using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E33 RID: 3635
	[Token(Token = "0x2000E33")]
	public class ActMainSSData
	{
		// Token: 0x06006B08 RID: 27400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B08")]
		[Address(RVA = "0x1FF9D40", Offset = "0x1FF8940", VA = "0x181FF9D40")]
		public ActMainSSData()
		{
		}

		// Token: 0x04004B9E RID: 19358
		[Token(Token = "0x4004B9E")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActMainSSZoneAdditionData> zoneAdditionDataMap;
	}
}
