using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FAD RID: 20397
	[Token(Token = "0x2004FAD")]
	public class EnemyDuelMileStoneEntryButtonPlugin : AbstractTemplateActivityEntryMilestonePlugin
	{
		// Token: 0x0601E4ED RID: 124141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4ED")]
		[Address(RVA = "0x1805460", Offset = "0x1804060", VA = "0x181805460", Slot = "6")]
		protected override void OnViewModelRefresh(TemplateActivityMilestoneGroupViewModel viewModel)
		{
		}

		// Token: 0x0601E4EE RID: 124142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4EE")]
		[Address(RVA = "0x1805990", Offset = "0x1804590", VA = "0x181805990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E4EF RID: 124143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4EF")]
		[Address(RVA = "0x18053B0", Offset = "0x1803FB0", VA = "0x1818053B0")]
		public void OnClick()
		{
		}

		// Token: 0x0601E4F0 RID: 124144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4F0")]
		[Address(RVA = "0x1805AE0", Offset = "0x18046E0", VA = "0x181805AE0")]
		public EnemyDuelMileStoneEntryButtonPlugin()
		{
		}

		// Token: 0x04028774 RID: 165748
		[Token(Token = "0x4028774")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x04028775 RID: 165749
		[Token(Token = "0x4028775")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _mileStoneLevelText;

		// Token: 0x04028776 RID: 165750
		[Token(Token = "0x4028776")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _maxLevelTag;

		// Token: 0x04028777 RID: 165751
		[Token(Token = "0x4028777")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICommonTrackPoint _newProgressTrack;

		// Token: 0x04028778 RID: 165752
		[Token(Token = "0x4028778")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _mileStoneName;

		// Token: 0x04028779 RID: 165753
		[Token(Token = "0x4028779")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402877A RID: 165754
		[Token(Token = "0x402877A")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isMileStoneEnable;

		// Token: 0x0402877B RID: 165755
		[Token(Token = "0x402877B")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_isEntryPluginInited;

		// Token: 0x0402877C RID: 165756
		[Token(Token = "0x402877C")]
		[FieldOffset(Offset = "0xB8")]
		private TrackPointViewProperty m_trackUpdatedProp;

		// Token: 0x0402877D RID: 165757
		[Token(Token = "0x402877D")]
		[FieldOffset(Offset = "0xC0")]
		private TemplateActivityMilestoneGroupViewModel m_viewModel;

		// Token: 0x0402877E RID: 165758
		[Token(Token = "0x402877E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0402877F RID: 165759
		[Token(Token = "0x402877F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028780 RID: 165760
		[Token(Token = "0x4028780")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04028781 RID: 165761
		[Token(Token = "0x4028781")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FAE RID: 20398
		[Token(Token = "0x2004FAE")]
		public class RewardTrackPoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x170046EC RID: 18156
			// (get) Token: 0x0601E4F1 RID: 124145 RVA: 0x000AE1C8 File Offset: 0x000AC3C8
			[Token(Token = "0x170046EC")]
			public bool isShow
			{
				[Token(Token = "0x601E4F1")]
				[Address(RVA = "0x180CCE0", Offset = "0x180B8E0", VA = "0x18180CCE0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601E4F2 RID: 124146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4F2")]
			[Address(RVA = "0x180CB80", Offset = "0x180B780", VA = "0x18180CB80", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0601E4F3 RID: 124147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4F3")]
			[Address(RVA = "0x180CC80", Offset = "0x180B880", VA = "0x18180CC80")]
			public RewardTrackPoint()
			{
			}

			// Token: 0x04028782 RID: 165762
			[Token(Token = "0x4028782")]
			[FieldOffset(Offset = "0x10")]
			private bool m_haveAvailFlag;

			// Token: 0x04028783 RID: 165763
			[Token(Token = "0x4028783")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04028784 RID: 165764
			[Token(Token = "0x4028784")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04028785 RID: 165765
			[Token(Token = "0x4028785")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02004FAF RID: 20399
			[Token(Token = "0x2004FAF")]
			public class Param
			{
				// Token: 0x0601E4F4 RID: 124148 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601E4F4")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x04028786 RID: 165766
				[Token(Token = "0x4028786")]
				[FieldOffset(Offset = "0x10")]
				public TemplateActivityMilestoneGroupViewModel viewModel;

				// Token: 0x04028787 RID: 165767
				[Token(Token = "0x4028787")]
				[FieldOffset(Offset = "0x18")]
				public bool isMileStoneEnable;
			}
		}

		// Token: 0x02004FB0 RID: 20400
		[Token(Token = "0x2004FB0")]
		public class ProgressTrackPoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x170046ED RID: 18157
			// (get) Token: 0x0601E4F5 RID: 124149 RVA: 0x000AE1E0 File Offset: 0x000AC3E0
			[Token(Token = "0x170046ED")]
			public bool isShow
			{
				[Token(Token = "0x601E4F5")]
				[Address(RVA = "0x180CB20", Offset = "0x180B720", VA = "0x18180CB20", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601E4F6 RID: 124150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4F6")]
			[Address(RVA = "0x180C8F0", Offset = "0x180B4F0", VA = "0x18180C8F0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0601E4F7 RID: 124151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4F7")]
			[Address(RVA = "0x180CAC0", Offset = "0x180B6C0", VA = "0x18180CAC0")]
			public ProgressTrackPoint()
			{
			}

			// Token: 0x04028788 RID: 165768
			[Token(Token = "0x4028788")]
			[FieldOffset(Offset = "0x10")]
			private bool m_haveAvailFlag;

			// Token: 0x04028789 RID: 165769
			[Token(Token = "0x4028789")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0402878A RID: 165770
			[Token(Token = "0x402878A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0402878B RID: 165771
			[Token(Token = "0x402878B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02004FB1 RID: 20401
			[Token(Token = "0x2004FB1")]
			public class Param
			{
				// Token: 0x0601E4F8 RID: 124152 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601E4F8")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0402878C RID: 165772
				[Token(Token = "0x402878C")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0402878D RID: 165773
				[Token(Token = "0x402878D")]
				[FieldOffset(Offset = "0x18")]
				public bool isMileStoneEnable;

				// Token: 0x0402878E RID: 165774
				[Token(Token = "0x402878E")]
				[FieldOffset(Offset = "0x19")]
				public bool isMax;
			}
		}
	}
}
