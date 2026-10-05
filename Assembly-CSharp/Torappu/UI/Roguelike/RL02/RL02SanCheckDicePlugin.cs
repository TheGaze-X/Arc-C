using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005740 RID: 22336
	[Token(Token = "0x2005740")]
	internal class RL02SanCheckDicePlugin : RoguelikeDicePlugin
	{
		// Token: 0x06020BB5 RID: 134069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BB5")]
		[Address(RVA = "0x1B0BEC0", Offset = "0x1B0AAC0", VA = "0x181B0BEC0", Slot = "8")]
		protected override void OnRefresh()
		{
		}

		// Token: 0x06020BB6 RID: 134070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BB6")]
		[Address(RVA = "0x1B0BFD0", Offset = "0x1B0ABD0", VA = "0x181B0BFD0")]
		public RL02SanCheckDicePlugin()
		{
		}

		// Token: 0x0402C6F6 RID: 182006
		[Token(Token = "0x402C6F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _sanNum;

		// Token: 0x0402C6F7 RID: 182007
		[Token(Token = "0x402C6F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x0402C6F8 RID: 182008
		[Token(Token = "0x402C6F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
