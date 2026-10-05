using System;
using Il2CppDummyDll;
using Torappu.UI.Shop;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003ECF RID: 16079
	[Token(Token = "0x2003ECF")]
	public class SkinBuyState : PopupFloatState
	{
		// Token: 0x06018F1C RID: 102172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F1C")]
		[Address(RVA = "0x1197DE0", Offset = "0x11969E0", VA = "0x181197DE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018F1D RID: 102173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018F1D")]
		[Address(RVA = "0x11973C0", Offset = "0x1195FC0", VA = "0x1811973C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018F1E RID: 102174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F1E")]
		[Address(RVA = "0x1197420", Offset = "0x1196020", VA = "0x181197420", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018F1F RID: 102175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F1F")]
		[Address(RVA = "0x1197900", Offset = "0x1196500", VA = "0x181197900")]
		public void SendBuyState()
		{
		}

		// Token: 0x06018F20 RID: 102176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F20")]
		[Address(RVA = "0x1197F10", Offset = "0x1196B10", VA = "0x181197F10")]
		private void _RenderPaymentInfo(SkinSelectViewModel skinViewModel)
		{
		}

		// Token: 0x06018F21 RID: 102177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018F21")]
		[Address(RVA = "0x1197CC0", Offset = "0x11968C0", VA = "0x181197CC0")]
		private string _GetVoucherItemName()
		{
			return null;
		}

		// Token: 0x06018F22 RID: 102178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F22")]
		[Address(RVA = "0x1198410", Offset = "0x1197010", VA = "0x181198410")]
		private void _SendGetSkinViaVoucher(SkinShopViewModel viewModel)
		{
		}

		// Token: 0x06018F23 RID: 102179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F23")]
		[Address(RVA = "0x11987F0", Offset = "0x11973F0", VA = "0x1811987F0")]
		public SkinBuyState()
		{
		}

		// Token: 0x06018F25 RID: 102181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F25")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401EC9D RID: 126109
		[Token(Token = "0x401EC9D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SkinSelectStateBean _stateBean;

		// Token: 0x0401EC9E RID: 126110
		[Token(Token = "0x401EC9E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _cashPart;

		// Token: 0x0401EC9F RID: 126111
		[Token(Token = "0x401EC9F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _diamondPart;

		// Token: 0x0401ECA0 RID: 126112
		[Token(Token = "0x401ECA0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgDiamond;

		// Token: 0x0401ECA1 RID: 126113
		[Token(Token = "0x401ECA1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _imgCash;

		// Token: 0x0401ECA2 RID: 126114
		[Token(Token = "0x401ECA2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0401ECA3 RID: 126115
		[Token(Token = "0x401ECA3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _infoText;

		// Token: 0x0401ECA4 RID: 126116
		[Token(Token = "0x401ECA4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _tmplText;

		// Token: 0x0401ECA5 RID: 126117
		[Token(Token = "0x401ECA5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0401ECA6 RID: 126118
		[Token(Token = "0x401ECA6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _objBuyPart;

		// Token: 0x0401ECA7 RID: 126119
		[Token(Token = "0x401ECA7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _objVoucherPart;

		// Token: 0x0401ECA8 RID: 126120
		[Token(Token = "0x401ECA8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _textVoucherTitle;

		// Token: 0x0401ECA9 RID: 126121
		[Token(Token = "0x401ECA9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _textVoucherDesc;

		// Token: 0x0401ECAA RID: 126122
		[Token(Token = "0x401ECAA")]
		[FieldOffset(Offset = "0xD8")]
		private SkinShopPerItemView m_cacheView;

		// Token: 0x0401ECAB RID: 126123
		[Token(Token = "0x401ECAB")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isInited;

		// Token: 0x0401ECAC RID: 126124
		[Token(Token = "0x401ECAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401ECAD RID: 126125
		[Token(Token = "0x401ECAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401ECAE RID: 126126
		[Token(Token = "0x401ECAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401ECAF RID: 126127
		[Token(Token = "0x401ECAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendBuyState;

		// Token: 0x0401ECB0 RID: 126128
		[Token(Token = "0x401ECB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderPaymentInfo;

		// Token: 0x0401ECB1 RID: 126129
		[Token(Token = "0x401ECB1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetVoucherItemName;

		// Token: 0x0401ECB2 RID: 126130
		[Token(Token = "0x401ECB2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendGetSkinViaVoucher;

		// Token: 0x0401ECB3 RID: 126131
		[Token(Token = "0x401ECB3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
