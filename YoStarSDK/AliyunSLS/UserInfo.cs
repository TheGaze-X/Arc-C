using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public sealed class UserInfo
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5BF0660", Offset = "0x5BEF260", VA = "0x185BF0660")]
		public UserInfo()
		{
		}

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x18")]
		public string channel;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> ext;
	}
}
