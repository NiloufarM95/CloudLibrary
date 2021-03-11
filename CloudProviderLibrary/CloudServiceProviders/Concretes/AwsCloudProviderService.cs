using System;
using System.Collections.Generic;
using System.Text;
using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Models;

namespace CloudProviderLibrary.CloudServiceProviders.Concretes
{
    public class AwsCloudProviderService:ICloudServiceProvider
    {
        // You can write suitable implementation for the specific provider here
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
