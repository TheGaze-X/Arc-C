using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x02001544 RID: 5444
	[Token(Token = "0x2001544")]
	public class GameCheckParam
	{
		// Token: 0x06007CAC RID: 31916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GameCheckParam()
		{
		}

		// Token: 0x04007D11 RID: 32017
		[Token(Token = "0x4007D11")]
		[FieldOffset(Offset = "0x10")]
		public int seq;

		// Token: 0x04007D12 RID: 32018
		[Token(Token = "0x4007D12")]
		[FieldOffset(Offset = "0x14")]
		public uint hash;

		// Token: 0x04007D13 RID: 32019
		[Token(Token = "0x4007D13")]
		[FieldOffset(Offset = "0x18")]
		public int hp;
	}
}
