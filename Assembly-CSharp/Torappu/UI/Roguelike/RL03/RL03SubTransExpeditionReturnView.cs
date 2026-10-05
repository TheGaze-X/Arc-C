using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005885 RID: 22661
	[Token(Token = "0x2005885")]
	public class RL03SubTransExpeditionReturnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004D9E RID: 19870
		// (get) Token: 0x0602115D RID: 135517 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602115E RID: 135518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D9E")]
		public Action onLastConfirmed
		{
			[Token(Token = "0x602115D")]
			[Address(RVA = "0x1B5F900", Offset = "0x1B5E500", VA = "0x181B5F900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602115E")]
			[Address(RVA = "0x1B5F960", Offset = "0x1B5E560", VA = "0x181B5F960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602115F RID: 135519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602115F")]
		[Address(RVA = "0x1B5F520", Offset = "0x1B5E120", VA = "0x181B5F520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021160 RID: 135520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021160")]
		[Address(RVA = "0x1B5F600", Offset = "0x1B5E200", VA = "0x181B5F600")]
		private void _RenderSingle(int index, int totalCount)
		{
		}

		// Token: 0x06021161 RID: 135521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021161")]
		[Address(RVA = "0x1B5F7C0", Offset = "0x1B5E3C0", VA = "0x181B5F7C0")]
		private IEnumerator _TransCoroutineSingle(int index, int totalCount)
		{
			return null;
		}

		// Token: 0x06021162 RID: 135522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021162")]
		[Address(RVA = "0x1B5F240", Offset = "0x1B5DE40", VA = "0x181B5F240")]
		public void Render(RL03SubTransExpeditionReturnController.ExpeditionReturnModel viewModel)
		{
		}

		// Token: 0x06021163 RID: 135523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021163")]
		[Address(RVA = "0x1B5F440", Offset = "0x1B5E040", VA = "0x181B5F440")]
		public IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x06021164 RID: 135524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021164")]
		[Address(RVA = "0x1B5F390", Offset = "0x1B5DF90", VA = "0x181B5F390")]
		public void Reset()
		{
		}

		// Token: 0x06021165 RID: 135525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021165")]
		[Address(RVA = "0x1B5F130", Offset = "0x1B5DD30", VA = "0x181B5F130")]
		public void Hide()
		{
		}

		// Token: 0x06021166 RID: 135526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021166")]
		[Address(RVA = "0x1B5F1A0", Offset = "0x1B5DDA0", VA = "0x181B5F1A0")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x06021167 RID: 135527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021167")]
		[Address(RVA = "0x1B5F8A0", Offset = "0x1B5E4A0", VA = "0x181B5F8A0")]
		public RL03SubTransExpeditionReturnView()
		{
		}

		// Token: 0x0402D0AC RID: 184492
		[Token(Token = "0x402D0AC")]
		private const float HIDE_TWEEN_DURATION = 0.5f;

		// Token: 0x0402D0AD RID: 184493
		[Token(Token = "0x402D0AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _panelMainTrans;

		// Token: 0x0402D0AE RID: 184494
		[Token(Token = "0x402D0AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClickPlayer _clickAudio;

		// Token: 0x0402D0AF RID: 184495
		[Token(Token = "0x402D0AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClickPlayer _clickAudioClose;

		// Token: 0x0402D0B0 RID: 184496
		[Token(Token = "0x402D0B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _charText;

		// Token: 0x0402D0B1 RID: 184497
		[Token(Token = "0x402D0B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0402D0B2 RID: 184498
		[Token(Token = "0x402D0B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0402D0B3 RID: 184499
		[Token(Token = "0x402D0B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlClose;

		// Token: 0x0402D0B4 RID: 184500
		[Token(Token = "0x402D0B4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlNext;

		// Token: 0x0402D0B5 RID: 184501
		[Token(Token = "0x402D0B5")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0402D0B6 RID: 184502
		[Token(Token = "0x402D0B6")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_enterTween;

		// Token: 0x0402D0B7 RID: 184503
		[Token(Token = "0x402D0B7")]
		[FieldOffset(Offset = "0x70")]
		private FadeSwitchTween m_mainTransSwitch;

		// Token: 0x0402D0B8 RID: 184504
		[Token(Token = "0x402D0B8")]
		[FieldOffset(Offset = "0x78")]
		private RL03SubTransExpeditionReturnController.ExpeditionReturnModel m_cachedModel;

		// Token: 0x0402D0B9 RID: 184505
		[Token(Token = "0x402D0B9")]
		[FieldOffset(Offset = "0x80")]
		private bool m_waitForConfirm;

		// Token: 0x0402D0BA RID: 184506
		[Token(Token = "0x402D0BA")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isLast;

		// Token: 0x0402D0BC RID: 184508
		[Token(Token = "0x402D0BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onLastConfirmed;

		// Token: 0x0402D0BD RID: 184509
		[Token(Token = "0x402D0BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onLastConfirmed;

		// Token: 0x0402D0BE RID: 184510
		[Token(Token = "0x402D0BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D0BF RID: 184511
		[Token(Token = "0x402D0BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderSingle;

		// Token: 0x0402D0C0 RID: 184512
		[Token(Token = "0x402D0C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TransCoroutineSingle;

		// Token: 0x0402D0C1 RID: 184513
		[Token(Token = "0x402D0C1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D0C2 RID: 184514
		[Token(Token = "0x402D0C2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402D0C3 RID: 184515
		[Token(Token = "0x402D0C3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402D0C4 RID: 184516
		[Token(Token = "0x402D0C4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0402D0C5 RID: 184517
		[Token(Token = "0x402D0C5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x0402D0C6 RID: 184518
		[Token(Token = "0x402D0C6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
