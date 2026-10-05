using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055D0 RID: 21968
	[Token(Token = "0x20055D0")]
	public class RL05FocusRollNodePlugin : RoguelikeFocusPlugin
	{
		// Token: 0x060203FF RID: 132095 RVA: 0x000B50C8 File Offset: 0x000B32C8
		[Token(Token = "0x60203FF")]
		[Address(RVA = "0x1A5F630", Offset = "0x1A5E230", VA = "0x181A5F630", Slot = "4")]
		public override bool Render(RoguelikeFocusViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06020400 RID: 132096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020400")]
		[Address(RVA = "0x1A5F780", Offset = "0x1A5E380", VA = "0x181A5F780")]
		public RL05FocusRollNodePlugin()
		{
		}

		// Token: 0x0402B9E8 RID: 178664
		[Token(Token = "0x402B9E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelRoll;

		// Token: 0x0402B9E9 RID: 178665
		[Token(Token = "0x402B9E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B9EA RID: 178666
		[Token(Token = "0x402B9EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
