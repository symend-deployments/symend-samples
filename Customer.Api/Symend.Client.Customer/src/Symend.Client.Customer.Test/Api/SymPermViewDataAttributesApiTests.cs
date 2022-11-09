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
    ///  Class for testing SymPermViewDataAttributesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SymPermViewDataAttributesApiTests : IDisposable
    {
        private SymPermViewDataAttributesApi instance;

        public SymPermViewDataAttributesApiTests()
        {
            instance = new SymPermViewDataAttributesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SymPermViewDataAttributesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SymPermViewDataAttributesApi
            //Assert.IsType<SymPermViewDataAttributesApi>(instance);
        }

        /// <summary>
        /// Test GetDataCategories
        /// </summary>
        [Fact]
        public void GetDataCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid xSymOrganizationId = null;
            //var response = instance.GetDataCategories(xSymOrganizationId);
            //Assert.IsType<StringIEnumerableResultModel>(response);
        }

        /// <summary>
        /// Test GetDataTargetDefinition
        /// </summary>
        [Fact]
        public void GetDataTargetDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid dataTargetDefinitionId = null;
            //Guid xSymOrganizationId = null;
            //var response = instance.GetDataTargetDefinition(dataTargetDefinitionId, xSymOrganizationId);
            //Assert.IsType<DataTargetDefinitionModelResultModel>(response);
        }

        /// <summary>
        /// Test GetDataTargetDefinitions
        /// </summary>
        [Fact]
        public void GetDataTargetDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid xSymOrganizationId = null;
            //GetDataTargetDefinitionsDataTargetDefinitionSearchCriteriaParameter dataTargetDefinitionSearchCriteria = null;
            //GuidPagedMetadata paging = null;
            //var response = instance.GetDataTargetDefinitions(xSymOrganizationId, dataTargetDefinitionSearchCriteria, paging);
            //Assert.IsType<DataTargetDefinitionSearchResultGuidPagedModel>(response);
        }

        /// <summary>
        /// Test GetDataTargetDefinitionsDictionary
        /// </summary>
        [Fact]
        public void GetDataTargetDefinitionsDictionaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid xSymOrganizationId = null;
            //var response = instance.GetDataTargetDefinitionsDictionary(xSymOrganizationId);
            //Assert.IsType<GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel>(response);
        }
    }
}
