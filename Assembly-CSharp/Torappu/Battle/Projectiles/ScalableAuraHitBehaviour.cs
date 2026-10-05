using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029AA RID: 10666
	[Token(Token = "0x20029AA")]
	public class ScalableAuraHitBehaviour : AuraHitBehaviour, IEffectSource
	{
		// Token: 0x06011A91 RID: 72337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A91")]
		[Address(RVA = "0x981D70", Offset = "0x980970", VA = "0x180981D70", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A92 RID: 72338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A92")]
		[Address(RVA = "0x982100", Offset = "0x980D00", VA = "0x180982100", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011A93 RID: 72339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A93")]
		[Address(RVA = "0x982390", Offset = "0x980F90", VA = "0x180982390", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011A94 RID: 72340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A94")]
		[Address(RVA = "0x982620", Offset = "0x981220", VA = "0x180982620", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011A95 RID: 72341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A95")]
		[Address(RVA = "0x982810", Offset = "0x981410", VA = "0x180982810", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A96 RID: 72342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A96")]
		[Address(RVA = "0x981CC0", Offset = "0x9808C0", VA = "0x180981CC0", Slot = "15")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011A97 RID: 72343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A97")]
		[Address(RVA = "0x982B20", Offset = "0x981720", VA = "0x180982B20")]
		public ScalableAuraHitBehaviour()
		{
		}

		// Token: 0x06011A98 RID: 72344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A98")]
		[Address(RVA = "0x982B10", Offset = "0x981710", VA = "0x180982B10")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A99 RID: 72345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A99")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011A9A RID: 72346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A9A")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x06011A9B RID: 72347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A9B")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011A9C RID: 72348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A9C")]
		[Address(RVA = "0x971A70", Offset = "0x970670", VA = "0x180971A70")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013C79 RID: 81017
		[Token(Token = "0x4013C79")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _scalePerSecond;

		// Token: 0x04013C7A RID: 81018
		[Token(Token = "0x4013C7A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x04013C7B RID: 81019
		[Token(Token = "0x4013C7B")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isStoped;

		// Token: 0x04013C7C RID: 81020
		[Token(Token = "0x4013C7C")]
		[FieldOffset(Offset = "0xD8")]
		private FP m_scalePerSecond;

		// Token: 0x04013C7D RID: 81021
		[Token(Token = "0x4013C7D")]
		[FieldOffset(Offset = "0xE0")]
		private FP m_curScale;

		// Token: 0x04013C7E RID: 81022
		[Token(Token = "0x4013C7E")]
		[FieldOffset(Offset = "0xE8")]
		private FP m_startRadius;

		// Token: 0x04013C7F RID: 81023
		[Token(Token = "0x4013C7F")]
		[FieldOffset(Offset = "0xF0")]
		private FP m_moveEndTime;

		// Token: 0x04013C80 RID: 81024
		[Token(Token = "0x4013C80")]
		[FieldOffset(Offset = "0xF8")]
		private CircleRange m_circleRange;

		// Token: 0x04013C81 RID: 81025
		[Token(Token = "0x4013C81")]
		[FieldOffset(Offset = "0x100")]
		private ObjectPtr<Effect> m_effect;

		// Token: 0x04013C82 RID: 81026
		[Token(Token = "0x4013C82")]
		[FieldOffset(Offset = "0x110")]
		private PeriodicTimer m_moveTimer;

		// Token: 0x04013C83 RID: 81027
		[Token(Token = "0x4013C83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C84 RID: 81028
		[Token(Token = "0x4013C84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013C85 RID: 81029
		[Token(Token = "0x4013C85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013C86 RID: 81030
		[Token(Token = "0x4013C86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013C87 RID: 81031
		[Token(Token = "0x4013C87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013C88 RID: 81032
		[Token(Token = "0x4013C88")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013C89 RID: 81033
		[Token(Token = "0x4013C89")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
