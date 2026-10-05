using System;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FD6 RID: 20438
	[Token(Token = "0x2004FD6")]
	public class EnemyDuelBetPlayerViewModel : IHotfixable, IComparable<EnemyDuelBetPlayerViewModel>
	{
		// Token: 0x0601E591 RID: 124305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E591")]
		[Address(RVA = "0x1813890", Offset = "0x1812490", VA = "0x181813890")]
		public void LoadData(EnemyDuelPlayerData playerData)
		{
		}

		// Token: 0x0601E592 RID: 124306 RVA: 0x000AE360 File Offset: 0x000AC560
		[Token(Token = "0x601E592")]
		[Address(RVA = "0x18137B0", Offset = "0x18123B0", VA = "0x1818137B0", Slot = "4")]
		public int CompareTo(EnemyDuelBetPlayerViewModel other)
		{
			return 0;
		}

		// Token: 0x0601E593 RID: 124307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E593")]
		[Address(RVA = "0x18139B0", Offset = "0x18125B0", VA = "0x1818139B0")]
		public EnemyDuelBetPlayerViewModel()
		{
		}

		// Token: 0x04028915 RID: 166165
		[Token(Token = "0x4028915")]
		[FieldOffset(Offset = "0x10")]
		public string playerId;

		// Token: 0x04028916 RID: 166166
		[Token(Token = "0x4028916")]
		[FieldOffset(Offset = "0x18")]
		public string playerNickname;

		// Token: 0x04028917 RID: 166167
		[Token(Token = "0x4028917")]
		[FieldOffset(Offset = "0x20")]
		public string npcAvatarId;

		// Token: 0x04028918 RID: 166168
		[Token(Token = "0x4028918")]
		[FieldOffset(Offset = "0x28")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04028919 RID: 166169
		[Token(Token = "0x4028919")]
		[FieldOffset(Offset = "0x40")]
		public EnemyDuelChoiceSide playerSideType;

		// Token: 0x0402891A RID: 166170
		[Token(Token = "0x402891A")]
		[FieldOffset(Offset = "0x44")]
		public int winStreakCount;

		// Token: 0x0402891B RID: 166171
		[Token(Token = "0x402891B")]
		[FieldOffset(Offset = "0x48")]
		public bool isExBet;

		// Token: 0x0402891C RID: 166172
		[Token(Token = "0x402891C")]
		[FieldOffset(Offset = "0x50")]
		public long lastUpdateTime;

		// Token: 0x0402891D RID: 166173
		[Token(Token = "0x402891D")]
		[FieldOffset(Offset = "0x58")]
		public bool isNpc;

		// Token: 0x0402891E RID: 166174
		[Token(Token = "0x402891E")]
		[FieldOffset(Offset = "0x59")]
		public bool isSelf;

		// Token: 0x0402891F RID: 166175
		[Token(Token = "0x402891F")]
		[FieldOffset(Offset = "0x5A")]
		public bool isSurvive;

		// Token: 0x04028920 RID: 166176
		[Token(Token = "0x4028920")]
		[FieldOffset(Offset = "0x5C")]
		public int curMoney;

		// Token: 0x04028921 RID: 166177
		[Token(Token = "0x4028921")]
		[FieldOffset(Offset = "0x60")]
		public int curRank;

		// Token: 0x04028922 RID: 166178
		[Token(Token = "0x4028922")]
		[FieldOffset(Offset = "0x64")]
		public int index;

		// Token: 0x04028923 RID: 166179
		[Token(Token = "0x4028923")]
		[FieldOffset(Offset = "0x68")]
		public int minWinStreakCount;

		// Token: 0x04028924 RID: 166180
		[Token(Token = "0x4028924")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028925 RID: 166181
		[Token(Token = "0x4028925")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04028926 RID: 166182
		[Token(Token = "0x4028926")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
