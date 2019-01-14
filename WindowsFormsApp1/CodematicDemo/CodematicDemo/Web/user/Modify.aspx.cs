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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace yuhi.Web.user
{
    public partial class Modify : Page
    {       

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
		this.txtid.Text=model.id.ToString();
		this.txtname.Text=model.name.ToString();
		this.txtpwd.Text=model.pwd.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtid.Text))
			{
				strErr+="id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtname.Text))
			{
				strErr+="name格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpwd.Text))
			{
				strErr+="pwd格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.txtid.Text);
			int name=int.Parse(this.txtname.Text);
			int pwd=int.Parse(this.txtpwd.Text);


			yuhi.Model.user model=new yuhi.Model.user();
			model.id=id;
			model.name=name;
			model.pwd=pwd;

			yuhi.BLL.user bll=new yuhi.BLL.user();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
