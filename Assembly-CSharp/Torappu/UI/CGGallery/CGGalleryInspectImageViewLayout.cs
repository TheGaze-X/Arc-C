using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x0200600F RID: 24591
	[Token(Token = "0x200600F")]
	[RequireComponent(typeof(RectTransform))]
	public class CGGalleryInspectImageViewLayout : UIBehaviour, IHotfixable
	{
		// Token: 0x060238EF RID: 145647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238EF")]
		[Address(RVA = "0x1E32680", Offset = "0x1E31280", VA = "0x181E32680", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060238F0 RID: 145648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F0")]
		[Address(RVA = "0x1E32610", Offset = "0x1E31210", VA = "0x181E32610", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060238F1 RID: 145649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F1")]
		[Address(RVA = "0x1E326F0", Offset = "0x1E312F0", VA = "0x181E326F0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060238F2 RID: 145650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F2")]
		[Address(RVA = "0x1E32760", Offset = "0x1E31360", VA = "0x181E32760", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060238F3 RID: 145651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F3")]
		[Address(RVA = "0x1E327D0", Offset = "0x1E313D0", VA = "0x181E327D0")]
		private void _UpdateRectTransform()
		{
		}

		// Token: 0x060238F4 RID: 145652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F4")]
		[Address(RVA = "0x1E32A90", Offset = "0x1E31690", VA = "0x181E32A90")]
		public CGGalleryInspectImageViewLayout()
		{
		}

		// Token: 0x060238F5 RID: 145653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x060238F6 RID: 145654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060238F7 RID: 145655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060238F8 RID: 145656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238F8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnTransformParentChanged()
		{
		}

		// Token: 0x04031345 RID: 201541
		[Token(Token = "0x4031345")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CGGalleryInspectImageViewScaleHandler _scaleHandler;

		// Token: 0x04031346 RID: 201542
		[Token(Token = "0x4031346")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _contentSize;

		// Token: 0x04031347 RID: 201543
		[Token(Token = "0x4031347")]
		[FieldOffset(Offset = "0x28")]
		private Rect m_currRect;

		// Token: 0x04031348 RID: 201544
		[Token(Token = "0x4031348")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04031349 RID: 201545
		[Token(Token = "0x4031349")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCanvasHierarchyChanged;

		// Token: 0x0403134A RID: 201546
		[Token(Token = "0x403134A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRectTransformDimensionsChange;

		// Token: 0x0403134B RID: 201547
		[Token(Token = "0x403134B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTransformParentChanged;

		// Token: 0x0403134C RID: 201548
		[Token(Token = "0x403134C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateRectTransform;

		// Token: 0x0403134D RID: 201549
		[Token(Token = "0x403134D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
