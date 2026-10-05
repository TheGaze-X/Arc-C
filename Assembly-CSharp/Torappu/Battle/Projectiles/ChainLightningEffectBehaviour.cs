using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200298B RID: 10635
	[Token(Token = "0x200298B")]
	public class ChainLightningEffectBehaviour : Projectile.Behaviour, IEffectSource
	{
		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x0601197F RID: 72063 RVA: 0x0006C288 File Offset: 0x0006A488
		[Token(Token = "0x170026E1")]
		protected bool playSpecialEffectOnFirstOne
		{
			[Token(Token = "0x601197F")]
			[Address(RVA = "0x96AA70", Offset = "0x969670", VA = "0x18096AA70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x06011980 RID: 72064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026E2")]
		protected LineRenderer[] lineRenderers
		{
			[Token(Token = "0x6011980")]
			[Address(RVA = "0x96A960", Offset = "0x969560", VA = "0x18096A960")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011981 RID: 72065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011981")]
		[Address(RVA = "0x96A830", Offset = "0x969430", VA = "0x18096A830")]
		private void _ResetLineRenders()
		{
		}

		// Token: 0x06011982 RID: 72066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011982")]
		[Address(RVA = "0x969DB0", Offset = "0x9689B0", VA = "0x180969DB0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011983 RID: 72067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011983")]
		[Address(RVA = "0x969E50", Offset = "0x968A50", VA = "0x180969E50", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011984 RID: 72068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011984")]
		[Address(RVA = "0x96A040", Offset = "0x968C40", VA = "0x18096A040")]
		public void PlayLineEffect(List<ObjectPtr<Entity>> targets)
		{
		}

		// Token: 0x06011985 RID: 72069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011985")]
		[Address(RVA = "0x969D10", Offset = "0x968910", VA = "0x180969D10", Slot = "15")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011986 RID: 72070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011986")]
		[Address(RVA = "0x96A8A0", Offset = "0x9694A0", VA = "0x18096A8A0")]
		public ChainLightningEffectBehaviour()
		{
		}

		// Token: 0x06011987 RID: 72071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011987")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011988 RID: 72072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011988")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013ACB RID: 80587
		[Token(Token = "0x4013ACB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _mainEffect;

		// Token: 0x04013ACC RID: 80588
		[Token(Token = "0x4013ACC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _playSpecialEffectOnFirstOne;

		// Token: 0x04013ACD RID: 80589
		[Token(Token = "0x4013ACD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Inspect("playSpecialEffectOnFirstOne")]
		private string _specialHitEffect;

		// Token: 0x04013ACE RID: 80590
		[Token(Token = "0x4013ACE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _finishMainEffectsBeforePlay;

		// Token: 0x04013ACF RID: 80591
		[Token(Token = "0x4013ACF")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _playEffectOnHitPoint;

		// Token: 0x04013AD0 RID: 80592
		[Token(Token = "0x4013AD0")]
		[FieldOffset(Offset = "0x42")]
		[SerializeField]
		private bool _setMeAsParent;

		// Token: 0x04013AD1 RID: 80593
		[Token(Token = "0x4013AD1")]
		[FieldOffset(Offset = "0x48")]
		private ObjectPtr<Effect> m_mainEffect;

		// Token: 0x04013AD2 RID: 80594
		[Token(Token = "0x4013AD2")]
		[FieldOffset(Offset = "0x58")]
		private ObjectPtr<Effect> m_hitEffect;

		// Token: 0x04013AD3 RID: 80595
		[Token(Token = "0x4013AD3")]
		[FieldOffset(Offset = "0x68")]
		private LineRenderer[] m_lineRenderers;

		// Token: 0x04013AD4 RID: 80596
		[Token(Token = "0x4013AD4")]
		[FieldOffset(Offset = "0x70")]
		private List<Vector3> m_positions;

		// Token: 0x04013AD5 RID: 80597
		[Token(Token = "0x4013AD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_playSpecialEffectOnFirstOne;

		// Token: 0x04013AD6 RID: 80598
		[Token(Token = "0x4013AD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lineRenderers;

		// Token: 0x04013AD7 RID: 80599
		[Token(Token = "0x4013AD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetLineRenders;

		// Token: 0x04013AD8 RID: 80600
		[Token(Token = "0x4013AD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013AD9 RID: 80601
		[Token(Token = "0x4013AD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013ADA RID: 80602
		[Token(Token = "0x4013ADA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayLineEffect;

		// Token: 0x04013ADB RID: 80603
		[Token(Token = "0x4013ADB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013ADC RID: 80604
		[Token(Token = "0x4013ADC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
