using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200108A RID: 4234
	[Token(Token = "0x200108A")]
	public class HalfIdleWeightedBattleTrap : IItemWithWeight
	{
		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06006E18 RID: 28184 RVA: 0x00031F38 File Offset: 0x00030138
		[Token(Token = "0x17000D1F")]
		private float weightValue
		{
			[Token(Token = "0x6006E18")]
			[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E19")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HalfIdleWeightedBattleTrap()
		{
		}

		// Token: 0x04005A58 RID: 23128
		[Token(Token = "0x4005A58")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x04005A59 RID: 23129
		[Token(Token = "0x4005A59")]
		[FieldOffset(Offset = "0x18")]
		public float weight;
	}
}
