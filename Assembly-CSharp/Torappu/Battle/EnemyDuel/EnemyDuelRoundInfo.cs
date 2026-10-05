using System;
using Il2CppDummyDll;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C0 RID: 9920
	[Token(Token = "0x20026C0")]
	public class EnemyDuelRoundInfo
	{
		// Token: 0x060102CA RID: 66250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102CA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelRoundInfo()
		{
		}

		// Token: 0x0401208D RID: 73869
		[Token(Token = "0x401208D")]
		[FieldOffset(Offset = "0x10")]
		public int choice;

		// Token: 0x0401208E RID: 73870
		[Token(Token = "0x401208E")]
		[FieldOffset(Offset = "0x14")]
		public bool bingo;

		// Token: 0x0401208F RID: 73871
		[Token(Token = "0x401208F")]
		[FieldOffset(Offset = "0x18")]
		public int money;

		// Token: 0x04012090 RID: 73872
		[Token(Token = "0x4012090")]
		[FieldOffset(Offset = "0x1C")]
		public int side;
	}
}
