using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.I18N
{
	// Token: 0x0200161F RID: 5663
	[Token(Token = "0x200161F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class LocalizationPreference
	{
		// Token: 0x0600809A RID: 32922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600809A")]
		[Address(RVA = "0x2887A40", Offset = "0x2886640", VA = "0x182887A40")]
		public static void ReloadConfig()
		{
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x0600809B RID: 32923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F38")]
		public static string numberUnitFormat
		{
			[Token(Token = "0x600809B")]
			[Address(RVA = "0x2887EF0", Offset = "0x2886AF0", VA = "0x182887EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x0600809C RID: 32924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F39")]
		public static string[] numberUnits
		{
			[Token(Token = "0x600809C")]
			[Address(RVA = "0x2887FC0", Offset = "0x2886BC0", VA = "0x182887FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x0600809D RID: 32925 RVA: 0x000383E8 File Offset: 0x000365E8
		[Token(Token = "0x17000F3A")]
		public static int unitStepSize
		{
			[Token(Token = "0x600809D")]
			[Address(RVA = "0x2888160", Offset = "0x2886D60", VA = "0x182888160")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x0600809E RID: 32926 RVA: 0x00038400 File Offset: 0x00036600
		[Token(Token = "0x17000F3B")]
		public static int battleResultCharWordLineLength
		{
			[Token(Token = "0x600809E")]
			[Address(RVA = "0x2887E30", Offset = "0x2886A30", VA = "0x182887E30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x0600809F RID: 32927 RVA: 0x00038418 File Offset: 0x00036618
		[Token(Token = "0x17000F3C")]
		public static LocalizationPreferenceConfig.BattleResultCharWordSplitMode splitMode
		{
			[Token(Token = "0x600809F")]
			[Address(RVA = "0x28880A0", Offset = "0x2886CA0", VA = "0x1828880A0")]
			get
			{
				return LocalizationPreferenceConfig.BattleResultCharWordSplitMode.LetterBased;
			}
		}

		// Token: 0x040081C4 RID: 33220
		[Token(Token = "0x40081C4")]
		private const string CONFIG_PATH = "I18N/local_pref";

		// Token: 0x040081C5 RID: 33221
		[Token(Token = "0x40081C5")]
		[FieldOffset(Offset = "0x0")]
		private static LocalizationPreference.ConfigData s_configData;

		// Token: 0x040081C6 RID: 33222
		[Token(Token = "0x40081C6")]
		[FieldOffset(Offset = "0x8")]
		private static string[] DEFAULT_UNITS;

		// Token: 0x040081C7 RID: 33223
		[Token(Token = "0x40081C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReloadConfig;

		// Token: 0x040081C8 RID: 33224
		[Token(Token = "0x40081C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_numberUnitFormat;

		// Token: 0x040081C9 RID: 33225
		[Token(Token = "0x40081C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_numberUnits;

		// Token: 0x040081CA RID: 33226
		[Token(Token = "0x40081CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_unitStepSize;

		// Token: 0x040081CB RID: 33227
		[Token(Token = "0x40081CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_battleResultCharWordLineLength;

		// Token: 0x040081CC RID: 33228
		[Token(Token = "0x40081CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_splitMode;

		// Token: 0x02001620 RID: 5664
		[Token(Token = "0x2001620")]
		private class ConfigData : IHotfixable
		{
			// Token: 0x060080A1 RID: 32929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080A1")]
			[Address(RVA = "0x2886C90", Offset = "0x2885890", VA = "0x182886C90")]
			public ConfigData(LocalizationPreferenceConfig config)
			{
			}

			// Token: 0x040081CD RID: 33229
			[Token(Token = "0x40081CD")]
			[FieldOffset(Offset = "0x10")]
			public string numberUnitFormat;

			// Token: 0x040081CE RID: 33230
			[Token(Token = "0x40081CE")]
			[FieldOffset(Offset = "0x18")]
			public string[] numberUnits;

			// Token: 0x040081CF RID: 33231
			[Token(Token = "0x40081CF")]
			[FieldOffset(Offset = "0x20")]
			public int unitStepSize;

			// Token: 0x040081D0 RID: 33232
			[Token(Token = "0x40081D0")]
			[FieldOffset(Offset = "0x24")]
			public int battleResultCharWordLineLength;

			// Token: 0x040081D1 RID: 33233
			[Token(Token = "0x40081D1")]
			[FieldOffset(Offset = "0x28")]
			public LocalizationPreferenceConfig.BattleResultCharWordSplitMode splitMode;

			// Token: 0x040081D2 RID: 33234
			[Token(Token = "0x40081D2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
