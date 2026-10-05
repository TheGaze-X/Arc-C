using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007597 RID: 30103
	[Token(Token = "0x2007597")]
	public class Act24sideEntryBattleTrapViewModel : IHotfixable
	{
		// Token: 0x0602A5E8 RID: 173544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5E8")]
		[Address(RVA = "0x2606FF0", Offset = "0x2605BF0", VA = "0x182606FF0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602A5E9 RID: 173545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5E9")]
		[Address(RVA = "0x26070C0", Offset = "0x2605CC0", VA = "0x1826070C0")]
		private void _InitData(string actId)
		{
		}

		// Token: 0x0602A5EA RID: 173546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5EA")]
		[Address(RVA = "0x2607350", Offset = "0x2605F50", VA = "0x182607350")]
		public Act24sideEntryBattleTrapViewModel()
		{
		}

		// Token: 0x0403CF40 RID: 249664
		[Token(Token = "0x403CF40")]
		[FieldOffset(Offset = "0x10")]
		public bool isHaveNew;

		// Token: 0x0403CF41 RID: 249665
		[Token(Token = "0x403CF41")]
		[FieldOffset(Offset = "0x11")]
		public bool timeOut;

		// Token: 0x0403CF42 RID: 249666
		[Token(Token = "0x403CF42")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, Act24SideData.ToolData> m_actToolData;

		// Token: 0x0403CF43 RID: 249667
		[Token(Token = "0x403CF43")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0403CF44 RID: 249668
		[Token(Token = "0x403CF44")]
		[FieldOffset(Offset = "0x28")]
		private long m_endTime;

		// Token: 0x0403CF45 RID: 249669
		[Token(Token = "0x403CF45")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_idList;

		// Token: 0x0403CF46 RID: 249670
		[Token(Token = "0x403CF46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CF47 RID: 249671
		[Token(Token = "0x403CF47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0403CF48 RID: 249672
		[Token(Token = "0x403CF48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
