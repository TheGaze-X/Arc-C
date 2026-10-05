using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CA9 RID: 3241
	[Token(Token = "0x2000CA9")]
	public class Act1VHalfIdleWeightedBattleEquip : IItemWithWeight
	{
		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06006987 RID: 27015 RVA: 0x00030D98 File Offset: 0x0002EF98
		[Token(Token = "0x17000CFD")]
		private float weightValue
		{
			[Token(Token = "0x6006987")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006988")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleWeightedBattleEquip()
		{
		}

		// Token: 0x0400422E RID: 16942
		[Token(Token = "0x400422E")]
		[FieldOffset(Offset = "0x10")]
		public float weight;

		// Token: 0x0400422F RID: 16943
		[Token(Token = "0x400422F")]
		[FieldOffset(Offset = "0x18")]
		public string equipId;

		// Token: 0x04004230 RID: 16944
		[Token(Token = "0x4004230")]
		[FieldOffset(Offset = "0x20")]
		public int level;

		// Token: 0x04004231 RID: 16945
		[Token(Token = "0x4004231")]
		[FieldOffset(Offset = "0x28")]
		public string alias;
	}
}
