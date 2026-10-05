using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DAE RID: 23982
	[Token(Token = "0x2005DAE")]
	public class ClimbTowerSweepEndingView : DataBinder<ClimbTowerSweepEndingProperty>
	{
		// Token: 0x06022C52 RID: 142418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C52")]
		[Address(RVA = "0x1D5A9A0", Offset = "0x1D595A0", VA = "0x181D5A9A0", Slot = "7")]
		public override void OnValueChanged(ClimbTowerSweepEndingProperty property)
		{
		}

		// Token: 0x06022C53 RID: 142419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C53")]
		[Address(RVA = "0x1D5B280", Offset = "0x1D59E80", VA = "0x181D5B280")]
		private void _PlayTween()
		{
		}

		// Token: 0x06022C54 RID: 142420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C54")]
		[Address(RVA = "0x1D5A8F0", Offset = "0x1D594F0", VA = "0x181D5A8F0")]
		public void OnCloseSweepEndingState()
		{
		}

		// Token: 0x06022C55 RID: 142421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C55")]
		[Address(RVA = "0x1D5B550", Offset = "0x1D5A150", VA = "0x181D5B550")]
		public ClimbTowerSweepEndingView()
		{
		}

		// Token: 0x0402FCC2 RID: 195778
		[Token(Token = "0x402FCC2")]
		private const string FLOOR_TARGET_FORMAT = "/{0}";

		// Token: 0x0402FCC3 RID: 195779
		[Token(Token = "0x402FCC3")]
		private const string ITEM_GAIN_COUNT_FORMAT = "+{0}";

		// Token: 0x0402FCC4 RID: 195780
		[Token(Token = "0x402FCC4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color ITEM_GAIN_TEXT_DEFAULT_COLOR;

		// Token: 0x0402FCC5 RID: 195781
		[Token(Token = "0x402FCC5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color ITEM_GAIN_TEXT_ZERO_COLOR;

		// Token: 0x0402FCC6 RID: 195782
		[Token(Token = "0x402FCC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textTowerName;

		// Token: 0x0402FCC7 RID: 195783
		[Token(Token = "0x402FCC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textTowerSubName;

		// Token: 0x0402FCC8 RID: 195784
		[Token(Token = "0x402FCC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textFinishTime;

		// Token: 0x0402FCC9 RID: 195785
		[Token(Token = "0x402FCC9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Tower info")]
		private Image _imgTowerIcon;

		// Token: 0x0402FCCA RID: 195786
		[Token(Token = "0x402FCCA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textFloorCurr;

		// Token: 0x0402FCCB RID: 195787
		[Token(Token = "0x402FCCB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textFloorTarget;

		// Token: 0x0402FCCC RID: 195788
		[Token(Token = "0x402FCCC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tower info")]
		private GameObject _imgHard;

		// Token: 0x0402FCCD RID: 195789
		[Token(Token = "0x402FCCD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tower info")]
		private Color _colorHard;

		// Token: 0x0402FCCE RID: 195790
		[Token(Token = "0x402FCCE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tower info")]
		private Color _colorNormal;

		// Token: 0x0402FCCF RID: 195791
		[Token(Token = "0x402FCCF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tower info")]
		private Color _colorTowerIconHard;

		// Token: 0x0402FCD0 RID: 195792
		[Token(Token = "0x402FCD0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Tower info")]
		private Color _colorTowerIconNormal;

		// Token: 0x0402FCD1 RID: 195793
		[Token(Token = "0x402FCD1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Items")]
		private Image _iconLowerItem;

		// Token: 0x0402FCD2 RID: 195794
		[Token(Token = "0x402FCD2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Items")]
		private Image _iconHigherItem;

		// Token: 0x0402FCD3 RID: 195795
		[Token(Token = "0x402FCD3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Items")]
		private Text _textLowerItemName;

		// Token: 0x0402FCD4 RID: 195796
		[Token(Token = "0x402FCD4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Items")]
		private Text _textHigherItemName;

		// Token: 0x0402FCD5 RID: 195797
		[Token(Token = "0x402FCD5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Items")]
		private UISingleValueChangeBar _barLowerItem;

		// Token: 0x0402FCD6 RID: 195798
		[Token(Token = "0x402FCD6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Items")]
		private UISingleValueChangeBar _barHigherItem;

		// Token: 0x0402FCD7 RID: 195799
		[Token(Token = "0x402FCD7")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Items")]
		private GameObject _iconLowerItemMax;

		// Token: 0x0402FCD8 RID: 195800
		[Token(Token = "0x402FCD8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Items")]
		private GameObject _iconHigherItemMax;

		// Token: 0x0402FCD9 RID: 195801
		[Token(Token = "0x402FCD9")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Items")]
		private Text _textLowerItemGain;

		// Token: 0x0402FCDA RID: 195802
		[Token(Token = "0x402FCDA")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Items")]
		private Text _textHigherItemGain;

		// Token: 0x0402FCDB RID: 195803
		[Token(Token = "0x402FCDB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Items")]
		private CanvasGroup _canvasLowerItemGain;

		// Token: 0x0402FCDC RID: 195804
		[Token(Token = "0x402FCDC")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Items")]
		private CanvasGroup _canvasHigherItemGain;

		// Token: 0x0402FCDD RID: 195805
		[Token(Token = "0x402FCDD")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isLowerItemMax;

		// Token: 0x0402FCDE RID: 195806
		[Token(Token = "0x402FCDE")]
		[FieldOffset(Offset = "0xF9")]
		private bool m_isHigherItemMax;

		// Token: 0x0402FCDF RID: 195807
		[Token(Token = "0x402FCDF")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402FCE0 RID: 195808
		[Token(Token = "0x402FCE0")]
		[FieldOffset(Offset = "0x110")]
		private bool m_animPlayed;

		// Token: 0x0402FCE1 RID: 195809
		[Token(Token = "0x402FCE1")]
		[FieldOffset(Offset = "0x118")]
		private Sequence m_sequence;

		// Token: 0x0402FCE2 RID: 195810
		[Token(Token = "0x402FCE2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402FCE3 RID: 195811
		[Token(Token = "0x402FCE3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayTween;

		// Token: 0x0402FCE4 RID: 195812
		[Token(Token = "0x402FCE4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCloseSweepEndingState;

		// Token: 0x0402FCE5 RID: 195813
		[Token(Token = "0x402FCE5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
