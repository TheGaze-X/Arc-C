using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004628 RID: 17960
	[Token(Token = "0x2004628")]
	public class RL02OuterBuffItemModel : IHotfixable
	{
		// Token: 0x0601B4AB RID: 111787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4AB")]
		[Address(RVA = "0x149D320", Offset = "0x149BF20", VA = "0x18149D320")]
		public RL02OuterBuffItemModel()
		{
		}

		// Token: 0x040233BC RID: 144316
		[Token(Token = "0x40233BC")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x040233BD RID: 144317
		[Token(Token = "0x40233BD")]
		[FieldOffset(Offset = "0x18")]
		public RL02DevelopmentNodeType nodeType;

		// Token: 0x040233BE RID: 144318
		[Token(Token = "0x40233BE")]
		[FieldOffset(Offset = "0x20")]
		public List<string> frontNodeId;

		// Token: 0x040233BF RID: 144319
		[Token(Token = "0x40233BF")]
		[FieldOffset(Offset = "0x28")]
		public RL02OuterBuffItemModel.UnlockStatus status;

		// Token: 0x040233C0 RID: 144320
		[Token(Token = "0x40233C0")]
		[FieldOffset(Offset = "0x2C")]
		public PolarPoint position;

		// Token: 0x040233C1 RID: 144321
		[Token(Token = "0x40233C1")]
		[FieldOffset(Offset = "0x38")]
		public List<RoguelikeTopicDisplayItem> buffDisplayInfo;

		// Token: 0x040233C2 RID: 144322
		[Token(Token = "0x40233C2")]
		[FieldOffset(Offset = "0x40")]
		public RL02DevelopmentEffectType effectType;

		// Token: 0x040233C3 RID: 144323
		[Token(Token = "0x40233C3")]
		[FieldOffset(Offset = "0x48")]
		public string rawDesc;

		// Token: 0x040233C4 RID: 144324
		[Token(Token = "0x40233C4")]
		[FieldOffset(Offset = "0x50")]
		public string iconId;

		// Token: 0x040233C5 RID: 144325
		[Token(Token = "0x40233C5")]
		[FieldOffset(Offset = "0x58")]
		public int tokenCost;

		// Token: 0x040233C6 RID: 144326
		[Token(Token = "0x40233C6")]
		[FieldOffset(Offset = "0x60")]
		public string name;

		// Token: 0x040233C7 RID: 144327
		[Token(Token = "0x40233C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004629 RID: 17961
		[Token(Token = "0x2004629")]
		public enum UnlockStatus
		{
			// Token: 0x040233C9 RID: 144329
			[Token(Token = "0x40233C9")]
			LOCKED,
			// Token: 0x040233CA RID: 144330
			[Token(Token = "0x40233CA")]
			UNLOCK,
			// Token: 0x040233CB RID: 144331
			[Token(Token = "0x40233CB")]
			ACTIVATED
		}
	}
}
