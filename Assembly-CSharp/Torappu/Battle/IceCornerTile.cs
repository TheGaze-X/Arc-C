using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023A1 RID: 9121
	[Token(Token = "0x20023A1")]
	public class IceCornerTile : BuffTile
	{
		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x0600E760 RID: 59232 RVA: 0x000544B0 File Offset: 0x000526B0
		[Token(Token = "0x17001D0D")]
		private Vector2 orbitCenter
		{
			[Token(Token = "0x600E760")]
			[Address(RVA = "0x5D49F0", Offset = "0x5D35F0", VA = "0x1805D49F0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x0600E761 RID: 59233 RVA: 0x000544C8 File Offset: 0x000526C8
		[Token(Token = "0x17001D0E")]
		private Vector2 tileCenter
		{
			[Token(Token = "0x600E761")]
			[Address(RVA = "0x5D4A80", Offset = "0x5D3680", VA = "0x1805D4A80")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x0600E762 RID: 59234 RVA: 0x000544E0 File Offset: 0x000526E0
		[Token(Token = "0x17001D0F")]
		private Vector2 exitDirectionX
		{
			[Token(Token = "0x600E762")]
			[Address(RVA = "0x5D48B0", Offset = "0x5D34B0", VA = "0x1805D48B0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x0600E763 RID: 59235 RVA: 0x000544F8 File Offset: 0x000526F8
		[Token(Token = "0x17001D10")]
		private Vector2 exitDirectionY
		{
			[Token(Token = "0x600E763")]
			[Address(RVA = "0x5D4950", Offset = "0x5D3550", VA = "0x1805D4950")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600E764 RID: 59236 RVA: 0x00054510 File Offset: 0x00052710
		[Token(Token = "0x600E764")]
		[Address(RVA = "0x5D4160", Offset = "0x5D2D60", VA = "0x1805D4160")]
		private bool _NormalDirectionDamping(Enemy target)
		{
			return default(bool);
		}

		// Token: 0x0600E765 RID: 59237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E765")]
		[Address(RVA = "0x5D2FE0", Offset = "0x5D1BE0", VA = "0x1805D2FE0")]
		private void _AddCentripetalForce(Enemy target)
		{
		}

		// Token: 0x0600E766 RID: 59238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E766")]
		[Address(RVA = "0x5D3400", Offset = "0x5D2000", VA = "0x1805D3400")]
		private void _DoOrbitInternal(Enemy aliveTarget)
		{
		}

		// Token: 0x0600E767 RID: 59239 RVA: 0x00054528 File Offset: 0x00052728
		[Token(Token = "0x600E767")]
		[Address(RVA = "0x5D32D0", Offset = "0x5D1ED0", VA = "0x1805D32D0")]
		private bool _CheckWithinRange(Vector2 targetPos)
		{
			return default(bool);
		}

		// Token: 0x0600E768 RID: 59240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E768")]
		[Address(RVA = "0x5D3630", Offset = "0x5D2230", VA = "0x1805D3630")]
		private void _DoOrbit(object rawTarget)
		{
		}

		// Token: 0x0600E769 RID: 59241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E769")]
		[Address(RVA = "0x5D4730", Offset = "0x5D3330", VA = "0x1805D4730")]
		private void _StopOrbit(Enemy enemy)
		{
		}

		// Token: 0x0600E76A RID: 59242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E76A")]
		[Address(RVA = "0x5D2DD0", Offset = "0x5D19D0", VA = "0x1805D2DD0", Slot = "31")]
		protected override void OnEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E76B RID: 59243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E76B")]
		[Address(RVA = "0x5D2F30", Offset = "0x5D1B30", VA = "0x1805D2F30", Slot = "32")]
		protected override void OnEnemyLeave(Enemy enemy)
		{
		}

		// Token: 0x0600E76C RID: 59244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E76C")]
		[Address(RVA = "0x5D4830", Offset = "0x5D3430", VA = "0x1805D4830")]
		public IceCornerTile()
		{
		}

		// Token: 0x0600E76D RID: 59245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E76D")]
		[Address(RVA = "0x5D2FC0", Offset = "0x5D1BC0", VA = "0x1805D2FC0")]
		private void <>xLuaBaseProxy_OnEnemyEnter(Enemy P0)
		{
		}

		// Token: 0x0600E76E RID: 59246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E76E")]
		[Address(RVA = "0x5D2FD0", Offset = "0x5D1BD0", VA = "0x1805D2FD0")]
		private void <>xLuaBaseProxy_OnEnemyLeave(Enemy P0)
		{
		}

		// Token: 0x0400FED5 RID: 65237
		[Token(Token = "0x400FED5")]
		private const float TILE_WIDTH = 1f;

		// Token: 0x0400FED6 RID: 65238
		[Token(Token = "0x400FED6")]
		private const float DAMPING_MAX_RADIUS = 1f;

		// Token: 0x0400FED7 RID: 65239
		[Token(Token = "0x400FED7")]
		private const float DAMPING_MIN_RADIUS = 0.4f;

		// Token: 0x0400FED8 RID: 65240
		[Token(Token = "0x400FED8")]
		private const float REFLECT_FACTOR = 1f;

		// Token: 0x0400FED9 RID: 65241
		[Token(Token = "0x400FED9")]
		private const float CENTRIPETAL_FORCE_MAX_RADIUS = 0.8f;

		// Token: 0x0400FEDA RID: 65242
		[Token(Token = "0x400FEDA")]
		private const float FRICTION_FACTOR = 0.5f;

		// Token: 0x0400FEDB RID: 65243
		[Token(Token = "0x400FEDB")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Transform _orbitCenter;

		// Token: 0x0400FEDC RID: 65244
		[Token(Token = "0x400FEDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_orbitCenter;

		// Token: 0x0400FEDD RID: 65245
		[Token(Token = "0x400FEDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_tileCenter;

		// Token: 0x0400FEDE RID: 65246
		[Token(Token = "0x400FEDE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_exitDirectionX;

		// Token: 0x0400FEDF RID: 65247
		[Token(Token = "0x400FEDF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_exitDirectionY;

		// Token: 0x0400FEE0 RID: 65248
		[Token(Token = "0x400FEE0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NormalDirectionDamping;

		// Token: 0x0400FEE1 RID: 65249
		[Token(Token = "0x400FEE1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddCentripetalForce;

		// Token: 0x0400FEE2 RID: 65250
		[Token(Token = "0x400FEE2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoOrbitInternal;

		// Token: 0x0400FEE3 RID: 65251
		[Token(Token = "0x400FEE3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckWithinRange;

		// Token: 0x0400FEE4 RID: 65252
		[Token(Token = "0x400FEE4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoOrbit;

		// Token: 0x0400FEE5 RID: 65253
		[Token(Token = "0x400FEE5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StopOrbit;

		// Token: 0x0400FEE6 RID: 65254
		[Token(Token = "0x400FEE6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnemyEnter;

		// Token: 0x0400FEE7 RID: 65255
		[Token(Token = "0x400FEE7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEnemyLeave;

		// Token: 0x0400FEE8 RID: 65256
		[Token(Token = "0x400FEE8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
