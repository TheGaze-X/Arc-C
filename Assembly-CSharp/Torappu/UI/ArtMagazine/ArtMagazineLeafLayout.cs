using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065BD RID: 26045
	[Token(Token = "0x20065BD")]
	[RequireComponent(typeof(RectTransform))]
	public class ArtMagazineLeafLayout : UIBehaviour, IHotfixable
	{
		// Token: 0x060256DD RID: 153309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256DD")]
		[Address(RVA = "0x2068D20", Offset = "0x2067920", VA = "0x182068D20", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060256DE RID: 153310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256DE")]
		[Address(RVA = "0x2068D90", Offset = "0x2067990", VA = "0x182068D90", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060256DF RID: 153311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256DF")]
		[Address(RVA = "0x2068E00", Offset = "0x2067A00", VA = "0x182068E00", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060256E0 RID: 153312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256E0")]
		[Address(RVA = "0x2068E70", Offset = "0x2067A70", VA = "0x182068E70")]
		private void _UpdateRectTransform()
		{
		}

		// Token: 0x060256E1 RID: 153313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256E1")]
		[Address(RVA = "0x2069360", Offset = "0x2067F60", VA = "0x182069360")]
		public ArtMagazineLeafLayout()
		{
		}

		// Token: 0x060256E2 RID: 153314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060256E3 RID: 153315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256E3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060256E4 RID: 153316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256E4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnTransformParentChanged()
		{
		}

		// Token: 0x0403487A RID: 215162
		[Token(Token = "0x403487A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform[] _elementList;

		// Token: 0x0403487B RID: 215163
		[Token(Token = "0x403487B")]
		[FieldOffset(Offset = "0x20")]
		private Rect m_currRect;

		// Token: 0x0403487C RID: 215164
		[Token(Token = "0x403487C")]
		[FieldOffset(Offset = "0x30")]
		private List<IArtMagazineLeafLayoutDrivenTrigger> m_triggerList;

		// Token: 0x0403487D RID: 215165
		[Token(Token = "0x403487D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCanvasHierarchyChanged;

		// Token: 0x0403487E RID: 215166
		[Token(Token = "0x403487E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRectTransformDimensionsChange;

		// Token: 0x0403487F RID: 215167
		[Token(Token = "0x403487F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTransformParentChanged;

		// Token: 0x04034880 RID: 215168
		[Token(Token = "0x4034880")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateRectTransform;

		// Token: 0x04034881 RID: 215169
		[Token(Token = "0x4034881")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
