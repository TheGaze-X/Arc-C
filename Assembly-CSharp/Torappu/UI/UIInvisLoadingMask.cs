using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A08 RID: 14856
	[Token(Token = "0x2003A08")]
	public class UIInvisLoadingMask : UIFloatMask
	{
		// Token: 0x0601771C RID: 96028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601771C")]
		[Address(RVA = "0xFCBC30", Offset = "0xFCA830", VA = "0x180FCBC30", Slot = "6")]
		protected override IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x0601771D RID: 96029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601771D")]
		[Address(RVA = "0xFCBF80", Offset = "0xFCAB80", VA = "0x180FCBF80", Slot = "4")]
		protected override IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0601771E RID: 96030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601771E")]
		[Address(RVA = "0xFCBD70", Offset = "0xFCA970", VA = "0x180FCBD70", Slot = "5")]
		protected override void OnShow()
		{
		}

		// Token: 0x0601771F RID: 96031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601771F")]
		[Address(RVA = "0xFCBCE0", Offset = "0xFCA8E0", VA = "0x180FCBCE0", Slot = "7")]
		protected override void OnHide()
		{
		}

		// Token: 0x06017720 RID: 96032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017720")]
		[Address(RVA = "0xFCBBD0", Offset = "0xFCA7D0", VA = "0x180FCBBD0")]
		public void EventOnClick()
		{
		}

		// Token: 0x06017721 RID: 96033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017721")]
		[Address(RVA = "0xFCC230", Offset = "0xFCAE30", VA = "0x180FCC230")]
		private void _ShowRipple()
		{
		}

		// Token: 0x06017722 RID: 96034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017722")]
		[Address(RVA = "0xFCC180", Offset = "0xFCAD80", VA = "0x180FCC180")]
		private IEnumerator _HideRipple()
		{
			return null;
		}

		// Token: 0x06017723 RID: 96035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017723")]
		[Address(RVA = "0xFCC040", Offset = "0xFCAC40", VA = "0x180FCC040")]
		private IEnumerator _AutoShowRippleCoroutine()
		{
			return null;
		}

		// Token: 0x06017724 RID: 96036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017724")]
		[Address(RVA = "0xFCC0F0", Offset = "0xFCACF0", VA = "0x180FCC0F0")]
		private void _ClearFadeTween()
		{
		}

		// Token: 0x06017725 RID: 96037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017725")]
		[Address(RVA = "0xFCC390", Offset = "0xFCAF90", VA = "0x180FCC390")]
		public UIInvisLoadingMask()
		{
		}

		// Token: 0x06017726 RID: 96038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017726")]
		[Address(RVA = "0xFCC030", Offset = "0xFCAC30", VA = "0x180FCC030")]
		private void <>xLuaBaseProxy_OnShow()
		{
		}

		// Token: 0x06017727 RID: 96039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017727")]
		[Address(RVA = "0xED08C0", Offset = "0xECF4C0", VA = "0x180ED08C0")]
		private void <>xLuaBaseProxy_OnHide()
		{
		}

		// Token: 0x0401C52B RID: 116011
		[Token(Token = "0x401C52B")]
		private const float ANIM_DURATION = 0.23f;

		// Token: 0x0401C52C RID: 116012
		[Token(Token = "0x401C52C")]
		private const float LONG_TIME_THRESHOLD = 0.3f;

		// Token: 0x0401C52D RID: 116013
		[Token(Token = "0x401C52D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _ripplePanel;

		// Token: 0x0401C52E RID: 116014
		[Token(Token = "0x401C52E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _rippleAnim;

		// Token: 0x0401C52F RID: 116015
		[Token(Token = "0x401C52F")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_fadeTween;

		// Token: 0x0401C530 RID: 116016
		[Token(Token = "0x401C530")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_animTween;

		// Token: 0x0401C531 RID: 116017
		[Token(Token = "0x401C531")]
		[FieldOffset(Offset = "0x68")]
		private bool m_showRipple;

		// Token: 0x0401C532 RID: 116018
		[Token(Token = "0x401C532")]
		[FieldOffset(Offset = "0x69")]
		private bool m_disableRippleLock;

		// Token: 0x0401C533 RID: 116019
		[Token(Token = "0x401C533")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401C534 RID: 116020
		[Token(Token = "0x401C534")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401C535 RID: 116021
		[Token(Token = "0x401C535")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401C536 RID: 116022
		[Token(Token = "0x401C536")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x0401C537 RID: 116023
		[Token(Token = "0x401C537")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401C538 RID: 116024
		[Token(Token = "0x401C538")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowRipple;

		// Token: 0x0401C539 RID: 116025
		[Token(Token = "0x401C539")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HideRipple;

		// Token: 0x0401C53A RID: 116026
		[Token(Token = "0x401C53A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AutoShowRippleCoroutine;

		// Token: 0x0401C53B RID: 116027
		[Token(Token = "0x401C53B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearFadeTween;

		// Token: 0x0401C53C RID: 116028
		[Token(Token = "0x401C53C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
