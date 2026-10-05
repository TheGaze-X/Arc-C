using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029AE RID: 10670
	[Token(Token = "0x20029AE")]
	public class SelectorForScanHitBehaviour : Projectile.Behaviour
	{
		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x06011AAF RID: 72367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026F2")]
		protected TargetSelector selector
		{
			[Token(Token = "0x6011AAF")]
			[Address(RVA = "0x9845F0", Offset = "0x9831F0", VA = "0x1809845F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011AB0 RID: 72368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AB0")]
		[Address(RVA = "0x984070", Offset = "0x982C70", VA = "0x180984070", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011AB1 RID: 72369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AB1")]
		[Address(RVA = "0x984300", Offset = "0x982F00", VA = "0x180984300", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011AB2 RID: 72370 RVA: 0x0006C528 File Offset: 0x0006A728
		[Token(Token = "0x6011AB2")]
		[Address(RVA = "0x984450", Offset = "0x983050", VA = "0x180984450")]
		private bool _DealHitTarget(Entity target, bool force)
		{
			return default(bool);
		}

		// Token: 0x06011AB3 RID: 72371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AB3")]
		[Address(RVA = "0x983DE0", Offset = "0x9829E0", VA = "0x180983DE0", Slot = "15")]
		protected virtual void DoSelectTarget(Vector2 inputPos)
		{
		}

		// Token: 0x06011AB4 RID: 72372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AB4")]
		[Address(RVA = "0x984500", Offset = "0x983100", VA = "0x180984500")]
		public SelectorForScanHitBehaviour()
		{
		}

		// Token: 0x06011AB5 RID: 72373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AB5")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011AB6 RID: 72374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AB6")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013CB1 RID: 81073
		[Token(Token = "0x4013CB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TargetSelector _scanSelector;

		// Token: 0x04013CB2 RID: 81074
		[Token(Token = "0x4013CB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _interval;

		// Token: 0x04013CB3 RID: 81075
		[Token(Token = "0x4013CB3")]
		[FieldOffset(Offset = "0x34")]
		private int m_maxHitNum;

		// Token: 0x04013CB4 RID: 81076
		[Token(Token = "0x4013CB4")]
		[FieldOffset(Offset = "0x38")]
		private PeriodicTimer m_periodicTimer;

		// Token: 0x04013CB5 RID: 81077
		[Token(Token = "0x4013CB5")]
		[FieldOffset(Offset = "0x40")]
		private List<ObjectPtr<Entity>> m_targetsList;

		// Token: 0x04013CB6 RID: 81078
		[Token(Token = "0x4013CB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selector;

		// Token: 0x04013CB7 RID: 81079
		[Token(Token = "0x4013CB7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013CB8 RID: 81080
		[Token(Token = "0x4013CB8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013CB9 RID: 81081
		[Token(Token = "0x4013CB9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DealHitTarget;

		// Token: 0x04013CBA RID: 81082
		[Token(Token = "0x4013CBA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoSelectTarget;

		// Token: 0x04013CBB RID: 81083
		[Token(Token = "0x4013CBB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
