using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005054 RID: 20564
	[Token(Token = "0x2005054")]
	public class EnemyDuelPrepareSelectModeCardViewModel : IComparable<EnemyDuelPrepareSelectModeCardViewModel>
	{
		// Token: 0x0601E7BA RID: 124858 RVA: 0x000AE918 File Offset: 0x000ACB18
		[Token(Token = "0x601E7BA")]
		[Address(RVA = "0x182BA60", Offset = "0x182A660", VA = "0x18182BA60", Slot = "4")]
		public int CompareTo(EnemyDuelPrepareSelectModeCardViewModel other)
		{
			return 0;
		}

		// Token: 0x0601E7BB RID: 124859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7BB")]
		[Address(RVA = "0x182BAB0", Offset = "0x182A6B0", VA = "0x18182BAB0")]
		public void RefreshData(EnemyDuelPrepareSelectModeViewModel mainViewModel)
		{
		}

		// Token: 0x0601E7BC RID: 124860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7BC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelPrepareSelectModeCardViewModel()
		{
		}

		// Token: 0x04028D49 RID: 167241
		[Token(Token = "0x4028D49")]
		[FieldOffset(Offset = "0x10")]
		public int seqNum;

		// Token: 0x04028D4A RID: 167242
		[Token(Token = "0x4028D4A")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x04028D4B RID: 167243
		[Token(Token = "0x4028D4B")]
		[FieldOffset(Offset = "0x20")]
		public int sortedIdx;

		// Token: 0x04028D4C RID: 167244
		[Token(Token = "0x4028D4C")]
		[FieldOffset(Offset = "0x24")]
		public bool isLock;

		// Token: 0x04028D4D RID: 167245
		[Token(Token = "0x4028D4D")]
		[FieldOffset(Offset = "0x25")]
		public bool isRoom;

		// Token: 0x04028D4E RID: 167246
		[Token(Token = "0x4028D4E")]
		[FieldOffset(Offset = "0x28")]
		public ActivityEnemyDuelModeData modeData;

		// Token: 0x04028D4F RID: 167247
		[Token(Token = "0x4028D4F")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerEnemyDuelActivity.ModeInfo playerModeData;

		// Token: 0x04028D50 RID: 167248
		[Token(Token = "0x4028D50")]
		[FieldOffset(Offset = "0x38")]
		public string lockText;

		// Token: 0x04028D51 RID: 167249
		[Token(Token = "0x4028D51")]
		[FieldOffset(Offset = "0x40")]
		public string lockToast;
	}
}
