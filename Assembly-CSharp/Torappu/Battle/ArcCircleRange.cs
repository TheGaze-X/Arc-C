using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C1 RID: 9409
	[Token(Token = "0x20024C1")]
	[RequireComponent(typeof(CircleCollider2D))]
	public class ArcCircleRange : PhysicsRange
	{
		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x0600F214 RID: 61972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F84")]
		public Vector2[] degreeRanges
		{
			[Token(Token = "0x600F214")]
			[Address(RVA = "0x682E90", Offset = "0x681A90", VA = "0x180682E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F215 RID: 61973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F215")]
		[Address(RVA = "0x682430", Offset = "0x681030", VA = "0x180682430", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F216 RID: 61974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F216")]
		[Address(RVA = "0x682960", Offset = "0x681560", VA = "0x180682960", Slot = "18")]
		protected override void InitCollidersIfNot(Range.Options options)
		{
		}

		// Token: 0x0600F217 RID: 61975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F217")]
		[Address(RVA = "0x682060", Offset = "0x680C60", VA = "0x180682060", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F218 RID: 61976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F218")]
		[Address(RVA = "0x6825D0", Offset = "0x6811D0", VA = "0x1806825D0", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F219 RID: 61977 RVA: 0x000592B0 File Offset: 0x000574B0
		[Token(Token = "0x600F219")]
		[Address(RVA = "0x682CA0", Offset = "0x6818A0", VA = "0x180682CA0")]
		private bool _CheckDegRangeValid()
		{
			return default(bool);
		}

		// Token: 0x0600F21A RID: 61978 RVA: 0x000592C8 File Offset: 0x000574C8
		[Token(Token = "0x600F21A")]
		[Address(RVA = "0x682B30", Offset = "0x681730", VA = "0x180682B30")]
		private bool _CheckDegInRange(float angle)
		{
			return default(bool);
		}

		// Token: 0x0600F21B RID: 61979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F21B")]
		[Address(RVA = "0x682E00", Offset = "0x681A00", VA = "0x180682E00")]
		public ArcCircleRange()
		{
		}

		// Token: 0x0600F21C RID: 61980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F21C")]
		[Address(RVA = "0x682AA0", Offset = "0x6816A0", VA = "0x180682AA0")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x0600F21D RID: 61981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F21D")]
		[Address(RVA = "0x682AF0", Offset = "0x6816F0", VA = "0x180682AF0")]
		private void <>xLuaBaseProxy_InitCollidersIfNot(Range.Options P0)
		{
		}

		// Token: 0x0600F21E RID: 61982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F21E")]
		[Address(RVA = "0x682A40", Offset = "0x681640", VA = "0x180682A40")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0, TargetOptions P1, Func<Entity, bool> P2)
		{
			return null;
		}

		// Token: 0x0600F21F RID: 61983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F21F")]
		[Address(RVA = "0x682AE0", Offset = "0x6816E0", VA = "0x180682AE0")]
		private List<Tile> <>xLuaBaseProxy_FindTiles(Vector2 P0, Func<Tile, bool> P1)
		{
			return null;
		}

		// Token: 0x04010C01 RID: 68609
		[Token(Token = "0x4010C01")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("x: min angle in degrees, y: max angle in degrees, Notice the forward face is 90 deg.")]
		private Vector2[] _degreeRanges;

		// Token: 0x04010C02 RID: 68610
		[Token(Token = "0x4010C02")]
		[FieldOffset(Offset = "0x58")]
		private CircleCollider2D m_circleCollider;

		// Token: 0x04010C03 RID: 68611
		[Token(Token = "0x4010C03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_degreeRanges;

		// Token: 0x04010C04 RID: 68612
		[Token(Token = "0x4010C04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010C05 RID: 68613
		[Token(Token = "0x4010C05")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitCollidersIfNot;

		// Token: 0x04010C06 RID: 68614
		[Token(Token = "0x4010C06")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010C07 RID: 68615
		[Token(Token = "0x4010C07")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010C08 RID: 68616
		[Token(Token = "0x4010C08")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckDegRangeValid;

		// Token: 0x04010C09 RID: 68617
		[Token(Token = "0x4010C09")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckDegInRange;

		// Token: 0x04010C0A RID: 68618
		[Token(Token = "0x4010C0A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
