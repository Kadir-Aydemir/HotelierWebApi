using System.ComponentModel.DataAnnotations;

namespace Hotelier.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizment ikon linki giriniz!")]
        public string? ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizment başlığı giriniz!")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir!")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Hizment açıklaması giriniz!")]
        [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olabilir!")]
        public string? Description { get; set; }
    }
}
