using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.DIY;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x020017EF RID: 6127
	[Token(Token = "0x20017EF")]
	public static class FurnitureLODSettingTool
	{
		// Token: 0x06009AB9 RID: 39609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009AB9")]
		[Address(RVA = "0x315EF00", Offset = "0x315DB00", VA = "0x18315EF00")]
		public static List<FurnitureLodObj> GetFurnitureLodObjs(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06009ABA RID: 39610 RVA: 0x0003C168 File Offset: 0x0003A368
		[Token(Token = "0x6009ABA")]
		[Address(RVA = "0x315FD90", Offset = "0x315E990", VA = "0x18315FD90")]
		private static int _GetMeshVertexCount(Mesh mesh)
		{
			return 0;
		}

		// Token: 0x06009ABB RID: 39611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009ABB")]
		[Address(RVA = "0x315F6D0", Offset = "0x315E2D0", VA = "0x18315F6D0")]
		public static List<string> GetFurnitureShowedTrans(FurnitureEntity entity, BuildingData.CustomData.FurnitureData data, List<FurnitureLodObj> lodObjs, List<Transform> transforms, FurnitureLodPreprocessSetting lodSetting)
		{
			return null;
		}
	}
}
