using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076DB RID: 30427
	[Token(Token = "0x20076DB")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act1VHalfIdleTriggerUtil
	{
		// Token: 0x0602AC26 RID: 175142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC26")]
		[Address(RVA = "0x268C4E0", Offset = "0x268B0E0", VA = "0x18268C4E0")]
		private static string _GenCharUnlockType(string actId)
		{
			return null;
		}

		// Token: 0x0602AC27 RID: 175143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC27")]
		[Address(RVA = "0x268C630", Offset = "0x268B230", VA = "0x18268C630")]
		private static string _GenTrapUnlockType(string actId)
		{
			return null;
		}

		// Token: 0x0602AC28 RID: 175144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC28")]
		[Address(RVA = "0x268C550", Offset = "0x268B150", VA = "0x18268C550")]
		private static string _GenItemUnlockType(string actId)
		{
			return null;
		}

		// Token: 0x0602AC29 RID: 175145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC29")]
		[Address(RVA = "0x268C5C0", Offset = "0x268B1C0", VA = "0x18268C5C0")]
		private static string _GenStageUnlockType(string actId)
		{
			return null;
		}

		// Token: 0x0602AC2A RID: 175146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC2A")]
		[Address(RVA = "0x268BEA0", Offset = "0x268AAA0", VA = "0x18268BEA0")]
		public static void ConsumeNewCharTrack(string actId, string charId)
		{
		}

		// Token: 0x0602AC2B RID: 175147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC2B")]
		[Address(RVA = "0x268BDF0", Offset = "0x268A9F0", VA = "0x18268BDF0")]
		public static void ConsumeAllNewCharTrack(string actId)
		{
		}

		// Token: 0x0602AC2C RID: 175148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC2C")]
		[Address(RVA = "0x268C1A0", Offset = "0x268ADA0", VA = "0x18268C1A0")]
		public static void RecordNewCharTrack(string actId, string charId)
		{
		}

		// Token: 0x0602AC2D RID: 175149 RVA: 0x000D9CF8 File Offset: 0x000D7EF8
		[Token(Token = "0x602AC2D")]
		[Address(RVA = "0x268BAD0", Offset = "0x268A6D0", VA = "0x18268BAD0")]
		public static bool CheckNewCharTrack(string actId, string charId)
		{
			return default(bool);
		}

		// Token: 0x0602AC2E RID: 175150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC2E")]
		[Address(RVA = "0x268C0D0", Offset = "0x268ACD0", VA = "0x18268C0D0")]
		public static void ConsumeNewTrapTrack(string actId, string trapId)
		{
		}

		// Token: 0x0602AC2F RID: 175151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC2F")]
		[Address(RVA = "0x268C410", Offset = "0x268B010", VA = "0x18268C410")]
		public static void RecordNewTrapTrack(string actId, string trapId)
		{
		}

		// Token: 0x0602AC30 RID: 175152 RVA: 0x000D9D10 File Offset: 0x000D7F10
		[Token(Token = "0x602AC30")]
		[Address(RVA = "0x268BD10", Offset = "0x268A910", VA = "0x18268BD10")]
		public static bool CheckNewTrapTrack(string actId, string trapId)
		{
			return default(bool);
		}

		// Token: 0x0602AC31 RID: 175153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC31")]
		[Address(RVA = "0x268BF70", Offset = "0x268AB70", VA = "0x18268BF70")]
		public static void ConsumeNewGachaPackageItemTrack(string actId)
		{
		}

		// Token: 0x0602AC32 RID: 175154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC32")]
		[Address(RVA = "0x268C270", Offset = "0x268AE70", VA = "0x18268C270")]
		public static void RecordNewGachaPackageItemTrack(string actId, string itemId)
		{
		}

		// Token: 0x0602AC33 RID: 175155 RVA: 0x000D9D28 File Offset: 0x000D7F28
		[Token(Token = "0x602AC33")]
		[Address(RVA = "0x268BBB0", Offset = "0x268A7B0", VA = "0x18268BBB0")]
		public static bool CheckNewGachaPackageItemTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602AC34 RID: 175156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC34")]
		[Address(RVA = "0x268C340", Offset = "0x268AF40", VA = "0x18268C340")]
		public static void RecordNewStageTrack(string actId, string stageId)
		{
		}

		// Token: 0x0602AC35 RID: 175157 RVA: 0x000D9D40 File Offset: 0x000D7F40
		[Token(Token = "0x602AC35")]
		[Address(RVA = "0x268BC60", Offset = "0x268A860", VA = "0x18268BC60")]
		public static bool CheckNewStageTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602AC36 RID: 175158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC36")]
		[Address(RVA = "0x268C020", Offset = "0x268AC20", VA = "0x18268C020")]
		public static void ConsumeNewStageTrack(string actId)
		{
		}

		// Token: 0x0602AC37 RID: 175159 RVA: 0x000D9D58 File Offset: 0x000D7F58
		[Token(Token = "0x602AC37")]
		[Address(RVA = "0x268B8B0", Offset = "0x268A4B0", VA = "0x18268B8B0")]
		public static bool CheckCharBuffTrackpoint(string actId, Dictionary<int, List<Act1VHalfIdleCharAvatarViewModel>> profMap)
		{
			return default(bool);
		}

		// Token: 0x0403D9D9 RID: 252377
		[Token(Token = "0x403D9D9")]
		private const string NEW_CHAR_TRACK_TYPE = "new_char_{0}";

		// Token: 0x0403D9DA RID: 252378
		[Token(Token = "0x403D9DA")]
		private const string NEW_TRAP_TRACK_TYPE = "new_trap_{0}";

		// Token: 0x0403D9DB RID: 252379
		[Token(Token = "0x403D9DB")]
		private const string NEW_ITEM_TRACK_TYPE = "new_item_{0}";

		// Token: 0x0403D9DC RID: 252380
		[Token(Token = "0x403D9DC")]
		private const string NEW_STAGE_TRACK_TYPE = "new_stage_{0}";

		// Token: 0x0403D9DD RID: 252381
		[Token(Token = "0x403D9DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GenCharUnlockType;

		// Token: 0x0403D9DE RID: 252382
		[Token(Token = "0x403D9DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenTrapUnlockType;

		// Token: 0x0403D9DF RID: 252383
		[Token(Token = "0x403D9DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenItemUnlockType;

		// Token: 0x0403D9E0 RID: 252384
		[Token(Token = "0x403D9E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenStageUnlockType;

		// Token: 0x0403D9E1 RID: 252385
		[Token(Token = "0x403D9E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConsumeNewCharTrack;

		// Token: 0x0403D9E2 RID: 252386
		[Token(Token = "0x403D9E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ConsumeAllNewCharTrack;

		// Token: 0x0403D9E3 RID: 252387
		[Token(Token = "0x403D9E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RecordNewCharTrack;

		// Token: 0x0403D9E4 RID: 252388
		[Token(Token = "0x403D9E4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckNewCharTrack;

		// Token: 0x0403D9E5 RID: 252389
		[Token(Token = "0x403D9E5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ConsumeNewTrapTrack;

		// Token: 0x0403D9E6 RID: 252390
		[Token(Token = "0x403D9E6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RecordNewTrapTrack;

		// Token: 0x0403D9E7 RID: 252391
		[Token(Token = "0x403D9E7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckNewTrapTrack;

		// Token: 0x0403D9E8 RID: 252392
		[Token(Token = "0x403D9E8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ConsumeNewGachaPackageItemTrack;

		// Token: 0x0403D9E9 RID: 252393
		[Token(Token = "0x403D9E9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RecordNewGachaPackageItemTrack;

		// Token: 0x0403D9EA RID: 252394
		[Token(Token = "0x403D9EA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckNewGachaPackageItemTrack;

		// Token: 0x0403D9EB RID: 252395
		[Token(Token = "0x403D9EB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RecordNewStageTrack;

		// Token: 0x0403D9EC RID: 252396
		[Token(Token = "0x403D9EC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckNewStageTrack;

		// Token: 0x0403D9ED RID: 252397
		[Token(Token = "0x403D9ED")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ConsumeNewStageTrack;

		// Token: 0x0403D9EE RID: 252398
		[Token(Token = "0x403D9EE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckCharBuffTrackpoint;
	}
}
