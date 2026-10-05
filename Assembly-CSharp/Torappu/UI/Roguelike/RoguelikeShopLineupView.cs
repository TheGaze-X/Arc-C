using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005509 RID: 21769
	[Token(Token = "0x2005509")]
	public class RoguelikeShopLineupView : DataBinder<RoguelikeGameShopGoodsProperty>, IRoguelikeGameShopVisibility
	{
		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x06020046 RID: 131142 RVA: 0x000B4408 File Offset: 0x000B2608
		[Token(Token = "0x17004B1A")]
		public RoguelikeShopLineupView.LineupLayer layer
		{
			[Token(Token = "0x6020046")]
			[Address(RVA = "0x1A249C0", Offset = "0x1A235C0", VA = "0x181A249C0")]
			get
			{
				return RoguelikeShopLineupView.LineupLayer.BUY;
			}
		}

		// Token: 0x06020047 RID: 131143 RVA: 0x000B4420 File Offset: 0x000B2620
		[Token(Token = "0x6020047")]
		[Address(RVA = "0x1A244D0", Offset = "0x1A230D0", VA = "0x181A244D0", Slot = "9")]
		public RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x06020048 RID: 131144 RVA: 0x000B4438 File Offset: 0x000B2638
		[Token(Token = "0x6020048")]
		[Address(RVA = "0x1A24460", Offset = "0x1A23060", VA = "0x181A24460", Slot = "10")]
		public RoguelikeGameShopStatusEnum GetRivalStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x06020049 RID: 131145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020049")]
		[Address(RVA = "0x1A245C0", Offset = "0x1A231C0", VA = "0x181A245C0", Slot = "7")]
		public override void OnValueChanged(RoguelikeGameShopGoodsProperty property)
		{
		}

		// Token: 0x0602004A RID: 131146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602004A")]
		[Address(RVA = "0x1A24550", Offset = "0x1A23150", VA = "0x181A24550")]
		public void Init()
		{
		}

		// Token: 0x0602004B RID: 131147 RVA: 0x000B4450 File Offset: 0x000B2650
		[Token(Token = "0x602004B")]
		[Address(RVA = "0x1A246A0", Offset = "0x1A232A0", VA = "0x181A246A0", Slot = "8")]
		public float SetShow(bool isShow, bool fastMode, RoguelikeGameShopStatusEnum current)
		{
			return 0f;
		}

		// Token: 0x0602004C RID: 131148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602004C")]
		[Address(RVA = "0x1A24360", Offset = "0x1A22F60", VA = "0x181A24360")]
		public void BindShopController(RoguelikeShopLineupControllerBindings bindings)
		{
		}

		// Token: 0x0602004D RID: 131149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602004D")]
		[Address(RVA = "0x1A24950", Offset = "0x1A23550", VA = "0x181A24950")]
		public RoguelikeShopLineupView()
		{
		}

		// Token: 0x0402B397 RID: 177047
		[Token(Token = "0x402B397")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeShopLineupView.LineupLayer _layer;

		// Token: 0x0402B398 RID: 177048
		[Token(Token = "0x402B398")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x0402B399 RID: 177049
		[Token(Token = "0x402B399")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LoopVerticalScrollRect _loopScrollRect;

		// Token: 0x0402B39A RID: 177050
		[Token(Token = "0x402B39A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeShopGoodsLoopAdapter _goodsLoopAdapter;

		// Token: 0x0402B39B RID: 177051
		[Token(Token = "0x402B39B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeShopLineupAddonView _addonView;

		// Token: 0x0402B39C RID: 177052
		[Token(Token = "0x402B39C")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402B39D RID: 177053
		[Token(Token = "0x402B39D")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeShopLineupControllerBindings m_controllerBindings;

		// Token: 0x0402B39E RID: 177054
		[Token(Token = "0x402B39E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layer;

		// Token: 0x0402B39F RID: 177055
		[Token(Token = "0x402B39F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShopStatus;

		// Token: 0x0402B3A0 RID: 177056
		[Token(Token = "0x402B3A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRivalStatus;

		// Token: 0x0402B3A1 RID: 177057
		[Token(Token = "0x402B3A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B3A2 RID: 177058
		[Token(Token = "0x402B3A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402B3A3 RID: 177059
		[Token(Token = "0x402B3A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402B3A4 RID: 177060
		[Token(Token = "0x402B3A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B3A5 RID: 177061
		[Token(Token = "0x402B3A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200550A RID: 21770
		[Token(Token = "0x200550A")]
		public enum LineupLayer
		{
			// Token: 0x0402B3A7 RID: 177063
			[Token(Token = "0x402B3A7")]
			BUY,
			// Token: 0x0402B3A8 RID: 177064
			[Token(Token = "0x402B3A8")]
			RECYCLE
		}
	}
}
