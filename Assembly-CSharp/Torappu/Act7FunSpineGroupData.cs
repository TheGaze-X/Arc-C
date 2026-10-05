using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EC8 RID: 3784
	[Token(Token = "0x2000EC8")]
	public class Act7FunSpineGroupData
	{
		// Token: 0x06006B98 RID: 27544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B98")]
		[Address(RVA = "0x1FF7C60", Offset = "0x1FF6860", VA = "0x181FF7C60")]
		public Act7FunSpineGroupData()
		{
		}

		// Token: 0x04004FF7 RID: 20471
		[Token(Token = "0x4004FF7")]
		[FieldOffset(Offset = "0x10")]
		public string spineGroupId;

		// Token: 0x04004FF8 RID: 20472
		[Token(Token = "0x4004FF8")]
		[FieldOffset(Offset = "0x18")]
		public List<Act7FunSpineHolderData> holderData;
	}
}
