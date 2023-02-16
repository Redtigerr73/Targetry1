using Targetry.UI.Blazor.Data.Dtos;

namespace Targetry.UI.Blazor.Data.Interfaces
{
    public interface ICertificateService
    {
        Task<CertificateDto> GetCertificateById(int id);
        Task<List<CertificateDto>> GetAllCertificates();
        Task<CertificateDto> CreateCertificate(CertificateDto certificate);
        Task<CertificateDto> UpdateCertificate(CertificateDto certificate);
        Task<CertificateDto> DeleteCertificate(int id);
        
    }
}
