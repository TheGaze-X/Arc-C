using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E8B RID: 16011
	[Token(Token = "0x2003E8B")]
	public class SpecialOperatorBoardEvolveNodeView : SpecialOperatorBoardEvolveItemView
	{
		// Token: 0x06018DF0 RID: 101872 RVA: 0x0009C408 File Offset: 0x0009A608
		[Token(Token = "0x6018DF0")]
		[Address(RVA = "0x1186E00", Offset = "0x1185A00", VA = "0x181186E00", Slot = "4")]
		public override SpecialOperatorBoardEvolveItemType GetItemType()
		{
			return SpecialOperatorBoardEvolveItemType.LINE;
		}

		// Token: 0x06018DF1 RID: 101873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DF1")]
		[Address(RVA = "0x11874E0", Offset = "0x11860E0", VA = "0x1811874E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018DF2 RID: 101874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DF2")]
		[Address(RVA = "0x1186F70", Offset = "0x1185B70", VA = "0x181186F70", Slot = "5")]
		public override void Render(ISpecialOperatorBoardEvolveItemViewModel viewModel, SpecialOperatorBoardEvolveItemView.Param param)
		{
		}

		// Token: 0x06018DF3 RID: 101875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DF3")]
		[Address(RVA = "0x1186E60", Offset = "0x1185A60", VA = "0x181186E60")]
		public void OnClick()
		{
		}

		// Token: 0x06018DF4 RID: 101876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DF4")]
		[Address(RVA = "0x1187750", Offset = "0x1186350", VA = "0x181187750")]
		public SpecialOperatorBoardEvolveNodeView()
		{
		}

		// Token: 0x0401EA1A RID: 125466
		[Token(Token = "0x401EA1A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0401EA1B RID: 125467
		[Token(Token = "0x401EA1B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLockPre;

		// Token: 0x0401EA1C RID: 125468
		[Token(Token = "0x401EA1C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelCanEvolve;

		// Token: 0x0401EA1D RID: 125469
		[Token(Token = "0x401EA1D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0401EA1E RID: 125470
		[Token(Token = "0x401EA1E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelHotSpot;

		// Token: 0x0401EA1F RID: 125471
		[Token(Token = "0x401EA1F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTip;

		// Token: 0x0401EA20 RID: 125472
		[Token(Token = "0x401EA20")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelTipMission;

		// Token: 0x0401EA21 RID: 125473
		[Token(Token = "0x401EA21")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelTipPre;

		// Token: 0x0401EA22 RID: 125474
		[Token(Token = "0x401EA22")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _tipPreLevel;

		// Token: 0x0401EA23 RID: 125475
		[Token(Token = "0x401EA23")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _tipPreDesc;

		// Token: 0x0401EA24 RID: 125476
		[Token(Token = "0x401EA24")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _featureContent;

		// Token: 0x0401EA25 RID: 125477
		[Token(Token = "0x401EA25")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _eliteIcon;

		// Token: 0x0401EA26 RID: 125478
		[Token(Token = "0x401EA26")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0401EA27 RID: 125479
		[Token(Token = "0x401EA27")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _unlockAnim;

		// Token: 0x0401EA28 RID: 125480
		[Token(Token = "0x401EA28")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0401EA29 RID: 125481
		[Token(Token = "0x401EA29")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EA2A RID: 125482
		[Token(Token = "0x401EA2A")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401EA2B RID: 125483
		[Token(Token = "0x401EA2B")]
		[FieldOffset(Offset = "0xC0")]
		private int m_evolvePhase;

		// Token: 0x0401EA2C RID: 125484
		[Token(Token = "0x401EA2C")]
		[FieldOffset(Offset = "0xC8")]
		private SpecialOperatorBoardEvolveNodeView.Adapter m_adapter;

		// Token: 0x0401EA2D RID: 125485
		[Token(Token = "0x401EA2D")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x0401EA2E RID: 125486
		[Token(Token = "0x401EA2E")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0401EA2F RID: 125487
		[Token(Token = "0x401EA2F")]
		[FieldOffset(Offset = "0xE0")]
		private SpecialOperatorBoardEvolveNodeViewModel m_cachedViewModel;

		// Token: 0x0401EA30 RID: 125488
		[Token(Token = "0x401EA30")]
		[FieldOffset(Offset = "0xE8")]
		private List<SpecialOperatorBoardEvolveNodeViewModel.Feature> m_cachedFeatures;

		// Token: 0x0401EA31 RID: 125489
		[Token(Token = "0x401EA31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetItemType;

		// Token: 0x0401EA32 RID: 125490
		[Token(Token = "0x401EA32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EA33 RID: 125491
		[Token(Token = "0x401EA33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EA34 RID: 125492
		[Token(Token = "0x401EA34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401EA35 RID: 125493
		[Token(Token = "0x401EA35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E8C RID: 16012
		[Token(Token = "0x2003E8C")]
		private enum NodeState
		{
			// Token: 0x0401EA37 RID: 125495
			[Token(Token = "0x401EA37")]
			LOCK_MISSION,
			// Token: 0x0401EA38 RID: 125496
			[Token(Token = "0x401EA38")]
			LOCK_PRE,
			// Token: 0x0401EA39 RID: 125497
			[Token(Token = "0x401EA39")]
			CAN_EVOLVE,
			// Token: 0x0401EA3A RID: 125498
			[Token(Token = "0x401EA3A")]
			UNLOCK
		}

		// Token: 0x02003E8D RID: 16013
		[Token(Token = "0x2003E8D")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06018DF5 RID: 101877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018DF5")]
			[Address(RVA = "0x1181A10", Offset = "0x1180610", VA = "0x181181A10")]
			public Adapter(SpecialOperatorBoardEvolveNodeView closure)
			{
			}

			// Token: 0x17003B5B RID: 15195
			// (get) Token: 0x06018DF6 RID: 101878 RVA: 0x0009C420 File Offset: 0x0009A620
			[Token(Token = "0x17003B5B")]
			public override int count
			{
				[Token(Token = "0x6018DF6")]
				[Address(RVA = "0x1181B10", Offset = "0x1180710", VA = "0x181181B10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018DF7 RID: 101879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018DF7")]
			[Address(RVA = "0x1181750", Offset = "0x1180350", VA = "0x181181750", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401EA3B RID: 125499
			[Token(Token = "0x401EA3B")]
			[FieldOffset(Offset = "0x20")]
			private SpecialOperatorBoardEvolveNodeView m_closure;

			// Token: 0x0401EA3C RID: 125500
			[Token(Token = "0x401EA3C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401EA3D RID: 125501
			[Token(Token = "0x401EA3D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401EA3E RID: 125502
			[Token(Token = "0x401EA3E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
