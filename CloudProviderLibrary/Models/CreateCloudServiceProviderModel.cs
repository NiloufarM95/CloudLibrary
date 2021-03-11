using System;
using System.Collections.Generic;
using System.Text;
using CloudProviderLibrary.Enums;

namespace CloudProviderLibrary.Models
{
    public class CreateCloudServiceProviderModel
    {
        public CloudServiceProvidersEnum CloudProvider { get; }
        public string InfrastructureName { get; }
        public ResourceTypesEnum ResourceType { get; }
        public IDictionary<string, string> ResourceContent { get; }

        public CreateCloudServiceProviderModel(
            CloudServiceProvidersEnum cloudProvider,
            string infrastructureName,
            ResourceTypesEnum resourceType,
            IDictionary<string, string> resourceContent)
        {
            CloudProvider = cloudProvider;
            InfrastructureName = infrastructureName;
            ResourceType = resourceType;
            ResourceContent = resourceContent;
        }
    }
}
