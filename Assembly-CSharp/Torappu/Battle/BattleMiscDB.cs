using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200266D RID: 9837
	[Token(Token = "0x200266D")]
	[CreateAssetMenu(fileName = "battle_misc_db", menuName = "Torappu/DB/Table/BattleMiscTable")]
	[Serializable]
	public class BattleMiscDB : ConstTable<BattleMiscData, BattleMiscDB>
	{
		// Token: 0x06010167 RID: 65895 RVA: 0x00062328 File Offset: 0x00060528
		[Token(Token = "0x6010167")]
		[Address(RVA = "0x7BD120", Offset = "0x7BBD20", VA = "0x1807BD120")]
		public bool TryGetSceneId(string levelId, out LevelScenePair levelScenePair)
		{
			return default(bool);
		}

		// Token: 0x06010168 RID: 65896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010168")]
		[Address(RVA = "0x7BCCD0", Offset = "0x7BB8D0", VA = "0x1807BCCD0")]
		public List<string> GetEffectBlackListOrNull(string skillId)
		{
			return null;
		}

		// Token: 0x06010169 RID: 65897 RVA: 0x00062340 File Offset: 0x00060540
		[Token(Token = "0x6010169")]
		[Address(RVA = "0x7BD050", Offset = "0x7BBC50", VA = "0x1807BD050")]
		public bool TryGetParticleEffectManagerConfig(string activityId, out ParticleEffectManagerConfig config)
		{
			return default(bool);
		}

		// Token: 0x0601016A RID: 65898 RVA: 0x00062358 File Offset: 0x00060558
		[Token(Token = "0x601016A")]
		[Address(RVA = "0x7BCE10", Offset = "0x7BBA10", VA = "0x1807BCE10")]
		public TileTypesMask GetTileTypesMask(string tileKey)
		{
			return TileTypesMask.NONE;
		}

		// Token: 0x0601016B RID: 65899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601016B")]
		[Address(RVA = "0x7BCC70", Offset = "0x7BB870", VA = "0x1807BCC70")]
		public void EditorGrabMapPreviewPath()
		{
		}

		// Token: 0x0601016C RID: 65900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601016C")]
		[Address(RVA = "0x7BCC10", Offset = "0x7BB810", VA = "0x1807BCC10")]
		public void EditorCollectBlackList(Dictionary<string, List<string>> blacklist)
		{
		}

		// Token: 0x0601016D RID: 65901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601016D")]
		[Address(RVA = "0x7BD220", Offset = "0x7BBE20", VA = "0x1807BD220")]
		public BattleMiscDB()
		{
		}

		// Token: 0x04011E51 RID: 73297
		[Token(Token = "0x4011E51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetSceneId;

		// Token: 0x04011E52 RID: 73298
		[Token(Token = "0x4011E52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEffectBlackListOrNull;

		// Token: 0x04011E53 RID: 73299
		[Token(Token = "0x4011E53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetParticleEffectManagerConfig;

		// Token: 0x04011E54 RID: 73300
		[Token(Token = "0x4011E54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTileTypesMask;

		// Token: 0x04011E55 RID: 73301
		[Token(Token = "0x4011E55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EditorGrabMapPreviewPath;

		// Token: 0x04011E56 RID: 73302
		[Token(Token = "0x4011E56")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EditorCollectBlackList;

		// Token: 0x04011E57 RID: 73303
		[Token(Token = "0x4011E57")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
