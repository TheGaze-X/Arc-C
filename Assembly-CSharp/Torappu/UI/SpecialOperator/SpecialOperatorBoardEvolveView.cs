using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E8E RID: 16014
	[Token(Token = "0x2003E8E")]
	public class SpecialOperatorBoardEvolveView : SpecialOperatorBoardLvlupContentView
	{
		// Token: 0x06018DF8 RID: 101880 RVA: 0x0009C438 File Offset: 0x0009A638
		[Token(Token = "0x6018DF8")]
		[Address(RVA = "0x1188390", Offset = "0x1186F90", VA = "0x181188390")]
		private bool _RebuildViewsIfNecessary(SpecialOperatorBoardLvlupEvolveModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06018DF9 RID: 101881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DF9")]
		[Address(RVA = "0x1187F00", Offset = "0x1186B00", VA = "0x181187F00")]
		private void _BuildViews(SpecialOperatorBoardLvlupEvolveModel viewModel)
		{
		}

		// Token: 0x06018DFA RID: 101882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018DFA")]
		[Address(RVA = "0x11881B0", Offset = "0x1186DB0", VA = "0x1811881B0")]
		private SpecialOperatorBoardEvolveItemView _GetPrefab(SpecialOperatorBoardEvolveItemType viewType)
		{
			return null;
		}

		// Token: 0x06018DFB RID: 101883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DFB")]
		[Address(RVA = "0x11884B0", Offset = "0x11870B0", VA = "0x1811884B0")]
		private void _UpdateCursor(bool isInit)
		{
		}

		// Token: 0x06018DFC RID: 101884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DFC")]
		[Address(RVA = "0x11882E0", Offset = "0x1186EE0", VA = "0x1811882E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018DFD RID: 101885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DFD")]
		[Address(RVA = "0x11878F0", Offset = "0x11864F0", VA = "0x1811878F0", Slot = "4")]
		public override void Render(SpecialOperatorBoardLvlupModel model, SpecialOperatorBoardLvlupContentView.Param param)
		{
		}

		// Token: 0x06018DFE RID: 101886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DFE")]
		[Address(RVA = "0x1187850", Offset = "0x1186450", VA = "0x181187850")]
		public void OnBackgroundClick()
		{
		}

		// Token: 0x06018DFF RID: 101887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DFF")]
		[Address(RVA = "0x1188A20", Offset = "0x1187620", VA = "0x181188A20")]
		public SpecialOperatorBoardEvolveView()
		{
		}

		// Token: 0x06018E00 RID: 101888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E00")]
		[Address(RVA = "0x116AED0", Offset = "0x1169AD0", VA = "0x18116AED0")]
		private void <>xLuaBaseProxy_Render(SpecialOperatorBoardLvlupModel P0, SpecialOperatorBoardLvlupContentView.Param P1)
		{
		}

		// Token: 0x0401EA3F RID: 125503
		[Token(Token = "0x401EA3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SpecialOperatorBoardEvolveItemView[] _viewPrefabs;

		// Token: 0x0401EA40 RID: 125504
		[Token(Token = "0x401EA40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SpecialOperatorBoardEvolveCursorView _cursor;

		// Token: 0x0401EA41 RID: 125505
		[Token(Token = "0x401EA41")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _contentContainer;

		// Token: 0x0401EA42 RID: 125506
		[Token(Token = "0x401EA42")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _cursorContainer;

		// Token: 0x0401EA43 RID: 125507
		[Token(Token = "0x401EA43")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _locationBounds;

		// Token: 0x0401EA44 RID: 125508
		[Token(Token = "0x401EA44")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _locationContent;

		// Token: 0x0401EA45 RID: 125509
		[Token(Token = "0x401EA45")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _locationViewPort;

		// Token: 0x0401EA46 RID: 125510
		[Token(Token = "0x401EA46")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401EA47 RID: 125511
		[Token(Token = "0x401EA47")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _expTip;

		// Token: 0x0401EA48 RID: 125512
		[Token(Token = "0x401EA48")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401EA49 RID: 125513
		[Token(Token = "0x401EA49")]
		[FieldOffset(Offset = "0x7C")]
		private int m_levelSumCheck;

		// Token: 0x0401EA4A RID: 125514
		[Token(Token = "0x401EA4A")]
		[FieldOffset(Offset = "0x80")]
		private List<SpecialOperatorBoardEvolveItemView> m_itemViews;

		// Token: 0x0401EA4B RID: 125515
		[Token(Token = "0x401EA4B")]
		[FieldOffset(Offset = "0x88")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x0401EA4C RID: 125516
		[Token(Token = "0x401EA4C")]
		[FieldOffset(Offset = "0x90")]
		private RectTransform m_cachedAnchor;

		// Token: 0x0401EA4D RID: 125517
		[Token(Token = "0x401EA4D")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EA4E RID: 125518
		[Token(Token = "0x401EA4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RebuildViewsIfNecessary;

		// Token: 0x0401EA4F RID: 125519
		[Token(Token = "0x401EA4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BuildViews;

		// Token: 0x0401EA50 RID: 125520
		[Token(Token = "0x401EA50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPrefab;

		// Token: 0x0401EA51 RID: 125521
		[Token(Token = "0x401EA51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateCursor;

		// Token: 0x0401EA52 RID: 125522
		[Token(Token = "0x401EA52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EA53 RID: 125523
		[Token(Token = "0x401EA53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EA54 RID: 125524
		[Token(Token = "0x401EA54")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackgroundClick;

		// Token: 0x0401EA55 RID: 125525
		[Token(Token = "0x401EA55")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E8F RID: 16015
		[Token(Token = "0x2003E8F")]
		private class OnPostLayoutUpdateCursorAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06018E01 RID: 101889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018E01")]
			[Address(RVA = "0x1182440", Offset = "0x1181040", VA = "0x181182440")]
			public OnPostLayoutUpdateCursorAction(SpecialOperatorBoardEvolveView closure, bool isInit)
			{
			}

			// Token: 0x06018E02 RID: 101890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018E02")]
			[Address(RVA = "0x11823C0", Offset = "0x1180FC0", VA = "0x1811823C0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401EA56 RID: 125526
			[Token(Token = "0x401EA56")]
			[FieldOffset(Offset = "0x10")]
			private SpecialOperatorBoardEvolveView m_closure;

			// Token: 0x0401EA57 RID: 125527
			[Token(Token = "0x401EA57")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isInit;
		}
	}
}
