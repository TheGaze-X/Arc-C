using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005BE RID: 1470
	[Token(Token = "0x20005BE")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/EnemyDB")]
	[Serializable]
	public class EnemyDB : ConstTable<EnemyDatabase, EnemyDB>
	{
		// Token: 0x0600611A RID: 24858 RVA: 0x0002F910 File Offset: 0x0002DB10
		[Token(Token = "0x600611A")]
		[Address(RVA = "0x1DEA180", Offset = "0x1DE8D80", VA = "0x181DEA180")]
		public bool TryGet(string id, int level, out LevelData.EnemyData output)
		{
			return default(bool);
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x0002F928 File Offset: 0x0002DB28
		[Token(Token = "0x600611B")]
		[Address(RVA = "0x1DE9F50", Offset = "0x1DE8B50", VA = "0x181DE9F50")]
		public bool TryGet(LevelData.EnemyDataDbReference dbRef, out LevelData.EnemyData output)
		{
			return default(bool);
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600611C")]
		[Address(RVA = "0x1DE99F0", Offset = "0x1DE85F0", VA = "0x181DE99F0")]
		public string GetEnemyName(string enemyId)
		{
			return null;
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x0002F940 File Offset: 0x0002DB40
		[Token(Token = "0x600611D")]
		[Address(RVA = "0x1DE9BA0", Offset = "0x1DE87A0", VA = "0x181DE9BA0")]
		public bool TryGetHandbookEnemyData(string id, int level, out InternalEnemyHBData output)
		{
			return default(bool);
		}

		// Token: 0x0600611E RID: 24862 RVA: 0x0002F958 File Offset: 0x0002DB58
		[Token(Token = "0x600611E")]
		[Address(RVA = "0x1DE9D00", Offset = "0x1DE8900", VA = "0x181DE9D00")]
		public bool TryGetHandbookEnemyData(LevelData.EnemyDataDbReference dbRef, out InternalEnemyHBData output, out bool isSp)
		{
			return default(bool);
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600611F")]
		[Address(RVA = "0x1DEA250", Offset = "0x1DE8E50", VA = "0x181DEA250")]
		private InternalEnemyHBData _ComputeEnemyHBData(LevelData.EnemyData enemyData, EnemyDatabase.EnemyData levelData, out bool isOverwritten)
		{
			return null;
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006120")]
		[Address(RVA = "0x1DEB150", Offset = "0x1DE9D50", VA = "0x181DEB150")]
		public EnemyDB()
		{
		}

		// Token: 0x04002AAB RID: 10923
		[Token(Token = "0x4002AAB")]
		public const string ENEMYDB_SINGLE_FILE_PATH = "ExternalTools/TorappuEnemyDataBase";

		// Token: 0x04002AAC RID: 10924
		[Token(Token = "0x4002AAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGet;

		// Token: 0x04002AAD RID: 10925
		[Token(Token = "0x4002AAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_TryGet;

		// Token: 0x04002AAE RID: 10926
		[Token(Token = "0x4002AAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEnemyName;

		// Token: 0x04002AAF RID: 10927
		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetHandbookEnemyData;

		// Token: 0x04002AB0 RID: 10928
		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_TryGetHandbookEnemyData;

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ComputeEnemyHBData;

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
