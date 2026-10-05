using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Audio.Middleware.Data;
using XLua;

namespace Torappu.CharWord
{
	// Token: 0x0200178C RID: 6028
	[Token(Token = "0x200178C")]
	public class VoiceLangManager : Singleton<VoiceLangManager>
	{
		// Token: 0x06009838 RID: 38968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009838")]
		public static IEnumerator<PrefType> EnumerateTypeWithI18NPrefOrder<PrefType>(Func<VoiceLangType, PrefType> convertFunc)
		{
			return null;
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009839")]
		[Address(RVA = "0x3132430", Offset = "0x3131030", VA = "0x183132430")]
		private VoiceLangManager()
		{
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x0003B358 File Offset: 0x00039558
		[Token(Token = "0x600983A")]
		[Address(RVA = "0x312FFA0", Offset = "0x312EBA0", VA = "0x18312FFA0")]
		public bool GetCharVoiceLangType(string charId, out VoiceLangType voiceLangType)
		{
			return default(bool);
		}

		// Token: 0x0600983B RID: 38971 RVA: 0x0003B370 File Offset: 0x00039570
		[Token(Token = "0x600983B")]
		[Address(RVA = "0x3130700", Offset = "0x312F300", VA = "0x183130700")]
		public VoiceLangManager.VoicePath GetVoicePathWithPlayerChar(ICharWordData charWordData)
		{
			return default(VoiceLangManager.VoicePath);
		}

		// Token: 0x0600983C RID: 38972 RVA: 0x0003B388 File Offset: 0x00039588
		[Token(Token = "0x600983C")]
		[Address(RVA = "0x31318E0", Offset = "0x31304E0", VA = "0x1831318E0")]
		public bool TryHookAudioByFxLang(VoiceQuery voiceQuery, string eventName, Dictionary<string, SoundFXVoiceLangData> soundFxVoiceLang, out string replacedSignal)
		{
			return default(bool);
		}

		// Token: 0x0600983D RID: 38973 RVA: 0x0003B3A0 File Offset: 0x000395A0
		[Token(Token = "0x600983D")]
		[Address(RVA = "0x312FE60", Offset = "0x312EA60", VA = "0x18312FE60")]
		public bool GetCharLangTypeOrDefault(VoiceQuery voiceQuery, out VoiceLangType voiceLangType)
		{
			return default(bool);
		}

		// Token: 0x0600983E RID: 38974 RVA: 0x0003B3B8 File Offset: 0x000395B8
		[Token(Token = "0x600983E")]
		[Address(RVA = "0x31304C0", Offset = "0x312F0C0", VA = "0x1831304C0")]
		public VoiceLangManager.VoicePath GetVoicePathByType(ICharWordData charWordData, VoiceLangType preferLangType, bool needDefault = false)
		{
			return default(VoiceLangManager.VoicePath);
		}

		// Token: 0x0600983F RID: 38975 RVA: 0x0003B3D0 File Offset: 0x000395D0
		[Token(Token = "0x600983F")]
		[Address(RVA = "0x312FD20", Offset = "0x312E920", VA = "0x18312FD20")]
		public bool GetCharDefaultVoiceLangType(string charId, string wordKey, out VoiceLangType defaultVoiceLang)
		{
			return default(bool);
		}

		// Token: 0x06009840 RID: 38976 RVA: 0x0003B3E8 File Offset: 0x000395E8
		[Token(Token = "0x6009840")]
		[Address(RVA = "0x312F9B0", Offset = "0x312E5B0", VA = "0x18312F9B0")]
		public bool CheckVoiceLangTypeValid(ICharWordData charWordData, VoiceLangType voiceLangType)
		{
			return default(bool);
		}

		// Token: 0x06009841 RID: 38977 RVA: 0x0003B400 File Offset: 0x00039600
		[Token(Token = "0x6009841")]
		[Address(RVA = "0x312F7A0", Offset = "0x312E3A0", VA = "0x18312F7A0")]
		public bool CheckVoiceLangGroupResValid(VoiceLangGroupType groupType)
		{
			return default(bool);
		}

		// Token: 0x06009842 RID: 38978 RVA: 0x0003B418 File Offset: 0x00039618
		[Token(Token = "0x6009842")]
		[Address(RVA = "0x312F850", Offset = "0x312E450", VA = "0x18312F850")]
		public bool CheckVoiceLangTypeResValid(VoiceLangType voiceLangType)
		{
			return default(bool);
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x0003B430 File Offset: 0x00039630
		[Token(Token = "0x6009843")]
		[Address(RVA = "0x312FAC0", Offset = "0x312E6C0", VA = "0x18312FAC0")]
		public bool CheckWordKeyDisplay(string wordKey)
		{
			return default(bool);
		}

		// Token: 0x06009844 RID: 38980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009844")]
		[Address(RVA = "0x3130BB0", Offset = "0x312F7B0", VA = "0x183130BB0")]
		public void LoadResValidPrevNearestTimeData(long timestamp, out NewVoiceTimeData newVoiceTimeData, out Dictionary<VoiceLangType, NewVoiceTimeData> newTypedVoiceTimeDataDict)
		{
		}

		// Token: 0x06009845 RID: 38981 RVA: 0x0003B448 File Offset: 0x00039648
		[Token(Token = "0x6009845")]
		[Address(RVA = "0x3130190", Offset = "0x312ED90", VA = "0x183130190")]
		public VoiceLangType GetGlobalVoiceLang()
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x06009846 RID: 38982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009846")]
		[Address(RVA = "0x3131D50", Offset = "0x3130950", VA = "0x183131D50")]
		public void UpdateGlobalVoiceLangWithPlayerData()
		{
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009847")]
		[Address(RVA = "0x3131720", Offset = "0x3130320", VA = "0x183131720")]
		public void SetHotUpdatePref(VoiceLangManager.HotUpdatePref pref)
		{
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x0003B460 File Offset: 0x00039660
		[Token(Token = "0x6009848")]
		[Address(RVA = "0x3130270", Offset = "0x312EE70", VA = "0x183130270")]
		public VoiceLangType GetVoiceLangTypeFromHotUpdatePref()
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x0003B478 File Offset: 0x00039678
		[Token(Token = "0x6009849")]
		[Address(RVA = "0x3131E50", Offset = "0x3130A50", VA = "0x183131E50")]
		private static VoiceLangType _GetGlobalLangTypeFromPlayerPref()
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x0003B490 File Offset: 0x00039690
		[Token(Token = "0x600984A")]
		[Address(RVA = "0x3132290", Offset = "0x3130E90", VA = "0x183132290")]
		private static VoiceLangType _PrefToLangType(VoiceLangManager.HotUpdatePref pref)
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600984B")]
		[Address(RVA = "0x31308E0", Offset = "0x312F4E0", VA = "0x1831308E0")]
		public static string HotUpdatePrefToResType(VoiceLangManager.HotUpdatePref pref)
		{
			return null;
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x0003B4A8 File Offset: 0x000396A8
		[Token(Token = "0x600984C")]
		[Address(RVA = "0x31317B0", Offset = "0x31303B0", VA = "0x1831317B0")]
		public bool ShouldSelectGlobalPref()
		{
			return default(bool);
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x0003B4C0 File Offset: 0x000396C0
		[Token(Token = "0x600984D")]
		[Address(RVA = "0x31309F0", Offset = "0x312F5F0", VA = "0x1831309F0")]
		public bool IsCharNeedNewVoiceTrackPoint(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600984E")]
		[Address(RVA = "0x3131040", Offset = "0x312FC40", VA = "0x183131040")]
		public void SaveCharNewVoiceVisited(string charId)
		{
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600984F")]
		[Address(RVA = "0x3131230", Offset = "0x312FE30", VA = "0x183131230")]
		public void SaveCharsNewVoiceVisited(IEnumerator<string> charIdIter)
		{
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x0003B4D8 File Offset: 0x000396D8
		[Token(Token = "0x6009850")]
		[Address(RVA = "0x3130AC0", Offset = "0x312F6C0", VA = "0x183130AC0")]
		public bool IsCharWithTypeNeedNewTrackPoint(string charId, VoiceLangType voiceLangType)
		{
			return default(bool);
		}

		// Token: 0x06009851 RID: 38993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009851")]
		[Address(RVA = "0x3131110", Offset = "0x312FD10", VA = "0x183131110")]
		public void SaveCharWithTypeNewVisited(string charId, VoiceLangType voiceLangType)
		{
		}

		// Token: 0x06009852 RID: 38994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009852")]
		[Address(RVA = "0x3131470", Offset = "0x3130070", VA = "0x183131470")]
		public void SaveCharsWithTypeNewVisited(IEnumerator<string> charIdIter)
		{
		}

		// Token: 0x06009853 RID: 38995 RVA: 0x0003B4F0 File Offset: 0x000396F0
		[Token(Token = "0x6009853")]
		[Address(RVA = "0x3131FD0", Offset = "0x3130BD0", VA = "0x183131FD0")]
		private static VoiceLangManager.VoicePath _GetVoicePath(VoiceLangType langType, string wordKey, string voiceAsset)
		{
			return default(VoiceLangManager.VoicePath);
		}

		// Token: 0x06009854 RID: 38996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009854")]
		[Address(RVA = "0x3131ED0", Offset = "0x3130AD0", VA = "0x183131ED0")]
		private NewVoiceTimeData _GetPrevNearestTimeDataInList(List<NewVoiceTimeData> timeSortedList, long timestamp)
		{
			return null;
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009855")]
		[Address(RVA = "0x3130300", Offset = "0x312EF00", VA = "0x183130300")]
		public static string GetVoicePathByGroupType(VoiceLangGroupType groupType, string wordKey, string voiceAsset)
		{
			return null;
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009856")]
		[Address(RVA = "0x3130830", Offset = "0x312F430", VA = "0x183130830")]
		public static string GetVoiceSettingTrackType(VoiceLangType voiceType)
		{
			return null;
		}

		// Token: 0x04008E21 RID: 36385
		[Token(Token = "0x4008E21")]
		[FieldOffset(Offset = "0x0")]
		private static readonly VoiceLangType[] I18N_PREF_ORDER_FLEX;

		// Token: 0x04008E22 RID: 36386
		[Token(Token = "0x4008E22")]
		[FieldOffset(Offset = "0x8")]
		private static readonly VoiceLangType[] I18N_PREF_ORDER_FIXED;

		// Token: 0x04008E23 RID: 36387
		[Token(Token = "0x4008E23")]
		[FieldOffset(Offset = "0x10")]
		private VoiceLangManager.HotUpdatePref m_hotupdatePrefCache;

		// Token: 0x04008E24 RID: 36388
		[Token(Token = "0x4008E24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EnumerateTypeWithI18NPrefOrder;

		// Token: 0x04008E25 RID: 36389
		[Token(Token = "0x4008E25")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008E26 RID: 36390
		[Token(Token = "0x4008E26")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCharVoiceLangType;

		// Token: 0x04008E27 RID: 36391
		[Token(Token = "0x4008E27")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetVoicePathWithPlayerChar;

		// Token: 0x04008E28 RID: 36392
		[Token(Token = "0x4008E28")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryHookAudioByFxLang;

		// Token: 0x04008E29 RID: 36393
		[Token(Token = "0x4008E29")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCharLangTypeOrDefault;

		// Token: 0x04008E2A RID: 36394
		[Token(Token = "0x4008E2A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetVoicePathByType;

		// Token: 0x04008E2B RID: 36395
		[Token(Token = "0x4008E2B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetCharDefaultVoiceLangType;

		// Token: 0x04008E2C RID: 36396
		[Token(Token = "0x4008E2C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckVoiceLangTypeValid;

		// Token: 0x04008E2D RID: 36397
		[Token(Token = "0x4008E2D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckVoiceLangGroupResValid;

		// Token: 0x04008E2E RID: 36398
		[Token(Token = "0x4008E2E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckVoiceLangTypeResValid;

		// Token: 0x04008E2F RID: 36399
		[Token(Token = "0x4008E2F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckWordKeyDisplay;

		// Token: 0x04008E30 RID: 36400
		[Token(Token = "0x4008E30")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadResValidPrevNearestTimeData;

		// Token: 0x04008E31 RID: 36401
		[Token(Token = "0x4008E31")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetGlobalVoiceLang;

		// Token: 0x04008E32 RID: 36402
		[Token(Token = "0x4008E32")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateGlobalVoiceLangWithPlayerData;

		// Token: 0x04008E33 RID: 36403
		[Token(Token = "0x4008E33")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SetHotUpdatePref;

		// Token: 0x04008E34 RID: 36404
		[Token(Token = "0x4008E34")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetVoiceLangTypeFromHotUpdatePref;

		// Token: 0x04008E35 RID: 36405
		[Token(Token = "0x4008E35")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetGlobalLangTypeFromPlayerPref;

		// Token: 0x04008E36 RID: 36406
		[Token(Token = "0x4008E36")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PrefToLangType;

		// Token: 0x04008E37 RID: 36407
		[Token(Token = "0x4008E37")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HotUpdatePrefToResType;

		// Token: 0x04008E38 RID: 36408
		[Token(Token = "0x4008E38")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ShouldSelectGlobalPref;

		// Token: 0x04008E39 RID: 36409
		[Token(Token = "0x4008E39")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_IsCharNeedNewVoiceTrackPoint;

		// Token: 0x04008E3A RID: 36410
		[Token(Token = "0x4008E3A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SaveCharNewVoiceVisited;

		// Token: 0x04008E3B RID: 36411
		[Token(Token = "0x4008E3B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SaveCharsNewVoiceVisited;

		// Token: 0x04008E3C RID: 36412
		[Token(Token = "0x4008E3C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_IsCharWithTypeNeedNewTrackPoint;

		// Token: 0x04008E3D RID: 36413
		[Token(Token = "0x4008E3D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SaveCharWithTypeNewVisited;

		// Token: 0x04008E3E RID: 36414
		[Token(Token = "0x4008E3E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_SaveCharsWithTypeNewVisited;

		// Token: 0x04008E3F RID: 36415
		[Token(Token = "0x4008E3F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetVoicePath;

		// Token: 0x04008E40 RID: 36416
		[Token(Token = "0x4008E40")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GetPrevNearestTimeDataInList;

		// Token: 0x04008E41 RID: 36417
		[Token(Token = "0x4008E41")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetVoicePathByGroupType;

		// Token: 0x04008E42 RID: 36418
		[Token(Token = "0x4008E42")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetVoiceSettingTrackType;

		// Token: 0x0200178D RID: 6029
		[Token(Token = "0x200178D")]
		public enum HotUpdatePref
		{
			// Token: 0x04008E44 RID: 36420
			[Token(Token = "0x4008E44")]
			NONE,
			// Token: 0x04008E45 RID: 36421
			[Token(Token = "0x4008E45")]
			CN,
			// Token: 0x04008E46 RID: 36422
			[Token(Token = "0x4008E46")]
			JP,
			// Token: 0x04008E47 RID: 36423
			[Token(Token = "0x4008E47")]
			EN,
			// Token: 0x04008E48 RID: 36424
			[Token(Token = "0x4008E48")]
			KR,
			// Token: 0x04008E49 RID: 36425
			[Token(Token = "0x4008E49")]
			DONT_CHANGE
		}

		// Token: 0x0200178E RID: 6030
		[Token(Token = "0x200178E")]
		public struct VoicePath
		{
			// Token: 0x06009858 RID: 39000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009858")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			public static implicit operator string(VoiceLangManager.VoicePath voicePathStuct)
			{
				return null;
			}

			// Token: 0x04008E4A RID: 36426
			[Token(Token = "0x4008E4A")]
			[FieldOffset(Offset = "0x0")]
			public static VoiceLangManager.VoicePath EMPTY;

			// Token: 0x04008E4B RID: 36427
			[Token(Token = "0x4008E4B")]
			[FieldOffset(Offset = "0x0")]
			public string voicePath;

			// Token: 0x04008E4C RID: 36428
			[Token(Token = "0x4008E4C")]
			[FieldOffset(Offset = "0x8")]
			public VoiceLangType voiceLangType;
		}
	}
}
