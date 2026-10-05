using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200346C RID: 13420
	[Token(Token = "0x200346C")]
	public class Act6FunUIDynPosJoystickHost : UIDynPosJoystickHost
	{
		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0601569A RID: 87706 RVA: 0x0008BBA8 File Offset: 0x00089DA8
		[Token(Token = "0x17003299")]
		public bool isJoystickDisabled
		{
			[Token(Token = "0x601569A")]
			[Address(RVA = "0xDDFAE0", Offset = "0xDDE6E0", VA = "0x180DDFAE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601569B RID: 87707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601569B")]
		[Address(RVA = "0xDDF990", Offset = "0xDDE590", VA = "0x180DDF990", Slot = "8")]
		protected override void _InitIfNot()
		{
		}

		// Token: 0x0601569C RID: 87708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601569C")]
		[Address(RVA = "0xDDF5C0", Offset = "0xDDE1C0", VA = "0x180DDF5C0", Slot = "9")]
		protected override UISwitchTween InitSwitchTween(CanvasGroup canvasGroupJoystick)
		{
			return null;
		}

		// Token: 0x0601569D RID: 87709 RVA: 0x0008BBC0 File Offset: 0x00089DC0
		[Token(Token = "0x601569D")]
		[Address(RVA = "0xDDF460", Offset = "0xDDE060", VA = "0x180DDF460", Slot = "10")]
		protected override Vector2 CalculateJoystickPos(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x0601569E RID: 87710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601569E")]
		[Address(RVA = "0xDDF760", Offset = "0xDDE360", VA = "0x180DDF760", Slot = "11")]
		protected override void ResetJoystick()
		{
		}

		// Token: 0x0601569F RID: 87711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601569F")]
		[Address(RVA = "0xDDF800", Offset = "0xDDE400", VA = "0x180DDF800")]
		public void SetJoystickDisable(bool isDisable, string disableKey)
		{
		}

		// Token: 0x060156A0 RID: 87712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156A0")]
		[Address(RVA = "0xDDFA30", Offset = "0xDDE630", VA = "0x180DDFA30")]
		public Act6FunUIDynPosJoystickHost()
		{
		}

		// Token: 0x060156A1 RID: 87713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156A1")]
		[Address(RVA = "0xDDF980", Offset = "0xDDE580", VA = "0x180DDF980")]
		private void <>xLuaBaseProxy__InitIfNot()
		{
		}

		// Token: 0x060156A2 RID: 87714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156A2")]
		[Address(RVA = "0xDDF960", Offset = "0xDDE560", VA = "0x180DDF960")]
		private UISwitchTween <>xLuaBaseProxy_InitSwitchTween(CanvasGroup P0)
		{
			return null;
		}

		// Token: 0x060156A3 RID: 87715 RVA: 0x0008BBD8 File Offset: 0x00089DD8
		[Token(Token = "0x60156A3")]
		[Address(RVA = "0xDDF950", Offset = "0xDDE550", VA = "0x180DDF950")]
		private Vector2 <>xLuaBaseProxy_CalculateJoystickPos(PointerEventData P0)
		{
			return default(Vector2);
		}

		// Token: 0x060156A4 RID: 87716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156A4")]
		[Address(RVA = "0xDDF970", Offset = "0xDDE570", VA = "0x180DDF970")]
		private void <>xLuaBaseProxy_ResetJoystick()
		{
		}

		// Token: 0x04019A32 RID: 105010
		[Token(Token = "0x4019A32")]
		public const float DEFAULT_TWEEN_DURATION = 0.16f;

		// Token: 0x04019A33 RID: 105011
		[Token(Token = "0x4019A33")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _inactiveAlpha;

		// Token: 0x04019A34 RID: 105012
		[Token(Token = "0x4019A34")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _activeAlpha;

		// Token: 0x04019A35 RID: 105013
		[Token(Token = "0x4019A35")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _joystickRestrictArea;

		// Token: 0x04019A36 RID: 105014
		[Token(Token = "0x4019A36")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_defaultJoystickPos;

		// Token: 0x04019A37 RID: 105015
		[Token(Token = "0x4019A37")]
		[FieldOffset(Offset = "0x78")]
		private EnableStateWithKey m_isJoystickDisabled;

		// Token: 0x04019A38 RID: 105016
		[Token(Token = "0x4019A38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isJoystickDisabled;

		// Token: 0x04019A39 RID: 105017
		[Token(Token = "0x4019A39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019A3A RID: 105018
		[Token(Token = "0x4019A3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitSwitchTween;

		// Token: 0x04019A3B RID: 105019
		[Token(Token = "0x4019A3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalculateJoystickPos;

		// Token: 0x04019A3C RID: 105020
		[Token(Token = "0x4019A3C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetJoystick;

		// Token: 0x04019A3D RID: 105021
		[Token(Token = "0x4019A3D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetJoystickDisable;

		// Token: 0x04019A3E RID: 105022
		[Token(Token = "0x4019A3E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200346D RID: 13421
		[Token(Token = "0x200346D")]
		private class Act6FunUISwitchTween : UISwitchTween
		{
			// Token: 0x060156A5 RID: 87717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156A5")]
			[Address(RVA = "0xDDFD80", Offset = "0xDDE980", VA = "0x180DDFD80")]
			public Act6FunUISwitchTween(CanvasGroup alphaHandler, float inactiveAlpha, float activeAlpha)
			{
			}

			// Token: 0x060156A6 RID: 87718 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60156A6")]
			[Address(RVA = "0xDDFB50", Offset = "0xDDE750", VA = "0x180DDFB50", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060156A7 RID: 87719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60156A7")]
			[Address(RVA = "0xDDFC20", Offset = "0xDDE820", VA = "0x180DDFC20", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060156A8 RID: 87720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156A8")]
			[Address(RVA = "0xDDFCF0", Offset = "0xDDE8F0", VA = "0x180DDFCF0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060156A9 RID: 87721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156A9")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04019A3F RID: 105023
			[Token(Token = "0x4019A3F")]
			[FieldOffset(Offset = "0x48")]
			private float m_inactiveAlpha;

			// Token: 0x04019A40 RID: 105024
			[Token(Token = "0x4019A40")]
			[FieldOffset(Offset = "0x4C")]
			private float m_activeAlpha;

			// Token: 0x04019A41 RID: 105025
			[Token(Token = "0x4019A41")]
			[FieldOffset(Offset = "0x50")]
			private CanvasGroup m_alphaHandler;

			// Token: 0x04019A42 RID: 105026
			[Token(Token = "0x4019A42")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019A43 RID: 105027
			[Token(Token = "0x4019A43")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04019A44 RID: 105028
			[Token(Token = "0x4019A44")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04019A45 RID: 105029
			[Token(Token = "0x4019A45")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
