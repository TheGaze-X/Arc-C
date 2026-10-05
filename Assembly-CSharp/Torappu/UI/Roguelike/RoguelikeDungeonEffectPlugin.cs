using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200525B RID: 21083
	[Token(Token = "0x200525B")]
	public abstract class RoguelikeDungeonEffectPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F17B RID: 127355
		[Token(Token = "0x601F17B")]
		public abstract void RenderView(RoguelikeFocusViewModel viewModel);

		// Token: 0x0601F17C RID: 127356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F17C")]
		[Address(RVA = "0x18CA970", Offset = "0x18C9570", VA = "0x1818CA970")]
		protected RoguelikeDungeonEffectPlugin()
		{
		}

		// Token: 0x04029B64 RID: 170852
		[Token(Token = "0x4029B64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
