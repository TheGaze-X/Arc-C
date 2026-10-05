using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010EF RID: 4335
	[Token(Token = "0x20010EF")]
	[Serializable]
	public class MeetingClueData
	{
		// Token: 0x06006E9A RID: 28314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9A")]
		[Address(RVA = "0x2107C50", Offset = "0x2106850", VA = "0x182107C50")]
		public MeetingClueData()
		{
		}

		// Token: 0x04005CE8 RID: 23784
		[Token(Token = "0x4005CE8")]
		[FieldOffset(Offset = "0x10")]
		public List<MeetingClueData.ClueData> clues;

		// Token: 0x04005CE9 RID: 23785
		[Token(Token = "0x4005CE9")]
		[FieldOffset(Offset = "0x18")]
		public List<MeetingClueData.ClueTypeData> clueTypes;

		// Token: 0x04005CEA RID: 23786
		[Token(Token = "0x4005CEA")]
		[FieldOffset(Offset = "0x20")]
		public List<MeetingClueData.ReceiveTimeBonus> receiveTimeBonus;

		// Token: 0x04005CEB RID: 23787
		[Token(Token = "0x4005CEB")]
		[FieldOffset(Offset = "0x28")]
		public MeetingClueData.MessageLeaveBoardConstData messageLeaveBoardConstData;

		// Token: 0x04005CEC RID: 23788
		[Token(Token = "0x4005CEC")]
		[FieldOffset(Offset = "0x30")]
		public int inventoryLimit;

		// Token: 0x04005CED RID: 23789
		[Token(Token = "0x4005CED")]
		[FieldOffset(Offset = "0x34")]
		public int outputBasicBonus;

		// Token: 0x04005CEE RID: 23790
		[Token(Token = "0x4005CEE")]
		[FieldOffset(Offset = "0x38")]
		public int outputOperatorsBonus;

		// Token: 0x04005CEF RID: 23791
		[Token(Token = "0x4005CEF")]
		[FieldOffset(Offset = "0x3C")]
		public int cluePointLimit;

		// Token: 0x04005CF0 RID: 23792
		[Token(Token = "0x4005CF0")]
		[FieldOffset(Offset = "0x40")]
		public int expiredDays;

		// Token: 0x04005CF1 RID: 23793
		[Token(Token = "0x4005CF1")]
		[FieldOffset(Offset = "0x44")]
		public int transferBonus;

		// Token: 0x04005CF2 RID: 23794
		[Token(Token = "0x4005CF2")]
		[FieldOffset(Offset = "0x48")]
		public int recycleBonus;

		// Token: 0x04005CF3 RID: 23795
		[Token(Token = "0x4005CF3")]
		[FieldOffset(Offset = "0x4C")]
		public int expiredBonus;

		// Token: 0x04005CF4 RID: 23796
		[Token(Token = "0x4005CF4")]
		[FieldOffset(Offset = "0x50")]
		public int communicationDuration;

		// Token: 0x04005CF5 RID: 23797
		[Token(Token = "0x4005CF5")]
		[FieldOffset(Offset = "0x54")]
		public int initiatorBonus;

		// Token: 0x04005CF6 RID: 23798
		[Token(Token = "0x4005CF6")]
		[FieldOffset(Offset = "0x58")]
		public int participantsBonus;

		// Token: 0x04005CF7 RID: 23799
		[Token(Token = "0x4005CF7")]
		[FieldOffset(Offset = "0x5C")]
		public float commuFoldDuration;

		// Token: 0x020010F0 RID: 4336
		[Token(Token = "0x20010F0")]
		[Serializable]
		public class ClueData
		{
			// Token: 0x06006E9B RID: 28315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E9B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClueData()
			{
			}

			// Token: 0x04005CF8 RID: 23800
			[Token(Token = "0x4005CF8")]
			[FieldOffset(Offset = "0x10")]
			public string clueId;

			// Token: 0x04005CF9 RID: 23801
			[Token(Token = "0x4005CF9")]
			[FieldOffset(Offset = "0x18")]
			public string clueName;

			// Token: 0x04005CFA RID: 23802
			[Token(Token = "0x4005CFA")]
			[FieldOffset(Offset = "0x20")]
			public string clueType;

			// Token: 0x04005CFB RID: 23803
			[Token(Token = "0x4005CFB")]
			[FieldOffset(Offset = "0x28")]
			public int number;
		}

		// Token: 0x020010F1 RID: 4337
		[Token(Token = "0x20010F1")]
		[Serializable]
		public class ClueTypeData
		{
			// Token: 0x06006E9C RID: 28316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E9C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClueTypeData()
			{
			}

			// Token: 0x04005CFC RID: 23804
			[Token(Token = "0x4005CFC")]
			[FieldOffset(Offset = "0x10")]
			public string clueType;

			// Token: 0x04005CFD RID: 23805
			[Token(Token = "0x4005CFD")]
			[FieldOffset(Offset = "0x18")]
			public int clueNumber;
		}

		// Token: 0x020010F2 RID: 4338
		[Token(Token = "0x20010F2")]
		[Serializable]
		public class ReceiveTimeBonus
		{
			// Token: 0x06006E9D RID: 28317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E9D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ReceiveTimeBonus()
			{
			}

			// Token: 0x04005CFE RID: 23806
			[Token(Token = "0x4005CFE")]
			[FieldOffset(Offset = "0x10")]
			public int receiveTimes;

			// Token: 0x04005CFF RID: 23807
			[Token(Token = "0x4005CFF")]
			[FieldOffset(Offset = "0x14")]
			public int receiveBonus;
		}

		// Token: 0x020010F3 RID: 4339
		[Token(Token = "0x20010F3")]
		[Serializable]
		public class MessageLeaveBoardConstData
		{
			// Token: 0x06006E9E RID: 28318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E9E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MessageLeaveBoardConstData()
			{
			}

			// Token: 0x04005D00 RID: 23808
			[Token(Token = "0x4005D00")]
			[FieldOffset(Offset = "0x10")]
			public int visitorBonus;

			// Token: 0x04005D01 RID: 23809
			[Token(Token = "0x4005D01")]
			[FieldOffset(Offset = "0x14")]
			public int visitorBonusLimit;

			// Token: 0x04005D02 RID: 23810
			[Token(Token = "0x4005D02")]
			[FieldOffset(Offset = "0x18")]
			public int visitorToWeek;

			// Token: 0x04005D03 RID: 23811
			[Token(Token = "0x4005D03")]
			[FieldOffset(Offset = "0x1C")]
			public int visitorPreWeek;

			// Token: 0x04005D04 RID: 23812
			[Token(Token = "0x4005D04")]
			[FieldOffset(Offset = "0x20")]
			public string bonusToast;

			// Token: 0x04005D05 RID: 23813
			[Token(Token = "0x4005D05")]
			[FieldOffset(Offset = "0x28")]
			public string bonusLimitText;

			// Token: 0x04005D06 RID: 23814
			[Token(Token = "0x4005D06")]
			[FieldOffset(Offset = "0x30")]
			public string recordsTextBonus;

			// Token: 0x04005D07 RID: 23815
			[Token(Token = "0x4005D07")]
			[FieldOffset(Offset = "0x38")]
			public string recordsTextTip;
		}
	}
}
