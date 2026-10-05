using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E96 RID: 28310
	[Token(Token = "0x2006E96")]
	public class VecBreakV2SeasonAchvInfo
	{
		// Token: 0x060284B0 RID: 165040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284B0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VecBreakV2SeasonAchvInfo()
		{
		}

		// Token: 0x04039436 RID: 234550
		[Token(Token = "0x4039436")]
		[FieldOffset(Offset = "0x10")]
		public VecBreakV2SeasonBestRecordInfo bestRecord;

		// Token: 0x04039437 RID: 234551
		[Token(Token = "0x4039437")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, VecBreakV2StageInfo> stageInfo;
	}
}
