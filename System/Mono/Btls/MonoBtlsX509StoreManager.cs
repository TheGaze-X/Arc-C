using System;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	internal static class MonoBtlsX509StoreManager
	{
		// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x50D85C0", Offset = "0x50D71C0", VA = "0x1850D85C0")]
		private static void Initialize()
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x50D8280", Offset = "0x50D6E80", VA = "0x1850D8280")]
		private static void DoInitialize()
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x50D8480", Offset = "0x50D7080", VA = "0x1850D8480")]
		public static string GetStorePath(MonoBtlsX509StoreType type)
		{
			return null;
		}

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x0")]
		private static bool initialized;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x8")]
		private static string machineTrustedRootPath;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x10")]
		private static string machineIntermediateCAPath;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x18")]
		private static string machineUntrustedPath;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x20")]
		private static string userTrustedRootPath;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x28")]
		private static string userIntermediateCAPath;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x30")]
		private static string userUntrustedPath;
	}
}
