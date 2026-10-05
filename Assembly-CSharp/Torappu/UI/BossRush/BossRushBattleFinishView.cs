using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.BattleFinish;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200615E RID: 24926
	[Token(Token = "0x200615E")]
	public class BossRushBattleFinishView : DynBattleFinishView
	{
		// Token: 0x170054E1 RID: 21729
		// (get) Token: 0x06023FAA RID: 147370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023FAB RID: 147371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054E1")]
		public Action onClose
		{
			[Token(Token = "0x6023FAA")]
			[Address(RVA = "0x1EA24C0", Offset = "0x1EA10C0", VA = "0x181EA24C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6023FAB")]
			[Address(RVA = "0x1EA2520", Offset = "0x1EA1120", VA = "0x181EA2520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023FAC RID: 147372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FAC")]
		[Address(RVA = "0x1EA0D90", Offset = "0x1E9F990", VA = "0x181EA0D90", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06023FAD RID: 147373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FAD")]
		[Address(RVA = "0x1EA1550", Offset = "0x1EA0150", VA = "0x181EA1550")]
		private void _Render()
		{
		}

		// Token: 0x06023FAE RID: 147374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FAE")]
		[Address(RVA = "0x1EA1170", Offset = "0x1E9FD70", VA = "0x181EA1170")]
		private void _RenderIllustView()
		{
		}

		// Token: 0x06023FAF RID: 147375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FAF")]
		[Address(RVA = "0x1EA0EB0", Offset = "0x1E9FAB0", VA = "0x181EA0EB0")]
		private CharWordData _FetchProperCharWord(CharUISkinStruct targetSkin)
		{
			return null;
		}

		// Token: 0x06023FB0 RID: 147376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FB0")]
		[Address(RVA = "0x1EA0D30", Offset = "0x1E9F930", VA = "0x181EA0D30")]
		public void JumpToBossRush()
		{
		}

		// Token: 0x06023FB1 RID: 147377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FB1")]
		[Address(RVA = "0x1EA2460", Offset = "0x1EA1060", VA = "0x181EA2460")]
		public BossRushBattleFinishView()
		{
		}

		// Token: 0x04031F93 RID: 204691
		[Token(Token = "0x4031F93")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCode;

		// Token: 0x04031F94 RID: 204692
		[Token(Token = "0x4031F94")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04031F95 RID: 204693
		[Token(Token = "0x4031F95")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textStatus;

		// Token: 0x04031F96 RID: 204694
		[Token(Token = "0x4031F96")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIFullScreenImage _blurBackground;

		// Token: 0x04031F97 RID: 204695
		[Token(Token = "0x4031F97")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x04031F98 RID: 204696
		[Token(Token = "0x4031F98")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _illustTextContainer;

		// Token: 0x04031F99 RID: 204697
		[Token(Token = "0x4031F99")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGTypeWriterText _illustText;

		// Token: 0x04031F9A RID: 204698
		[Token(Token = "0x4031F9A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _waveList;

		// Token: 0x04031F9B RID: 204699
		[Token(Token = "0x4031F9B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textCurrentExp;

		// Token: 0x04031F9C RID: 204700
		[Token(Token = "0x4031F9C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textTotalExp;

		// Token: 0x04031F9D RID: 204701
		[Token(Token = "0x4031F9D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Slider _sliderExp;

		// Token: 0x04031F9E RID: 204702
		[Token(Token = "0x4031F9E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textMilestoneLv;

		// Token: 0x04031F9F RID: 204703
		[Token(Token = "0x4031F9F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _tagMaxGo;

		// Token: 0x04031FA0 RID: 204704
		[Token(Token = "0x4031FA0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _tagLevelUpGo;

		// Token: 0x04031FA1 RID: 204705
		[Token(Token = "0x4031FA1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BossRushBattleFinishRewardItemView _milestoneReward;

		// Token: 0x04031FA2 RID: 204706
		[Token(Token = "0x4031FA2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BossRushBattleFinishRewardItemView _tokenReward;

		// Token: 0x04031FA3 RID: 204707
		[Token(Token = "0x4031FA3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _successInfoGo;

		// Token: 0x04031FA4 RID: 204708
		[Token(Token = "0x4031FA4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textSuccessInfo;

		// Token: 0x04031FA5 RID: 204709
		[Token(Token = "0x4031FA5")]
		[FieldOffset(Offset = "0xB0")]
		private BossRushBattleFinishViewModel m_viewModel;

		// Token: 0x04031FA7 RID: 204711
		[Token(Token = "0x4031FA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClose;

		// Token: 0x04031FA8 RID: 204712
		[Token(Token = "0x4031FA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClose;

		// Token: 0x04031FA9 RID: 204713
		[Token(Token = "0x4031FA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04031FAA RID: 204714
		[Token(Token = "0x4031FAA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04031FAB RID: 204715
		[Token(Token = "0x4031FAB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderIllustView;

		// Token: 0x04031FAC RID: 204716
		[Token(Token = "0x4031FAC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FetchProperCharWord;

		// Token: 0x04031FAD RID: 204717
		[Token(Token = "0x4031FAD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_JumpToBossRush;

		// Token: 0x04031FAE RID: 204718
		[Token(Token = "0x4031FAE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200615F RID: 24927
		[Token(Token = "0x200615F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06023FB2 RID: 147378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023FB2")]
			[Address(RVA = "0x1E9DD10", Offset = "0x1E9C910", VA = "0x181E9DD10")]
			public Adapter(BossRushBattleFinishView closure)
			{
			}

			// Token: 0x170054E2 RID: 21730
			// (get) Token: 0x06023FB3 RID: 147379 RVA: 0x000C2940 File Offset: 0x000C0B40
			[Token(Token = "0x170054E2")]
			public override int count
			{
				[Token(Token = "0x6023FB3")]
				[Address(RVA = "0x1E9DEA0", Offset = "0x1E9CAA0", VA = "0x181E9DEA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023FB4 RID: 147380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023FB4")]
			[Address(RVA = "0x1E9D550", Offset = "0x1E9C150", VA = "0x181E9D550", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04031FAF RID: 204719
			[Token(Token = "0x4031FAF")]
			[FieldOffset(Offset = "0x20")]
			private BossRushBattleFinishView m_closure;

			// Token: 0x04031FB0 RID: 204720
			[Token(Token = "0x4031FB0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031FB1 RID: 204721
			[Token(Token = "0x4031FB1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031FB2 RID: 204722
			[Token(Token = "0x4031FB2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
