using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200550D RID: 21773
	[Token(Token = "0x200550D")]
	public class RoguelikeShopNormalView : DataBinder<RoguelikeGameShopGoodsProperty>, IRoguelikeGameShopVisibility
	{
		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x06020056 RID: 131158 RVA: 0x000B4468 File Offset: 0x000B2668
		[Token(Token = "0x17004B1D")]
		public bool isReady
		{
			[Token(Token = "0x6020056")]
			[Address(RVA = "0x1A25750", Offset = "0x1A24350", VA = "0x181A25750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020057 RID: 131159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020057")]
		[Address(RVA = "0x1A25050", Offset = "0x1A23C50", VA = "0x181A25050")]
		public void OnSwitchEvent()
		{
		}

		// Token: 0x06020058 RID: 131160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020058")]
		[Address(RVA = "0x1A24E60", Offset = "0x1A23A60", VA = "0x181A24E60")]
		public void OnBtnConfirmLeaveShow()
		{
		}

		// Token: 0x06020059 RID: 131161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020059")]
		[Address(RVA = "0x1A24DD0", Offset = "0x1A239D0", VA = "0x181A24DD0")]
		public void OnBtnConfirmLeaveHide()
		{
		}

		// Token: 0x0602005A RID: 131162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602005A")]
		[Address(RVA = "0x1A24FA0", Offset = "0x1A23BA0", VA = "0x181A24FA0")]
		public void OnLeaveShop()
		{
		}

		// Token: 0x0602005B RID: 131163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602005B")]
		[Address(RVA = "0x1A24EF0", Offset = "0x1A23AF0", VA = "0x181A24EF0")]
		public void OnDealerClick()
		{
		}

		// Token: 0x0602005C RID: 131164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602005C")]
		[Address(RVA = "0x1A24D10", Offset = "0x1A23910", VA = "0x181A24D10")]
		public void Init()
		{
		}

		// Token: 0x0602005D RID: 131165 RVA: 0x000B4480 File Offset: 0x000B2680
		[Token(Token = "0x602005D")]
		[Address(RVA = "0x1A251D0", Offset = "0x1A23DD0", VA = "0x181A251D0", Slot = "8")]
		public float SetShow(bool isShow, bool fastMode, RoguelikeGameShopStatusEnum current)
		{
			return 0f;
		}

		// Token: 0x0602005E RID: 131166 RVA: 0x000B4498 File Offset: 0x000B2698
		[Token(Token = "0x602005E")]
		[Address(RVA = "0x1A24CB0", Offset = "0x1A238B0", VA = "0x181A24CB0", Slot = "9")]
		public RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x0602005F RID: 131167 RVA: 0x000B44B0 File Offset: 0x000B26B0
		[Token(Token = "0x602005F")]
		[Address(RVA = "0x1A24C50", Offset = "0x1A23850", VA = "0x181A24C50", Slot = "10")]
		public RoguelikeGameShopStatusEnum GetRivalStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x06020060 RID: 131168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020060")]
		[Address(RVA = "0x1A25100", Offset = "0x1A23D00", VA = "0x181A25100", Slot = "7")]
		public override void OnValueChanged(RoguelikeGameShopGoodsProperty property)
		{
		}

		// Token: 0x06020061 RID: 131169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020061")]
		[Address(RVA = "0x1A24BD0", Offset = "0x1A237D0", VA = "0x181A24BD0")]
		public void BindShopController(RoguelikeShopNormalControllerBindings bindings)
		{
		}

		// Token: 0x06020062 RID: 131170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020062")]
		[Address(RVA = "0x1A25370", Offset = "0x1A23F70", VA = "0x181A25370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020063 RID: 131171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020063")]
		[Address(RVA = "0x1A256D0", Offset = "0x1A242D0", VA = "0x181A256D0")]
		public RoguelikeShopNormalView()
		{
		}

		// Token: 0x0402B3BC RID: 177084
		[Token(Token = "0x402B3BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x0402B3BD RID: 177085
		[Token(Token = "0x402B3BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0402B3BE RID: 177086
		[Token(Token = "0x402B3BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _switchPanel;

		// Token: 0x0402B3BF RID: 177087
		[Token(Token = "0x402B3BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _switchAnimationLocation;

		// Token: 0x0402B3C0 RID: 177088
		[Token(Token = "0x402B3C0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _leaveCanvasGroup;

		// Token: 0x0402B3C1 RID: 177089
		[Token(Token = "0x402B3C1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _confirmLeavePanelGo;

		// Token: 0x0402B3C2 RID: 177090
		[Token(Token = "0x402B3C2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _confirmBtnCanvasGroup;

		// Token: 0x0402B3C3 RID: 177091
		[Token(Token = "0x402B3C3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _confirmBtnRt;

		// Token: 0x0402B3C4 RID: 177092
		[Token(Token = "0x402B3C4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector2 _confirmBtnHidePos;

		// Token: 0x0402B3C5 RID: 177093
		[Token(Token = "0x402B3C5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector2 _confirmBtnShowPos;

		// Token: 0x0402B3C6 RID: 177094
		[Token(Token = "0x402B3C6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _btnBattleGo;

		// Token: 0x0402B3C7 RID: 177095
		[Token(Token = "0x402B3C7")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402B3C8 RID: 177096
		[Token(Token = "0x402B3C8")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_rootSwitchTween;

		// Token: 0x0402B3C9 RID: 177097
		[Token(Token = "0x402B3C9")]
		[FieldOffset(Offset = "0x90")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402B3CA RID: 177098
		[Token(Token = "0x402B3CA")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_leaveSwitchTween;

		// Token: 0x0402B3CB RID: 177099
		[Token(Token = "0x402B3CB")]
		[FieldOffset(Offset = "0xA0")]
		private FadeTranslationSwitchTween m_leaveConfirmSwitchTween;

		// Token: 0x0402B3CC RID: 177100
		[Token(Token = "0x402B3CC")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeShopNormalControllerBindings m_controllerBindings;

		// Token: 0x0402B3CD RID: 177101
		[Token(Token = "0x402B3CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x0402B3CE RID: 177102
		[Token(Token = "0x402B3CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSwitchEvent;

		// Token: 0x0402B3CF RID: 177103
		[Token(Token = "0x402B3CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnConfirmLeaveShow;

		// Token: 0x0402B3D0 RID: 177104
		[Token(Token = "0x402B3D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnConfirmLeaveHide;

		// Token: 0x0402B3D1 RID: 177105
		[Token(Token = "0x402B3D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnLeaveShop;

		// Token: 0x0402B3D2 RID: 177106
		[Token(Token = "0x402B3D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDealerClick;

		// Token: 0x0402B3D3 RID: 177107
		[Token(Token = "0x402B3D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402B3D4 RID: 177108
		[Token(Token = "0x402B3D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402B3D5 RID: 177109
		[Token(Token = "0x402B3D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetShopStatus;

		// Token: 0x0402B3D6 RID: 177110
		[Token(Token = "0x402B3D6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetRivalStatus;

		// Token: 0x0402B3D7 RID: 177111
		[Token(Token = "0x402B3D7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B3D8 RID: 177112
		[Token(Token = "0x402B3D8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B3D9 RID: 177113
		[Token(Token = "0x402B3D9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B3DA RID: 177114
		[Token(Token = "0x402B3DA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
