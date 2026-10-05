using System;
using Il2CppDummyDll;

namespace UDatasdk
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class ReportEventRet : CommonRet
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReportEventRet()
		{
		}

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		public string R_DATA;
	}
}
