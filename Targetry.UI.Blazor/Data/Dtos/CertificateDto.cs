using Targetry.UI.Blazor.Pages;

namespace Targetry.UI.Blazor.Data.Dtos
{
    public class CertificateDto
    {
        public class CertificateModel
        {
            public int CertificateNumber { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime DueDate { get; set; }

            public ShooterDetails ShooterDetails { get; set; }
            public SessionsDetails SessionsDetails { get; set; }

            
        }

        public class ShooterDetails
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Matricule { get; set; }
        }

        public class SessionsDetails
        {
            public string Name { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }
            public string Location { get; set; }
        }


    }
}
