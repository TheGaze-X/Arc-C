using System;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x0200183E RID: 6206
	[Token(Token = "0x200183E")]
	public static class BuildingUtil
	{
		// Token: 0x06009CF8 RID: 40184 RVA: 0x0003D608 File Offset: 0x0003B808
		[Token(Token = "0x6009CF8")]
		[Address(RVA = "0x7C99C0", Offset = "0x7C85C0", VA = "0x1807C99C0")]
		public static bool CheckAlmostVertical(Vector2 normalizedDir)
		{
			return default(bool);
		}

		// Token: 0x06009CF9 RID: 40185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CF9")]
		[Address(RVA = "0x317BF60", Offset = "0x317AB60", VA = "0x18317BF60")]
		public static void DrawGizmosWireGrids(Vector3 leftBottom, Vector3 leftTop, Vector3 rightBottom, Vector3 rightTop, GridPosition gridSize, Color color)
		{
		}

		// Token: 0x06009CFA RID: 40186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CFA")]
		[Address(RVA = "0x317B8C0", Offset = "0x317A4C0", VA = "0x18317B8C0")]
		public static void DrawGizmosGridMap(Vector3 leftBottom, Vector3 leftTop, Vector3 rightBottom, Vector3 rightTop, GridMap map, Color wireColor, Color obstacleColor)
		{
		}

		// Token: 0x06009CFB RID: 40187 RVA: 0x0003D620 File Offset: 0x0003B820
		[Token(Token = "0x6009CFB")]
		[Address(RVA = "0x317C5D0", Offset = "0x317B1D0", VA = "0x18317C5D0")]
		private static Vector3 _GetWorldPosInBoundingBoxByGridPos(Vector3 leftBottom, Vector3 leftTop, Vector3 rightBottom, Vector3 rightTop, GridPosition gridSize, Vector2 gridPos)
		{
			return default(Vector3);
		}

		// Token: 0x06009CFC RID: 40188 RVA: 0x0003D638 File Offset: 0x0003B838
		[Token(Token = "0x6009CFC")]
		[Address(RVA = "0x317C450", Offset = "0x317B050", VA = "0x18317C450")]
		public static bool TryGetActiveSelectedDIYRoom(RoomSlotModel roomModel, out VDIYRoom vDiyRoom)
		{
			return default(bool);
		}

		// Token: 0x06009CFD RID: 40189 RVA: 0x0003D650 File Offset: 0x0003B850
		[Token(Token = "0x6009CFD")]
		[Address(RVA = "0x317B7D0", Offset = "0x317A3D0", VA = "0x18317B7D0")]
		public static bool CheckIsPrivateOwner(VCharacter vChar)
		{
			return default(bool);
		}

		// Token: 0x040093CE RID: 37838
		[Token(Token = "0x40093CE")]
		private const float ALMOST_VERTICAL_THRESHOLD = 0.992f;
	}
}
