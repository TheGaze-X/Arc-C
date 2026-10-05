using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002389 RID: 9097
	[Token(Token = "0x2002389")]
	public class SandboxSeasonCheckerWithBlackboard : Tile.Behaviour
	{
		// Token: 0x0600E6C7 RID: 59079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C7")]
		[Address(RVA = "0x5CAB80", Offset = "0x5C9780", VA = "0x1805CAB80", Slot = "4")]
		public override void Init(Tile initTile)
		{
		}

		// Token: 0x0600E6C8 RID: 59080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C8")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public SandboxSeasonCheckerWithBlackboard()
		{
		}

		// Token: 0x0400FE1F RID: 65055
		[Token(Token = "0x400FE1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SandboxSeasonCheckerWithBlackboard.SeasonConfig> _configList;

		// Token: 0x0200238A RID: 9098
		[Token(Token = "0x200238A")]
		[Serializable]
		private struct SeasonConfig
		{
			// Token: 0x0400FE20 RID: 65056
			[Token(Token = "0x400FE20")]
			[FieldOffset(Offset = "0x0")]
			public List<Blackboard.DataPair> blackboard;

			// Token: 0x0400FE21 RID: 65057
			[Token(Token = "0x400FE21")]
			[FieldOffset(Offset = "0x8")]
			public List<SandboxV2SeasonType> validSeason;
		}
	}
}
