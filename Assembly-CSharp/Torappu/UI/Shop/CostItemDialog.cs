using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A62 RID: 23138
	[Token(Token = "0x2005A62")]
	public class CostItemDialog : UICompDialog<CostItemDialog.Input>, IHotfixable
	{
		// Token: 0x06021AB9 RID: 137913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AB9")]
		[Address(RVA = "0x1C17CB0", Offset = "0x1C168B0", VA = "0x181C17CB0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06021ABA RID: 137914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ABA")]
		[Address(RVA = "0x1C17D10", Offset = "0x1C16910", VA = "0x181C17D10", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06021ABB RID: 137915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ABB")]
		[Address(RVA = "0x1C17EA0", Offset = "0x1C16AA0", VA = "0x181C17EA0", Slot = "18")]
		protected override void OnRender(CostItemDialog.Input input)
		{
		}

		// Token: 0x06021ABC RID: 137916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ABC")]
		[Address(RVA = "0x1C17BF0", Offset = "0x1C167F0", VA = "0x181C17BF0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x06021ABD RID: 137917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ABD")]
		[Address(RVA = "0x1C17B30", Offset = "0x1C16730", VA = "0x181C17B30")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x06021ABE RID: 137918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ABE")]
		[Address(RVA = "0x1C18160", Offset = "0x1C16D60", VA = "0x181C18160")]
		private void _OnFromItemCardClicked(int _)
		{
		}

		// Token: 0x06021ABF RID: 137919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ABF")]
		[Address(RVA = "0x1C18220", Offset = "0x1C16E20", VA = "0x181C18220")]
		private void _OnToItemCardClicked(int _)
		{
		}

		// Token: 0x06021AC0 RID: 137920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AC0")]
		[Address(RVA = "0x1C17FF0", Offset = "0x1C16BF0", VA = "0x181C17FF0")]
		private static UIItemCard _GenerateItemCard(RectTransform container, float scale)
		{
			return null;
		}

		// Token: 0x06021AC1 RID: 137921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AC1")]
		[Address(RVA = "0x1C182E0", Offset = "0x1C16EE0", VA = "0x181C182E0")]
		public CostItemDialog()
		{
		}

		// Token: 0x06021AC2 RID: 137922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AC2")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06021AC3 RID: 137923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AC3")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402E076 RID: 188534
		[Token(Token = "0x402E076")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBackground;

		// Token: 0x0402E077 RID: 188535
		[Token(Token = "0x402E077")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _fromItemCardContainer;

		// Token: 0x0402E078 RID: 188536
		[Token(Token = "0x402E078")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _toItemCardContainer;

		// Token: 0x0402E079 RID: 188537
		[Token(Token = "0x402E079")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402E07A RID: 188538
		[Token(Token = "0x402E07A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textConfirmDesc;

		// Token: 0x0402E07B RID: 188539
		[Token(Token = "0x402E07B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textCancelDesc;

		// Token: 0x0402E07C RID: 188540
		[Token(Token = "0x402E07C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0402E07D RID: 188541
		[Token(Token = "0x402E07D")]
		[FieldOffset(Offset = "0xA8")]
		private UIItemCard m_fromItemCard;

		// Token: 0x0402E07E RID: 188542
		[Token(Token = "0x402E07E")]
		[FieldOffset(Offset = "0xB0")]
		private UIItemCard m_toItemCard;

		// Token: 0x0402E07F RID: 188543
		[Token(Token = "0x402E07F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402E080 RID: 188544
		[Token(Token = "0x402E080")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402E081 RID: 188545
		[Token(Token = "0x402E081")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402E082 RID: 188546
		[Token(Token = "0x402E082")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0402E083 RID: 188547
		[Token(Token = "0x402E083")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x0402E084 RID: 188548
		[Token(Token = "0x402E084")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFromItemCardClicked;

		// Token: 0x0402E085 RID: 188549
		[Token(Token = "0x402E085")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnToItemCardClicked;

		// Token: 0x0402E086 RID: 188550
		[Token(Token = "0x402E086")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateItemCard;

		// Token: 0x0402E087 RID: 188551
		[Token(Token = "0x402E087")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A63 RID: 23139
		[Token(Token = "0x2005A63")]
		public class Input
		{
			// Token: 0x06021AC4 RID: 137924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021AC4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402E088 RID: 188552
			[Token(Token = "0x402E088")]
			[FieldOffset(Offset = "0x10")]
			public UIItemViewModel fromItemViewModel;

			// Token: 0x0402E089 RID: 188553
			[Token(Token = "0x402E089")]
			[FieldOffset(Offset = "0x18")]
			public UIItemViewModel toItemViewModel;

			// Token: 0x0402E08A RID: 188554
			[Token(Token = "0x402E08A")]
			[FieldOffset(Offset = "0x20")]
			public string desc;

			// Token: 0x0402E08B RID: 188555
			[Token(Token = "0x402E08B")]
			[FieldOffset(Offset = "0x28")]
			public string confirmDesc;

			// Token: 0x0402E08C RID: 188556
			[Token(Token = "0x402E08C")]
			[FieldOffset(Offset = "0x30")]
			public string cancelDesc;
		}
	}
}
