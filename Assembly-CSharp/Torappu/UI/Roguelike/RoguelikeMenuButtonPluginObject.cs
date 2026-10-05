using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052F9 RID: 21241
	[Token(Token = "0x20052F9")]
	public class RoguelikeMenuButtonPluginObject : RoguelikeMenuObject<RoguelikeMenuCompViewModel>
	{
		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x0601F53F RID: 128319 RVA: 0x000B1870 File Offset: 0x000AFA70
		[Token(Token = "0x17004982")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F53F")]
			[Address(RVA = "0x190F6C0", Offset = "0x190E2C0", VA = "0x18190F6C0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F540 RID: 128320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F540")]
		[Address(RVA = "0x190F5C0", Offset = "0x190E1C0", VA = "0x18190F5C0")]
		private void _RenderShowStatus()
		{
		}

		// Token: 0x0601F541 RID: 128321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F541")]
		[Address(RVA = "0x190F100", Offset = "0x190DD00", VA = "0x18190F100", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x0601F542 RID: 128322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F542")]
		[Address(RVA = "0x190F240", Offset = "0x190DE40", VA = "0x18190F240", Slot = "7")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F543 RID: 128323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F543")]
		[Address(RVA = "0x190F2F0", Offset = "0x190DEF0", VA = "0x18190F2F0", Slot = "16")]
		public override void Render(RoguelikeMenuCompViewModel viewModel)
		{
		}

		// Token: 0x0601F544 RID: 128324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F544")]
		[Address(RVA = "0x190F370", Offset = "0x190DF70", VA = "0x18190F370")]
		private void _RefreshButtonPlugin(RoguelikeMenuAdapter adapter)
		{
		}

		// Token: 0x0601F545 RID: 128325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F545")]
		[Address(RVA = "0x190F650", Offset = "0x190E250", VA = "0x18190F650")]
		public RoguelikeMenuButtonPluginObject()
		{
		}

		// Token: 0x0601F546 RID: 128326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F546")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0601F547 RID: 128327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F547")]
		[Address(RVA = "0x190F360", Offset = "0x190DF60", VA = "0x18190F360")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0402A173 RID: 172403
		[Token(Token = "0x402A173")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _pluginContainer;

		// Token: 0x0402A174 RID: 172404
		[Token(Token = "0x402A174")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeMenuButtonPluginBase m_buttonPrefab;

		// Token: 0x0402A175 RID: 172405
		[Token(Token = "0x402A175")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeMenuButtonPluginBase m_buttonInst;

		// Token: 0x0402A176 RID: 172406
		[Token(Token = "0x402A176")]
		[FieldOffset(Offset = "0x40")]
		private bool m_showStateCondition;

		// Token: 0x0402A177 RID: 172407
		[Token(Token = "0x402A177")]
		[FieldOffset(Offset = "0x41")]
		private bool m_showDataCondition;

		// Token: 0x0402A178 RID: 172408
		[Token(Token = "0x402A178")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A179 RID: 172409
		[Token(Token = "0x402A179")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402A17A RID: 172410
		[Token(Token = "0x402A17A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402A17B RID: 172411
		[Token(Token = "0x402A17B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402A17C RID: 172412
		[Token(Token = "0x402A17C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A17D RID: 172413
		[Token(Token = "0x402A17D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshButtonPlugin;

		// Token: 0x0402A17E RID: 172414
		[Token(Token = "0x402A17E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
