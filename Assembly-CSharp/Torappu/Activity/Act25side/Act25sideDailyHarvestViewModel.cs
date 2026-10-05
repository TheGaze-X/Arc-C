using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007523 RID: 29987
	[Token(Token = "0x2007523")]
	public class Act25sideDailyHarvestViewModel : IHotfixable
	{
		// Token: 0x1700636B RID: 25451
		// (get) Token: 0x0602A411 RID: 173073 RVA: 0x000D7C58 File Offset: 0x000D5E58
		[Token(Token = "0x1700636B")]
		public int harvestRewardCnt
		{
			[Token(Token = "0x602A411")]
			[Address(RVA = "0x25DC450", Offset = "0x25DB050", VA = "0x1825DC450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700636C RID: 25452
		// (get) Token: 0x0602A412 RID: 173074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700636C")]
		public PlayerActivity.PlayerAct25SideActivity.DailyHarvest dailyHarvest
		{
			[Token(Token = "0x602A412")]
			[Address(RVA = "0x25DC3F0", Offset = "0x25DAFF0", VA = "0x1825DC3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700636D RID: 25453
		// (get) Token: 0x0602A413 RID: 173075 RVA: 0x000D7C70 File Offset: 0x000D5E70
		[Token(Token = "0x1700636D")]
		public long nearestHarvestTimeSecs
		{
			[Token(Token = "0x602A413")]
			[Address(RVA = "0x25DC4B0", Offset = "0x25DB0B0", VA = "0x1825DC4B0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700636E RID: 25454
		// (get) Token: 0x0602A414 RID: 173076 RVA: 0x000D7C88 File Offset: 0x000D5E88
		[Token(Token = "0x1700636E")]
		public long nearestHarvestTimestamp
		{
			[Token(Token = "0x602A414")]
			[Address(RVA = "0x25DC610", Offset = "0x25DB210", VA = "0x1825DC610")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700636F RID: 25455
		// (get) Token: 0x0602A415 RID: 173077 RVA: 0x000D7CA0 File Offset: 0x000D5EA0
		[Token(Token = "0x1700636F")]
		public bool rewardMax
		{
			[Token(Token = "0x602A415")]
			[Address(RVA = "0x25DC760", Offset = "0x25DB360", VA = "0x1825DC760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A416 RID: 173078 RVA: 0x000D7CB8 File Offset: 0x000D5EB8
		[Token(Token = "0x602A416")]
		[Address(RVA = "0x25DC060", Offset = "0x25DAC60", VA = "0x1825DC060")]
		private long _CalNearestHarvestTimeSecs()
		{
			return 0L;
		}

		// Token: 0x0602A417 RID: 173079 RVA: 0x000D7CD0 File Offset: 0x000D5ED0
		[Token(Token = "0x602A417")]
		[Address(RVA = "0x25DC170", Offset = "0x25DAD70", VA = "0x1825DC170")]
		private long _CalNearestHarvestTimestamp()
		{
			return 0L;
		}

		// Token: 0x0602A418 RID: 173080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A418")]
		[Address(RVA = "0x25DBE50", Offset = "0x25DAA50", VA = "0x1825DBE50")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602A419 RID: 173081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A419")]
		[Address(RVA = "0x25DC270", Offset = "0x25DAE70", VA = "0x1825DC270")]
		private void _CalculateReward(PlayerActivity.PlayerAct25SideActivity.DailyHarvest harvestData)
		{
		}

		// Token: 0x0602A41A RID: 173082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A41A")]
		[Address(RVA = "0x25DC390", Offset = "0x25DAF90", VA = "0x1825DC390")]
		public Act25sideDailyHarvestViewModel()
		{
		}

		// Token: 0x0403CBF4 RID: 248820
		[Token(Token = "0x403CBF4")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403CBF5 RID: 248821
		[Token(Token = "0x403CBF5")]
		[FieldOffset(Offset = "0x18")]
		private int m_rewardCnt;

		// Token: 0x0403CBF6 RID: 248822
		[Token(Token = "0x403CBF6")]
		[FieldOffset(Offset = "0x1C")]
		private int m_rewardLimit;

		// Token: 0x0403CBF7 RID: 248823
		[Token(Token = "0x403CBF7")]
		[FieldOffset(Offset = "0x20")]
		private PlayerActivity.PlayerAct25SideActivity.DailyHarvest m_dailyHarvest;

		// Token: 0x0403CBF8 RID: 248824
		[Token(Token = "0x403CBF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_harvestRewardCnt;

		// Token: 0x0403CBF9 RID: 248825
		[Token(Token = "0x403CBF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dailyHarvest;

		// Token: 0x0403CBFA RID: 248826
		[Token(Token = "0x403CBFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_nearestHarvestTimeSecs;

		// Token: 0x0403CBFB RID: 248827
		[Token(Token = "0x403CBFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nearestHarvestTimestamp;

		// Token: 0x0403CBFC RID: 248828
		[Token(Token = "0x403CBFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rewardMax;

		// Token: 0x0403CBFD RID: 248829
		[Token(Token = "0x403CBFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalNearestHarvestTimeSecs;

		// Token: 0x0403CBFE RID: 248830
		[Token(Token = "0x403CBFE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalNearestHarvestTimestamp;

		// Token: 0x0403CBFF RID: 248831
		[Token(Token = "0x403CBFF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC00 RID: 248832
		[Token(Token = "0x403CC00")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CalculateReward;

		// Token: 0x0403CC01 RID: 248833
		[Token(Token = "0x403CC01")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
