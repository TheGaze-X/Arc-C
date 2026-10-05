using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A05 RID: 18949
	[Token(Token = "0x2004A05")]
	public class InformantHomeViewModel : IHotfixable
	{
		// Token: 0x0601C856 RID: 116822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C856")]
		[Address(RVA = "0x15F8A50", Offset = "0x15F7650", VA = "0x1815F8A50")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x0601C857 RID: 116823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C857")]
		[Address(RVA = "0x15F8E20", Offset = "0x15F7A20", VA = "0x1815F8E20")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601C858 RID: 116824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C858")]
		[Address(RVA = "0x15F9660", Offset = "0x15F8260", VA = "0x1815F9660")]
		public InformantHomeViewModel()
		{
		}

		// Token: 0x04025631 RID: 153137
		[Token(Token = "0x4025631")]
		[FieldOffset(Offset = "0x10")]
		public InformantHomeViewModel.State state;

		// Token: 0x04025632 RID: 153138
		[Token(Token = "0x4025632")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x04025633 RID: 153139
		[Token(Token = "0x4025633")]
		[FieldOffset(Offset = "0x20")]
		public int itemCost;

		// Token: 0x04025634 RID: 153140
		[Token(Token = "0x4025634")]
		[FieldOffset(Offset = "0x28")]
		public string itemName;

		// Token: 0x04025635 RID: 153141
		[Token(Token = "0x4025635")]
		[FieldOffset(Offset = "0x30")]
		public string itemCount;

		// Token: 0x04025636 RID: 153142
		[Token(Token = "0x4025636")]
		[FieldOffset(Offset = "0x38")]
		public int day;

		// Token: 0x04025637 RID: 153143
		[Token(Token = "0x4025637")]
		[FieldOffset(Offset = "0x3C")]
		public int milestonePoint;

		// Token: 0x04025638 RID: 153144
		[Token(Token = "0x4025638")]
		[FieldOffset(Offset = "0x40")]
		public List<bool> specialCustomerUnlockList;

		// Token: 0x04025639 RID: 153145
		[Token(Token = "0x4025639")]
		[FieldOffset(Offset = "0x48")]
		public bool showMilestoneTrackPoint;

		// Token: 0x0402563A RID: 153146
		[Token(Token = "0x402563A")]
		[FieldOffset(Offset = "0x49")]
		public bool isMilestoneComplete;

		// Token: 0x0402563B RID: 153147
		[Token(Token = "0x402563B")]
		[FieldOffset(Offset = "0x4A")]
		public bool isNew;

		// Token: 0x0402563C RID: 153148
		[Token(Token = "0x402563C")]
		[FieldOffset(Offset = "0x4C")]
		private int m_itemCount;

		// Token: 0x0402563D RID: 153149
		[Token(Token = "0x402563D")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, int> m_milestonePointDict;

		// Token: 0x0402563E RID: 153150
		[Token(Token = "0x402563E")]
		[FieldOffset(Offset = "0x58")]
		private List<string> m_specialCustomerIdList;

		// Token: 0x0402563F RID: 153151
		[Token(Token = "0x402563F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025640 RID: 153152
		[Token(Token = "0x4025640")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04025641 RID: 153153
		[Token(Token = "0x4025641")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A06 RID: 18950
		[Token(Token = "0x2004A06")]
		public enum State
		{
			// Token: 0x04025643 RID: 153155
			[Token(Token = "0x4025643")]
			WAIT_START,
			// Token: 0x04025644 RID: 153156
			[Token(Token = "0x4025644")]
			CONTINUE,
			// Token: 0x04025645 RID: 153157
			[Token(Token = "0x4025645")]
			ITEM_LOCKED,
			// Token: 0x04025646 RID: 153158
			[Token(Token = "0x4025646")]
			CLOSE
		}
	}
}
