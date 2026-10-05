using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029C3 RID: 10691
	[Token(Token = "0x20029C3")]
	public class VortexMultiHitBehaviour : SelectorHitBehaviour, IEffectSource
	{
		// Token: 0x06011B47 RID: 72519 RVA: 0x0006C6A8 File Offset: 0x0006A8A8
		[Token(Token = "0x6011B47")]
		[Address(RVA = "0x9903C0", Offset = "0x98EFC0", VA = "0x1809903C0")]
		private int RegisterPullRemainingTime()
		{
			return 0;
		}

		// Token: 0x06011B48 RID: 72520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011B48")]
		[Address(RVA = "0x990500", Offset = "0x98F100", VA = "0x180990500")]
		private IEnumerator _DoPull(Enemy target)
		{
			return null;
		}

		// Token: 0x06011B49 RID: 72521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B49")]
		[Address(RVA = "0x9901E0", Offset = "0x98EDE0", VA = "0x1809901E0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011B4A RID: 72522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B4A")]
		[Address(RVA = "0x98FEF0", Offset = "0x98EAF0", VA = "0x18098FEF0", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011B4B RID: 72523 RVA: 0x0006C6C0 File Offset: 0x0006A8C0
		[Token(Token = "0x6011B4B")]
		[Address(RVA = "0x98FC90", Offset = "0x98E890", VA = "0x18098FC90", Slot = "18")]
		protected override bool DealHitTarget(Entity target, bool force)
		{
			return default(bool);
		}

		// Token: 0x06011B4C RID: 72524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B4C")]
		[Address(RVA = "0x9900C0", Offset = "0x98ECC0", VA = "0x1809900C0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011B4D RID: 72525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B4D")]
		[Address(RVA = "0x990010", Offset = "0x98EC10", VA = "0x180990010", Slot = "15")]
		public new void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011B4E RID: 72526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B4E")]
		[Address(RVA = "0x9905D0", Offset = "0x98F1D0", VA = "0x1809905D0")]
		public VortexMultiHitBehaviour()
		{
		}

		// Token: 0x06011B4F RID: 72527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B4F")]
		[Address(RVA = "0x96EFB0", Offset = "0x96DBB0", VA = "0x18096EFB0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011B50 RID: 72528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B50")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x06011B51 RID: 72529 RVA: 0x0006C6D8 File Offset: 0x0006A8D8
		[Token(Token = "0x6011B51")]
		[Address(RVA = "0x9904F0", Offset = "0x98F0F0", VA = "0x1809904F0")]
		private bool <>xLuaBaseProxy_DealHitTarget(Entity P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06011B52 RID: 72530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B52")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x04013D96 RID: 81302
		[Token(Token = "0x4013D96")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Vortex")]
		private float _pullDuration;

		// Token: 0x04013D97 RID: 81303
		[Token(Token = "0x4013D97")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Vortex")]
		private string _castEffect;

		// Token: 0x04013D98 RID: 81304
		[Token(Token = "0x4013D98")]
		[FieldOffset(Offset = "0xB8")]
		private int m_pullForceLevel;

		// Token: 0x04013D99 RID: 81305
		[Token(Token = "0x4013D99")]
		[FieldOffset(Offset = "0xC0")]
		private List<FP> m_pullRemainingTimeList;

		// Token: 0x04013D9A RID: 81306
		[Token(Token = "0x4013D9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterPullRemainingTime;

		// Token: 0x04013D9B RID: 81307
		[Token(Token = "0x4013D9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoPull;

		// Token: 0x04013D9C RID: 81308
		[Token(Token = "0x4013D9C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013D9D RID: 81309
		[Token(Token = "0x4013D9D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013D9E RID: 81310
		[Token(Token = "0x4013D9E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013D9F RID: 81311
		[Token(Token = "0x4013D9F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013DA0 RID: 81312
		[Token(Token = "0x4013DA0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013DA1 RID: 81313
		[Token(Token = "0x4013DA1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
