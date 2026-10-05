using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Multiplayer.Servers;

namespace Torappu.Multiplayer
{
	// Token: 0x02001530 RID: 5424
	[Token(Token = "0x2001530")]
	public class TeamInfo
	{
		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06007C84 RID: 31876 RVA: 0x00037518 File Offset: 0x00035718
		[Token(Token = "0x17000ECA")]
		public TeamProtocol.StageRandomType stageRandomType
		{
			[Token(Token = "0x6007C84")]
			[Address(RVA = "0x284E8E0", Offset = "0x284D4E0", VA = "0x18284E8E0")]
			get
			{
				return TeamProtocol.StageRandomType.NOT_RANDOM;
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06007C85 RID: 31877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECB")]
		public string stageID
		{
			[Token(Token = "0x6007C85")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06007C86 RID: 31878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECC")]
		public string ownerID
		{
			[Token(Token = "0x6007C86")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06007C87 RID: 31879 RVA: 0x00037530 File Offset: 0x00035730
		[Token(Token = "0x17000ECD")]
		public long endTs
		{
			[Token(Token = "0x6007C87")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06007C88 RID: 31880 RVA: 0x00037548 File Offset: 0x00035748
		[Token(Token = "0x17000ECE")]
		public TeamProtocol.TeamState state
		{
			[Token(Token = "0x6007C88")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return TeamProtocol.TeamState.INIT;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECF")]
		public List<TeamProtocol.STPlayerStatus> players
		{
			[Token(Token = "0x6007C89")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06007C8A RID: 31882 RVA: 0x00037560 File Offset: 0x00035760
		[Token(Token = "0x17000ED0")]
		public bool isMatch
		{
			[Token(Token = "0x6007C8A")]
			[Address(RVA = "0x284E8D0", Offset = "0x284D4D0", VA = "0x18284E8D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x00037578 File Offset: 0x00035778
		[Token(Token = "0x17000ED1")]
		public bool valid
		{
			[Token(Token = "0x6007C8B")]
			[Address(RVA = "0xAC8CE0", Offset = "0xAC78E0", VA = "0x180AC8CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06007C8C RID: 31884 RVA: 0x00037590 File Offset: 0x00035790
		[Token(Token = "0x17000ED2")]
		public bool isFlipMode
		{
			[Token(Token = "0x6007C8C")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C8D")]
		[Address(RVA = "0x284E5A0", Offset = "0x284D1A0", VA = "0x18284E5A0")]
		public void CopyFrom(TeamProtocol.STTeamStatus from)
		{
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C8E")]
		[Address(RVA = "0x284E4F0", Offset = "0x284D0F0", VA = "0x18284E4F0")]
		public void Clear()
		{
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C8F")]
		[Address(RVA = "0x284E840", Offset = "0x284D440", VA = "0x18284E840")]
		public TeamInfo()
		{
		}

		// Token: 0x04007C74 RID: 31860
		[Token(Token = "0x4007C74")]
		[FieldOffset(Offset = "0x10")]
		public string teamID;

		// Token: 0x04007C75 RID: 31861
		[Token(Token = "0x4007C75")]
		[FieldOffset(Offset = "0x18")]
		public TeamProtocol.STTeamStatus teamStatus;

		// Token: 0x04007C76 RID: 31862
		[Token(Token = "0x4007C76")]
		[FieldOffset(Offset = "0x98")]
		public bool start;

		// Token: 0x04007C77 RID: 31863
		[Token(Token = "0x4007C77")]
		[FieldOffset(Offset = "0xA0")]
		private ListDict<string, TeamProtocol.STBasicSquad> m_cachedSquad;
	}
}
