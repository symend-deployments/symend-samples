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
    ///  Class for testing SegmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SegmentsApiTests : IDisposable
    {
        private SegmentsApi instance;

        public SegmentsApiTests()
        {
            instance = new SegmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SegmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SegmentsApi
            //Assert.IsType<SegmentsApi>(instance);
        }

        /// <summary>
        /// Test CopySegment
        /// </summary>
        [Fact]
        public void CopySegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //Guid xSymOrganizationId = null;
            //string status = null;
            //SegmentCloneForm segmentCloneForm = null;
            //var response = instance.CopySegment(id, xSymOrganizationId, status, segmentCloneForm);
            //Assert.IsType<SegmentModelResultModel>(response);
        }

        /// <summary>
        /// Test CreateSegment
        /// </summary>
        [Fact]
        public void CreateSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid xSymOrganizationId = null;
            //SegmentForm segmentForm = null;
            //var response = instance.CreateSegment(xSymOrganizationId, segmentForm);
            //Assert.IsType<SegmentModelResultModel>(response);
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

        /// <summary>
        /// Test GetSegment
        /// </summary>
        [Fact]
        public void GetSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //Guid xSymOrganizationId = null;
            //var response = instance.GetSegment(id, xSymOrganizationId);
            //Assert.IsType<SegmentModelResultModel>(response);
        }

        /// <summary>
        /// Test GetSegmentRevision
        /// </summary>
        [Fact]
        public void GetSegmentRevisionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //Guid xSymOrganizationId = null;
            //string status = null;
            //var response = instance.GetSegmentRevision(id, xSymOrganizationId, status);
            //Assert.IsType<SegmentRevisionModelResultModel>(response);
        }

        /// <summary>
        /// Test ListSegments
        /// </summary>
        [Fact]
        public void ListSegmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid xSymOrganizationId = null;
            //int? limit = null;
            //string direction = null;
            //string orderByAttribute = null;
            //string orderByLastValue = null;
            //Guid? cursor = null;
            //var response = instance.ListSegments(xSymOrganizationId, limit, direction, orderByAttribute, orderByLastValue, cursor);
            //Assert.IsType<SegmentGuidPagedModel>(response);
        }

        /// <summary>
        /// Test PublishSegment
        /// </summary>
        [Fact]
        public void PublishSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //Guid xSymOrganizationId = null;
            //var response = instance.PublishSegment(id, xSymOrganizationId);
            //Assert.IsType<SegmentModelResultModel>(response);
        }

        /// <summary>
        /// Test UpdateSegment
        /// </summary>
        [Fact]
        public void UpdateSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //Guid xSymOrganizationId = null;
            //SegmentForm segmentForm = null;
            //var response = instance.UpdateSegment(id, xSymOrganizationId, segmentForm);
            //Assert.IsType<SegmentModelResultModel>(response);
        }
    }
}
