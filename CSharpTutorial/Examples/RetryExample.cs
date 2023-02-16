using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTutorial.Examples
{
    public class RetryExample
    {
        //Use Polly package : https://www.youtube.com/watch?v=nJH0PC2Pubs&ab_channel=NickChapsas or do it manually
        public async Task ApiMethod() 
        {
            //string clientName = string.Empty;
            //int retryCount = 0;
            
            //var repsone = client.getAsync("");

            //Start:
            //try
            //{
            //    if(retryCount >= 5)
            //    { 
            //        return bad stuff
            //    }

            //    await Task.Delay(1000);
            //    retryCount++;
            //    goto Start;
            //}
            //catch (HttpRequestException ex)
            //{
            //    await Task.Delay(1000);
            //    retryCount++;
            //    goto Start;
            //}
        }

        public void TestMethod() {


            bool result = false;

            int retryCount = 0;

            Start:

            try
            {
                if (retryCount <= 3)
                {
                    Thread.Sleep(1000);
                    retryCount++;
                    goto Start;
                }
            }
            catch(Exception ex) {
            }
        }
    }
}
