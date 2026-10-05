using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x0200036A RID: 874
	[Token(Token = "0x200036A")]
	internal class ChannelData
	{
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700034D")]
		internal System.Collections.ArrayList ServerProviders
		{
			[Token(Token = "0x6001CBE")]
			[Address(RVA = "0x4B73650", Offset = "0x4B72250", VA = "0x184B73650")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700034E")]
		public System.Collections.ArrayList ClientProviders
		{
			[Token(Token = "0x6001CBF")]
			[Address(RVA = "0x4B73550", Offset = "0x4B72150", VA = "0x184B73550")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700034F")]
		public System.Collections.Hashtable CustomProperties
		{
			[Token(Token = "0x6001CC0")]
			[Address(RVA = "0x4B735D0", Offset = "0x4B721D0", VA = "0x184B735D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0x4B72970", Offset = "0x4B71570", VA = "0x184B72970")]
		public void CopyFrom(ChannelData other)
		{
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC2")]
		[Address(RVA = "0x4B73470", Offset = "0x4B72070", VA = "0x184B73470")]
		public ChannelData()
		{
		}

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x10")]
		internal string Ref;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x18")]
		internal string Type;

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x20")]
		internal string Id;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x28")]
		internal string DelayLoadAsClientChannel;

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x30")]
		private System.Collections.ArrayList _serverProviders;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x38")]
		private System.Collections.ArrayList _clientProviders;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x40")]
		private System.Collections.Hashtable _customProperties;
	}
}
