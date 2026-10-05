using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E98 RID: 28312
	[Token(Token = "0x2006E98")]
	public class VecBreakV2SeasonBestRecordInfo
	{
		// Token: 0x060284B2 RID: 165042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284B2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VecBreakV2SeasonBestRecordInfo()
		{
		}

		// Token: 0x0403943A RID: 234554
		[Token(Token = "0x403943A")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403943B RID: 234555
		[Token(Token = "0x403943B")]
		[FieldOffset(Offset = "0x18")]
		public List<string> buff;

		// Token: 0x0403943C RID: 234556
		[Token(Token = "0x403943C")]
		[FieldOffset(Offset = "0x20")]
		public long showTs;

		// Token: 0x0403943D RID: 234557
		[Token(Token = "0x403943D")]
		[FieldOffset(Offset = "0x28")]
		public List<VecBreakV2SeasonRecordCharInfo> squad;

		// Token: 0x0403943E RID: 234558
		[Token(Token = "0x403943E")]
		[FieldOffset(Offset = "0x30")]
		public VecBreakV2SeasonRecordCharInfo assistChar;
	}
}
