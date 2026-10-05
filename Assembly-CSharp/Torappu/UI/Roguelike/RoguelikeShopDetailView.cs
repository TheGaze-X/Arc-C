using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054FF RID: 21759
	[Token(Token = "0x20054FF")]
	public class RoguelikeShopDetailView : MonoBehaviour, IHotfixable, IRoguelikeGameShopVisibility
	{
		// Token: 0x0602000F RID: 131087 RVA: 0x000B4318 File Offset: 0x000B2518
		[Token(Token = "0x602000F")]
		[Address(RVA = "0x1A20DF0", Offset = "0x1A1F9F0", VA = "0x181A20DF0", Slot = "5")]
		public RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x06020010 RID: 131088 RVA: 0x000B4330 File Offset: 0x000B2530
		[Token(Token = "0x6020010")]
		[Address(RVA = "0x1A20D90", Offset = "0x1A1F990", VA = "0x181A20D90", Slot = "6")]
		public RoguelikeGameShopStatusEnum GetRivalStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x06020011 RID: 131089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020011")]
		[Address(RVA = "0x1A20FB0", Offset = "0x1A1FBB0", VA = "0x181A20FB0")]
		public void Render(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06020012 RID: 131090 RVA: 0x000B4348 File Offset: 0x000B2548
		[Token(Token = "0x6020012")]
		[Address(RVA = "0x1A21140", Offset = "0x1A1FD40", VA = "0x181A21140", Slot = "4")]
		public float SetShow(bool isShow, bool fastMode, RoguelikeGameShopStatusEnum current)
		{
			return 0f;
		}

		// Token: 0x06020013 RID: 131091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020013")]
		[Address(RVA = "0x1A20A30", Offset = "0x1A1F630", VA = "0x181A20A30")]
		public void BindShopController(RoguelikeShopDetailControllerBindings bindings)
		{
		}

		// Token: 0x06020014 RID: 131092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020014")]
		[Address(RVA = "0x1A21210", Offset = "0x1A1FE10", VA = "0x181A21210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020015 RID: 131093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020015")]
		[Address(RVA = "0x1A213E0", Offset = "0x1A1FFE0", VA = "0x181A213E0")]
		private void _InjectExtraInfoPlugin(RoguelikeShopDetailExtraInfoPlugin plugin)
		{
		}

		// Token: 0x06020016 RID: 131094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020016")]
		[Address(RVA = "0x1A21E70", Offset = "0x1A20A70", VA = "0x181A21E70")]
		private void _SetupIconPluginIfNeed()
		{
		}

		// Token: 0x06020017 RID: 131095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020017")]
		[Address(RVA = "0x1A21830", Offset = "0x1A20430", VA = "0x181A21830")]
		private void _RenderItemInfo(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06020018 RID: 131096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020018")]
		[Address(RVA = "0x1A21C70", Offset = "0x1A20870", VA = "0x181A21C70")]
		private void _RenderPriceDesc(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06020019 RID: 131097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020019")]
		[Address(RVA = "0x1A214C0", Offset = "0x1A200C0", VA = "0x181A214C0")]
		private void _RenderButtons(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0602001A RID: 131098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602001A")]
		[Address(RVA = "0x1A20F00", Offset = "0x1A1FB00", VA = "0x181A20F00")]
		public void OnBtnConfirm()
		{
		}

		// Token: 0x0602001B RID: 131099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602001B")]
		[Address(RVA = "0x1A20E50", Offset = "0x1A1FA50", VA = "0x181A20E50")]
		public void OnBtnCancel()
		{
		}

		// Token: 0x0602001C RID: 131100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602001C")]
		[Address(RVA = "0x1A20BE0", Offset = "0x1A1F7E0", VA = "0x181A20BE0")]
		public static string GetDefaultConfirmText(RoguelikeGoodsViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0602001D RID: 131101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602001D")]
		[Address(RVA = "0x1A21FE0", Offset = "0x1A20BE0", VA = "0x181A21FE0")]
		public RoguelikeShopDetailView()
		{
		}

		// Token: 0x0402B31C RID: 176924
		[Token(Token = "0x402B31C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _panelWidgets;

		// Token: 0x0402B31D RID: 176925
		[Token(Token = "0x402B31D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402B31E RID: 176926
		[Token(Token = "0x402B31E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0402B31F RID: 176927
		[Token(Token = "0x402B31F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402B320 RID: 176928
		[Token(Token = "0x402B320")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x0402B321 RID: 176929
		[Token(Token = "0x402B321")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402B322 RID: 176930
		[Token(Token = "0x402B322")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textPrice;

		// Token: 0x0402B323 RID: 176931
		[Token(Token = "0x402B323")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _priceColorAffordable;

		// Token: 0x0402B324 RID: 176932
		[Token(Token = "0x402B324")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _priceColorLack;

		// Token: 0x0402B325 RID: 176933
		[Token(Token = "0x402B325")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _priceColorRecycle;

		// Token: 0x0402B326 RID: 176934
		[Token(Token = "0x402B326")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textBuyName;

		// Token: 0x0402B327 RID: 176935
		[Token(Token = "0x402B327")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402B328 RID: 176936
		[Token(Token = "0x402B328")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _imagePrice;

		// Token: 0x0402B329 RID: 176937
		[Token(Token = "0x402B329")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<GameObject> _buyPanels;

		// Token: 0x0402B32A RID: 176938
		[Token(Token = "0x402B32A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<GameObject> _recyclePanels;

		// Token: 0x0402B32B RID: 176939
		[Token(Token = "0x402B32B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Vector2 _hidePos;

		// Token: 0x0402B32C RID: 176940
		[Token(Token = "0x402B32C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Vector2 _showPos;

		// Token: 0x0402B32D RID: 176941
		[Token(Token = "0x402B32D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _btnAlphaHandler;

		// Token: 0x0402B32E RID: 176942
		[Token(Token = "0x402B32E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _btnInactiveAlpha;

		// Token: 0x0402B32F RID: 176943
		[Token(Token = "0x402B32F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x0402B330 RID: 176944
		[Token(Token = "0x402B330")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _confirmText;

		// Token: 0x0402B331 RID: 176945
		[Token(Token = "0x402B331")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TwoStateToggle _toggleConfirmText;

		// Token: 0x0402B332 RID: 176946
		[Token(Token = "0x402B332")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RoguelikeShopDetailExtraInfoView _extraInfoView;

		// Token: 0x0402B333 RID: 176947
		[Token(Token = "0x402B333")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Plugin")]
		private RectTransform _iconPluginContainer;

		// Token: 0x0402B334 RID: 176948
		[Token(Token = "0x402B334")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_inited;

		// Token: 0x0402B335 RID: 176949
		[Token(Token = "0x402B335")]
		[FieldOffset(Offset = "0xF8")]
		private RoguelikeGameShopSwitchTween m_switchTween;

		// Token: 0x0402B336 RID: 176950
		[Token(Token = "0x402B336")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_finder;

		// Token: 0x0402B337 RID: 176951
		[Token(Token = "0x402B337")]
		[FieldOffset(Offset = "0x110")]
		private ILoadAsset m_loadAsset;

		// Token: 0x0402B338 RID: 176952
		[Token(Token = "0x402B338")]
		[FieldOffset(Offset = "0x118")]
		private RoguelikeShopDetailControllerBindings m_controllerBindings;

		// Token: 0x0402B339 RID: 176953
		[Token(Token = "0x402B339")]
		[FieldOffset(Offset = "0x120")]
		private RoguelikeGoodsObjPlugin m_pluginIcon;

		// Token: 0x0402B33A RID: 176954
		[Token(Token = "0x402B33A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetShopStatus;

		// Token: 0x0402B33B RID: 176955
		[Token(Token = "0x402B33B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRivalStatus;

		// Token: 0x0402B33C RID: 176956
		[Token(Token = "0x402B33C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B33D RID: 176957
		[Token(Token = "0x402B33D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402B33E RID: 176958
		[Token(Token = "0x402B33E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B33F RID: 176959
		[Token(Token = "0x402B33F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B340 RID: 176960
		[Token(Token = "0x402B340")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InjectExtraInfoPlugin;

		// Token: 0x0402B341 RID: 176961
		[Token(Token = "0x402B341")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetupIconPluginIfNeed;

		// Token: 0x0402B342 RID: 176962
		[Token(Token = "0x402B342")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderItemInfo;

		// Token: 0x0402B343 RID: 176963
		[Token(Token = "0x402B343")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderPriceDesc;

		// Token: 0x0402B344 RID: 176964
		[Token(Token = "0x402B344")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderButtons;

		// Token: 0x0402B345 RID: 176965
		[Token(Token = "0x402B345")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnConfirm;

		// Token: 0x0402B346 RID: 176966
		[Token(Token = "0x402B346")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnCancel;

		// Token: 0x0402B347 RID: 176967
		[Token(Token = "0x402B347")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetDefaultConfirmText;

		// Token: 0x0402B348 RID: 176968
		[Token(Token = "0x402B348")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
