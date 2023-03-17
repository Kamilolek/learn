using Models.Response;

namespace Integrations.Waste
{
    public interface IWasteRepository
    {
        WasteResponseModel GetWaste(string lang);
    }
}