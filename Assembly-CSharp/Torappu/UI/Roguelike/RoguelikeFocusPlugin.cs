using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200526A RID: 21098
	[Token(Token = "0x200526A")]
	public abstract class RoguelikeFocusPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F214 RID: 127508
		[Token(Token = "0x601F214")]
		public abstract bool Render(RoguelikeFocusViewModel viewModel);

		// Token: 0x0601F215 RID: 127509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F215")]
		[Address(RVA = "0x18D7A20", Offset = "0x18D6620", VA = "0x1818D7A20")]
		protected RoguelikeFocusPlugin()
		{
		}

		// Token: 0x04029C51 RID: 171089
		[Token(Token = "0x4029C51")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public RoguelikeFocusView closure;

		// Token: 0x04029C52 RID: 171090
		[Token(Token = "0x4029C52")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public UIPage uipage;

		// Token: 0x04029C53 RID: 171091
		[Token(Token = "0x4029C53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
