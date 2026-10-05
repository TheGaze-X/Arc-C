using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A3D RID: 6717
	[Token(Token = "0x2001A3D")]
	public class VFloorPlane : VGridPlane
	{
		// Token: 0x0600A871 RID: 43121 RVA: 0x000413E8 File Offset: 0x0003F5E8
		[Token(Token = "0x600A871")]
		[Address(RVA = "0x3240FA0", Offset = "0x323FBA0", VA = "0x183240FA0", Slot = "4")]
		public override Bounds GetLocalBounds3D(float thickness)
		{
			return default(Bounds);
		}

		// Token: 0x0600A872 RID: 43122 RVA: 0x00041400 File Offset: 0x0003F600
		[Token(Token = "0x600A872")]
		[Address(RVA = "0x32410B0", Offset = "0x323FCB0", VA = "0x1832410B0", Slot = "5")]
		public override Bounds GetLocalBounds3D(GridPosition gridPos, float thickness)
		{
			return default(Bounds);
		}

		// Token: 0x0600A873 RID: 43123 RVA: 0x00041418 File Offset: 0x0003F618
		[Token(Token = "0x600A873")]
		[Address(RVA = "0x32412E0", Offset = "0x323FEE0", VA = "0x1832412E0", Slot = "8")]
		protected override Vector2 LocalPosToGridPos(Vector3 localPos)
		{
			return default(Vector2);
		}

		// Token: 0x0600A874 RID: 43124 RVA: 0x00041430 File Offset: 0x0003F630
		[Token(Token = "0x600A874")]
		[Address(RVA = "0x3241250", Offset = "0x323FE50", VA = "0x183241250", Slot = "9")]
		protected override Vector3 GridPosToLocalPos(Vector2 gridPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600A875 RID: 43125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A875")]
		[Address(RVA = "0x3240D20", Offset = "0x323F920", VA = "0x183240D20", Slot = "6")]
		protected override GridMap CreateGridMap(VGridPlane.Options options)
		{
			return null;
		}

		// Token: 0x0600A876 RID: 43126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A876")]
		[Address(RVA = "0x3241390", Offset = "0x323FF90", VA = "0x183241390", Slot = "7")]
		protected override void ResetLocation(float altitute, Rect area)
		{
		}

		// Token: 0x0600A877 RID: 43127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A877")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public VFloorPlane()
		{
		}

		// Token: 0x0400A0AC RID: 41132
		[Token(Token = "0x400A0AC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public BuildingData.ObstacleRect[] _obstacleRects;
	}
}
