using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x20002B5")]
	internal static class NclUtilities
	{
		// Token: 0x06001355 RID: 4949 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x51B1CD0", Offset = "0x51B08D0", VA = "0x1851B1CD0")]
		internal static bool IsFatal(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x51B1C40", Offset = "0x51B0840", VA = "0x1851B1C40")]
		internal static bool IsAddressLocal(IPAddress ipAddress)
		{
			return default(bool);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001357")]
		[Address(RVA = "0x51B1C20", Offset = "0x51B0820", VA = "0x1851B1C20")]
		private static IPHostEntry GetLocalHost()
		{
			return null;
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000407")]
		internal static IPAddress[] LocalAddresses
		{
			[Token(Token = "0x6001358")]
			[Address(RVA = "0x51B1E50", Offset = "0x51B0A50", VA = "0x1851B1E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000408")]
		private static object LocalAddressesLock
		{
			[Token(Token = "0x6001359")]
			[Address(RVA = "0x51B1DA0", Offset = "0x51B09A0", VA = "0x1851B1DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x0")]
		private static IPAddress[] _LocalAddresses;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x8")]
		private static object _LocalAddressesLock;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x10")]
		internal static string _LocalDomainName;
	}
}
