using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200560A RID: 22026
	[Token(Token = "0x200560A")]
	public class RL05RoguelikeMenuButtonPlugin : RoguelikeMenuButtonPluginBase
	{
		// Token: 0x06020525 RID: 132389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020525")]
		[Address(RVA = "0x1A6F120", Offset = "0x1A6DD20", VA = "0x181A6F120", Slot = "7")]
		public override void RenderPlugin(RoguelikeMenuButtonPluginBase.Input config)
		{
		}

		// Token: 0x06020526 RID: 132390 RVA: 0x000B5620 File Offset: 0x000B3820
		[Token(Token = "0x6020526")]
		[Address(RVA = "0x1A6F3A0", Offset = "0x1A6DFA0", VA = "0x181A6F3A0")]
		private RL05RoguelikeMenuButtonTheme.MenuButtonType _GetAvailPanelIndex(RoguelikeMenuButtonPluginBase.Input config)
		{
			return RL05RoguelikeMenuButtonTheme.MenuButtonType.RECRUIT_COMMON;
		}

		// Token: 0x06020527 RID: 132391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020527")]
		[Address(RVA = "0x1A6F4D0", Offset = "0x1A6E0D0", VA = "0x181A6F4D0")]
		private void _ShowPanel(RL05RoguelikeMenuButtonTheme.MenuButtonType targetShowType)
		{
		}

		// Token: 0x06020528 RID: 132392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020528")]
		[Address(RVA = "0x1A6F630", Offset = "0x1A6E230", VA = "0x181A6F630")]
		public RL05RoguelikeMenuButtonPlugin()
		{
		}

		// Token: 0x0402BBF5 RID: 179189
		[Token(Token = "0x402BBF5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RL05RoguelikeMenuButtonTheme[] _buttonConfigs;

		// Token: 0x0402BBF6 RID: 179190
		[Token(Token = "0x402BBF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderPlugin;

		// Token: 0x0402BBF7 RID: 179191
		[Token(Token = "0x402BBF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetAvailPanelIndex;

		// Token: 0x0402BBF8 RID: 179192
		[Token(Token = "0x402BBF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowPanel;

		// Token: 0x0402BBF9 RID: 179193
		[Token(Token = "0x402BBF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
