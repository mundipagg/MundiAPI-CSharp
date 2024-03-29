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
    public class TransfersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static TransfersController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Transfers;
        }

        /// <summary>
        /// Gets all transfers 
        /// </summary>
        [Test]
        public async Task TestTestGetTransfers1() 
        {

            // Perform API call
            PCL.Models.ListTransfers result = null;

            try
            {
                result = await controller.GetTransfers1Async();
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