/*
 * Customer Service API
 *
 * API for Customer Domain Operations
 *
 * The version of the OpenAPI document: v1
 * Contact: support@symend.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Symend.Client.Customer.Client;
using Symend.Client.Customer.Api;
// uncomment below to import models
//using Symend.Client.Customer.Model;

namespace Symend.Client.Customer.Test.Api
{
    /// <summary>
    ///  Class for testing SymPermDeleteSegmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SymPermDeleteSegmentsApiTests : IDisposable
    {
        private SymPermDeleteSegmentsApi instance;

        public SymPermDeleteSegmentsApiTests()
        {
            instance = new SymPermDeleteSegmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SymPermDeleteSegmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SymPermDeleteSegmentsApi
            //Assert.IsType<SymPermDeleteSegmentsApi>(instance);
        }

        /// <summary>
        /// Test DeleteSegment
        /// </summary>
        [Fact]
        public void DeleteSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //Guid xSymOrganizationId = null;
            //instance.DeleteSegment(id, xSymOrganizationId);
        }
    }
}