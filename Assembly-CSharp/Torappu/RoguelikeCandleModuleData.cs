using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011C0 RID: 4544
	[Token(Token = "0x20011C0")]
	public class RoguelikeCandleModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06006FAB RID: 28587 RVA: 0x00032790 File Offset: 0x00030990
		[Token(Token = "0x17000D45")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006FAB")]
			[Address(RVA = "0x2110790", Offset = "0x210F390", VA = "0x182110790", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAC")]
		[Address(RVA = "0x21106A0", Offset = "0x210F2A0", VA = "0x1821106A0")]
		public RoguelikeCandleModuleData()
		{
		}

		// Token: 0x04006142 RID: 24898
		[Token(Token = "0x4006142")]
		[FieldOffset(Offset = "0x10")]
		public List<string> candleTicketIdList;

		// Token: 0x04006143 RID: 24899
		[Token(Token = "0x4006143")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeCandleModuleConsts moduleConsts;

		// Token: 0x04006144 RID: 24900
		[Token(Token = "0x4006144")]
		[FieldOffset(Offset = "0x20")]
		public List<string> candleBattleStageIdList;
	}
}
