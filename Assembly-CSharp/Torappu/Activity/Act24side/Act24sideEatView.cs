using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007582 RID: 30082
	[Token(Token = "0x2007582")]
	public class Act24sideEatView : DataBinder<Act24sideEatProperty>, ITimeWatcher
	{
		// Token: 0x0602A5A8 RID: 173480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5A8")]
		[Address(RVA = "0x26003A0", Offset = "0x25FEFA0", VA = "0x1826003A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A5A9 RID: 173481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5A9")]
		[Address(RVA = "0x2600680", Offset = "0x25FF280", VA = "0x182600680")]
		private void _UpdateCountdownText()
		{
		}

		// Token: 0x0602A5AA RID: 173482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5AA")]
		[Address(RVA = "0x26002D0", Offset = "0x25FEED0", VA = "0x1826002D0")]
		private void Start()
		{
		}

		// Token: 0x0602A5AB RID: 173483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5AB")]
		[Address(RVA = "0x25FFF70", Offset = "0x25FEB70", VA = "0x1825FFF70")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602A5AC RID: 173484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5AC")]
		[Address(RVA = "0x25FFFD0", Offset = "0x25FEBD0", VA = "0x1825FFFD0", Slot = "7")]
		public override void OnValueChanged(Act24sideEatProperty property)
		{
		}

		// Token: 0x0602A5AD RID: 173485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5AD")]
		[Address(RVA = "0x2600330", Offset = "0x25FEF30", VA = "0x182600330", Slot = "8")]
		public void UpdateTime(float timeDelta)
		{
		}

		// Token: 0x0602A5AE RID: 173486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5AE")]
		[Address(RVA = "0x25FFED0", Offset = "0x25FEAD0", VA = "0x1825FFED0")]
		public void OnBtnConfirmClicked()
		{
		}

		// Token: 0x0602A5AF RID: 173487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5AF")]
		[Address(RVA = "0x26008C0", Offset = "0x25FF4C0", VA = "0x1826008C0")]
		public Act24sideEatView()
		{
		}

		// Token: 0x0403CE96 RID: 249494
		[Token(Token = "0x403CE96")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animPanelSwitch;

		// Token: 0x0403CE97 RID: 249495
		[Token(Token = "0x403CE97")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform[] _mealItemHolders;

		// Token: 0x0403CE98 RID: 249496
		[Token(Token = "0x403CE98")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act24sideEatMealItem _prefabMealItem;

		// Token: 0x0403CE99 RID: 249497
		[Token(Token = "0x403CE99")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act24sideEatView.WelcomePanel _pnlWelcome;

		// Token: 0x0403CE9A RID: 249498
		[Token(Token = "0x403CE9A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act24sideEatView.DetailPanel _pnlDetail;

		// Token: 0x0403CE9B RID: 249499
		[Token(Token = "0x403CE9B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasTips;

		// Token: 0x0403CE9C RID: 249500
		[Token(Token = "0x403CE9C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textTips;

		// Token: 0x0403CE9D RID: 249501
		[Token(Token = "0x403CE9D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _canvasTipsSwitchDuration;

		// Token: 0x0403CE9E RID: 249502
		[Token(Token = "0x403CE9E")]
		[FieldOffset(Offset = "0x64")]
		private bool m_inited;

		// Token: 0x0403CE9F RID: 249503
		[Token(Token = "0x403CE9F")]
		[FieldOffset(Offset = "0x68")]
		private UISwitchTween m_panelSwitchTween;

		// Token: 0x0403CEA0 RID: 249504
		[Token(Token = "0x403CEA0")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_panelTipSwitchTween;

		// Token: 0x0403CEA1 RID: 249505
		[Token(Token = "0x403CEA1")]
		[FieldOffset(Offset = "0x78")]
		private List<Act24sideEatMealItem> m_mealItems;

		// Token: 0x0403CEA2 RID: 249506
		[Token(Token = "0x403CEA2")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedSequenceNum;

		// Token: 0x0403CEA3 RID: 249507
		[Token(Token = "0x403CEA3")]
		[FieldOffset(Offset = "0x88")]
		private long m_cachedNextRefreshTs;

		// Token: 0x0403CEA4 RID: 249508
		[Token(Token = "0x403CEA4")]
		[FieldOffset(Offset = "0x90")]
		private bool m_cachedShowNextRefreshTs;

		// Token: 0x0403CEA5 RID: 249509
		[Token(Token = "0x403CEA5")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_finder;

		// Token: 0x0403CEA6 RID: 249510
		[Token(Token = "0x403CEA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CEA7 RID: 249511
		[Token(Token = "0x403CEA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateCountdownText;

		// Token: 0x0403CEA8 RID: 249512
		[Token(Token = "0x403CEA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403CEA9 RID: 249513
		[Token(Token = "0x403CEA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403CEAA RID: 249514
		[Token(Token = "0x403CEAA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403CEAB RID: 249515
		[Token(Token = "0x403CEAB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0403CEAC RID: 249516
		[Token(Token = "0x403CEAC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnConfirmClicked;

		// Token: 0x0403CEAD RID: 249517
		[Token(Token = "0x403CEAD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007583 RID: 30083
		[Token(Token = "0x2007583")]
		[Serializable]
		private class DetailPanel : IHotfixable
		{
			// Token: 0x0602A5B0 RID: 173488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5B0")]
			[Address(RVA = "0x2603190", Offset = "0x2601D90", VA = "0x182603190")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0602A5B1 RID: 173489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5B1")]
			[Address(RVA = "0x26034C0", Offset = "0x26020C0", VA = "0x1826034C0")]
			private void _PlayLoopTween(bool show)
			{
			}

			// Token: 0x0602A5B2 RID: 173490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5B2")]
			[Address(RVA = "0x2602BE0", Offset = "0x26017E0", VA = "0x182602BE0")]
			public void Render(Act24sideEatViewModel viewModel, bool isInit)
			{
			}

			// Token: 0x0602A5B3 RID: 173491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5B3")]
			[Address(RVA = "0x2603620", Offset = "0x2602220", VA = "0x182603620")]
			public DetailPanel()
			{
			}

			// Token: 0x0403CEAE RID: 249518
			[Token(Token = "0x403CEAE")]
			private const string FORMAT_PLUS_AP = "+{0}";

			// Token: 0x0403CEAF RID: 249519
			[Token(Token = "0x403CEAF")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private RectTransform _pnlRoot;

			// Token: 0x0403CEB0 RID: 249520
			[Token(Token = "0x403CEB0")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Image _imgMealName;

			// Token: 0x0403CEB1 RID: 249521
			[Token(Token = "0x403CEB1")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textApNum;

			// Token: 0x0403CEB2 RID: 249522
			[Token(Token = "0x403CEB2")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image _imgItemUp;

			// Token: 0x0403CEB3 RID: 249523
			[Token(Token = "0x403CEB3")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textEffect;

			// Token: 0x0403CEB4 RID: 249524
			[Token(Token = "0x403CEB4")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _textDesc;

			// Token: 0x0403CEB5 RID: 249525
			[Token(Token = "0x403CEB5")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Text _textCost;

			// Token: 0x0403CEB6 RID: 249526
			[Token(Token = "0x403CEB6")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private GameObject _pnlEat;

			// Token: 0x0403CEB7 RID: 249527
			[Token(Token = "0x403CEB7")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private GameObject _pnlEaten;

			// Token: 0x0403CEB8 RID: 249528
			[Token(Token = "0x403CEB8")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private Image _imgMeal;

			// Token: 0x0403CEB9 RID: 249529
			[Token(Token = "0x403CEB9")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private UIAnimationLocation _animEat;

			// Token: 0x0403CEBA RID: 249530
			[Token(Token = "0x403CEBA")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			private UIAnimationLocation _animLoop;

			// Token: 0x0403CEBB RID: 249531
			[Token(Token = "0x403CEBB")]
			[FieldOffset(Offset = "0x80")]
			[SerializeField]
			private RectTransform _transCircle;

			// Token: 0x0403CEBC RID: 249532
			[Token(Token = "0x403CEBC")]
			[FieldOffset(Offset = "0x88")]
			[SerializeField]
			private float _circleTweenDuration;

			// Token: 0x0403CEBD RID: 249533
			[Token(Token = "0x403CEBD")]
			[FieldOffset(Offset = "0x8C")]
			[SerializeField]
			private Color _colorCostNormal;

			// Token: 0x0403CEBE RID: 249534
			[Token(Token = "0x403CEBE")]
			[FieldOffset(Offset = "0x9C")]
			[SerializeField]
			private Color _colorCostLack;

			// Token: 0x0403CEBF RID: 249535
			[Token(Token = "0x403CEBF")]
			[FieldOffset(Offset = "0xB0")]
			private UIStateFinder m_finder;

			// Token: 0x0403CEC0 RID: 249536
			[Token(Token = "0x403CEC0")]
			[FieldOffset(Offset = "0xC0")]
			private bool m_inited;

			// Token: 0x0403CEC1 RID: 249537
			[Token(Token = "0x403CEC1")]
			[FieldOffset(Offset = "0xC8")]
			private UISwitchTween m_eatSwitchTween;

			// Token: 0x0403CEC2 RID: 249538
			[Token(Token = "0x403CEC2")]
			[FieldOffset(Offset = "0xD0")]
			private Tween m_loopTween;

			// Token: 0x0403CEC3 RID: 249539
			[Token(Token = "0x403CEC3")]
			[FieldOffset(Offset = "0xD8")]
			private Tween m_circleTween;

			// Token: 0x0403CEC4 RID: 249540
			[Token(Token = "0x403CEC4")]
			[FieldOffset(Offset = "0xE0")]
			private bool m_loopTweenPlaying;

			// Token: 0x0403CEC5 RID: 249541
			[Token(Token = "0x403CEC5")]
			[FieldOffset(Offset = "0xE1")]
			private bool m_cachedEaten;

			// Token: 0x0403CEC6 RID: 249542
			[Token(Token = "0x403CEC6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x0403CEC7 RID: 249543
			[Token(Token = "0x403CEC7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__PlayLoopTween;

			// Token: 0x0403CEC8 RID: 249544
			[Token(Token = "0x403CEC8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403CEC9 RID: 249545
			[Token(Token = "0x403CEC9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007584 RID: 30084
		[Token(Token = "0x2007584")]
		[Serializable]
		private class WelcomePanel : IHotfixable
		{
			// Token: 0x0602A5B4 RID: 173492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5B4")]
			[Address(RVA = "0x2606D90", Offset = "0x2605990", VA = "0x182606D90")]
			public void Render(Act24sideEatViewModel viewModel, bool isInit)
			{
			}

			// Token: 0x0602A5B5 RID: 173493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5B5")]
			[Address(RVA = "0x2606F90", Offset = "0x2605B90", VA = "0x182606F90")]
			public WelcomePanel()
			{
			}

			// Token: 0x0403CECA RID: 249546
			[Token(Token = "0x403CECA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlNormal;

			// Token: 0x0403CECB RID: 249547
			[Token(Token = "0x403CECB")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _pnlEaten;

			// Token: 0x0403CECC RID: 249548
			[Token(Token = "0x403CECC")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UIAtlasImage _imgBubble;

			// Token: 0x0403CECD RID: 249549
			[Token(Token = "0x403CECD")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private UIAtlasObject _atlasObject;

			// Token: 0x0403CECE RID: 249550
			[Token(Token = "0x403CECE")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private string[] _imgBubbleNames;

			// Token: 0x0403CECF RID: 249551
			[Token(Token = "0x403CECF")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _textMealUsed;

			// Token: 0x0403CED0 RID: 249552
			[Token(Token = "0x403CED0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403CED1 RID: 249553
			[Token(Token = "0x403CED1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
