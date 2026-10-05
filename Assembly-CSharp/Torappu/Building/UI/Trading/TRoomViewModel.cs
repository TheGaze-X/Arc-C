using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C29 RID: 7209
	[Token(Token = "0x2001C29")]
	public class TRoomViewModel : IBasicRoomModel, IHotfixable
	{
		// Token: 0x0600B395 RID: 45973 RVA: 0x00044358 File Offset: 0x00042558
		[Token(Token = "0x600B395")]
		[Address(RVA = "0x32E6510", Offset = "0x32E5110", VA = "0x1832E6510", Slot = "4")]
		public BasicRoomInfoModel GetRoomInfo()
		{
			return default(BasicRoomInfoModel);
		}

		// Token: 0x0600B396 RID: 45974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B396")]
		[Address(RVA = "0x32E65A0", Offset = "0x32E51A0", VA = "0x1832E65A0")]
		public TRoomViewModel()
		{
		}

		// Token: 0x0400AEF9 RID: 44793
		[Token(Token = "0x400AEF9")]
		[FieldOffset(Offset = "0x10")]
		public BasicRoomInfoModel basicInfo;

		// Token: 0x0400AEFA RID: 44794
		[Token(Token = "0x400AEFA")]
		[FieldOffset(Offset = "0x40")]
		public TradingInfoViewStruct info;

		// Token: 0x0400AEFB RID: 44795
		[Token(Token = "0x400AEFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRoomInfo;

		// Token: 0x0400AEFC RID: 44796
		[Token(Token = "0x400AEFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
