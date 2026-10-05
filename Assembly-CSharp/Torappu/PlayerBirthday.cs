using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008EF RID: 2287
	[Token(Token = "0x20008EF")]
	[Serializable]
	public class PlayerBirthday
	{
		// Token: 0x060065B5 RID: 26037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBirthday()
		{
		}

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[FieldOffset(Offset = "0x10")]
		public int month;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[FieldOffset(Offset = "0x14")]
		public int day;
	}
}
