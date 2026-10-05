using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using Torappu.DataStream;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005095 RID: 20629
	[Token(Token = "0x2005095")]
	public struct EnemyDuelBattleStatus : IStreamDeserialize
	{
		// Token: 0x17004754 RID: 18260
		// (get) Token: 0x0601E8A2 RID: 125090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004754")]
		public EnemyDuelBattleStatus.EntryData entryData
		{
			[Token(Token = "0x601E8A2")]
			[Address(RVA = "0x183F1C0", Offset = "0x183DDC0", VA = "0x18183F1C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E8A3 RID: 125091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8A3")]
		[Address(RVA = "0x183F160", Offset = "0x183DD60", VA = "0x18183F160")]
		public EnemyDuelBattleStatus(int curRound)
		{
		}

		// Token: 0x0601E8A4 RID: 125092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8A4")]
		[Address(RVA = "0x183F030", Offset = "0x183DC30", VA = "0x18183F030", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04028EB0 RID: 167600
		[Token(Token = "0x4028EB0")]
		[FieldOffset(Offset = "0x0")]
		public EnemyDuelServiceGameState state;

		// Token: 0x04028EB1 RID: 167601
		[Token(Token = "0x4028EB1")]
		[FieldOffset(Offset = "0x4")]
		public int round;

		// Token: 0x04028EB2 RID: 167602
		[Token(Token = "0x4028EB2")]
		[FieldOffset(Offset = "0x8")]
		public long forceEndTs;

		// Token: 0x04028EB3 RID: 167603
		[Token(Token = "0x4028EB3")]
		[FieldOffset(Offset = "0x10")]
		public List<EnemyDuelBattleStatus.EntryData> srcEntryData;

		// Token: 0x04028EB4 RID: 167604
		[Token(Token = "0x4028EB4")]
		[FieldOffset(Offset = "0x18")]
		public List<EnemyDuelBattleStatus.BetItem> betList;

		// Token: 0x04028EB5 RID: 167605
		[Token(Token = "0x4028EB5")]
		[FieldOffset(Offset = "0x20")]
		public List<EnemyDuelBattleStatus.RoundLeaderBoard> leaderBoard;

		// Token: 0x02005096 RID: 20630
		[Token(Token = "0x2005096")]
		public class EntryData : IStreamDeserialize
		{
			// Token: 0x0601E8A5 RID: 125093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E8A5")]
			[Address(RVA = "0x184C600", Offset = "0x184B200", VA = "0x18184C600", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x0601E8A6 RID: 125094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E8A6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EntryData()
			{
			}

			// Token: 0x04028EB6 RID: 167606
			[Token(Token = "0x4028EB6")]
			[FieldOffset(Offset = "0x10")]
			public int seed;

			// Token: 0x04028EB7 RID: 167607
			[Token(Token = "0x4028EB7")]
			[FieldOffset(Offset = "0x18")]
			public List<int> seedHistory;

			// Token: 0x04028EB8 RID: 167608
			[Token(Token = "0x4028EB8")]
			[FieldOffset(Offset = "0x20")]
			public List<EnemyDuelChoiceSide> sideHistory;
		}

		// Token: 0x02005097 RID: 20631
		[Token(Token = "0x2005097")]
		public class BetItem : IStreamDeserialize
		{
			// Token: 0x0601E8A7 RID: 125095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E8A7")]
			[Address(RVA = "0x1837E20", Offset = "0x1836A20", VA = "0x181837E20", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x0601E8A8 RID: 125096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E8A8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BetItem()
			{
			}

			// Token: 0x04028EB9 RID: 167609
			[Token(Token = "0x4028EB9")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04028EBA RID: 167610
			[Token(Token = "0x4028EBA")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelChoiceSide side;

			// Token: 0x04028EBB RID: 167611
			[Token(Token = "0x4028EBB")]
			[FieldOffset(Offset = "0x1C")]
			public bool allin;

			// Token: 0x04028EBC RID: 167612
			[Token(Token = "0x4028EBC")]
			[FieldOffset(Offset = "0x20")]
			public int streak;

			// Token: 0x04028EBD RID: 167613
			[Token(Token = "0x4028EBD")]
			[FieldOffset(Offset = "0x28")]
			public long updateTs;
		}

		// Token: 0x02005098 RID: 20632
		[Token(Token = "0x2005098")]
		public class RoundLeaderBoard : IStreamDeserialize
		{
			// Token: 0x0601E8A9 RID: 125097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E8A9")]
			[Address(RVA = "0x184CED0", Offset = "0x184BAD0", VA = "0x18184CED0", Slot = "4")]
			public void Read(IStreamReader from)
			{
			}

			// Token: 0x0601E8AA RID: 125098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E8AA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoundLeaderBoard()
			{
			}

			// Token: 0x04028EBE RID: 167614
			[Token(Token = "0x4028EBE")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04028EBF RID: 167615
			[Token(Token = "0x4028EBF")]
			[FieldOffset(Offset = "0x18")]
			public int oldMoney;

			// Token: 0x04028EC0 RID: 167616
			[Token(Token = "0x4028EC0")]
			[FieldOffset(Offset = "0x1C")]
			public int newMoney;

			// Token: 0x04028EC1 RID: 167617
			[Token(Token = "0x4028EC1")]
			[FieldOffset(Offset = "0x20")]
			public int maxRound;

			// Token: 0x04028EC2 RID: 167618
			[Token(Token = "0x4028EC2")]
			[FieldOffset(Offset = "0x24")]
			public int streak;

			// Token: 0x04028EC3 RID: 167619
			[Token(Token = "0x4028EC3")]
			[FieldOffset(Offset = "0x28")]
			public EnemyDuelRoundResult result;

			// Token: 0x04028EC4 RID: 167620
			[Token(Token = "0x4028EC4")]
			[FieldOffset(Offset = "0x2C")]
			public EnemyDuelChoiceSide bet;

			// Token: 0x04028EC5 RID: 167621
			[Token(Token = "0x4028EC5")]
			[FieldOffset(Offset = "0x30")]
			public EnemyDuelShieldState shieldState;
		}
	}
}
