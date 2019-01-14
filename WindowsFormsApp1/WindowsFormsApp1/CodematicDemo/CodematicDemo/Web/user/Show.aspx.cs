using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace yuhi.Web.user
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		yuhi.BLL.user bll=new yuhi.BLL.user();
		yuhi.Model.user model=bll.GetModel();
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name.ToString();
		this.lblpwd.Text=model.pwd.ToString();

	}


    }
}
