using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002997 RID: 10647
	[Token(Token = "0x2002997")]
	public class GdglowHitBehaviour : MultiFunnelHitBehaviour
	{
		// Token: 0x060119EC RID: 72172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119EC")]
		[Address(RVA = "0x972CA0", Offset = "0x9718A0", VA = "0x180972CA0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x060119ED RID: 72173 RVA: 0x0006C3D8 File Offset: 0x0006A5D8
		[Token(Token = "0x60119ED")]
		[Address(RVA = "0x972640", Offset = "0x971240", VA = "0x180972640", Slot = "15")]
		protected override bool DealHitTarget()
		{
			return default(bool);
		}

		// Token: 0x060119EE RID: 72174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119EE")]
		[Address(RVA = "0x972F80", Offset = "0x971B80", VA = "0x180972F80", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x060119EF RID: 72175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119EF")]
		[Address(RVA = "0x972970", Offset = "0x971570", VA = "0x180972970")]
		private void EmitProjectile(Entity entity)
		{
		}

		// Token: 0x060119F0 RID: 72176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119F0")]
		[Address(RVA = "0x973220", Offset = "0x971E20", VA = "0x180973220")]
		public GdglowHitBehaviour()
		{
		}

		// Token: 0x060119F1 RID: 72177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119F1")]
		[Address(RVA = "0x973210", Offset = "0x971E10", VA = "0x180973210")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119F2 RID: 72178 RVA: 0x0006C3F0 File Offset: 0x0006A5F0
		[Token(Token = "0x60119F2")]
		[Address(RVA = "0x973060", Offset = "0x971C60", VA = "0x180973060")]
		private bool <>xLuaBaseProxy_DealHitTarget()
		{
			return default(bool);
		}

		// Token: 0x060119F3 RID: 72179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119F3")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x04013B7C RID: 80764
		[Token(Token = "0x4013B7C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private int _startIndex;

		// Token: 0x04013B7D RID: 80765
		[Token(Token = "0x4013B7D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string[] _projectileKeys;

		// Token: 0x04013B7E RID: 80766
		[Token(Token = "0x4013B7E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x04013B7F RID: 80767
		[Token(Token = "0x4013B7F")]
		[FieldOffset(Offset = "0xC0")]
		[ReadOnly]
		[Inspect]
		private float m_prob;

		// Token: 0x04013B80 RID: 80768
		[Token(Token = "0x4013B80")]
		[FieldOffset(Offset = "0xC4")]
		[ReadOnly]
		[Inspect]
		private int m_prdMaxMultiplier;

		// Token: 0x04013B81 RID: 80769
		[Token(Token = "0x4013B81")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_useHookProjectile;

		// Token: 0x04013B82 RID: 80770
		[Token(Token = "0x4013B82")]
		[FieldOffset(Offset = "0xCC")]
		private int m_projectileKeyIndex;

		// Token: 0x04013B83 RID: 80771
		[Token(Token = "0x4013B83")]
		[FieldOffset(Offset = "0xD0")]
		private readonly List<string> m_logicProjectileKeys;

		// Token: 0x04013B84 RID: 80772
		[Token(Token = "0x4013B84")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<string> m_graphicProjectileKeys;

		// Token: 0x04013B85 RID: 80773
		[Token(Token = "0x4013B85")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<ActionNode> m_damageNodeReplacedActionNodes;

		// Token: 0x04013B86 RID: 80774
		[Token(Token = "0x4013B86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013B87 RID: 80775
		[Token(Token = "0x4013B87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013B88 RID: 80776
		[Token(Token = "0x4013B88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013B89 RID: 80777
		[Token(Token = "0x4013B89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EmitProjectile;

		// Token: 0x04013B8A RID: 80778
		[Token(Token = "0x4013B8A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
