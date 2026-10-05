using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C18 RID: 7192
	[Token(Token = "0x2001C18")]
	public struct LevelUpSnapshot : IHotfixable
	{
		// Token: 0x0600B34C RID: 45900 RVA: 0x00044238 File Offset: 0x00042438
		[Token(Token = "0x600B34C")]
		[Address(RVA = "0x32E51C0", Offset = "0x32E3DC0", VA = "0x1832E51C0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0600B34D RID: 45901 RVA: 0x00044250 File Offset: 0x00042450
		[Token(Token = "0x600B34D")]
		[Address(RVA = "0x32E4FC0", Offset = "0x32E3BC0", VA = "0x1832E4FC0")]
		public float GetRemainSecs()
		{
			return 0f;
		}

		// Token: 0x0600B34E RID: 45902 RVA: 0x00044268 File Offset: 0x00042468
		[Token(Token = "0x600B34E")]
		[Address(RVA = "0x32E4F10", Offset = "0x32E3B10", VA = "0x1832E4F10")]
		public float GetRemainProgress()
		{
			return 0f;
		}

		// Token: 0x0600B34F RID: 45903 RVA: 0x00044280 File Offset: 0x00042480
		[Token(Token = "0x600B34F")]
		[Address(RVA = "0x32E4CC0", Offset = "0x32E38C0", VA = "0x1832E4CC0")]
		public float GetProcessedProgress()
		{
			return 0f;
		}

		// Token: 0x0600B350 RID: 45904 RVA: 0x00044298 File Offset: 0x00042498
		[Token(Token = "0x600B350")]
		[Address(RVA = "0x32E48D0", Offset = "0x32E34D0", VA = "0x1832E48D0")]
		public static LevelUpSnapshot CreateSnapshot(PlayerBuildingTraining trainingModel)
		{
			return default(LevelUpSnapshot);
		}

		// Token: 0x0400AE9F RID: 44703
		[Token(Token = "0x400AE9F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LevelUpSnapshot EMPTY;

		// Token: 0x0400AEA0 RID: 44704
		[Token(Token = "0x400AEA0")]
		[FieldOffset(Offset = "0x0")]
		public bool isTraining;

		// Token: 0x0400AEA1 RID: 44705
		[Token(Token = "0x400AEA1")]
		[FieldOffset(Offset = "0x4")]
		public int charInstId;

		// Token: 0x0400AEA2 RID: 44706
		[Token(Token = "0x400AEA2")]
		[FieldOffset(Offset = "0x8")]
		public int skillIndex;

		// Token: 0x0400AEA3 RID: 44707
		[Token(Token = "0x400AEA3")]
		[FieldOffset(Offset = "0xC")]
		public float speed;

		// Token: 0x0400AEA4 RID: 44708
		[Token(Token = "0x400AEA4")]
		[FieldOffset(Offset = "0x10")]
		public DateTime lastUpdateTime;

		// Token: 0x0400AEA5 RID: 44709
		[Token(Token = "0x400AEA5")]
		[FieldOffset(Offset = "0x18")]
		public long totalRequirePoint;

		// Token: 0x0400AEA6 RID: 44710
		[Token(Token = "0x400AEA6")]
		[FieldOffset(Offset = "0x20")]
		public double processPoint;

		// Token: 0x0400AEA7 RID: 44711
		[Token(Token = "0x400AEA7")]
		[FieldOffset(Offset = "0x28")]
		public bool isBuffed;

		// Token: 0x0400AEA8 RID: 44712
		[Token(Token = "0x400AEA8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0400AEA9 RID: 44713
		[Token(Token = "0x400AEA9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRemainSecs;

		// Token: 0x0400AEAA RID: 44714
		[Token(Token = "0x400AEAA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetRemainProgress;

		// Token: 0x0400AEAB RID: 44715
		[Token(Token = "0x400AEAB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProcessedProgress;

		// Token: 0x0400AEAC RID: 44716
		[Token(Token = "0x400AEAC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CreateSnapshot;
	}
}
