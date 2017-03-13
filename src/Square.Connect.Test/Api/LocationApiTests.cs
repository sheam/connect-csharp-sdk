/* 
 * Square Connect API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Square.Connect.Client;
using Square.Connect.Api;
using Square.Connect.Model;

namespace Square.Connect.Test
{
    /// <summary>
    ///  Class for testing LocationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocationApiTests
    {
        private LocationApi instance;
        private TestAccounts testAccounts;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationApi();
            testAccounts = new TestAccounts();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<LocationApi>(instance, "instance is not type of LocationApi");
        }

        
        /// <summary>
        /// Test ListLocations
        /// </summary>
        [Test]
        public void ListLocationsTest()
        {
            var sandboxAccount = testAccounts["US-Prod-Sandbox"];
            var authorization = sandboxAccount.AccessToken;
            var response = instance.ListLocations(authorization);
            var firstLocation = response.Locations.First();

            Assert.IsInstanceOf<ListLocationsResponse> (response, "response type is not ListLocationsResponse.");
            Assert.IsInstanceOf<Location> (firstLocation, "response element type is not Location.");
            Assert.AreEqual("CBASEEffqN8pnVNXwoCL0dSGMVAgAQ", firstLocation.Id, "first location id doesn't match.");
        }
        
    }

}
