using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public sealed class LogicalCallContext : System.Runtime.Serialization.ISerializable, System.ICloneable
	{
		// Token: 0x06001E3B RID: 7739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal LogicalCallContext()
		{
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x4B80E70", Offset = "0x4B7FA70", VA = "0x184B80E70")]
		internal LogicalCallContext(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x4B80570", Offset = "0x4B7F170", VA = "0x184B80570", Slot = "4")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x4B7FC70", Offset = "0x4B7E870", VA = "0x184B7FC70", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x4B809B0", Offset = "0x4B7F5B0", VA = "0x184B809B0")]
		internal void Merge(LogicalCallContext lc)
		{
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x170003A2")]
		public bool HasInfo
		{
			[Token(Token = "0x6001E40")]
			[Address(RVA = "0x4B811B0", Offset = "0x4B7FDB0", VA = "0x184B811B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x00012DE0 File Offset: 0x00010FE0
		[Token(Token = "0x170003A3")]
		private bool HasUserData
		{
			[Token(Token = "0x6001E41")]
			[Address(RVA = "0x4B7DB50", Offset = "0x4B7C750", VA = "0x184B7DB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003A4")]
		private System.Collections.Hashtable Datastore
		{
			[Token(Token = "0x6001E42")]
			[Address(RVA = "0x4B81130", Offset = "0x4B7FD30", VA = "0x184B81130")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x4B80510", Offset = "0x4B7F110", VA = "0x184B80510")]
		public object GetData(string name)
		{
			return null;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x4B80D30", Offset = "0x4B7F930", VA = "0x184B80D30")]
		public void SetData(string name, object data)
		{
		}

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Type s_callContextType;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.Collections.Hashtable m_Datastore;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CallContextRemotingData m_RemotingData;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CallContextSecurityData m_SecurityData;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object m_HostContext;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_IsCorrelationMgr;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Header[] _sendHeaders;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Header[] _recvHeaders;

		// Token: 0x020003BA RID: 954
		[Token(Token = "0x20003BA")]
		internal struct Reader
		{
			// Token: 0x06001E46 RID: 7750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E46")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public Reader(LogicalCallContext ctx)
			{
			}

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06001E47 RID: 7751 RVA: 0x00012DF8 File Offset: 0x00010FF8
			[Token(Token = "0x170003A5")]
			public bool IsNull
			{
				[Token(Token = "0x6001E47")]
				[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00012E10 File Offset: 0x00011010
			[Token(Token = "0x170003A6")]
			public bool HasInfo
			{
				[Token(Token = "0x6001E48")]
				[Address(RVA = "0x4B85960", Offset = "0x4B84560", VA = "0x184B85960")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001E49 RID: 7753 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6001E49")]
			[Address(RVA = "0x4B85880", Offset = "0x4B84480", VA = "0x184B85880")]
			public LogicalCallContext Clone()
			{
				return null;
			}

			// Token: 0x06001E4A RID: 7754 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6001E4A")]
			[Address(RVA = "0x4B858F0", Offset = "0x4B844F0", VA = "0x184B858F0")]
			public object GetData(string name)
			{
				return null;
			}

			// Token: 0x04001010 RID: 4112
			[Token(Token = "0x4001010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private LogicalCallContext m_ctx;
		}
	}
}
