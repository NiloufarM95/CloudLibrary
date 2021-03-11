using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.AzureViewModels
{
    public class DeleteAzureViewModel : DeleteViewModel
    {
        public override DeleteCloudServiceProviderModel ToDeleteCloudServiceProviderModel()
        {
            return new DeleteCloudServiceProviderModel(CloudServiceProvidersEnum.Azure, InfrastructureName);
        }
    }
}
