using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E83 RID: 20099
	[Token(Token = "0x2004E83")]
	public class FireworkCraftModel : IHotfixable
	{
		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x0601DFE3 RID: 122851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004664")]
		public FireworkCraftModel.CraftStageInfoModel selectedStageModel
		{
			[Token(Token = "0x601DFE3")]
			[Address(RVA = "0x179EAE0", Offset = "0x179D6E0", VA = "0x18179EAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DFE4 RID: 122852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFE4")]
		[Address(RVA = "0x179E580", Offset = "0x179D180", VA = "0x18179E580")]
		private void _LoadFireworkData(FireworkData fireworkData)
		{
		}

		// Token: 0x0601DFE5 RID: 122853 RVA: 0x000AD1F0 File Offset: 0x000AB3F0
		[Token(Token = "0x601DFE5")]
		[Address(RVA = "0x179E460", Offset = "0x179D060", VA = "0x18179E460")]
		private bool _CheckIfHaveAnimalNewTrack(List<string> animalIdList)
		{
			return default(bool);
		}

		// Token: 0x0601DFE6 RID: 122854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFE6")]
		[Address(RVA = "0x179D4A0", Offset = "0x179C0A0", VA = "0x18179D4A0")]
		public void LoadData(FireworkCraftModel.Input input)
		{
		}

		// Token: 0x0601DFE7 RID: 122855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFE7")]
		[Address(RVA = "0x179DF50", Offset = "0x179CB50", VA = "0x18179DF50")]
		public void RefreshData()
		{
		}

		// Token: 0x0601DFE8 RID: 122856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFE8")]
		[Address(RVA = "0x179E3F0", Offset = "0x179CFF0", VA = "0x18179E3F0")]
		public void SetEditStatus(FireworkCraftModel.EditStatus status)
		{
		}

		// Token: 0x0601DFE9 RID: 122857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFE9")]
		[Address(RVA = "0x179E230", Offset = "0x179CE30", VA = "0x18179E230")]
		public void SelectStage(string stageId)
		{
		}

		// Token: 0x0601DFEA RID: 122858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFEA")]
		[Address(RVA = "0x179E2F0", Offset = "0x179CEF0", VA = "0x18179E2F0")]
		public void SelectZone(string zoneId, bool useFirstLockedStage = false)
		{
		}

		// Token: 0x0601DFEB RID: 122859 RVA: 0x000AD208 File Offset: 0x000AB408
		[Token(Token = "0x601DFEB")]
		[Address(RVA = "0x179D3C0", Offset = "0x179BFC0", VA = "0x18179D3C0")]
		public bool IsZoneLocked(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0601DFEC RID: 122860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFEC")]
		[Address(RVA = "0x179E950", Offset = "0x179D550", VA = "0x18179E950")]
		public FireworkCraftModel()
		{
		}

		// Token: 0x04027D78 RID: 163192
		[Token(Token = "0x4027D78")]
		[FieldOffset(Offset = "0x10")]
		public int enterSeqNum;

		// Token: 0x04027D79 RID: 163193
		[Token(Token = "0x4027D79")]
		[FieldOffset(Offset = "0x14")]
		public FireworkCraftModel.EditStatus status;

		// Token: 0x04027D7A RID: 163194
		[Token(Token = "0x4027D7A")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, FireworkCraftModel.CraftZoneInfoModel> zoneDict;

		// Token: 0x04027D7B RID: 163195
		[Token(Token = "0x4027D7B")]
		[FieldOffset(Offset = "0x20")]
		public string selectedStageId;

		// Token: 0x04027D7C RID: 163196
		[Token(Token = "0x4027D7C")]
		[FieldOffset(Offset = "0x28")]
		public string selectedZoneId;

		// Token: 0x04027D7D RID: 163197
		[Token(Token = "0x4027D7D")]
		[FieldOffset(Offset = "0x30")]
		public string currentAnimalId;

		// Token: 0x04027D7E RID: 163198
		[Token(Token = "0x4027D7E")]
		[FieldOffset(Offset = "0x38")]
		public string currentAnimalIconId;

		// Token: 0x04027D7F RID: 163199
		[Token(Token = "0x4027D7F")]
		[FieldOffset(Offset = "0x40")]
		public string currentAnimalNameId;

		// Token: 0x04027D80 RID: 163200
		[Token(Token = "0x4027D80")]
		[FieldOffset(Offset = "0x48")]
		public string currentAnimalBuffDesc;

		// Token: 0x04027D81 RID: 163201
		[Token(Token = "0x4027D81")]
		[FieldOffset(Offset = "0x50")]
		public bool hasNewAnimalMark;

		// Token: 0x04027D82 RID: 163202
		[Token(Token = "0x4027D82")]
		[FieldOffset(Offset = "0x58")]
		public List<string> platePieceList;

		// Token: 0x04027D83 RID: 163203
		[Token(Token = "0x4027D83")]
		[FieldOffset(Offset = "0x60")]
		public FireworkPlateGroupModel plateGroupViewModel;

		// Token: 0x04027D84 RID: 163204
		[Token(Token = "0x4027D84")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, FireworkCraftModel.CraftStageInfoModel> m_stageDict;

		// Token: 0x04027D85 RID: 163205
		[Token(Token = "0x4027D85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedStageModel;

		// Token: 0x04027D86 RID: 163206
		[Token(Token = "0x4027D86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadFireworkData;

		// Token: 0x04027D87 RID: 163207
		[Token(Token = "0x4027D87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfHaveAnimalNewTrack;

		// Token: 0x04027D88 RID: 163208
		[Token(Token = "0x4027D88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027D89 RID: 163209
		[Token(Token = "0x4027D89")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04027D8A RID: 163210
		[Token(Token = "0x4027D8A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetEditStatus;

		// Token: 0x04027D8B RID: 163211
		[Token(Token = "0x4027D8B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SelectStage;

		// Token: 0x04027D8C RID: 163212
		[Token(Token = "0x4027D8C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SelectZone;

		// Token: 0x04027D8D RID: 163213
		[Token(Token = "0x4027D8D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsZoneLocked;

		// Token: 0x04027D8E RID: 163214
		[Token(Token = "0x4027D8E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E84 RID: 20100
		[Token(Token = "0x2004E84")]
		public enum EditStatus
		{
			// Token: 0x04027D90 RID: 163216
			[Token(Token = "0x4027D90")]
			FIREWORK_WITH_NO_STAGE_BG,
			// Token: 0x04027D91 RID: 163217
			[Token(Token = "0x4027D91")]
			FIREWORK_WITH_STAGE_BG,
			// Token: 0x04027D92 RID: 163218
			[Token(Token = "0x4027D92")]
			STAGE_CHOOSE
		}

		// Token: 0x02004E85 RID: 20101
		[Token(Token = "0x2004E85")]
		public enum OpenSource
		{
			// Token: 0x04027D94 RID: 163220
			[Token(Token = "0x4027D94")]
			ZONE,
			// Token: 0x04027D95 RID: 163221
			[Token(Token = "0x4027D95")]
			STAGE
		}

		// Token: 0x02004E86 RID: 20102
		[Token(Token = "0x2004E86")]
		public class CraftStageInfoModel : IHotfixable, IComparable<FireworkCraftModel.CraftStageInfoModel>
		{
			// Token: 0x0601DFED RID: 122861 RVA: 0x000AD220 File Offset: 0x000AB420
			[Token(Token = "0x601DFED")]
			[Address(RVA = "0x1799890", Offset = "0x1798490", VA = "0x181799890", Slot = "4")]
			public int CompareTo(FireworkCraftModel.CraftStageInfoModel other)
			{
				return 0;
			}

			// Token: 0x0601DFEE RID: 122862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DFEE")]
			[Address(RVA = "0x1799930", Offset = "0x1798530", VA = "0x181799930")]
			public CraftStageInfoModel()
			{
			}

			// Token: 0x04027D96 RID: 163222
			[Token(Token = "0x4027D96")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04027D97 RID: 163223
			[Token(Token = "0x4027D97")]
			[FieldOffset(Offset = "0x18")]
			public string stageCode;

			// Token: 0x04027D98 RID: 163224
			[Token(Token = "0x4027D98")]
			[FieldOffset(Offset = "0x20")]
			public string stageName;

			// Token: 0x04027D99 RID: 163225
			[Token(Token = "0x4027D99")]
			[FieldOffset(Offset = "0x28")]
			public string zoneId;

			// Token: 0x04027D9A RID: 163226
			[Token(Token = "0x4027D9A")]
			[FieldOffset(Offset = "0x30")]
			public bool isSpecialStage;

			// Token: 0x04027D9B RID: 163227
			[Token(Token = "0x4027D9B")]
			[FieldOffset(Offset = "0x34")]
			public int stageRank;

			// Token: 0x04027D9C RID: 163228
			[Token(Token = "0x4027D9C")]
			[FieldOffset(Offset = "0x38")]
			public int sortId;

			// Token: 0x04027D9D RID: 163229
			[Token(Token = "0x4027D9D")]
			[FieldOffset(Offset = "0x3C")]
			public PlayerStageState stageState;

			// Token: 0x04027D9E RID: 163230
			[Token(Token = "0x4027D9E")]
			[FieldOffset(Offset = "0x40")]
			public int trapPosX;

			// Token: 0x04027D9F RID: 163231
			[Token(Token = "0x4027D9F")]
			[FieldOffset(Offset = "0x44")]
			public int trapPosY;

			// Token: 0x04027DA0 RID: 163232
			[Token(Token = "0x4027DA0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x04027DA1 RID: 163233
			[Token(Token = "0x4027DA1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004E87 RID: 20103
		[Token(Token = "0x2004E87")]
		public class CraftZoneInfoModel : IHotfixable, IComparable<FireworkCraftModel.CraftZoneInfoModel>
		{
			// Token: 0x0601DFEF RID: 122863 RVA: 0x000AD238 File Offset: 0x000AB438
			[Token(Token = "0x601DFEF")]
			[Address(RVA = "0x1799990", Offset = "0x1798590", VA = "0x181799990", Slot = "4")]
			public int CompareTo(FireworkCraftModel.CraftZoneInfoModel other)
			{
				return 0;
			}

			// Token: 0x0601DFF0 RID: 122864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DFF0")]
			[Address(RVA = "0x1799A30", Offset = "0x1798630", VA = "0x181799A30")]
			public CraftZoneInfoModel()
			{
			}

			// Token: 0x04027DA2 RID: 163234
			[Token(Token = "0x4027DA2")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04027DA3 RID: 163235
			[Token(Token = "0x4027DA3")]
			[FieldOffset(Offset = "0x18")]
			public string zoneName;

			// Token: 0x04027DA4 RID: 163236
			[Token(Token = "0x4027DA4")]
			[FieldOffset(Offset = "0x20")]
			public bool isUnlock;

			// Token: 0x04027DA5 RID: 163237
			[Token(Token = "0x4027DA5")]
			[FieldOffset(Offset = "0x28")]
			public List<FireworkCraftModel.CraftStageInfoModel> stages;

			// Token: 0x04027DA6 RID: 163238
			[Token(Token = "0x4027DA6")]
			[FieldOffset(Offset = "0x30")]
			public int sortIdByStage;

			// Token: 0x04027DA7 RID: 163239
			[Token(Token = "0x4027DA7")]
			[FieldOffset(Offset = "0x38")]
			public string firstLockedNonSpStageId;

			// Token: 0x04027DA8 RID: 163240
			[Token(Token = "0x4027DA8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x04027DA9 RID: 163241
			[Token(Token = "0x4027DA9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004E88 RID: 20104
		[Token(Token = "0x2004E88")]
		public class Input : IHotfixable
		{
			// Token: 0x0601DFF1 RID: 122865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DFF1")]
			[Address(RVA = "0x17B0720", Offset = "0x17AF320", VA = "0x1817B0720")]
			public Input()
			{
			}

			// Token: 0x04027DAA RID: 163242
			[Token(Token = "0x4027DAA")]
			[FieldOffset(Offset = "0x10")]
			public string defaultStageId;

			// Token: 0x04027DAB RID: 163243
			[Token(Token = "0x4027DAB")]
			[FieldOffset(Offset = "0x18")]
			public FireworkCraftModel.OpenSource source;

			// Token: 0x04027DAC RID: 163244
			[Token(Token = "0x4027DAC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
