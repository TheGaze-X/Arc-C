using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Common.Effect
{
	// Token: 0x02005C28 RID: 23592
	[Token(Token = "0x2005C28")]
	public class UIBlinkEffect : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005036 RID: 20534
		// (get) Token: 0x0602232F RID: 140079 RVA: 0x000BCA00 File Offset: 0x000BAC00
		[Token(Token = "0x17005036")]
		public bool IsPlaying
		{
			[Token(Token = "0x602232F")]
			[Address(RVA = "0x1CB5450", Offset = "0x1CB4050", VA = "0x181CB5450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005037 RID: 20535
		// (get) Token: 0x06022330 RID: 140080 RVA: 0x000BCA18 File Offset: 0x000BAC18
		[Token(Token = "0x17005037")]
		public bool IsPaused
		{
			[Token(Token = "0x6022330")]
			[Address(RVA = "0x1CB53F0", Offset = "0x1CB3FF0", VA = "0x181CB53F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022331 RID: 140081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022331")]
		[Address(RVA = "0x1CB4B90", Offset = "0x1CB3790", VA = "0x181CB4B90")]
		private void Start()
		{
		}

		// Token: 0x06022332 RID: 140082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022332")]
		[Address(RVA = "0x1CB4740", Offset = "0x1CB3340", VA = "0x181CB4740")]
		private void OnDestroy()
		{
		}

		// Token: 0x06022333 RID: 140083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022333")]
		[Address(RVA = "0x1CB5070", Offset = "0x1CB3C70", VA = "0x181CB5070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022334 RID: 140084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022334")]
		[Address(RVA = "0x1CB4960", Offset = "0x1CB3560", VA = "0x181CB4960")]
		public void StartBlink()
		{
		}

		// Token: 0x06022335 RID: 140085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022335")]
		[Address(RVA = "0x1CB4C00", Offset = "0x1CB3800", VA = "0x181CB4C00")]
		public void StopBlink()
		{
		}

		// Token: 0x06022336 RID: 140086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022336")]
		[Address(RVA = "0x1CB47A0", Offset = "0x1CB33A0", VA = "0x181CB47A0")]
		public void SetBlinkParameters(float duration, float minAlpha, float maxAlpha, Ease easeType = Ease.InOutSine)
		{
		}

		// Token: 0x06022337 RID: 140087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022337")]
		[Address(RVA = "0x1CB48C0", Offset = "0x1CB34C0", VA = "0x181CB48C0")]
		public void SetCustomCurve(AnimationCurve curve)
		{
		}

		// Token: 0x06022338 RID: 140088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022338")]
		[Address(RVA = "0x1CB4D10", Offset = "0x1CB3910", VA = "0x181CB4D10")]
		private void _CreateBlinkTween()
		{
		}

		// Token: 0x06022339 RID: 140089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022339")]
		[Address(RVA = "0x1CB4C90", Offset = "0x1CB3890", VA = "0x181CB4C90")]
		private void _OnBlinkComplete()
		{
		}

		// Token: 0x0602233A RID: 140090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602233A")]
		[Address(RVA = "0x1CB51A0", Offset = "0x1CB3DA0", VA = "0x181CB51A0")]
		private void _SetAlpha(float alpha)
		{
		}

		// Token: 0x0602233B RID: 140091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602233B")]
		[Address(RVA = "0x1CB5340", Offset = "0x1CB3F40", VA = "0x181CB5340")]
		public UIBlinkEffect()
		{
		}

		// Token: 0x0402EE93 RID: 192147
		[Token(Token = "0x402EE93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _autoStart;

		// Token: 0x0402EE94 RID: 192148
		[Token(Token = "0x402EE94")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _isPingPong;

		// Token: 0x0402EE95 RID: 192149
		[Token(Token = "0x402EE95")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _duration;

		// Token: 0x0402EE96 RID: 192150
		[Token(Token = "0x402EE96")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minAlpha;

		// Token: 0x0402EE97 RID: 192151
		[Token(Token = "0x402EE97")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxAlpha;

		// Token: 0x0402EE98 RID: 192152
		[Token(Token = "0x402EE98")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useCustomCurve;

		// Token: 0x0402EE99 RID: 192153
		[Token(Token = "0x402EE99")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x0402EE9A RID: 192154
		[Token(Token = "0x402EE9A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _customCurve;

		// Token: 0x0402EE9B RID: 192155
		[Token(Token = "0x402EE9B")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isPlaying;

		// Token: 0x0402EE9C RID: 192156
		[Token(Token = "0x402EE9C")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isPaused;

		// Token: 0x0402EE9D RID: 192157
		[Token(Token = "0x402EE9D")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_blinkTween;

		// Token: 0x0402EE9E RID: 192158
		[Token(Token = "0x402EE9E")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402EE9F RID: 192159
		[Token(Token = "0x402EE9F")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isInversed;

		// Token: 0x0402EEA0 RID: 192160
		[Token(Token = "0x402EEA0")]
		[FieldOffset(Offset = "0x50")]
		private Image m_targetImage;

		// Token: 0x0402EEA1 RID: 192161
		[Token(Token = "0x402EEA1")]
		[FieldOffset(Offset = "0x58")]
		private CanvasGroup m_targetCanvasGroup;

		// Token: 0x0402EEA2 RID: 192162
		[Token(Token = "0x402EEA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_IsPlaying;

		// Token: 0x0402EEA3 RID: 192163
		[Token(Token = "0x402EEA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_IsPaused;

		// Token: 0x0402EEA4 RID: 192164
		[Token(Token = "0x402EEA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0402EEA5 RID: 192165
		[Token(Token = "0x402EEA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402EEA6 RID: 192166
		[Token(Token = "0x402EEA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EEA7 RID: 192167
		[Token(Token = "0x402EEA7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StartBlink;

		// Token: 0x0402EEA8 RID: 192168
		[Token(Token = "0x402EEA8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopBlink;

		// Token: 0x0402EEA9 RID: 192169
		[Token(Token = "0x402EEA9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetBlinkParameters;

		// Token: 0x0402EEAA RID: 192170
		[Token(Token = "0x402EEAA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetCustomCurve;

		// Token: 0x0402EEAB RID: 192171
		[Token(Token = "0x402EEAB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateBlinkTween;

		// Token: 0x0402EEAC RID: 192172
		[Token(Token = "0x402EEAC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBlinkComplete;

		// Token: 0x0402EEAD RID: 192173
		[Token(Token = "0x402EEAD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetAlpha;

		// Token: 0x0402EEAE RID: 192174
		[Token(Token = "0x402EEAE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
