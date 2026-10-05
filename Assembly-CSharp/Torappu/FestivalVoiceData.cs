using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F88 RID: 3976
	[Token(Token = "0x2000F88")]
	public class FestivalVoiceData
	{
		// Token: 0x06006CC9 RID: 27849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FestivalVoiceData()
		{
		}

		// Token: 0x0400547D RID: 21629
		[Token(Token = "0x400547D")]
		[FieldOffset(Offset = "0x10")]
		public CharWordShowType showType;

		// Token: 0x0400547E RID: 21630
		[Token(Token = "0x400547E")]
		[FieldOffset(Offset = "0x18")]
		public List<FestivalTimeData> timeData;
	}
}
