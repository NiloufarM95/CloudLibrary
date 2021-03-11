using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;
using System.Collections.Generic;

namespace CloudProvider.Api.ViewModels
{
    public abstract class CloudServiceProviderViewModel
    {
        public string InfrastructureName { get; set; }
    }

    public abstract class CreateViewModel : CloudServiceProviderViewModel
    {
        public ResourceTypesEnum ResourceType { get; set; }
        public IDictionary<string, string> ResourceContent { get; set; }

        public abstract CreateCloudServiceProviderModel ToCreateCloudServiceProviderModel();


    }

    public abstract class DeleteViewModel : CloudServiceProviderViewModel
    {
        public abstract DeleteCloudServiceProviderModel ToDeleteCloudServiceProviderModel();
    }
}
