using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000298")]
	internal class FtpMethodInfo
	{
		// Token: 0x060012B8 RID: 4792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x51A4D10", Offset = "0x51A3910", VA = "0x1851A4D10")]
		internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x51A43F0", Offset = "0x51A2FF0", VA = "0x1851A43F0")]
		internal bool HasFlag(FtpMethodFlags flags)
		{
			return default(bool);
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x170003D3")]
		internal bool IsCommandOnly
		{
			[Token(Token = "0x60012BA")]
			[Address(RVA = "0x51A4D80", Offset = "0x51A3980", VA = "0x1851A4D80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x170003D4")]
		internal bool IsUpload
		{
			[Token(Token = "0x60012BB")]
			[Address(RVA = "0x51A4D90", Offset = "0x51A3990", VA = "0x1851A4D90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x170003D5")]
		internal bool IsDownload
		{
			[Token(Token = "0x60012BC")]
			[Address(RVA = "0x4F73BE0", Offset = "0x4F727E0", VA = "0x184F73BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x170003D6")]
		internal bool ShouldParseForResponseUri
		{
			[Token(Token = "0x60012BD")]
			[Address(RVA = "0x51A4DA0", Offset = "0x51A39A0", VA = "0x1851A4DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x51A4290", Offset = "0x51A2E90", VA = "0x1851A4290")]
		internal static FtpMethodInfo GetMethodInfo(string method)
		{
			return null;
		}

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x10")]
		internal string Method;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x18")]
		internal FtpOperation Operation;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x1C")]
		internal FtpMethodFlags Flags;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x20")]
		internal string HttpCommand;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FtpMethodInfo[] s_knownMethodInfo;
	}
}
