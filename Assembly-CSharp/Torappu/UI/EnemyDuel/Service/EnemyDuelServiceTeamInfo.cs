using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005063 RID: 20579
	[Token(Token = "0x2005063")]
	public class EnemyDuelServiceTeamInfo
	{
		// Token: 0x17004738 RID: 18232
		// (get) Token: 0x0601E825 RID: 124965 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E826 RID: 124966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004738")]
		public string teamID
		{
			[Token(Token = "0x601E825")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E826")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004739 RID: 18233
		// (get) Token: 0x0601E827 RID: 124967 RVA: 0x000AEA38 File Offset: 0x000ACC38
		[Token(Token = "0x17004739")]
		public EnemyDuelTeamState state
		{
			[Token(Token = "0x601E827")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return EnemyDuelTeamState.NONE;
			}
		}

		// Token: 0x1700473A RID: 18234
		// (get) Token: 0x0601E828 RID: 124968 RVA: 0x000AEA50 File Offset: 0x000ACC50
		[Token(Token = "0x1700473A")]
		public bool closedTeam
		{
			[Token(Token = "0x601E828")]
			[Address(RVA = "0x1848070", Offset = "0x1846C70", VA = "0x181848070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700473B RID: 18235
		// (get) Token: 0x0601E829 RID: 124969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700473B")]
		public List<STDuelPlayerStatus> playerStatus
		{
			[Token(Token = "0x601E829")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700473C RID: 18236
		// (get) Token: 0x0601E82A RID: 124970 RVA: 0x000AEA68 File Offset: 0x000ACC68
		[Token(Token = "0x1700473C")]
		public int playerCnt
		{
			[Token(Token = "0x601E82A")]
			[Address(RVA = "0x1848090", Offset = "0x1846C90", VA = "0x181848090")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700473D RID: 18237
		// (get) Token: 0x0601E82B RID: 124971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700473D")]
		public string hostId
		{
			[Token(Token = "0x601E82B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E82C RID: 124972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E82C")]
		[Address(RVA = "0x1848000", Offset = "0x1846C00", VA = "0x181848000")]
		public void Fill(string teamId, EnemyDuelTeamStatus newStatus)
		{
		}

		// Token: 0x0601E82D RID: 124973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E82D")]
		[Address(RVA = "0x1847FB0", Offset = "0x1846BB0", VA = "0x181847FB0")]
		public void Clear()
		{
		}

		// Token: 0x0601E82E RID: 124974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E82E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelServiceTeamInfo()
		{
		}

		// Token: 0x04028DC8 RID: 167368
		[Token(Token = "0x4028DC8")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelTeamStatus teamStatus;
	}
}
