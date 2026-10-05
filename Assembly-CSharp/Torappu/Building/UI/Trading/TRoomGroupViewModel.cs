using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C2B RID: 7211
	[Token(Token = "0x2001C2B")]
	public class TRoomGroupViewModel : IBasicRoomGroupModel, IHotfixable
	{
		// Token: 0x0600B398 RID: 45976 RVA: 0x00044370 File Offset: 0x00042570
		[Token(Token = "0x600B398")]
		[Address(RVA = "0x32E6330", Offset = "0x32E4F30", VA = "0x1832E6330", Slot = "5")]
		public int GetRoomNum()
		{
			return 0;
		}

		// Token: 0x0600B399 RID: 45977 RVA: 0x00044388 File Offset: 0x00042588
		[Token(Token = "0x600B399")]
		[Address(RVA = "0x32E6200", Offset = "0x32E4E00", VA = "0x1832E6200", Slot = "6")]
		public BasicRoomInfoModel GetRoomInfo(int index)
		{
			return default(BasicRoomInfoModel);
		}

		// Token: 0x0600B39A RID: 45978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B39A")]
		[Address(RVA = "0x32E63A0", Offset = "0x32E4FA0", VA = "0x1832E63A0", Slot = "4")]
		public string GetSelectedSlotId()
		{
			return null;
		}

		// Token: 0x0600B39B RID: 45979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B39B")]
		[Address(RVA = "0x32E6400", Offset = "0x32E5000", VA = "0x1832E6400")]
		public TRoomGroupViewModel()
		{
		}

		// Token: 0x0400AEFD RID: 44797
		[Token(Token = "0x400AEFD")]
		[FieldOffset(Offset = "0x10")]
		public int maxTradingRoom;

		// Token: 0x0400AEFE RID: 44798
		[Token(Token = "0x400AEFE")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, TRoomViewModel> rooms;

		// Token: 0x0400AEFF RID: 44799
		[Token(Token = "0x400AEFF")]
		[FieldOffset(Offset = "0x20")]
		public string selectedSlotId;

		// Token: 0x0400AF00 RID: 44800
		[Token(Token = "0x400AF00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRoomNum;

		// Token: 0x0400AF01 RID: 44801
		[Token(Token = "0x400AF01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRoomInfo;

		// Token: 0x0400AF02 RID: 44802
		[Token(Token = "0x400AF02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSelectedSlotId;

		// Token: 0x0400AF03 RID: 44803
		[Token(Token = "0x400AF03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
