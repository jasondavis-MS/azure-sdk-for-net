// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_BatchAccountDetectorCollection
    {
        // ListDetectors
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDetectors()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2022-10-01/examples/DetectorList.json
            // this example is just showing the usage of "BatchAccount_ListDetectors" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountDetectorResource
            BatchAccountDetectorCollection collection = batchAccount.GetBatchAccountDetectors();

            // invoke the operation and iterate over the result
            await foreach (BatchAccountDetectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BatchAccountDetectorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetDetector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDetector()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2022-10-01/examples/DetectorGet.json
            // this example is just showing the usage of "BatchAccount_GetDetector" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountDetectorResource
            BatchAccountDetectorCollection collection = batchAccount.GetBatchAccountDetectors();

            // invoke the operation
            string detectorId = "poolsAndNodes";
            BatchAccountDetectorResource result = await collection.GetAsync(detectorId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountDetectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetDetector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDetector()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2022-10-01/examples/DetectorGet.json
            // this example is just showing the usage of "BatchAccount_GetDetector" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountDetectorResource
            BatchAccountDetectorCollection collection = batchAccount.GetBatchAccountDetectors();

            // invoke the operation
            string detectorId = "poolsAndNodes";
            bool result = await collection.ExistsAsync(detectorId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
