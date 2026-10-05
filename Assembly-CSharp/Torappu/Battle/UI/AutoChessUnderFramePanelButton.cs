using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032B1 RID: 12977
	[Token(Token = "0x20032B1")]
	public class AutoChessUnderFramePanelButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x060149EB RID: 84459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149EB")]
		[Address(RVA = "0xCDD560", Offset = "0xCDC160", VA = "0x180CDD560")]
		public void Render(AutoChessUnderFramePanelButton.Param param)
		{
		}

		// Token: 0x060149EC RID: 84460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149EC")]
		[Address(RVA = "0xCDD3B0", Offset = "0xCDBFB0", VA = "0x180CDD3B0")]
		public void Hide()
		{
		}

		// Token: 0x060149ED RID: 84461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149ED")]
		[Address(RVA = "0xCDD410", Offset = "0xCDC010", VA = "0x180CDD410")]
		private void InitIfNot()
		{
		}

		// Token: 0x060149EE RID: 84462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149EE")]
		[Address(RVA = "0xCDD4F0", Offset = "0xCDC0F0", VA = "0x180CDD4F0")]
		public void OnClick()
		{
		}

		// Token: 0x060149EF RID: 84463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149EF")]
		[Address(RVA = "0xCDD900", Offset = "0xCDC500", VA = "0x180CDD900")]
		private void _RenderCoin(AutoChessUnderFramePanelButton.Param param)
		{
		}

		// Token: 0x060149F0 RID: 84464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149F0")]
		[Address(RVA = "0xCDDB80", Offset = "0xCDC780", VA = "0x180CDDB80")]
		public AutoChessUnderFramePanelButton()
		{
		}

		// Token: 0x040186B6 RID: 100022
		[Token(Token = "0x40186B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AutoChessUnderFramePanelButton.DisplayTypeSetting[] _settings;

		// Token: 0x040186B7 RID: 100023
		[Token(Token = "0x40186B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessUnderFramePanelButton.LiteTextIconPairSetting[] _liteSettings;

		// Token: 0x040186B8 RID: 100024
		[Token(Token = "0x40186B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _btnText;

		// Token: 0x040186B9 RID: 100025
		[Token(Token = "0x40186B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040186BA RID: 100026
		[Token(Token = "0x40186BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _coinText;

		// Token: 0x040186BB RID: 100027
		[Token(Token = "0x40186BB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _displayBg;

		// Token: 0x040186BC RID: 100028
		[Token(Token = "0x40186BC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _coinBg;

		// Token: 0x040186BD RID: 100029
		[Token(Token = "0x40186BD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _coinRoot;

		// Token: 0x040186BE RID: 100030
		[Token(Token = "0x40186BE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite _defaultIconBg;

		// Token: 0x040186BF RID: 100031
		[Token(Token = "0x40186BF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _defaultIconColor;

		// Token: 0x040186C0 RID: 100032
		[Token(Token = "0x40186C0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _defaultTextColor;

		// Token: 0x040186C1 RID: 100033
		[Token(Token = "0x40186C1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _defaultPriceTextColor;

		// Token: 0x040186C2 RID: 100034
		[Token(Token = "0x40186C2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _button;

		// Token: 0x040186C3 RID: 100035
		[Token(Token = "0x40186C3")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x040186C4 RID: 100036
		[Token(Token = "0x40186C4")]
		[FieldOffset(Offset = "0x99")]
		private bool m_isShowed;

		// Token: 0x040186C5 RID: 100037
		[Token(Token = "0x40186C5")]
		[FieldOffset(Offset = "0xA0")]
		private ListDict<AutoChessUnderFramePanelButton.DisplayType, AutoChessUnderFramePanelButton.DisplayTypeSetting> m_displayTypeSettings;

		// Token: 0x040186C6 RID: 100038
		[Token(Token = "0x40186C6")]
		[FieldOffset(Offset = "0xA8")]
		private AutoChessUnderFramePanelButton.Param m_param;

		// Token: 0x040186C7 RID: 100039
		[Token(Token = "0x40186C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040186C8 RID: 100040
		[Token(Token = "0x40186C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040186C9 RID: 100041
		[Token(Token = "0x40186C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x040186CA RID: 100042
		[Token(Token = "0x40186CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040186CB RID: 100043
		[Token(Token = "0x40186CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderCoin;

		// Token: 0x040186CC RID: 100044
		[Token(Token = "0x40186CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032B2 RID: 12978
		[Token(Token = "0x20032B2")]
		public enum DisplayType
		{
			// Token: 0x040186CE RID: 100046
			[Token(Token = "0x40186CE")]
			SELL,
			// Token: 0x040186CF RID: 100047
			[Token(Token = "0x40186CF")]
			DESTROY
		}

		// Token: 0x020032B3 RID: 12979
		[Token(Token = "0x20032B3")]
		public struct Param
		{
			// Token: 0x040186D0 RID: 100048
			[Token(Token = "0x40186D0")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessUnderFramePanelButton.DisplayType displayType;

			// Token: 0x040186D1 RID: 100049
			[Token(Token = "0x40186D1")]
			[FieldOffset(Offset = "0x8")]
			public string btnText;

			// Token: 0x040186D2 RID: 100050
			[Token(Token = "0x40186D2")]
			[FieldOffset(Offset = "0x10")]
			public bool displayCoin;

			// Token: 0x040186D3 RID: 100051
			[Token(Token = "0x40186D3")]
			[FieldOffset(Offset = "0x11")]
			public bool displayCoinAdd;

			// Token: 0x040186D4 RID: 100052
			[Token(Token = "0x40186D4")]
			[FieldOffset(Offset = "0x14")]
			public int coinValue;

			// Token: 0x040186D5 RID: 100053
			[Token(Token = "0x40186D5")]
			[FieldOffset(Offset = "0x18")]
			public Action onClick;

			// Token: 0x040186D6 RID: 100054
			[Token(Token = "0x40186D6")]
			[FieldOffset(Offset = "0x20")]
			public Transform mountPoint;

			// Token: 0x040186D7 RID: 100055
			[Token(Token = "0x40186D7")]
			[FieldOffset(Offset = "0x28")]
			public Canvas canvas;
		}

		// Token: 0x020032B4 RID: 12980
		[Token(Token = "0x20032B4")]
		[Serializable]
		public class DisplayTypeSetting
		{
			// Token: 0x060149F1 RID: 84465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60149F1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DisplayTypeSetting()
			{
			}

			// Token: 0x040186D8 RID: 100056
			[Token(Token = "0x40186D8")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessUnderFramePanelButton.DisplayType displayType;

			// Token: 0x040186D9 RID: 100057
			[Token(Token = "0x40186D9")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x040186DA RID: 100058
			[Token(Token = "0x40186DA")]
			[FieldOffset(Offset = "0x20")]
			public Sprite bg;
		}

		// Token: 0x020032B5 RID: 12981
		[Token(Token = "0x20032B5")]
		[Serializable]
		public class LiteTextIconPairSetting
		{
			// Token: 0x060149F2 RID: 84466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60149F2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LiteTextIconPairSetting()
			{
			}

			// Token: 0x040186DB RID: 100059
			[Token(Token = "0x40186DB")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 textPos;
		}
	}
}
