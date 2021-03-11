using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;
using System.Collections.Generic;

namespace CloudProvider.Api.ViewModels.AzureViewModels
{
    public class CreateAzureViewModel : CreateViewModel
    {
        public override CreateCloudServiceProviderModel ToCreateCloudServiceProviderModel()
        {
            return new CreateCloudServiceProviderModel(CloudServiceProvidersEnum.Azure, InfrastructureName, ResourceType, ResourceContent);
        }
    }
}
