using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x0200600C RID: 24588
	[Token(Token = "0x200600C")]
	public class CGGalleryDragAndPinchView : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, IHotfixable
	{
		// Token: 0x170053FA RID: 21498
		// (get) Token: 0x060238C2 RID: 145602 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060238C3 RID: 145603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053FA")]
		public TouchHandler touchHandler
		{
			[Token(Token = "0x60238C2")]
			[Address(RVA = "0x1E2F230", Offset = "0x1E2DE30", VA = "0x181E2F230")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60238C3")]
			[Address(RVA = "0x1E2F290", Offset = "0x1E2DE90", VA = "0x181E2F290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060238C4 RID: 145604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238C4")]
		[Address(RVA = "0x1E2EE90", Offset = "0x1E2DA90", VA = "0x181E2EE90", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060238C5 RID: 145605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238C5")]
		[Address(RVA = "0x1E2EBD0", Offset = "0x1E2D7D0", VA = "0x181E2EBD0", Slot = "5")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060238C6 RID: 145606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238C6")]
		[Address(RVA = "0x1E2EFB0", Offset = "0x1E2DBB0", VA = "0x181E2EFB0", Slot = "8")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x060238C7 RID: 145607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238C7")]
		[Address(RVA = "0x1E2EDD0", Offset = "0x1E2D9D0", VA = "0x181E2EDD0", Slot = "6")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060238C8 RID: 145608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238C8")]
		[Address(RVA = "0x1E2EE30", Offset = "0x1E2DA30", VA = "0x181E2EE30", Slot = "7")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060238C9 RID: 145609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238C9")]
		[Address(RVA = "0x1E2ECF0", Offset = "0x1E2D8F0", VA = "0x181E2ECF0")]
		public void OnClicked()
		{
		}

		// Token: 0x060238CA RID: 145610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238CA")]
		[Address(RVA = "0x1E2F1D0", Offset = "0x1E2DDD0", VA = "0x181E2F1D0")]
		public CGGalleryDragAndPinchView()
		{
		}

		// Token: 0x04031303 RID: 201475
		[Token(Token = "0x4031303")]
		[FieldOffset(Offset = "0x18")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031304 RID: 201476
		[Token(Token = "0x4031304")]
		[FieldOffset(Offset = "0x28")]
		private TouchHandler.ScrollWheelComp m_scrollWheelComp;

		// Token: 0x04031306 RID: 201478
		[Token(Token = "0x4031306")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_touchHandler;

		// Token: 0x04031307 RID: 201479
		[Token(Token = "0x4031307")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_touchHandler;

		// Token: 0x04031308 RID: 201480
		[Token(Token = "0x4031308")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x04031309 RID: 201481
		[Token(Token = "0x4031309")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0403130A RID: 201482
		[Token(Token = "0x403130A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x0403130B RID: 201483
		[Token(Token = "0x403130B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0403130C RID: 201484
		[Token(Token = "0x403130C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x0403130D RID: 201485
		[Token(Token = "0x403130D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403130E RID: 201486
		[Token(Token = "0x403130E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
