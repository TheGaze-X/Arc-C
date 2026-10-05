using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CB4 RID: 3252
	[Token(Token = "0x2000CB4")]
	public class Act1VHalfIdleCharBuffData
	{
		// Token: 0x06006995 RID: 27029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006995")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleCharBuffData()
		{
		}

		// Token: 0x04004258 RID: 16984
		[Token(Token = "0x4004258")]
		[FieldOffset(Offset = "0x10")]
		public ProfessionCategory prof;

		// Token: 0x04004259 RID: 16985
		[Token(Token = "0x4004259")]
		[FieldOffset(Offset = "0x18")]
		public List<Act1VHalfIdleCharBuffInfo> buffInfos;
	}
}
