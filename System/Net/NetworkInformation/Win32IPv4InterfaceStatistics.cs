using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	internal class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
	{
		// Token: 0x0600188E RID: 6286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x50B8380", Offset = "0x50B6F80", VA = "0x1850B8380")]
		public Win32IPv4InterfaceStatistics(Win32_MIB_IFROW info)
		{
		}

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x10")]
		private Win32_MIB_IFROW info;
	}
}
