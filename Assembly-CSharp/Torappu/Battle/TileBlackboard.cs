using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200238B RID: 9099
	[Token(Token = "0x200238B")]
	public class TileBlackboard : Tile.Behaviour
	{
		// Token: 0x0600E6C9 RID: 59081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C9")]
		[Address(RVA = "0x5CB1C0", Offset = "0x5C9DC0", VA = "0x1805CB1C0", Slot = "4")]
		public override void Init(Tile tile)
		{
		}

		// Token: 0x0600E6CA RID: 59082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6CA")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public TileBlackboard()
		{
		}

		// Token: 0x0400FE22 RID: 65058
		[Token(Token = "0x400FE22")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Blackboard.DataPair> _blackboardPairs;
	}
}
