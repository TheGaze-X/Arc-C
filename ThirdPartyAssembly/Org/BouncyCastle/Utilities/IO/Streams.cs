using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public sealed class Streams
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Streams()
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x546A060", Offset = "0x5468C60", VA = "0x18546A060")]
		public static void Drain(Stream inStr)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x546A500", Offset = "0x5469100", VA = "0x18546A500")]
		public static byte[] ReadAll(Stream inStr)
		{
			return null;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x546A350", Offset = "0x5468F50", VA = "0x18546A350")]
		public static byte[] ReadAllLimited(Stream inStr, int limit)
		{
			return null;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x546A700", Offset = "0x5469300", VA = "0x18546A700")]
		public static int ReadFully(Stream inStr, byte[] buf)
		{
			return 0;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x546A650", Offset = "0x5469250", VA = "0x18546A650")]
		public static int ReadFully(Stream inStr, byte[] buf, int off, int len)
		{
			return 0;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x546A250", Offset = "0x5468E50", VA = "0x18546A250")]
		public static void PipeAll(Stream inStr, Stream outStr)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x546A100", Offset = "0x5468D00", VA = "0x18546A100")]
		public static long PipeAllLimited(Stream inStr, long limit, Stream outStr)
		{
			return 0L;
		}

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		private const int BufferSize = 512;
	}
}
