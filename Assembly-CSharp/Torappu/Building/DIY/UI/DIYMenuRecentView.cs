using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200199E RID: 6558
	[Token(Token = "0x200199E")]
	public class DIYMenuRecentView : DIYBottomMenuTabStateView
	{
		// Token: 0x0600A4B0 RID: 42160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B0")]
		[Address(RVA = "0x31E2900", Offset = "0x31E1500", VA = "0x1831E2900", Slot = "8")]
		public override void ShowImmediately()
		{
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B1")]
		[Address(RVA = "0x31E21B0", Offset = "0x31E0DB0", VA = "0x1831E21B0", Slot = "9")]
		public override void HideImmediately()
		{
		}

		// Token: 0x0600A4B2 RID: 42162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4B2")]
		[Address(RVA = "0x31E26E0", Offset = "0x31E12E0", VA = "0x1831E26E0", Slot = "10")]
		public override Tween PlayShowTween()
		{
			return null;
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4B3")]
		[Address(RVA = "0x31E2510", Offset = "0x31E1110", VA = "0x1831E2510", Slot = "11")]
		public override Tween PlayHideTween()
		{
			return null;
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B4")]
		[Address(RVA = "0x31E2280", Offset = "0x31E0E80", VA = "0x1831E2280", Slot = "7")]
		public override void OnValueChanged(DIYMenuProperty property)
		{
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B5")]
		[Address(RVA = "0x31E2A10", Offset = "0x31E1610", VA = "0x1831E2A10")]
		public DIYMenuRecentView()
		{
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B7")]
		[Address(RVA = "0x31E2A00", Offset = "0x31E1600", VA = "0x1831E2A00")]
		private void <>xLuaBaseProxy_ShowImmediately()
		{
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B8")]
		[Address(RVA = "0x31E29D0", Offset = "0x31E15D0", VA = "0x1831E29D0")]
		private void <>xLuaBaseProxy_HideImmediately()
		{
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4B9")]
		[Address(RVA = "0x31E29F0", Offset = "0x31E15F0", VA = "0x1831E29F0")]
		private Tween <>xLuaBaseProxy_PlayShowTween()
		{
			return null;
		}

		// Token: 0x0600A4BA RID: 42170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4BA")]
		[Address(RVA = "0x31E29E0", Offset = "0x31E15E0", VA = "0x1831E29E0")]
		private Tween <>xLuaBaseProxy_PlayHideTween()
		{
			return null;
		}

		// Token: 0x04009BF2 RID: 39922
		[Token(Token = "0x4009BF2")]
		private const float OLD_VIEW_FADE_OUT_DURATION = 0.12f;

		// Token: 0x04009BF3 RID: 39923
		[Token(Token = "0x4009BF3")]
		private const float OLD_VIEW_FADE_OUT_DELAY = 0.24f;

		// Token: 0x04009BF4 RID: 39924
		[Token(Token = "0x4009BF4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DIYMenuRecentItemView _recentThemeView;

		// Token: 0x04009BF5 RID: 39925
		[Token(Token = "0x4009BF5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DIYMenuRecentItemView _recentSingleView;

		// Token: 0x04009BF6 RID: 39926
		[Token(Token = "0x4009BF6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _oldView;

		// Token: 0x04009BF7 RID: 39927
		[Token(Token = "0x4009BF7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _presetCount;

		// Token: 0x04009BF8 RID: 39928
		[Token(Token = "0x4009BF8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _tabTrackpoint;

		// Token: 0x04009BF9 RID: 39929
		[Token(Token = "0x4009BF9")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_switchingTween;

		// Token: 0x04009BFA RID: 39930
		[Token(Token = "0x4009BFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04009BFB RID: 39931
		[Token(Token = "0x4009BFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04009BFC RID: 39932
		[Token(Token = "0x4009BFC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayShowTween;

		// Token: 0x04009BFD RID: 39933
		[Token(Token = "0x4009BFD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayHideTween;

		// Token: 0x04009BFE RID: 39934
		[Token(Token = "0x4009BFE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04009BFF RID: 39935
		[Token(Token = "0x4009BFF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
