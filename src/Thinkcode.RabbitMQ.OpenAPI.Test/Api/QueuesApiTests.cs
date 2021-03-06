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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Thinkcode.RabbitMQ.OpenAPI.Client;
using Thinkcode.RabbitMQ.OpenAPI.Api;
using Thinkcode.RabbitMQ.OpenAPI.Model;

namespace Thinkcode.RabbitMQ.OpenAPI.Test
{
    /// <summary>
    ///  Class for testing QueuesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class QueuesApiTests : IDisposable
    {
        private QueuesApi instance;

        public QueuesApiTests()
        {
            instance = new QueuesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QueuesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' QueuesApi
            //Assert.IsType(typeof(QueuesApi), instance, "instance is a QueuesApi");
        }

        
        /// <summary>
        /// Test ConsumeMessage
        /// </summary>
        [Fact]
        public void ConsumeMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string queue = null;
            //ConsumeRequest body = null;
            //var response = instance.ConsumeMessage(vhost, queue, body);
            //Assert.IsType<List<ConsumeResponse>> (response, "response is List<ConsumeResponse>");
        }
        
        /// <summary>
        /// Test CreateQueue
        /// </summary>
        [Fact]
        public void CreateQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string queue = null;
            //QueueRequest body = null;
            //instance.CreateQueue(vhost, queue, body);
            
        }
        
        /// <summary>
        /// Test CreateQueueActions
        /// </summary>
        [Fact]
        public void CreateQueueActionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string queue = null;
            //QueueAction body = null;
            //instance.CreateQueueActions(vhost, queue, body);
            
        }
        
        /// <summary>
        /// Test DeleteQueue
        /// </summary>
        [Fact]
        public void DeleteQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string queue = null;
            //bool? ifEmpty = null;
            //bool? ifUnused = null;
            //instance.DeleteQueue(vhost, queue, ifEmpty, ifUnused);
            
        }
        
        /// <summary>
        /// Test DeleteQueueContents
        /// </summary>
        [Fact]
        public void DeleteQueueContentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string queue = null;
            //instance.DeleteQueueContents(vhost, queue);
            
        }
        
        /// <summary>
        /// Test GetQueue
        /// </summary>
        [Fact]
        public void GetQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string queue = null;
            //var response = instance.GetQueue(vhost, queue);
            //Assert.IsType<Queue> (response, "response is Queue");
        }
        
        /// <summary>
        /// Test ListBindingsForQueue
        /// </summary>
        [Fact]
        public void ListBindingsForQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //string queue = null;
            //var response = instance.ListBindingsForQueue(vhost, queue);
            //Assert.IsType<List<Binding>> (response, "response is List<Binding>");
        }
        
        /// <summary>
        /// Test ListQueues
        /// </summary>
        [Fact]
        public void ListQueuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListQueues();
            //Assert.IsType<List<Queue>> (response, "response is List<Queue>");
        }
        
        /// <summary>
        /// Test ListQueuesForVirtualHost
        /// </summary>
        [Fact]
        public void ListQueuesForVirtualHostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vhost = null;
            //var response = instance.ListQueuesForVirtualHost(vhost);
            //Assert.IsType<List<Queue>> (response, "response is List<Queue>");
        }
        
    }

}
