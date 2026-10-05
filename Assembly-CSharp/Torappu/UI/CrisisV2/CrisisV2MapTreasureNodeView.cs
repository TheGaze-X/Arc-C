using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059C4 RID: 22980
	[Token(Token = "0x20059C4")]
	public class CrisisV2MapTreasureNodeView : CrisisV2MapNodeViewBase
	{
		// Token: 0x060217E7 RID: 137191 RVA: 0x000BA708 File Offset: 0x000B8908
		[Token(Token = "0x60217E7")]
		[Address(RVA = "0x1BD8F80", Offset = "0x1BD7B80", VA = "0x181BD8F80", Slot = "4")]
		public override CrisisV2NodeSlotType GetSlotType()
		{
			return CrisisV2NodeSlotType.NONE;
		}

		// Token: 0x060217E8 RID: 137192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217E8")]
		[Address(RVA = "0x1BD8FE0", Offset = "0x1BD7BE0", VA = "0x181BD8FE0", Slot = "5")]
		protected override void Render()
		{
		}

		// Token: 0x060217E9 RID: 137193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217E9")]
		[Address(RVA = "0x1BD94E0", Offset = "0x1BD80E0", VA = "0x181BD94E0")]
		private void _RenderItemCard(CrisisV2MapTreasureNodeModel treasureModel)
		{
		}

		// Token: 0x060217EA RID: 137194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217EA")]
		[Address(RVA = "0x1BD8E90", Offset = "0x1BD7A90", VA = "0x181BD8E90")]
		public void EventBtnSkinPreview()
		{
		}

		// Token: 0x060217EB RID: 137195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217EB")]
		[Address(RVA = "0x1BD9720", Offset = "0x1BD8320", VA = "0x181BD9720")]
		public CrisisV2MapTreasureNodeView()
		{
		}

		// Token: 0x0402DC0F RID: 187407
		[Token(Token = "0x402DC0F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unavailBgGo;

		// Token: 0x0402DC10 RID: 187408
		[Token(Token = "0x402DC10")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _availBgGo;

		// Token: 0x0402DC11 RID: 187409
		[Token(Token = "0x402DC11")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imgRewardGlow;

		// Token: 0x0402DC12 RID: 187410
		[Token(Token = "0x402DC12")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorRewardGlowUnavail;

		// Token: 0x0402DC13 RID: 187411
		[Token(Token = "0x402DC13")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorRewardGlowAvail;

		// Token: 0x0402DC14 RID: 187412
		[Token(Token = "0x402DC14")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _imgRewardCaption;

		// Token: 0x0402DC15 RID: 187413
		[Token(Token = "0x402DC15")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _colorRewardCaptionUnavail;

		// Token: 0x0402DC16 RID: 187414
		[Token(Token = "0x402DC16")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _colorRewardCaptionAvail;

		// Token: 0x0402DC17 RID: 187415
		[Token(Token = "0x402DC17")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x0402DC18 RID: 187416
		[Token(Token = "0x402DC18")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402DC19 RID: 187417
		[Token(Token = "0x402DC19")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _iconIncompletedGo;

		// Token: 0x0402DC1A RID: 187418
		[Token(Token = "0x402DC1A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _iconAvailGo;

		// Token: 0x0402DC1B RID: 187419
		[Token(Token = "0x402DC1B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _iconClaimedGo;

		// Token: 0x0402DC1C RID: 187420
		[Token(Token = "0x402DC1C")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CanvasGroup _nodeCanvasGroup;

		// Token: 0x0402DC1D RID: 187421
		[Token(Token = "0x402DC1D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _claimedAlpha;

		// Token: 0x0402DC1E RID: 187422
		[Token(Token = "0x402DC1E")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _claimedMaskGo;

		// Token: 0x0402DC1F RID: 187423
		[Token(Token = "0x402DC1F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text _textCurrent;

		// Token: 0x0402DC20 RID: 187424
		[Token(Token = "0x402DC20")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _textTotal;

		// Token: 0x0402DC21 RID: 187425
		[Token(Token = "0x402DC21")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _incompleteCaptionGo;

		// Token: 0x0402DC22 RID: 187426
		[Token(Token = "0x402DC22")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _completedCaptionGo;

		// Token: 0x0402DC23 RID: 187427
		[Token(Token = "0x402DC23")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _availCaptionGo;

		// Token: 0x0402DC24 RID: 187428
		[Token(Token = "0x402DC24")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _btnSkinPreviewGo;

		// Token: 0x0402DC25 RID: 187429
		[Token(Token = "0x402DC25")]
		[FieldOffset(Offset = "0x120")]
		private UIItemCard m_itemCard;

		// Token: 0x0402DC26 RID: 187430
		[Token(Token = "0x402DC26")]
		[FieldOffset(Offset = "0x128")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0402DC27 RID: 187431
		[Token(Token = "0x402DC27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSlotType;

		// Token: 0x0402DC28 RID: 187432
		[Token(Token = "0x402DC28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DC29 RID: 187433
		[Token(Token = "0x402DC29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderItemCard;

		// Token: 0x0402DC2A RID: 187434
		[Token(Token = "0x402DC2A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventBtnSkinPreview;

		// Token: 0x0402DC2B RID: 187435
		[Token(Token = "0x402DC2B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
