using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Principios_ABC.Lesson_1
{//==================================== INICIO del namespace ====================================//

	public partial class Condiciones_2 : System.Web.UI.Page
	{//===================================== INICIO de la Clase =====================================//

		protected void Page_Load(object sender, EventArgs e)
		{//======================================= INICIO del Load =======================================//

			double var_Tienda_1;
			double var_Tienda_2;

			var_Tienda_1 = 10000;
			var_Tienda_2 = 15000;

			if (var_Tienda_1 < var_Tienda_2 )
			{
				Obj_Resultado.Text =  "La Tienda Uno es mas barato que la Tienda Dos";
			}
			else
			{
				Obj_Resultado.Text = "La Tienda Dos es mas barato que la Tienda Uno";
			}

		}//=======================================    FIN del Load =======================================//

	}//=====================================    FIN de la Clase =====================================//

}//====================================    FIN del namespace ====================================//
