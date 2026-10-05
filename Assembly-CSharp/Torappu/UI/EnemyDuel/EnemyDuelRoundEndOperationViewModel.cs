using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200500E RID: 20494
	[Token(Token = "0x200500E")]
	public class EnemyDuelRoundEndOperationViewModel
	{
		// Token: 0x17004707 RID: 18183
		// (get) Token: 0x0601E698 RID: 124568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004707")]
		public List<OperationRoundRankItemModel> rankList
		{
			[Token(Token = "0x601E698")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E699 RID: 124569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E699")]
		[Address(RVA = "0x181E740", Offset = "0x181D340", VA = "0x18181E740")]
		public void LoadData()
		{
		}

		// Token: 0x0601E69A RID: 124570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E69A")]
		[Address(RVA = "0x181E960", Offset = "0x181D560", VA = "0x18181E960")]
		private void _LoadPlayersData(ActivityEnemyDuelData actData, Dictionary<string, EnemyDuelPlayerData> playerDict)
		{
		}

		// Token: 0x0601E69B RID: 124571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E69B")]
		[Address(RVA = "0x181EE60", Offset = "0x181DA60", VA = "0x18181EE60")]
		public EnemyDuelRoundEndOperationViewModel()
		{
		}

		// Token: 0x04028AFA RID: 166650
		[Token(Token = "0x4028AFA")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04028AFB RID: 166651
		[Token(Token = "0x4028AFB")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelRoundEndBarModel barModel;

		// Token: 0x04028AFC RID: 166652
		[Token(Token = "0x4028AFC")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isOut;

		// Token: 0x04028AFD RID: 166653
		[Token(Token = "0x4028AFD")]
		[FieldOffset(Offset = "0x50")]
		private List<OperationRoundRankItemModel> m_rankList;
	}
}
