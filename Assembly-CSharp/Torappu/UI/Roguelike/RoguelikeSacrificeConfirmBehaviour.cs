using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005459 RID: 21593
	[Token(Token = "0x2005459")]
	public class RoguelikeSacrificeConfirmBehaviour
	{
		// Token: 0x17004A7C RID: 19068
		// (get) Token: 0x0601FC90 RID: 130192 RVA: 0x000B32C8 File Offset: 0x000B14C8
		[Token(Token = "0x17004A7C")]
		protected virtual bool doEmptyBack
		{
			[Token(Token = "0x601FC90")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601FC91 RID: 130193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC91")]
		[Address(RVA = "0x19F7A30", Offset = "0x19F6630", VA = "0x1819F7A30", Slot = "5")]
		public virtual void OnConfirmClick(RoguelikeSacrificeViewModel model, Action<string> confirmServiceAction)
		{
		}

		// Token: 0x0601FC92 RID: 130194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC92")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeSacrificeConfirmBehaviour()
		{
		}
	}
}
