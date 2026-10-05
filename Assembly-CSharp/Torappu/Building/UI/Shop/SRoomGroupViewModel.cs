using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CEE RID: 7406
	[Token(Token = "0x2001CEE")]
	public class SRoomGroupViewModel : IBasicRoomGroupModel, IHotfixable
	{
		// Token: 0x0600B6F4 RID: 46836 RVA: 0x00045138 File Offset: 0x00043338
		[Token(Token = "0x600B6F4")]
		[Address(RVA = "0x33505E0", Offset = "0x334F1E0", VA = "0x1833505E0", Slot = "5")]
		public int GetRoomNum()
		{
			return 0;
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x00045150 File Offset: 0x00043350
		[Token(Token = "0x600B6F5")]
		[Address(RVA = "0x33504A0", Offset = "0x334F0A0", VA = "0x1833504A0", Slot = "6")]
		public BasicRoomInfoModel GetRoomInfo(int index)
		{
			return default(BasicRoomInfoModel);
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6F6")]
		[Address(RVA = "0x3350650", Offset = "0x334F250", VA = "0x183350650", Slot = "4")]
		public string GetSelectedSlotId()
		{
			return null;
		}

		// Token: 0x0600B6F7 RID: 46839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6F7")]
		[Address(RVA = "0x33506B0", Offset = "0x334F2B0", VA = "0x1833506B0")]
		public SRoomGroupViewModel()
		{
		}

		// Token: 0x0400B4C3 RID: 46275
		[Token(Token = "0x400B4C3")]
		[FieldOffset(Offset = "0x10")]
		public int maxShopRoom;

		// Token: 0x0400B4C4 RID: 46276
		[Token(Token = "0x400B4C4")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, SRoomViewModel> rooms;

		// Token: 0x0400B4C5 RID: 46277
		[Token(Token = "0x400B4C5")]
		[FieldOffset(Offset = "0x20")]
		public string selectedSlotId;

		// Token: 0x0400B4C6 RID: 46278
		[Token(Token = "0x400B4C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRoomNum;

		// Token: 0x0400B4C7 RID: 46279
		[Token(Token = "0x400B4C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRoomInfo;

		// Token: 0x0400B4C8 RID: 46280
		[Token(Token = "0x400B4C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSelectedSlotId;

		// Token: 0x0400B4C9 RID: 46281
		[Token(Token = "0x400B4C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
