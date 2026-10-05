using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007839 RID: 30777
	[Token(Token = "0x2007839")]
	public class Act1VHalfIdleBattleFinishIncomeViewModel : IHotfixable
	{
		// Token: 0x17006507 RID: 25863
		// (get) Token: 0x0602B2B6 RID: 176822 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2B7 RID: 176823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006507")]
		public string stageId
		{
			[Token(Token = "0x602B2B6")]
			[Address(RVA = "0x26F2FA0", Offset = "0x26F1BA0", VA = "0x1826F2FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B2B7")]
			[Address(RVA = "0x26F31B0", Offset = "0x26F1DB0", VA = "0x1826F31B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006508 RID: 25864
		// (get) Token: 0x0602B2B8 RID: 176824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2B9 RID: 176825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006508")]
		public string stageName
		{
			[Token(Token = "0x602B2B8")]
			[Address(RVA = "0x26F3000", Offset = "0x26F1C00", VA = "0x1826F3000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B2B9")]
			[Address(RVA = "0x26F3230", Offset = "0x26F1E30", VA = "0x1826F3230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006509 RID: 25865
		// (get) Token: 0x0602B2BA RID: 176826 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2BB RID: 176827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006509")]
		public string stageCode
		{
			[Token(Token = "0x602B2BA")]
			[Address(RVA = "0x26F2F40", Offset = "0x26F1B40", VA = "0x1826F2F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B2BB")]
			[Address(RVA = "0x26F3130", Offset = "0x26F1D30", VA = "0x1826F3130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700650A RID: 25866
		// (get) Token: 0x0602B2BC RID: 176828 RVA: 0x000DB090 File Offset: 0x000D9290
		// (set) Token: 0x0602B2BD RID: 176829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700650A")]
		public int stagePrg
		{
			[Token(Token = "0x602B2BC")]
			[Address(RVA = "0x26F3060", Offset = "0x26F1C60", VA = "0x1826F3060")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602B2BD")]
			[Address(RVA = "0x26F32B0", Offset = "0x26F1EB0", VA = "0x1826F32B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700650B RID: 25867
		// (get) Token: 0x0602B2BE RID: 176830 RVA: 0x000DB0A8 File Offset: 0x000D92A8
		// (set) Token: 0x0602B2BF RID: 176831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700650B")]
		public PlayerActivity.PlayerAct1VHalfIdleActivity.BossState bossState
		{
			[Token(Token = "0x602B2BE")]
			[Address(RVA = "0x26F2EE0", Offset = "0x26F1AE0", VA = "0x1826F2EE0")]
			[CompilerGenerated]
			get
			{
				return PlayerActivity.PlayerAct1VHalfIdleActivity.BossState.NO_APPEAR;
			}
			[Token(Token = "0x602B2BF")]
			[Address(RVA = "0x26F30C0", Offset = "0x26F1CC0", VA = "0x1826F30C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B2C0 RID: 176832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2C0")]
		[Address(RVA = "0x26F2C60", Offset = "0x26F1860", VA = "0x1826F2C60")]
		public void LoadFromSettleInfo(string activityId)
		{
		}

		// Token: 0x0602B2C1 RID: 176833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2C1")]
		[Address(RVA = "0x26F2B00", Offset = "0x26F1700", VA = "0x1826F2B00")]
		public void LoadFromBattleFinishResp(string activityId, BattleStageInfo stageInfo, Act1VHalfIdleBattleFinishResponse resp)
		{
		}

		// Token: 0x0602B2C2 RID: 176834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2C2")]
		[Address(RVA = "0x26F2E40", Offset = "0x26F1A40", VA = "0x1826F2E40")]
		public Act1VHalfIdleBattleFinishIncomeViewModel()
		{
		}

		// Token: 0x0403E675 RID: 255605
		[Token(Token = "0x403E675")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleIncomeGraphViewModel graphViewModel;

		// Token: 0x0403E67B RID: 255611
		[Token(Token = "0x403E67B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403E67C RID: 255612
		[Token(Token = "0x403E67C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_stageId;

		// Token: 0x0403E67D RID: 255613
		[Token(Token = "0x403E67D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stageName;

		// Token: 0x0403E67E RID: 255614
		[Token(Token = "0x403E67E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_stageName;

		// Token: 0x0403E67F RID: 255615
		[Token(Token = "0x403E67F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageCode;

		// Token: 0x0403E680 RID: 255616
		[Token(Token = "0x403E680")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_stageCode;

		// Token: 0x0403E681 RID: 255617
		[Token(Token = "0x403E681")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_stagePrg;

		// Token: 0x0403E682 RID: 255618
		[Token(Token = "0x403E682")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_stagePrg;

		// Token: 0x0403E683 RID: 255619
		[Token(Token = "0x403E683")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bossState;

		// Token: 0x0403E684 RID: 255620
		[Token(Token = "0x403E684")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_bossState;

		// Token: 0x0403E685 RID: 255621
		[Token(Token = "0x403E685")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadFromSettleInfo;

		// Token: 0x0403E686 RID: 255622
		[Token(Token = "0x403E686")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadFromBattleFinishResp;

		// Token: 0x0403E687 RID: 255623
		[Token(Token = "0x403E687")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
