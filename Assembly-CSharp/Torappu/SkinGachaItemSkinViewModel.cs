using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000864 RID: 2148
	[Token(Token = "0x2000864")]
	public class SkinGachaItemSkinViewModel : IHotfixable
	{
		// Token: 0x060064FE RID: 25854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FE")]
		[Address(RVA = "0x1F018C0", Offset = "0x1F004C0", VA = "0x181F018C0")]
		public SkinGachaItemSkinViewModel()
		{
		}

		// Token: 0x04003181 RID: 12673
		[Token(Token = "0x4003181")]
		[FieldOffset(Offset = "0x10")]
		public string skinId;

		// Token: 0x04003182 RID: 12674
		[Token(Token = "0x4003182")]
		[FieldOffset(Offset = "0x18")]
		public SkinObtainApproachType displayType;

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		[FieldOffset(Offset = "0x20")]
		public string displayStr;

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x04003185 RID: 12677
		[Token(Token = "0x4003185")]
		[FieldOffset(Offset = "0x2C")]
		public int price;

		// Token: 0x04003186 RID: 12678
		[Token(Token = "0x4003186")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
