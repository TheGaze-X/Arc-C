using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000367 RID: 871
	[Token(Token = "0x2000367")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class ObjRef : System.Runtime.Serialization.IObjectReference, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001C80 RID: 7296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C80")]
		[Address(RVA = "0x4B61C80", Offset = "0x4B60880", VA = "0x184B61C80")]
		public ObjRef()
		{
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x4B61C30", Offset = "0x4B60830", VA = "0x184B61C30")]
		internal ObjRef(string uri, IChannelInfo cinfo)
		{
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x4B61020", Offset = "0x4B5FC20", VA = "0x184B61020")]
		internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo)
		{
			return null;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x4B613D0", Offset = "0x4B5FFD0", VA = "0x184B613D0")]
		internal byte[] SerializeType()
		{
			return null;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x4B61580", Offset = "0x4B60180", VA = "0x184B61580")]
		internal ObjRef(System.Type type, string url, object remoteChannelData)
		{
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x4B616B0", Offset = "0x4B602B0", VA = "0x184B616B0")]
		protected ObjRef(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00012930 File Offset: 0x00010B30
		[Token(Token = "0x17000345")]
		internal bool IsReferenceToWellKnow
		{
			[Token(Token = "0x6001C86")]
			[Address(RVA = "0x4B61D40", Offset = "0x4B60940", VA = "0x184B61D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000346")]
		public virtual IChannelInfo ChannelInfo
		{
			[Token(Token = "0x6001C87")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000347")]
		public virtual IEnvoyInfo EnvoyInfo
		{
			[Token(Token = "0x6001C88")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000348")]
		public virtual IRemotingTypeInfo TypeInfo
		{
			[Token(Token = "0x6001C8A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C8B")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000349")]
		public virtual string URI
		{
			[Token(Token = "0x6001C8C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C8D")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x4B61180", Offset = "0x4B5FD80", VA = "0x184B61180", Slot = "13")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x4B61330", Offset = "0x4B5FF30", VA = "0x184B61330", Slot = "14")]
		public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
		{
			return null;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x4B61480", Offset = "0x4B60080", VA = "0x184B61480")]
		internal void UpdateChannelInfo()
		{
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700034A")]
		internal System.Type ServerType
		{
			[Token(Token = "0x6001C91")]
			[Address(RVA = "0x4B61DA0", Offset = "0x4B609A0", VA = "0x184B61DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IChannelInfo channel_info;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string uri;

		// Token: 0x04000F51 RID: 3921
		[Token(Token = "0x4000F51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IRemotingTypeInfo typeInfo;

		// Token: 0x04000F52 RID: 3922
		[Token(Token = "0x4000F52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEnvoyInfo envoyInfo;

		// Token: 0x04000F53 RID: 3923
		[Token(Token = "0x4000F53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int flags;

		// Token: 0x04000F54 RID: 3924
		[Token(Token = "0x4000F54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private System.Type _serverType;

		// Token: 0x04000F55 RID: 3925
		[Token(Token = "0x4000F55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int MarshalledObjectRef;

		// Token: 0x04000F56 RID: 3926
		[Token(Token = "0x4000F56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int WellKnowObjectRef;
	}
}
