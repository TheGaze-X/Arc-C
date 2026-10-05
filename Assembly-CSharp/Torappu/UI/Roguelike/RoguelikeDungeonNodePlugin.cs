using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200525E RID: 21086
	[Token(Token = "0x200525E")]
	[Serializable]
	public abstract class RoguelikeDungeonNodePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F18D RID: 127373
		[Token(Token = "0x601F18D")]
		public abstract void Render(RoguelikeDungeonNode node);

		// Token: 0x0601F18E RID: 127374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F18E")]
		[Address(RVA = "0x18D0400", Offset = "0x18CF000", VA = "0x1818D0400")]
		protected RoguelikeDungeonNodePlugin()
		{
		}

		// Token: 0x04029B7C RID: 170876
		[Token(Token = "0x4029B7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
