using System;
using Il2CppDummyDll;

namespace Torappu.Config
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	public class DynGameConfigUtils
	{
		// Token: 0x06000D51 RID: 3409 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x55810E0", Offset = "0x557FCE0", VA = "0x1855810E0")]
		public static void SetAuditMode(bool auditMode)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00008774 File Offset: 0x00006974
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x5581090", Offset = "0x557FC90", VA = "0x185581090")]
		public static bool IsAuditMode()
		{
			return default(bool);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0000878C File Offset: 0x0000698C
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x5580920", Offset = "0x557F520", VA = "0x185580920")]
		public static DynConfigRequest CreateConfigRequest(IDynGameConfig config, string overrideEnv)
		{
			return default(DynConfigRequest);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x000087A4 File Offset: 0x000069A4
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x5581140", Offset = "0x557FD40", VA = "0x185581140")]
		public static bool SetDataFromResponse(IDynGameConfig config, string response)
		{
			return default(bool);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000087BC File Offset: 0x000069BC
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x5581320", Offset = "0x557FF20", VA = "0x185581320")]
		private static int _ConfigAppID()
		{
			return 0;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x5580EF0", Offset = "0x557FAF0", VA = "0x185580EF0")]
		public static string GetRuntimePlatformName()
		{
			return null;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x5581490", Offset = "0x5580090", VA = "0x185581490")]
		private static string _GetRuntimeChannelName()
		{
			return null;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x5581330", Offset = "0x557FF30", VA = "0x185581330")]
		private static string _FormatRuntimeConfigEnv(string overrideEnv)
		{
			return null;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DynGameConfigUtils()
		{
		}

		// Token: 0x04000D72 RID: 3442
		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x0")]
		public static string DEFAULT_NAME;

		// Token: 0x04000D73 RID: 3443
		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x8")]
		public static string DEFAULT_ENV_NAME;

		// Token: 0x04000D74 RID: 3444
		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x10")]
		public static string DEFAULT_APPCODE;

		// Token: 0x04000D75 RID: 3445
		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x18")]
		private static bool isAuditMode;
	}
}
