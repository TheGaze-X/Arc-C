using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FE3 RID: 4067
	[Token(Token = "0x2000FE3")]
	[Serializable]
	public class CrossDayTrackTypeData
	{
		// Token: 0x06006D39 RID: 27961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D39")]
		[Address(RVA = "0x2101820", Offset = "0x2100420", VA = "0x182101820")]
		public CrossDayTrackTypeData()
		{
		}

		// Token: 0x0400563A RID: 22074
		[Token(Token = "0x400563A")]
		[FieldOffset(Offset = "0x10")]
		public string type;

		// Token: 0x0400563B RID: 22075
		[Token(Token = "0x400563B")]
		[FieldOffset(Offset = "0x18")]
		public long startTs;

		// Token: 0x0400563C RID: 22076
		[Token(Token = "0x400563C")]
		[FieldOffset(Offset = "0x20")]
		public long expireTs;

		// Token: 0x0400563D RID: 22077
		[Token(Token = "0x400563D")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CrossDayTrackData> dataDict;
	}
}
