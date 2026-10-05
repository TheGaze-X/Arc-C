using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200547D RID: 21629
	[Token(Token = "0x200547D")]
	public abstract class RoguelikeSelectCharConflictPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004AA6 RID: 19110
		// (get) Token: 0x0601FD58 RID: 130392
		[Token(Token = "0x17004AA6")]
		public abstract PanelType panelType { [Token(Token = "0x601FD58")] get; }

		// Token: 0x0601FD59 RID: 130393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD59")]
		[Address(RVA = "0x19FC5A0", Offset = "0x19FB1A0", VA = "0x1819FC5A0")]
		protected RoguelikeSelectCharConflictPanel()
		{
		}

		// Token: 0x0402AE25 RID: 175653
		[Token(Token = "0x402AE25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
