using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005455 RID: 21589
	[Token(Token = "0x2005455")]
	public abstract class RoguelikeSacrificeListItemPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FC88 RID: 130184
		[Token(Token = "0x601FC88")]
		public abstract void Render(IRoguelikeSacrifice data);

		// Token: 0x0601FC89 RID: 130185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC89")]
		[Address(RVA = "0x196E370", Offset = "0x196CF70", VA = "0x18196E370")]
		protected RoguelikeSacrificeListItemPlugin()
		{
		}

		// Token: 0x0402AD33 RID: 175411
		[Token(Token = "0x402AD33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
