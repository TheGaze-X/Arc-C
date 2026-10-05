using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.DevelopTools.Tester
{
	// Token: 0x020028A1 RID: 10401
	[Token(Token = "0x20028A1")]
	public class BattleLineupRecorder : MonoBehaviour
	{
		// Token: 0x060114E2 RID: 70882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114E2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BattleLineupRecorder()
		{
		}

		// Token: 0x04013547 RID: 79175
		[Token(Token = "0x4013547")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextAsset _lineupFile;

		// Token: 0x020028A2 RID: 10402
		[Token(Token = "0x20028A2")]
		[Serializable]
		private class CharacterSpec
		{
			// Token: 0x060114E3 RID: 70883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60114E3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharacterSpec()
			{
			}

			// Token: 0x04013548 RID: 79176
			[Token(Token = "0x4013548")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x04013549 RID: 79177
			[Token(Token = "0x4013549")]
			[FieldOffset(Offset = "0x18")]
			public GridPosition position;

			// Token: 0x0401354A RID: 79178
			[Token(Token = "0x401354A")]
			[FieldOffset(Offset = "0x20")]
			public SharedConsts.Direction direction;
		}
	}
}
