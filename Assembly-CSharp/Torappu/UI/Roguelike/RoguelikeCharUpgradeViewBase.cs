using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005496 RID: 21654
	[Token(Token = "0x2005496")]
	public abstract class RoguelikeCharUpgradeViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FDE6 RID: 130534
		[Token(Token = "0x601FDE6")]
		public abstract void Render(RoguelikeCharCardViewModel viewModel);

		// Token: 0x0601FDE7 RID: 130535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDE7")]
		[Address(RVA = "0x19F79D0", Offset = "0x19F65D0", VA = "0x1819F79D0")]
		protected RoguelikeCharUpgradeViewBase()
		{
		}

		// Token: 0x0402AF1D RID: 175901
		[Token(Token = "0x402AF1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
