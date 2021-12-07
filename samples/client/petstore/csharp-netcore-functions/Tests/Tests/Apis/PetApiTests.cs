/*
 * OpenAPI Petstore
 *
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * The version of the OpenAPI document: 1.0.0
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

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Apis;
// uncomment below to import models
//using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing PetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PetApiTests : IDisposable
    {
        private PetApi instance;

        public PetApiTests()
        {
            instance = new PetApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PetApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PetApi
            //Assert.IsType<PetApi>(instance);
        }

        /// <summary>
        /// Test AddPet
        /// </summary>
        [Fact]
        public void AddPetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Pet pet = null;
            //var response = instance.AddPet(pet);
            //Assert.IsType<Pet>(response);
        }

        /// <summary>
        /// Test DeletePet
        /// </summary>
        [Fact]
        public void DeletePetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long petId = null;
            //string apiKey = null;
            //instance.DeletePet(petId, apiKey);
        }

        /// <summary>
        /// Test FindPetsByStatus
        /// </summary>
        [Fact]
        public void FindPetsByStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> status = null;
            //var response = instance.FindPetsByStatus(status);
            //Assert.IsType<List<Pet>>(response);
        }

        /// <summary>
        /// Test FindPetsByTags
        /// </summary>
        [Fact]
        public void FindPetsByTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> tags = null;
            //var response = instance.FindPetsByTags(tags);
            //Assert.IsType<List<Pet>>(response);
        }

        /// <summary>
        /// Test GetPetById
        /// </summary>
        [Fact]
        public void GetPetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long petId = null;
            //var response = instance.GetPetById(petId);
            //Assert.IsType<Pet>(response);
        }

        /// <summary>
        /// Test UpdatePet
        /// </summary>
        [Fact]
        public void UpdatePetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Pet pet = null;
            //var response = instance.UpdatePet(pet);
            //Assert.IsType<Pet>(response);
        }

        /// <summary>
        /// Test UpdatePetWithForm
        /// </summary>
        [Fact]
        public void UpdatePetWithFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long petId = null;
            //string name = null;
            //string status = null;
            //instance.UpdatePetWithForm(petId, name, status);
        }

        /// <summary>
        /// Test UploadFile
        /// </summary>
        [Fact]
        public void UploadFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long petId = null;
            //string additionalMetadata = null;
            //System.IO.Stream file = null;
            //var response = instance.UploadFile(petId, additionalMetadata, file);
            //Assert.IsType<ApiResponse>(response);
        }
    }
}
