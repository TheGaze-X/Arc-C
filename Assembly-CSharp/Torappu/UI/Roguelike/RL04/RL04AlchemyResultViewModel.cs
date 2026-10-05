using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005667 RID: 22119
	[Token(Token = "0x2005667")]
	public class RL04AlchemyResultViewModel : IHotfixable
	{
		// Token: 0x17004C07 RID: 19463
		// (get) Token: 0x06020726 RID: 132902 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020727 RID: 132903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C07")]
		public RoguelikeRewardListViewModel otherRewardListViewModel
		{
			[Token(Token = "0x6020726")]
			[Address(RVA = "0x1A9D500", Offset = "0x1A9C100", VA = "0x181A9D500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020727")]
			[Address(RVA = "0x1A9D690", Offset = "0x1A9C290", VA = "0x181A9D690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C08 RID: 19464
		// (get) Token: 0x06020728 RID: 132904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020729 RID: 132905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C08")]
		public List<RL04AlchemyResultSsrItemViewModel> ssrRewardListViewModel
		{
			[Token(Token = "0x6020728")]
			[Address(RVA = "0x1A9D5C0", Offset = "0x1A9C1C0", VA = "0x181A9D5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020729")]
			[Address(RVA = "0x1A9D780", Offset = "0x1A9C380", VA = "0x181A9D780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C09 RID: 19465
		// (get) Token: 0x0602072A RID: 132906 RVA: 0x000B5FB0 File Offset: 0x000B41B0
		// (set) Token: 0x0602072B RID: 132907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C09")]
		public RL04AlchemyResultViewModel.ResultState resultState
		{
			[Token(Token = "0x602072A")]
			[Address(RVA = "0x1A9D560", Offset = "0x1A9C160", VA = "0x181A9D560")]
			[CompilerGenerated]
			get
			{
				return RL04AlchemyResultViewModel.ResultState.NORMAL;
			}
			[Token(Token = "0x602072B")]
			[Address(RVA = "0x1A9D710", Offset = "0x1A9C310", VA = "0x181A9D710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C0A RID: 19466
		// (get) Token: 0x0602072C RID: 132908 RVA: 0x000B5FC8 File Offset: 0x000B41C8
		// (set) Token: 0x0602072D RID: 132909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C0A")]
		public bool isMultiChoiceReward
		{
			[Token(Token = "0x602072C")]
			[Address(RVA = "0x1A9D4A0", Offset = "0x1A9C0A0", VA = "0x181A9D4A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602072D")]
			[Address(RVA = "0x1A9D620", Offset = "0x1A9C220", VA = "0x181A9D620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602072E RID: 132910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602072E")]
		[Address(RVA = "0x1A9D170", Offset = "0x1A9BD70", VA = "0x181A9D170")]
		public RL04AlchemyResultViewModel(string topicId, List<RoguelikeItemBundle> items, bool isSsr, bool isFail)
		{
		}

		// Token: 0x0602072F RID: 132911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602072F")]
		[Address(RVA = "0x1A9CE60", Offset = "0x1A9BA60", VA = "0x181A9CE60")]
		private void _RefreshSsrRewardListModel(string topicId, List<RoguelikeItemBundle> items, int maxCount)
		{
		}

		// Token: 0x06020730 RID: 132912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020730")]
		[Address(RVA = "0x1A9CB90", Offset = "0x1A9B790", VA = "0x181A9CB90")]
		private void _RefreshOtherRewardsList(string topicId, List<RoguelikeItemBundle> items, int maxCount)
		{
		}

		// Token: 0x0402BF17 RID: 179991
		[Token(Token = "0x402BF17")]
		private const int MAX_REWARDS_COUNT = 2;

		// Token: 0x0402BF18 RID: 179992
		[Token(Token = "0x402BF18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_otherRewardListViewModel;

		// Token: 0x0402BF19 RID: 179993
		[Token(Token = "0x402BF19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_otherRewardListViewModel;

		// Token: 0x0402BF1A RID: 179994
		[Token(Token = "0x402BF1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ssrRewardListViewModel;

		// Token: 0x0402BF1B RID: 179995
		[Token(Token = "0x402BF1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_ssrRewardListViewModel;

		// Token: 0x0402BF1C RID: 179996
		[Token(Token = "0x402BF1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_resultState;

		// Token: 0x0402BF1D RID: 179997
		[Token(Token = "0x402BF1D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_resultState;

		// Token: 0x0402BF1E RID: 179998
		[Token(Token = "0x402BF1E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isMultiChoiceReward;

		// Token: 0x0402BF1F RID: 179999
		[Token(Token = "0x402BF1F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isMultiChoiceReward;

		// Token: 0x0402BF20 RID: 180000
		[Token(Token = "0x402BF20")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402BF21 RID: 180001
		[Token(Token = "0x402BF21")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshSsrRewardListModel;

		// Token: 0x0402BF22 RID: 180002
		[Token(Token = "0x402BF22")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshOtherRewardsList;

		// Token: 0x02005668 RID: 22120
		[Token(Token = "0x2005668")]
		public enum ResultState
		{
			// Token: 0x0402BF24 RID: 180004
			[Token(Token = "0x402BF24")]
			NORMAL,
			// Token: 0x0402BF25 RID: 180005
			[Token(Token = "0x402BF25")]
			FAIL,
			// Token: 0x0402BF26 RID: 180006
			[Token(Token = "0x402BF26")]
			SSR
		}
	}
}
