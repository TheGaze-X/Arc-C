using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065D6 RID: 26070
	[Token(Token = "0x20065D6")]
	public class ArtGalleryDisplayState : PopupFadeState, IHotfixable, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06025797 RID: 153495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025797")]
		[Address(RVA = "0x205BB00", Offset = "0x205A700", VA = "0x18205BB00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025798 RID: 153496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025798")]
		[Address(RVA = "0x205BBF0", Offset = "0x205A7F0", VA = "0x18205BBF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025799 RID: 153497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025799")]
		[Address(RVA = "0x205C480", Offset = "0x205B080", VA = "0x18205C480")]
		private void _ClearEntryAnimTween()
		{
		}

		// Token: 0x0602579A RID: 153498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602579A")]
		[Address(RVA = "0x205CB20", Offset = "0x205B720", VA = "0x18205CB20")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x0602579B RID: 153499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602579B")]
		[Address(RVA = "0x205C330", Offset = "0x205AF30", VA = "0x18205C330", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602579C RID: 153500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602579C")]
		[Address(RVA = "0x205BED0", Offset = "0x205AAD0", VA = "0x18205BED0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602579D RID: 153501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602579D")]
		[Address(RVA = "0x205CA90", Offset = "0x205B690", VA = "0x18205CA90")]
		private void _OnExitClick()
		{
		}

		// Token: 0x0602579E RID: 153502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602579E")]
		[Address(RVA = "0x205C640", Offset = "0x205B240", VA = "0x18205C640")]
		private void _InitTabPagerModel()
		{
		}

		// Token: 0x0602579F RID: 153503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602579F")]
		[Address(RVA = "0x205CC20", Offset = "0x205B820", VA = "0x18205CC20")]
		private void _RefreshTabPagerModel(ArtGalleryDisplayViewModel viewModel)
		{
		}

		// Token: 0x060257A0 RID: 153504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A0")]
		[Address(RVA = "0x205C500", Offset = "0x205B100", VA = "0x18205C500")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060257A1 RID: 153505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A1")]
		[Address(RVA = "0x205BF40", Offset = "0x205AB40", VA = "0x18205BF40", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060257A2 RID: 153506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A2")]
		[Address(RVA = "0x205C9A0", Offset = "0x205B5A0", VA = "0x18205C9A0")]
		private void _NotifySystemUpdate()
		{
		}

		// Token: 0x060257A3 RID: 153507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A3")]
		[Address(RVA = "0x205CF90", Offset = "0x205BB90", VA = "0x18205CF90")]
		private void _SelectTab(long intVal)
		{
		}

		// Token: 0x060257A4 RID: 153508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A4")]
		[Address(RVA = "0x205CDC0", Offset = "0x205B9C0", VA = "0x18205CDC0")]
		private void _SelectFilter(long intVal)
		{
		}

		// Token: 0x060257A5 RID: 153509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A5")]
		[Address(RVA = "0x205CE70", Offset = "0x205BA70", VA = "0x18205CE70")]
		private void _SelectItem(object objVal)
		{
		}

		// Token: 0x060257A6 RID: 153510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A6")]
		[Address(RVA = "0x205D040", Offset = "0x205BC40", VA = "0x18205D040")]
		private void _UpdateFocus(float oneMinusNormalizedPos)
		{
		}

		// Token: 0x060257A7 RID: 153511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A7")]
		[Address(RVA = "0x205BB60", Offset = "0x205A760", VA = "0x18205BB60", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x060257A8 RID: 153512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A8")]
		[Address(RVA = "0x205D150", Offset = "0x205BD50", VA = "0x18205D150")]
		public ArtGalleryDisplayState()
		{
		}

		// Token: 0x060257A9 RID: 153513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257A9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060257AA RID: 153514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257AA")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x060257AB RID: 153515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257AB")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04034981 RID: 215425
		[Token(Token = "0x4034981")]
		[NonSerialized]
		public const int SELECT_TAB = 0;

		// Token: 0x04034982 RID: 215426
		[Token(Token = "0x4034982")]
		[NonSerialized]
		public const int SELECT_FILTER = 1;

		// Token: 0x04034983 RID: 215427
		[Token(Token = "0x4034983")]
		[NonSerialized]
		public const int SELECT_ITEM = 2;

		// Token: 0x04034984 RID: 215428
		[Token(Token = "0x4034984")]
		[NonSerialized]
		public const int FOCUS_UPDATE = 3;

		// Token: 0x04034985 RID: 215429
		[Token(Token = "0x4034985")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x04034986 RID: 215430
		[Token(Token = "0x4034986")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UITabPager _tabPager;

		// Token: 0x04034987 RID: 215431
		[Token(Token = "0x4034987")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ArtGalleryDisplayView _view;

		// Token: 0x04034988 RID: 215432
		[Token(Token = "0x4034988")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ArtGalleryBottomDetailHolder _bottomDetailHolder;

		// Token: 0x04034989 RID: 215433
		[Token(Token = "0x4034989")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _entryAnimationLocation;

		// Token: 0x0403498A RID: 215434
		[Token(Token = "0x403498A")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403498B RID: 215435
		[Token(Token = "0x403498B")]
		[FieldOffset(Offset = "0xB0")]
		private ListDict<string, ArtGalleryDisplayState.ModeModelBase> m_tabPageModels;

		// Token: 0x0403498C RID: 215436
		[Token(Token = "0x403498C")]
		[FieldOffset(Offset = "0xB8")]
		private UITabPager.Core m_tabPagerCore;

		// Token: 0x0403498D RID: 215437
		[Token(Token = "0x403498D")]
		[FieldOffset(Offset = "0xC0")]
		private ArtGalleryDisplayProperty m_property;

		// Token: 0x0403498E RID: 215438
		[Token(Token = "0x403498E")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x0403498F RID: 215439
		[Token(Token = "0x403498F")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_entryAnimTween;

		// Token: 0x04034990 RID: 215440
		[Token(Token = "0x4034990")]
		private const string TAB_LIST_MODE = "tab_list_mode";

		// Token: 0x04034991 RID: 215441
		[Token(Token = "0x4034991")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034992 RID: 215442
		[Token(Token = "0x4034992")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034993 RID: 215443
		[Token(Token = "0x4034993")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearEntryAnimTween;

		// Token: 0x04034994 RID: 215444
		[Token(Token = "0x4034994")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x04034995 RID: 215445
		[Token(Token = "0x4034995")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04034996 RID: 215446
		[Token(Token = "0x4034996")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04034997 RID: 215447
		[Token(Token = "0x4034997")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnExitClick;

		// Token: 0x04034998 RID: 215448
		[Token(Token = "0x4034998")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitTabPagerModel;

		// Token: 0x04034999 RID: 215449
		[Token(Token = "0x4034999")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshTabPagerModel;

		// Token: 0x0403499A RID: 215450
		[Token(Token = "0x403499A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403499B RID: 215451
		[Token(Token = "0x403499B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403499C RID: 215452
		[Token(Token = "0x403499C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__NotifySystemUpdate;

		// Token: 0x0403499D RID: 215453
		[Token(Token = "0x403499D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SelectTab;

		// Token: 0x0403499E RID: 215454
		[Token(Token = "0x403499E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SelectFilter;

		// Token: 0x0403499F RID: 215455
		[Token(Token = "0x403499F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SelectItem;

		// Token: 0x040349A0 RID: 215456
		[Token(Token = "0x40349A0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateFocus;

		// Token: 0x040349A1 RID: 215457
		[Token(Token = "0x40349A1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040349A2 RID: 215458
		[Token(Token = "0x40349A2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065D7 RID: 26071
		[Token(Token = "0x20065D7")]
		private abstract class ModeModelBase : UITabPager.TabPageViewModel
		{
			// Token: 0x060257AC RID: 153516 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60257AC")]
			[Address(RVA = "0x206CE60", Offset = "0x206BA60", VA = "0x18206CE60", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x060257AD RID: 153517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60257AD")]
			[Address(RVA = "0x206CF20", Offset = "0x206BB20", VA = "0x18206CF20")]
			protected ModeModelBase()
			{
			}

			// Token: 0x060257AE RID: 153518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60257AE")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x040349A3 RID: 215459
			[Token(Token = "0x40349A3")]
			[FieldOffset(Offset = "0x30")]
			public ArtGalleryTabType currTab;

			// Token: 0x040349A4 RID: 215460
			[Token(Token = "0x40349A4")]
			[FieldOffset(Offset = "0x34")]
			public ArtGalleryDisplayViewModel.ArtGalleryShuffleRule curShuffleRule;

			// Token: 0x040349A5 RID: 215461
			[Token(Token = "0x40349A5")]
			[FieldOffset(Offset = "0x38")]
			public ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam curSelectParam;

			// Token: 0x040349A6 RID: 215462
			[Token(Token = "0x40349A6")]
			[FieldOffset(Offset = "0x48")]
			public ArtGalleryDisplayViewModel.ArtGalleryFocusParam curFocusParam;

			// Token: 0x040349A7 RID: 215463
			[Token(Token = "0x40349A7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x040349A8 RID: 215464
			[Token(Token = "0x40349A8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020065D8 RID: 26072
		[Token(Token = "0x20065D8")]
		private class ListModeModel : ArtGalleryDisplayState.ModeModelBase
		{
			// Token: 0x060257AF RID: 153519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60257AF")]
			[Address(RVA = "0x206CDC0", Offset = "0x206B9C0", VA = "0x18206CDC0")]
			public ListModeModel()
			{
			}

			// Token: 0x040349A9 RID: 215465
			[Token(Token = "0x40349A9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020065D9 RID: 26073
		[Token(Token = "0x20065D9")]
		private class TabDataSource : UITabPager.TabDataSource
		{
			// Token: 0x060257B0 RID: 153520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60257B0")]
			[Address(RVA = "0x206DFB0", Offset = "0x206CBB0", VA = "0x18206DFB0")]
			public TabDataSource(ArtGalleryDisplayState closure)
			{
			}

			// Token: 0x060257B1 RID: 153521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60257B1")]
			[Address(RVA = "0x206DEF0", Offset = "0x206CAF0", VA = "0x18206DEF0", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x060257B2 RID: 153522 RVA: 0x000C8088 File Offset: 0x000C6288
			[Token(Token = "0x60257B2")]
			[Address(RVA = "0x206DE20", Offset = "0x206CA20", VA = "0x18206DE20", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x040349AA RID: 215466
			[Token(Token = "0x40349AA")]
			[FieldOffset(Offset = "0x10")]
			private ArtGalleryDisplayState m_closure;

			// Token: 0x040349AB RID: 215467
			[Token(Token = "0x40349AB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040349AC RID: 215468
			[Token(Token = "0x40349AC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTab;

			// Token: 0x040349AD RID: 215469
			[Token(Token = "0x40349AD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTabCount;
		}
	}
}
