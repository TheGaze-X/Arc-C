using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004103 RID: 16643
	[Token(Token = "0x2004103")]
	public class SandboxV2AdminShopItemDetailView : DataBinder<SandboxV2AdminShopItemDetailProperty>, IHotfixable
	{
		// Token: 0x06019BCB RID: 105419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BCB")]
		[Address(RVA = "0x1293230", Offset = "0x1291E30", VA = "0x181293230", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminShopItemDetailProperty property)
		{
		}

		// Token: 0x06019BCC RID: 105420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BCC")]
		[Address(RVA = "0x12931A0", Offset = "0x1291DA0", VA = "0x1812931A0")]
		public void OnBuyBtnClicked()
		{
		}

		// Token: 0x06019BCD RID: 105421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BCD")]
		[Address(RVA = "0x1293C80", Offset = "0x1292880", VA = "0x181293C80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019BCE RID: 105422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BCE")]
		[Address(RVA = "0x1293FD0", Offset = "0x1292BD0", VA = "0x181293FD0")]
		private void _OnIncreaseBtnClicked()
		{
		}

		// Token: 0x06019BCF RID: 105423 RVA: 0x0009F3F0 File Offset: 0x0009D5F0
		[Token(Token = "0x6019BCF")]
		[Address(RVA = "0x1294060", Offset = "0x1292C60", VA = "0x181294060")]
		private bool _OnIncreaseBtnLongPressed()
		{
			return default(bool);
		}

		// Token: 0x06019BD0 RID: 105424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BD0")]
		[Address(RVA = "0x1293E70", Offset = "0x1292A70", VA = "0x181293E70")]
		private void _OnDecreaseBtnClicked()
		{
		}

		// Token: 0x06019BD1 RID: 105425 RVA: 0x0009F408 File Offset: 0x0009D608
		[Token(Token = "0x6019BD1")]
		[Address(RVA = "0x1293F00", Offset = "0x1292B00", VA = "0x181293F00")]
		private bool _OnDecreaseBtnLongPressed()
		{
			return default(bool);
		}

		// Token: 0x06019BD2 RID: 105426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BD2")]
		[Address(RVA = "0x1294130", Offset = "0x1292D30", VA = "0x181294130")]
		public SandboxV2AdminShopItemDetailView()
		{
		}

		// Token: 0x040203B1 RID: 132017
		[Token(Token = "0x40203B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _textName;

		// Token: 0x040203B2 RID: 132018
		[Token(Token = "0x40203B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040203B3 RID: 132019
		[Token(Token = "0x40203B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x040203B4 RID: 132020
		[Token(Token = "0x40203B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgItemIcon;

		// Token: 0x040203B5 RID: 132021
		[Token(Token = "0x40203B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _panelGold;

		// Token: 0x040203B6 RID: 132022
		[Token(Token = "0x40203B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _panelDimensionCoin;

		// Token: 0x040203B7 RID: 132023
		[Token(Token = "0x40203B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelOriginPrice;

		// Token: 0x040203B8 RID: 132024
		[Token(Token = "0x40203B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text[] _textOriginPrice;

		// Token: 0x040203B9 RID: 132025
		[Token(Token = "0x40203B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text[] _textCurrentPrice;

		// Token: 0x040203BA RID: 132026
		[Token(Token = "0x40203BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textOwnCount;

		// Token: 0x040203BB RID: 132027
		[Token(Token = "0x40203BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textGoodItemCount;

		// Token: 0x040203BC RID: 132028
		[Token(Token = "0x40203BC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textBuyCount;

		// Token: 0x040203BD RID: 132029
		[Token(Token = "0x40203BD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textStock;

		// Token: 0x040203BE RID: 132030
		[Token(Token = "0x40203BE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text[] _textPrice;

		// Token: 0x040203BF RID: 132031
		[Token(Token = "0x40203BF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _imgDiscountGold;

		// Token: 0x040203C0 RID: 132032
		[Token(Token = "0x40203C0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imgDiscountDimensionCoin;

		// Token: 0x040203C1 RID: 132033
		[Token(Token = "0x40203C1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image[] _imgGold;

		// Token: 0x040203C2 RID: 132034
		[Token(Token = "0x40203C2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image[] _imgDimensionCoin;

		// Token: 0x040203C3 RID: 132035
		[Token(Token = "0x40203C3")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private MaskableGraphic[] _graphicGold;

		// Token: 0x040203C4 RID: 132036
		[Token(Token = "0x40203C4")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private MaskableGraphic[] _graphicDimensionCoin;

		// Token: 0x040203C5 RID: 132037
		[Token(Token = "0x40203C5")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UILongPressButtonEx _btnIncrease;

		// Token: 0x040203C6 RID: 132038
		[Token(Token = "0x40203C6")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UILongPressButtonEx _btnDecrease;

		// Token: 0x040203C7 RID: 132039
		[Token(Token = "0x40203C7")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Button[] _btnBuy;

		// Token: 0x040203C8 RID: 132040
		[Token(Token = "0x40203C8")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040203C9 RID: 132041
		[Token(Token = "0x40203C9")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_hasInited;

		// Token: 0x040203CA RID: 132042
		[Token(Token = "0x40203CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040203CB RID: 132043
		[Token(Token = "0x40203CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBuyBtnClicked;

		// Token: 0x040203CC RID: 132044
		[Token(Token = "0x40203CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040203CD RID: 132045
		[Token(Token = "0x40203CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnClicked;

		// Token: 0x040203CE RID: 132046
		[Token(Token = "0x40203CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnLongPressed;

		// Token: 0x040203CF RID: 132047
		[Token(Token = "0x40203CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnClicked;

		// Token: 0x040203D0 RID: 132048
		[Token(Token = "0x40203D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnLongPressed;

		// Token: 0x040203D1 RID: 132049
		[Token(Token = "0x40203D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
