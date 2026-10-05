using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001361 RID: 4961
	[Token(Token = "0x2001361")]
	[Serializable]
	public class WeeklyForceOpenTable
	{
		// Token: 0x0600732A RID: 29482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WeeklyForceOpenTable()
		{
		}

		// Token: 0x04006E1A RID: 28186
		[Token(Token = "0x4006E1A")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006E1B RID: 28187
		[Token(Token = "0x4006E1B")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x04006E1C RID: 28188
		[Token(Token = "0x4006E1C")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x04006E1D RID: 28189
		[Token(Token = "0x4006E1D")]
		[FieldOffset(Offset = "0x28")]
		public List<string> forceOpenList;
	}
}
