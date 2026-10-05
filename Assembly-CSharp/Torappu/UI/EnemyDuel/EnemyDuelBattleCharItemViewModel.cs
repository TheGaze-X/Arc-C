using System;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005001 RID: 20481
	[Token(Token = "0x2005001")]
	public class EnemyDuelBattleCharItemViewModel : IComparable<EnemyDuelBattleCharItemViewModel>, IHotfixable
	{
		// Token: 0x0601E665 RID: 124517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E665")]
		[Address(RVA = "0x180F3E0", Offset = "0x180DFE0", VA = "0x18180F3E0")]
		public void LoadData(EnemyDuelPlayerData playerData)
		{
		}

		// Token: 0x0601E666 RID: 124518 RVA: 0x000AE5E8 File Offset: 0x000AC7E8
		[Token(Token = "0x601E666")]
		[Address(RVA = "0x180F330", Offset = "0x180DF30", VA = "0x18180F330", Slot = "4")]
		public int CompareTo(EnemyDuelBattleCharItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0601E667 RID: 124519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E667")]
		[Address(RVA = "0x180F4C0", Offset = "0x180E0C0", VA = "0x18180F4C0")]
		public EnemyDuelBattleCharItemViewModel()
		{
		}

		// Token: 0x04028A64 RID: 166500
		[Token(Token = "0x4028A64")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04028A65 RID: 166501
		[Token(Token = "0x4028A65")]
		[FieldOffset(Offset = "0x18")]
		public bool isNpc;

		// Token: 0x04028A66 RID: 166502
		[Token(Token = "0x4028A66")]
		[FieldOffset(Offset = "0x19")]
		public bool isSelf;

		// Token: 0x04028A67 RID: 166503
		[Token(Token = "0x4028A67")]
		[FieldOffset(Offset = "0x20")]
		public string npcAvatarId;

		// Token: 0x04028A68 RID: 166504
		[Token(Token = "0x4028A68")]
		[FieldOffset(Offset = "0x28")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04028A69 RID: 166505
		[Token(Token = "0x4028A69")]
		[FieldOffset(Offset = "0x40")]
		public int round;

		// Token: 0x04028A6A RID: 166506
		[Token(Token = "0x4028A6A")]
		[FieldOffset(Offset = "0x44")]
		public EnemyDuelChoiceSide choiceSide;

		// Token: 0x04028A6B RID: 166507
		[Token(Token = "0x4028A6B")]
		[FieldOffset(Offset = "0x48")]
		public EnemyDuelChoiceType choiceType;

		// Token: 0x04028A6C RID: 166508
		[Token(Token = "0x4028A6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028A6D RID: 166509
		[Token(Token = "0x4028A6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04028A6E RID: 166510
		[Token(Token = "0x4028A6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
