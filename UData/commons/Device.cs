using System;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	internal class Device
	{
		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Device()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x55C85F0", Offset = "0x55C71F0", VA = "0x1855C85F0")]
		private static string GetMacAddress()
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x55C8420", Offset = "0x55C7020", VA = "0x1855C8420")]
		public static string GetDeviceID()
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x55C8720", Offset = "0x55C7320", VA = "0x1855C8720")]
		public static ValueTuple<string, string, string> GetSystemInfo()
		{
			return default(ValueTuple<string, string, string>);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x55C8330", Offset = "0x55C6F30", VA = "0x1855C8330")]
		public static string GetClickCode()
		{
			return null;
		}
	}
}
