using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065DA RID: 26074
	[Token(Token = "0x20065DA")]
	public class ArtGalleryEntryState : PopupFadeState, IHotfixable
	{
		// Token: 0x060257B3 RID: 153523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60257B3")]
		[Address(RVA = "0x205D250", Offset = "0x205BE50", VA = "0x18205D250", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060257B4 RID: 153524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257B4")]
		[Address(RVA = "0x205D2B0", Offset = "0x205BEB0", VA = "0x18205D2B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060257B5 RID: 153525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257B5")]
		[Address(RVA = "0x205D620", Offset = "0x205C220", VA = "0x18205D620", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x060257B6 RID: 153526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257B6")]
		[Address(RVA = "0x205DA60", Offset = "0x205C660", VA = "0x18205DA60")]
		private void _OnExitClick()
		{
		}

		// Token: 0x060257B7 RID: 153527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257B7")]
		[Address(RVA = "0x205D890", Offset = "0x205C490", VA = "0x18205D890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060257B8 RID: 153528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257B8")]
		[Address(RVA = "0x205D810", Offset = "0x205C410", VA = "0x18205D810")]
		private void _ClearEntryAnimTween()
		{
		}

		// Token: 0x060257B9 RID: 153529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257B9")]
		[Address(RVA = "0x205DAF0", Offset = "0x205C6F0", VA = "0x18205DAF0")]
		public ArtGalleryEntryState()
		{
		}

		// Token: 0x060257BA RID: 153530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257BA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060257BB RID: 153531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257BB")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x040349AE RID: 215470
		[Token(Token = "0x40349AE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x040349AF RID: 215471
		[Token(Token = "0x40349AF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICommonTrackPoint _collectionRewardTrackPoint;

		// Token: 0x040349B0 RID: 215472
		[Token(Token = "0x40349B0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UICommonTrackPoint _collectionNewTrackPoint;

		// Token: 0x040349B1 RID: 215473
		[Token(Token = "0x40349B1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UICommonTrackPoint _magazineRewardTrackPoint;

		// Token: 0x040349B2 RID: 215474
		[Token(Token = "0x40349B2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICommonTrackPoint _magazineNewTrackPoint;

		// Token: 0x040349B3 RID: 215475
		[Token(Token = "0x40349B3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ArtGalleryEntryView _view;

		// Token: 0x040349B4 RID: 215476
		[Token(Token = "0x40349B4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x040349B5 RID: 215477
		[Token(Token = "0x40349B5")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040349B6 RID: 215478
		[Token(Token = "0x40349B6")]
		[FieldOffset(Offset = "0xC0")]
		private ArtGalleryEntryStateBean m_stateBean;

		// Token: 0x040349B7 RID: 215479
		[Token(Token = "0x40349B7")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x040349B8 RID: 215480
		[Token(Token = "0x40349B8")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_entryAnimTween;

		// Token: 0x040349B9 RID: 215481
		[Token(Token = "0x40349B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040349BA RID: 215482
		[Token(Token = "0x40349BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040349BB RID: 215483
		[Token(Token = "0x40349BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040349BC RID: 215484
		[Token(Token = "0x40349BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnExitClick;

		// Token: 0x040349BD RID: 215485
		[Token(Token = "0x40349BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040349BE RID: 215486
		[Token(Token = "0x40349BE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClearEntryAnimTween;

		// Token: 0x040349BF RID: 215487
		[Token(Token = "0x40349BF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
