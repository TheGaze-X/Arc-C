using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stencil
{
	// Token: 0x02005A4F RID: 23119
	[Token(Token = "0x2005A4F")]
	public abstract class UIStencilMaskable : Graphic, IHotfixable, IClippable
	{
		// Token: 0x06021A6E RID: 137838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A6E")]
		[Address(RVA = "0x1C2E530", Offset = "0x1C2D130", VA = "0x181C2E530", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06021A6F RID: 137839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A6F")]
		[Address(RVA = "0x1C2E4C0", Offset = "0x1C2D0C0", VA = "0x181C2E4C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x17004EFE RID: 20222
		// (get) Token: 0x06021A70 RID: 137840 RVA: 0x000BB0B0 File Offset: 0x000B92B0
		[Token(Token = "0x17004EFE")]
		private Rect rootCanvasRect
		{
			[Token(Token = "0x6021A70")]
			[Address(RVA = "0x1C2EB30", Offset = "0x1C2D730", VA = "0x181C2EB30")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x06021A71 RID: 137841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A71")]
		[Address(RVA = "0x1C2E6E0", Offset = "0x1C2D2E0", VA = "0x181C2E6E0", Slot = "57")]
		public void SetClipSoftness(Vector2 clipSoftness)
		{
		}

		// Token: 0x06021A72 RID: 137842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A72")]
		[Address(RVA = "0x1C2E5A0", Offset = "0x1C2D1A0", VA = "0x181C2E5A0", Slot = "53")]
		public void RecalculateClipping()
		{
		}

		// Token: 0x06021A73 RID: 137843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A73")]
		[Address(RVA = "0x1C2E3C0", Offset = "0x1C2CFC0", VA = "0x181C2E3C0", Slot = "55")]
		public void Cull(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x06021A74 RID: 137844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A74")]
		[Address(RVA = "0x1C2E600", Offset = "0x1C2D200", VA = "0x181C2E600", Slot = "56")]
		public void SetClipRect(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x06021A75 RID: 137845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A75")]
		[Address(RVA = "0x1C2E7D0", Offset = "0x1C2D3D0", VA = "0x181C2E7D0")]
		protected void UpdateClipParent()
		{
		}

		// Token: 0x06021A76 RID: 137846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A76")]
		[Address(RVA = "0x1C2E9B0", Offset = "0x1C2D5B0", VA = "0x181C2E9B0")]
		private void _UpdateCull(bool cull)
		{
		}

		// Token: 0x06021A77 RID: 137847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A77")]
		[Address(RVA = "0x1C2EA80", Offset = "0x1C2D680", VA = "0x181C2EA80")]
		protected UIStencilMaskable()
		{
		}

		// Token: 0x06021A78 RID: 137848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A78")]
		[Address(RVA = "0x1C2E770", Offset = "0x1C2D370", VA = "0x181C2E770", Slot = "52")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06021A79 RID: 137849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A79")]
		[Address(RVA = "0x1C2E760", Offset = "0x1C2D360", VA = "0x181C2E760")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06021A7A RID: 137850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A7A")]
		[Address(RVA = "0x1C2E750", Offset = "0x1C2D350", VA = "0x181C2E750")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x0402E041 RID: 188481
		[Token(Token = "0x402E041")]
		[FieldOffset(Offset = "0xB0")]
		private RectMask2D m_parentMask;

		// Token: 0x0402E042 RID: 188482
		[Token(Token = "0x402E042")]
		[FieldOffset(Offset = "0xB8")]
		private readonly Vector3[] m_corners;

		// Token: 0x0402E043 RID: 188483
		[Token(Token = "0x402E043")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402E044 RID: 188484
		[Token(Token = "0x402E044")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402E045 RID: 188485
		[Token(Token = "0x402E045")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rootCanvasRect;

		// Token: 0x0402E046 RID: 188486
		[Token(Token = "0x402E046")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetClipSoftness;

		// Token: 0x0402E047 RID: 188487
		[Token(Token = "0x402E047")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RecalculateClipping;

		// Token: 0x0402E048 RID: 188488
		[Token(Token = "0x402E048")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Cull;

		// Token: 0x0402E049 RID: 188489
		[Token(Token = "0x402E049")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetClipRect;

		// Token: 0x0402E04A RID: 188490
		[Token(Token = "0x402E04A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateClipParent;

		// Token: 0x0402E04B RID: 188491
		[Token(Token = "0x402E04B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateCull;

		// Token: 0x0402E04C RID: 188492
		[Token(Token = "0x402E04C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402E04D RID: 188493
		[Token(Token = "0x402E04D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge get_gameObject;
	}
}
