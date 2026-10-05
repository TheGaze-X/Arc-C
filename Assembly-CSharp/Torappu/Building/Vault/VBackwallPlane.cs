using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A3C RID: 6716
	[Token(Token = "0x2001A3C")]
	public class VBackwallPlane : VGridPlane
	{
		// Token: 0x0600A868 RID: 43112 RVA: 0x00041370 File Offset: 0x0003F570
		[Token(Token = "0x600A868")]
		[Address(RVA = "0x323A920", Offset = "0x3239520", VA = "0x18323A920", Slot = "4")]
		public override Bounds GetLocalBounds3D(float thickness)
		{
			return default(Bounds);
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x00041388 File Offset: 0x0003F588
		[Token(Token = "0x600A869")]
		[Address(RVA = "0x323A780", Offset = "0x3239380", VA = "0x18323A780", Slot = "5")]
		public override Bounds GetLocalBounds3D(GridPosition gridPos, float thickness)
		{
			return default(Bounds);
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x000413A0 File Offset: 0x0003F5A0
		[Token(Token = "0x600A86A")]
		[Address(RVA = "0x323AAB0", Offset = "0x32396B0", VA = "0x18323AAB0", Slot = "8")]
		protected override Vector2 LocalPosToGridPos(Vector3 localPos)
		{
			return default(Vector2);
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x000413B8 File Offset: 0x0003F5B8
		[Token(Token = "0x600A86B")]
		[Address(RVA = "0x323AA40", Offset = "0x3239640", VA = "0x18323AA40", Slot = "9")]
		protected override Vector3 GridPosToLocalPos(Vector2 gridPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600A86C RID: 43116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A86C")]
		[Address(RVA = "0x323A480", Offset = "0x3239080", VA = "0x18323A480", Slot = "6")]
		protected override GridMap CreateGridMap(VGridPlane.Options options)
		{
			return null;
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A86D")]
		[Address(RVA = "0x323AB90", Offset = "0x3239790", VA = "0x18323AB90", Slot = "7")]
		protected override void ResetLocation(float depth, Rect area)
		{
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A86E")]
		[Address(RVA = "0x323AB60", Offset = "0x3239760", VA = "0x18323AB60", Slot = "10")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A86F RID: 43119 RVA: 0x000413D0 File Offset: 0x0003F5D0
		[Token(Token = "0x600A86F")]
		[Address(RVA = "0x323AC60", Offset = "0x3239860", VA = "0x18323AC60")]
		private bool _ShouldEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600A870 RID: 43120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A870")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public VBackwallPlane()
		{
		}

		// Token: 0x0400A0AB RID: 41131
		[Token(Token = "0x400A0AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingData.ObstacleRect[] _obstacleRects;
	}
}
