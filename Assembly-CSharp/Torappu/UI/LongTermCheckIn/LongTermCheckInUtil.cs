using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049C3 RID: 18883
	[Token(Token = "0x20049C3")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class LongTermCheckInUtil
	{
		// Token: 0x0601C717 RID: 116503 RVA: 0x000A86D8 File Offset: 0x000A68D8
		[Token(Token = "0x601C717")]
		[Address(RVA = "0x15E6420", Offset = "0x15E5020", VA = "0x1815E6420")]
		public static bool CheckIfLongTermCheckInOpen()
		{
			return default(bool);
		}

		// Token: 0x0601C718 RID: 116504 RVA: 0x000A86F0 File Offset: 0x000A68F0
		[Token(Token = "0x601C718")]
		[Address(RVA = "0x15E64E0", Offset = "0x15E50E0", VA = "0x1815E64E0")]
		public static bool CheckIfShowTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601C719 RID: 116505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C719")]
		[Address(RVA = "0x15E6580", Offset = "0x15E5180", VA = "0x1815E6580")]
		public static void ConsumeTrackPoint()
		{
		}

		// Token: 0x0601C71A RID: 116506 RVA: 0x000A8708 File Offset: 0x000A6908
		[Token(Token = "0x601C71A")]
		[Address(RVA = "0x15E6220", Offset = "0x15E4E20", VA = "0x1815E6220")]
		public static bool CheckIfCanReceive()
		{
			return default(bool);
		}

		// Token: 0x0601C71B RID: 116507 RVA: 0x000A8720 File Offset: 0x000A6920
		[Token(Token = "0x601C71B")]
		[Address(RVA = "0x15E6140", Offset = "0x15E4D40", VA = "0x1815E6140")]
		public static LongTermCheckInGroupStatus CheckGroupStatus(LongTermCheckInGroupData data, PlayerDataModel playerData)
		{
			return LongTermCheckInGroupStatus.UNCOMPLETE;
		}

		// Token: 0x04025454 RID: 152660
		[Token(Token = "0x4025454")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfLongTermCheckInOpen;

		// Token: 0x04025455 RID: 152661
		[Token(Token = "0x4025455")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfShowTrackPoint;

		// Token: 0x04025456 RID: 152662
		[Token(Token = "0x4025456")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConsumeTrackPoint;

		// Token: 0x04025457 RID: 152663
		[Token(Token = "0x4025457")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfCanReceive;

		// Token: 0x04025458 RID: 152664
		[Token(Token = "0x4025458")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckGroupStatus;
	}
}
