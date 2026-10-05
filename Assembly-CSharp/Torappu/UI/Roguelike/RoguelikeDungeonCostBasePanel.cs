using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005257 RID: 21079
	[Token(Token = "0x2005257")]
	public abstract class RoguelikeDungeonCostBasePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F16E RID: 127342
		[Token(Token = "0x601F16E")]
		public abstract void HandleOnOpenCost(UIPage page, RoguelikeDungeonCostSingleton.Config config);

		// Token: 0x0601F16F RID: 127343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F16F")]
		[Address(RVA = "0x18C9370", Offset = "0x18C7F70", VA = "0x1818C9370")]
		protected RoguelikeDungeonCostBasePanel()
		{
		}

		// Token: 0x04029B42 RID: 170818
		[Token(Token = "0x4029B42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
