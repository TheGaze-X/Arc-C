using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B12 RID: 31506
	[Token(Token = "0x2007B12")]
	public class PlayerRelicHandBookData : RoguelikeItemData
	{
		// Token: 0x0602C1BC RID: 180668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1BC")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public PlayerRelicHandBookData()
		{
		}

		// Token: 0x0403FF32 RID: 261938
		[Token(Token = "0x403FF32")]
		[FieldOffset(Offset = "0x70")]
		public bool read;

		// Token: 0x0403FF33 RID: 261939
		[Token(Token = "0x403FF33")]
		[FieldOffset(Offset = "0x71")]
		public bool got;

		// Token: 0x0403FF34 RID: 261940
		[Token(Token = "0x403FF34")]
		[FieldOffset(Offset = "0x72")]
		public bool unlocked;

		// Token: 0x0403FF35 RID: 261941
		[Token(Token = "0x403FF35")]
		[FieldOffset(Offset = "0x74")]
		public int progress;
	}
}
