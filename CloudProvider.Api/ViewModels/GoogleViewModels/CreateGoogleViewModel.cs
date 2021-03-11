using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.GoogleViewModels
{
    public class CreateGoogleViewModel : CreateViewModel
    {
        public override CreateCloudServiceProviderModel ToCreateCloudServiceProviderModel()
        {
            return new CreateCloudServiceProviderModel(CloudServiceProvidersEnum.Google, InfrastructureName, ResourceType, ResourceContent);
        }
    }
}
