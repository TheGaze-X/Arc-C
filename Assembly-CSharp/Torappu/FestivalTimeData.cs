using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F87 RID: 3975
	[Token(Token = "0x2000F87")]
	public class FestivalTimeData
	{
		// Token: 0x06006CC8 RID: 27848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FestivalTimeData()
		{
		}

		// Token: 0x0400547B RID: 21627
		[Token(Token = "0x400547B")]
		[FieldOffset(Offset = "0x10")]
		public FestivalVoiceTimeType timeType;

		// Token: 0x0400547C RID: 21628
		[Token(Token = "0x400547C")]
		[FieldOffset(Offset = "0x18")]
		public FestivalTimeInterval interval;
	}
}
