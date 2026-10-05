using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047F6 RID: 18422
	[Token(Token = "0x20047F6")]
	public class MonopolyCardPanelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BDCC RID: 114124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDCC")]
		[Address(RVA = "0x1538820", Offset = "0x1537420", VA = "0x181538820")]
		public void Render(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BDCD RID: 114125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDCD")]
		[Address(RVA = "0x1538C80", Offset = "0x1537880", VA = "0x181538C80")]
		private void _RenderCardImmediatly(MonopolyCardPanelModel model, bool isFastMode)
		{
		}

		// Token: 0x0601BDCE RID: 114126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDCE")]
		[Address(RVA = "0x1538EF0", Offset = "0x1537AF0", VA = "0x181538EF0")]
		private void _RenderCardWithTween(MonopolyCardPanelModel model)
		{
		}

		// Token: 0x0601BDCF RID: 114127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDCF")]
		[Address(RVA = "0x1538BC0", Offset = "0x15377C0", VA = "0x181538BC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BDD0 RID: 114128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDD0")]
		[Address(RVA = "0x1538550", Offset = "0x1537150", VA = "0x181538550")]
		public void EventOnMoveBtnClick()
		{
		}

		// Token: 0x0601BDD1 RID: 114129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDD1")]
		[Address(RVA = "0x15384C0", Offset = "0x15370C0", VA = "0x1815384C0")]
		public void EventOnMiningBtnClick()
		{
		}

		// Token: 0x0601BDD2 RID: 114130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDD2")]
		[Address(RVA = "0x1538430", Offset = "0x1537030", VA = "0x181538430")]
		public void EventOnEndRoundBtnClick()
		{
		}

		// Token: 0x0601BDD3 RID: 114131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDD3")]
		[Address(RVA = "0x15386C0", Offset = "0x15372C0", VA = "0x1815386C0")]
		public void EventOnNotifyCannotMove()
		{
		}

		// Token: 0x0601BDD4 RID: 114132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDD4")]
		[Address(RVA = "0x15385E0", Offset = "0x15371E0", VA = "0x1815385E0")]
		public void EventOnNotifyCannotMining()
		{
		}

		// Token: 0x0601BDD5 RID: 114133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDD5")]
		[Address(RVA = "0x1538750", Offset = "0x1537350", VA = "0x181538750")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0601BDD6 RID: 114134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDD6")]
		[Address(RVA = "0x15391E0", Offset = "0x1537DE0", VA = "0x1815391E0")]
		public MonopolyCardPanelView()
		{
		}

		// Token: 0x04024478 RID: 148600
		[Token(Token = "0x4024478")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MonopolyCardItemView _cardPrefab;

		// Token: 0x04024479 RID: 148601
		[Token(Token = "0x4024479")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardParent;

		// Token: 0x0402447A RID: 148602
		[Token(Token = "0x402447A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _cardFadeInInterval;

		// Token: 0x0402447B RID: 148603
		[Token(Token = "0x402447B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _moveBtn;

		// Token: 0x0402447C RID: 148604
		[Token(Token = "0x402447C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cannotMoveToastTriggerGo;

		// Token: 0x0402447D RID: 148605
		[Token(Token = "0x402447D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _miningBtn;

		// Token: 0x0402447E RID: 148606
		[Token(Token = "0x402447E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _cannotMiningToastTriggerGo;

		// Token: 0x0402447F RID: 148607
		[Token(Token = "0x402447F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _currRound;

		// Token: 0x04024480 RID: 148608
		[Token(Token = "0x4024480")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _maxRound;

		// Token: 0x04024481 RID: 148609
		[Token(Token = "0x4024481")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _miningComboHintGo;

		// Token: 0x04024482 RID: 148610
		[Token(Token = "0x4024482")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoStateToggle _endRoundBtnToggle;

		// Token: 0x04024483 RID: 148611
		[Token(Token = "0x4024483")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TwoStateFadeSwitcher _cardListToggle;

		// Token: 0x04024484 RID: 148612
		[Token(Token = "0x4024484")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _cardPanelTutorialGo;

		// Token: 0x04024485 RID: 148613
		[Token(Token = "0x4024485")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _roundPanelTutorialGo;

		// Token: 0x04024486 RID: 148614
		[Token(Token = "0x4024486")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Font _kjeragDigitFont;

		// Token: 0x04024487 RID: 148615
		[Token(Token = "0x4024487")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text[] _textUseKjeragFont;

		// Token: 0x04024488 RID: 148616
		[Token(Token = "0x4024488")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04024489 RID: 148617
		[Token(Token = "0x4024489")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cacheEnterSeqNum;

		// Token: 0x0402448A RID: 148618
		[Token(Token = "0x402448A")]
		[FieldOffset(Offset = "0xB0")]
		private List<MonopolyCardItemView> m_createdCardItemList;

		// Token: 0x0402448B RID: 148619
		[Token(Token = "0x402448B")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_tween;

		// Token: 0x0402448C RID: 148620
		[Token(Token = "0x402448C")]
		[FieldOffset(Offset = "0xC0")]
		private int m_gameActSeqNum;

		// Token: 0x0402448D RID: 148621
		[Token(Token = "0x402448D")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_cacheCanMove;

		// Token: 0x0402448E RID: 148622
		[Token(Token = "0x402448E")]
		[FieldOffset(Offset = "0xC5")]
		private bool m_cacheCanMining;

		// Token: 0x0402448F RID: 148623
		[Token(Token = "0x402448F")]
		[FieldOffset(Offset = "0xC6")]
		private bool m_hasInited;

		// Token: 0x04024490 RID: 148624
		[Token(Token = "0x4024490")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024491 RID: 148625
		[Token(Token = "0x4024491")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCardImmediatly;

		// Token: 0x04024492 RID: 148626
		[Token(Token = "0x4024492")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCardWithTween;

		// Token: 0x04024493 RID: 148627
		[Token(Token = "0x4024493")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024494 RID: 148628
		[Token(Token = "0x4024494")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnMoveBtnClick;

		// Token: 0x04024495 RID: 148629
		[Token(Token = "0x4024495")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnMiningBtnClick;

		// Token: 0x04024496 RID: 148630
		[Token(Token = "0x4024496")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnEndRoundBtnClick;

		// Token: 0x04024497 RID: 148631
		[Token(Token = "0x4024497")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnNotifyCannotMove;

		// Token: 0x04024498 RID: 148632
		[Token(Token = "0x4024498")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnNotifyCannotMining;

		// Token: 0x04024499 RID: 148633
		[Token(Token = "0x4024499")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x0402449A RID: 148634
		[Token(Token = "0x402449A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
