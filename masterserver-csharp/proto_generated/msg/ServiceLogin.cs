// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Messages/proto/service_login.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace P4TLB.MasterServer {

  /// <summary>Holder for reflection information generated from Messages/proto/service_login.proto</summary>
  public static partial class ServiceLoginReflection {

    #region Descriptor
    /// <summary>File descriptor for Messages/proto/service_login.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceLoginReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJNZXNzYWdlcy9wcm90by9zZXJ2aWNlX2xvZ2luLnByb3RvEhJQNFRMQi5N",
            "YXN0ZXJTZXJ2ZXIiMwoQVXNlckxvZ2luUmVxdWVzdBINCgVsb2dpbhgBIAEo",
            "CRIQCghwYXNzd29yZBgCIAEoCSIiChFVc2VyTG9naW5SZXNwb25zZRINCgVl",
            "cnJvchgBIAEoBSI0ChFVc2VyU2lnblVwUmVxdWVzdBINCgVsb2dpbhgBIAEo",
            "CRIQCghwYXNzd29yZBgCIAEoCSIjChJVc2VyU2lnblVwUmVzcG9uc2USDQoF",
            "ZXJyb3IYASABKAUy0wEKDkF1dGhlbnRpY2F0aW9uEl4KDVNlbmRVc2VyTG9n",
            "aW4SJC5QNFRMQi5NYXN0ZXJTZXJ2ZXIuVXNlckxvZ2luUmVxdWVzdBolLlA0",
            "VExCLk1hc3RlclNlcnZlci5Vc2VyTG9naW5SZXNwb25zZSIAEmEKDlNlbmRV",
            "c2VyU2lnblVwEiUuUDRUTEIuTWFzdGVyU2VydmVyLlVzZXJTaWduVXBSZXF1",
            "ZXN0GiYuUDRUTEIuTWFzdGVyU2VydmVyLlVzZXJTaWduVXBSZXNwb25zZSIA",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.UserLoginRequest), global::P4TLB.MasterServer.UserLoginRequest.Parser, new[]{ "Login", "Password" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.UserLoginResponse), global::P4TLB.MasterServer.UserLoginResponse.Parser, new[]{ "Error" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.UserSignUpRequest), global::P4TLB.MasterServer.UserSignUpRequest.Parser, new[]{ "Login", "Password" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::P4TLB.MasterServer.UserSignUpResponse), global::P4TLB.MasterServer.UserSignUpResponse.Parser, new[]{ "Error" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserLoginRequest : pb::IMessage<UserLoginRequest> {
    private static readonly pb::MessageParser<UserLoginRequest> _parser = new pb::MessageParser<UserLoginRequest>(() => new UserLoginRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserLoginRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.ServiceLoginReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginRequest(UserLoginRequest other) : this() {
      login_ = other.login_;
      password_ = other.password_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginRequest Clone() {
      return new UserLoginRequest(this);
    }

    /// <summary>Field number for the "login" field.</summary>
    public const int LoginFieldNumber = 1;
    private string login_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Login {
      get { return login_; }
      set {
        login_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    /// <summary>
    ///&lt; need to be hashed before being sent...
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserLoginRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserLoginRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Login != other.Login) return false;
      if (Password != other.Password) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Login.Length != 0) hash ^= Login.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Login.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Login);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Login.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Login);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserLoginRequest other) {
      if (other == null) {
        return;
      }
      if (other.Login.Length != 0) {
        Login = other.Login;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Login = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class UserLoginResponse : pb::IMessage<UserLoginResponse> {
    private static readonly pb::MessageParser<UserLoginResponse> _parser = new pb::MessageParser<UserLoginResponse>(() => new UserLoginResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserLoginResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.ServiceLoginReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginResponse(UserLoginResponse other) : this() {
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginResponse Clone() {
      return new UserLoginResponse(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private int error_;
    /// <summary>
    /// Error codes:
    /// 0 -> success
    /// 1 -> invalid (we can't say if the password was incorrect or username was incorrect: security reason)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserLoginResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserLoginResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Error != 0) hash ^= Error.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Error != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Error != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserLoginResponse other) {
      if (other == null) {
        return;
      }
      if (other.Error != 0) {
        Error = other.Error;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Error = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// For the password part, we will use generated token from a homemade discord bot 
  /// </summary>
  public sealed partial class UserSignUpRequest : pb::IMessage<UserSignUpRequest> {
    private static readonly pb::MessageParser<UserSignUpRequest> _parser = new pb::MessageParser<UserSignUpRequest>(() => new UserSignUpRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserSignUpRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.ServiceLoginReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserSignUpRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserSignUpRequest(UserSignUpRequest other) : this() {
      login_ = other.login_;
      password_ = other.password_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserSignUpRequest Clone() {
      return new UserSignUpRequest(this);
    }

    /// <summary>Field number for the "login" field.</summary>
    public const int LoginFieldNumber = 1;
    private string login_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Login {
      get { return login_; }
      set {
        login_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    /// <summary>
    ///&lt; need to be hashed before being sent...
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserSignUpRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserSignUpRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Login != other.Login) return false;
      if (Password != other.Password) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Login.Length != 0) hash ^= Login.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Login.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Login);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Login.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Login);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserSignUpRequest other) {
      if (other == null) {
        return;
      }
      if (other.Login.Length != 0) {
        Login = other.Login;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Login = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class UserSignUpResponse : pb::IMessage<UserSignUpResponse> {
    private static readonly pb::MessageParser<UserSignUpResponse> _parser = new pb::MessageParser<UserSignUpResponse>(() => new UserSignUpResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserSignUpResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::P4TLB.MasterServer.ServiceLoginReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserSignUpResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserSignUpResponse(UserSignUpResponse other) : this() {
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserSignUpResponse Clone() {
      return new UserSignUpResponse(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private int error_;
    /// <summary>
    /// Error codes:
    /// 0 -> success
    /// 1 -> already existing login
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserSignUpResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserSignUpResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Error != 0) hash ^= Error.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Error != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Error != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserSignUpResponse other) {
      if (other == null) {
        return;
      }
      if (other.Error != 0) {
        Error = other.Error;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Error = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
