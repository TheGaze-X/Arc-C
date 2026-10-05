using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005601 RID: 22017
	[Token(Token = "0x2005601")]
	public class RL05SacrificeConfrimBehaviour : RoguelikeSacrificeConfirmBehaviour
	{
		// Token: 0x17004BAE RID: 19374
		// (get) Token: 0x06020504 RID: 132356 RVA: 0x000B5500 File Offset: 0x000B3700
		[Token(Token = "0x17004BAE")]
		protected override bool doEmptyBack
		{
			[Token(Token = "0x6020504")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020505 RID: 132357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020505")]
		[Address(RVA = "0x1A6F7B0", Offset = "0x1A6E3B0", VA = "0x181A6F7B0", Slot = "5")]
		public override void OnConfirmClick(RoguelikeSacrificeViewModel model, Action<string> confirmServiceAction)
		{
		}

		// Token: 0x06020506 RID: 132358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020506")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RL05SacrificeConfrimBehaviour()
		{
		}
	}
}
