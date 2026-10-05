using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public sealed class Credentials
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5BDFE00", Offset = "0x5BDEA00", VA = "0x185BDFE00")]
		public Credentials()
		{
		}

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x10")]
		public string instanceId;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x18")]
		public string endpoint;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x20")]
		public string project;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		public string secretKey;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		public string siteId;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x38")]
		public string deviceId;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x40")]
		public string accessKeyId;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x48")]
		public string accessKeySecret;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x50")]
		public string securityToken;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, string> extension;
	}
}
