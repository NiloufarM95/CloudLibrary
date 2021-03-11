using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.IGSViewModels
{
    public class CreateIGSViewModel : CreateViewModel
    {
        public override CreateCloudServiceProviderModel ToCreateCloudServiceProviderModel()
        {
            return new CreateCloudServiceProviderModel(CloudServiceProvidersEnum.IGS, InfrastructureName, ResourceType, ResourceContent);
        }
    }
}
