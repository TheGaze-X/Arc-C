using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055FE RID: 22014
	[Token(Token = "0x20055FE")]
	public class RL05SacrificeListItemPlugin : RoguelikeSacrificeListItemPlugin
	{
		// Token: 0x060204FA RID: 132346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204FA")]
		[Address(RVA = "0x1A6FA10", Offset = "0x1A6E610", VA = "0x181A6FA10", Slot = "4")]
		public override void Render(IRoguelikeSacrifice data)
		{
		}

		// Token: 0x060204FB RID: 132347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204FB")]
		[Address(RVA = "0x1A6FB90", Offset = "0x1A6E790", VA = "0x181A6FB90")]
		public RL05SacrificeListItemPlugin()
		{
		}

		// Token: 0x0402BBC5 RID: 179141
		[Token(Token = "0x402BBC5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _hasDrawnPanel;

		// Token: 0x0402BBC6 RID: 179142
		[Token(Token = "0x402BBC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BBC7 RID: 179143
		[Token(Token = "0x402BBC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
