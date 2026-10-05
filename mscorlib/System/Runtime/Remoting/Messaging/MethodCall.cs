using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003D6 RID: 982
	[Token(Token = "0x20003D6")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.CLSCompliant(false)]
	[System.Serializable]
	public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, System.Runtime.Serialization.ISerializable, IInternalMessage
	{
		// Token: 0x06001ECA RID: 7882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0x4B77F10", Offset = "0x4B76B10", VA = "0x184B77F10")]
		internal MethodCall(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x4B84750", Offset = "0x4B83350", VA = "0x184B84750")]
		internal MethodCall(CADMethodCallMessage msg)
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal MethodCall()
		{
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x4B832A0", Offset = "0x4B81EA0", VA = "0x184B832A0")]
		internal void CopyFrom(IMethodMessage call)
		{
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x4B839F0", Offset = "0x4B825F0", VA = "0x184B839F0", Slot = "19")]
		internal virtual void InitMethodProperty(string key, object value)
		{
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x4B83490", Offset = "0x4B82090", VA = "0x184B83490", Slot = "20")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x170003D5")]
		public int ArgCount
		{
			[Token(Token = "0x6001ED0")]
			[Address(RVA = "0x4A60EB0", Offset = "0x4A5FAB0", VA = "0x184A60EB0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003D6")]
		public object[] Args
		{
			[Token(Token = "0x6001ED1")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003D7")]
		public LogicalCallContext LogicalCallContext
		{
			[Token(Token = "0x6001ED2")]
			[Address(RVA = "0x4B84C30", Offset = "0x4B83830", VA = "0x184B84C30", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003D8")]
		public System.Reflection.MethodBase MethodBase
		{
			[Token(Token = "0x6001ED3")]
			[Address(RVA = "0x4B84CB0", Offset = "0x4B838B0", VA = "0x184B84CB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003D9")]
		public string MethodName
		{
			[Token(Token = "0x6001ED4")]
			[Address(RVA = "0x4B84CE0", Offset = "0x4B838E0", VA = "0x184B84CE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003DA")]
		public object MethodSignature
		{
			[Token(Token = "0x6001ED5")]
			[Address(RVA = "0x4B84D50", Offset = "0x4B83950", VA = "0x184B84D50", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003DB")]
		public virtual System.Collections.IDictionary Properties
		{
			[Token(Token = "0x6001ED6")]
			[Address(RVA = "0x4B781A0", Offset = "0x4B76DA0", VA = "0x184B781A0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x4B838C0", Offset = "0x4B824C0", VA = "0x184B838C0", Slot = "22")]
		internal virtual void InitDictionary()
		{
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003DC")]
		public string TypeName
		{
			[Token(Token = "0x6001ED8")]
			[Address(RVA = "0x4B84EE0", Offset = "0x4B83AE0", VA = "0x184B84EE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DD")]
		public string Uri
		{
			[Token(Token = "0x6001ED9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EDA")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DE")]
		private string Uri
		{
			[Token(Token = "0x6001EDB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x5EA350", Offset = "0x5E8F50", VA = "0x1805EA350", Slot = "12")]
		public object GetArg(int argNum)
		{
			return null;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "23")]
		public virtual void Init()
		{
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x4B83F10", Offset = "0x4B82B10", VA = "0x184B83F10")]
		public void ResolveMethod()
		{
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x4B83030", Offset = "0x4B81C30", VA = "0x184B83030")]
		private System.Type CastTo(string clientType, System.Type serverType)
		{
			return null;
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0x4B83830", Offset = "0x4B82430", VA = "0x184B83830")]
		private static string GetTypeNameFromAssemblyQualifiedName(string aqname)
		{
			return null;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DF")]
		private Identity TargetIdentity
		{
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003E0")]
		private System.Type[] GenericArguments
		{
			[Token(Token = "0x6001EE4")]
			[Address(RVA = "0x4B84BB0", Offset = "0x4B837B0", VA = "0x184B84BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400104C RID: 4172
		[Token(Token = "0x400104C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _uri;

		// Token: 0x0400104D RID: 4173
		[Token(Token = "0x400104D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _typeName;

		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _methodName;

		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object[] _args;

		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private System.Type[] _methodSignature;

		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private System.Reflection.MethodBase _methodBase;

		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LogicalCallContext _callContext;

		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Identity _targetIdentity;

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private System.Type[] _genericArguments;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected System.Collections.IDictionary ExternalProperties;

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected System.Collections.IDictionary InternalProperties;
	}
}
