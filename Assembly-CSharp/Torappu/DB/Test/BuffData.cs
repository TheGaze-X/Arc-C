using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.DB.Test
{
	// Token: 0x020016BA RID: 5818
	[Token(Token = "0x20016BA")]
	[Serializable]
	public class BuffData
	{
		// Token: 0x06009332 RID: 37682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009332")]
		[Address(RVA = "0x2B28450", Offset = "0x2B27050", VA = "0x182B28450")]
		public BuffData()
		{
		}

		// Token: 0x040088DD RID: 35037
		[Token(Token = "0x40088DD")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x040088DE RID: 35038
		[Token(Token = "0x40088DE")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> paramValues;
	}
}
