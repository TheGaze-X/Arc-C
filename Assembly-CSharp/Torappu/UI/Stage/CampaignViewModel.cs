using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020068AA RID: 26794
	[Token(Token = "0x20068AA")]
	public class CampaignViewModel
	{
		// Token: 0x06026656 RID: 157270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026656")]
		[Address(RVA = "0x2178680", Offset = "0x2177280", VA = "0x182178680")]
		public CampaignViewModel(CampaignData campData)
		{
		}

		// Token: 0x06026657 RID: 157271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026657")]
		[Address(RVA = "0x2178560", Offset = "0x2177160", VA = "0x182178560")]
		public void SetPlayerData(PlayerCampaign.Stage instance)
		{
		}

		// Token: 0x0403611E RID: 221470
		[Token(Token = "0x403611E")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403611F RID: 221471
		[Token(Token = "0x403611F")]
		[FieldOffset(Offset = "0x18")]
		public int curMaxKillCnt;

		// Token: 0x04036120 RID: 221472
		[Token(Token = "0x4036120")]
		[FieldOffset(Offset = "0x20")]
		public List<CampaignViewModel.BreakLadderViewModel> breakLadders;

		// Token: 0x04036121 RID: 221473
		[Token(Token = "0x4036121")]
		[FieldOffset(Offset = "0x28")]
		public List<StageRewardViewModel> displayRewards;

		// Token: 0x020068AB RID: 26795
		[Token(Token = "0x20068AB")]
		public class BreakLadderViewModel
		{
			// Token: 0x17005A94 RID: 23188
			// (get) Token: 0x06026658 RID: 157272 RVA: 0x000CAD40 File Offset: 0x000C8F40
			[Token(Token = "0x17005A94")]
			public bool isReadyToConfirm
			{
				[Token(Token = "0x6026658")]
				[Address(RVA = "0x21005D0", Offset = "0x20FF1D0", VA = "0x1821005D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005A95 RID: 23189
			// (get) Token: 0x06026659 RID: 157273 RVA: 0x000CAD58 File Offset: 0x000C8F58
			[Token(Token = "0x17005A95")]
			public bool isConfirmed
			{
				[Token(Token = "0x6026659")]
				[Address(RVA = "0x2178550", Offset = "0x2177150", VA = "0x182178550")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602665A RID: 157274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602665A")]
			[Address(RVA = "0x21783B0", Offset = "0x2176FB0", VA = "0x1821783B0")]
			public BreakLadderViewModel(CampaignData.BreakRewardLadder breakLadder, int index_)
			{
			}

			// Token: 0x04036122 RID: 221474
			[Token(Token = "0x4036122")]
			[FieldOffset(Offset = "0x10")]
			public int killCnt;

			// Token: 0x04036123 RID: 221475
			[Token(Token = "0x4036123")]
			[FieldOffset(Offset = "0x14")]
			public int breakFeeAdd;

			// Token: 0x04036124 RID: 221476
			[Token(Token = "0x4036124")]
			[FieldOffset(Offset = "0x18")]
			public UIItemViewModel[] rewards;

			// Token: 0x04036125 RID: 221477
			[Token(Token = "0x4036125")]
			[FieldOffset(Offset = "0x20")]
			public CampaignViewModel.BreakLadderViewModel.State state;

			// Token: 0x04036126 RID: 221478
			[Token(Token = "0x4036126")]
			[FieldOffset(Offset = "0x24")]
			public int index;

			// Token: 0x020068AC RID: 26796
			[Token(Token = "0x20068AC")]
			public enum State
			{
				// Token: 0x04036128 RID: 221480
				[Token(Token = "0x4036128")]
				UNREACHED,
				// Token: 0x04036129 RID: 221481
				[Token(Token = "0x4036129")]
				REACHED_BUT_NOT_CONFIRMED,
				// Token: 0x0403612A RID: 221482
				[Token(Token = "0x403612A")]
				CONFIRMED
			}
		}
	}
}
