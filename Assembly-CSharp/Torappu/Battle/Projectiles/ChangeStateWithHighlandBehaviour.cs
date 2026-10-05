using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200298E RID: 10638
	[Token(Token = "0x200298E")]
	public class ChangeStateWithHighlandBehaviour : Projectile.Behaviour
	{
		// Token: 0x0601199B RID: 72091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601199B")]
		[Address(RVA = "0x96C130", Offset = "0x96AD30", VA = "0x18096C130", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x0601199C RID: 72092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601199C")]
		[Address(RVA = "0x96C200", Offset = "0x96AE00", VA = "0x18096C200", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601199D RID: 72093 RVA: 0x0006C2D0 File Offset: 0x0006A4D0
		[Token(Token = "0x601199D")]
		[Address(RVA = "0x96C8D0", Offset = "0x96B4D0", VA = "0x18096C8D0")]
		private bool _CheckHit()
		{
			return default(bool);
		}

		// Token: 0x0601199E RID: 72094 RVA: 0x0006C2E8 File Offset: 0x0006A4E8
		[Token(Token = "0x601199E")]
		[Address(RVA = "0x96CC90", Offset = "0x96B890", VA = "0x18096CC90")]
		private float _GetDistanceToNextTile(Vector2 mapPosition, Vector2 direction)
		{
			return 0f;
		}

		// Token: 0x0601199F RID: 72095 RVA: 0x0006C300 File Offset: 0x0006A500
		[Token(Token = "0x601199F")]
		[Address(RVA = "0x96CB80", Offset = "0x96B780", VA = "0x18096CB80")]
		private bool _CheckNextTileHighland(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060119A0 RID: 72096 RVA: 0x0006C318 File Offset: 0x0006A518
		[Token(Token = "0x60119A0")]
		[Address(RVA = "0x96CC10", Offset = "0x96B810", VA = "0x18096CC10")]
		private bool _CheckNextTileStartType(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060119A1 RID: 72097 RVA: 0x0006C330 File Offset: 0x0006A530
		[Token(Token = "0x60119A1")]
		[Address(RVA = "0x96CB00", Offset = "0x96B700", VA = "0x18096CB00")]
		private bool _CheckNextTileEndType(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060119A2 RID: 72098 RVA: 0x0006C348 File Offset: 0x0006A548
		[Token(Token = "0x60119A2")]
		[Address(RVA = "0x96C610", Offset = "0x96B210", VA = "0x18096C610")]
		private bool _CheckHitConditions(Vector2 nextGrid)
		{
			return default(bool);
		}

		// Token: 0x060119A3 RID: 72099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119A3")]
		[Address(RVA = "0x96C2C0", Offset = "0x96AEC0", VA = "0x18096C2C0")]
		private void _ChangeDirection()
		{
		}

		// Token: 0x060119A4 RID: 72100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119A4")]
		[Address(RVA = "0x96CEF0", Offset = "0x96BAF0", VA = "0x18096CEF0")]
		public ChangeStateWithHighlandBehaviour()
		{
		}

		// Token: 0x060119A5 RID: 72101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119A5")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119A6 RID: 72102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119A6")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013AF9 RID: 80633
		[Token(Token = "0x4013AF9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _changeDirectionWhenHit;

		// Token: 0x04013AFA RID: 80634
		[Token(Token = "0x4013AFA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _hitDistance;

		// Token: 0x04013AFB RID: 80635
		[Token(Token = "0x4013AFB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _hitEps;

		// Token: 0x04013AFC RID: 80636
		[Token(Token = "0x4013AFC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _clearTargetsAlreadyHitListWhenHit;

		// Token: 0x04013AFD RID: 80637
		[Token(Token = "0x4013AFD")]
		[FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _checkHitHighland;

		// Token: 0x04013AFE RID: 80638
		[Token(Token = "0x4013AFE")]
		[FieldOffset(Offset = "0x36")]
		[SerializeField]
		private bool _checkHitMapEdge;

		// Token: 0x04013AFF RID: 80639
		[Token(Token = "0x4013AFF")]
		[FieldOffset(Offset = "0x37")]
		[SerializeField]
		private bool _checkTileEnd;

		// Token: 0x04013B00 RID: 80640
		[Token(Token = "0x4013B00")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _checkTileStart;

		// Token: 0x04013B01 RID: 80641
		[Token(Token = "0x4013B01")]
		[FieldOffset(Offset = "0x40")]
		private BasicMovement m_movement;

		// Token: 0x04013B02 RID: 80642
		[Token(Token = "0x4013B02")]
		private const float MAX_DISTANCE_VALUE = 100000f;

		// Token: 0x04013B03 RID: 80643
		[Token(Token = "0x4013B03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013B04 RID: 80644
		[Token(Token = "0x4013B04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013B05 RID: 80645
		[Token(Token = "0x4013B05")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckHit;

		// Token: 0x04013B06 RID: 80646
		[Token(Token = "0x4013B06")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDistanceToNextTile;

		// Token: 0x04013B07 RID: 80647
		[Token(Token = "0x4013B07")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckNextTileHighland;

		// Token: 0x04013B08 RID: 80648
		[Token(Token = "0x4013B08")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckNextTileStartType;

		// Token: 0x04013B09 RID: 80649
		[Token(Token = "0x4013B09")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckNextTileEndType;

		// Token: 0x04013B0A RID: 80650
		[Token(Token = "0x4013B0A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckHitConditions;

		// Token: 0x04013B0B RID: 80651
		[Token(Token = "0x4013B0B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ChangeDirection;

		// Token: 0x04013B0C RID: 80652
		[Token(Token = "0x4013B0C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
