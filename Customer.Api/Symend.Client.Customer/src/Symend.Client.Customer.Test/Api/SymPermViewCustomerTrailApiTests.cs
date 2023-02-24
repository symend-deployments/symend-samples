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
    ///  Class for testing SymPermViewCustomerTrailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SymPermViewCustomerTrailApiTests : IDisposable
    {
        private SymPermViewCustomerTrailApi instance;

        public SymPermViewCustomerTrailApiTests()
        {
            instance = new SymPermViewCustomerTrailApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SymPermViewCustomerTrailApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SymPermViewCustomerTrailApi
            //Assert.IsType<SymPermViewCustomerTrailApi>(instance);
        }

        /// <summary>
        /// Test GetAttributeValuesByEventId
        /// </summary>
        [Fact]
        public void GetAttributeValuesByEventIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventId = null;
            //var response = instance.GetAttributeValuesByEventId(eventId);
            //Assert.IsType<CustomerTrailEventAttributeValueResultModel>(response);
        }

        /// <summary>
        /// Test GetCustomerEventsByAccountKey
        /// </summary>
        [Fact]
        public void GetCustomerEventsByAccountKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid xSymOrganizationId = null;
            //string accountKey = null;
            //GetCustomerTrailEventsForAccountSearchParameterParameter searchParameter = null;
            //GuidPagedMetadata paging = null;
            //var response = instance.GetCustomerEventsByAccountKey(xSymOrganizationId, accountKey, searchParameter, paging);
            //Assert.IsType<CustomerTrailEventPagedModel>(response);
        }

        /// <summary>
        /// Test GetCustomerEventsByAccountKeyOrderByDateTime
        /// </summary>
        [Fact]
        public void GetCustomerEventsByAccountKeyOrderByDateTimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid xSymOrganizationId = null;
            //string accountKey = null;
            //string interval = null;
            //GuidPagedMetadata paging = null;
            //GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter searchParameter = null;
            //var response = instance.GetCustomerEventsByAccountKeyOrderByDateTime(xSymOrganizationId, accountKey, interval, paging, searchParameter);
            //Assert.IsType<CustomerTrailEventPagedModelV2>(response);
        }

        /// <summary>
        /// Test GetCustomerTrailEventsForAccount
        /// </summary>
        [Fact]
        public void GetCustomerTrailEventsForAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Guid xSymOrganizationId = null;
            //GetCustomerTrailEventsForAccountSearchParameterParameter searchParameter = null;
            //GuidPagedMetadata paging = null;
            //var response = instance.GetCustomerTrailEventsForAccount(id, xSymOrganizationId, searchParameter, paging);
            //Assert.IsType<CustomerTrailEventPagedModel>(response);
        }

        /// <summary>
        /// Test GetCustomerTrailEventsForAccountPagedDateTime
        /// </summary>
        [Fact]
        public void GetCustomerTrailEventsForAccountPagedDateTimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Guid xSymOrganizationId = null;
            //string interval = null;
            //GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter searchParameter = null;
            //var response = instance.GetCustomerTrailEventsForAccountPagedDateTime(id, xSymOrganizationId, interval, searchParameter);
            //Assert.IsType<CustomerTrailEventPagedModelV2>(response);
        }
    }
}