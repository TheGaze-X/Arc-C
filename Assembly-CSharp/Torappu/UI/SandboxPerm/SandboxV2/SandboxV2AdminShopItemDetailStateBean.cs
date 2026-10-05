using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004101 RID: 16641
	[Token(Token = "0x2004101")]
	public class SandboxV2AdminShopItemDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06019BC8 RID: 105416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC8")]
		[Address(RVA = "0x12913F0", Offset = "0x128FFF0", VA = "0x1812913F0")]
		public SandboxV2AdminShopItemDetailStateBean()
		{
		}

		// Token: 0x040203A1 RID: 132001
		[Token(Token = "0x40203A1")]
		[FieldOffset(Offset = "0x10")]
		public int goodIndex;

		// Token: 0x040203A2 RID: 132002
		[Token(Token = "0x40203A2")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x040203A3 RID: 132003
		[Token(Token = "0x40203A3")]
		[FieldOffset(Offset = "0x20")]
		public bool hasBought;

		// Token: 0x040203A4 RID: 132004
		[Token(Token = "0x40203A4")]
		[FieldOffset(Offset = "0x21")]
		public bool showDimensionCoin;

		// Token: 0x040203A5 RID: 132005
		[Token(Token = "0x40203A5")]
		[FieldOffset(Offset = "0x22")]
		public bool showGold;

		// Token: 0x040203A6 RID: 132006
		[Token(Token = "0x40203A6")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2AdminShopItemDetailProperty property;

		// Token: 0x040203A7 RID: 132007
		[Token(Token = "0x40203A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
