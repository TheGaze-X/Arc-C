using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Building
{
	// Token: 0x02001849 RID: 6217
	[Token(Token = "0x2001849")]
	[CreateAssetMenu(fileName = "building_localdata_db", menuName = "Torappu/DB/Table/BuildingLocalDataTable")]
	[Serializable]
	public class BuildingLocalDataDB : ConstTable<BuildingData.BuildingLocalData, BuildingLocalDataDB>
	{
		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06009D28 RID: 40232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001144")]
		public Dictionary<string, BuildingData.ObstacleData> obstacleTemplates
		{
			[Token(Token = "0x6009D28")]
			[Address(RVA = "0x31767D0", Offset = "0x31753D0", VA = "0x1831767D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06009D29 RID: 40233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001145")]
		public Dictionary<string, BuildingData.ObstacleData> furnitureObstacleData
		{
			[Token(Token = "0x6009D29")]
			[Address(RVA = "0x3176750", Offset = "0x3175350", VA = "0x183176750")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D2A")]
		[Address(RVA = "0x3176510", Offset = "0x3175110", VA = "0x183176510")]
		public BuildingData.ObstacleData GetObstacleDataOrDefault(string obstableId)
		{
			return null;
		}

		// Token: 0x06009D2B RID: 40235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D2B")]
		[Address(RVA = "0x31763C0", Offset = "0x3174FC0", VA = "0x1831763C0")]
		public List<string> GetFurnitureLODShowedNames(string furnitureId, BuildingData.LODLEVEL lodLevel)
		{
			return null;
		}

		// Token: 0x06009D2C RID: 40236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D2C")]
		[Address(RVA = "0x3176290", Offset = "0x3174E90", VA = "0x183176290")]
		public BuildingData.ObstacleData GetFurnirtureObstacleDataOrDefault(string furnitureId)
		{
			return null;
		}

		// Token: 0x06009D2D RID: 40237 RVA: 0x0003D728 File Offset: 0x0003B928
		[Token(Token = "0x6009D2D")]
		[Address(RVA = "0x31765F0", Offset = "0x31751F0", VA = "0x1831765F0")]
		public bool SaveBackToFile()
		{
			return default(bool);
		}

		// Token: 0x06009D2E RID: 40238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D2E")]
		[Address(RVA = "0x3176650", Offset = "0x3175250", VA = "0x183176650")]
		public string SerializeLocalData(bool idented)
		{
			return null;
		}

		// Token: 0x06009D2F RID: 40239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D2F")]
		[Address(RVA = "0x31766E0", Offset = "0x31752E0", VA = "0x1831766E0")]
		public BuildingLocalDataDB()
		{
		}

		// Token: 0x040093EE RID: 37870
		[Token(Token = "0x40093EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_obstacleTemplates;

		// Token: 0x040093EF RID: 37871
		[Token(Token = "0x40093EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_furnitureObstacleData;

		// Token: 0x040093F0 RID: 37872
		[Token(Token = "0x40093F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetObstacleDataOrDefault;

		// Token: 0x040093F1 RID: 37873
		[Token(Token = "0x40093F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetFurnitureLODShowedNames;

		// Token: 0x040093F2 RID: 37874
		[Token(Token = "0x40093F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetFurnirtureObstacleDataOrDefault;

		// Token: 0x040093F3 RID: 37875
		[Token(Token = "0x40093F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SaveBackToFile;

		// Token: 0x040093F4 RID: 37876
		[Token(Token = "0x40093F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SerializeLocalData;

		// Token: 0x040093F5 RID: 37877
		[Token(Token = "0x40093F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
