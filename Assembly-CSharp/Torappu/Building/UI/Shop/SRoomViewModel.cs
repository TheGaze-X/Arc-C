using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CEC RID: 7404
	[Token(Token = "0x2001CEC")]
	public class SRoomViewModel : IBasicRoomModel, IHotfixable
	{
		// Token: 0x0600B6F1 RID: 46833 RVA: 0x00045120 File Offset: 0x00043320
		[Token(Token = "0x600B6F1")]
		[Address(RVA = "0x33507C0", Offset = "0x334F3C0", VA = "0x1833507C0", Slot = "4")]
		public BasicRoomInfoModel GetRoomInfo()
		{
			return default(BasicRoomInfoModel);
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6F2")]
		[Address(RVA = "0x3350850", Offset = "0x334F450", VA = "0x183350850")]
		public SRoomViewModel()
		{
		}

		// Token: 0x0400B4BF RID: 46271
		[Token(Token = "0x400B4BF")]
		[FieldOffset(Offset = "0x10")]
		public BasicRoomInfoModel basicInfo;

		// Token: 0x0400B4C0 RID: 46272
		[Token(Token = "0x400B4C0")]
		[FieldOffset(Offset = "0x40")]
		public ShopInfoViewModel shopInfo;

		// Token: 0x0400B4C1 RID: 46273
		[Token(Token = "0x400B4C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRoomInfo;

		// Token: 0x0400B4C2 RID: 46274
		[Token(Token = "0x400B4C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
