using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006361 RID: 25441
	[Token(Token = "0x2006361")]
	public class AutoChessShopCharListView : AutoChessShopBaseCharListView, ICommandExecutor, IHotfixable
	{
		// Token: 0x170056A6 RID: 22182
		// (get) Token: 0x06024B40 RID: 150336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056A6")]
		public override AutoChessShopLevelCharGroupItemView groupCharChessItemPrefab
		{
			[Token(Token = "0x6024B40")]
			[Address(RVA = "0x1F84B80", Offset = "0x1F83780", VA = "0x181F84B80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024B41 RID: 150337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B41")]
		[Address(RVA = "0x1F838E0", Offset = "0x1F824E0", VA = "0x181F838E0")]
		public void Init(AutoChessShopPage page)
		{
		}

		// Token: 0x06024B42 RID: 150338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B42")]
		[Address(RVA = "0x1F83A70", Offset = "0x1F82670", VA = "0x181F83A70")]
		public void Render(AutoChessShopLevelCharGroupListViewModel listViewModel, AutoChessShopBaseCharListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024B43 RID: 150339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B43")]
		[Address(RVA = "0x1F83D80", Offset = "0x1F82980", VA = "0x181F83D80")]
		public void ResetViewSeqCache()
		{
		}

		// Token: 0x06024B44 RID: 150340 RVA: 0x000C5478 File Offset: 0x000C3678
		[Token(Token = "0x6024B44")]
		[Address(RVA = "0x1F83860", Offset = "0x1F82460", VA = "0x181F83860")]
		public int GetLeftMostFocusChessInfo(out float columnIndex)
		{
			return 0;
		}

		// Token: 0x06024B45 RID: 150341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B45")]
		[Address(RVA = "0x1F84250", Offset = "0x1F82E50", VA = "0x181F84250")]
		public IEnumerator WaitForLayoutReady()
		{
			return null;
		}

		// Token: 0x06024B46 RID: 150342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B46")]
		[Address(RVA = "0x1F83DE0", Offset = "0x1F829E0", VA = "0x181F83DE0")]
		public void TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x06024B47 RID: 150343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B47")]
		[Address(RVA = "0x1F847F0", Offset = "0x1F833F0", VA = "0x181F847F0")]
		private void _TutorialOnly_RegisterTutorialGoLevelFiveDiyCharItem()
		{
		}

		// Token: 0x170056A7 RID: 22183
		// (get) Token: 0x06024B48 RID: 150344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056A7")]
		public string command
		{
			[Token(Token = "0x6024B48")]
			[Address(RVA = "0x1F84B10", Offset = "0x1F83710", VA = "0x181F84B10", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024B49 RID: 150345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B49")]
		[Address(RVA = "0x1F83670", Offset = "0x1F82270", VA = "0x181F83670", Slot = "6")]
		public void Execute(Command _, Action<ICommandExecutor> finishCb)
		{
		}

		// Token: 0x06024B4A RID: 150346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B4A")]
		[Address(RVA = "0x1F83A10", Offset = "0x1F82610", VA = "0x181F83A10", Slot = "7")]
		public void RaiseSignal(Command _)
		{
		}

		// Token: 0x06024B4B RID: 150347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B4B")]
		[Address(RVA = "0x1F83800", Offset = "0x1F82400", VA = "0x181F83800", Slot = "8")]
		public void ForceEnd()
		{
		}

		// Token: 0x06024B4C RID: 150348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B4C")]
		[Address(RVA = "0x1F83960", Offset = "0x1F82560", VA = "0x181F83960")]
		private void OnDestroy()
		{
		}

		// Token: 0x06024B4D RID: 150349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B4D")]
		[Address(RVA = "0x1F84300", Offset = "0x1F82F00", VA = "0x181F84300")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024B4E RID: 150350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B4E")]
		[Address(RVA = "0x1F84620", Offset = "0x1F83220", VA = "0x181F84620")]
		private void _TryStartScrollCo(AutoChessShopBaseCharListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024B4F RID: 150351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B4F")]
		[Address(RVA = "0x1F84530", Offset = "0x1F83130", VA = "0x181F84530")]
		private IEnumerator _TryScrollToPos(AutoChessShopBaseCharListView.FocusParams focusParams)
		{
			return null;
		}

		// Token: 0x06024B50 RID: 150352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B50")]
		[Address(RVA = "0x1F84A20", Offset = "0x1F83620", VA = "0x181F84A20")]
		public AutoChessShopCharListView()
		{
		}

		// Token: 0x06024B51 RID: 150353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B51")]
		[Address(RVA = "0x1F80E90", Offset = "0x1F7FA90", VA = "0x181F80E90")]
		private AutoChessShopLevelCharGroupItemView <>xLuaBaseProxy_get_groupCharChessItemPrefab()
		{
			return null;
		}

		// Token: 0x040333E6 RID: 209894
		[Token(Token = "0x40333E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessShopLevelCharGroupItemView _groupItemViewPrefab;

		// Token: 0x040333E7 RID: 209895
		[Token(Token = "0x40333E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleLayoutList;

		// Token: 0x040333E8 RID: 209896
		[Token(Token = "0x40333E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x040333E9 RID: 209897
		[Token(Token = "0x40333E9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x040333EA RID: 209898
		[Token(Token = "0x40333EA")]
		[FieldOffset(Offset = "0x40")]
		private AutoChessShopCharListRecycleAdapter m_adapter;

		// Token: 0x040333EB RID: 209899
		[Token(Token = "0x40333EB")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040333EC RID: 209900
		[Token(Token = "0x40333EC")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine m_scrollToGroupCoroutine;

		// Token: 0x040333ED RID: 209901
		[Token(Token = "0x40333ED")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessShopPage m_page;

		// Token: 0x040333EE RID: 209902
		[Token(Token = "0x40333EE")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_focusTween;

		// Token: 0x040333EF RID: 209903
		[Token(Token = "0x40333EF")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedRefreshSequenceNum;

		// Token: 0x040333F0 RID: 209904
		[Token(Token = "0x40333F0")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessShopBaseCharListView.FocusCoreLogic m_focusLogic;

		// Token: 0x040333F1 RID: 209905
		[Token(Token = "0x40333F1")]
		[FieldOffset(Offset = "0x78")]
		private string m_tutorial_levelFiveDiyChessId;

		// Token: 0x040333F2 RID: 209906
		[Token(Token = "0x40333F2")]
		private const float CHAR_CARD_BOUNDS_MARGIN = 28f;

		// Token: 0x040333F3 RID: 209907
		[Token(Token = "0x40333F3")]
		private const float GROUP_VIEW_HEADER_WIDTH = 120f;

		// Token: 0x040333F4 RID: 209908
		[Token(Token = "0x40333F4")]
		private const float GROUP_VIEW_ELEMENT_WIDTH = 123f;

		// Token: 0x040333F5 RID: 209909
		[Token(Token = "0x40333F5")]
		private const float GROUP_VIEW_ELEMENT_SPACING = 28f;

		// Token: 0x040333F6 RID: 209910
		[Token(Token = "0x40333F6")]
		private const float FOCUS_TWEEN_DUR = 0.6f;

		// Token: 0x040333F7 RID: 209911
		[Token(Token = "0x40333F7")]
		private const int TUTORIAL_FIRST_GROUP_LEVEL = 1;

		// Token: 0x040333F8 RID: 209912
		[Token(Token = "0x40333F8")]
		private const int TUTORIAL_FIRST_CHAR_CARD_POS = 0;

		// Token: 0x040333F9 RID: 209913
		[Token(Token = "0x40333F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupCharChessItemPrefab;

		// Token: 0x040333FA RID: 209914
		[Token(Token = "0x40333FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040333FB RID: 209915
		[Token(Token = "0x40333FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040333FC RID: 209916
		[Token(Token = "0x40333FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetViewSeqCache;

		// Token: 0x040333FD RID: 209917
		[Token(Token = "0x40333FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLeftMostFocusChessInfo;

		// Token: 0x040333FE RID: 209918
		[Token(Token = "0x40333FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_WaitForLayoutReady;

		// Token: 0x040333FF RID: 209919
		[Token(Token = "0x40333FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x04033400 RID: 209920
		[Token(Token = "0x4033400")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterTutorialGoLevelFiveDiyCharItem;

		// Token: 0x04033401 RID: 209921
		[Token(Token = "0x4033401")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_command;

		// Token: 0x04033402 RID: 209922
		[Token(Token = "0x4033402")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x04033403 RID: 209923
		[Token(Token = "0x4033403")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x04033404 RID: 209924
		[Token(Token = "0x4033404")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ForceEnd;

		// Token: 0x04033405 RID: 209925
		[Token(Token = "0x4033405")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04033406 RID: 209926
		[Token(Token = "0x4033406")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033407 RID: 209927
		[Token(Token = "0x4033407")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryStartScrollCo;

		// Token: 0x04033408 RID: 209928
		[Token(Token = "0x4033408")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TryScrollToPos;

		// Token: 0x04033409 RID: 209929
		[Token(Token = "0x4033409")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
