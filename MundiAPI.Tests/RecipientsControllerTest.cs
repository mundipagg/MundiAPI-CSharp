/*
 * MundiAPI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities; 
using MundiAPI.PCL.Http.Client;
using MundiAPI.PCL.Http.Response;
using MundiAPI.Tests.Helpers;
using NUnit.Framework;
using MundiAPI.PCL;
using MundiAPI.PCL.Controllers;
using MundiAPI.PCL.Exceptions;

namespace MundiAPI.Tests
{
    [TestFixture]
    public class RecipientsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static RecipientsController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Recipients;
        }

        /// <summary>
        /// Retrieves paginated recipients information 
        /// </summary>
        [Test]
        public async Task TestTestGetRecipients() 
        {
            // Parameters for the API call
            int? page = null;
            int? size = null;

            // Perform API call
            PCL.Models.RecipientsResponse result = null;

            try
            {
                result = await controller.GetRecipientsAsync(page, size);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}