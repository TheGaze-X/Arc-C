using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000D7B RID: 3451
	[Token(Token = "0x2000D7B")]
	public class Act9D0Data
	{
		// Token: 0x06006A4B RID: 27211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4B")]
		[Address(RVA = "0x1FF7CF0", Offset = "0x1FF68F0", VA = "0x181FF7CF0")]
		public Act9D0Data()
		{
		}

		// Token: 0x04004701 RID: 18177
		[Token(Token = "0x4004701")]
		[FieldOffset(Offset = "0x10")]
		public string tokenItemId;

		// Token: 0x04004702 RID: 18178
		[Token(Token = "0x4004702")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, Act9D0Data.ZoneDescInfo> zoneDescList;

		// Token: 0x04004703 RID: 18179
		[Token(Token = "0x4004703")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, Act9D0Data.FavorUpInfo> favorUpList;

		// Token: 0x04004704 RID: 18180
		[Token(Token = "0x4004704")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act9D0Data.SubMissionInfo> subMissionInfo;

		// Token: 0x04004705 RID: 18181
		[Token(Token = "0x4004705")]
		[FieldOffset(Offset = "0x30")]
		public bool hasSubMission;

		// Token: 0x04004706 RID: 18182
		[Token(Token = "0x4004706")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, long> apSupplyOutOfDateDict;

		// Token: 0x04004707 RID: 18183
		[Token(Token = "0x4004707")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act9D0Data.ActivityNewsInfo> newsInfoList;

		// Token: 0x04004708 RID: 18184
		[Token(Token = "0x4004708")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, Act9D0Data.ActivityNewsServerInfo> newsServerInfoList;

		// Token: 0x04004709 RID: 18185
		[Token(Token = "0x4004709")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, string> miscHub;

		// Token: 0x0400470A RID: 18186
		[Token(Token = "0x400470A")]
		[FieldOffset(Offset = "0x58")]
		public Act9D0Data.Act9D0ConstData constData;

		// Token: 0x02000D7C RID: 3452
		[Token(Token = "0x2000D7C")]
		public class MiscDataHubKeys
		{
			// Token: 0x06006A4C RID: 27212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A4C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MiscDataHubKeys()
			{
			}

			// Token: 0x0400470B RID: 18187
			[Token(Token = "0x400470B")]
			public const string NEWS_READ_SMALL = "NEWS_READ_SMALL";

			// Token: 0x0400470C RID: 18188
			[Token(Token = "0x400470C")]
			public const string NEWS_READ_MIDDLE = "NEWS_READ_MIDDLE";

			// Token: 0x0400470D RID: 18189
			[Token(Token = "0x400470D")]
			public const string NEWS_READ_LARGE = "NEWS_READ_LARGE";

			// Token: 0x0400470E RID: 18190
			[Token(Token = "0x400470E")]
			public const string NEWS_UNREAD = "NEWS_UNREAD";
		}

		// Token: 0x02000D7D RID: 3453
		[Token(Token = "0x2000D7D")]
		public class ZoneDescInfo
		{
			// Token: 0x06006A4D RID: 27213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A4D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneDescInfo()
			{
			}

			// Token: 0x0400470F RID: 18191
			[Token(Token = "0x400470F")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004710 RID: 18192
			[Token(Token = "0x4004710")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;

			// Token: 0x04004711 RID: 18193
			[Token(Token = "0x4004711")]
			[FieldOffset(Offset = "0x20")]
			public long displayStartTime;
		}

		// Token: 0x02000D7E RID: 3454
		[Token(Token = "0x2000D7E")]
		public class FavorUpInfo
		{
			// Token: 0x06006A4E RID: 27214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A4E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FavorUpInfo()
			{
			}

			// Token: 0x04004712 RID: 18194
			[Token(Token = "0x4004712")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04004713 RID: 18195
			[Token(Token = "0x4004713")]
			[FieldOffset(Offset = "0x18")]
			public long displayStartTime;

			// Token: 0x04004714 RID: 18196
			[Token(Token = "0x4004714")]
			[FieldOffset(Offset = "0x20")]
			public long displayEndTime;
		}

		// Token: 0x02000D7F RID: 3455
		[Token(Token = "0x2000D7F")]
		public class SubMissionInfo
		{
			// Token: 0x06006A4F RID: 27215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A4F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SubMissionInfo()
			{
			}

			// Token: 0x04004715 RID: 18197
			[Token(Token = "0x4004715")]
			[FieldOffset(Offset = "0x10")]
			public string missionId;

			// Token: 0x04004716 RID: 18198
			[Token(Token = "0x4004716")]
			[FieldOffset(Offset = "0x18")]
			public string missionTitle;

			// Token: 0x04004717 RID: 18199
			[Token(Token = "0x4004717")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x04004718 RID: 18200
			[Token(Token = "0x4004718")]
			[FieldOffset(Offset = "0x28")]
			public string missionIndex;
		}

		// Token: 0x02000D80 RID: 3456
		[Token(Token = "0x2000D80")]
		public class ActivityNewsInfo
		{
			// Token: 0x06006A50 RID: 27216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A50")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityNewsInfo()
			{
			}

			// Token: 0x04004719 RID: 18201
			[Token(Token = "0x4004719")]
			[FieldOffset(Offset = "0x10")]
			public string newsId;

			// Token: 0x0400471A RID: 18202
			[Token(Token = "0x400471A")]
			[FieldOffset(Offset = "0x18")]
			public int newsSortId;

			// Token: 0x0400471B RID: 18203
			[Token(Token = "0x400471B")]
			[FieldOffset(Offset = "0x20")]
			public Act9D0Data.ActivityNewsStyleInfo styleInfo;

			// Token: 0x0400471C RID: 18204
			[Token(Token = "0x400471C")]
			[FieldOffset(Offset = "0x28")]
			public string preposedStage;

			// Token: 0x0400471D RID: 18205
			[Token(Token = "0x400471D")]
			[FieldOffset(Offset = "0x30")]
			public string titlePic;

			// Token: 0x0400471E RID: 18206
			[Token(Token = "0x400471E")]
			[FieldOffset(Offset = "0x38")]
			public string newsTitle;

			// Token: 0x0400471F RID: 18207
			[Token(Token = "0x400471F")]
			[FieldOffset(Offset = "0x40")]
			public int newsInfShow;

			// Token: 0x04004720 RID: 18208
			[Token(Token = "0x4004720")]
			[FieldOffset(Offset = "0x48")]
			public string newsFrom;

			// Token: 0x04004721 RID: 18209
			[Token(Token = "0x4004721")]
			[FieldOffset(Offset = "0x50")]
			public string newsText;

			// Token: 0x04004722 RID: 18210
			[Token(Token = "0x4004722")]
			[FieldOffset(Offset = "0x58")]
			public int newsParam1;

			// Token: 0x04004723 RID: 18211
			[Token(Token = "0x4004723")]
			[FieldOffset(Offset = "0x5C")]
			public int newsParam2;

			// Token: 0x04004724 RID: 18212
			[Token(Token = "0x4004724")]
			[FieldOffset(Offset = "0x60")]
			public float newsParam3;

			// Token: 0x04004725 RID: 18213
			[Token(Token = "0x4004725")]
			[FieldOffset(Offset = "0x68")]
			public List<Act9D0Data.ActivityNewsLine> newsLines;
		}

		// Token: 0x02000D81 RID: 3457
		[Token(Token = "0x2000D81")]
		public class ActivityNewsServerInfo
		{
			// Token: 0x06006A51 RID: 27217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A51")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityNewsServerInfo()
			{
			}

			// Token: 0x04004726 RID: 18214
			[Token(Token = "0x4004726")]
			[FieldOffset(Offset = "0x10")]
			public string newsId;

			// Token: 0x04004727 RID: 18215
			[Token(Token = "0x4004727")]
			[FieldOffset(Offset = "0x18")]
			public string preposedStage;
		}

		// Token: 0x02000D82 RID: 3458
		[Token(Token = "0x2000D82")]
		public class ActivityNewsStyleInfo
		{
			// Token: 0x06006A52 RID: 27218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A52")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityNewsStyleInfo()
			{
			}

			// Token: 0x04004728 RID: 18216
			[Token(Token = "0x4004728")]
			[FieldOffset(Offset = "0x10")]
			public string typeId;

			// Token: 0x04004729 RID: 18217
			[Token(Token = "0x4004729")]
			[FieldOffset(Offset = "0x18")]
			public string typeName;

			// Token: 0x0400472A RID: 18218
			[Token(Token = "0x400472A")]
			[FieldOffset(Offset = "0x20")]
			public string typeLogo;

			// Token: 0x0400472B RID: 18219
			[Token(Token = "0x400472B")]
			[FieldOffset(Offset = "0x28")]
			public string typeMainLogo;
		}

		// Token: 0x02000D83 RID: 3459
		[Token(Token = "0x2000D83")]
		public class ActivityNewsLine
		{
			// Token: 0x06006A53 RID: 27219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A53")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityNewsLine()
			{
			}

			// Token: 0x0400472C RID: 18220
			[Token(Token = "0x400472C")]
			[FieldOffset(Offset = "0x10")]
			public Act9D0Data.ActivityNewsLineType lineType;

			// Token: 0x0400472D RID: 18221
			[Token(Token = "0x400472D")]
			[FieldOffset(Offset = "0x18")]
			public string content;
		}

		// Token: 0x02000D84 RID: 3460
		[Token(Token = "0x2000D84")]
		public enum ActivityNewsLineType
		{
			// Token: 0x0400472F RID: 18223
			[Token(Token = "0x400472F")]
			TextContent,
			// Token: 0x04004730 RID: 18224
			[Token(Token = "0x4004730")]
			ImageContent
		}

		// Token: 0x02000D85 RID: 3461
		[Token(Token = "0x2000D85")]
		public class Act9D0ConstData
		{
			// Token: 0x06006A54 RID: 27220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A54")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act9D0ConstData()
			{
			}

			// Token: 0x04004731 RID: 18225
			[Token(Token = "0x4004731")]
			[FieldOffset(Offset = "0x10")]
			public int campaignEnemyCnt;

			// Token: 0x04004732 RID: 18226
			[Token(Token = "0x4004732")]
			[FieldOffset(Offset = "0x18")]
			public string campaignStageId;
		}
	}
}
