using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005642 RID: 22082
	[Token(Token = "0x2005642")]
	public class RL05MainTransitionView : RoguelikeMainTransController
	{
		// Token: 0x0602064A RID: 132682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602064A")]
		[Address(RVA = "0x1A7D9E0", Offset = "0x1A7C5E0", VA = "0x181A7D9E0", Slot = "4")]
		public override void Render(RoguelikeDungeonZoneViewProperty property)
		{
		}

		// Token: 0x0602064B RID: 132683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602064B")]
		[Address(RVA = "0x1A7DE10", Offset = "0x1A7CA10", VA = "0x181A7DE10")]
		private void _RenderMainTrans(RL05MainTransitionView.TransitionParam transitionParam)
		{
		}

		// Token: 0x0602064C RID: 132684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602064C")]
		[Address(RVA = "0x1A7DB60", Offset = "0x1A7C760", VA = "0x181A7DB60", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x0602064D RID: 132685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602064D")]
		[Address(RVA = "0x1A7DC30", Offset = "0x1A7C830", VA = "0x181A7DC30", Slot = "6")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x0602064E RID: 132686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602064E")]
		[Address(RVA = "0x1A7E0D0", Offset = "0x1A7CCD0", VA = "0x181A7E0D0")]
		private IEnumerator _WaitForNextClick()
		{
			return null;
		}

		// Token: 0x0602064F RID: 132687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602064F")]
		[Address(RVA = "0x1A7DD20", Offset = "0x1A7C920", VA = "0x181A7DD20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020650 RID: 132688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020650")]
		[Address(RVA = "0x1A7D980", Offset = "0x1A7C580", VA = "0x181A7D980")]
		public void EventOnMainPanelClicked()
		{
		}

		// Token: 0x06020651 RID: 132689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020651")]
		[Address(RVA = "0x1A7E180", Offset = "0x1A7CD80", VA = "0x181A7E180")]
		public RL05MainTransitionView()
		{
		}

		// Token: 0x0402BDA6 RID: 179622
		[Token(Token = "0x402BDA6")]
		private const float AUTO_MAIN_TRANS_DUR = 1.5f;

		// Token: 0x0402BDA7 RID: 179623
		[Token(Token = "0x402BDA7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelMainTrans;

		// Token: 0x0402BDA8 RID: 179624
		[Token(Token = "0x402BDA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x0402BDA9 RID: 179625
		[Token(Token = "0x402BDA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _labelImg;

		// Token: 0x0402BDAA RID: 179626
		[Token(Token = "0x402BDAA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _leftScope;

		// Token: 0x0402BDAB RID: 179627
		[Token(Token = "0x402BDAB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _rightScope;

		// Token: 0x0402BDAC RID: 179628
		[Token(Token = "0x402BDAC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _zoneName;

		// Token: 0x0402BDAD RID: 179629
		[Token(Token = "0x402BDAD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _zoneInfo;

		// Token: 0x0402BDAE RID: 179630
		[Token(Token = "0x402BDAE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _wrathInfo;

		// Token: 0x0402BDAF RID: 179631
		[Token(Token = "0x402BDAF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _wrathIcon;

		// Token: 0x0402BDB0 RID: 179632
		[Token(Token = "0x402BDB0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _hiddenWrathBg;

		// Token: 0x0402BDB1 RID: 179633
		[Token(Token = "0x402BDB1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _normalWrathBg;

		// Token: 0x0402BDB2 RID: 179634
		[Token(Token = "0x402BDB2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnimLocation;

		// Token: 0x0402BDB3 RID: 179635
		[Token(Token = "0x402BDB3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _wrathShowAnimLocation;

		// Token: 0x0402BDB4 RID: 179636
		[Token(Token = "0x402BDB4")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_mainTransSwitch;

		// Token: 0x0402BDB5 RID: 179637
		[Token(Token = "0x402BDB5")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0402BDB6 RID: 179638
		[Token(Token = "0x402BDB6")]
		[FieldOffset(Offset = "0xA8")]
		private RL05MainTransitionView.TransitionParam m_cachedTransitionParam;

		// Token: 0x0402BDB7 RID: 179639
		[Token(Token = "0x402BDB7")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_enterTween;

		// Token: 0x0402BDB8 RID: 179640
		[Token(Token = "0x402BDB8")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_wrathTween;

		// Token: 0x0402BDB9 RID: 179641
		[Token(Token = "0x402BDB9")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_waitForNextClick;

		// Token: 0x0402BDBA RID: 179642
		[Token(Token = "0x402BDBA")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BDBB RID: 179643
		[Token(Token = "0x402BDBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BDBC RID: 179644
		[Token(Token = "0x402BDBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderMainTrans;

		// Token: 0x0402BDBD RID: 179645
		[Token(Token = "0x402BDBD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402BDBE RID: 179646
		[Token(Token = "0x402BDBE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402BDBF RID: 179647
		[Token(Token = "0x402BDBF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__WaitForNextClick;

		// Token: 0x0402BDC0 RID: 179648
		[Token(Token = "0x402BDC0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BDC1 RID: 179649
		[Token(Token = "0x402BDC1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnMainPanelClicked;

		// Token: 0x0402BDC2 RID: 179650
		[Token(Token = "0x402BDC2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005643 RID: 22083
		[Token(Token = "0x2005643")]
		private class WrathParam : IHotfixable
		{
			// Token: 0x06020654 RID: 132692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020654")]
			[Address(RVA = "0x1A8ABC0", Offset = "0x1A897C0", VA = "0x181A8ABC0")]
			public void LoadData(string topicId)
			{
			}

			// Token: 0x06020655 RID: 132693 RVA: 0x000B5B90 File Offset: 0x000B3D90
			[Token(Token = "0x6020655")]
			[Address(RVA = "0x1A8AB60", Offset = "0x1A89760", VA = "0x181A8AB60")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06020656 RID: 132694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020656")]
			[Address(RVA = "0x1A8AE70", Offset = "0x1A89A70", VA = "0x181A8AE70")]
			public WrathParam()
			{
			}

			// Token: 0x0402BDC3 RID: 179651
			[Token(Token = "0x402BDC3")]
			[FieldOffset(Offset = "0x10")]
			public string newWrathId;

			// Token: 0x0402BDC4 RID: 179652
			[Token(Token = "0x402BDC4")]
			[FieldOffset(Offset = "0x18")]
			public string newWrathGroupId;

			// Token: 0x0402BDC5 RID: 179653
			[Token(Token = "0x402BDC5")]
			[FieldOffset(Offset = "0x20")]
			public string newWrathInfo;

			// Token: 0x0402BDC6 RID: 179654
			[Token(Token = "0x402BDC6")]
			[FieldOffset(Offset = "0x28")]
			public bool isHidden;

			// Token: 0x0402BDC7 RID: 179655
			[Token(Token = "0x402BDC7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402BDC8 RID: 179656
			[Token(Token = "0x402BDC8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x0402BDC9 RID: 179657
			[Token(Token = "0x402BDC9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005644 RID: 22084
		[Token(Token = "0x2005644")]
		private class TransitionParam : IHotfixable
		{
			// Token: 0x06020657 RID: 132695 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020657")]
			[Address(RVA = "0x1A89900", Offset = "0x1A88500", VA = "0x181A89900")]
			public static RL05MainTransitionView.TransitionParam Create(RoguelikeDungeonZoneViewModel zoneModel)
			{
				return null;
			}

			// Token: 0x06020658 RID: 132696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020658")]
			[Address(RVA = "0x1A89BB0", Offset = "0x1A887B0", VA = "0x181A89BB0")]
			public TransitionParam()
			{
			}

			// Token: 0x0402BDCA RID: 179658
			[Token(Token = "0x402BDCA")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402BDCB RID: 179659
			[Token(Token = "0x402BDCB")]
			[FieldOffset(Offset = "0x18")]
			public bool isAutoTrans;

			// Token: 0x0402BDCC RID: 179660
			[Token(Token = "0x402BDCC")]
			[FieldOffset(Offset = "0x19")]
			public bool isManualTrans;

			// Token: 0x0402BDCD RID: 179661
			[Token(Token = "0x402BDCD")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeGameZoneData zoneData;

			// Token: 0x0402BDCE RID: 179662
			[Token(Token = "0x402BDCE")]
			[FieldOffset(Offset = "0x28")]
			public RL05MainTransitionView.WrathParam wrathParam;

			// Token: 0x0402BDCF RID: 179663
			[Token(Token = "0x402BDCF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x0402BDD0 RID: 179664
			[Token(Token = "0x402BDD0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
