using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels
{
    public class CloudServiceProviderViewModel
    {
        public CloudServiceProvidersEnum CloudProvider { get; set; }
        public string InfrastructureName { get; set; }
    }

    public class CreateViewModel:CloudServiceProviderViewModel
    {
        public ResourceTypesEnum ResourceType { get; set; }
        public IDictionary<string, string> ResourceContent { get; set; }

        public virtual CreateCloudServiceProviderModel ToModel(CreateViewModel model)
        {
            return new CreateCloudServiceProviderModel(
                model.CloudProvider,
                model.InfrastructureName,
                model.ResourceType,
                model.ResourceContent);
        }
    }

    public class DeleteViewModel:CloudServiceProviderViewModel
    {
        public virtual DeleteCloudServiceProviderModel ToModel(DeleteViewModel model) => new DeleteCloudServiceProviderModel(model.CloudProvider, model.InfrastructureName);
    }
}
