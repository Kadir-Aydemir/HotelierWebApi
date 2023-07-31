using System.ComponentModel.DataAnnotations;

namespace Hotelier.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizment ikon linki giriniz!")]
        public string? ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizment başlığı giriniz!")]
        [StringLength(100,ErrorMessage ="Başlık en fazla 100 karakter olabilir!")]
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
