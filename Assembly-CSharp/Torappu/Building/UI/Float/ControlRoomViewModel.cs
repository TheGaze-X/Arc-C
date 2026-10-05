using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DE3 RID: 7651
	[Token(Token = "0x2001DE3")]
	public class ControlRoomViewModel : IHotfixable
	{
		// Token: 0x0600BCD7 RID: 48343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD7")]
		[Address(RVA = "0x33B0840", Offset = "0x33AF440", VA = "0x1833B0840")]
		public void LoadData()
		{
		}

		// Token: 0x0600BCD8 RID: 48344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD8")]
		[Address(RVA = "0x33B0A50", Offset = "0x33AF650", VA = "0x1833B0A50")]
		public ControlRoomViewModel()
		{
		}

		// Token: 0x0400BCF9 RID: 48377
		[Token(Token = "0x400BCF9")]
		[FieldOffset(Offset = "0x10")]
		public long mpReducePerHour;

		// Token: 0x0400BCFA RID: 48378
		[Token(Token = "0x400BCFA")]
		[FieldOffset(Offset = "0x18")]
		public long mpCostPerHourBase;

		// Token: 0x0400BCFB RID: 48379
		[Token(Token = "0x400BCFB")]
		[FieldOffset(Offset = "0x20")]
		public long mpCostPerHourBuff;

		// Token: 0x0400BCFC RID: 48380
		[Token(Token = "0x400BCFC")]
		[FieldOffset(Offset = "0x28")]
		public bool showAssistTrackPoint;

		// Token: 0x0400BCFD RID: 48381
		[Token(Token = "0x400BCFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400BCFE RID: 48382
		[Token(Token = "0x400BCFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
