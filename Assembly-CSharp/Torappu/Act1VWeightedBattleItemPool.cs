using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CA8 RID: 3240
	[Token(Token = "0x2000CA8")]
	public class Act1VWeightedBattleItemPool : IItemWithWeight
	{
		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06006985 RID: 27013 RVA: 0x00030D80 File Offset: 0x0002EF80
		[Token(Token = "0x17000CFC")]
		private float weightValue
		{
			[Token(Token = "0x6006985")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006986")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VWeightedBattleItemPool()
		{
		}

		// Token: 0x0400422B RID: 16939
		[Token(Token = "0x400422B")]
		[FieldOffset(Offset = "0x10")]
		public string poolKey;

		// Token: 0x0400422C RID: 16940
		[Token(Token = "0x400422C")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleBattleItemType type;

		// Token: 0x0400422D RID: 16941
		[Token(Token = "0x400422D")]
		[FieldOffset(Offset = "0x1C")]
		public float weight;
	}
}
