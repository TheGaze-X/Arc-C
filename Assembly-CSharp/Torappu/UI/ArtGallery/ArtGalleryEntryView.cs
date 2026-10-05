using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065DB RID: 26075
	[Token(Token = "0x20065DB")]
	public class ArtGalleryEntryView : DataBinder<ArtGalleryEntryProperty>, IHotfixable
	{
		// Token: 0x060257BC RID: 153532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257BC")]
		[Address(RVA = "0x205DE50", Offset = "0x205CA50", VA = "0x18205DE50", Slot = "7")]
		public override void OnValueChanged(ArtGalleryEntryProperty property)
		{
		}

		// Token: 0x060257BD RID: 153533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257BD")]
		[Address(RVA = "0x205DDB0", Offset = "0x205C9B0", VA = "0x18205DDB0")]
		public void EventOpenWardrobePage()
		{
		}

		// Token: 0x060257BE RID: 153534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257BE")]
		[Address(RVA = "0x205DC50", Offset = "0x205C850", VA = "0x18205DC50")]
		public void EventOpenGalleryDisplayState()
		{
		}

		// Token: 0x060257BF RID: 153535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257BF")]
		[Address(RVA = "0x205DBA0", Offset = "0x205C7A0", VA = "0x18205DBA0")]
		public void EventOpenCollectionDisplayState()
		{
		}

		// Token: 0x060257C0 RID: 153536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257C0")]
		[Address(RVA = "0x205DD00", Offset = "0x205C900", VA = "0x18205DD00")]
		public void EventOpenMagazineCoverPage()
		{
		}

		// Token: 0x060257C1 RID: 153537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257C1")]
		[Address(RVA = "0x205DF20", Offset = "0x205CB20", VA = "0x18205DF20")]
		public ArtGalleryEntryView()
		{
		}

		// Token: 0x040349C0 RID: 215488
		[Token(Token = "0x40349C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _skinCount;

		// Token: 0x040349C1 RID: 215489
		[Token(Token = "0x40349C1")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040349C2 RID: 215490
		[Token(Token = "0x40349C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040349C3 RID: 215491
		[Token(Token = "0x40349C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOpenWardrobePage;

		// Token: 0x040349C4 RID: 215492
		[Token(Token = "0x40349C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOpenGalleryDisplayState;

		// Token: 0x040349C5 RID: 215493
		[Token(Token = "0x40349C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOpenCollectionDisplayState;

		// Token: 0x040349C6 RID: 215494
		[Token(Token = "0x40349C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOpenMagazineCoverPage;

		// Token: 0x040349C7 RID: 215495
		[Token(Token = "0x40349C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
