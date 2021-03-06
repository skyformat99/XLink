using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Vsd.Entity
{
    /// <summary>设备</summary>
    [Serializable]
    [DataObject]
    [Description("设备")]
    [BindIndex("IU_Device_Code", true, "Code")]
    [BindIndex("IX_Device_ProductID", false, "ProductID")]
    [BindTable("Device", Description = "设备", ConnName = "Vsd", DbType = DatabaseType.SqlServer)]
    public partial class Device : IDevice
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "名称", "", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _Code;
        /// <summary>编码</summary>
        [DisplayName("编码")]
        [Description("编码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Code", "编码", "")]
        public String Code { get { return _Code; } set { if (OnPropertyChanging(__.Code, value)) { _Code = value; OnPropertyChanged(__.Code); } } }

        private String _Secret;
        /// <summary>密钥</summary>
        [DisplayName("密钥")]
        [Description("密钥")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Secret", "密钥", "")]
        public String Secret { get { return _Secret; } set { if (OnPropertyChanging(__.Secret, value)) { _Secret = value; OnPropertyChanged(__.Secret); } } }

        private Boolean _Enable;
        /// <summary>启用</summary>
        [DisplayName("启用")]
        [Description("启用")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Enable", "启用", "")]
        public Boolean Enable { get { return _Enable; } set { if (OnPropertyChanging(__.Enable, value)) { _Enable = value; OnPropertyChanged(__.Enable); } } }

        private Int32 _ProductID;
        /// <summary>产品</summary>
        [DisplayName("产品")]
        [Description("产品")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ProductID", "产品", "")]
        public Int32 ProductID { get { return _ProductID; } set { if (OnPropertyChanging(__.ProductID, value)) { _ProductID = value; OnPropertyChanged(__.ProductID); } } }

        private String _Version;
        /// <summary>版本</summary>
        [DisplayName("版本")]
        [Description("版本")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Version", "版本", "")]
        public String Version { get { return _Version; } set { if (OnPropertyChanging(__.Version, value)) { _Version = value; OnPropertyChanged(__.Version); } } }

        private String _LocalIP;
        /// <summary>本地地址</summary>
        [DisplayName("本地地址")]
        [Description("本地地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("LocalIP", "本地地址", "")]
        public String LocalIP { get { return _LocalIP; } set { if (OnPropertyChanging(__.LocalIP, value)) { _LocalIP = value; OnPropertyChanged(__.LocalIP); } } }

        private Int32 _HeartInterval;
        /// <summary>心跳间隔。默认60秒</summary>
        [DisplayName("心跳间隔")]
        [Description("心跳间隔。默认60秒")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("HeartInterval", "心跳间隔。默认60秒", "")]
        public Int32 HeartInterval { get { return _HeartInterval; } set { if (OnPropertyChanging(__.HeartInterval, value)) { _HeartInterval = value; OnPropertyChanged(__.HeartInterval); } } }

        private Int32 _KeepAliveTime;
        /// <summary>在线间隔。默认10秒</summary>
        [DisplayName("在线间隔")]
        [Description("在线间隔。默认10秒")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("KeepAliveTime", "在线间隔。默认10秒", "")]
        public Int32 KeepAliveTime { get { return _KeepAliveTime; } set { if (OnPropertyChanging(__.KeepAliveTime, value)) { _KeepAliveTime = value; OnPropertyChanged(__.KeepAliveTime); } } }

        private String _ResetTime;
        /// <summary>重启时间。默认24:00:00不启用</summary>
        [DisplayName("重启时间")]
        [Description("重启时间。默认24:00:00不启用")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("ResetTime", "重启时间。默认24:00:00不启用", "")]
        public String ResetTime { get { return _ResetTime; } set { if (OnPropertyChanging(__.ResetTime, value)) { _ResetTime = value; OnPropertyChanged(__.ResetTime); } } }

        private String _Data;
        /// <summary>数据</summary>
        [DisplayName("数据")]
        [Description("数据")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Data", "数据", "")]
        public String Data { get { return _Data; } set { if (OnPropertyChanging(__.Data, value)) { _Data = value; OnPropertyChanged(__.Data); } } }

        private Int32 _Logins;
        /// <summary>登录</summary>
        [DisplayName("登录")]
        [Description("登录")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Logins", "登录", "")]
        public Int32 Logins { get { return _Logins; } set { if (OnPropertyChanging(__.Logins, value)) { _Logins = value; OnPropertyChanged(__.Logins); } } }

        private DateTime _LastLogin;
        /// <summary>最后登录</summary>
        [DisplayName("最后登录")]
        [Description("最后登录")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("LastLogin", "最后登录", "")]
        public DateTime LastLogin { get { return _LastLogin; } set { if (OnPropertyChanging(__.LastLogin, value)) { _LastLogin = value; OnPropertyChanged(__.LastLogin); } } }

        private String _LastLoginIP;
        /// <summary>最后登录IP</summary>
        [DisplayName("最后登录IP")]
        [Description("最后登录IP")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("LastLoginIP", "最后登录IP", "")]
        public String LastLoginIP { get { return _LastLoginIP; } set { if (OnPropertyChanging(__.LastLoginIP, value)) { _LastLoginIP = value; OnPropertyChanged(__.LastLoginIP); } } }

        private Int32 _CreateUserID;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateUserID", "创建者", "")]
        public Int32 CreateUserID { get { return _CreateUserID; } set { if (OnPropertyChanging(__.CreateUserID, value)) { _CreateUserID = value; OnPropertyChanged(__.CreateUserID); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "")]
        public DateTime CreateTime { get { return _CreateTime; } set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "")]
        public String CreateIP { get { return _CreateIP; } set { if (OnPropertyChanging(__.CreateIP, value)) { _CreateIP = value; OnPropertyChanged(__.CreateIP); } } }

        private Int32 _UpdateUserID;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateUserID", "更新者", "")]
        public Int32 UpdateUserID { get { return _UpdateUserID; } set { if (OnPropertyChanging(__.UpdateUserID, value)) { _UpdateUserID = value; OnPropertyChanged(__.UpdateUserID); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get { return _UpdateTime; } set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } } }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "")]
        public String UpdateIP { get { return _UpdateIP; } set { if (OnPropertyChanging(__.UpdateIP, value)) { _UpdateIP = value; OnPropertyChanged(__.UpdateIP); } } }

        private String _Description;
        /// <summary>描述</summary>
        [DisplayName("描述")]
        [Description("描述")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Description", "描述", "")]
        public String Description { get { return _Description; } set { if (OnPropertyChanging(__.Description, value)) { _Description = value; OnPropertyChanged(__.Description); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.Name : return _Name;
                    case __.Code : return _Code;
                    case __.Secret : return _Secret;
                    case __.Enable : return _Enable;
                    case __.ProductID : return _ProductID;
                    case __.Version : return _Version;
                    case __.LocalIP : return _LocalIP;
                    case __.HeartInterval : return _HeartInterval;
                    case __.KeepAliveTime : return _KeepAliveTime;
                    case __.ResetTime : return _ResetTime;
                    case __.Data : return _Data;
                    case __.Logins : return _Logins;
                    case __.LastLogin : return _LastLogin;
                    case __.LastLoginIP : return _LastLoginIP;
                    case __.CreateUserID : return _CreateUserID;
                    case __.CreateTime : return _CreateTime;
                    case __.CreateIP : return _CreateIP;
                    case __.UpdateUserID : return _UpdateUserID;
                    case __.UpdateTime : return _UpdateTime;
                    case __.UpdateIP : return _UpdateIP;
                    case __.Description : return _Description;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = value.ToInt(); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Code : _Code = Convert.ToString(value); break;
                    case __.Secret : _Secret = Convert.ToString(value); break;
                    case __.Enable : _Enable = value.ToBoolean(); break;
                    case __.ProductID : _ProductID = value.ToInt(); break;
                    case __.Version : _Version = Convert.ToString(value); break;
                    case __.LocalIP : _LocalIP = Convert.ToString(value); break;
                    case __.HeartInterval : _HeartInterval = value.ToInt(); break;
                    case __.KeepAliveTime : _KeepAliveTime = value.ToInt(); break;
                    case __.ResetTime : _ResetTime = Convert.ToString(value); break;
                    case __.Data : _Data = Convert.ToString(value); break;
                    case __.Logins : _Logins = value.ToInt(); break;
                    case __.LastLogin : _LastLogin = value.ToDateTime(); break;
                    case __.LastLoginIP : _LastLoginIP = Convert.ToString(value); break;
                    case __.CreateUserID : _CreateUserID = value.ToInt(); break;
                    case __.CreateTime : _CreateTime = value.ToDateTime(); break;
                    case __.CreateIP : _CreateIP = Convert.ToString(value); break;
                    case __.UpdateUserID : _UpdateUserID = value.ToInt(); break;
                    case __.UpdateTime : _UpdateTime = value.ToDateTime(); break;
                    case __.UpdateIP : _UpdateIP = Convert.ToString(value); break;
                    case __.Description : _Description = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得设备字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>编码</summary>
            public static readonly Field Code = FindByName(__.Code);

            /// <summary>密钥</summary>
            public static readonly Field Secret = FindByName(__.Secret);

            /// <summary>启用</summary>
            public static readonly Field Enable = FindByName(__.Enable);

            /// <summary>产品</summary>
            public static readonly Field ProductID = FindByName(__.ProductID);

            /// <summary>版本</summary>
            public static readonly Field Version = FindByName(__.Version);

            /// <summary>本地地址</summary>
            public static readonly Field LocalIP = FindByName(__.LocalIP);

            /// <summary>心跳间隔。默认60秒</summary>
            public static readonly Field HeartInterval = FindByName(__.HeartInterval);

            /// <summary>在线间隔。默认10秒</summary>
            public static readonly Field KeepAliveTime = FindByName(__.KeepAliveTime);

            /// <summary>重启时间。默认24:00:00不启用</summary>
            public static readonly Field ResetTime = FindByName(__.ResetTime);

            /// <summary>数据</summary>
            public static readonly Field Data = FindByName(__.Data);

            /// <summary>登录</summary>
            public static readonly Field Logins = FindByName(__.Logins);

            /// <summary>最后登录</summary>
            public static readonly Field LastLogin = FindByName(__.LastLogin);

            /// <summary>最后登录IP</summary>
            public static readonly Field LastLoginIP = FindByName(__.LastLoginIP);

            /// <summary>创建者</summary>
            public static readonly Field CreateUserID = FindByName(__.CreateUserID);

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName(__.CreateIP);

            /// <summary>更新者</summary>
            public static readonly Field UpdateUserID = FindByName(__.UpdateUserID);

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName(__.UpdateIP);

            /// <summary>描述</summary>
            public static readonly Field Description = FindByName(__.Description);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得设备字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>编码</summary>
            public const String Code = "Code";

            /// <summary>密钥</summary>
            public const String Secret = "Secret";

            /// <summary>启用</summary>
            public const String Enable = "Enable";

            /// <summary>产品</summary>
            public const String ProductID = "ProductID";

            /// <summary>版本</summary>
            public const String Version = "Version";

            /// <summary>本地地址</summary>
            public const String LocalIP = "LocalIP";

            /// <summary>心跳间隔。默认60秒</summary>
            public const String HeartInterval = "HeartInterval";

            /// <summary>在线间隔。默认10秒</summary>
            public const String KeepAliveTime = "KeepAliveTime";

            /// <summary>重启时间。默认24:00:00不启用</summary>
            public const String ResetTime = "ResetTime";

            /// <summary>数据</summary>
            public const String Data = "Data";

            /// <summary>登录</summary>
            public const String Logins = "Logins";

            /// <summary>最后登录</summary>
            public const String LastLogin = "LastLogin";

            /// <summary>最后登录IP</summary>
            public const String LastLoginIP = "LastLoginIP";

            /// <summary>创建者</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>更新者</summary>
            public const String UpdateUserID = "UpdateUserID";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";

            /// <summary>描述</summary>
            public const String Description = "Description";
        }
        #endregion
    }

    /// <summary>设备接口</summary>
    public partial interface IDevice
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>编码</summary>
        String Code { get; set; }

        /// <summary>密钥</summary>
        String Secret { get; set; }

        /// <summary>启用</summary>
        Boolean Enable { get; set; }

        /// <summary>产品</summary>
        Int32 ProductID { get; set; }

        /// <summary>版本</summary>
        String Version { get; set; }

        /// <summary>本地地址</summary>
        String LocalIP { get; set; }

        /// <summary>心跳间隔。默认60秒</summary>
        Int32 HeartInterval { get; set; }

        /// <summary>在线间隔。默认10秒</summary>
        Int32 KeepAliveTime { get; set; }

        /// <summary>重启时间。默认24:00:00不启用</summary>
        String ResetTime { get; set; }

        /// <summary>数据</summary>
        String Data { get; set; }

        /// <summary>登录</summary>
        Int32 Logins { get; set; }

        /// <summary>最后登录</summary>
        DateTime LastLogin { get; set; }

        /// <summary>最后登录IP</summary>
        String LastLoginIP { get; set; }

        /// <summary>创建者</summary>
        Int32 CreateUserID { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }

        /// <summary>创建地址</summary>
        String CreateIP { get; set; }

        /// <summary>更新者</summary>
        Int32 UpdateUserID { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>更新地址</summary>
        String UpdateIP { get; set; }

        /// <summary>描述</summary>
        String Description { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}