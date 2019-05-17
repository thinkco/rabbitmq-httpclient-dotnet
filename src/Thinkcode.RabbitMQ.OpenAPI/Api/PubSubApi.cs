/* 
 * Rabbitmq Http API
 *
 * This is the OpenAPI specification of the RabbitMQ HTTP API. For more information, please refer to [HTTP API](https://cdn.rawgit.com/rabbitmq/rabbitmq-management/v3.7.14/priv/www/api/index.html) official documentation.
 *
 * OpenAPI spec version: 1.0
 * Contact: carlos@adaptive.me
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Thinkcode.RabbitMQ.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPubSubApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Consume Message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="queue"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;ConsumeResponse&gt;</returns>
        List<ConsumeResponse> ConsumeMessage (string vhost, string queue, ConsumeRequest body = null);

        /// <summary>
        /// Consume Message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="queue"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ConsumeResponse&gt;</returns>
        ApiResponse<List<ConsumeResponse>> ConsumeMessageWithHttpInfo (string vhost, string queue, ConsumeRequest body = null);
        /// <summary>
        /// Publish Message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="exchange"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>PublishResponse</returns>
        PublishResponse PublishMessage (string vhost, string exchange, PublishRequest body = null);

        /// <summary>
        /// Publish Message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="exchange"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PublishResponse</returns>
        ApiResponse<PublishResponse> PublishMessageWithHttpInfo (string vhost, string exchange, PublishRequest body = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPubSubApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Consume Message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="queue"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;ConsumeResponse&gt;</returns>
        System.Threading.Tasks.Task<List<ConsumeResponse>> ConsumeMessageAsync (string vhost, string queue, ConsumeRequest body = null);

        /// <summary>
        /// Consume Message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="queue"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ConsumeResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ConsumeResponse>>> ConsumeMessageAsyncWithHttpInfo (string vhost, string queue, ConsumeRequest body = null);
        /// <summary>
        /// Publish Message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="exchange"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PublishResponse</returns>
        System.Threading.Tasks.Task<PublishResponse> PublishMessageAsync (string vhost, string exchange, PublishRequest body = null);

        /// <summary>
        /// Publish Message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="exchange"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PublishResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishResponse>> PublishMessageAsyncWithHttpInfo (string vhost, string exchange, PublishRequest body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPubSubApi : IPubSubApiSync, IPubSubApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PubSubApi : IPubSubApi
    {
        private Thinkcode.RabbitMQ.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PubSubApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PubSubApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PubSubApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PubSubApi(String basePath)
        {
            this.Configuration = Thinkcode.RabbitMQ.OpenAPI.Client.Configuration.MergeConfigurations(
                Thinkcode.RabbitMQ.OpenAPI.Client.GlobalConfiguration.Instance,
                new Thinkcode.RabbitMQ.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Thinkcode.RabbitMQ.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Thinkcode.RabbitMQ.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Thinkcode.RabbitMQ.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PubSubApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PubSubApi(Thinkcode.RabbitMQ.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Thinkcode.RabbitMQ.OpenAPI.Client.Configuration.MergeConfigurations(
                Thinkcode.RabbitMQ.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Thinkcode.RabbitMQ.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Thinkcode.RabbitMQ.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Thinkcode.RabbitMQ.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PubSubApi(Thinkcode.RabbitMQ.OpenAPI.Client.ISynchronousClient client,Thinkcode.RabbitMQ.OpenAPI.Client.IAsynchronousClient asyncClient, Thinkcode.RabbitMQ.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Thinkcode.RabbitMQ.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Thinkcode.RabbitMQ.OpenAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Thinkcode.RabbitMQ.OpenAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Thinkcode.RabbitMQ.OpenAPI.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Thinkcode.RabbitMQ.OpenAPI.Client.ExceptionFactory ExceptionFactory
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
        /// Consume Message 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="queue"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;ConsumeResponse&gt;</returns>
        public List<ConsumeResponse> ConsumeMessage (string vhost, string queue, ConsumeRequest body = null)
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<List<ConsumeResponse>> localVarResponse = ConsumeMessageWithHttpInfo(vhost, queue, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consume Message 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="queue"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ConsumeResponse&gt;</returns>
        public Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse< List<ConsumeResponse> > ConsumeMessageWithHttpInfo (string vhost, string queue, ConsumeRequest body = null)
        {
            // verify the required parameter 'vhost' is set
            if (vhost == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'vhost' when calling PubSubApi->ConsumeMessage");

            // verify the required parameter 'queue' is set
            if (queue == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'queue' when calling PubSubApi->ConsumeMessage");

            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (vhost != null)
                requestOptions.PathParameters.Add("vhost", Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.ParameterToString(vhost)); // path parameter
            if (queue != null)
                requestOptions.PathParameters.Add("queue", Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.ParameterToString(queue)); // path parameter
            requestOptions.Data = body;

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = this.Client.Post< List<ConsumeResponse> >("/queues/{vhost}/{queue}/get", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ConsumeMessage", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Consume Message 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="queue"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;ConsumeResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<ConsumeResponse>> ConsumeMessageAsync (string vhost, string queue, ConsumeRequest body = null)
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<List<ConsumeResponse>> localVarResponse = await ConsumeMessageAsyncWithHttpInfo(vhost, queue, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consume Message 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="queue"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ConsumeResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<List<ConsumeResponse>>> ConsumeMessageAsyncWithHttpInfo (string vhost, string queue, ConsumeRequest body = null)
        {
            // verify the required parameter 'vhost' is set
            if (vhost == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'vhost' when calling PubSubApi->ConsumeMessage");

            // verify the required parameter 'queue' is set
            if (queue == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'queue' when calling PubSubApi->ConsumeMessage");


            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (vhost != null)
                requestOptions.PathParameters.Add("vhost", Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.ParameterToString(vhost)); // path parameter
            if (queue != null)
                requestOptions.PathParameters.Add("queue", Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.ParameterToString(queue)); // path parameter
            requestOptions.Data = body;

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = await this.AsynchronousClient.PostAsync<List<ConsumeResponse>>("/queues/{vhost}/{queue}/get", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ConsumeMessage", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Publish Message 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="exchange"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>PublishResponse</returns>
        public PublishResponse PublishMessage (string vhost, string exchange, PublishRequest body = null)
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<PublishResponse> localVarResponse = PublishMessageWithHttpInfo(vhost, exchange, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish Message 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="exchange"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PublishResponse</returns>
        public Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse< PublishResponse > PublishMessageWithHttpInfo (string vhost, string exchange, PublishRequest body = null)
        {
            // verify the required parameter 'vhost' is set
            if (vhost == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'vhost' when calling PubSubApi->PublishMessage");

            // verify the required parameter 'exchange' is set
            if (exchange == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'exchange' when calling PubSubApi->PublishMessage");

            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (vhost != null)
                requestOptions.PathParameters.Add("vhost", Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.ParameterToString(vhost)); // path parameter
            if (exchange != null)
                requestOptions.PathParameters.Add("exchange", Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.ParameterToString(exchange)); // path parameter
            requestOptions.Data = body;

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = this.Client.Post< PublishResponse >("/exchanges/{vhost}/{exchange}/publish", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PublishMessage", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Publish Message 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="exchange"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PublishResponse</returns>
        public async System.Threading.Tasks.Task<PublishResponse> PublishMessageAsync (string vhost, string exchange, PublishRequest body = null)
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<PublishResponse> localVarResponse = await PublishMessageAsyncWithHttpInfo(vhost, exchange, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish Message 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <param name="exchange"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PublishResponse)</returns>
        public async System.Threading.Tasks.Task<Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<PublishResponse>> PublishMessageAsyncWithHttpInfo (string vhost, string exchange, PublishRequest body = null)
        {
            // verify the required parameter 'vhost' is set
            if (vhost == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'vhost' when calling PubSubApi->PublishMessage");

            // verify the required parameter 'exchange' is set
            if (exchange == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'exchange' when calling PubSubApi->PublishMessage");


            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (vhost != null)
                requestOptions.PathParameters.Add("vhost", Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.ParameterToString(vhost)); // path parameter
            if (exchange != null)
                requestOptions.PathParameters.Add("exchange", Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.ParameterToString(exchange)); // path parameter
            requestOptions.Data = body;

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = await this.AsynchronousClient.PostAsync<PublishResponse>("/exchanges/{vhost}/{exchange}/publish", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PublishMessage", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
