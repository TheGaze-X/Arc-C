using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E4D RID: 3661
	[Token(Token = "0x2000E4D")]
	public class ActMultiV3DiffStarRewardData
	{
		// Token: 0x06006B1B RID: 27419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3DiffStarRewardData()
		{
		}

		// Token: 0x04004C3B RID: 19515
		[Token(Token = "0x4004C3B")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3MapDiffType diffType;

		// Token: 0x04004C3C RID: 19516
		[Token(Token = "0x4004C3C")]
		[FieldOffset(Offset = "0x18")]
		public List<ActMultiV3StarRewardData> starRewardDatas;
	}
}
