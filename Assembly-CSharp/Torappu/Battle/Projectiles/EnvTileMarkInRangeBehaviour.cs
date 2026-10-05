using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002993 RID: 10643
	[Token(Token = "0x2002993")]
	public class EnvTileMarkInRangeBehaviour : Projectile.Behaviour
	{
		// Token: 0x060119D3 RID: 72147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D3")]
		[Address(RVA = "0x970F00", Offset = "0x96FB00", VA = "0x180970F00", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x060119D4 RID: 72148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D4")]
		[Address(RVA = "0x9710B0", Offset = "0x96FCB0", VA = "0x1809710B0", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x060119D5 RID: 72149 RVA: 0x0006C3A8 File Offset: 0x0006A5A8
		[Token(Token = "0x60119D5")]
		[Address(RVA = "0x971410", Offset = "0x970010", VA = "0x180971410")]
		private bool ValidateTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060119D6 RID: 72150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D6")]
		[Address(RVA = "0x971480", Offset = "0x970080", VA = "0x180971480")]
		public EnvTileMarkInRangeBehaviour()
		{
		}

		// Token: 0x060119D7 RID: 72151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D7")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119D8 RID: 72152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D8")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x04013B60 RID: 80736
		[Token(Token = "0x4013B60")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("We use |Range| only to initialize the colliders.")]
		private Range _rangeToLoad;

		// Token: 0x04013B61 RID: 80737
		[Token(Token = "0x4013B61")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _rangeId;

		// Token: 0x04013B62 RID: 80738
		[Token(Token = "0x4013B62")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _valueToMark;

		// Token: 0x04013B63 RID: 80739
		[Token(Token = "0x4013B63")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _timeBlackboardKey;

		// Token: 0x04013B64 RID: 80740
		[Token(Token = "0x4013B64")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _envSystemKey;

		// Token: 0x04013B65 RID: 80741
		[Token(Token = "0x4013B65")]
		[FieldOffset(Offset = "0x50")]
		private bool m_initedRange;

		// Token: 0x04013B66 RID: 80742
		[Token(Token = "0x4013B66")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013B67 RID: 80743
		[Token(Token = "0x4013B67")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013B68 RID: 80744
		[Token(Token = "0x4013B68")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ValidateTile;

		// Token: 0x04013B69 RID: 80745
		[Token(Token = "0x4013B69")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
