using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010DB RID: 4315
	[Token(Token = "0x20010DB")]
	public class LevelTempData
	{
		// Token: 0x06006E7D RID: 28285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7D")]
		[Address(RVA = "0x21067B0", Offset = "0x21053B0", VA = "0x1821067B0")]
		public void AssignData(LevelData levelData)
		{
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7E")]
		[Address(RVA = "0x21068F0", Offset = "0x21054F0", VA = "0x1821068F0")]
		public LevelTempData()
		{
		}

		// Token: 0x04005C6D RID: 23661
		[Token(Token = "0x4005C6D")]
		[FieldOffset(Offset = "0x10")]
		public List<LegacyInLevelRuneData> runes;

		// Token: 0x04005C6E RID: 23662
		[Token(Token = "0x4005C6E")]
		[FieldOffset(Offset = "0x18")]
		public List<LevelData.GlobalBuffData> globalBuffs;

		// Token: 0x04005C6F RID: 23663
		[Token(Token = "0x4005C6F")]
		[FieldOffset(Offset = "0x20")]
		public List<RouteData> routes;

		// Token: 0x04005C70 RID: 23664
		[Token(Token = "0x4005C70")]
		[FieldOffset(Offset = "0x28")]
		public List<RouteData> extraRoutes;

		// Token: 0x04005C71 RID: 23665
		[Token(Token = "0x4005C71")]
		[FieldOffset(Offset = "0x30")]
		public List<LevelData.EnemyData> enemies;

		// Token: 0x04005C72 RID: 23666
		[Token(Token = "0x4005C72")]
		[FieldOffset(Offset = "0x38")]
		public List<LevelData.EnemyDataDbReference> enemyDbRefs;

		// Token: 0x04005C73 RID: 23667
		[Token(Token = "0x4005C73")]
		[FieldOffset(Offset = "0x40")]
		public List<LevelData.WaveData> waves;

		// Token: 0x04005C74 RID: 23668
		[Token(Token = "0x4005C74")]
		[FieldOffset(Offset = "0x48")]
		public ListDict<string, LevelData.BranchData> branches;
	}
}
