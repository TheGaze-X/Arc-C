using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200588D RID: 22669
	[Token(Token = "0x200588D")]
	public class RL03SubTransPredictView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602118C RID: 135564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602118C")]
		[Address(RVA = "0x1B60550", Offset = "0x1B5F150", VA = "0x181B60550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602118D RID: 135565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602118D")]
		[Address(RVA = "0x1B60210", Offset = "0x1B5EE10", VA = "0x181B60210")]
		public void Render(RL03SubTransPredictController.PredictModel predictModel)
		{
		}

		// Token: 0x0602118E RID: 135566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602118E")]
		[Address(RVA = "0x1B604A0", Offset = "0x1B5F0A0", VA = "0x181B604A0")]
		public IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x0602118F RID: 135567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602118F")]
		[Address(RVA = "0x1B60400", Offset = "0x1B5F000", VA = "0x181B60400")]
		public void Reset()
		{
		}

		// Token: 0x06021190 RID: 135568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021190")]
		[Address(RVA = "0x1B601A0", Offset = "0x1B5EDA0", VA = "0x181B601A0")]
		public void Hide()
		{
		}

		// Token: 0x06021191 RID: 135569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021191")]
		[Address(RVA = "0x1B60630", Offset = "0x1B5F230", VA = "0x181B60630")]
		public RL03SubTransPredictView()
		{
		}

		// Token: 0x0402D0EF RID: 184559
		[Token(Token = "0x402D0EF")]
		private const float HIDE_TWEEN_DURATION = 0.5f;

		// Token: 0x0402D0F0 RID: 184560
		[Token(Token = "0x402D0F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _panelMainTrans;

		// Token: 0x0402D0F1 RID: 184561
		[Token(Token = "0x402D0F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClickPlayer _clickAudio;

		// Token: 0x0402D0F2 RID: 184562
		[Token(Token = "0x402D0F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0402D0F3 RID: 184563
		[Token(Token = "0x402D0F3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RL03SubTransPredictView.TotemView _totemView;

		// Token: 0x0402D0F4 RID: 184564
		[Token(Token = "0x402D0F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL03SubTransPredictView.ChaosView _chaosView;

		// Token: 0x0402D0F5 RID: 184565
		[Token(Token = "0x402D0F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDescription;

		// Token: 0x0402D0F6 RID: 184566
		[Token(Token = "0x402D0F6")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0402D0F7 RID: 184567
		[Token(Token = "0x402D0F7")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_enterTween;

		// Token: 0x0402D0F8 RID: 184568
		[Token(Token = "0x402D0F8")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_mainTransSwitch;

		// Token: 0x0402D0F9 RID: 184569
		[Token(Token = "0x402D0F9")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isTotemPredict;

		// Token: 0x0402D0FA RID: 184570
		[Token(Token = "0x402D0FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D0FB RID: 184571
		[Token(Token = "0x402D0FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D0FC RID: 184572
		[Token(Token = "0x402D0FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402D0FD RID: 184573
		[Token(Token = "0x402D0FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402D0FE RID: 184574
		[Token(Token = "0x402D0FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0402D0FF RID: 184575
		[Token(Token = "0x402D0FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200588E RID: 22670
		[Token(Token = "0x200588E")]
		[Serializable]
		private class TotemView : IHotfixable
		{
			// Token: 0x06021193 RID: 135571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021193")]
			[Address(RVA = "0x1B6D7A0", Offset = "0x1B6C3A0", VA = "0x181B6D7A0")]
			public void Render(RL03SubTransPredictController.TotemModel totemModel)
			{
			}

			// Token: 0x06021194 RID: 135572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021194")]
			[Address(RVA = "0x1B6D9A0", Offset = "0x1B6C5A0", VA = "0x181B6D9A0")]
			public TotemView()
			{
			}

			// Token: 0x0402D100 RID: 184576
			[Token(Token = "0x402D100")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlTotem;

			// Token: 0x0402D101 RID: 184577
			[Token(Token = "0x402D101")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIAtlasImage _totemBack;

			// Token: 0x0402D102 RID: 184578
			[Token(Token = "0x402D102")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image _imgTotemIcon;

			// Token: 0x0402D103 RID: 184579
			[Token(Token = "0x402D103")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textTotemName;

			// Token: 0x0402D104 RID: 184580
			[Token(Token = "0x402D104")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textTotemDesc;

			// Token: 0x0402D105 RID: 184581
			[Token(Token = "0x402D105")]
			[FieldOffset(Offset = "0x38")]
			private UIPageFinder m_pageFinder;

			// Token: 0x0402D106 RID: 184582
			[Token(Token = "0x402D106")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402D107 RID: 184583
			[Token(Token = "0x402D107")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200588F RID: 22671
		[Token(Token = "0x200588F")]
		[Serializable]
		private class ChaosView : IHotfixable
		{
			// Token: 0x06021195 RID: 135573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021195")]
			[Address(RVA = "0x1B5BB50", Offset = "0x1B5A750", VA = "0x181B5BB50")]
			public void Render(string topicId, RL03SubTransPredictController.ChaosModel chaosViewModel)
			{
			}

			// Token: 0x06021196 RID: 135574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021196")]
			[Address(RVA = "0x1B5BDA0", Offset = "0x1B5A9A0", VA = "0x181B5BDA0")]
			public ChaosView()
			{
			}

			// Token: 0x0402D108 RID: 184584
			[Token(Token = "0x402D108")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlChaos;

			// Token: 0x0402D109 RID: 184585
			[Token(Token = "0x402D109")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Image _imgChaosIcon;

			// Token: 0x0402D10A RID: 184586
			[Token(Token = "0x402D10A")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UIAtlasImage _imgChaosLevel1;

			// Token: 0x0402D10B RID: 184587
			[Token(Token = "0x402D10B")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private UIAtlasImage _imgChaosLevel2;

			// Token: 0x0402D10C RID: 184588
			[Token(Token = "0x402D10C")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textChaosName;

			// Token: 0x0402D10D RID: 184589
			[Token(Token = "0x402D10D")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _textChaosDesc;

			// Token: 0x0402D10E RID: 184590
			[Token(Token = "0x402D10E")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Color _colorLight;

			// Token: 0x0402D10F RID: 184591
			[Token(Token = "0x402D10F")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private Color _colorDark;

			// Token: 0x0402D110 RID: 184592
			[Token(Token = "0x402D110")]
			[FieldOffset(Offset = "0x60")]
			private UIPageFinder m_pageFinder;

			// Token: 0x0402D111 RID: 184593
			[Token(Token = "0x402D111")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402D112 RID: 184594
			[Token(Token = "0x402D112")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
