using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x0200291C RID: 10524
	[Token(Token = "0x200291C")]
	public class RoguelikeInput : IHotfixable
	{
		// Token: 0x06011733 RID: 71475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011733")]
		[Address(RVA = "0x94D430", Offset = "0x94C030", VA = "0x18094D430")]
		public RoguelikeInput()
		{
		}

		// Token: 0x040137DC RID: 79836
		[Token(Token = "0x40137DC")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeBuff> outerBuffs;

		// Token: 0x040137DD RID: 79837
		[Token(Token = "0x40137DD")]
		[FieldOffset(Offset = "0x18")]
		public List<BattleRoguelikeRelicBuff> relicBuffs;

		// Token: 0x040137DE RID: 79838
		[Token(Token = "0x40137DE")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeTopicExtraBuffData> extraBuffs;

		// Token: 0x040137DF RID: 79839
		[Token(Token = "0x40137DF")]
		[FieldOffset(Offset = "0x28")]
		public int hp;

		// Token: 0x040137E0 RID: 79840
		[Token(Token = "0x40137E0")]
		[FieldOffset(Offset = "0x2C")]
		public int maxHp;

		// Token: 0x040137E1 RID: 79841
		[Token(Token = "0x40137E1")]
		[FieldOffset(Offset = "0x30")]
		public int shield;

		// Token: 0x040137E2 RID: 79842
		[Token(Token = "0x40137E2")]
		[FieldOffset(Offset = "0x38")]
		public BattleRoguelikeMeta meta;

		// Token: 0x040137E3 RID: 79843
		[Token(Token = "0x40137E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
