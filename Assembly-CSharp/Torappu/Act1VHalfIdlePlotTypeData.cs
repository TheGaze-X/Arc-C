using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C8E RID: 3214
	[Token(Token = "0x2000C8E")]
	public class Act1VHalfIdlePlotTypeData
	{
		// Token: 0x06006969 RID: 26985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006969")]
		[Address(RVA = "0x1FF3F30", Offset = "0x1FF2B30", VA = "0x181FF3F30")]
		public Act1VHalfIdlePlotTypeData()
		{
		}

		// Token: 0x040041A1 RID: 16801
		[Token(Token = "0x40041A1")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdlePlotType plotType;

		// Token: 0x040041A2 RID: 16802
		[Token(Token = "0x40041A2")]
		[FieldOffset(Offset = "0x18")]
		public string typeName;

		// Token: 0x040041A3 RID: 16803
		[Token(Token = "0x40041A3")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, List<int>> plotSquadLimit;
	}
}
