using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002388 RID: 9096
	[Token(Token = "0x2002388")]
	public class RunActionsForTile : Tile.Behaviour, IActionNodeSource
	{
		// Token: 0x0600E6C4 RID: 59076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C4")]
		[Address(RVA = "0x5C8500", Offset = "0x5C7100", VA = "0x1805C8500", Slot = "10")]
		public override void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x0600E6C5 RID: 59077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C5")]
		[Address(RVA = "0x5C84D0", Offset = "0x5C70D0", VA = "0x1805C84D0", Slot = "12")]
		public void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600E6C6 RID: 59078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C6")]
		[Address(RVA = "0x5C8680", Offset = "0x5C7280", VA = "0x1805C8680")]
		public RunActionsForTile()
		{
		}

		// Token: 0x0400FE1E RID: 65054
		[Token(Token = "0x400FE1E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActionArray _actionsOnGameOver;
	}
}
