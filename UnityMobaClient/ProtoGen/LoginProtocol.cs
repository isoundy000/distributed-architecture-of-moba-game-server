//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LoginProtocol.proto
namespace gprotocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserUnregisterRes")]
  public partial class UserUnregisterRes : global::ProtoBuf.IExtensible
  {
    public UserUnregisterRes() {}
    
    private int _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuestLoginReq")]
  public partial class GuestLoginReq : global::ProtoBuf.IExtensible
  {
    public GuestLoginReq() {}
    
    private string _guest_key;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guest_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string guest_key
    {
      get { return _guest_key; }
      set { _guest_key = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserCenterInfo")]
  public partial class UserCenterInfo : global::ProtoBuf.IExtensible
  {
    public UserCenterInfo() {}
    
    private string _unick;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unick", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string unick
    {
      get { return _unick; }
      set { _unick = value; }
    }
    private int _uface;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"uface", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uface
    {
      get { return _uface; }
      set { _uface = value; }
    }
    private int _usex;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"usex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int usex
    {
      get { return _usex; }
      set { _usex = value; }
    }
    private int _uvip;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"uvip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uvip
    {
      get { return _uvip; }
      set { _uvip = value; }
    }
    private int _uid;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuestLoginRes")]
  public partial class GuestLoginRes : global::ProtoBuf.IExtensible
  {
    public GuestLoginRes() {}
    
    private int _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private UserCenterInfo _uinfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"uinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public UserCenterInfo uinfo
    {
      get { return _uinfo; }
      set { _uinfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EditProfileReq")]
  public partial class EditProfileReq : global::ProtoBuf.IExtensible
  {
    public EditProfileReq() {}
    
    private string _unick;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unick", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string unick
    {
      get { return _unick; }
      set { _unick = value; }
    }
    private int _uface;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"uface", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uface
    {
      get { return _uface; }
      set { _uface = value; }
    }
    private int _usex;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"usex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int usex
    {
      get { return _usex; }
      set { _usex = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EditProfileRes")]
  public partial class EditProfileRes : global::ProtoBuf.IExtensible
  {
    public EditProfileRes() {}
    
    private int _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AccountUpgradeReq")]
  public partial class AccountUpgradeReq : global::ProtoBuf.IExtensible
  {
    public AccountUpgradeReq() {}
    
    private string _uname;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string uname
    {
      get { return _uname; }
      set { _uname = value; }
    }
    private string _upwd_md5;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"upwd_md5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string upwd_md5
    {
      get { return _upwd_md5; }
      set { _upwd_md5 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AccountUpgradeRes")]
  public partial class AccountUpgradeRes : global::ProtoBuf.IExtensible
  {
    public AccountUpgradeRes() {}
    
    private int _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginReq")]
  public partial class UserLoginReq : global::ProtoBuf.IExtensible
  {
    public UserLoginReq() {}
    
    private string _uname;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string uname
    {
      get { return _uname; }
      set { _uname = value; }
    }
    private string _upwd_md5;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"upwd_md5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string upwd_md5
    {
      get { return _upwd_md5; }
      set { _upwd_md5 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginRes")]
  public partial class UserLoginRes : global::ProtoBuf.IExtensible
  {
    public UserLoginRes() {}
    
    private int _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private UserCenterInfo _uinfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"uinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public UserCenterInfo uinfo
    {
      get { return _uinfo; }
      set { _uinfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"LoginCmd")]
    public enum LoginCmd
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INVALID_LOGIN_CMD", Value=0)]
      INVALID_LOGIN_CMD = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eGuestLoginReq", Value=1)]
      eGuestLoginReq = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eGuestLoginRes", Value=2)]
      eGuestLoginRes = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eReLogin", Value=3)]
      eReLogin = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eUserLostConn", Value=4)]
      eUserLostConn = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eEditProfileReq", Value=5)]
      eEditProfileReq = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eEditProfileRes", Value=6)]
      eEditProfileRes = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eAccountUpgradeReq", Value=7)]
      eAccountUpgradeReq = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eAccountUpgradeRes", Value=8)]
      eAccountUpgradeRes = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eUserLoginReq", Value=9)]
      eUserLoginReq = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eUserLoginRes", Value=10)]
      eUserLoginRes = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eUserUnregisterReq", Value=11)]
      eUserUnregisterReq = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eUserUnregisterRes", Value=12)]
      eUserUnregisterRes = 12
    }
  
}