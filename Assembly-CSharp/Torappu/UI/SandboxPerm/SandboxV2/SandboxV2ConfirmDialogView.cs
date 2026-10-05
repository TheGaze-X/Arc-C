using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004136 RID: 16694
	[Token(Token = "0x2004136")]
	public class SandboxV2ConfirmDialogView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x06019C6D RID: 105581 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019C6E RID: 105582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D6A")]
		public Action onCancelClicked
		{
			[Token(Token = "0x6019C6D")]
			[Address(RVA = "0x12AA0E0", Offset = "0x12A8CE0", VA = "0x1812AA0E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019C6E")]
			[Address(RVA = "0x12AA280", Offset = "0x12A8E80", VA = "0x1812AA280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x06019C6F RID: 105583 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019C70 RID: 105584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D6B")]
		public Action onConfirmClicked
		{
			[Token(Token = "0x6019C6F")]
			[Address(RVA = "0x12AA160", Offset = "0x12A8D60", VA = "0x1812AA160")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019C70")]
			[Address(RVA = "0x12AA320", Offset = "0x12A8F20", VA = "0x1812AA320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x06019C71 RID: 105585 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019C72 RID: 105586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D6C")]
		public Action onBackPressed
		{
			[Token(Token = "0x6019C71")]
			[Address(RVA = "0x12AA060", Offset = "0x12A8C60", VA = "0x1812AA060")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019C72")]
			[Address(RVA = "0x12AA1E0", Offset = "0x12A8DE0", VA = "0x1812AA1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019C73 RID: 105587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C73")]
		[Address(RVA = "0x12A8EF0", Offset = "0x12A7AF0", VA = "0x1812A8EF0")]
		public void Render(SandboxV2ConfirmDialogView.RenderParam renderParam)
		{
		}

		// Token: 0x06019C74 RID: 105588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C74")]
		[Address(RVA = "0x12A8CC0", Offset = "0x12A78C0", VA = "0x1812A8CC0")]
		public void OnCancelBtnClicked()
		{
		}

		// Token: 0x06019C75 RID: 105589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C75")]
		[Address(RVA = "0x12A8D70", Offset = "0x12A7970", VA = "0x1812A8D70")]
		public void OnConfirmBtnClicked()
		{
		}

		// Token: 0x06019C76 RID: 105590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C76")]
		[Address(RVA = "0x12A8C10", Offset = "0x12A7810", VA = "0x1812A8C10")]
		public void OnBackPressed()
		{
		}

		// Token: 0x06019C77 RID: 105591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C77")]
		[Address(RVA = "0x12A94B0", Offset = "0x12A80B0", VA = "0x1812A94B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019C78 RID: 105592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C78")]
		[Address(RVA = "0x12A9B30", Offset = "0x12A8730", VA = "0x1812A9B30")]
		private void _RenderThemeStyle(SandboxV2ConfirmDialogThemeType themeType)
		{
		}

		// Token: 0x06019C79 RID: 105593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C79")]
		[Address(RVA = "0x12A9670", Offset = "0x12A8270", VA = "0x1812A9670")]
		private void _RenderConfirmStyle(SandboxV2ConfirmDialogConfirmVisualType confirmVisualType)
		{
		}

		// Token: 0x06019C7A RID: 105594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C7A")]
		[Address(RVA = "0x12A9910", Offset = "0x12A8510", VA = "0x1812A9910")]
		private void _RenderIcon(string iconId, Sprite iconSprite, UIAssetLoader.Assets assetLoader)
		{
		}

		// Token: 0x06019C7B RID: 105595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C7B")]
		[Address(RVA = "0x12A9D50", Offset = "0x12A8950", VA = "0x1812A9D50")]
		private void _SetColorForGraphicItems(Graphic[] graphics, Color color)
		{
		}

		// Token: 0x06019C7C RID: 105596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C7C")]
		[Address(RVA = "0x12A9FE0", Offset = "0x12A8BE0", VA = "0x1812A9FE0")]
		public SandboxV2ConfirmDialogView()
		{
		}

		// Token: 0x04020543 RID: 132419
		[Token(Token = "0x4020543")]
		[FieldOffset(Offset = "0x0")]
		private static Color LIGHT_TITLE_COLOR;

		// Token: 0x04020544 RID: 132420
		[Token(Token = "0x4020544")]
		[FieldOffset(Offset = "0x10")]
		private static Color LIGHT_DESC_COLOR;

		// Token: 0x04020545 RID: 132421
		[Token(Token = "0x4020545")]
		[FieldOffset(Offset = "0x20")]
		private static Color DARK_TITLE_COLOR;

		// Token: 0x04020546 RID: 132422
		[Token(Token = "0x4020546")]
		[FieldOffset(Offset = "0x30")]
		private static Color DARK_DESC_COLOR;

		// Token: 0x04020547 RID: 132423
		[Token(Token = "0x4020547")]
		[FieldOffset(Offset = "0x40")]
		private static Color GREEN_CONFIRM_BG_COLOR;

		// Token: 0x04020548 RID: 132424
		[Token(Token = "0x4020548")]
		[FieldOffset(Offset = "0x50")]
		private static Color GREEN_CONFIRM_ITEMS_COLOR;

		// Token: 0x04020549 RID: 132425
		[Token(Token = "0x4020549")]
		[FieldOffset(Offset = "0x60")]
		private static Color RED_CONFIRM_BG_COLOR;

		// Token: 0x0402054A RID: 132426
		[Token(Token = "0x402054A")]
		[FieldOffset(Offset = "0x70")]
		private static Color RED_CONFIRM_ITEMS_COLOR;

		// Token: 0x0402054B RID: 132427
		[Token(Token = "0x402054B")]
		[FieldOffset(Offset = "0x80")]
		private static Color GRAY_CONFIRM_BG_COLOR;

		// Token: 0x0402054C RID: 132428
		[Token(Token = "0x402054C")]
		[FieldOffset(Offset = "0x90")]
		private static Color GRAY_CONFIRM_ITEMS_COLOR;

		// Token: 0x0402054D RID: 132429
		[Token(Token = "0x402054D")]
		[FieldOffset(Offset = "0xA0")]
		private static Color BLUE_CONFIRM_BG_COLOR;

		// Token: 0x0402054E RID: 132430
		[Token(Token = "0x402054E")]
		[FieldOffset(Offset = "0xB0")]
		private static Color BLUE_CONFIRM_ITEMS_COLOR;

		// Token: 0x0402054F RID: 132431
		[Token(Token = "0x402054F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtTitle;

		// Token: 0x04020550 RID: 132432
		[Token(Token = "0x4020550")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x04020551 RID: 132433
		[Token(Token = "0x4020551")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtConfirm;

		// Token: 0x04020552 RID: 132434
		[Token(Token = "0x4020552")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtCancel;

		// Token: 0x04020553 RID: 132435
		[Token(Token = "0x4020553")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04020554 RID: 132436
		[Token(Token = "0x4020554")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelThemeLight;

		// Token: 0x04020555 RID: 132437
		[Token(Token = "0x4020555")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelThemeDark;

		// Token: 0x04020556 RID: 132438
		[Token(Token = "0x4020556")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Graphic _graphicConfirmBg;

		// Token: 0x04020557 RID: 132439
		[Token(Token = "0x4020557")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Graphic[] _graphicConfirmItems;

		// Token: 0x04020558 RID: 132440
		[Token(Token = "0x4020558")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _decoContainer;

		// Token: 0x04020559 RID: 132441
		[Token(Token = "0x4020559")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0402055A RID: 132442
		[Token(Token = "0x402055A")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0402055B RID: 132443
		[Token(Token = "0x402055B")]
		[FieldOffset(Offset = "0x78")]
		private UIAssetLoader.Assets m_assetLoader;

		// Token: 0x0402055C RID: 132444
		[Token(Token = "0x402055C")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2ConfirmDialogConfirmAudioType m_cachedAudioType;

		// Token: 0x04020560 RID: 132448
		[Token(Token = "0x4020560")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_onCancelClicked;

		// Token: 0x04020561 RID: 132449
		[Token(Token = "0x4020561")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_onCancelClicked;

		// Token: 0x04020562 RID: 132450
		[Token(Token = "0x4020562")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_onConfirmClicked;

		// Token: 0x04020563 RID: 132451
		[Token(Token = "0x4020563")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_onConfirmClicked;

		// Token: 0x04020564 RID: 132452
		[Token(Token = "0x4020564")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_onBackPressed;

		// Token: 0x04020565 RID: 132453
		[Token(Token = "0x4020565")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_onBackPressed;

		// Token: 0x04020566 RID: 132454
		[Token(Token = "0x4020566")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020567 RID: 132455
		[Token(Token = "0x4020567")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnCancelBtnClicked;

		// Token: 0x04020568 RID: 132456
		[Token(Token = "0x4020568")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClicked;

		// Token: 0x04020569 RID: 132457
		[Token(Token = "0x4020569")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnBackPressed;

		// Token: 0x0402056A RID: 132458
		[Token(Token = "0x402056A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402056B RID: 132459
		[Token(Token = "0x402056B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__RenderThemeStyle;

		// Token: 0x0402056C RID: 132460
		[Token(Token = "0x402056C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__RenderConfirmStyle;

		// Token: 0x0402056D RID: 132461
		[Token(Token = "0x402056D")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__RenderIcon;

		// Token: 0x0402056E RID: 132462
		[Token(Token = "0x402056E")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__SetColorForGraphicItems;

		// Token: 0x0402056F RID: 132463
		[Token(Token = "0x402056F")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004137 RID: 16695
		[Token(Token = "0x2004137")]
		public struct RenderParam
		{
			// Token: 0x04020570 RID: 132464
			[Token(Token = "0x4020570")]
			[FieldOffset(Offset = "0x0")]
			public string iconId;

			// Token: 0x04020571 RID: 132465
			[Token(Token = "0x4020571")]
			[FieldOffset(Offset = "0x8")]
			public Sprite iconSprite;

			// Token: 0x04020572 RID: 132466
			[Token(Token = "0x4020572")]
			[FieldOffset(Offset = "0x10")]
			public UIAssetLoader.Assets assetLoader;

			// Token: 0x04020573 RID: 132467
			[Token(Token = "0x4020573")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2ConfirmDialogDecoViewBase dialogDecoViewPrefab;

			// Token: 0x04020574 RID: 132468
			[Token(Token = "0x4020574")]
			[FieldOffset(Offset = "0x20")]
			public object dialogDecoViewParam;

			// Token: 0x04020575 RID: 132469
			[Token(Token = "0x4020575")]
			[FieldOffset(Offset = "0x28")]
			public SandboxV2ConfirmDialogThemeType themeType;

			// Token: 0x04020576 RID: 132470
			[Token(Token = "0x4020576")]
			[FieldOffset(Offset = "0x2C")]
			public SandboxV2ConfirmDialogConfirmVisualType confirmVisualType;

			// Token: 0x04020577 RID: 132471
			[Token(Token = "0x4020577")]
			[FieldOffset(Offset = "0x30")]
			public SandboxV2ConfirmDialogConfirmAudioType confirmAudioType;

			// Token: 0x04020578 RID: 132472
			[Token(Token = "0x4020578")]
			[FieldOffset(Offset = "0x38")]
			public string titleStr;

			// Token: 0x04020579 RID: 132473
			[Token(Token = "0x4020579")]
			[FieldOffset(Offset = "0x40")]
			public string descStr;

			// Token: 0x0402057A RID: 132474
			[Token(Token = "0x402057A")]
			[FieldOffset(Offset = "0x48")]
			public string confirmStr;

			// Token: 0x0402057B RID: 132475
			[Token(Token = "0x402057B")]
			[FieldOffset(Offset = "0x50")]
			public string cancalStr;
		}
	}
}
