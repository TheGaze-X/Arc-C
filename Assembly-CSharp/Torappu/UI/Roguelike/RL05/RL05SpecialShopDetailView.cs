using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200561D RID: 22045
	[Token(Token = "0x200561D")]
	public class RL05SpecialShopDetailView : MonoBehaviour, IHotfixable, IRoguelikeGameShopVisibility
	{
		// Token: 0x06020593 RID: 132499 RVA: 0x000B57A0 File Offset: 0x000B39A0
		[Token(Token = "0x6020593")]
		[Address(RVA = "0x1A82D40", Offset = "0x1A81940", VA = "0x181A82D40", Slot = "5")]
		public RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x06020594 RID: 132500 RVA: 0x000B57B8 File Offset: 0x000B39B8
		[Token(Token = "0x6020594")]
		[Address(RVA = "0x1A82CE0", Offset = "0x1A818E0", VA = "0x181A82CE0", Slot = "6")]
		public RoguelikeGameShopStatusEnum GetRivalStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x06020595 RID: 132501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020595")]
		[Address(RVA = "0x1A82E80", Offset = "0x1A81A80", VA = "0x181A82E80")]
		public void Render(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06020596 RID: 132502 RVA: 0x000B57D0 File Offset: 0x000B39D0
		[Token(Token = "0x6020596")]
		[Address(RVA = "0x1A83100", Offset = "0x1A81D00", VA = "0x181A83100", Slot = "4")]
		public float SetShow(bool isShow, bool fastMode, RoguelikeGameShopStatusEnum current)
		{
			return 0f;
		}

		// Token: 0x06020597 RID: 132503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020597")]
		[Address(RVA = "0x1A82BD0", Offset = "0x1A817D0", VA = "0x181A82BD0")]
		public void BindShopController(RoguelikeShopDetailControllerBindings bindings)
		{
		}

		// Token: 0x06020598 RID: 132504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020598")]
		[Address(RVA = "0x1A831D0", Offset = "0x1A81DD0", VA = "0x181A831D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020599 RID: 132505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020599")]
		[Address(RVA = "0x1A83390", Offset = "0x1A81F90", VA = "0x181A83390")]
		private void _InjectExtraInfoPlugin(RoguelikeShopDetailExtraInfoPlugin plugin)
		{
		}

		// Token: 0x0602059A RID: 132506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602059A")]
		[Address(RVA = "0x1A83DF0", Offset = "0x1A829F0", VA = "0x181A83DF0")]
		private void _SetupIconPluginIfNeed()
		{
		}

		// Token: 0x0602059B RID: 132507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602059B")]
		[Address(RVA = "0x1A83410", Offset = "0x1A82010", VA = "0x181A83410")]
		private void _PrepareCostIcon(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0602059C RID: 132508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602059C")]
		[Address(RVA = "0x1A837E0", Offset = "0x1A823E0", VA = "0x181A837E0")]
		private void _RenderItemInfo(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0602059D RID: 132509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602059D")]
		[Address(RVA = "0x1A83AD0", Offset = "0x1A826D0", VA = "0x181A83AD0")]
		private void _RenderPriceDesc(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0602059E RID: 132510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602059E")]
		[Address(RVA = "0x1A83500", Offset = "0x1A82100", VA = "0x181A83500")]
		private void _RenderButton(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0602059F RID: 132511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602059F")]
		[Address(RVA = "0x1A82E10", Offset = "0x1A81A10", VA = "0x181A82E10")]
		public void OnBtnConfirm()
		{
		}

		// Token: 0x060205A0 RID: 132512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205A0")]
		[Address(RVA = "0x1A82DA0", Offset = "0x1A819A0", VA = "0x181A82DA0")]
		public void OnBtnCancel()
		{
		}

		// Token: 0x060205A1 RID: 132513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205A1")]
		[Address(RVA = "0x1A83F20", Offset = "0x1A82B20", VA = "0x181A83F20")]
		public RL05SpecialShopDetailView()
		{
		}

		// Token: 0x0402BC72 RID: 179314
		[Token(Token = "0x402BC72")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Anim")]
		private RectTransform _rootRect;

		// Token: 0x0402BC73 RID: 179315
		[Token(Token = "0x402BC73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Anim")]
		private CanvasGroup _rootGroup;

		// Token: 0x0402BC74 RID: 179316
		[Token(Token = "0x402BC74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Anim")]
		private Vector2 _hidePos;

		// Token: 0x0402BC75 RID: 179317
		[Token(Token = "0x402BC75")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Anim")]
		private Vector2 _showPos;

		// Token: 0x0402BC76 RID: 179318
		[Token(Token = "0x402BC76")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Anim")]
		private float _fadeDuration;

		// Token: 0x0402BC77 RID: 179319
		[Token(Token = "0x402BC77")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Item Info")]
		private Image _itemIconImage;

		// Token: 0x0402BC78 RID: 179320
		[Token(Token = "0x402BC78")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Item Info")]
		private RectTransform _iconPluginContainer;

		// Token: 0x0402BC79 RID: 179321
		[Token(Token = "0x402BC79")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Item Info")]
		private Text _itemNameText;

		// Token: 0x0402BC7A RID: 179322
		[Token(Token = "0x402BC7A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Item Info")]
		private Text _itemUsageText;

		// Token: 0x0402BC7B RID: 179323
		[Token(Token = "0x402BC7B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Item Info")]
		private Text _itemDescText;

		// Token: 0x0402BC7C RID: 179324
		[Token(Token = "0x402BC7C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Item Info")]
		private RoguelikeShopDetailExtraInfoView _extraInfoView;

		// Token: 0x0402BC7D RID: 179325
		[Token(Token = "0x402BC7D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Price Desc")]
		private Image _priceDescIconImage;

		// Token: 0x0402BC7E RID: 179326
		[Token(Token = "0x402BC7E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Price Desc")]
		private Text _priceDescCountText;

		// Token: 0x0402BC7F RID: 179327
		[Token(Token = "0x402BC7F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Price Desc")]
		private Text _priceDescPriceNameText;

		// Token: 0x0402BC80 RID: 179328
		[Token(Token = "0x402BC80")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Price Desc")]
		private Color _priceColorAffordable;

		// Token: 0x0402BC81 RID: 179329
		[Token(Token = "0x402BC81")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Price Desc")]
		private Color _priceColorLack;

		// Token: 0x0402BC82 RID: 179330
		[Token(Token = "0x402BC82")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Price Desc")]
		private Text _priceDescItemNameText;

		// Token: 0x0402BC83 RID: 179331
		[Token(Token = "0x402BC83")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Button")]
		private Button _confirmButton;

		// Token: 0x0402BC84 RID: 179332
		[Token(Token = "0x402BC84")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Button")]
		private GameObject _invalidPanel;

		// Token: 0x0402BC85 RID: 179333
		[Token(Token = "0x402BC85")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Button")]
		private List<Image> _priceIconImages;

		// Token: 0x0402BC86 RID: 179334
		[Token(Token = "0x402BC86")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Button")]
		private Text _confirmText;

		// Token: 0x0402BC87 RID: 179335
		[Token(Token = "0x402BC87")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Button")]
		private Text _confirmPriceText;

		// Token: 0x0402BC88 RID: 179336
		[Token(Token = "0x402BC88")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_inited;

		// Token: 0x0402BC89 RID: 179337
		[Token(Token = "0x402BC89")]
		[FieldOffset(Offset = "0xE0")]
		private RoguelikeGameShopSwitchTween m_switchTween;

		// Token: 0x0402BC8A RID: 179338
		[Token(Token = "0x402BC8A")]
		[FieldOffset(Offset = "0xE8")]
		private UIStateFinder m_finder;

		// Token: 0x0402BC8B RID: 179339
		[Token(Token = "0x402BC8B")]
		[FieldOffset(Offset = "0xF8")]
		private ILoadAsset m_loader;

		// Token: 0x0402BC8C RID: 179340
		[Token(Token = "0x402BC8C")]
		[FieldOffset(Offset = "0x100")]
		private RoguelikeShopDetailControllerBindings m_controllerBindings;

		// Token: 0x0402BC8D RID: 179341
		[Token(Token = "0x402BC8D")]
		[FieldOffset(Offset = "0x108")]
		private RoguelikeGoodsObjPlugin m_pluginIcon;

		// Token: 0x0402BC8E RID: 179342
		[Token(Token = "0x402BC8E")]
		[FieldOffset(Offset = "0x110")]
		private string m_cachedPriceId;

		// Token: 0x0402BC8F RID: 179343
		[Token(Token = "0x402BC8F")]
		[FieldOffset(Offset = "0x118")]
		private Sprite m_cachedPriceSprite;

		// Token: 0x0402BC90 RID: 179344
		[Token(Token = "0x402BC90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetShopStatus;

		// Token: 0x0402BC91 RID: 179345
		[Token(Token = "0x402BC91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRivalStatus;

		// Token: 0x0402BC92 RID: 179346
		[Token(Token = "0x402BC92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BC93 RID: 179347
		[Token(Token = "0x402BC93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402BC94 RID: 179348
		[Token(Token = "0x402BC94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402BC95 RID: 179349
		[Token(Token = "0x402BC95")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BC96 RID: 179350
		[Token(Token = "0x402BC96")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InjectExtraInfoPlugin;

		// Token: 0x0402BC97 RID: 179351
		[Token(Token = "0x402BC97")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetupIconPluginIfNeed;

		// Token: 0x0402BC98 RID: 179352
		[Token(Token = "0x402BC98")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PrepareCostIcon;

		// Token: 0x0402BC99 RID: 179353
		[Token(Token = "0x402BC99")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderItemInfo;

		// Token: 0x0402BC9A RID: 179354
		[Token(Token = "0x402BC9A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderPriceDesc;

		// Token: 0x0402BC9B RID: 179355
		[Token(Token = "0x402BC9B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderButton;

		// Token: 0x0402BC9C RID: 179356
		[Token(Token = "0x402BC9C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnConfirm;

		// Token: 0x0402BC9D RID: 179357
		[Token(Token = "0x402BC9D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBtnCancel;

		// Token: 0x0402BC9E RID: 179358
		[Token(Token = "0x402BC9E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
