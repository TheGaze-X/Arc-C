using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045E6 RID: 17894
	[Token(Token = "0x20045E6")]
	public class Rl03OuterBuffSummaryDifficultyItemModel : IHotfixable
	{
		// Token: 0x0601B343 RID: 111427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B343")]
		[Address(RVA = "0x1468790", Offset = "0x1467390", VA = "0x181468790")]
		public Rl03OuterBuffSummaryDifficultyItemModel()
		{
		}

		// Token: 0x04023111 RID: 143633
		[Token(Token = "0x4023111")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04023112 RID: 143634
		[Token(Token = "0x4023112")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04023113 RID: 143635
		[Token(Token = "0x4023113")]
		[FieldOffset(Offset = "0x20")]
		public int effectGrade;

		// Token: 0x04023114 RID: 143636
		[Token(Token = "0x4023114")]
		[FieldOffset(Offset = "0x28")]
		public List<string> effectDescs;

		// Token: 0x04023115 RID: 143637
		[Token(Token = "0x4023115")]
		[FieldOffset(Offset = "0x30")]
		public bool isInGame;

		// Token: 0x04023116 RID: 143638
		[Token(Token = "0x4023116")]
		[FieldOffset(Offset = "0x31")]
		public bool isEffective;

		// Token: 0x04023117 RID: 143639
		[Token(Token = "0x4023117")]
		[FieldOffset(Offset = "0x32")]
		public bool isActive;

		// Token: 0x04023118 RID: 143640
		[Token(Token = "0x4023118")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
