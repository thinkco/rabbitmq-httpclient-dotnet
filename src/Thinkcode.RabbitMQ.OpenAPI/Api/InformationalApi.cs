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
    public interface IInformationalApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Read Cluster Name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClusterName</returns>
        ClusterName GetClusterName ();

        /// <summary>
        /// Read Cluster Name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClusterName</returns>
        ApiResponse<ClusterName> GetClusterNameWithHttpInfo ();
        /// <summary>
        /// Get Definitions for VHost
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <returns>Definition</returns>
        Definition GetDefinitionsForVirtualHost (string vhost);

        /// <summary>
        /// Get Definitions for VHost
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <returns>ApiResponse of Definition</returns>
        ApiResponse<Definition> GetDefinitionsForVirtualHostWithHttpInfo (string vhost);
        /// <summary>
        /// Get Overview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Overview</returns>
        Overview GetOverview ();

        /// <summary>
        /// Get Overview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Overview</returns>
        ApiResponse<Overview> GetOverviewWithHttpInfo ();
        /// <summary>
        /// List Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Definition</returns>
        Definition ListDefinitions ();

        /// <summary>
        /// List Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Definition</returns>
        ApiResponse<Definition> ListDefinitionsWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInformationalApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Read Cluster Name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ClusterName</returns>
        System.Threading.Tasks.Task<ClusterName> GetClusterNameAsync ();

        /// <summary>
        /// Read Cluster Name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ClusterName)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClusterName>> GetClusterNameAsyncWithHttpInfo ();
        /// <summary>
        /// Get Definitions for VHost
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <returns>Task of Definition</returns>
        System.Threading.Tasks.Task<Definition> GetDefinitionsForVirtualHostAsync (string vhost);

        /// <summary>
        /// Get Definitions for VHost
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <returns>Task of ApiResponse (Definition)</returns>
        System.Threading.Tasks.Task<ApiResponse<Definition>> GetDefinitionsForVirtualHostAsyncWithHttpInfo (string vhost);
        /// <summary>
        /// Get Overview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Overview</returns>
        System.Threading.Tasks.Task<Overview> GetOverviewAsync ();

        /// <summary>
        /// Get Overview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Overview)</returns>
        System.Threading.Tasks.Task<ApiResponse<Overview>> GetOverviewAsyncWithHttpInfo ();
        /// <summary>
        /// List Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Definition</returns>
        System.Threading.Tasks.Task<Definition> ListDefinitionsAsync ();

        /// <summary>
        /// List Definitions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Definition)</returns>
        System.Threading.Tasks.Task<ApiResponse<Definition>> ListDefinitionsAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInformationalApi : IInformationalApiSync, IInformationalApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InformationalApi : IInformationalApi
    {
        private Thinkcode.RabbitMQ.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InformationalApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InformationalApi(String basePath)
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
        /// Initializes a new instance of the <see cref="InformationalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InformationalApi(Thinkcode.RabbitMQ.OpenAPI.Client.Configuration configuration)
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
        public InformationalApi(Thinkcode.RabbitMQ.OpenAPI.Client.ISynchronousClient client,Thinkcode.RabbitMQ.OpenAPI.Client.IAsynchronousClient asyncClient, Thinkcode.RabbitMQ.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// Read Cluster Name 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClusterName</returns>
        public ClusterName GetClusterName ()
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<ClusterName> localVarResponse = GetClusterNameWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Cluster Name 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClusterName</returns>
        public Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse< ClusterName > GetClusterNameWithHttpInfo ()
        {
            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = this.Client.Get< ClusterName >("/cluster-name", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetClusterName", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Read Cluster Name 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ClusterName</returns>
        public async System.Threading.Tasks.Task<ClusterName> GetClusterNameAsync ()
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<ClusterName> localVarResponse = await GetClusterNameAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read Cluster Name 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ClusterName)</returns>
        public async System.Threading.Tasks.Task<Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<ClusterName>> GetClusterNameAsyncWithHttpInfo ()
        {

            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<ClusterName>("/cluster-name", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetClusterName", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get Definitions for VHost 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <returns>Definition</returns>
        public Definition GetDefinitionsForVirtualHost (string vhost)
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Definition> localVarResponse = GetDefinitionsForVirtualHostWithHttpInfo(vhost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Definitions for VHost 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <returns>ApiResponse of Definition</returns>
        public Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse< Definition > GetDefinitionsForVirtualHostWithHttpInfo (string vhost)
        {
            // verify the required parameter 'vhost' is set
            if (vhost == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'vhost' when calling InformationalApi->GetDefinitionsForVirtualHost");

            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
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

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = this.Client.Get< Definition >("/definitions/{vhost}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetDefinitionsForVirtualHost", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get Definitions for VHost 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <returns>Task of Definition</returns>
        public async System.Threading.Tasks.Task<Definition> GetDefinitionsForVirtualHostAsync (string vhost)
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Definition> localVarResponse = await GetDefinitionsForVirtualHostAsyncWithHttpInfo(vhost);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Definitions for VHost 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vhost"></param>
        /// <returns>Task of ApiResponse (Definition)</returns>
        public async System.Threading.Tasks.Task<Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Definition>> GetDefinitionsForVirtualHostAsyncWithHttpInfo (string vhost)
        {
            // verify the required parameter 'vhost' is set
            if (vhost == null)
                throw new Thinkcode.RabbitMQ.OpenAPI.Client.ApiException(400, "Missing required parameter 'vhost' when calling InformationalApi->GetDefinitionsForVirtualHost");


            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
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

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<Definition>("/definitions/{vhost}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetDefinitionsForVirtualHost", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get Overview 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Overview</returns>
        public Overview GetOverview ()
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Overview> localVarResponse = GetOverviewWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Overview 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Overview</returns>
        public Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse< Overview > GetOverviewWithHttpInfo ()
        {
            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = this.Client.Get< Overview >("/overview", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetOverview", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get Overview 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Overview</returns>
        public async System.Threading.Tasks.Task<Overview> GetOverviewAsync ()
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Overview> localVarResponse = await GetOverviewAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Overview 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Overview)</returns>
        public async System.Threading.Tasks.Task<Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Overview>> GetOverviewAsyncWithHttpInfo ()
        {

            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<Overview>("/overview", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetOverview", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// List Definitions 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Definition</returns>
        public Definition ListDefinitions ()
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Definition> localVarResponse = ListDefinitionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Definitions 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Definition</returns>
        public Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse< Definition > ListDefinitionsWithHttpInfo ()
        {
            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = this.Client.Get< Definition >("/definitions", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ListDefinitions", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// List Definitions 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Definition</returns>
        public async System.Threading.Tasks.Task<Definition> ListDefinitionsAsync ()
        {
             Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Definition> localVarResponse = await ListDefinitionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Definitions 
        /// </summary>
        /// <exception cref="Thinkcode.RabbitMQ.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Definition)</returns>
        public async System.Threading.Tasks.Task<Thinkcode.RabbitMQ.OpenAPI.Client.ApiResponse<Definition>> ListDefinitionsAsyncWithHttpInfo ()
        {

            Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions requestOptions = new Thinkcode.RabbitMQ.OpenAPI.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            

            // authentication (basic_auth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
                requestOptions.HeaderParameters.Add("X-Auth-Fallback", "Basic " + Thinkcode.RabbitMQ.OpenAPI.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<Definition>("/definitions", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ListDefinitions", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
