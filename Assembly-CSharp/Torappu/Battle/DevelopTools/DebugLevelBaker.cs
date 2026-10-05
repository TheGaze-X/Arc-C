using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x0200288E RID: 10382
	[Token(Token = "0x200288E")]
	public class DebugLevelBaker : LevelBaker
	{
		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x060114AF RID: 70831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700263A")]
		[Inspect]
		public TextAsset levelJson
		{
			[Token(Token = "0x60114AF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x060114B0 RID: 70832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700263B")]
		protected override string outputFolder
		{
			[Token(Token = "0x60114B0")]
			[Address(RVA = "0x9214F0", Offset = "0x9200F0", VA = "0x1809214F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060114B1 RID: 70833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114B1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DebugLevelBaker()
		{
		}

		// Token: 0x040134FF RID: 79103
		[Token(Token = "0x40134FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private string _levelId;

		// Token: 0x04013500 RID: 79104
		[Token(Token = "0x4013500")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MapGraphic _graphicPrefab;

		// Token: 0x04013501 RID: 79105
		[Token(Token = "0x4013501")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private TextAsset _levelJson;
	}
}
