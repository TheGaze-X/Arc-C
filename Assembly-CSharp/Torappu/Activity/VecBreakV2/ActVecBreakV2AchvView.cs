using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.Medal;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DD1 RID: 28113
	[Token(Token = "0x2006DD1")]
	public class ActVecBreakV2AchvView : DataBinder<ActVecBreakV2AchvProp>
	{
		// Token: 0x17005EAA RID: 24234
		// (get) Token: 0x06028079 RID: 163961 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602807A RID: 163962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EAA")]
		public UIPage page
		{
			[Token(Token = "0x6028079")]
			[Address(RVA = "0x234C6C0", Offset = "0x234B2C0", VA = "0x18234C6C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602807A")]
			[Address(RVA = "0x234C720", Offset = "0x234B320", VA = "0x18234C720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602807B RID: 163963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602807B")]
		[Address(RVA = "0x234B490", Offset = "0x234A090", VA = "0x18234B490", Slot = "7")]
		public override void OnValueChanged(ActVecBreakV2AchvProp property)
		{
		}

		// Token: 0x0602807C RID: 163964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602807C")]
		[Address(RVA = "0x234BD70", Offset = "0x234A970", VA = "0x18234BD70")]
		private void _RenderSeasonView(ActVecBreakV2AchvSeasonModel selectSeasonModel)
		{
		}

		// Token: 0x0602807D RID: 163965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602807D")]
		[Address(RVA = "0x234B7E0", Offset = "0x234A3E0", VA = "0x18234B7E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602807E RID: 163966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602807E")]
		[Address(RVA = "0x234B400", Offset = "0x234A000", VA = "0x18234B400")]
		public void EventOnBtnNavPrev()
		{
		}

		// Token: 0x0602807F RID: 163967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602807F")]
		[Address(RVA = "0x234B370", Offset = "0x2349F70", VA = "0x18234B370")]
		public void EventOnBtnNavNext()
		{
		}

		// Token: 0x06028080 RID: 163968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028080")]
		[Address(RVA = "0x234B2E0", Offset = "0x2349EE0", VA = "0x18234B2E0")]
		public void EventOnBtnMedalGroup()
		{
		}

		// Token: 0x06028081 RID: 163969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028081")]
		[Address(RVA = "0x234C640", Offset = "0x234B240", VA = "0x18234C640")]
		public ActVecBreakV2AchvView()
		{
		}

		// Token: 0x04038C21 RID: 232481
		[Token(Token = "0x4038C21")]
		private const int CHAR_LIST_DECO_HIDE_BUFF_COUNT = 5;

		// Token: 0x04038C22 RID: 232482
		[Token(Token = "0x4038C22")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _navPartGO;

		// Token: 0x04038C23 RID: 232483
		[Token(Token = "0x4038C23")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _tabList;

		// Token: 0x04038C24 RID: 232484
		[Token(Token = "0x4038C24")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x04038C25 RID: 232485
		[Token(Token = "0x4038C25")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hardStageLockGO;

		// Token: 0x04038C26 RID: 232486
		[Token(Token = "0x4038C26")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _hardStageNormalGO;

		// Token: 0x04038C27 RID: 232487
		[Token(Token = "0x4038C27")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _hardStageList;

		// Token: 0x04038C28 RID: 232488
		[Token(Token = "0x4038C28")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _squadBuffList;

		// Token: 0x04038C29 RID: 232489
		[Token(Token = "0x4038C29")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _squadCharList;

		// Token: 0x04038C2A RID: 232490
		[Token(Token = "0x4038C2A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _squadCharListDeco;

		// Token: 0x04038C2B RID: 232491
		[Token(Token = "0x4038C2B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _medalGroupContainer;

		// Token: 0x04038C2C RID: 232492
		[Token(Token = "0x4038C2C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgSeasonTitle;

		// Token: 0x04038C2D RID: 232493
		[Token(Token = "0x4038C2D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgSeasonTitleMini;

		// Token: 0x04038C2E RID: 232494
		[Token(Token = "0x4038C2E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textBestLevel;

		// Token: 0x04038C2F RID: 232495
		[Token(Token = "0x4038C2F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textPlayerNickName;

		// Token: 0x04038C30 RID: 232496
		[Token(Token = "0x4038C30")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x04038C31 RID: 232497
		[Token(Token = "0x4038C31")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x04038C32 RID: 232498
		[Token(Token = "0x4038C32")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _emptyRecrodInfoGO;

		// Token: 0x04038C33 RID: 232499
		[Token(Token = "0x4038C33")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _normalRecrodInfoGO;

		// Token: 0x04038C34 RID: 232500
		[Token(Token = "0x4038C34")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _textRecordTime;

		// Token: 0x04038C35 RID: 232501
		[Token(Token = "0x4038C35")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textHardZoneName;

		// Token: 0x04038C36 RID: 232502
		[Token(Token = "0x4038C36")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _textOffenseZoneName;

		// Token: 0x04038C37 RID: 232503
		[Token(Token = "0x4038C37")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _textDefenseZoneName;

		// Token: 0x04038C38 RID: 232504
		[Token(Token = "0x4038C38")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038C39 RID: 232505
		[Token(Token = "0x4038C39")]
		[FieldOffset(Offset = "0xE0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04038C3A RID: 232506
		[Token(Token = "0x4038C3A")]
		[FieldOffset(Offset = "0xF0")]
		private ActVecBreakV2AchvView.TabListAdapter m_tabListAdapter;

		// Token: 0x04038C3B RID: 232507
		[Token(Token = "0x4038C3B")]
		[FieldOffset(Offset = "0xF8")]
		private ActVecBreakV2AchvView.BuffListAdapter m_buffListAdapter;

		// Token: 0x04038C3C RID: 232508
		[Token(Token = "0x4038C3C")]
		[FieldOffset(Offset = "0x100")]
		private ActVecBreakV2AchvView.SquadBuffListAdapter m_squadBuffListAdapter;

		// Token: 0x04038C3D RID: 232509
		[Token(Token = "0x4038C3D")]
		[FieldOffset(Offset = "0x108")]
		private ActVecBreakV2AchvView.SquadCharListAdapter m_squadCharListAdapter;

		// Token: 0x04038C3E RID: 232510
		[Token(Token = "0x4038C3E")]
		[FieldOffset(Offset = "0x110")]
		private ActVecBreakV2AchvView.HardStageListAdapter m_hardStageListAdapter;

		// Token: 0x04038C3F RID: 232511
		[Token(Token = "0x4038C3F")]
		[FieldOffset(Offset = "0x118")]
		private bool m_hasInited;

		// Token: 0x04038C40 RID: 232512
		[Token(Token = "0x4038C40")]
		[FieldOffset(Offset = "0x120")]
		private ActVecBreakV2AchvModel m_viewModel;

		// Token: 0x04038C41 RID: 232513
		[Token(Token = "0x4038C41")]
		[FieldOffset(Offset = "0x128")]
		private UIMedalGroupView m_medalGroupView;

		// Token: 0x04038C42 RID: 232514
		[Token(Token = "0x4038C42")]
		[FieldOffset(Offset = "0x130")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04038C44 RID: 232516
		[Token(Token = "0x4038C44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04038C45 RID: 232517
		[Token(Token = "0x4038C45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04038C46 RID: 232518
		[Token(Token = "0x4038C46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04038C47 RID: 232519
		[Token(Token = "0x4038C47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderSeasonView;

		// Token: 0x04038C48 RID: 232520
		[Token(Token = "0x4038C48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038C49 RID: 232521
		[Token(Token = "0x4038C49")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBtnNavPrev;

		// Token: 0x04038C4A RID: 232522
		[Token(Token = "0x4038C4A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnNavNext;

		// Token: 0x04038C4B RID: 232523
		[Token(Token = "0x4038C4B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnMedalGroup;

		// Token: 0x04038C4C RID: 232524
		[Token(Token = "0x4038C4C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DD2 RID: 28114
		[Token(Token = "0x2006DD2")]
		private class SquadCharListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028082 RID: 163970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028082")]
			[Address(RVA = "0x235BC20", Offset = "0x235A820", VA = "0x18235BC20")]
			public SquadCharListAdapter(ActVecBreakV2AchvView closure)
			{
			}

			// Token: 0x17005EAB RID: 24235
			// (get) Token: 0x06028083 RID: 163971 RVA: 0x000D06E0 File Offset: 0x000CE8E0
			[Token(Token = "0x17005EAB")]
			public override int count
			{
				[Token(Token = "0x6028083")]
				[Address(RVA = "0x235BCA0", Offset = "0x235A8A0", VA = "0x18235BCA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028084 RID: 163972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028084")]
			[Address(RVA = "0x235BA00", Offset = "0x235A600", VA = "0x18235BA00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038C4D RID: 232525
			[Token(Token = "0x4038C4D")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2AchvView m_closure;

			// Token: 0x04038C4E RID: 232526
			[Token(Token = "0x4038C4E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038C4F RID: 232527
			[Token(Token = "0x4038C4F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038C50 RID: 232528
			[Token(Token = "0x4038C50")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006DD3 RID: 28115
		[Token(Token = "0x2006DD3")]
		private class SquadBuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028085 RID: 163973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028085")]
			[Address(RVA = "0x235B8B0", Offset = "0x235A4B0", VA = "0x18235B8B0")]
			public SquadBuffListAdapter(ActVecBreakV2AchvView closure)
			{
			}

			// Token: 0x17005EAC RID: 24236
			// (get) Token: 0x06028086 RID: 163974 RVA: 0x000D06F8 File Offset: 0x000CE8F8
			[Token(Token = "0x17005EAC")]
			public override int count
			{
				[Token(Token = "0x6028086")]
				[Address(RVA = "0x235B930", Offset = "0x235A530", VA = "0x18235B930", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028087 RID: 163975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028087")]
			[Address(RVA = "0x235B550", Offset = "0x235A150", VA = "0x18235B550", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038C51 RID: 232529
			[Token(Token = "0x4038C51")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2AchvView m_closure;

			// Token: 0x04038C52 RID: 232530
			[Token(Token = "0x4038C52")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038C53 RID: 232531
			[Token(Token = "0x4038C53")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038C54 RID: 232532
			[Token(Token = "0x4038C54")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006DD4 RID: 28116
		[Token(Token = "0x2006DD4")]
		private class HardStageListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028088 RID: 163976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028088")]
			[Address(RVA = "0x235B1D0", Offset = "0x2359DD0", VA = "0x18235B1D0")]
			public HardStageListAdapter(ActVecBreakV2AchvView closure)
			{
			}

			// Token: 0x17005EAD RID: 24237
			// (get) Token: 0x06028089 RID: 163977 RVA: 0x000D0710 File Offset: 0x000CE910
			[Token(Token = "0x17005EAD")]
			public override int count
			{
				[Token(Token = "0x6028089")]
				[Address(RVA = "0x235B250", Offset = "0x2359E50", VA = "0x18235B250", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602808A RID: 163978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602808A")]
			[Address(RVA = "0x235AFB0", Offset = "0x2359BB0", VA = "0x18235AFB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038C55 RID: 232533
			[Token(Token = "0x4038C55")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2AchvView m_closure;

			// Token: 0x04038C56 RID: 232534
			[Token(Token = "0x4038C56")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038C57 RID: 232535
			[Token(Token = "0x4038C57")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038C58 RID: 232536
			[Token(Token = "0x4038C58")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006DD5 RID: 28117
		[Token(Token = "0x2006DD5")]
		private class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602808B RID: 163979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602808B")]
			[Address(RVA = "0x235AE30", Offset = "0x2359A30", VA = "0x18235AE30")]
			public BuffListAdapter(ActVecBreakV2AchvView closure)
			{
			}

			// Token: 0x17005EAE RID: 24238
			// (get) Token: 0x0602808C RID: 163980 RVA: 0x000D0728 File Offset: 0x000CE928
			[Token(Token = "0x17005EAE")]
			public override int count
			{
				[Token(Token = "0x602808C")]
				[Address(RVA = "0x235AEB0", Offset = "0x2359AB0", VA = "0x18235AEB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602808D RID: 163981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602808D")]
			[Address(RVA = "0x235AC10", Offset = "0x2359810", VA = "0x18235AC10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038C59 RID: 232537
			[Token(Token = "0x4038C59")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2AchvView m_closure;

			// Token: 0x04038C5A RID: 232538
			[Token(Token = "0x4038C5A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038C5B RID: 232539
			[Token(Token = "0x4038C5B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038C5C RID: 232540
			[Token(Token = "0x4038C5C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006DD6 RID: 28118
		[Token(Token = "0x2006DD6")]
		private class TabListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602808E RID: 163982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602808E")]
			[Address(RVA = "0x235BFD0", Offset = "0x235ABD0", VA = "0x18235BFD0")]
			public TabListAdapter(ActVecBreakV2AchvView closure)
			{
			}

			// Token: 0x17005EAF RID: 24239
			// (get) Token: 0x0602808F RID: 163983 RVA: 0x000D0740 File Offset: 0x000CE940
			[Token(Token = "0x17005EAF")]
			public override int count
			{
				[Token(Token = "0x602808F")]
				[Address(RVA = "0x235C050", Offset = "0x235AC50", VA = "0x18235C050", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028090 RID: 163984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028090")]
			[Address(RVA = "0x235BD90", Offset = "0x235A990", VA = "0x18235BD90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038C5D RID: 232541
			[Token(Token = "0x4038C5D")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2AchvView m_closure;

			// Token: 0x04038C5E RID: 232542
			[Token(Token = "0x4038C5E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038C5F RID: 232543
			[Token(Token = "0x4038C5F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038C60 RID: 232544
			[Token(Token = "0x4038C60")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
