using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Setting
{
	// Token: 0x02001E12 RID: 7698
	[Token(Token = "0x2001E12")]
	public class SettingManager : Singleton<SettingManager>
	{
		// Token: 0x0600BDE2 RID: 48610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BDE2")]
		[Address(RVA = "0x33C8F30", Offset = "0x33C7B30", VA = "0x1833C8F30")]
		public object GetData(SettingConstVars.SettingType type)
		{
			return null;
		}

		// Token: 0x0600BDE3 RID: 48611 RVA: 0x00046578 File Offset: 0x00044778
		[Token(Token = "0x600BDE3")]
		[Address(RVA = "0x33C9130", Offset = "0x33C7D30", VA = "0x1833C9130")]
		public float GetVolumnValue()
		{
			return 0f;
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE4")]
		[Address(RVA = "0x33CA160", Offset = "0x33C8D60", VA = "0x1833CA160")]
		public void SetData(SettingConstVars.SettingType type, object value, SettingConstVars.InstantFlag instant = SettingConstVars.InstantFlag.DELAY)
		{
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x00046590 File Offset: 0x00044790
		[Token(Token = "0x600BDE5")]
		[Address(RVA = "0x33C9000", Offset = "0x33C7C00", VA = "0x1833C9000")]
		public bool GetFlag(SettingConstVars.SettingType type)
		{
			return default(bool);
		}

		// Token: 0x0600BDE6 RID: 48614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE6")]
		[Address(RVA = "0x33CA270", Offset = "0x33C8E70", VA = "0x1833CA270")]
		public void SetFlag(SettingConstVars.SettingType type, bool value, SettingConstVars.InstantFlag instant = SettingConstVars.InstantFlag.DELAY)
		{
		}

		// Token: 0x0600BDE7 RID: 48615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE7")]
		[Address(RVA = "0x33C9500", Offset = "0x33C8100", VA = "0x1833C9500")]
		public void ResetData()
		{
		}

		// Token: 0x0600BDE8 RID: 48616 RVA: 0x000465A8 File Offset: 0x000447A8
		[Token(Token = "0x600BDE8")]
		[Address(RVA = "0x33CF530", Offset = "0x33CE130", VA = "0x1833CF530")]
		private bool _ResetDataWithType(SettingConstVars.SettingType type)
		{
			return default(bool);
		}

		// Token: 0x0600BDE9 RID: 48617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE9")]
		[Address(RVA = "0x33C9330", Offset = "0x33C7F30", VA = "0x1833C9330")]
		public void LoadPersonal()
		{
		}

		// Token: 0x0600BDEA RID: 48618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEA")]
		[Address(RVA = "0x33C9220", Offset = "0x33C7E20", VA = "0x1833C9220")]
		public void LoadCommon()
		{
		}

		// Token: 0x0600BDEB RID: 48619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEB")]
		[Address(RVA = "0x33CA070", Offset = "0x33C8C70", VA = "0x1833CA070")]
		public void Save()
		{
		}

		// Token: 0x0600BDEC RID: 48620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEC")]
		[Address(RVA = "0x33CF660", Offset = "0x33CE260", VA = "0x1833CF660")]
		protected SettingManager()
		{
		}

		// Token: 0x0600BDED RID: 48621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDED")]
		[Address(RVA = "0x33CCCD0", Offset = "0x33CB8D0", VA = "0x1833CCCD0")]
		private void _Init()
		{
		}

		// Token: 0x0600BDEE RID: 48622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEE")]
		[Address(RVA = "0x33CCA90", Offset = "0x33CB690", VA = "0x1833CCA90")]
		private void _InitDataByDataGroupType(SettingManager.DataGroupType dataGroupType)
		{
		}

		// Token: 0x0400BED7 RID: 48855
		[Token(Token = "0x400BED7")]
		[FieldOffset(Offset = "0x10")]
		private SettingManager.CommonSettingData m_commonSettingData;

		// Token: 0x0400BED8 RID: 48856
		[Token(Token = "0x400BED8")]
		[FieldOffset(Offset = "0x18")]
		private SettingManager.PersonalSettingData m_personalSettingData;

		// Token: 0x0400BED9 RID: 48857
		[Token(Token = "0x400BED9")]
		[FieldOffset(Offset = "0x20")]
		public Action<SettingConstVars.SettingType> instantSettingAction;

		// Token: 0x0400BEDA RID: 48858
		[Token(Token = "0x400BEDA")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<SettingConstVars.SettingType, SettingManager.SettingDataBinding> m_bindingDic;

		// Token: 0x0400BEDB RID: 48859
		[Token(Token = "0x400BEDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x0400BEDC RID: 48860
		[Token(Token = "0x400BEDC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetVolumnValue;

		// Token: 0x0400BEDD RID: 48861
		[Token(Token = "0x400BEDD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0400BEDE RID: 48862
		[Token(Token = "0x400BEDE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetFlag;

		// Token: 0x0400BEDF RID: 48863
		[Token(Token = "0x400BEDF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetFlag;

		// Token: 0x0400BEE0 RID: 48864
		[Token(Token = "0x400BEE0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetData;

		// Token: 0x0400BEE1 RID: 48865
		[Token(Token = "0x400BEE1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetDataWithType;

		// Token: 0x0400BEE2 RID: 48866
		[Token(Token = "0x400BEE2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadPersonal;

		// Token: 0x0400BEE3 RID: 48867
		[Token(Token = "0x400BEE3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadCommon;

		// Token: 0x0400BEE4 RID: 48868
		[Token(Token = "0x400BEE4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Save;

		// Token: 0x0400BEE5 RID: 48869
		[Token(Token = "0x400BEE5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400BEE6 RID: 48870
		[Token(Token = "0x400BEE6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400BEE7 RID: 48871
		[Token(Token = "0x400BEE7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitDataByDataGroupType;

		// Token: 0x02001E13 RID: 7699
		[Token(Token = "0x2001E13")]
		private enum DataGroupType
		{
			// Token: 0x0400BEE9 RID: 48873
			[Token(Token = "0x400BEE9")]
			COMMON_DATA = 1,
			// Token: 0x0400BEEA RID: 48874
			[Token(Token = "0x400BEEA")]
			PERSONAL_DATA
		}

		// Token: 0x02001E14 RID: 7700
		[Token(Token = "0x2001E14")]
		private class SettingDataBinding
		{
			// Token: 0x0600BE49 RID: 48713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BE49")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SettingDataBinding()
			{
			}

			// Token: 0x0400BEEB RID: 48875
			[Token(Token = "0x400BEEB")]
			[FieldOffset(Offset = "0x10")]
			public SettingManager.DataGroupType dataGroupType;

			// Token: 0x0400BEEC RID: 48876
			[Token(Token = "0x400BEEC")]
			[FieldOffset(Offset = "0x18")]
			public Func<object> getter;

			// Token: 0x0400BEED RID: 48877
			[Token(Token = "0x400BEED")]
			[FieldOffset(Offset = "0x20")]
			public Action<object> setter;

			// Token: 0x0400BEEE RID: 48878
			[Token(Token = "0x400BEEE")]
			[FieldOffset(Offset = "0x28")]
			public Func<object> init;
		}

		// Token: 0x02001E15 RID: 7701
		[Token(Token = "0x2001E15")]
		public struct ResolutionSetting
		{
			// Token: 0x0400BEEF RID: 48879
			[Token(Token = "0x400BEEF")]
			[FieldOffset(Offset = "0x0")]
			public int width;

			// Token: 0x0400BEF0 RID: 48880
			[Token(Token = "0x400BEF0")]
			[FieldOffset(Offset = "0x4")]
			public int height;

			// Token: 0x0400BEF1 RID: 48881
			[Token(Token = "0x400BEF1")]
			[FieldOffset(Offset = "0x8")]
			public bool isFullScreen;

			// Token: 0x0400BEF2 RID: 48882
			[Token(Token = "0x400BEF2")]
			[FieldOffset(Offset = "0x9")]
			public bool isBorderless;
		}

		// Token: 0x02001E16 RID: 7702
		[Token(Token = "0x2001E16")]
		[Serializable]
		public class CommonSettingData
		{
			// Token: 0x0600BE4A RID: 48714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BE4A")]
			[Address(RVA = "0x33C24C0", Offset = "0x33C10C0", VA = "0x1833C24C0")]
			public CommonSettingData()
			{
			}

			// Token: 0x0400BEF3 RID: 48883
			[Token(Token = "0x400BEF3")]
			[FieldOffset(Offset = "0x10")]
			public float seVolume;

			// Token: 0x0400BEF4 RID: 48884
			[Token(Token = "0x400BEF4")]
			[FieldOffset(Offset = "0x14")]
			public float musicVolume;

			// Token: 0x0400BEF5 RID: 48885
			[Token(Token = "0x400BEF5")]
			[FieldOffset(Offset = "0x18")]
			public float voiceVolumn;

			// Token: 0x0400BEF6 RID: 48886
			[Token(Token = "0x400BEF6")]
			[FieldOffset(Offset = "0x1C")]
			public bool seFlag;

			// Token: 0x0400BEF7 RID: 48887
			[Token(Token = "0x400BEF7")]
			[FieldOffset(Offset = "0x1D")]
			public bool musicFlag;

			// Token: 0x0400BEF8 RID: 48888
			[Token(Token = "0x400BEF8")]
			[FieldOffset(Offset = "0x1E")]
			public bool voiceFlag;

			// Token: 0x0400BEF9 RID: 48889
			[Token(Token = "0x400BEF9")]
			[FieldOffset(Offset = "0x1F")]
			public bool noVideoWhenHide;

			// Token: 0x0400BEFA RID: 48890
			[Token(Token = "0x400BEFA")]
			[FieldOffset(Offset = "0x20")]
			public bool limitFpsFlag;

			// Token: 0x0400BEFB RID: 48891
			[Token(Token = "0x400BEFB")]
			[FieldOffset(Offset = "0x21")]
			public bool bloomFlag;

			// Token: 0x0400BEFC RID: 48892
			[Token(Token = "0x400BEFC")]
			[FieldOffset(Offset = "0x22")]
			public bool battleCancelDirectionSelectHintFlag;

			// Token: 0x0400BEFD RID: 48893
			[Token(Token = "0x400BEFD")]
			[FieldOffset(Offset = "0x24")]
			public int performanceRate;

			// Token: 0x0400BEFE RID: 48894
			[Token(Token = "0x400BEFE")]
			[FieldOffset(Offset = "0x28")]
			public int fpsStrategy;

			// Token: 0x0400BEFF RID: 48895
			[Token(Token = "0x400BEFF")]
			[FieldOffset(Offset = "0x2C")]
			public bool antialiasingFlag;

			// Token: 0x0400BF00 RID: 48896
			[Token(Token = "0x400BF00")]
			[FieldOffset(Offset = "0x30")]
			public SettingManager.ResolutionSetting resolutionSetting;

			// Token: 0x0400BF01 RID: 48897
			[Token(Token = "0x400BF01")]
			[FieldOffset(Offset = "0x3C")]
			public float uiScaler;

			// Token: 0x0400BF02 RID: 48898
			[Token(Token = "0x400BF02")]
			[FieldOffset(Offset = "0x40")]
			public bool enableVSync;

			// Token: 0x0400BF03 RID: 48899
			[Token(Token = "0x400BF03")]
			[FieldOffset(Offset = "0x44")]
			public float cursorSize;
		}

		// Token: 0x02001E17 RID: 7703
		[Token(Token = "0x2001E17")]
		[Serializable]
		public class PersonalSettingData
		{
			// Token: 0x0600BE4B RID: 48715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BE4B")]
			[Address(RVA = "0x33C87F0", Offset = "0x33C73F0", VA = "0x1833C87F0")]
			public PersonalSettingData()
			{
			}

			// Token: 0x0400BF04 RID: 48900
			[Token(Token = "0x400BF04")]
			[FieldOffset(Offset = "0x10")]
			public bool rollbackToDefaultSpeedAfterSlowMotion;

			// Token: 0x0400BF05 RID: 48901
			[Token(Token = "0x400BF05")]
			[FieldOffset(Offset = "0x11")]
			public bool leaveBuildingHintFlag;

			// Token: 0x0400BF06 RID: 48902
			[Token(Token = "0x400BF06")]
			[FieldOffset(Offset = "0x12")]
			public bool manufactureAnnounceFlag;

			// Token: 0x0400BF07 RID: 48903
			[Token(Token = "0x400BF07")]
			[FieldOffset(Offset = "0x13")]
			public bool tradingAnnounceFlag;

			// Token: 0x0400BF08 RID: 48904
			[Token(Token = "0x400BF08")]
			[FieldOffset(Offset = "0x14")]
			public bool buildingCharTired;

			// Token: 0x0400BF09 RID: 48905
			[Token(Token = "0x400BF09")]
			[FieldOffset(Offset = "0x15")]
			public bool manufactureAutoSupplementFlag;

			// Token: 0x0400BF0A RID: 48906
			[Token(Token = "0x400BF0A")]
			[FieldOffset(Offset = "0x18")]
			public int dynamicIllustLoadStrategy;

			// Token: 0x0400BF0B RID: 48907
			[Token(Token = "0x400BF0B")]
			[FieldOffset(Offset = "0x1C")]
			public bool avgSkipDecisionWhenQuickPlay;

			// Token: 0x0400BF0C RID: 48908
			[Token(Token = "0x400BF0C")]
			[FieldOffset(Offset = "0x1D")]
			public bool enableDynamicEntrance;

			// Token: 0x0400BF0D RID: 48909
			[Token(Token = "0x400BF0D")]
			[FieldOffset(Offset = "0x20")]
			public int dynmaicEntranceLoginStrategy;

			// Token: 0x0400BF0E RID: 48910
			[Token(Token = "0x400BF0E")]
			[FieldOffset(Offset = "0x24")]
			public int charRotationUpdateStrategy;

			// Token: 0x0400BF0F RID: 48911
			[Token(Token = "0x400BF0F")]
			[FieldOffset(Offset = "0x28")]
			public bool buildingShowBatchNotify;

			// Token: 0x0400BF10 RID: 48912
			[Token(Token = "0x400BF10")]
			[FieldOffset(Offset = "0x29")]
			public bool enableBattleBtnKeyDisplay;
		}
	}
}
