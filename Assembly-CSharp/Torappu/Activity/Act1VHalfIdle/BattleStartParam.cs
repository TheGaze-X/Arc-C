using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076BC RID: 30396
	[Token(Token = "0x20076BC")]
	public struct BattleStartParam
	{
		// Token: 0x0403D990 RID: 252304
		[Token(Token = "0x403D990")]
		[FieldOffset(Offset = "0x0")]
		public List<AdvancedCharacterInst> squad;

		// Token: 0x0403D991 RID: 252305
		[Token(Token = "0x403D991")]
		[FieldOffset(Offset = "0x8")]
		public BattleStartController.Param basicStartBattleParam;

		// Token: 0x0403D992 RID: 252306
		[Token(Token = "0x403D992")]
		[FieldOffset(Offset = "0x290")]
		public ListDict<string, List<string>> plotSquad;

		// Token: 0x0403D993 RID: 252307
		[Token(Token = "0x403D993")]
		[FieldOffset(Offset = "0x298")]
		public List<string> plotList;
	}
}
