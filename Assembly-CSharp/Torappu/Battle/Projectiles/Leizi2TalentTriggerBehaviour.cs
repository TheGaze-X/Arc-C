using System;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200299C RID: 10652
	[Token(Token = "0x200299C")]
	public class Leizi2TalentTriggerBehaviour : Projectile.Behaviour
	{
		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x06011A25 RID: 72229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026E9")]
		private Leizi2Talent1Ability talentAbility
		{
			[Token(Token = "0x6011A25")]
			[Address(RVA = "0x978190", Offset = "0x976D90", VA = "0x180978190")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011A26 RID: 72230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A26")]
		[Address(RVA = "0x977B90", Offset = "0x976790", VA = "0x180977B90", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile initProjectile)
		{
		}

		// Token: 0x06011A27 RID: 72231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A27")]
		[Address(RVA = "0x977C40", Offset = "0x976840", VA = "0x180977C40", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011A28 RID: 72232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A28")]
		[Address(RVA = "0x977D50", Offset = "0x976950", VA = "0x180977D50", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011A29 RID: 72233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A29")]
		[Address(RVA = "0x977DD0", Offset = "0x9769D0", VA = "0x180977DD0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A2A RID: 72234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A2A")]
		[Address(RVA = "0x978120", Offset = "0x976D20", VA = "0x180978120")]
		public Leizi2TalentTriggerBehaviour()
		{
		}

		// Token: 0x06011A2B RID: 72235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A2B")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A2C RID: 72236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A2C")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011A2D RID: 72237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A2D")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011A2E RID: 72238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A2E")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013BE3 RID: 80867
		[Token(Token = "0x4013BE3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _interval;

		// Token: 0x04013BE4 RID: 80868
		[Token(Token = "0x4013BE4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _abilityName;

		// Token: 0x04013BE5 RID: 80869
		[Token(Token = "0x4013BE5")]
		[FieldOffset(Offset = "0x38")]
		private PeriodicTimer m_intervalTicker;

		// Token: 0x04013BE6 RID: 80870
		[Token(Token = "0x4013BE6")]
		[FieldOffset(Offset = "0x40")]
		private float m_interval;

		// Token: 0x04013BE7 RID: 80871
		[Token(Token = "0x4013BE7")]
		[FieldOffset(Offset = "0x48")]
		private Leizi2Talent1Ability m_talentAbility;

		// Token: 0x04013BE8 RID: 80872
		[Token(Token = "0x4013BE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_talentAbility;

		// Token: 0x04013BE9 RID: 80873
		[Token(Token = "0x4013BE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013BEA RID: 80874
		[Token(Token = "0x4013BEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013BEB RID: 80875
		[Token(Token = "0x4013BEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013BEC RID: 80876
		[Token(Token = "0x4013BEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013BED RID: 80877
		[Token(Token = "0x4013BED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
