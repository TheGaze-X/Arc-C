using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C2E RID: 7214
	[Token(Token = "0x2001C2E")]
	public class TOrderSlotGroupViewModel : IHotfixable
	{
		// Token: 0x0600B39E RID: 45982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B39E")]
		[Address(RVA = "0x32E5640", Offset = "0x32E4240", VA = "0x1832E5640")]
		public void LoadData(TRoomViewModel roomModel)
		{
		}

		// Token: 0x0600B39F RID: 45983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B39F")]
		[Address(RVA = "0x32E6030", Offset = "0x32E4C30", VA = "0x1832E6030")]
		public TOrderSlotGroupViewModel()
		{
		}

		// Token: 0x0400AF08 RID: 44808
		[Token(Token = "0x400AF08")]
		[FieldOffset(Offset = "0x10")]
		private string m_roomIdCache;

		// Token: 0x0400AF09 RID: 44809
		[Token(Token = "0x400AF09")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<long, TradingOrderStruct> m_sortList;

		// Token: 0x0400AF0A RID: 44810
		[Token(Token = "0x400AF0A")]
		[FieldOffset(Offset = "0x20")]
		public TradingInfoViewStruct info;

		// Token: 0x0400AF0B RID: 44811
		[Token(Token = "0x400AF0B")]
		[FieldOffset(Offset = "0xA0")]
		public int nonEmptySlotCount;

		// Token: 0x0400AF0C RID: 44812
		[Token(Token = "0x400AF0C")]
		[FieldOffset(Offset = "0xA4")]
		public bool hasGainingSlot;

		// Token: 0x0400AF0D RID: 44813
		[Token(Token = "0x400AF0D")]
		[FieldOffset(Offset = "0xA8")]
		public List<TOrderSlotStruct> slots;

		// Token: 0x0400AF0E RID: 44814
		[Token(Token = "0x400AF0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400AF0F RID: 44815
		[Token(Token = "0x400AF0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
