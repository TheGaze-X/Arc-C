using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public sealed class StreamUtils
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x4A42BF0", Offset = "0x4A417F0", VA = "0x184A42BF0")]
		public static void ReadFully(Stream stream, byte[] buffer)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4A429B0", Offset = "0x4A415B0", VA = "0x184A429B0")]
		public static void ReadFully(Stream stream, byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4A42280", Offset = "0x4A40E80", VA = "0x184A42280")]
		public static void Copy(Stream source, Stream destination, byte[] buffer)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4A42230", Offset = "0x4A40E30", VA = "0x184A42230")]
		public static void Copy(Stream source, Stream destination, byte[] buffer, ProgressHandler progressHandler, TimeSpan updateInterval, object sender, string name)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4A424A0", Offset = "0x4A410A0", VA = "0x184A424A0")]
		public static void Copy(Stream source, Stream destination, byte[] buffer, ProgressHandler progressHandler, TimeSpan updateInterval, object sender, string name, long fixedTarget)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private StreamUtils()
		{
		}
	}
}
