using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000CBF RID: 3263
	[Token(Token = "0x2000CBF")]
	public class SiracusaData
	{
		// Token: 0x0600699D RID: 27037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699D")]
		[Address(RVA = "0x200CEA0", Offset = "0x200BAA0", VA = "0x18200CEA0")]
		public SiracusaData()
		{
		}

		// Token: 0x040042A6 RID: 17062
		[Token(Token = "0x40042A6")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SiracusaData.AreaData> areaDataMap;

		// Token: 0x040042A7 RID: 17063
		[Token(Token = "0x40042A7")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SiracusaData.PointData> pointDataMap;

		// Token: 0x040042A8 RID: 17064
		[Token(Token = "0x40042A8")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SiracusaData.CharCardData> charCardMap;

		// Token: 0x040042A9 RID: 17065
		[Token(Token = "0x40042A9")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SiracusaData.TaskRingData> taskRingMap;

		// Token: 0x040042AA RID: 17066
		[Token(Token = "0x40042AA")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, SiracusaData.TaskBasicInfoData> taskInfoMap;

		// Token: 0x040042AB RID: 17067
		[Token(Token = "0x40042AB")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, SiracusaData.BattleTaskData> battleTaskMap;

		// Token: 0x040042AC RID: 17068
		[Token(Token = "0x40042AC")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, SiracusaData.AVGTaskData> avgTaskMap;

		// Token: 0x040042AD RID: 17069
		[Token(Token = "0x40042AD")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, SiracusaData.ItemInfoData> itemInfoMap;

		// Token: 0x040042AE RID: 17070
		[Token(Token = "0x40042AE")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, SiracusaData.ItemCardInfoData> itemCardInfoMap;

		// Token: 0x040042AF RID: 17071
		[Token(Token = "0x40042AF")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, SiracusaData.NavigationInfoData> navigationInfoMap;

		// Token: 0x040042B0 RID: 17072
		[Token(Token = "0x40042B0")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, SiracusaData.OptionInfoData> optionInfoMap;

		// Token: 0x040042B1 RID: 17073
		[Token(Token = "0x40042B1")]
		[FieldOffset(Offset = "0x68")]
		public List<SiracusaData.StagePointInfoData> stagePointList;

		// Token: 0x040042B2 RID: 17074
		[Token(Token = "0x40042B2")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, SiracusaData.StoryBriefInfoData> storyBriefInfoDataMap;

		// Token: 0x040042B3 RID: 17075
		[Token(Token = "0x40042B3")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, SiracusaData.OperaInfoData> operaInfoMap;

		// Token: 0x040042B4 RID: 17076
		[Token(Token = "0x40042B4")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, SiracusaData.OperaCommentInfoData> operaCommentInfoMap;

		// Token: 0x040042B5 RID: 17077
		[Token(Token = "0x40042B5")]
		[FieldOffset(Offset = "0x88")]
		public SiracusaData.ConstData constData;

		// Token: 0x02000CC0 RID: 3264
		[Token(Token = "0x2000CC0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ZoneUnlockType
		{
			// Token: 0x040042B7 RID: 17079
			[Token(Token = "0x40042B7")]
			NONE,
			// Token: 0x040042B8 RID: 17080
			[Token(Token = "0x40042B8")]
			STAGE_UNLOCK,
			// Token: 0x040042B9 RID: 17081
			[Token(Token = "0x40042B9")]
			TASK_UNLOCK
		}

		// Token: 0x02000CC1 RID: 3265
		[Token(Token = "0x2000CC1")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum CardGainType
		{
			// Token: 0x040042BB RID: 17083
			[Token(Token = "0x40042BB")]
			NONE,
			// Token: 0x040042BC RID: 17084
			[Token(Token = "0x40042BC")]
			STAGE_GAIN,
			// Token: 0x040042BD RID: 17085
			[Token(Token = "0x40042BD")]
			TASK_GAIN
		}

		// Token: 0x02000CC2 RID: 3266
		[Token(Token = "0x2000CC2")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TaskRingLogicType
		{
			// Token: 0x040042BF RID: 17087
			[Token(Token = "0x40042BF")]
			NONE,
			// Token: 0x040042C0 RID: 17088
			[Token(Token = "0x40042C0")]
			LINEAR,
			// Token: 0x040042C1 RID: 17089
			[Token(Token = "0x40042C1")]
			AND,
			// Token: 0x040042C2 RID: 17090
			[Token(Token = "0x40042C2")]
			OR
		}

		// Token: 0x02000CC3 RID: 3267
		[Token(Token = "0x2000CC3")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TaskType
		{
			// Token: 0x040042C4 RID: 17092
			[Token(Token = "0x40042C4")]
			NONE,
			// Token: 0x040042C5 RID: 17093
			[Token(Token = "0x40042C5")]
			BATTLE,
			// Token: 0x040042C6 RID: 17094
			[Token(Token = "0x40042C6")]
			AVG
		}

		// Token: 0x02000CC4 RID: 3268
		[Token(Token = "0x2000CC4")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum NavigationType
		{
			// Token: 0x040042C8 RID: 17096
			[Token(Token = "0x40042C8")]
			NONE,
			// Token: 0x040042C9 RID: 17097
			[Token(Token = "0x40042C9")]
			AVG,
			// Token: 0x040042CA RID: 17098
			[Token(Token = "0x40042CA")]
			LEVEL,
			// Token: 0x040042CB RID: 17099
			[Token(Token = "0x40042CB")]
			CHAR_CARD
		}

		// Token: 0x02000CC5 RID: 3269
		[Token(Token = "0x2000CC5")]
		public class ConstData
		{
			// Token: 0x0600699E RID: 27038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600699E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x040042CC RID: 17100
			[Token(Token = "0x40042CC")]
			[FieldOffset(Offset = "0x10")]
			public int operaDailyNum;

			// Token: 0x040042CD RID: 17101
			[Token(Token = "0x40042CD")]
			[FieldOffset(Offset = "0x18")]
			public long operaAllUnlockTime;

			// Token: 0x040042CE RID: 17102
			[Token(Token = "0x40042CE")]
			[FieldOffset(Offset = "0x20")]
			public string defaultFocusArea;
		}

		// Token: 0x02000CC6 RID: 3270
		[Token(Token = "0x2000CC6")]
		public class AreaData
		{
			// Token: 0x0600699F RID: 27039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600699F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AreaData()
			{
			}

			// Token: 0x040042CF RID: 17103
			[Token(Token = "0x40042CF")]
			[FieldOffset(Offset = "0x10")]
			public string areaId;

			// Token: 0x040042D0 RID: 17104
			[Token(Token = "0x40042D0")]
			[FieldOffset(Offset = "0x18")]
			public string areaName;

			// Token: 0x040042D1 RID: 17105
			[Token(Token = "0x40042D1")]
			[FieldOffset(Offset = "0x20")]
			public string areaSubName;

			// Token: 0x040042D2 RID: 17106
			[Token(Token = "0x40042D2")]
			[FieldOffset(Offset = "0x28")]
			public SiracusaData.ZoneUnlockType unlockType;

			// Token: 0x040042D3 RID: 17107
			[Token(Token = "0x40042D3")]
			[FieldOffset(Offset = "0x30")]
			public string unlockStage;

			// Token: 0x040042D4 RID: 17108
			[Token(Token = "0x40042D4")]
			[FieldOffset(Offset = "0x38")]
			public string areaIconId;

			// Token: 0x040042D5 RID: 17109
			[Token(Token = "0x40042D5")]
			[FieldOffset(Offset = "0x40")]
			public List<string> pointList;
		}

		// Token: 0x02000CC7 RID: 3271
		[Token(Token = "0x2000CC7")]
		public class PointData
		{
			// Token: 0x060069A0 RID: 27040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069A0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PointData()
			{
			}

			// Token: 0x040042D6 RID: 17110
			[Token(Token = "0x40042D6")]
			[FieldOffset(Offset = "0x10")]
			public string pointId;

			// Token: 0x040042D7 RID: 17111
			[Token(Token = "0x40042D7")]
			[FieldOffset(Offset = "0x18")]
			public string areaId;

			// Token: 0x040042D8 RID: 17112
			[Token(Token = "0x40042D8")]
			[FieldOffset(Offset = "0x20")]
			public string pointName;

			// Token: 0x040042D9 RID: 17113
			[Token(Token = "0x40042D9")]
			[FieldOffset(Offset = "0x28")]
			public string pointDesc;

			// Token: 0x040042DA RID: 17114
			[Token(Token = "0x40042DA")]
			[FieldOffset(Offset = "0x30")]
			public string pointIconId;

			// Token: 0x040042DB RID: 17115
			[Token(Token = "0x40042DB")]
			[FieldOffset(Offset = "0x38")]
			public string pointItaName;
		}

		// Token: 0x02000CC8 RID: 3272
		[Token(Token = "0x2000CC8")]
		public class CharCardData
		{
			// Token: 0x060069A1 RID: 27041 RVA: 0x00030DE0 File Offset: 0x0002EFE0
			[Token(Token = "0x60069A1")]
			[Address(RVA = "0x2008230", Offset = "0x2006E30", VA = "0x182008230", Slot = "4")]
			public virtual bool ShouldSerializegainType()
			{
				return default(bool);
			}

			// Token: 0x060069A2 RID: 27042 RVA: 0x00030DF8 File Offset: 0x0002EFF8
			[Token(Token = "0x60069A2")]
			[Address(RVA = "0x2008220", Offset = "0x2006E20", VA = "0x182008220", Slot = "5")]
			public virtual bool ShouldSerializegainParam()
			{
				return default(bool);
			}

			// Token: 0x060069A3 RID: 27043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069A3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharCardData()
			{
			}

			// Token: 0x040042DC RID: 17116
			[Token(Token = "0x40042DC")]
			[FieldOffset(Offset = "0x10")]
			public string charCardId;

			// Token: 0x040042DD RID: 17117
			[Token(Token = "0x40042DD")]
			[FieldOffset(Offset = "0x18")]
			public int sortIndex;

			// Token: 0x040042DE RID: 17118
			[Token(Token = "0x40042DE")]
			[FieldOffset(Offset = "0x20")]
			public string avgChar;

			// Token: 0x040042DF RID: 17119
			[Token(Token = "0x40042DF")]
			[FieldOffset(Offset = "0x28")]
			public float avgCharOffsetY;

			// Token: 0x040042E0 RID: 17120
			[Token(Token = "0x40042E0")]
			[FieldOffset(Offset = "0x30")]
			public string charCardName;

			// Token: 0x040042E1 RID: 17121
			[Token(Token = "0x40042E1")]
			[FieldOffset(Offset = "0x38")]
			public string charCardItaName;

			// Token: 0x040042E2 RID: 17122
			[Token(Token = "0x40042E2")]
			[FieldOffset(Offset = "0x40")]
			public string charCardTitle;

			// Token: 0x040042E3 RID: 17123
			[Token(Token = "0x40042E3")]
			[FieldOffset(Offset = "0x48")]
			public string charCardDesc;

			// Token: 0x040042E4 RID: 17124
			[Token(Token = "0x40042E4")]
			[FieldOffset(Offset = "0x50")]
			public string fullCompleteDes;

			// Token: 0x040042E5 RID: 17125
			[Token(Token = "0x40042E5")]
			[FieldOffset(Offset = "0x58")]
			public string gainDesc;

			// Token: 0x040042E6 RID: 17126
			[Token(Token = "0x40042E6")]
			[FieldOffset(Offset = "0x60")]
			public string themeColor;

			// Token: 0x040042E7 RID: 17127
			[Token(Token = "0x40042E7")]
			[FieldOffset(Offset = "0x68")]
			public List<string> taskRingList;

			// Token: 0x040042E8 RID: 17128
			[Token(Token = "0x40042E8")]
			[FieldOffset(Offset = "0x70")]
			public string operaItemId;

			// Token: 0x040042E9 RID: 17129
			[Token(Token = "0x40042E9")]
			[FieldOffset(Offset = "0x78")]
			public SiracusaData.CardGainType gainType;

			// Token: 0x040042EA RID: 17130
			[Token(Token = "0x40042EA")]
			[FieldOffset(Offset = "0x80")]
			public List<string> gainParamList;
		}

		// Token: 0x02000CC9 RID: 3273
		[Token(Token = "0x2000CC9")]
		public class TaskRingData
		{
			// Token: 0x060069A4 RID: 27044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069A4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TaskRingData()
			{
			}

			// Token: 0x040042EB RID: 17131
			[Token(Token = "0x40042EB")]
			[FieldOffset(Offset = "0x10")]
			public string taskRingId;

			// Token: 0x040042EC RID: 17132
			[Token(Token = "0x40042EC")]
			[FieldOffset(Offset = "0x18")]
			public int sortIndex;

			// Token: 0x040042ED RID: 17133
			[Token(Token = "0x40042ED")]
			[FieldOffset(Offset = "0x20")]
			public string charCardId;

			// Token: 0x040042EE RID: 17134
			[Token(Token = "0x40042EE")]
			[FieldOffset(Offset = "0x28")]
			public SiracusaData.TaskRingLogicType logicType;

			// Token: 0x040042EF RID: 17135
			[Token(Token = "0x40042EF")]
			[FieldOffset(Offset = "0x30")]
			public string ringText;

			// Token: 0x040042F0 RID: 17136
			[Token(Token = "0x40042F0")]
			[FieldOffset(Offset = "0x38")]
			public ItemBundle item;

			// Token: 0x040042F1 RID: 17137
			[Token(Token = "0x40042F1")]
			[FieldOffset(Offset = "0x40")]
			public bool isPrecious;

			// Token: 0x040042F2 RID: 17138
			[Token(Token = "0x40042F2")]
			[FieldOffset(Offset = "0x48")]
			public List<string> taskIdList;
		}

		// Token: 0x02000CCA RID: 3274
		[Token(Token = "0x2000CCA")]
		public class TaskBasicInfoData
		{
			// Token: 0x060069A5 RID: 27045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069A5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TaskBasicInfoData()
			{
			}

			// Token: 0x040042F3 RID: 17139
			[Token(Token = "0x40042F3")]
			[FieldOffset(Offset = "0x10")]
			public string taskId;

			// Token: 0x040042F4 RID: 17140
			[Token(Token = "0x40042F4")]
			[FieldOffset(Offset = "0x18")]
			public string taskRingId;

			// Token: 0x040042F5 RID: 17141
			[Token(Token = "0x40042F5")]
			[FieldOffset(Offset = "0x20")]
			public int sortIndex;

			// Token: 0x040042F6 RID: 17142
			[Token(Token = "0x40042F6")]
			[FieldOffset(Offset = "0x28")]
			public string placeId;

			// Token: 0x040042F7 RID: 17143
			[Token(Token = "0x40042F7")]
			[FieldOffset(Offset = "0x30")]
			public string npcId;

			// Token: 0x040042F8 RID: 17144
			[Token(Token = "0x40042F8")]
			[FieldOffset(Offset = "0x38")]
			public SiracusaData.TaskType taskType;
		}

		// Token: 0x02000CCB RID: 3275
		[Token(Token = "0x2000CCB")]
		public class BattleTaskData
		{
			// Token: 0x060069A6 RID: 27046 RVA: 0x00030E10 File Offset: 0x0002F010
			[Token(Token = "0x60069A6")]
			[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0", Slot = "4")]
			public virtual bool ShouldSerializetargetType()
			{
				return default(bool);
			}

			// Token: 0x060069A7 RID: 27047 RVA: 0x00030E28 File Offset: 0x0002F028
			[Token(Token = "0x60069A7")]
			[Address(RVA = "0x1FFE4D0", Offset = "0x1FFD0D0", VA = "0x181FFE4D0", Slot = "5")]
			public virtual bool ShouldSerializetargetTemplate()
			{
				return default(bool);
			}

			// Token: 0x060069A8 RID: 27048 RVA: 0x00030E40 File Offset: 0x0002F040
			[Token(Token = "0x60069A8")]
			[Address(RVA = "0x1FF9020", Offset = "0x1FF7C20", VA = "0x181FF9020", Slot = "6")]
			public virtual bool ShouldSerializetargetParamList()
			{
				return default(bool);
			}

			// Token: 0x060069A9 RID: 27049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069A9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleTaskData()
			{
			}

			// Token: 0x040042F9 RID: 17145
			[Token(Token = "0x40042F9")]
			[FieldOffset(Offset = "0x10")]
			public string taskId;

			// Token: 0x040042FA RID: 17146
			[Token(Token = "0x40042FA")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x040042FB RID: 17147
			[Token(Token = "0x40042FB")]
			[FieldOffset(Offset = "0x20")]
			public string battleTaskDesc;

			// Token: 0x040042FC RID: 17148
			[Token(Token = "0x40042FC")]
			[FieldOffset(Offset = "0x28")]
			public string targetType;

			// Token: 0x040042FD RID: 17149
			[Token(Token = "0x40042FD")]
			[FieldOffset(Offset = "0x30")]
			public string targetTemplate;

			// Token: 0x040042FE RID: 17150
			[Token(Token = "0x40042FE")]
			[FieldOffset(Offset = "0x38")]
			public List<string> targetParamList;
		}

		// Token: 0x02000CCC RID: 3276
		[Token(Token = "0x2000CCC")]
		public class AVGTaskData
		{
			// Token: 0x060069AA RID: 27050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069AA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AVGTaskData()
			{
			}

			// Token: 0x040042FF RID: 17151
			[Token(Token = "0x40042FF")]
			[FieldOffset(Offset = "0x10")]
			public string taskId;

			// Token: 0x04004300 RID: 17152
			[Token(Token = "0x4004300")]
			[FieldOffset(Offset = "0x18")]
			public string taskAvg;
		}

		// Token: 0x02000CCD RID: 3277
		[Token(Token = "0x2000CCD")]
		public class CharInfoData
		{
			// Token: 0x060069AB RID: 27051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069AB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharInfoData()
			{
			}

			// Token: 0x04004301 RID: 17153
			[Token(Token = "0x4004301")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04004302 RID: 17154
			[Token(Token = "0x4004302")]
			[FieldOffset(Offset = "0x18")]
			public string charName;
		}

		// Token: 0x02000CCE RID: 3278
		[Token(Token = "0x2000CCE")]
		public class ItemInfoData
		{
			// Token: 0x060069AC RID: 27052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069AC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemInfoData()
			{
			}

			// Token: 0x04004303 RID: 17155
			[Token(Token = "0x4004303")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04004304 RID: 17156
			[Token(Token = "0x4004304")]
			[FieldOffset(Offset = "0x18")]
			public string itemName;

			// Token: 0x04004305 RID: 17157
			[Token(Token = "0x4004305")]
			[FieldOffset(Offset = "0x20")]
			public string itemItalyName;

			// Token: 0x04004306 RID: 17158
			[Token(Token = "0x4004306")]
			[FieldOffset(Offset = "0x28")]
			public string itemDesc;

			// Token: 0x04004307 RID: 17159
			[Token(Token = "0x4004307")]
			[FieldOffset(Offset = "0x30")]
			public string itemIcon;
		}

		// Token: 0x02000CCF RID: 3279
		[Token(Token = "0x2000CCF")]
		public class ItemCardInfoData
		{
			// Token: 0x060069AD RID: 27053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069AD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemCardInfoData()
			{
			}

			// Token: 0x04004308 RID: 17160
			[Token(Token = "0x4004308")]
			[FieldOffset(Offset = "0x10")]
			public string cardId;

			// Token: 0x04004309 RID: 17161
			[Token(Token = "0x4004309")]
			[FieldOffset(Offset = "0x18")]
			public string cardName;

			// Token: 0x0400430A RID: 17162
			[Token(Token = "0x400430A")]
			[FieldOffset(Offset = "0x20")]
			public string cardDesc;

			// Token: 0x0400430B RID: 17163
			[Token(Token = "0x400430B")]
			[FieldOffset(Offset = "0x28")]
			public string optionScript;
		}

		// Token: 0x02000CD0 RID: 3280
		[Token(Token = "0x2000CD0")]
		public class OptionInfoData
		{
			// Token: 0x060069AE RID: 27054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069AE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OptionInfoData()
			{
			}

			// Token: 0x0400430C RID: 17164
			[Token(Token = "0x400430C")]
			[FieldOffset(Offset = "0x10")]
			public string optionId;

			// Token: 0x0400430D RID: 17165
			[Token(Token = "0x400430D")]
			[FieldOffset(Offset = "0x18")]
			public string optionDesc;

			// Token: 0x0400430E RID: 17166
			[Token(Token = "0x400430E")]
			[FieldOffset(Offset = "0x20")]
			public string optionScript;

			// Token: 0x0400430F RID: 17167
			[Token(Token = "0x400430F")]
			[FieldOffset(Offset = "0x28")]
			public string optionGoToScript;

			// Token: 0x04004310 RID: 17168
			[Token(Token = "0x4004310")]
			[FieldOffset(Offset = "0x30")]
			public bool isLeaveOption;

			// Token: 0x04004311 RID: 17169
			[Token(Token = "0x4004311")]
			[FieldOffset(Offset = "0x31")]
			public bool needCommentLike;

			// Token: 0x04004312 RID: 17170
			[Token(Token = "0x4004312")]
			[FieldOffset(Offset = "0x38")]
			public string requireCardId;
		}

		// Token: 0x02000CD1 RID: 3281
		[Token(Token = "0x2000CD1")]
		public class NavigationInfoData
		{
			// Token: 0x060069AF RID: 27055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069AF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NavigationInfoData()
			{
			}

			// Token: 0x04004313 RID: 17171
			[Token(Token = "0x4004313")]
			[FieldOffset(Offset = "0x10")]
			public string entryId;

			// Token: 0x04004314 RID: 17172
			[Token(Token = "0x4004314")]
			[FieldOffset(Offset = "0x18")]
			public SiracusaData.NavigationType navigationType;

			// Token: 0x04004315 RID: 17173
			[Token(Token = "0x4004315")]
			[FieldOffset(Offset = "0x20")]
			public string entryIcon;

			// Token: 0x04004316 RID: 17174
			[Token(Token = "0x4004316")]
			[FieldOffset(Offset = "0x28")]
			public string entryName;

			// Token: 0x04004317 RID: 17175
			[Token(Token = "0x4004317")]
			[FieldOffset(Offset = "0x30")]
			public string entrySubName;
		}

		// Token: 0x02000CD2 RID: 3282
		[Token(Token = "0x2000CD2")]
		public class StagePointInfoData
		{
			// Token: 0x060069B0 RID: 27056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069B0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StagePointInfoData()
			{
			}

			// Token: 0x04004318 RID: 17176
			[Token(Token = "0x4004318")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004319 RID: 17177
			[Token(Token = "0x4004319")]
			[FieldOffset(Offset = "0x18")]
			public string pointId;

			// Token: 0x0400431A RID: 17178
			[Token(Token = "0x400431A")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x0400431B RID: 17179
			[Token(Token = "0x400431B")]
			[FieldOffset(Offset = "0x24")]
			public bool isTaskStage;
		}

		// Token: 0x02000CD3 RID: 3283
		[Token(Token = "0x2000CD3")]
		public class StoryBriefInfoData
		{
			// Token: 0x060069B1 RID: 27057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069B1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StoryBriefInfoData()
			{
			}

			// Token: 0x0400431C RID: 17180
			[Token(Token = "0x400431C")]
			[FieldOffset(Offset = "0x10")]
			public string storyId;

			// Token: 0x0400431D RID: 17181
			[Token(Token = "0x400431D")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x0400431E RID: 17182
			[Token(Token = "0x400431E")]
			[FieldOffset(Offset = "0x20")]
			public string storyInfo;
		}

		// Token: 0x02000CD4 RID: 3284
		[Token(Token = "0x2000CD4")]
		public class OperaInfoData
		{
			// Token: 0x060069B2 RID: 27058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069B2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OperaInfoData()
			{
			}

			// Token: 0x0400431F RID: 17183
			[Token(Token = "0x400431F")]
			[FieldOffset(Offset = "0x10")]
			public string operaId;

			// Token: 0x04004320 RID: 17184
			[Token(Token = "0x4004320")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004321 RID: 17185
			[Token(Token = "0x4004321")]
			[FieldOffset(Offset = "0x20")]
			public string operaName;

			// Token: 0x04004322 RID: 17186
			[Token(Token = "0x4004322")]
			[FieldOffset(Offset = "0x28")]
			public string operaSubName;

			// Token: 0x04004323 RID: 17187
			[Token(Token = "0x4004323")]
			[FieldOffset(Offset = "0x30")]
			public string operaScore;

			// Token: 0x04004324 RID: 17188
			[Token(Token = "0x4004324")]
			[FieldOffset(Offset = "0x38")]
			public long unlockTime;
		}

		// Token: 0x02000CD5 RID: 3285
		[Token(Token = "0x2000CD5")]
		public class OperaCommentInfoData
		{
			// Token: 0x060069B3 RID: 27059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069B3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OperaCommentInfoData()
			{
			}

			// Token: 0x04004325 RID: 17189
			[Token(Token = "0x4004325")]
			[FieldOffset(Offset = "0x10")]
			public string commentId;

			// Token: 0x04004326 RID: 17190
			[Token(Token = "0x4004326")]
			[FieldOffset(Offset = "0x18")]
			public string referenceOperaId;

			// Token: 0x04004327 RID: 17191
			[Token(Token = "0x4004327")]
			[FieldOffset(Offset = "0x20")]
			public int columnIndex;

			// Token: 0x04004328 RID: 17192
			[Token(Token = "0x4004328")]
			[FieldOffset(Offset = "0x24")]
			public int columnSortId;

			// Token: 0x04004329 RID: 17193
			[Token(Token = "0x4004329")]
			[FieldOffset(Offset = "0x28")]
			public string commentTitle;

			// Token: 0x0400432A RID: 17194
			[Token(Token = "0x400432A")]
			[FieldOffset(Offset = "0x30")]
			public string score;

			// Token: 0x0400432B RID: 17195
			[Token(Token = "0x400432B")]
			[FieldOffset(Offset = "0x38")]
			public string commentContent;

			// Token: 0x0400432C RID: 17196
			[Token(Token = "0x400432C")]
			[FieldOffset(Offset = "0x40")]
			public string commentCharId;
		}
	}
}
