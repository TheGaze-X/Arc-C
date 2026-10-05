using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D40 RID: 19776
	[Token(Token = "0x2004D40")]
	public class GroceryMileStoneViewModel : IHotfixable
	{
		// Token: 0x0601D991 RID: 121233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D991")]
		[Address(RVA = "0x1730DB0", Offset = "0x172F9B0", VA = "0x181730DB0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601D992 RID: 121234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D992")]
		[Address(RVA = "0x1731110", Offset = "0x172FD10", VA = "0x181731110")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x0601D993 RID: 121235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D993")]
		[Address(RVA = "0x1731480", Offset = "0x1730080", VA = "0x181731480")]
		public GroceryMileStoneViewModel()
		{
		}

		// Token: 0x04027187 RID: 160135
		[Token(Token = "0x4027187")]
		[FieldOffset(Offset = "0x10")]
		public List<GroceryMileStoneItemViewModel> dataSet;

		// Token: 0x04027188 RID: 160136
		[Token(Token = "0x4027188")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, GroceryMileStoneItemViewModel.State> itemStateMap;

		// Token: 0x04027189 RID: 160137
		[Token(Token = "0x4027189")]
		[FieldOffset(Offset = "0x20")]
		public int focusIndex;

		// Token: 0x0402718A RID: 160138
		[Token(Token = "0x402718A")]
		[FieldOffset(Offset = "0x24")]
		public bool hasItemCanReceive;

		// Token: 0x0402718B RID: 160139
		[Token(Token = "0x402718B")]
		[FieldOffset(Offset = "0x28")]
		public string prizeText;

		// Token: 0x0402718C RID: 160140
		[Token(Token = "0x402718C")]
		[FieldOffset(Offset = "0x30")]
		public List<Act27SideData.Act27SideMileStoneFurniRewardData> furniRewards;

		// Token: 0x0402718D RID: 160141
		[Token(Token = "0x402718D")]
		[FieldOffset(Offset = "0x38")]
		public int point;

		// Token: 0x0402718E RID: 160142
		[Token(Token = "0x402718E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402718F RID: 160143
		[Token(Token = "0x402718F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04027190 RID: 160144
		[Token(Token = "0x4027190")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
