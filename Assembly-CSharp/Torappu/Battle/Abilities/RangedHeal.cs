using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AD8 RID: 10968
	[Token(Token = "0x2002AD8")]
	public class RangedHeal : Heal
	{
		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x06012481 RID: 74881 RVA: 0x00070020 File Offset: 0x0006E220
		[Token(Token = "0x1700281A")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012481")]
			[Address(RVA = "0xA5C220", Offset = "0xA5AE20", VA = "0x180A5C220", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012482 RID: 74882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012482")]
		[Address(RVA = "0xA5BF40", Offset = "0xA5AB40", VA = "0x180A5BF40", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012483 RID: 74883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012483")]
		[Address(RVA = "0xA5BC20", Offset = "0xA5A820", VA = "0x180A5BC20", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012484 RID: 74884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012484")]
		[Address(RVA = "0xA5BD60", Offset = "0xA5A960", VA = "0x180A5BD60", Slot = "108")]
		protected override Nodes.ApplyHeal NewHealNode(FP healScale)
		{
			return null;
		}

		// Token: 0x06012485 RID: 74885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012485")]
		[Address(RVA = "0xA5BC90", Offset = "0xA5A890", VA = "0x180A5BC90", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012486 RID: 74886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012486")]
		[Address(RVA = "0xA5BB60", Offset = "0xA5A760", VA = "0x180A5BB60", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x06012487 RID: 74887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012487")]
		[Address(RVA = "0xA54520", Offset = "0xA53120", VA = "0x180A54520", Slot = "110")]
		protected virtual string GetProjectileKey()
		{
			return null;
		}

		// Token: 0x06012488 RID: 74888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012488")]
		[Address(RVA = "0xA5C1B0", Offset = "0xA5ADB0", VA = "0x180A5C1B0")]
		public RangedHeal()
		{
		}

		// Token: 0x06012489 RID: 74889 RVA: 0x00070038 File Offset: 0x0006E238
		[Token(Token = "0x6012489")]
		[Address(RVA = "0xA5C1A0", Offset = "0xA5ADA0", VA = "0x180A5C1A0")]
		private bool <>xLuaBaseProxy_get_alwaysIncludeTarget()
		{
			return default(bool);
		}

		// Token: 0x0601248A RID: 74890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601248A")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x0601248B RID: 74891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601248B")]
		[Address(RVA = "0xA5C110", Offset = "0xA5AD10", VA = "0x180A5C110")]
		private IList<ActionNode> <>xLuaBaseProxy_GetEventActions(AbilityStandard.Event P0)
		{
			return null;
		}

		// Token: 0x0601248C RID: 74892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601248C")]
		[Address(RVA = "0xA5C190", Offset = "0xA5AD90", VA = "0x180A5C190")]
		private Nodes.ApplyHeal <>xLuaBaseProxy_NewHealNode(FP P0)
		{
			return null;
		}

		// Token: 0x0601248D RID: 74893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601248D")]
		[Address(RVA = "0xA55080", Offset = "0xA53C80", VA = "0x180A55080")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x0601248E RID: 74894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601248E")]
		[Address(RVA = "0xA4B080", Offset = "0xA49C80", VA = "0x180A4B080")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x04014ABF RID: 84671
		[Token(Token = "0x4014ABF")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x04014AC0 RID: 84672
		[Token(Token = "0x4014AC0")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private bool _useCachedAtkOnly;

		// Token: 0x04014AC1 RID: 84673
		[Token(Token = "0x4014AC1")]
		[FieldOffset(Offset = "0x204")]
		[SerializeField]
		private Entity.MountPointType _mountPointType;

		// Token: 0x04014AC2 RID: 84674
		[Token(Token = "0x4014AC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014AC3 RID: 84675
		[Token(Token = "0x4014AC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014AC4 RID: 84676
		[Token(Token = "0x4014AC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014AC5 RID: 84677
		[Token(Token = "0x4014AC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NewHealNode;

		// Token: 0x04014AC6 RID: 84678
		[Token(Token = "0x4014AC6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014AC7 RID: 84679
		[Token(Token = "0x4014AC7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04014AC8 RID: 84680
		[Token(Token = "0x4014AC8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetProjectileKey;

		// Token: 0x04014AC9 RID: 84681
		[Token(Token = "0x4014AC9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
