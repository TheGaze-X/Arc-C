using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E9C RID: 3740
	[Token(Token = "0x2000E9C")]
	public class AprilFoolScoreData
	{
		// Token: 0x06006B70 RID: 27504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B70")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AprilFoolScoreData()
		{
		}

		// Token: 0x04004EFA RID: 20218
		[Token(Token = "0x4004EFA")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004EFB RID: 20219
		[Token(Token = "0x4004EFB")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004EFC RID: 20220
		[Token(Token = "0x4004EFC")]
		[FieldOffset(Offset = "0x20")]
		public string playerName;

		// Token: 0x04004EFD RID: 20221
		[Token(Token = "0x4004EFD")]
		[FieldOffset(Offset = "0x28")]
		public long playerScore;
	}
}
