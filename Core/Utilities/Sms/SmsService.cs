using System.Net;
using System.Text;
using Core.Business.Abstract;
using Microsoft.Extensions.Configuration;
using Core.Entities.Concrete.Sms;
using Newtonsoft.Json;

namespace Core.Utilities.Sms
{
    public class SmsService:ISmsService
    {   public IConfiguration Configuration { get; }
        private SmsRequest smsRequest;
        private SmsOptions smsOptions;
        public SmsService(IConfiguration configuration)
        {
            Configuration = configuration;
            smsOptions = Configuration.GetSection("SmsOptions").Get<SmsOptions>();
        }

        public string SendSms(string Text,string[] Numbers)
        {
            try
            {
                smsRequest.Request.Authentication.Key = smsOptions.Key;
                smsRequest.Request.Authentication.Hash = smsOptions.Hash;
                smsRequest.Order.Iys = smsOptions.Iys;
                smsRequest.Order.IysList = smsOptions.IysList;
                smsRequest.Order.Sender = smsOptions.Sender;
                smsRequest.Order.Message.Text = Text;
                smsRequest.Order.Message.Receipents.Numbers = Numbers;
                var res = "";
                byte[] bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(smsRequest));
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(smsOptions.ApiUrl);
                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = "text/json";
                request.Timeout = 300000000;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }

                using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        string message = String.Format(
                            "POST failed. Received HTTP {0}",
                            response.StatusCode);
                        throw new ApplicationException(message);
                    }

                    Stream responseStream = response.GetResponseStream();
                    using (StreamReader rdr = new StreamReader(responseStream))
                    {
                        res = rdr.ReadToEnd();
                    }

                    return res;
                }
            }
            catch
            {
                return "-1";
            }


        }

    }
}

