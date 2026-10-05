using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005BD RID: 1469
	[Token(Token = "0x20005BD")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/DisplayMetaTable")]
	[Serializable]
	public class DisplayMetaDB : ConstTable<DisplayMetaData, DisplayMetaDB>
	{
		// Token: 0x06006102 RID: 24834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006102")]
		[Address(RVA = "0x1CED110", Offset = "0x1CEBD10", VA = "0x181CED110", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006103")]
		[Address(RVA = "0x1CED810", Offset = "0x1CEC410", VA = "0x181CED810")]
		private void _InitAVGDialogSettings()
		{
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006104")]
		[Address(RVA = "0x1CEC630", Offset = "0x1CEB230", VA = "0x181CEC630")]
		public HomeBackgroundSingleData GetHomeBgDataById(string id)
		{
			return null;
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006105")]
		[Address(RVA = "0x1CEC7A0", Offset = "0x1CEB3A0", VA = "0x181CEC7A0")]
		public HomeThemeDisplayData GetHomeThemeDataById(string id)
		{
			return null;
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006106")]
		[Address(RVA = "0x1CEC710", Offset = "0x1CEB310", VA = "0x181CEC710")]
		public string GetHomeBgDefaultMusicId()
		{
			return null;
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006107")]
		[Address(RVA = "0x1CEDA30", Offset = "0x1CEC630", VA = "0x181CEDA30")]
		private void _InitMultiFormRuleInfo()
		{
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006108")]
		[Address(RVA = "0x1CEDC60", Offset = "0x1CEC860", VA = "0x181CEDC60")]
		private void _InitMultiFormTimeRule()
		{
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006109")]
		[Address(RVA = "0x1CEC950", Offset = "0x1CEB550", VA = "0x181CEC950")]
		public HomeMultiFormInfoData GetMultiFormRuleInfo(HomeMultiFormChangeRule rule)
		{
			return null;
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600610A")]
		[Address(RVA = "0x1CED080", Offset = "0x1CEBC80", VA = "0x181CED080")]
		public List<int> GetTimeRuleStamps(string id)
		{
			return null;
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600610B")]
		[Address(RVA = "0x1CEC350", Offset = "0x1CEAF50", VA = "0x181CEC350")]
		public PlayerAvatarPerData GetAvatarDataById(string id)
		{
			return null;
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
		[Token(Token = "0x600610C")]
		[Address(RVA = "0x1CED730", Offset = "0x1CEC330", VA = "0x181CED730")]
		public bool TryGetAvatarDataById(string id, out PlayerAvatarPerData data)
		{
			return default(bool);
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600610D")]
		[Address(RVA = "0x1CEC410", Offset = "0x1CEB010", VA = "0x181CEC410")]
		public PlayerAvatarGroupData GetAvatarGroupDataByType(PlayerAvatarGroupType type)
		{
			return null;
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600610E")]
		[Address(RVA = "0x1CECA10", Offset = "0x1CEB610", VA = "0x181CECA10")]
		public NameCardV2ModuleData GetNameCardFixedModuleDataById(string id)
		{
			return null;
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600610F")]
		[Address(RVA = "0x1CECB40", Offset = "0x1CEB740", VA = "0x181CECB40")]
		public NameCardV2RemovableModuleData GetNameCardRemovableModuleDataById(string id)
		{
			return null;
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006110")]
		[Address(RVA = "0x1CECC70", Offset = "0x1CEB870", VA = "0x181CECC70")]
		public NameCardV2SkinData GetNameCardSkinDataById(string id)
		{
			return null;
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006111")]
		[Address(RVA = "0x1CEC2C0", Offset = "0x1CEAEC0", VA = "0x181CEC2C0")]
		public List<AVGDialogPresetData> GetAVGDialogPresetList()
		{
			return null;
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006112")]
		[Address(RVA = "0x1CEC200", Offset = "0x1CEAE00", VA = "0x181CEC200")]
		public AVGDialogPresetData GetAVGDialogPresetById(int presetId)
		{
			return null;
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006113")]
		[Address(RVA = "0x1CEC4D0", Offset = "0x1CEB0D0", VA = "0x181CEC4D0")]
		public AVGDialogPresetData GetDefaultAVGDialogPreset()
		{
			return null;
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006114")]
		[Address(RVA = "0x1CEE000", Offset = "0x1CECC00", VA = "0x181CEE000")]
		private void _InitVariantDict()
		{
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
		[Token(Token = "0x6006115")]
		[Address(RVA = "0x1CED650", Offset = "0x1CEC250", VA = "0x181CED650")]
		public bool StoryVariantExist(string storyId, out List<StoryVariantData> variants)
		{
			return default(bool);
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006116")]
		[Address(RVA = "0x1CECE70", Offset = "0x1CEBA70", VA = "0x181CECE70")]
		public string GetStoryVariantId(string storyId)
		{
			return null;
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006117")]
		[Address(RVA = "0x1CEC880", Offset = "0x1CEB480", VA = "0x181CEC880")]
		public MagazineLeafItemData GetMagazineLeafItemDataById(string id)
		{
			return null;
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006118")]
		[Address(RVA = "0x1CECDA0", Offset = "0x1CEB9A0", VA = "0x181CECDA0")]
		public StickerItemData GetStickerItemDataById(string id)
		{
			return null;
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006119")]
		[Address(RVA = "0x1CEE330", Offset = "0x1CECF30", VA = "0x181CEE330")]
		public DisplayMetaDB()
		{
		}

		// Token: 0x04002A8B RID: 10891
		[Token(Token = "0x4002A8B")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, PlayerAvatarPerData> m_avatarDataMap;

		// Token: 0x04002A8C RID: 10892
		[Token(Token = "0x4002A8C")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<PlayerAvatarGroupType, PlayerAvatarGroupData> m_avatarGroupMap;

		// Token: 0x04002A8D RID: 10893
		[Token(Token = "0x4002A8D")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Dictionary<string, HomeBackgroundSingleData> m_homeBgDic;

		// Token: 0x04002A8E RID: 10894
		[Token(Token = "0x4002A8E")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private Dictionary<string, HomeThemeDisplayData> m_homeThemeDic;

		// Token: 0x04002A8F RID: 10895
		[Token(Token = "0x4002A8F")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private Dictionary<string, List<StoryVariantData>> m_storyToVariantDict;

		// Token: 0x04002A90 RID: 10896
		[Token(Token = "0x4002A90")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private EnumIntDictionary<HomeMultiFormChangeRule, HomeMultiFormInfoData> m_ruleInfoDict;

		// Token: 0x04002A91 RID: 10897
		[Token(Token = "0x4002A91")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private Dictionary<string, List<int>> m_timeRuleStamps;

		// Token: 0x04002A92 RID: 10898
		[Token(Token = "0x4002A92")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private Dictionary<int, AVGDialogPresetData> m_avgDialogPresetMap;

		// Token: 0x04002A93 RID: 10899
		[Token(Token = "0x4002A93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002A94 RID: 10900
		[Token(Token = "0x4002A94")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitAVGDialogSettings;

		// Token: 0x04002A95 RID: 10901
		[Token(Token = "0x4002A95")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetHomeBgDataById;

		// Token: 0x04002A96 RID: 10902
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetHomeThemeDataById;

		// Token: 0x04002A97 RID: 10903
		[Token(Token = "0x4002A97")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetHomeBgDefaultMusicId;

		// Token: 0x04002A98 RID: 10904
		[Token(Token = "0x4002A98")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitMultiFormRuleInfo;

		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitMultiFormTimeRule;

		// Token: 0x04002A9A RID: 10906
		[Token(Token = "0x4002A9A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetMultiFormRuleInfo;

		// Token: 0x04002A9B RID: 10907
		[Token(Token = "0x4002A9B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetTimeRuleStamps;

		// Token: 0x04002A9C RID: 10908
		[Token(Token = "0x4002A9C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetAvatarDataById;

		// Token: 0x04002A9D RID: 10909
		[Token(Token = "0x4002A9D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryGetAvatarDataById;

		// Token: 0x04002A9E RID: 10910
		[Token(Token = "0x4002A9E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetAvatarGroupDataByType;

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetNameCardFixedModuleDataById;

		// Token: 0x04002AA0 RID: 10912
		[Token(Token = "0x4002AA0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetNameCardRemovableModuleDataById;

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetNameCardSkinDataById;

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetAVGDialogPresetList;

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetAVGDialogPresetById;

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetDefaultAVGDialogPreset;

		// Token: 0x04002AA5 RID: 10917
		[Token(Token = "0x4002AA5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitVariantDict;

		// Token: 0x04002AA6 RID: 10918
		[Token(Token = "0x4002AA6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_StoryVariantExist;

		// Token: 0x04002AA7 RID: 10919
		[Token(Token = "0x4002AA7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetStoryVariantId;

		// Token: 0x04002AA8 RID: 10920
		[Token(Token = "0x4002AA8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetMagazineLeafItemDataById;

		// Token: 0x04002AA9 RID: 10921
		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetStickerItemDataById;

		// Token: 0x04002AAA RID: 10922
		[Token(Token = "0x4002AAA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
