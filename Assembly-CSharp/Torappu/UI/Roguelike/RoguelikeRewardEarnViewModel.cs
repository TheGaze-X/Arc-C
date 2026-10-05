using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005407 RID: 21511
	[Token(Token = "0x2005407")]
	public class RoguelikeRewardEarnViewModel : IHotfixable
	{
		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x0601FA62 RID: 129634 RVA: 0x000B27B8 File Offset: 0x000B09B8
		[Token(Token = "0x17004A2A")]
		public int initHp
		{
			[Token(Token = "0x601FA62")]
			[Address(RVA = "0x19593F0", Offset = "0x1957FF0", VA = "0x1819593F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x0601FA63 RID: 129635 RVA: 0x000B27D0 File Offset: 0x000B09D0
		[Token(Token = "0x17004A2B")]
		public int initShield
		{
			[Token(Token = "0x601FA63")]
			[Address(RVA = "0x1959450", Offset = "0x1958050", VA = "0x181959450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601FA64 RID: 129636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA64")]
		[Address(RVA = "0x1959390", Offset = "0x1957F90", VA = "0x181959390")]
		public RoguelikeRewardEarnViewModel()
		{
		}

		// Token: 0x0402AA66 RID: 174694
		[Token(Token = "0x402AA66")]
		[FieldOffset(Offset = "0x10")]
		public int currentHp;

		// Token: 0x0402AA67 RID: 174695
		[Token(Token = "0x402AA67")]
		[FieldOffset(Offset = "0x14")]
		public int deltaHp;

		// Token: 0x0402AA68 RID: 174696
		[Token(Token = "0x402AA68")]
		[FieldOffset(Offset = "0x18")]
		public int perfectChain;

		// Token: 0x0402AA69 RID: 174697
		[Token(Token = "0x402AA69")]
		[FieldOffset(Offset = "0x1C")]
		public bool hasMaxHpLimit;

		// Token: 0x0402AA6A RID: 174698
		[Token(Token = "0x402AA6A")]
		[FieldOffset(Offset = "0x20")]
		public int currentMaxHp;

		// Token: 0x0402AA6B RID: 174699
		[Token(Token = "0x402AA6B")]
		[FieldOffset(Offset = "0x24")]
		public int deltaMaxHp;

		// Token: 0x0402AA6C RID: 174700
		[Token(Token = "0x402AA6C")]
		[FieldOffset(Offset = "0x28")]
		public int initLevel;

		// Token: 0x0402AA6D RID: 174701
		[Token(Token = "0x402AA6D")]
		[FieldOffset(Offset = "0x2C")]
		public int currentLevel;

		// Token: 0x0402AA6E RID: 174702
		[Token(Token = "0x402AA6E")]
		[FieldOffset(Offset = "0x30")]
		public int maxLevel;

		// Token: 0x0402AA6F RID: 174703
		[Token(Token = "0x402AA6F")]
		[FieldOffset(Offset = "0x34")]
		public int initExp;

		// Token: 0x0402AA70 RID: 174704
		[Token(Token = "0x402AA70")]
		[FieldOffset(Offset = "0x38")]
		public int currentExp;

		// Token: 0x0402AA71 RID: 174705
		[Token(Token = "0x402AA71")]
		[FieldOffset(Offset = "0x3C")]
		public int additiveExp;

		// Token: 0x0402AA72 RID: 174706
		[Token(Token = "0x402AA72")]
		[FieldOffset(Offset = "0x40")]
		public int currentShield;

		// Token: 0x0402AA73 RID: 174707
		[Token(Token = "0x402AA73")]
		[FieldOffset(Offset = "0x44")]
		public int deltaShield;

		// Token: 0x0402AA74 RID: 174708
		[Token(Token = "0x402AA74")]
		[FieldOffset(Offset = "0x48")]
		public int popAdd;

		// Token: 0x0402AA75 RID: 174709
		[Token(Token = "0x402AA75")]
		[FieldOffset(Offset = "0x50")]
		public List<RoguelikeRewardsPopInfo> lvUpPopInfos;

		// Token: 0x0402AA76 RID: 174710
		[Token(Token = "0x402AA76")]
		[FieldOffset(Offset = "0x58")]
		public int popCurrent;

		// Token: 0x0402AA77 RID: 174711
		[Token(Token = "0x402AA77")]
		[FieldOffset(Offset = "0x5C")]
		public int popCurrentMax;

		// Token: 0x0402AA78 RID: 174712
		[Token(Token = "0x402AA78")]
		[FieldOffset(Offset = "0x60")]
		public PlayerRoguelikeV2.CurrentData.PlayerStatus.Properties.RewardHpShowStatus hpShowState;

		// Token: 0x0402AA79 RID: 174713
		[Token(Token = "0x402AA79")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<int, RoguelikeTopicDetailConst.PlayerLevelData> currentLevelDataTable;

		// Token: 0x0402AA7A RID: 174714
		[Token(Token = "0x402AA7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_initHp;

		// Token: 0x0402AA7B RID: 174715
		[Token(Token = "0x402AA7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_initShield;

		// Token: 0x0402AA7C RID: 174716
		[Token(Token = "0x402AA7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
