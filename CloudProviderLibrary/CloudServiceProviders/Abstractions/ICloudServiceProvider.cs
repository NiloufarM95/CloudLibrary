using System;
using System.Collections.Generic;
using System.Text;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProviderLibrary.CloudServiceProviders.Abstractions
{
    public interface ICloudServiceProvider
    {
        void CreateCloudInfrastructure(CreateCloudServiceProviderModel model);
        void DeleteCloudInfrastructure(DeleteCloudServiceProviderModel model);
    }
}
