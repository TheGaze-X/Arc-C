using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007917 RID: 30999
	[Token(Token = "0x2007917")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act1ArcadeTrackTriggerUtil
	{
		// Token: 0x0602B7D8 RID: 178136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7D8")]
		[Address(RVA = "0x27793C0", Offset = "0x2777FC0", VA = "0x1827793C0")]
		public static void RecordBadgeUpdateTrigger(string actId, string badgeId)
		{
		}

		// Token: 0x0602B7D9 RID: 178137 RVA: 0x000DC320 File Offset: 0x000DA520
		[Token(Token = "0x602B7D9")]
		[Address(RVA = "0x2778DC0", Offset = "0x27779C0", VA = "0x182778DC0")]
		public static bool CheckBadgeUpdateTrigger(string actId, string badgeId)
		{
			return default(bool);
		}

		// Token: 0x0602B7DA RID: 178138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7DA")]
		[Address(RVA = "0x27790A0", Offset = "0x2777CA0", VA = "0x1827790A0")]
		public static void ConsumeBadgeUpdateTrigger(string actId, string badgeId)
		{
		}

		// Token: 0x0602B7DB RID: 178139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7DB")]
		[Address(RVA = "0x27795E0", Offset = "0x27781E0", VA = "0x1827795E0")]
		private static string _GetBadgeTriggerType(string actId)
		{
			return null;
		}

		// Token: 0x0602B7DC RID: 178140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7DC")]
		[Address(RVA = "0x2779310", Offset = "0x2777F10", VA = "0x182779310")]
		public static void RecordBadgeUpdateEntryTrigger(string actId)
		{
		}

		// Token: 0x0602B7DD RID: 178141 RVA: 0x000DC338 File Offset: 0x000DA538
		[Token(Token = "0x602B7DD")]
		[Address(RVA = "0x2778C80", Offset = "0x2777880", VA = "0x182778C80")]
		public static bool CheckBadgeUpdateEntryTrigger(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602B7DE RID: 178142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7DE")]
		[Address(RVA = "0x2778FF0", Offset = "0x2777BF0", VA = "0x182778FF0")]
		public static void ConsumeBadgeUpdateEntryTrigger(string actId)
		{
		}

		// Token: 0x0602B7DF RID: 178143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7DF")]
		[Address(RVA = "0x2779570", Offset = "0x2778170", VA = "0x182779570")]
		private static string _GetBadgeTriggerEntryType(string actId)
		{
			return null;
		}

		// Token: 0x0602B7E0 RID: 178144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7E0")]
		[Address(RVA = "0x2779230", Offset = "0x2777E30", VA = "0x182779230")]
		public static void ConsumeNewZoneTrigger(string actId, string zoneId)
		{
		}

		// Token: 0x0602B7E1 RID: 178145 RVA: 0x000DC350 File Offset: 0x000DA550
		[Token(Token = "0x602B7E1")]
		[Address(RVA = "0x2778F30", Offset = "0x2777B30", VA = "0x182778F30")]
		public static bool CheckNewZoneTrigger(string actId, string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0602B7E2 RID: 178146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7E2")]
		[Address(RVA = "0x2779490", Offset = "0x2778090", VA = "0x182779490")]
		public static void RecordStageUpdateTrigger(string actId, string stageId)
		{
		}

		// Token: 0x0602B7E3 RID: 178147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7E3")]
		[Address(RVA = "0x2779150", Offset = "0x2777D50", VA = "0x182779150")]
		public static void ConsumeNewStageTrigger(string actId, string stageId)
		{
		}

		// Token: 0x0602B7E4 RID: 178148 RVA: 0x000DC368 File Offset: 0x000DA568
		[Token(Token = "0x602B7E4")]
		[Address(RVA = "0x2778E70", Offset = "0x2777A70", VA = "0x182778E70")]
		public static bool CheckNewStageTrigger(string actId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0403EE13 RID: 257555
		[Token(Token = "0x403EE13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RecordBadgeUpdateTrigger;

		// Token: 0x0403EE14 RID: 257556
		[Token(Token = "0x403EE14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckBadgeUpdateTrigger;

		// Token: 0x0403EE15 RID: 257557
		[Token(Token = "0x403EE15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConsumeBadgeUpdateTrigger;

		// Token: 0x0403EE16 RID: 257558
		[Token(Token = "0x403EE16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetBadgeTriggerType;

		// Token: 0x0403EE17 RID: 257559
		[Token(Token = "0x403EE17")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RecordBadgeUpdateEntryTrigger;

		// Token: 0x0403EE18 RID: 257560
		[Token(Token = "0x403EE18")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckBadgeUpdateEntryTrigger;

		// Token: 0x0403EE19 RID: 257561
		[Token(Token = "0x403EE19")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConsumeBadgeUpdateEntryTrigger;

		// Token: 0x0403EE1A RID: 257562
		[Token(Token = "0x403EE1A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetBadgeTriggerEntryType;

		// Token: 0x0403EE1B RID: 257563
		[Token(Token = "0x403EE1B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ConsumeNewZoneTrigger;

		// Token: 0x0403EE1C RID: 257564
		[Token(Token = "0x403EE1C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckNewZoneTrigger;

		// Token: 0x0403EE1D RID: 257565
		[Token(Token = "0x403EE1D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RecordStageUpdateTrigger;

		// Token: 0x0403EE1E RID: 257566
		[Token(Token = "0x403EE1E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ConsumeNewStageTrigger;

		// Token: 0x0403EE1F RID: 257567
		[Token(Token = "0x403EE1F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckNewStageTrigger;
	}
}
