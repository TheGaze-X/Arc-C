using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011E0 RID: 4576
	[Token(Token = "0x20011E0")]
	public class RL05CustomizeData
	{
		// Token: 0x06006FCD RID: 28621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0x210E700", Offset = "0x210D300", VA = "0x18210E700")]
		public RL05CustomizeData()
		{
		}

		// Token: 0x04006234 RID: 25140
		[Token(Token = "0x4006234")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeCommonDevelopmentData commonDevelopment;

		// Token: 0x04006235 RID: 25141
		[Token(Token = "0x4006235")]
		[FieldOffset(Offset = "0x18")]
		public List<RL05DifficultyExt> difficulties;

		// Token: 0x04006236 RID: 25142
		[Token(Token = "0x4006236")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeGameShopDialogData specialShopDialog;

		// Token: 0x04006237 RID: 25143
		[Token(Token = "0x4006237")]
		[FieldOffset(Offset = "0x28")]
		public RL05EndingText endingText;
	}
}
