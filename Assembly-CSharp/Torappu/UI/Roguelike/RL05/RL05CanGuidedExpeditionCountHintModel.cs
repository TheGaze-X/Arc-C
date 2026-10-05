using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005575 RID: 21877
	[Token(Token = "0x2005575")]
	public class RL05CanGuidedExpeditionCountHintModel : RoguelikeChoiceExpeditionHintBaseModel
	{
		// Token: 0x17004B70 RID: 19312
		// (get) Token: 0x0602026A RID: 131690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B70")]
		protected override string expeditionHintFormat
		{
			[Token(Token = "0x602026A")]
			[Address(RVA = "0x1A31CC0", Offset = "0x1A308C0", VA = "0x181A31CC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602026B RID: 131691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602026B")]
		[Address(RVA = "0x1A31C60", Offset = "0x1A30860", VA = "0x181A31C60")]
		public RL05CanGuidedExpeditionCountHintModel()
		{
		}

		// Token: 0x0402B6D6 RID: 177878
		[Token(Token = "0x402B6D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_expeditionHintFormat;

		// Token: 0x0402B6D7 RID: 177879
		[Token(Token = "0x402B6D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
