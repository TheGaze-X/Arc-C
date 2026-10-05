using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	internal class IllogicalCallContext
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700039F")]
		private System.Collections.Hashtable Datastore
		{
			[Token(Token = "0x6001E34")]
			[Address(RVA = "0x4B7DAD0", Offset = "0x4B7C6D0", VA = "0x184B7DAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A0")]
		internal object HostContext
		{
			[Token(Token = "0x6001E35")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E36")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x170003A1")]
		internal bool HasUserData
		{
			[Token(Token = "0x6001E37")]
			[Address(RVA = "0x4B7DB50", Offset = "0x4B7C750", VA = "0x184B7DB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x4B7DA70", Offset = "0x4B7C670", VA = "0x184B7DA70")]
		public void FreeNamedDataSlot(string name)
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x4B7D6B0", Offset = "0x4B7C2B0", VA = "0x184B7D6B0")]
		public IllogicalCallContext CreateCopy()
		{
			return null;
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public IllogicalCallContext()
		{
		}

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.Hashtable m_Datastore;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x18")]
		private object m_HostContext;
	}
}
