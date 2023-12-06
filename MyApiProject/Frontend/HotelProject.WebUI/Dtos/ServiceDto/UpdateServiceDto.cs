using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }


        [Required(ErrorMessage = "Hizmet İkon Linki Giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet Başlığı  Giriniz")]

        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması  Giriniz")]
        public string Description { get; set; }
    }
}
