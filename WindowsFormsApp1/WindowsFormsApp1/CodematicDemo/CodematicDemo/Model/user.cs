using System;
namespace yuhi.Model
{
	/// <summary>
	/// user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user
	{
		public user()
		{}
		#region Model
		private int _id;
		private int _name;
		private int _pwd;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
		}
		#endregion Model

	}
}

