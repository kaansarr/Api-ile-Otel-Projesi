using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {

        [Required(ErrorMessage = "Hizmet İkon Linki Giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet Başlığı  Giriniz")]

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
