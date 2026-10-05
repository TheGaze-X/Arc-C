using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001372 RID: 4978
	[Token(Token = "0x2001372")]
	[Serializable]
	public class StageTable
	{
		// Token: 0x0600733D RID: 29501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733D")]
		[Address(RVA = "0x2213D10", Offset = "0x2212910", VA = "0x182213D10")]
		public StageTable()
		{
		}

		// Token: 0x04006E4E RID: 28238
		[Token(Token = "0x4006E4E")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, StageData> stages;

		// Token: 0x04006E4F RID: 28239
		[Token(Token = "0x4006E4F")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RuneStageGroupData> runeStageGroups;

		// Token: 0x04006E50 RID: 28240
		[Token(Token = "0x4006E50")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, MapThemeData> mapThemes;

		// Token: 0x04006E51 RID: 28241
		[Token(Token = "0x4006E51")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, TileAppendInfo> tileInfo;

		// Token: 0x04006E52 RID: 28242
		[Token(Token = "0x4006E52")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, WeeklyForceOpenTable> forceOpenTable;

		// Token: 0x04006E53 RID: 28243
		[Token(Token = "0x4006E53")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, TimelyDropTimeInfo> timelyStageDropInfo;

		// Token: 0x04006E54 RID: 28244
		[Token(Token = "0x4006E54")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, OverrideDropInfo> overrideDropInfo;

		// Token: 0x04006E55 RID: 28245
		[Token(Token = "0x4006E55")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, OverrideUnlockInfo> overrideUnlockInfo;

		// Token: 0x04006E56 RID: 28246
		[Token(Token = "0x4006E56")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, TimelyDropInfo> timelyTable;

		// Token: 0x04006E57 RID: 28247
		[Token(Token = "0x4006E57")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, StageValidInfo> stageValidInfo;

		// Token: 0x04006E58 RID: 28248
		[Token(Token = "0x4006E58")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, StageFogInfo> stageFogInfo;

		// Token: 0x04006E59 RID: 28249
		[Token(Token = "0x4006E59")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, StageStartCond> stageStartConds;

		// Token: 0x04006E5A RID: 28250
		[Token(Token = "0x4006E5A")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, StageDiffGroupTable> diffGroupTable;

		// Token: 0x04006E5B RID: 28251
		[Token(Token = "0x4006E5B")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, Dictionary<StageDiffGroup, StoryStageShowGroup>> storyStageShowGroup;

		// Token: 0x04006E5C RID: 28252
		[Token(Token = "0x4006E5C")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, SpecialBattleFinishStageData> specialBattleFinishStageData;

		// Token: 0x04006E5D RID: 28253
		[Token(Token = "0x4006E5D")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, RecordRewardServerData> recordRewardData;

		// Token: 0x04006E5E RID: 28254
		[Token(Token = "0x4006E5E")]
		[FieldOffset(Offset = "0x90")]
		public Dictionary<string, ApProtectZoneInfo> apProtectZoneInfo;

		// Token: 0x04006E5F RID: 28255
		[Token(Token = "0x4006E5F")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<string, List<string>> antiSpoilerDict;

		// Token: 0x04006E60 RID: 28256
		[Token(Token = "0x4006E60")]
		[FieldOffset(Offset = "0xA0")]
		public Dictionary<string, ActCustomStageData> actCustomStageDatas;

		// Token: 0x04006E61 RID: 28257
		[Token(Token = "0x4006E61")]
		[FieldOffset(Offset = "0xA8")]
		public List<string> spNormalStageIdFor4StarList;

		// Token: 0x04006E62 RID: 28258
		[Token(Token = "0x4006E62")]
		[FieldOffset(Offset = "0xB0")]
		public ListDict<string, StorylineData> storylines;

		// Token: 0x04006E63 RID: 28259
		[Token(Token = "0x4006E63")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<string, StorylineStorySetData> storylineStorySets;

		// Token: 0x04006E64 RID: 28260
		[Token(Token = "0x4006E64")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<string, StorylineTagData> storylineTags;

		// Token: 0x04006E65 RID: 28261
		[Token(Token = "0x4006E65")]
		[FieldOffset(Offset = "0xC8")]
		public StorylineConstData storylineConst;

		// Token: 0x04006E66 RID: 28262
		[Token(Token = "0x4006E66")]
		[FieldOffset(Offset = "0xD0")]
		public Dictionary<string, CGGalleryDisplayData> cgGalleryDisplays;

		// Token: 0x04006E67 RID: 28263
		[Token(Token = "0x4006E67")]
		[FieldOffset(Offset = "0xD8")]
		public Dictionary<string, CGGalleryGroupData> cgGalleryGroups;

		// Token: 0x04006E68 RID: 28264
		[Token(Token = "0x4006E68")]
		[FieldOffset(Offset = "0xE0")]
		public Dictionary<string, CGGalleryCGData> cgGalleryCgs;

		// Token: 0x04006E69 RID: 28265
		[Token(Token = "0x4006E69")]
		[FieldOffset(Offset = "0xE8")]
		public Dictionary<string, SixStarRuneData> sixStarRuneData;

		// Token: 0x04006E6A RID: 28266
		[Token(Token = "0x4006E6A")]
		[FieldOffset(Offset = "0xF0")]
		public Dictionary<string, SixStarMilestoneGroupData> sixStarMilestoneInfo;

		// Token: 0x04006E6B RID: 28267
		[Token(Token = "0x4006E6B")]
		[FieldOffset(Offset = "0xF8")]
		public Dictionary<string, SixStarLinkedStageCompatibleInfo> sixStarCompatibleInfo;

		// Token: 0x04006E6C RID: 28268
		[Token(Token = "0x4006E6C")]
		[FieldOffset(Offset = "0x100")]
		public Dictionary<string, ConditionalDropInfo> conditionalDropInfo;
	}
}
