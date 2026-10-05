using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200216E RID: 8558
	[Token(Token = "0x200216E")]
	[Serializable]
	public class BakedSpineData
	{
		// Token: 0x0600D2D1 RID: 53969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2D1")]
		[Address(RVA = "0x3532EE0", Offset = "0x3531AE0", VA = "0x183532EE0")]
		public BakedSpineData()
		{
		}

		// Token: 0x0400E1D5 RID: 57813
		[Token(Token = "0x400E1D5")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, BakedAnimData> bakedAnimDatas;
	}
}
