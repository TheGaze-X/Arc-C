using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.I18N
{
	// Token: 0x0200161D RID: 5661
	[Token(Token = "0x200161D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class LocalizationEnv
	{
		// Token: 0x06008090 RID: 32912 RVA: 0x00038328 File Offset: 0x00036528
		[Token(Token = "0x6008090")]
		[Address(RVA = "0x28872D0", Offset = "0x2885ED0", VA = "0x1828872D0")]
		public static bool IsInland()
		{
			return default(bool);
		}

		// Token: 0x06008091 RID: 32913 RVA: 0x00038340 File Offset: 0x00036540
		[Token(Token = "0x6008091")]
		[Address(RVA = "0x2887360", Offset = "0x2885F60", VA = "0x182887360")]
		public static bool IsJapan()
		{
			return default(bool);
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x00038358 File Offset: 0x00036558
		[Token(Token = "0x6008092")]
		[Address(RVA = "0x28873F0", Offset = "0x2885FF0", VA = "0x1828873F0")]
		public static bool IsKorea()
		{
			return default(bool);
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x00038370 File Offset: 0x00036570
		[Token(Token = "0x6008093")]
		[Address(RVA = "0x28871B0", Offset = "0x2885DB0", VA = "0x1828871B0")]
		public static bool IsEnArea()
		{
			return default(bool);
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x00038388 File Offset: 0x00036588
		[Token(Token = "0x6008094")]
		[Address(RVA = "0x28876B0", Offset = "0x28862B0", VA = "0x1828876B0")]
		public static bool IsTcArea()
		{
			return default(bool);
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x000383A0 File Offset: 0x000365A0
		[Token(Token = "0x6008095")]
		[Address(RVA = "0x2887240", Offset = "0x2885E40", VA = "0x182887240")]
		public static bool IsGlobal()
		{
			return default(bool);
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x000383B8 File Offset: 0x000365B8
		[Token(Token = "0x6008096")]
		[Address(RVA = "0x2887500", Offset = "0x2886100", VA = "0x182887500")]
		public static bool IsOverseasPC()
		{
			return default(bool);
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x000383D0 File Offset: 0x000365D0
		[Token(Token = "0x6008097")]
		[Address(RVA = "0x2887480", Offset = "0x2886080", VA = "0x182887480")]
		public static bool IsMultiCurrencyArea()
		{
			return default(bool);
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008098")]
		[Address(RVA = "0x2887740", Offset = "0x2886340", VA = "0x182887740")]
		public static string SystemDeviceId()
		{
			return null;
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008099")]
		[Address(RVA = "0x28870D0", Offset = "0x2885CD0", VA = "0x1828870D0")]
		public static string GetLanguageStr()
		{
			return null;
		}

		// Token: 0x040081B1 RID: 33201
		[Token(Token = "0x40081B1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<LocalizationEnv.EnvType, string> LANGUAGE_MAP;

		// Token: 0x040081B2 RID: 33202
		[Token(Token = "0x40081B2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly LocalizationEnv.EnvType ENV_TYPE;

		// Token: 0x040081B3 RID: 33203
		[Token(Token = "0x40081B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsInland;

		// Token: 0x040081B4 RID: 33204
		[Token(Token = "0x40081B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsJapan;

		// Token: 0x040081B5 RID: 33205
		[Token(Token = "0x40081B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsKorea;

		// Token: 0x040081B6 RID: 33206
		[Token(Token = "0x40081B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsEnArea;

		// Token: 0x040081B7 RID: 33207
		[Token(Token = "0x40081B7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsTcArea;

		// Token: 0x040081B8 RID: 33208
		[Token(Token = "0x40081B8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsGlobal;

		// Token: 0x040081B9 RID: 33209
		[Token(Token = "0x40081B9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsOverseasPC;

		// Token: 0x040081BA RID: 33210
		[Token(Token = "0x40081BA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsMultiCurrencyArea;

		// Token: 0x040081BB RID: 33211
		[Token(Token = "0x40081BB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SystemDeviceId;

		// Token: 0x040081BC RID: 33212
		[Token(Token = "0x40081BC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetLanguageStr;

		// Token: 0x0200161E RID: 5662
		[Token(Token = "0x200161E")]
		public enum EnvType
		{
			// Token: 0x040081BE RID: 33214
			[Token(Token = "0x40081BE")]
			INLAND,
			// Token: 0x040081BF RID: 33215
			[Token(Token = "0x40081BF")]
			JP,
			// Token: 0x040081C0 RID: 33216
			[Token(Token = "0x40081C0")]
			KR,
			// Token: 0x040081C1 RID: 33217
			[Token(Token = "0x40081C1")]
			EN,
			// Token: 0x040081C2 RID: 33218
			[Token(Token = "0x40081C2")]
			TC,
			// Token: 0x040081C3 RID: 33219
			[Token(Token = "0x40081C3")]
			NONE = 999
		}
	}
}
