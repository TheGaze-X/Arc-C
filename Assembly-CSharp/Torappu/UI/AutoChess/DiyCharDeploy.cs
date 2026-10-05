using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006256 RID: 25174
	[Token(Token = "0x2006256")]
	public class DiyCharDeploy
	{
		// Token: 0x06024561 RID: 148833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024561")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DiyCharDeploy()
		{
		}

		// Token: 0x0403287F RID: 206975
		[Token(Token = "0x403287F")]
		[FieldOffset(Offset = "0x10")]
		public int skillIndex;

		// Token: 0x04032880 RID: 206976
		[Token(Token = "0x4032880")]
		[FieldOffset(Offset = "0x18")]
		public string currentEquip;

		// Token: 0x04032881 RID: 206977
		[Token(Token = "0x4032881")]
		[FieldOffset(Offset = "0x20")]
		public string diyChar;

		// Token: 0x04032882 RID: 206978
		[Token(Token = "0x4032882")]
		[FieldOffset(Offset = "0x28")]
		public string origChessId;
	}
}
