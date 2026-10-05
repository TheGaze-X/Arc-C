using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200612E RID: 24878
	[Token(Token = "0x200612E")]
	public class CampaignBreakDetailItemViewModel : IHotfixable, IComparable
	{
		// Token: 0x170054D2 RID: 21714
		// (get) Token: 0x06023ECD RID: 147149 RVA: 0x000C2658 File Offset: 0x000C0858
		[Token(Token = "0x170054D2")]
		public bool isConfirmed
		{
			[Token(Token = "0x6023ECD")]
			[Address(RVA = "0x1E85040", Offset = "0x1E83C40", VA = "0x181E85040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170054D3 RID: 21715
		// (get) Token: 0x06023ECE RID: 147150 RVA: 0x000C2670 File Offset: 0x000C0870
		[Token(Token = "0x170054D3")]
		public bool needConfirm
		{
			[Token(Token = "0x6023ECE")]
			[Address(RVA = "0x1E850A0", Offset = "0x1E83CA0", VA = "0x181E850A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023ECF RID: 147151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ECF")]
		[Address(RVA = "0x1E84EB0", Offset = "0x1E83AB0", VA = "0x181E84EB0")]
		public CampaignBreakDetailItemViewModel(CampaignData.BreakRewardLadder breakLadder, int index_)
		{
		}

		// Token: 0x06023ED0 RID: 147152 RVA: 0x000C2688 File Offset: 0x000C0888
		[Token(Token = "0x6023ED0")]
		[Address(RVA = "0x1E84CC0", Offset = "0x1E838C0", VA = "0x181E84CC0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04031DD6 RID: 204246
		[Token(Token = "0x4031DD6")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x04031DD7 RID: 204247
		[Token(Token = "0x4031DD7")]
		[FieldOffset(Offset = "0x14")]
		public CampaignBreakDetailItemViewModel.State currState;

		// Token: 0x04031DD8 RID: 204248
		[Token(Token = "0x4031DD8")]
		[FieldOffset(Offset = "0x18")]
		public float progress;

		// Token: 0x04031DD9 RID: 204249
		[Token(Token = "0x4031DD9")]
		[FieldOffset(Offset = "0x1C")]
		public int killCnt;

		// Token: 0x04031DDA RID: 204250
		[Token(Token = "0x4031DDA")]
		[FieldOffset(Offset = "0x20")]
		public string progressDesc;

		// Token: 0x04031DDB RID: 204251
		[Token(Token = "0x4031DDB")]
		[FieldOffset(Offset = "0x28")]
		public int breakFeeAdd;

		// Token: 0x04031DDC RID: 204252
		[Token(Token = "0x4031DDC")]
		[FieldOffset(Offset = "0x30")]
		public List<UIItemViewModel> rewardList;

		// Token: 0x04031DDD RID: 204253
		[Token(Token = "0x4031DDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isConfirmed;

		// Token: 0x04031DDE RID: 204254
		[Token(Token = "0x4031DDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needConfirm;

		// Token: 0x04031DDF RID: 204255
		[Token(Token = "0x4031DDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04031DE0 RID: 204256
		[Token(Token = "0x4031DE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0200612F RID: 24879
		[Token(Token = "0x200612F")]
		public enum State
		{
			// Token: 0x04031DE2 RID: 204258
			[Token(Token = "0x4031DE2")]
			UNREACHED,
			// Token: 0x04031DE3 RID: 204259
			[Token(Token = "0x4031DE3")]
			REACHED_BUT_NOT_CONFIRMED,
			// Token: 0x04031DE4 RID: 204260
			[Token(Token = "0x4031DE4")]
			CONFIRMED
		}
	}
}
