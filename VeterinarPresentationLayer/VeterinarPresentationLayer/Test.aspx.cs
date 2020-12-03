using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VetBussinessLayer;
using VetDataAccessLayer.Models;

namespace VeterinarPresentationLayer
{
    public partial class Test : System.Web.UI.Page
    {
        private  VeterinarBussiness veterinarBussiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.veterinarBussiness = new VeterinarBussiness();

            List<Veterinar> veterinars = this.veterinarBussiness.GetallVeterinars();

            foreach(Veterinar v in veterinars)
            {
                ListBoxIspis.Items.Add(v.Id + "." + v.FullName + "," + v.Specialy + "," + v.Years + " ");
            }

        }
    }
}