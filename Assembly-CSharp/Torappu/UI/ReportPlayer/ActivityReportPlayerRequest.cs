using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ReportPlayer
{
	// Token: 0x020046E3 RID: 18147
	[Token(Token = "0x20046E3")]
	public class ActivityReportPlayerRequest
	{
		// Token: 0x0601B829 RID: 112681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B829")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityReportPlayerRequest()
		{
		}

		// Token: 0x04023A36 RID: 145974
		[Token(Token = "0x4023A36")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04023A37 RID: 145975
		[Token(Token = "0x4023A37")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x04023A38 RID: 145976
		[Token(Token = "0x4023A38")]
		[FieldOffset(Offset = "0x20")]
		public List<string> reasons;
	}
}
