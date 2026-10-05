using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E3D RID: 28221
	[Token(Token = "0x2006E3D")]
	public class ActVecBreakV2MileStoneEntryButtonPlugin : AbstractTemplateActivityEntryMilestonePlugin
	{
		// Token: 0x060282A2 RID: 164514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282A2")]
		[Address(RVA = "0x23755A0", Offset = "0x23741A0", VA = "0x1823755A0")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x060282A3 RID: 164515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282A3")]
		[Address(RVA = "0x2375640", Offset = "0x2374240", VA = "0x182375640", Slot = "6")]
		protected override void OnViewModelRefresh(TemplateActivityMilestoneGroupViewModel viewModel)
		{
		}

		// Token: 0x060282A4 RID: 164516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282A4")]
		[Address(RVA = "0x23758D0", Offset = "0x23744D0", VA = "0x1823758D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060282A5 RID: 164517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282A5")]
		[Address(RVA = "0x2375A10", Offset = "0x2374610", VA = "0x182375A10")]
		private void _RenderView()
		{
		}

		// Token: 0x060282A6 RID: 164518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282A6")]
		[Address(RVA = "0x2375DB0", Offset = "0x23749B0", VA = "0x182375DB0")]
		public ActVecBreakV2MileStoneEntryButtonPlugin()
		{
		}

		// Token: 0x040390A4 RID: 233636
		[Token(Token = "0x40390A4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x040390A5 RID: 233637
		[Token(Token = "0x40390A5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _mileStoneLevelText;

		// Token: 0x040390A6 RID: 233638
		[Token(Token = "0x40390A6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x040390A7 RID: 233639
		[Token(Token = "0x40390A7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _normalLevelBgGo;

		// Token: 0x040390A8 RID: 233640
		[Token(Token = "0x40390A8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _maxLevelBgGo;

		// Token: 0x040390A9 RID: 233641
		[Token(Token = "0x40390A9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _maxLevelTag;

		// Token: 0x040390AA RID: 233642
		[Token(Token = "0x40390AA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIActTrackPoint _newProgressTrack;

		// Token: 0x040390AB RID: 233643
		[Token(Token = "0x40390AB")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x040390AC RID: 233644
		[Token(Token = "0x40390AC")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040390AD RID: 233645
		[Token(Token = "0x40390AD")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isMilestoneEnabled;

		// Token: 0x040390AE RID: 233646
		[Token(Token = "0x40390AE")]
		[FieldOffset(Offset = "0xD0")]
		private TemplateActivityMilestoneGroupViewModel m_viewModel;

		// Token: 0x040390AF RID: 233647
		[Token(Token = "0x40390AF")]
		[FieldOffset(Offset = "0xD8")]
		private TrackPointViewProperty m_trackUpdatedProp;

		// Token: 0x040390B0 RID: 233648
		[Token(Token = "0x40390B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x040390B1 RID: 233649
		[Token(Token = "0x40390B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x040390B2 RID: 233650
		[Token(Token = "0x40390B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040390B3 RID: 233651
		[Token(Token = "0x40390B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x040390B4 RID: 233652
		[Token(Token = "0x40390B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E3E RID: 28222
		[Token(Token = "0x2006E3E")]
		public class RewardTrackPoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x17005EEF RID: 24303
			// (get) Token: 0x060282A7 RID: 164519 RVA: 0x000D0CC8 File Offset: 0x000CEEC8
			[Token(Token = "0x17005EEF")]
			public bool isShow
			{
				[Token(Token = "0x60282A7")]
				[Address(RVA = "0x2388070", Offset = "0x2386C70", VA = "0x182388070", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060282A8 RID: 164520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60282A8")]
			[Address(RVA = "0x2387F30", Offset = "0x2386B30", VA = "0x182387F30", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x060282A9 RID: 164521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60282A9")]
			[Address(RVA = "0x2388010", Offset = "0x2386C10", VA = "0x182388010")]
			public RewardTrackPoint()
			{
			}

			// Token: 0x040390B5 RID: 233653
			[Token(Token = "0x40390B5")]
			[FieldOffset(Offset = "0x10")]
			private bool m_haveAvailFlag;

			// Token: 0x040390B6 RID: 233654
			[Token(Token = "0x40390B6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x040390B7 RID: 233655
			[Token(Token = "0x40390B7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x040390B8 RID: 233656
			[Token(Token = "0x40390B8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02006E3F RID: 28223
			[Token(Token = "0x2006E3F")]
			public class Param
			{
				// Token: 0x060282AA RID: 164522 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60282AA")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x040390B9 RID: 233657
				[Token(Token = "0x40390B9")]
				[FieldOffset(Offset = "0x10")]
				public bool hasReward;

				// Token: 0x040390BA RID: 233658
				[Token(Token = "0x40390BA")]
				[FieldOffset(Offset = "0x11")]
				public bool hasProgressNew;

				// Token: 0x040390BB RID: 233659
				[Token(Token = "0x40390BB")]
				[FieldOffset(Offset = "0x12")]
				public bool isMileStoneEnable;
			}
		}

		// Token: 0x02006E40 RID: 28224
		[Token(Token = "0x2006E40")]
		public class ProgressTrackPoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x17005EF0 RID: 24304
			// (get) Token: 0x060282AB RID: 164523 RVA: 0x000D0CE0 File Offset: 0x000CEEE0
			[Token(Token = "0x17005EF0")]
			public bool isShow
			{
				[Token(Token = "0x60282AB")]
				[Address(RVA = "0x2387ED0", Offset = "0x2386AD0", VA = "0x182387ED0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060282AC RID: 164524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60282AC")]
			[Address(RVA = "0x2387D90", Offset = "0x2386990", VA = "0x182387D90", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x060282AD RID: 164525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60282AD")]
			[Address(RVA = "0x2387E70", Offset = "0x2386A70", VA = "0x182387E70")]
			public ProgressTrackPoint()
			{
			}

			// Token: 0x040390BC RID: 233660
			[Token(Token = "0x40390BC")]
			[FieldOffset(Offset = "0x10")]
			private bool m_haveAvailFlag;

			// Token: 0x040390BD RID: 233661
			[Token(Token = "0x40390BD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x040390BE RID: 233662
			[Token(Token = "0x40390BE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x040390BF RID: 233663
			[Token(Token = "0x40390BF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02006E41 RID: 28225
			[Token(Token = "0x2006E41")]
			public class Param
			{
				// Token: 0x060282AE RID: 164526 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60282AE")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x040390C0 RID: 233664
				[Token(Token = "0x40390C0")]
				[FieldOffset(Offset = "0x10")]
				public bool hasProgressNew;

				// Token: 0x040390C1 RID: 233665
				[Token(Token = "0x40390C1")]
				[FieldOffset(Offset = "0x11")]
				public bool isMileStoneEnable;

				// Token: 0x040390C2 RID: 233666
				[Token(Token = "0x40390C2")]
				[FieldOffset(Offset = "0x12")]
				public bool isMax;
			}
		}
	}
}
