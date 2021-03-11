using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudProviderLibrary.CloudServiceProviders.Concretes
{
    public abstract class CloudProviderService : ICloudServiceProvider
    {
        public void CreateCloudInfrastructure(CreateCloudServiceProviderModel model)
        {
            CloudServiceProviderUtils.CreateCloudInfrastructure(model);
        }

        public void DeleteCloudInfrastructure(DeleteCloudServiceProviderModel model)
        {
            CloudServiceProviderUtils.DeleteCloudInfrastructure(model);
        }
    }
}
