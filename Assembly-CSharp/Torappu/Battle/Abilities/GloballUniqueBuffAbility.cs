using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B42 RID: 11074
	[Token(Token = "0x2002B42")]
	public class GloballUniqueBuffAbility : AbstractAnimatedAbility, IBuffSource
	{
		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0601294B RID: 76107 RVA: 0x00071CD0 File Offset: 0x0006FED0
		[Token(Token = "0x170028F4")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x601294B")]
			[Address(RVA = "0xA89910", Offset = "0xA88510", VA = "0x180A89910", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x0601294C RID: 76108 RVA: 0x00071CE8 File Offset: 0x0006FEE8
		[Token(Token = "0x170028F5")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x601294C")]
			[Address(RVA = "0xA898B0", Offset = "0xA884B0", VA = "0x180A898B0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601294D RID: 76109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601294D")]
		[Address(RVA = "0xA88C50", Offset = "0xA87850", VA = "0x180A88C50", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0601294E RID: 76110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601294E")]
		[Address(RVA = "0xA88D20", Offset = "0xA87920", VA = "0x180A88D20", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601294F RID: 76111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601294F")]
		[Address(RVA = "0xA88CC0", Offset = "0xA878C0", VA = "0x180A88CC0", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012950 RID: 76112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012950")]
		[Address(RVA = "0xA88BF0", Offset = "0xA877F0", VA = "0x180A88BF0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012951 RID: 76113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012951")]
		[Address(RVA = "0xA88B40", Offset = "0xA87740", VA = "0x180A88B40", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012952 RID: 76114 RVA: 0x00071D00 File Offset: 0x0006FF00
		[Token(Token = "0x6012952")]
		[Address(RVA = "0xA88EA0", Offset = "0xA87AA0", VA = "0x180A88EA0", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012953 RID: 76115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012953")]
		[Address(RVA = "0xA88FB0", Offset = "0xA87BB0", VA = "0x180A88FB0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012954 RID: 76116 RVA: 0x00071D18 File Offset: 0x0006FF18
		[Token(Token = "0x6012954")]
		[Address(RVA = "0xA88DB0", Offset = "0xA879B0", VA = "0x180A88DB0", Slot = "35")]
		public override bool InterruptIfNot()
		{
			return default(bool);
		}

		// Token: 0x06012955 RID: 76117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012955")]
		[Address(RVA = "0xA88E30", Offset = "0xA87A30", VA = "0x180A88E30", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012956 RID: 76118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012956")]
		[Address(RVA = "0xA88F20", Offset = "0xA87B20", VA = "0x180A88F20", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012957 RID: 76119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012957")]
		[Address(RVA = "0xA893B0", Offset = "0xA87FB0", VA = "0x180A893B0")]
		private void _DoUpdateTarget()
		{
		}

		// Token: 0x06012958 RID: 76120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012958")]
		[Address(RVA = "0xA89080", Offset = "0xA87C80", VA = "0x180A89080")]
		private void _DoAddBuff(Entity target)
		{
		}

		// Token: 0x06012959 RID: 76121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012959")]
		[Address(RVA = "0xA891D0", Offset = "0xA87DD0", VA = "0x180A891D0")]
		private void _DoRemoveBuff()
		{
		}

		// Token: 0x0601295A RID: 76122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601295A")]
		[Address(RVA = "0xA89850", Offset = "0xA88450", VA = "0x180A89850")]
		public GloballUniqueBuffAbility()
		{
		}

		// Token: 0x0601295B RID: 76123 RVA: 0x00071D30 File Offset: 0x0006FF30
		[Token(Token = "0x601295B")]
		[Address(RVA = "0xA87D20", Offset = "0xA86920", VA = "0x180A87D20")]
		private AbilityStandard.SelectTargetSource <>xLuaBaseProxy_get_selectTargetSource()
		{
			return AbilityStandard.SelectTargetSource.NONE;
		}

		// Token: 0x0601295C RID: 76124 RVA: 0x00071D48 File Offset: 0x0006FF48
		[Token(Token = "0x601295C")]
		[Address(RVA = "0xA5C1A0", Offset = "0xA5ADA0", VA = "0x180A5C1A0")]
		private bool <>xLuaBaseProxy_get_alwaysIncludeTarget()
		{
			return default(bool);
		}

		// Token: 0x0601295D RID: 76125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601295D")]
		[Address(RVA = "0xA56970", Offset = "0xA55570", VA = "0x180A56970")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x0601295E RID: 76126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601295E")]
		[Address(RVA = "0xA275B0", Offset = "0xA261B0", VA = "0x180A275B0")]
		private IList<BuffData> <>xLuaBaseProxy_GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601295F RID: 76127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601295F")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x06012960 RID: 76128 RVA: 0x00071D60 File Offset: 0x0006FF60
		[Token(Token = "0x6012960")]
		[Address(RVA = "0xA1EDF0", Offset = "0xA1D9F0", VA = "0x180A1EDF0")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012961 RID: 76129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012961")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012962 RID: 76130 RVA: 0x00071D78 File Offset: 0x0006FF78
		[Token(Token = "0x6012962")]
		[Address(RVA = "0xA694A0", Offset = "0xA680A0", VA = "0x180A694A0")]
		private bool <>xLuaBaseProxy_InterruptIfNot()
		{
			return default(bool);
		}

		// Token: 0x06012963 RID: 76131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012963")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012964 RID: 76132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012964")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014FDD RID: 85981
		[Token(Token = "0x4014FDD")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		protected BuffData _uniqueBuff;

		// Token: 0x04014FDE RID: 85982
		[Token(Token = "0x4014FDE")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		protected bool _interruptible;

		// Token: 0x04014FDF RID: 85983
		[Token(Token = "0x4014FDF")]
		[FieldOffset(Offset = "0x1D1")]
		[SerializeField]
		private bool _removeBuffsIfNoValidTarget;

		// Token: 0x04014FE0 RID: 85984
		[Token(Token = "0x4014FE0")]
		[FieldOffset(Offset = "0x1D2")]
		[SerializeField]
		private bool _useTileSelectorForSearchCharacter;

		// Token: 0x04014FE1 RID: 85985
		[Token(Token = "0x4014FE1")]
		[FieldOffset(Offset = "0x1D8")]
		private ObjectPtr<Entity> m_target;

		// Token: 0x04014FE2 RID: 85986
		[Token(Token = "0x4014FE2")]
		[FieldOffset(Offset = "0x1E8")]
		private ObjectPtr<Buff> m_buff;

		// Token: 0x04014FE3 RID: 85987
		[Token(Token = "0x4014FE3")]
		[FieldOffset(Offset = "0x1F8")]
		private bool m_startCheck;

		// Token: 0x04014FE4 RID: 85988
		[Token(Token = "0x4014FE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014FE5 RID: 85989
		[Token(Token = "0x4014FE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014FE6 RID: 85990
		[Token(Token = "0x4014FE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014FE7 RID: 85991
		[Token(Token = "0x4014FE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014FE8 RID: 85992
		[Token(Token = "0x4014FE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014FE9 RID: 85993
		[Token(Token = "0x4014FE9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014FEA RID: 85994
		[Token(Token = "0x4014FEA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014FEB RID: 85995
		[Token(Token = "0x4014FEB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x04014FEC RID: 85996
		[Token(Token = "0x4014FEC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014FED RID: 85997
		[Token(Token = "0x4014FED")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InterruptIfNot;

		// Token: 0x04014FEE RID: 85998
		[Token(Token = "0x4014FEE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014FEF RID: 85999
		[Token(Token = "0x4014FEF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014FF0 RID: 86000
		[Token(Token = "0x4014FF0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoUpdateTarget;

		// Token: 0x04014FF1 RID: 86001
		[Token(Token = "0x4014FF1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DoAddBuff;

		// Token: 0x04014FF2 RID: 86002
		[Token(Token = "0x4014FF2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoRemoveBuff;

		// Token: 0x04014FF3 RID: 86003
		[Token(Token = "0x4014FF3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
