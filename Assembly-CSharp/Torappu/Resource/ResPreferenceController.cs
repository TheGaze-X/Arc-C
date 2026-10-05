using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x02001756 RID: 5974
	[Token(Token = "0x2001756")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ResPreferenceController
	{
		// Token: 0x0600967F RID: 38527 RVA: 0x0003A9E0 File Offset: 0x00038BE0
		[Token(Token = "0x600967F")]
		[Address(RVA = "0x312A0A0", Offset = "0x3128CA0", VA = "0x18312A0A0")]
		public static bool CheckUpdate(string resType)
		{
			return default(bool);
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009680")]
		[Address(RVA = "0x312A690", Offset = "0x3129290", VA = "0x18312A690")]
		public static void TryToSetUpdateEnable(string resType)
		{
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009681")]
		[Address(RVA = "0x312A440", Offset = "0x3129040", VA = "0x18312A440")]
		public static void SetUpdateListEnable(IList<string> resTypeList)
		{
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		[Token(Token = "0x6009682")]
		[Address(RVA = "0x312A1B0", Offset = "0x3128DB0", VA = "0x18312A1B0")]
		public static bool HaveShowPrefDialog()
		{
			return default(bool);
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x0003AA10 File Offset: 0x00038C10
		[Token(Token = "0x6009683")]
		[Address(RVA = "0x312A240", Offset = "0x3128E40", VA = "0x18312A240")]
		public static bool IsFullHotupdatePreference()
		{
			return default(bool);
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x0003AA28 File Offset: 0x00038C28
		[Token(Token = "0x6009684")]
		[Address(RVA = "0x312A2D0", Offset = "0x3128ED0", VA = "0x18312A2D0")]
		public static bool IsTypeVersionUpgraded()
		{
			return default(bool);
		}

		// Token: 0x06009685 RID: 38533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009685")]
		[Address(RVA = "0x312A380", Offset = "0x3128F80", VA = "0x18312A380")]
		public static void MarkHotupdatePreference(bool isFull)
		{
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009686")]
		[Address(RVA = "0x312A5F0", Offset = "0x31291F0", VA = "0x18312A5F0")]
		public static void StartHotUpdate(string resType)
		{
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009687")]
		[Address(RVA = "0x312A4C0", Offset = "0x31290C0", VA = "0x18312A4C0")]
		public static void StartHotUpdate()
		{
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009688")]
		[Address(RVA = "0x312A120", Offset = "0x3128D20", VA = "0x18312A120")]
		public static string GetVoiceTypeVersion()
		{
			return null;
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009689")]
		[Address(RVA = "0x312A740", Offset = "0x3129340", VA = "0x18312A740")]
		public static void UpdateVoiceTypeVersion(string version)
		{
		}

		// Token: 0x0600968A RID: 38538 RVA: 0x0003AA40 File Offset: 0x00038C40
		[Token(Token = "0x600968A")]
		[Address(RVA = "0x31295F0", Offset = "0x31281F0", VA = "0x1831295F0")]
		public static bool CheckIfResReadyForStartStage(string stageId, [Optional] Action nextStep)
		{
			return default(bool);
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x0003AA58 File Offset: 0x00038C58
		[Token(Token = "0x600968B")]
		[Address(RVA = "0x31298E0", Offset = "0x31284E0", VA = "0x1831298E0")]
		public static bool CheckIfResReadyForStartStory(IList<StoryData> storysToTrig, ResPreferenceController.CheckResOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x0003AA70 File Offset: 0x00038C70
		[Token(Token = "0x600968C")]
		[Address(RVA = "0x3129D30", Offset = "0x3128930", VA = "0x183129D30")]
		public static bool CheckIfResReadyForStartStory(IList<StoryData> storysToTrig, [Optional] Action nextStep)
		{
			return default(bool);
		}

		// Token: 0x0600968D RID: 38541 RVA: 0x0003AA88 File Offset: 0x00038C88
		[Token(Token = "0x600968D")]
		[Address(RVA = "0x3129E10", Offset = "0x3128A10", VA = "0x183129E10")]
		public static bool CheckIfResReadyForVoice(Action nextStep)
		{
			return default(bool);
		}

		// Token: 0x0600968E RID: 38542 RVA: 0x0003AAA0 File Offset: 0x00038CA0
		[Token(Token = "0x600968E")]
		[Address(RVA = "0x3129370", Offset = "0x3127F70", VA = "0x183129370")]
		public static bool CheckIfResReadyForSkinShop(Action nextStep)
		{
			return default(bool);
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600968F")]
		[Address(RVA = "0x312B420", Offset = "0x312A020", VA = "0x18312B420")]
		private static void _TryShowResUpdateAlert(IList<string> sharedTypes, ResPreferenceController.StepHandler stepHandler)
		{
		}

		// Token: 0x06009690 RID: 38544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009690")]
		[Address(RVA = "0x312B120", Offset = "0x3129D20", VA = "0x18312B120")]
		private static void _OnResTypeAlertConfirmed(IList<string> resTypeList)
		{
		}

		// Token: 0x06009691 RID: 38545 RVA: 0x0003AAB8 File Offset: 0x00038CB8
		[Token(Token = "0x6009691")]
		[Address(RVA = "0x312A8E0", Offset = "0x31294E0", VA = "0x18312A8E0")]
		private static bool _CheckIfShowResAlert(IList<string> types, bool ignoreAlertVersion, out IList<string> neededTypes)
		{
			return default(bool);
		}

		// Token: 0x06009692 RID: 38546 RVA: 0x0003AAD0 File Offset: 0x00038CD0
		[Token(Token = "0x6009692")]
		[Address(RVA = "0x312A7F0", Offset = "0x31293F0", VA = "0x18312A7F0")]
		private static bool _CheckIfResAlertVersionDirty()
		{
			return default(bool);
		}

		// Token: 0x06009693 RID: 38547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009693")]
		[Address(RVA = "0x312AB00", Offset = "0x3129700", VA = "0x18312AB00")]
		private static void _ConfirmTypesAlertInfo(IList<string> types)
		{
		}

		// Token: 0x06009694 RID: 38548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009694")]
		[Address(RVA = "0x312AFC0", Offset = "0x3129BC0", VA = "0x18312AFC0")]
		private static string _GenerateTypeVersion()
		{
			return null;
		}

		// Token: 0x06009695 RID: 38549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009695")]
		[Address(RVA = "0x312ABD0", Offset = "0x31297D0", VA = "0x18312ABD0")]
		private static string _GenerateTypeNameStr(IList<string> types)
		{
			return null;
		}

		// Token: 0x06009696 RID: 38550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009696")]
		[Address(RVA = "0x312B090", Offset = "0x3129C90", VA = "0x18312B090")]
		private static ResPreferenceController.HotupdatePreferenceData _GetHotupdatePreference()
		{
			return null;
		}

		// Token: 0x06009697 RID: 38551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009697")]
		[Address(RVA = "0x312B380", Offset = "0x3129F80", VA = "0x18312B380")]
		private static void _SetHotupdatePreference(ResPreferenceController.HotupdatePreferenceData preference)
		{
		}

		// Token: 0x04008CC0 RID: 36032
		[Token(Token = "0x4008CC0")]
		public const string TYPE_VIDEO = "video";

		// Token: 0x04008CC1 RID: 36033
		[Token(Token = "0x4008CC1")]
		public const string TYPE_DYN_ILLUST = "dyn_illust";

		// Token: 0x04008CC2 RID: 36034
		[Token(Token = "0x4008CC2")]
		public const string TYPE_VOICE_BASIC = "voice_basic";

		// Token: 0x04008CC3 RID: 36035
		[Token(Token = "0x4008CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> ALL_EXTRA_RES_TYPES;

		// Token: 0x04008CC4 RID: 36036
		[Token(Token = "0x4008CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<string, string> TYPE_NAME_DIC;

		// Token: 0x04008CC5 RID: 36037
		[Token(Token = "0x4008CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<string> s_sharedTypeList;

		// Token: 0x04008CC6 RID: 36038
		[Token(Token = "0x4008CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<StoryData> s_sharedStoryList;

		// Token: 0x04008CC7 RID: 36039
		[Token(Token = "0x4008CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckUpdate;

		// Token: 0x04008CC8 RID: 36040
		[Token(Token = "0x4008CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryToSetUpdateEnable;

		// Token: 0x04008CC9 RID: 36041
		[Token(Token = "0x4008CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetUpdateListEnable;

		// Token: 0x04008CCA RID: 36042
		[Token(Token = "0x4008CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HaveShowPrefDialog;

		// Token: 0x04008CCB RID: 36043
		[Token(Token = "0x4008CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsFullHotupdatePreference;

		// Token: 0x04008CCC RID: 36044
		[Token(Token = "0x4008CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsTypeVersionUpgraded;

		// Token: 0x04008CCD RID: 36045
		[Token(Token = "0x4008CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_MarkHotupdatePreference;

		// Token: 0x04008CCE RID: 36046
		[Token(Token = "0x4008CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_StartHotUpdate;

		// Token: 0x04008CCF RID: 36047
		[Token(Token = "0x4008CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_StartHotUpdate;

		// Token: 0x04008CD0 RID: 36048
		[Token(Token = "0x4008CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetVoiceTypeVersion;

		// Token: 0x04008CD1 RID: 36049
		[Token(Token = "0x4008CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateVoiceTypeVersion;

		// Token: 0x04008CD2 RID: 36050
		[Token(Token = "0x4008CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckIfResReadyForStartStage;

		// Token: 0x04008CD3 RID: 36051
		[Token(Token = "0x4008CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckIfResReadyForStartStory;

		// Token: 0x04008CD4 RID: 36052
		[Token(Token = "0x4008CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_CheckIfResReadyForStartStory;

		// Token: 0x04008CD5 RID: 36053
		[Token(Token = "0x4008CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckIfResReadyForVoice;

		// Token: 0x04008CD6 RID: 36054
		[Token(Token = "0x4008CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckIfResReadyForSkinShop;

		// Token: 0x04008CD7 RID: 36055
		[Token(Token = "0x4008CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TryShowResUpdateAlert;

		// Token: 0x04008CD8 RID: 36056
		[Token(Token = "0x4008CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnResTypeAlertConfirmed;

		// Token: 0x04008CD9 RID: 36057
		[Token(Token = "0x4008CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckIfShowResAlert;

		// Token: 0x04008CDA RID: 36058
		[Token(Token = "0x4008CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CheckIfResAlertVersionDirty;

		// Token: 0x04008CDB RID: 36059
		[Token(Token = "0x4008CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ConfirmTypesAlertInfo;

		// Token: 0x04008CDC RID: 36060
		[Token(Token = "0x4008CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GenerateTypeVersion;

		// Token: 0x04008CDD RID: 36061
		[Token(Token = "0x4008CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GenerateTypeNameStr;

		// Token: 0x04008CDE RID: 36062
		[Token(Token = "0x4008CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetHotupdatePreference;

		// Token: 0x04008CDF RID: 36063
		[Token(Token = "0x4008CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__SetHotupdatePreference;

		// Token: 0x02001757 RID: 5975
		[Token(Token = "0x2001757")]
		[Serializable]
		public class HotupdatePreferenceData
		{
			// Token: 0x06009699 RID: 38553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009699")]
			[Address(RVA = "0x3126930", Offset = "0x3125530", VA = "0x183126930")]
			public HotupdatePreferenceData()
			{
			}

			// Token: 0x04008CE0 RID: 36064
			[Token(Token = "0x4008CE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool haveShowDialog;

			// Token: 0x04008CE1 RID: 36065
			[Token(Token = "0x4008CE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool isFull;

			// Token: 0x04008CE2 RID: 36066
			[Token(Token = "0x4008CE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string typeVersion;

			// Token: 0x04008CE3 RID: 36067
			[Token(Token = "0x4008CE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string voiceTypeVersion;
		}

		// Token: 0x02001758 RID: 5976
		[Token(Token = "0x2001758")]
		private class StepHandler
		{
			// Token: 0x0600969A RID: 38554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600969A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StepHandler()
			{
			}

			// Token: 0x04008CE4 RID: 36068
			[Token(Token = "0x4008CE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action skipStep;

			// Token: 0x04008CE5 RID: 36069
			[Token(Token = "0x4008CE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action negativeStep;

			// Token: 0x04008CE6 RID: 36070
			[Token(Token = "0x4008CE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool ignoreAlertVersion;
		}

		// Token: 0x02001759 RID: 5977
		[Token(Token = "0x2001759")]
		public struct CheckResOptions
		{
			// Token: 0x04008CE7 RID: 36071
			[Token(Token = "0x4008CE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action nextStep;

			// Token: 0x04008CE8 RID: 36072
			[Token(Token = "0x4008CE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool ignoreAlertVersion;
		}
	}
}
