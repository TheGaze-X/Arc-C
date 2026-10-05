using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x0200467E RID: 18046
	[Token(Token = "0x200467E")]
	public class RoguelikeTopicEndingSPOperatorGrowInfoItemViewModel
	{
		// Token: 0x0601B66C RID: 112236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B66C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicEndingSPOperatorGrowInfoItemViewModel()
		{
		}

		// Token: 0x040236BE RID: 145086
		[Token(Token = "0x40236BE")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicEndingSPOperatorGrowInfoItemViewModel.GrowInfoType type;

		// Token: 0x040236BF RID: 145087
		[Token(Token = "0x40236BF")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x0200467F RID: 18047
		[Token(Token = "0x200467F")]
		public enum GrowInfoType
		{
			// Token: 0x040236C1 RID: 145089
			[Token(Token = "0x40236C1")]
			NODE_ACTIVE,
			// Token: 0x040236C2 RID: 145090
			[Token(Token = "0x40236C2")]
			EVOLVE_UNLOCK,
			// Token: 0x040236C3 RID: 145091
			[Token(Token = "0x40236C3")]
			EVOLVE_ACTIVE
		}
	}
}
