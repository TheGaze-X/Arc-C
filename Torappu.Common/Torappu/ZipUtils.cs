using System;
using System.IO;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	public class ZipUtils : IHotfixable
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x552D8C0", Offset = "0x552C4C0", VA = "0x18552D8C0")]
		public static void Decompress(string outputFolder, string zipFilePath, ZipUtils.UnzipThreadContext context)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x552D3D0", Offset = "0x552BFD0", VA = "0x18552D3D0")]
		public static void Decompress(string outputFolder, Stream stream, ZipUtils.UnzipThreadContext context)
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000665C File Offset: 0x0000485C
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x552DAC0", Offset = "0x552C6C0", VA = "0x18552DAC0")]
		public static int Decompress(Stream input, out byte[] outBytes)
		{
			return 0;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00006674 File Offset: 0x00004874
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x552C740", Offset = "0x552B340", VA = "0x18552C740")]
		public static int Compress(Stream input, out byte[] outBytes)
		{
			return 0;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0000668C File Offset: 0x0000488C
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x552C440", Offset = "0x552B040", VA = "0x18552C440")]
		public static int CompressToZipBytes(byte[] input, out byte[] outBytes)
		{
			return 0;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000066A4 File Offset: 0x000048A4
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x552CB90", Offset = "0x552B790", VA = "0x18552CB90")]
		public static int DecompressFromZipBytes(byte[] input, out byte[] outBytes)
		{
			return 0;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x552C300", Offset = "0x552AF00", VA = "0x18552C300")]
		public static string CompressStrToBase64(string src)
		{
			return null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x552D270", Offset = "0x552BE70", VA = "0x18552D270")]
		public static string DecompressStrFromBase64(string src)
		{
			return null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000066BC File Offset: 0x000048BC
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x552CE80", Offset = "0x552BA80", VA = "0x18552CE80")]
		public static int DecompressGZip(byte[] inBytes, out byte[] outBytes)
		{
			return 0;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x552DF90", Offset = "0x552CB90", VA = "0x18552DF90")]
		public ZipUtils()
		{
		}

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		private const int BUFFER_LENGTH = 24576;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		private const string DEFAULT_ENTRY = "default_entry";

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate5 __Hotfix0_Decompress;

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate5 __Hotfix1_Decompress;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate128 __Hotfix2_Decompress;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate128 __Hotfix0_Compress;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate128 __Hotfix0_CompressToZipBytes;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate128 __Hotfix0_DecompressFromZipBytes;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate19 __Hotfix0_CompressStrToBase64;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate19 __Hotfix0_DecompressStrFromBase64;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate128 __Hotfix0_DecompressGZip;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000120 RID: 288
		[Token(Token = "0x2000120")]
		public class UnzipThreadContext
		{
			// Token: 0x060006FF RID: 1791 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x552BB40", Offset = "0x552A740", VA = "0x18552BB40")]
			public UnzipThreadContext()
			{
			}

			// Token: 0x040005FC RID: 1532
			[Token(Token = "0x40005FC")]
			[FieldOffset(Offset = "0x10")]
			public bool isContinue;

			// Token: 0x040005FD RID: 1533
			[Token(Token = "0x40005FD")]
			[FieldOffset(Offset = "0x14")]
			public float progressForCurrentTask;
		}
	}
}
