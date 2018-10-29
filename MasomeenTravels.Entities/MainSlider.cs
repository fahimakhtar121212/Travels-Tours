using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasomeenTravels.Entities
{
    public class MainSlider
    {
        [Key]
        public int SliderID { get; set; }
        public String Caption1 { get; set; }
        public String Caption2 { get; set; }
        public String Image { get; set; }
        public String AltText { get; set; }
        public String Description { get; set; }
        public String ButtonText1 { get; set; }
        public String ButtonText2 { get; set; }
    }
}
