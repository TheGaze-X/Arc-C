using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D24 RID: 3364
	[Token(Token = "0x2000D24")]
	public class Act38SideData
	{
		// Token: 0x060069FD RID: 27133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FD")]
		[Address(RVA = "0x1FF5A00", Offset = "0x1FF4600", VA = "0x181FF5A00")]
		public Act38SideData()
		{
		}

		// Token: 0x0400452E RID: 17710
		[Token(Token = "0x400452E")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act38SideData.Act38SideZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x0400452F RID: 17711
		[Token(Token = "0x400452F")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act38SideData.Act38SidePuzzleInfo> puzzleInfoMap;

		// Token: 0x04004530 RID: 17712
		[Token(Token = "0x4004530")]
		[FieldOffset(Offset = "0x20")]
		public List<Act38SideData.Act38SideNpcDialogData> npcDialogList;

		// Token: 0x04004531 RID: 17713
		[Token(Token = "0x4004531")]
		[FieldOffset(Offset = "0x28")]
		public Act38SideData.ConstData constData;

		// Token: 0x04004532 RID: 17714
		[Token(Token = "0x4004532")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act38SideData.Act38SidePuzzleGroupFocusData> puzzleGroupFocusDataMap;

		// Token: 0x02000D25 RID: 3365
		[Token(Token = "0x2000D25")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum NpcDialogType
		{
			// Token: 0x04004534 RID: 17716
			[Token(Token = "0x4004534")]
			NONE,
			// Token: 0x04004535 RID: 17717
			[Token(Token = "0x4004535")]
			ENTER_PUZZLE,
			// Token: 0x04004536 RID: 17718
			[Token(Token = "0x4004536")]
			PLATE_ERROR,
			// Token: 0x04004537 RID: 17719
			[Token(Token = "0x4004537")]
			HINT_SUCC,
			// Token: 0x04004538 RID: 17720
			[Token(Token = "0x4004538")]
			HINT_FAIL,
			// Token: 0x04004539 RID: 17721
			[Token(Token = "0x4004539")]
			PUZZLE_SOLVED
		}

		// Token: 0x02000D26 RID: 3366
		[Token(Token = "0x2000D26")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum NpcEmoType
		{
			// Token: 0x0400453B RID: 17723
			[Token(Token = "0x400453B")]
			NONE,
			// Token: 0x0400453C RID: 17724
			[Token(Token = "0x400453C")]
			EMO_1,
			// Token: 0x0400453D RID: 17725
			[Token(Token = "0x400453D")]
			EMO_2,
			// Token: 0x0400453E RID: 17726
			[Token(Token = "0x400453E")]
			EMO_3
		}

		// Token: 0x02000D27 RID: 3367
		[Token(Token = "0x2000D27")]
		public class Act38SideZoneAdditionData
		{
			// Token: 0x060069FE RID: 27134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069FE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act38SideZoneAdditionData()
			{
			}

			// Token: 0x0400453F RID: 17727
			[Token(Token = "0x400453F")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004540 RID: 17728
			[Token(Token = "0x4004540")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;
		}

		// Token: 0x02000D28 RID: 3368
		[Token(Token = "0x2000D28")]
		public class Act38SidePuzzleInfo
		{
			// Token: 0x060069FF RID: 27135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069FF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act38SidePuzzleInfo()
			{
			}

			// Token: 0x04004541 RID: 17729
			[Token(Token = "0x4004541")]
			[FieldOffset(Offset = "0x10")]
			public string puzzleId;

			// Token: 0x04004542 RID: 17730
			[Token(Token = "0x4004542")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004543 RID: 17731
			[Token(Token = "0x4004543")]
			[FieldOffset(Offset = "0x20")]
			public long startTime;

			// Token: 0x04004544 RID: 17732
			[Token(Token = "0x4004544")]
			[FieldOffset(Offset = "0x28")]
			public string puzzleGroupId;
		}

		// Token: 0x02000D29 RID: 3369
		[Token(Token = "0x2000D29")]
		public class Act38SideNpcDialogData
		{
			// Token: 0x06006A00 RID: 27136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A00")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act38SideNpcDialogData()
			{
			}

			// Token: 0x04004545 RID: 17733
			[Token(Token = "0x4004545")]
			[FieldOffset(Offset = "0x10")]
			public string desc;

			// Token: 0x04004546 RID: 17734
			[Token(Token = "0x4004546")]
			[FieldOffset(Offset = "0x18")]
			public Act38SideData.NpcDialogType dialogType;

			// Token: 0x04004547 RID: 17735
			[Token(Token = "0x4004547")]
			[FieldOffset(Offset = "0x20")]
			public string emoSpineName;
		}

		// Token: 0x02000D2A RID: 3370
		[Token(Token = "0x2000D2A")]
		public class Act38SidePuzzleGroupFocusData
		{
			// Token: 0x06006A01 RID: 27137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A01")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act38SidePuzzleGroupFocusData()
			{
			}

			// Token: 0x04004548 RID: 17736
			[Token(Token = "0x4004548")]
			[FieldOffset(Offset = "0x10")]
			public string puzzleGroupId;

			// Token: 0x04004549 RID: 17737
			[Token(Token = "0x4004549")]
			[FieldOffset(Offset = "0x18")]
			public float xAxisFocusPos;
		}

		// Token: 0x02000D2B RID: 3371
		[Token(Token = "0x2000D2B")]
		public class ConstData
		{
			// Token: 0x06006A02 RID: 27138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A02")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x0400454A RID: 17738
			[Token(Token = "0x400454A")]
			[FieldOffset(Offset = "0x10")]
			public string npcIdleSpineName;

			// Token: 0x0400454B RID: 17739
			[Token(Token = "0x400454B")]
			[FieldOffset(Offset = "0x18")]
			public string puzzleMapAnimGroupId;

			// Token: 0x0400454C RID: 17740
			[Token(Token = "0x400454C")]
			[FieldOffset(Offset = "0x20")]
			public string puzzleCrossDayTrackId;

			// Token: 0x0400454D RID: 17741
			[Token(Token = "0x400454D")]
			[FieldOffset(Offset = "0x28")]
			public string puzzleListText;

			// Token: 0x0400454E RID: 17742
			[Token(Token = "0x400454E")]
			[FieldOffset(Offset = "0x30")]
			public int puzzleRewardNum;
		}
	}
}
