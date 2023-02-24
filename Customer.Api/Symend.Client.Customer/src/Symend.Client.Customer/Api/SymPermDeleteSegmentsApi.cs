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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Symend.Client.Customer.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISymPermDeleteSegmentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete Segment
        /// </summary>
        /// <remarks>
        /// Delete a segment by its ID. Segment cannot be in a published state.
        /// </remarks>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Segment Id</param>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteSegment(Guid id, Guid xSymOrganizationId, int operationIndex = 0);

        /// <summary>
        /// Delete Segment
        /// </summary>
        /// <remarks>
        /// Delete a segment by its ID. Segment cannot be in a published state.
        /// </remarks>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Segment Id</param>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSegmentWithHttpInfo(Guid id, Guid xSymOrganizationId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISymPermDeleteSegmentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Delete Segment
        /// </summary>
        /// <remarks>
        /// Delete a segment by its ID. Segment cannot be in a published state.
        /// </remarks>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Segment Id</param>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSegmentAsync(Guid id, Guid xSymOrganizationId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete Segment
        /// </summary>
        /// <remarks>
        /// Delete a segment by its ID. Segment cannot be in a published state.
        /// </remarks>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Segment Id</param>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSegmentWithHttpInfoAsync(Guid id, Guid xSymOrganizationId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISymPermDeleteSegmentsApi : ISymPermDeleteSegmentsApiSync, ISymPermDeleteSegmentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SymPermDeleteSegmentsApi : ISymPermDeleteSegmentsApi
    {
        private Symend.Client.Customer.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SymPermDeleteSegmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SymPermDeleteSegmentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SymPermDeleteSegmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SymPermDeleteSegmentsApi(string basePath)
        {
            this.Configuration = Symend.Client.Customer.Client.Configuration.MergeConfigurations(
                Symend.Client.Customer.Client.GlobalConfiguration.Instance,
                new Symend.Client.Customer.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Symend.Client.Customer.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Symend.Client.Customer.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Symend.Client.Customer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SymPermDeleteSegmentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SymPermDeleteSegmentsApi(Symend.Client.Customer.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Symend.Client.Customer.Client.Configuration.MergeConfigurations(
                Symend.Client.Customer.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Symend.Client.Customer.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Symend.Client.Customer.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Symend.Client.Customer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SymPermDeleteSegmentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SymPermDeleteSegmentsApi(Symend.Client.Customer.Client.ISynchronousClient client, Symend.Client.Customer.Client.IAsynchronousClient asyncClient, Symend.Client.Customer.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Symend.Client.Customer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Symend.Client.Customer.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Symend.Client.Customer.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Symend.Client.Customer.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Symend.Client.Customer.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Delete Segment Delete a segment by its ID. Segment cannot be in a published state.
        /// </summary>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Segment Id</param>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteSegment(Guid id, Guid xSymOrganizationId, int operationIndex = 0)
        {
            DeleteSegmentWithHttpInfo(id, xSymOrganizationId);
        }

        /// <summary>
        /// Delete Segment Delete a segment by its ID. Segment cannot be in a published state.
        /// </summary>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Segment Id</param>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Symend.Client.Customer.Client.ApiResponse<Object> DeleteSegmentWithHttpInfo(Guid id, Guid xSymOrganizationId, int operationIndex = 0)
        {
            Symend.Client.Customer.Client.RequestOptions localVarRequestOptions = new Symend.Client.Customer.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Symend.Client.Customer.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Symend.Client.Customer.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Symend.Client.Customer.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("X-Sym-OrganizationId", Symend.Client.Customer.Client.ClientUtils.ParameterToString(xSymOrganizationId)); // header parameter

            localVarRequestOptions.Operation = "SymPermDeleteSegmentsApi.DeleteSegment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JSON_Web_Token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/v1/segments/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteSegment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete Segment Delete a segment by its ID. Segment cannot be in a published state.
        /// </summary>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Segment Id</param>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSegmentAsync(Guid id, Guid xSymOrganizationId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteSegmentWithHttpInfoAsync(id, xSymOrganizationId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete Segment Delete a segment by its ID. Segment cannot be in a published state.
        /// </summary>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Segment Id</param>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Symend.Client.Customer.Client.ApiResponse<Object>> DeleteSegmentWithHttpInfoAsync(Guid id, Guid xSymOrganizationId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Symend.Client.Customer.Client.RequestOptions localVarRequestOptions = new Symend.Client.Customer.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Symend.Client.Customer.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Symend.Client.Customer.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Symend.Client.Customer.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("X-Sym-OrganizationId", Symend.Client.Customer.Client.ClientUtils.ParameterToString(xSymOrganizationId)); // header parameter

            localVarRequestOptions.Operation = "SymPermDeleteSegmentsApi.DeleteSegment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JSON_Web_Token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/v1/segments/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteSegment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
