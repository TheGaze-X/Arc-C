using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	public class DefaultTraceListener : TraceListener
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x5105470", Offset = "0x5104070", VA = "0x185105470")]
		private static string GetPrefix(string var, string target)
		{
			return null;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x5105DC0", Offset = "0x51049C0", VA = "0x185105DC0")]
		public DefaultTraceListener()
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000135")]
		[MonoTODO]
		public string LogFileName
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006E4 RID: 1764
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x5105BD0", Offset = "0x51047D0", VA = "0x185105BD0")]
		[MethodImpl(4096)]
		private unsafe static extern void WriteWindowsDebugString(char* message);

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x51054E0", Offset = "0x51040E0", VA = "0x1851054E0")]
		private void WriteDebugString(string message)
		{
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x5105940", Offset = "0x5104540", VA = "0x185105940")]
		private void WriteMonoTrace(string message)
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x5105B40", Offset = "0x5104740", VA = "0x185105B40")]
		private void WritePrefix()
		{
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x5105590", Offset = "0x5104190", VA = "0x185105590")]
		private void WriteImpl(string message)
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x51057B0", Offset = "0x51043B0", VA = "0x1851057B0")]
		private void WriteLogFile(string message, string logFile)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x5105BE0", Offset = "0x51047E0", VA = "0x185105BE0", Slot = "10")]
		public override void Write(string message)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x5105760", Offset = "0x5104360", VA = "0x185105760", Slot = "12")]
		public override void WriteLine(string message)
		{
		}

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool OnWin32;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string MonoTracePrefix;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string MonoTraceFile;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x38")]
		private string logFileName;
	}
}
