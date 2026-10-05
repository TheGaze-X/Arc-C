using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005497 RID: 21655
	[Token(Token = "0x2005497")]
	public class RoguelikeCharCommonUpgradeView : RoguelikeCharUpgradeViewBase
	{
		// Token: 0x0601FDE8 RID: 130536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDE8")]
		[Address(RVA = "0x19EFC90", Offset = "0x19EE890", VA = "0x1819EFC90", Slot = "4")]
		public override void Render(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FDE9 RID: 130537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDE9")]
		[Address(RVA = "0x19EFDC0", Offset = "0x19EE9C0", VA = "0x1819EFDC0")]
		public RoguelikeCharCommonUpgradeView()
		{
		}

		// Token: 0x0402AF1E RID: 175902
		[Token(Token = "0x402AF1E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelUpgrade;

		// Token: 0x0402AF1F RID: 175903
		[Token(Token = "0x402AF1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelAlreadyUpgrade;

		// Token: 0x0402AF20 RID: 175904
		[Token(Token = "0x402AF20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AF21 RID: 175905
		[Token(Token = "0x402AF21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
