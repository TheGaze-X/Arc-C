using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200038B")]
	internal class DynamicPropertyCollection
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00012C30 File Offset: 0x00010E30
		[Token(Token = "0x17000376")]
		public bool HasProperties
		{
			[Token(Token = "0x6001DAB")]
			[Address(RVA = "0x4B7D440", Offset = "0x4B7C040", VA = "0x184B7D440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00012C48 File Offset: 0x00010E48
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x4B7D010", Offset = "0x4B7BC10", VA = "0x184B7D010")]
		public bool RegisterDynamicProperty(IDynamicProperty prop)
		{
			return default(bool);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00012C60 File Offset: 0x00010E60
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x4B7D260", Offset = "0x4B7BE60", VA = "0x184B7D260")]
		public bool UnregisterDynamicProperty(string name)
		{
			return default(bool);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAE")]
		[Address(RVA = "0x4B7CAD0", Offset = "0x4B7B6D0", VA = "0x184B7CAD0")]
		public void NotifyMessage(bool start, System.Runtime.Remoting.Messaging.IMessage msg, bool client_site, bool async)
		{
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00012C78 File Offset: 0x00010E78
		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0x4B7C8E0", Offset = "0x4B7B4E0", VA = "0x184B7C8E0")]
		private int FindProperty(string name)
		{
			return 0;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x4B7D3D0", Offset = "0x4B7BFD0", VA = "0x184B7D3D0")]
		public DynamicPropertyCollection()
		{
		}

		// Token: 0x04000FD5 RID: 4053
		[Token(Token = "0x4000FD5")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.ArrayList _properties;

		// Token: 0x0200038C RID: 908
		[Token(Token = "0x200038C")]
		private class DynamicPropertyReg
		{
			// Token: 0x06001DB1 RID: 7601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001DB1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DynamicPropertyReg()
			{
			}

			// Token: 0x04000FD6 RID: 4054
			[Token(Token = "0x4000FD6")]
			[FieldOffset(Offset = "0x10")]
			public IDynamicProperty Property;

			// Token: 0x04000FD7 RID: 4055
			[Token(Token = "0x4000FD7")]
			[FieldOffset(Offset = "0x18")]
			public IDynamicMessageSink Sink;
		}
	}
}
