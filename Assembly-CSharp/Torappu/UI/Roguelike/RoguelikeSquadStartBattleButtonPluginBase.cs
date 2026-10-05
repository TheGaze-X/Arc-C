using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200551E RID: 21790
	[Token(Token = "0x200551E")]
	public abstract class RoguelikeSquadStartBattleButtonPluginBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x060200C0 RID: 131264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200C0")]
		[Address(RVA = "0x1A2A330", Offset = "0x1A28F30", VA = "0x181A2A330", Slot = "4")]
		public virtual void OnClickStartBattle()
		{
		}

		// Token: 0x060200C1 RID: 131265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200C1")]
		[Address(RVA = "0x1A2A390", Offset = "0x1A28F90", VA = "0x181A2A390", Slot = "5")]
		public virtual void Render(RoguelikeSquadStartBattleButtonPluginBase.Input config)
		{
		}

		// Token: 0x060200C2 RID: 131266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200C2")]
		[Address(RVA = "0x1A2A410", Offset = "0x1A29010", VA = "0x181A2A410")]
		protected RoguelikeSquadStartBattleButtonPluginBase()
		{
		}

		// Token: 0x0402B45B RID: 177243
		[Token(Token = "0x402B45B")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action onStartBattle;

		// Token: 0x0402B45C RID: 177244
		[Token(Token = "0x402B45C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickStartBattle;

		// Token: 0x0402B45D RID: 177245
		[Token(Token = "0x402B45D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B45E RID: 177246
		[Token(Token = "0x402B45E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200551F RID: 21791
		[Token(Token = "0x200551F")]
		public class Input
		{
			// Token: 0x060200C3 RID: 131267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60200C3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402B45F RID: 177247
			[Token(Token = "0x402B45F")]
			[FieldOffset(Offset = "0x10")]
			public Action onStartBattle;
		}
	}
}
