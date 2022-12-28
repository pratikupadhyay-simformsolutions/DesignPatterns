using Polly;
using System;
using System.Net.Http;

namespace CircuitBreaker.Weather
{
    public static class CircuitBreakerActions
    {
        public static void OnHalfOpen()
        {
            Console.WriteLine("Circuit in test mode, one request will be allowed.");
        }

        public static void OnReset()
        {
            Console.WriteLine("Circuit closed, requests flow normally.");
        }

        public static void OnBreak(DelegateResult<HttpResponseMessage> result, TimeSpan ts)
        {
            Console.WriteLine("Circuit cut, requests will not flow.");
        }
    }
}
