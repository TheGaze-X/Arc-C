using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.HotUpdate;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x020016FF RID: 5887
	[Token(Token = "0x20016FF")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class VoiceLangResController
	{
		// Token: 0x060094E4 RID: 38116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094E4")]
		[Address(RVA = "0x3118320", Offset = "0x3116F20", VA = "0x183118320")]
		public static void HotUpdater_NotifyResStatus(HotUpdater.LocalResStatus resStatus)
		{
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x0003A0F8 File Offset: 0x000382F8
		[Token(Token = "0x60094E5")]
		[Address(RVA = "0x3118170", Offset = "0x3116D70", VA = "0x183118170")]
		public static bool CheckVoiceResEnable()
		{
			return default(bool);
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x0003A110 File Offset: 0x00038310
		[Token(Token = "0x60094E6")]
		[Address(RVA = "0x3117BB0", Offset = "0x31167B0", VA = "0x183117BB0")]
		public static bool CheckIfHasVoiceResToDownload()
		{
			return default(bool);
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094E7")]
		[Address(RVA = "0x3118210", Offset = "0x3116E10", VA = "0x183118210")]
		public static Dictionary<string, HotUpdateVoicePackItemData> GetCachedUndownloadedResInfo()
		{
			return null;
		}

		// Token: 0x060094E8 RID: 38120 RVA: 0x0003A128 File Offset: 0x00038328
		[Token(Token = "0x60094E8")]
		[Address(RVA = "0x3117C50", Offset = "0x3116850", VA = "0x183117C50")]
		public static bool CheckTargetVoiceResEnable(string voiceResType)
		{
			return default(bool);
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x0003A140 File Offset: 0x00038340
		[Token(Token = "0x60094E9")]
		[Address(RVA = "0x3117CF0", Offset = "0x31168F0", VA = "0x183117CF0")]
		public static bool CheckVoiceGroupResEnable(VoiceLangGroupType groupType)
		{
			return default(bool);
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x0003A158 File Offset: 0x00038358
		[Token(Token = "0x60094EA")]
		[Address(RVA = "0x3117EE0", Offset = "0x3116AE0", VA = "0x183117EE0")]
		public static bool CheckVoiceLangResEnable(VoiceLangType voiceLangType)
		{
			return default(bool);
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x0003A170 File Offset: 0x00038370
		[Token(Token = "0x60094EB")]
		[Address(RVA = "0x3118420", Offset = "0x3117020", VA = "0x183118420")]
		public static bool IsVoiceTypeVersionUpgraded()
		{
			return default(bool);
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x0003A188 File Offset: 0x00038388
		[Token(Token = "0x60094EC")]
		[Address(RVA = "0x31185A0", Offset = "0x31171A0", VA = "0x1831185A0")]
		public static bool IsVoiceType(string resType)
		{
			return default(bool);
		}

		// Token: 0x060094ED RID: 38125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094ED")]
		[Address(RVA = "0x3118750", Offset = "0x3117350", VA = "0x183118750")]
		public static void SetVoiceResListEnable(IList<string> voiceResList)
		{
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x0003A1A0 File Offset: 0x000383A0
		[Token(Token = "0x60094EE")]
		[Address(RVA = "0x3118290", Offset = "0x3116E90", VA = "0x183118290")]
		public static bool GetVoicePackShownFlag()
		{
			return default(bool);
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094EF")]
		[Address(RVA = "0x31186D0", Offset = "0x31172D0", VA = "0x1831186D0")]
		public static void SetVoicePackDialogShown()
		{
		}

		// Token: 0x060094F0 RID: 38128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094F0")]
		[Address(RVA = "0x3118650", Offset = "0x3117250", VA = "0x183118650")]
		public static void ResetVoicePackDialogStatus()
		{
		}

		// Token: 0x060094F1 RID: 38129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094F1")]
		[Address(RVA = "0x31187F0", Offset = "0x31173F0", VA = "0x1831187F0")]
		private static string _GenerateVoiceTypeVersion()
		{
			return null;
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094F2")]
		[Address(RVA = "0x3118950", Offset = "0x3117550", VA = "0x183118950")]
		private static string _VoiceLangGroupTypeToResType(VoiceLangGroupType groupType)
		{
			return null;
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094F3")]
		[Address(RVA = "0x31188B0", Offset = "0x31174B0", VA = "0x1831188B0")]
		private static void _SetVoicePackShownFlag(bool shownFlag)
		{
		}

		// Token: 0x04008AF7 RID: 35575
		[Token(Token = "0x4008AF7")]
		public const string TYPE_VOICE_CN = "voice_cn";

		// Token: 0x04008AF8 RID: 35576
		[Token(Token = "0x4008AF8")]
		public const string TYPE_VOICE_JP = "voice_jp";

		// Token: 0x04008AF9 RID: 35577
		[Token(Token = "0x4008AF9")]
		public const string TYPE_VOICE_CUSTOM = "voice_custom";

		// Token: 0x04008AFA RID: 35578
		[Token(Token = "0x4008AFA")]
		public const string TYPE_VOICE_EN = "voice_en";

		// Token: 0x04008AFB RID: 35579
		[Token(Token = "0x4008AFB")]
		public const string TYPE_VOICE_KR = "voice_kr";

		// Token: 0x04008AFC RID: 35580
		[Token(Token = "0x4008AFC")]
		private const string VOICE_RES_PREFIX = "voice_";

		// Token: 0x04008AFD RID: 35581
		[Token(Token = "0x4008AFD")]
		[FieldOffset(Offset = "0x0")]
		public static List<string> ALL_RES_LANG_VOICES;

		// Token: 0x04008AFE RID: 35582
		[Token(Token = "0x4008AFE")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, HotUpdateVoicePackItemData> s_undownloadedInfo;

		// Token: 0x04008AFF RID: 35583
		[Token(Token = "0x4008AFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HotUpdater_NotifyResStatus;

		// Token: 0x04008B00 RID: 35584
		[Token(Token = "0x4008B00")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckVoiceResEnable;

		// Token: 0x04008B01 RID: 35585
		[Token(Token = "0x4008B01")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfHasVoiceResToDownload;

		// Token: 0x04008B02 RID: 35586
		[Token(Token = "0x4008B02")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCachedUndownloadedResInfo;

		// Token: 0x04008B03 RID: 35587
		[Token(Token = "0x4008B03")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckTargetVoiceResEnable;

		// Token: 0x04008B04 RID: 35588
		[Token(Token = "0x4008B04")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckVoiceGroupResEnable;

		// Token: 0x04008B05 RID: 35589
		[Token(Token = "0x4008B05")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckVoiceLangResEnable;

		// Token: 0x04008B06 RID: 35590
		[Token(Token = "0x4008B06")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsVoiceTypeVersionUpgraded;

		// Token: 0x04008B07 RID: 35591
		[Token(Token = "0x4008B07")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsVoiceType;

		// Token: 0x04008B08 RID: 35592
		[Token(Token = "0x4008B08")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetVoiceResListEnable;

		// Token: 0x04008B09 RID: 35593
		[Token(Token = "0x4008B09")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetVoicePackShownFlag;

		// Token: 0x04008B0A RID: 35594
		[Token(Token = "0x4008B0A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetVoicePackDialogShown;

		// Token: 0x04008B0B RID: 35595
		[Token(Token = "0x4008B0B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ResetVoicePackDialogStatus;

		// Token: 0x04008B0C RID: 35596
		[Token(Token = "0x4008B0C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateVoiceTypeVersion;

		// Token: 0x04008B0D RID: 35597
		[Token(Token = "0x4008B0D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__VoiceLangGroupTypeToResType;

		// Token: 0x04008B0E RID: 35598
		[Token(Token = "0x4008B0E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SetVoicePackShownFlag;
	}
}
