// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: addressbook.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbd = global::Google.Protobuf.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.Examples.AddressBook {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Addressbook {

    #region Static variables
    internal static pbd::MessageDescriptor internal__static_tutorial_Person__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.Person> internal__static_tutorial_Person__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_tutorial_Person_PhoneNumber__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber> internal__static_tutorial_Person_PhoneNumber__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_tutorial_AddressBook__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.AddressBook> internal__static_tutorial_AddressBook__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;

    static Addressbook() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFhZGRyZXNzYm9vay5wcm90bxIIdHV0b3JpYWwi2gEKBlBlcnNvbhIMCgRu", 
            "YW1lGAEgAigJEgoKAmlkGAIgAigFEg0KBWVtYWlsGAMgASgJEisKBXBob25l", 
            "GAQgAygLMhwudHV0b3JpYWwuUGVyc29uLlBob25lTnVtYmVyGk0KC1Bob25l", 
            "TnVtYmVyEg4KBm51bWJlchgBIAIoCRIuCgR0eXBlGAIgASgOMhoudHV0b3Jp", 
            "YWwuUGVyc29uLlBob25lVHlwZToESE9NRSIrCglQaG9uZVR5cGUSCgoGTU9C", 
            "SUxFEAASCAoESE9NRRABEggKBFdPUksQAiIvCgtBZGRyZXNzQm9vaxIgCgZw", 
            "ZXJzb24YASADKAsyEC50dXRvcmlhbC5QZXJzb25CVwoUY29tLmV4YW1wbGUu", 
            "dHV0b3JpYWxCEUFkZHJlc3NCb29rUHJvdG9zqgIrR29vZ2xlLlByb3RvY29s", 
          "QnVmZmVycy5FeGFtcGxlcy5BZGRyZXNzQm9vaw=="));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_tutorial_Person__Descriptor = Descriptor.MessageTypes[0];
        internal__static_tutorial_Person__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.Person>(internal__static_tutorial_Person__Descriptor,
                new string[] { "Name", "Id", "Email", "Phone", });
        internal__static_tutorial_Person_PhoneNumber__Descriptor = internal__static_tutorial_Person__Descriptor.NestedTypes[0];
        internal__static_tutorial_Person_PhoneNumber__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber>(internal__static_tutorial_Person_PhoneNumber__Descriptor,
                new string[] { "Number", "Type", });
        internal__static_tutorial_AddressBook__Descriptor = Descriptor.MessageTypes[1];
        internal__static_tutorial_AddressBook__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.AddressBook>(internal__static_tutorial_AddressBook__Descriptor,
                new string[] { "Person", });
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Person : pb::IMessage<Person>, global::System.IEquatable<Person> {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    private static readonly string[] _fieldNames = new string[] { "email", "id", "name", "phone" };
    private static readonly uint[] _fieldTags = new uint[] { 26, 16, 10, 34 };
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.Examples.AddressBook.Addressbook.internal__static_tutorial_Person__Descriptor; }
    }

    public pb::FieldAccess.FieldAccessorTable<Person> Fields {
      get { return global::Google.ProtocolBuffers.Examples.AddressBook.Addressbook.internal__static_tutorial_Person__FieldAccessorTable; }
    }

    public Person() { }
    public Person(Person other) {
      MergeFrom(other);
    }
    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set { name_ = value ?? ""; }
    }


    public const int IdFieldNumber = 2;
    private int id_;
    public int Id {
      get { return id_; }
      set { id_ = value; }
    }


    public const int EmailFieldNumber = 3;
    private string email_ = "";
    public string Email {
      get { return email_; }
      set { email_ = value ?? ""; }
    }


    public const int PhoneFieldNumber = 4;
    private readonly pbc::RepeatedField<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber> phone_ = new pbc::RepeatedField<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber>();
    public pbc::RepeatedField<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber> Phone {
      get { return phone_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (Email != other.Email) return false;
      if(!phone_.Equals(other.phone_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 0;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      hash ^= phone_.GetHashCode();
      return hash;
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteString(1, Name);
      }
      if (Id != 0) {
        output.WriteInt32(2, Id);
      }
      if (Email.Length != 0) {
        output.WriteString(3, Email);
      }
      if (phone_.Count > 0) {
        output.WriteMessageArray(4, phone_);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += pb::CodedOutputStream.ComputeStringSize(1, Name);
      }
      if (Id != 0) {
        size += pb::CodedOutputStream.ComputeInt32Size(2, Id);
      }
      if (Email.Length != 0) {
        size += pb::CodedOutputStream.ComputeStringSize(3, Email);
      }
      if (phone_.Count > 0) {
        foreach (global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber element in phone_) {
          size += pb::CodedOutputStream.ComputeMessageSize(4, element);
        }
      }
      return size;
    }
    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      phone_.Add(other.phone_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while (input.ReadTag(out tag)) {
        switch(tag) {
          case 0:
            throw pb::InvalidProtocolBufferException.InvalidTag();
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            input.ReadMessageArray(tag, phone_, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber.Parser);
            break;
          }
        }
      }
    }

    #region Nested types
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum PhoneType {
        MOBILE = 0,
        HOME = 1,
        WORK = 2,
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber>, global::System.IEquatable<PhoneNumber> {
        private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
        public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }

        private static readonly string[] _fieldNames = new string[] { "number", "type" };
        private static readonly uint[] _fieldTags = new uint[] { 10, 16 };
        public static pbd::MessageDescriptor Descriptor {
          get { return global::Google.ProtocolBuffers.Examples.AddressBook.Addressbook.internal__static_tutorial_Person_PhoneNumber__Descriptor; }
        }

        public pb::FieldAccess.FieldAccessorTable<PhoneNumber> Fields {
          get { return global::Google.ProtocolBuffers.Examples.AddressBook.Addressbook.internal__static_tutorial_Person_PhoneNumber__FieldAccessorTable; }
        }

        public PhoneNumber() { }
        public PhoneNumber(PhoneNumber other) {
          MergeFrom(other);
        }
        public const int NumberFieldNumber = 1;
        private string number_ = "";
        public string Number {
          get { return number_; }
          set { number_ = value ?? ""; }
        }


        public const int TypeFieldNumber = 2;
        private global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType type_ = global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType.HOME;
        public global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType Type {
          get { return type_; }
          set { type_ = value; }
        }


        public override bool Equals(object other) {
          return Equals(other as PhoneNumber);
        }

        public bool Equals(PhoneNumber other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Number != other.Number) return false;
          if (Type != other.Type) return false;
          return true;
        }

        public override int GetHashCode() {
          int hash = 0;
          if (Number.Length != 0) hash ^= Number.GetHashCode();
          if (Type != global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType.HOME) hash ^= Type.GetHashCode();
          return hash;
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Number.Length != 0) {
            output.WriteString(1, Number);
          }
          if (Type != global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType.HOME) {
            output.WriteEnum(2, (int) Type);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Number.Length != 0) {
            size += pb::CodedOutputStream.ComputeStringSize(1, Number);
          }
          if (Type != global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType.HOME) {
            size += pb::CodedOutputStream.ComputeEnumSize(2, (int) Type);
          }
          return size;
        }
        public void MergeFrom(PhoneNumber other) {
          if (other == null) {
            return;
          }
          if (other.Number.Length != 0) {
            Number = other.Number;
          }
          if (other.Type != global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType.HOME) {
            Type = other.Type;
          }
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while (input.ReadTag(out tag)) {
            switch(tag) {
              case 0:
                throw pb::InvalidProtocolBufferException.InvalidTag();
              default:
                if (pb::WireFormat.IsEndGroupTag(tag)) {
                  return;
                }
                break;
              case 10: {
                Number = input.ReadString();
                break;
              }
              case 16: {
                type_ = (global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType) input.ReadEnum();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AddressBook : pb::IMessage<AddressBook>, global::System.IEquatable<AddressBook> {
    private static readonly pb::MessageParser<AddressBook> _parser = new pb::MessageParser<AddressBook>(() => new AddressBook());
    public static pb::MessageParser<AddressBook> Parser { get { return _parser; } }

    private static readonly string[] _fieldNames = new string[] { "person" };
    private static readonly uint[] _fieldTags = new uint[] { 10 };
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.Examples.AddressBook.Addressbook.internal__static_tutorial_AddressBook__Descriptor; }
    }

    public pb::FieldAccess.FieldAccessorTable<AddressBook> Fields {
      get { return global::Google.ProtocolBuffers.Examples.AddressBook.Addressbook.internal__static_tutorial_AddressBook__FieldAccessorTable; }
    }

    public AddressBook() { }
    public AddressBook(AddressBook other) {
      MergeFrom(other);
    }
    public const int PersonFieldNumber = 1;
    private readonly pbc::RepeatedField<global::Google.ProtocolBuffers.Examples.AddressBook.Person> person_ = new pbc::RepeatedField<global::Google.ProtocolBuffers.Examples.AddressBook.Person>();
    public pbc::RepeatedField<global::Google.ProtocolBuffers.Examples.AddressBook.Person> Person {
      get { return person_; }
    }

    public override bool Equals(object other) {
      return Equals(other as AddressBook);
    }

    public bool Equals(AddressBook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!person_.Equals(other.person_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 0;
      hash ^= person_.GetHashCode();
      return hash;
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (person_.Count > 0) {
        output.WriteMessageArray(1, person_);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (person_.Count > 0) {
        foreach (global::Google.ProtocolBuffers.Examples.AddressBook.Person element in person_) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, element);
        }
      }
      return size;
    }
    public void MergeFrom(AddressBook other) {
      if (other == null) {
        return;
      }
      person_.Add(other.person_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while (input.ReadTag(out tag)) {
        switch(tag) {
          case 0:
            throw pb::InvalidProtocolBufferException.InvalidTag();
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            break;
          case 10: {
            input.ReadMessageArray(tag, person_, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Parser);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
