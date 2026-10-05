using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C27 RID: 7207
	[Token(Token = "0x2001C27")]
	public class TradingStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B38B RID: 45963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B38B")]
		[Address(RVA = "0x32E6E90", Offset = "0x32E5A90", VA = "0x1832E6E90")]
		public void SetSelectedRoom(string slotId, bool forceUpdate = false)
		{
		}

		// Token: 0x0600B38C RID: 45964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B38C")]
		[Address(RVA = "0x32E67A0", Offset = "0x32E53A0", VA = "0x1832E67A0")]
		public void InitData()
		{
		}

		// Token: 0x0600B38D RID: 45965 RVA: 0x00044310 File Offset: 0x00042510
		[Token(Token = "0x600B38D")]
		[Address(RVA = "0x32E6DE0", Offset = "0x32E59E0", VA = "0x1832E6DE0")]
		public bool IsValidNextOrder(long orderInstId)
		{
			return default(bool);
		}

		// Token: 0x0600B38E RID: 45966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B38E")]
		[Address(RVA = "0x32E70E0", Offset = "0x32E5CE0", VA = "0x1832E70E0")]
		public void UpdateData()
		{
		}

		// Token: 0x0600B38F RID: 45967 RVA: 0x00044328 File Offset: 0x00042528
		[Token(Token = "0x600B38F")]
		[Address(RVA = "0x32E74A0", Offset = "0x32E60A0", VA = "0x1832E74A0")]
		private bool _CheckTabTrackPoint(TradingInfoViewStruct tradingInfo)
		{
			return default(bool);
		}

		// Token: 0x0600B390 RID: 45968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B390")]
		[Address(RVA = "0x32E7660", Offset = "0x32E6260", VA = "0x1832E7660")]
		private void _UpdateOrderGroupProperty(TRoomViewModel selectedRoom)
		{
		}

		// Token: 0x0600B391 RID: 45969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B391")]
		[Address(RVA = "0x32E7720", Offset = "0x32E6320", VA = "0x1832E7720")]
		public TradingStateBean()
		{
		}

		// Token: 0x0400AEED RID: 44781
		[Token(Token = "0x400AEED")]
		[FieldOffset(Offset = "0x10")]
		public TRoomGroupViewProperty roomsProp;

		// Token: 0x0400AEEE RID: 44782
		[Token(Token = "0x400AEEE")]
		[FieldOffset(Offset = "0x18")]
		public TRoomViewProperty selectedRoomProp;

		// Token: 0x0400AEEF RID: 44783
		[Token(Token = "0x400AEEF")]
		[FieldOffset(Offset = "0x20")]
		public TOrderSlotGroupViewProperty orderSlotProp;

		// Token: 0x0400AEF0 RID: 44784
		[Token(Token = "0x400AEF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSelectedRoom;

		// Token: 0x0400AEF1 RID: 44785
		[Token(Token = "0x400AEF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0400AEF2 RID: 44786
		[Token(Token = "0x400AEF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsValidNextOrder;

		// Token: 0x0400AEF3 RID: 44787
		[Token(Token = "0x400AEF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0400AEF4 RID: 44788
		[Token(Token = "0x400AEF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckTabTrackPoint;

		// Token: 0x0400AEF5 RID: 44789
		[Token(Token = "0x400AEF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateOrderGroupProperty;

		// Token: 0x0400AEF6 RID: 44790
		[Token(Token = "0x400AEF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
