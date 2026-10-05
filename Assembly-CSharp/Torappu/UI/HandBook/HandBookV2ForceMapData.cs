using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066CD RID: 26317
	[Token(Token = "0x20066CD")]
	[Serializable]
	public class HandBookV2ForceMapData
	{
		// Token: 0x06025C8B RID: 154763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C8B")]
		[Address(RVA = "0x20C0070", Offset = "0x20BEC70", VA = "0x1820C0070")]
		public HandBookV2ForceMapData()
		{
		}

		// Token: 0x040351DE RID: 217566
		[Token(Token = "0x40351DE")]
		[FieldOffset(Offset = "0x10")]
		public List<HandBookV2ForceData> forceList;

		// Token: 0x040351DF RID: 217567
		[Token(Token = "0x40351DF")]
		[FieldOffset(Offset = "0x18")]
		public List<HandBookV2ForceLineData> forceLineList;

		// Token: 0x040351E0 RID: 217568
		[Token(Token = "0x40351E0")]
		[FieldOffset(Offset = "0x20")]
		public List<HandBookV2PointLineData> pointLineList;
	}
}
