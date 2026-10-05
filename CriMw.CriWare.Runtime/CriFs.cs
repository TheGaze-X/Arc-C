using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	public class CriFs
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x36FE1D0", Offset = "0x36FCDD0", VA = "0x1836FE1D0")]
		public static bool GetNumUsedBinders(out int curNum, out int maxNum, out int limit)
		{
			return default(bool);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x36FE330", Offset = "0x36FCF30", VA = "0x1836FE330")]
		public static bool GetNumUsedLoaders(out int curNum, out int maxNum, out int limit)
		{
			return default(bool);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000398C File Offset: 0x00001B8C
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x36FE280", Offset = "0x36FCE80", VA = "0x1836FE280")]
		public static bool GetNumUsedInstallers(out int curNum, out int maxNum, out int limit)
		{
			return default(bool);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000039A4 File Offset: 0x00001BA4
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x36FE070", Offset = "0x36FCC70", VA = "0x1836FE070")]
		public static bool GetNumBinds(out int curNum, out int maxNum, out int limit)
		{
			return default(bool);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x36FE120", Offset = "0x36FCD20", VA = "0x1836FE120")]
		public static bool GetNumOpenedFiles(out int curNum, out int maxNum, out int limit)
		{
			return default(bool);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x36FDFE0", Offset = "0x36FCBE0", VA = "0x1836FDFE0")]
		public static bool GetMaxPathLength(out int length)
		{
			return default(bool);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CriFs()
		{
		}

		// Token: 0x020000B4 RID: 180
		[Token(Token = "0x20000B4")]
		private class NativeMethods
		{
			// Token: 0x060005ED RID: 1517
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x3708260", Offset = "0x3706E60", VA = "0x183708260")]
			[PreserveSig]
			internal static extern int criFs_GetNumUsedBinders(ref int curNum, ref int maxNum, ref int limit);

			// Token: 0x060005EE RID: 1518
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x3708440", Offset = "0x3707040", VA = "0x183708440")]
			[PreserveSig]
			internal static extern int criFs_GetNumUsedLoaders(ref int curNum, ref int maxNum, ref int limit);

			// Token: 0x060005EF RID: 1519
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x3708300", Offset = "0x3706F00", VA = "0x183708300")]
			[PreserveSig]
			internal static extern int criFs_GetNumUsedGroupLoaders(ref int curNum, ref int maxNum, ref int limit);

			// Token: 0x060005F0 RID: 1520
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x37084E0", Offset = "0x37070E0", VA = "0x1837084E0")]
			[PreserveSig]
			internal static extern int criFs_GetNumUsedStdioHandles(ref int curNum, ref int maxNum, ref int limit);

			// Token: 0x060005F1 RID: 1521
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x37083A0", Offset = "0x3706FA0", VA = "0x1837083A0")]
			[PreserveSig]
			internal static extern int criFs_GetNumUsedInstallers(ref int curNum, ref int maxNum, ref int limit);

			// Token: 0x060005F2 RID: 1522
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x3708120", Offset = "0x3706D20", VA = "0x183708120")]
			[PreserveSig]
			internal static extern int criFs_GetNumBinds(ref int curNum, ref int maxNum, ref int limit);

			// Token: 0x060005F3 RID: 1523
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x37081C0", Offset = "0x3706DC0", VA = "0x1837081C0")]
			[PreserveSig]
			internal static extern int criFs_GetNumOpenedFiles(ref int curNum, ref int maxNum, ref int limit);

			// Token: 0x060005F4 RID: 1524
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x37080A0", Offset = "0x3706CA0", VA = "0x1837080A0")]
			[PreserveSig]
			internal static extern int criFs_GetMaxPathLength(ref int length);

			// Token: 0x060005F5 RID: 1525 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NativeMethods()
			{
			}
		}
	}
}
