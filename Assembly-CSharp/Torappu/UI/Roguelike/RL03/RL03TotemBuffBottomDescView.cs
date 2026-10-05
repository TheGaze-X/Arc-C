using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005859 RID: 22617
	[Token(Token = "0x2005859")]
	public class RL03TotemBuffBottomDescView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602108F RID: 135311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602108F")]
		[Address(RVA = "0x1B60C20", Offset = "0x1B5F820", VA = "0x181B60C20")]
		public void Render(string desc)
		{
		}

		// Token: 0x06021090 RID: 135312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021090")]
		[Address(RVA = "0x1B60B90", Offset = "0x1B5F790", VA = "0x181B60B90")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06021091 RID: 135313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021091")]
		[Address(RVA = "0x1B60E70", Offset = "0x1B5FA70", VA = "0x181B60E70")]
		private void _InitFocusStatusIfNot()
		{
		}

		// Token: 0x06021092 RID: 135314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021092")]
		[Address(RVA = "0x1B60F50", Offset = "0x1B5FB50", VA = "0x181B60F50")]
		private void _TweenFocusState()
		{
		}

		// Token: 0x06021093 RID: 135315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021093")]
		[Address(RVA = "0x1B61250", Offset = "0x1B5FE50", VA = "0x181B61250")]
		private void _TweenUnfocusState()
		{
		}

		// Token: 0x06021094 RID: 135316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021094")]
		[Address(RVA = "0x1B60DE0", Offset = "0x1B5F9E0", VA = "0x181B60DE0")]
		private void _ClearTimerTween()
		{
		}

		// Token: 0x06021095 RID: 135317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021095")]
		[Address(RVA = "0x1B612F0", Offset = "0x1B5FEF0", VA = "0x181B612F0")]
		public RL03TotemBuffBottomDescView()
		{
		}

		// Token: 0x0402CF03 RID: 184067
		[Token(Token = "0x402CF03")]
		private const float FOCUS_STAY_DUR = 1f;

		// Token: 0x0402CF04 RID: 184068
		[Token(Token = "0x402CF04")]
		private const float FOCUS_FADE_IN_DUR = 0.16f;

		// Token: 0x0402CF05 RID: 184069
		[Token(Token = "0x402CF05")]
		private const float FOCUS_FADE_OUT_DUR = 0.8f;

		// Token: 0x0402CF06 RID: 184070
		[Token(Token = "0x402CF06")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x0402CF07 RID: 184071
		[Token(Token = "0x402CF07")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroupFocus;

		// Token: 0x0402CF08 RID: 184072
		[Token(Token = "0x402CF08")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_focusTween;

		// Token: 0x0402CF09 RID: 184073
		[Token(Token = "0x402CF09")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_timerTween;

		// Token: 0x0402CF0A RID: 184074
		[Token(Token = "0x402CF0A")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isFocusInited;

		// Token: 0x0402CF0B RID: 184075
		[Token(Token = "0x402CF0B")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedDesc;

		// Token: 0x0402CF0C RID: 184076
		[Token(Token = "0x402CF0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CF0D RID: 184077
		[Token(Token = "0x402CF0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402CF0E RID: 184078
		[Token(Token = "0x402CF0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitFocusStatusIfNot;

		// Token: 0x0402CF0F RID: 184079
		[Token(Token = "0x402CF0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TweenFocusState;

		// Token: 0x0402CF10 RID: 184080
		[Token(Token = "0x402CF10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TweenUnfocusState;

		// Token: 0x0402CF11 RID: 184081
		[Token(Token = "0x402CF11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClearTimerTween;

		// Token: 0x0402CF12 RID: 184082
		[Token(Token = "0x402CF12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
