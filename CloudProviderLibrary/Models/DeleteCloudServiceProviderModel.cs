using System;
using System.Collections.Generic;
using System.Text;
using CloudProviderLibrary.Enums;

namespace CloudProviderLibrary.Models
{
    public class DeleteCloudServiceProviderModel
    {
        public CloudServiceProvidersEnum CloudProvider { get; }
        public string InfrastructureName { get; }

        public DeleteCloudServiceProviderModel(CloudServiceProvidersEnum cloudProvider, string infrastructureName)
        {
            CloudProvider = cloudProvider;
            InfrastructureName = infrastructureName;
        }
    }
}
