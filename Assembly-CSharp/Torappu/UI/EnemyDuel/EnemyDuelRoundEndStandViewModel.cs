using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005015 RID: 20501
	[Token(Token = "0x2005015")]
	public class EnemyDuelRoundEndStandViewModel : IHotfixable
	{
		// Token: 0x0601E6B3 RID: 124595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6B3")]
		[Address(RVA = "0x1834190", Offset = "0x1832D90", VA = "0x181834190")]
		public void LoadData()
		{
		}

		// Token: 0x0601E6B4 RID: 124596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6B4")]
		[Address(RVA = "0x18347F0", Offset = "0x18333F0", VA = "0x1818347F0")]
		public EnemyDuelRoundEndStandViewModel()
		{
		}

		// Token: 0x04028B3D RID: 166717
		[Token(Token = "0x4028B3D")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04028B3E RID: 166718
		[Token(Token = "0x4028B3E")]
		[FieldOffset(Offset = "0x18")]
		public int curRoundIndex;

		// Token: 0x04028B3F RID: 166719
		[Token(Token = "0x4028B3F")]
		[FieldOffset(Offset = "0x1C")]
		public bool isProtectedRound;

		// Token: 0x04028B40 RID: 166720
		[Token(Token = "0x4028B40")]
		[FieldOffset(Offset = "0x1D")]
		public bool isLastRound;

		// Token: 0x04028B41 RID: 166721
		[Token(Token = "0x4028B41")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<EnemyDuelPlayerData> playerDataList;

		// Token: 0x04028B42 RID: 166722
		[Token(Token = "0x4028B42")]
		[FieldOffset(Offset = "0x28")]
		public EnemyDuelRoundEndBarModel barModel;

		// Token: 0x04028B43 RID: 166723
		[Token(Token = "0x4028B43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028B44 RID: 166724
		[Token(Token = "0x4028B44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
