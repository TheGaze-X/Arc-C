using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006551 RID: 25937
	[Token(Token = "0x2006551")]
	public class ArtMagazineDiyLeafDragAndPinchView : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, IHotfixable
	{
		// Token: 0x17005813 RID: 22547
		// (get) Token: 0x060254B0 RID: 152752 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060254B1 RID: 152753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005813")]
		public string itemId
		{
			[Token(Token = "0x60254B0")]
			[Address(RVA = "0x204CF10", Offset = "0x204BB10", VA = "0x18204CF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60254B1")]
			[Address(RVA = "0x204CF70", Offset = "0x204BB70", VA = "0x18204CF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060254B2 RID: 152754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254B2")]
		[Address(RVA = "0x204CA20", Offset = "0x204B620", VA = "0x18204CA20", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060254B3 RID: 152755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254B3")]
		[Address(RVA = "0x204C710", Offset = "0x204B310", VA = "0x18204C710", Slot = "5")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060254B4 RID: 152756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254B4")]
		[Address(RVA = "0x204C960", Offset = "0x204B560", VA = "0x18204C960", Slot = "6")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060254B5 RID: 152757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254B5")]
		[Address(RVA = "0x204C9C0", Offset = "0x204B5C0", VA = "0x18204C9C0", Slot = "7")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060254B6 RID: 152758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254B6")]
		[Address(RVA = "0x204CBE0", Offset = "0x204B7E0", VA = "0x18204CBE0", Slot = "8")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x060254B7 RID: 152759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254B7")]
		[Address(RVA = "0x204CEB0", Offset = "0x204BAB0", VA = "0x18204CEB0")]
		public ArtMagazineDiyLeafDragAndPinchView()
		{
		}

		// Token: 0x0403452B RID: 214315
		[Token(Token = "0x403452B")]
		[FieldOffset(Offset = "0x18")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403452C RID: 214316
		[Token(Token = "0x403452C")]
		[FieldOffset(Offset = "0x28")]
		private TouchHandler.ScrollWheelComp m_scrollWheelComp;

		// Token: 0x0403452E RID: 214318
		[Token(Token = "0x403452E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x0403452F RID: 214319
		[Token(Token = "0x403452F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemId;

		// Token: 0x04034530 RID: 214320
		[Token(Token = "0x4034530")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x04034531 RID: 214321
		[Token(Token = "0x4034531")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x04034532 RID: 214322
		[Token(Token = "0x4034532")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x04034533 RID: 214323
		[Token(Token = "0x4034533")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x04034534 RID: 214324
		[Token(Token = "0x4034534")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x04034535 RID: 214325
		[Token(Token = "0x4034535")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
