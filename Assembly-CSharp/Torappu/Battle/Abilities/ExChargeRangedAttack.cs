using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AAC RID: 10924
	[Token(Token = "0x2002AAC")]
	public class ExChargeRangedAttack : ChargeRangedAttack, IExChargeableSource, IChargeableSource
	{
		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x06012292 RID: 74386 RVA: 0x0006F498 File Offset: 0x0006D698
		[Token(Token = "0x170027E0")]
		[Inspect(Level = 2)]
		[Group("Extra")]
		public int exChargeTimes
		{
			[Token(Token = "0x6012292")]
			[Address(RVA = "0xA3B840", Offset = "0xA3A440", VA = "0x180A3B840")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06012293 RID: 74387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012293")]
		[Address(RVA = "0xA3AC80", Offset = "0xA39880", VA = "0x180A3AC80", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012294 RID: 74388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012294")]
		[Address(RVA = "0xA3B460", Offset = "0xA3A060", VA = "0x180A3B460")]
		public void SetChargeGroup(AbilityExChargeGroup group)
		{
		}

		// Token: 0x06012295 RID: 74389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012295")]
		[Address(RVA = "0xA3AF80", Offset = "0xA39B80", VA = "0x180A3AF80", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012296 RID: 74390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012296")]
		[Address(RVA = "0xA3B340", Offset = "0xA39F40", VA = "0x180A3B340", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012297 RID: 74391 RVA: 0x0006F4B0 File Offset: 0x0006D6B0
		[Token(Token = "0x6012297")]
		[Address(RVA = "0xA3A4A0", Offset = "0xA390A0", VA = "0x180A3A4A0", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012298 RID: 74392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012298")]
		[Address(RVA = "0xA3B250", Offset = "0xA39E50", VA = "0x180A3B250", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012299 RID: 74393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012299")]
		[Address(RVA = "0xA3A8C0", Offset = "0xA394C0", VA = "0x180A3A8C0", Slot = "113")]
		protected override Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x0601229A RID: 74394 RVA: 0x0006F4C8 File Offset: 0x0006D6C8
		[Token(Token = "0x601229A")]
		[Address(RVA = "0xA3A610", Offset = "0xA39210", VA = "0x180A3A610")]
		public bool ConsumeChargeTimes()
		{
			return default(bool);
		}

		// Token: 0x0601229B RID: 74395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601229B")]
		[Address(RVA = "0xA3A270", Offset = "0xA38E70", VA = "0x180A3A270", Slot = "129")]
		public override void AddChargeTimes()
		{
		}

		// Token: 0x0601229C RID: 74396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601229C")]
		[Address(RVA = "0xA3B550", Offset = "0xA3A150", VA = "0x180A3B550", Slot = "131")]
		public override void SetIsChargeAction(bool isChargeAttack)
		{
		}

		// Token: 0x0601229D RID: 74397 RVA: 0x0006F4E0 File Offset: 0x0006D6E0
		[Token(Token = "0x601229D")]
		[Address(RVA = "0xA3A3B0", Offset = "0xA38FB0", VA = "0x180A3A3B0", Slot = "130")]
		public override bool CanCharge()
		{
			return default(bool);
		}

		// Token: 0x0601229E RID: 74398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601229E")]
		[Address(RVA = "0xA3B4E0", Offset = "0xA3A0E0", VA = "0x180A3B4E0")]
		public void SetExChargeTimes(int exTimes)
		{
		}

		// Token: 0x0601229F RID: 74399 RVA: 0x0006F4F8 File Offset: 0x0006D6F8
		[Token(Token = "0x601229F")]
		[Address(RVA = "0xA3AEC0", Offset = "0xA39AC0", VA = "0x180A3AEC0", Slot = "132")]
		public int GetExChargeTimes()
		{
			return 0;
		}

		// Token: 0x060122A0 RID: 74400 RVA: 0x0006F510 File Offset: 0x0006D710
		[Token(Token = "0x60122A0")]
		[Address(RVA = "0xA3AF20", Offset = "0xA39B20", VA = "0x180A3AF20")]
		public bool IsExChargeAction()
		{
			return default(bool);
		}

		// Token: 0x060122A1 RID: 74401 RVA: 0x0006F528 File Offset: 0x0006D728
		[Token(Token = "0x60122A1")]
		[Address(RVA = "0xA3B680", Offset = "0xA3A280", VA = "0x180A3B680")]
		public bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060122A2 RID: 74402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122A2")]
		[Address(RVA = "0xA3B780", Offset = "0xA3A380", VA = "0x180A3B780")]
		public ExChargeRangedAttack()
		{
		}

		// Token: 0x060122A3 RID: 74403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122A3")]
		[Address(RVA = "0xA38EC0", Offset = "0xA37AC0", VA = "0x180A38EC0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060122A4 RID: 74404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122A4")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x060122A5 RID: 74405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122A5")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060122A6 RID: 74406 RVA: 0x0006F540 File Offset: 0x0006D740
		[Token(Token = "0x60122A6")]
		[Address(RVA = "0xA37530", Offset = "0xA36130", VA = "0x180A37530")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x060122A7 RID: 74407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122A7")]
		[Address(RVA = "0xA3B670", Offset = "0xA3A270", VA = "0x180A3B670")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x060122A8 RID: 74408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60122A8")]
		[Address(RVA = "0xA3B660", Offset = "0xA3A260", VA = "0x180A3B660")]
		private Projectile <>xLuaBaseProxy_CreateProjectile(ILocatable P0, out Projectile P1)
		{
			return null;
		}

		// Token: 0x060122A9 RID: 74409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122A9")]
		[Address(RVA = "0xA373C0", Offset = "0xA35FC0", VA = "0x180A373C0")]
		private void <>xLuaBaseProxy_AddChargeTimes()
		{
		}

		// Token: 0x060122AA RID: 74410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122AA")]
		[Address(RVA = "0xA385E0", Offset = "0xA371E0", VA = "0x180A385E0")]
		private void <>xLuaBaseProxy_SetIsChargeAction(bool P0)
		{
		}

		// Token: 0x060122AB RID: 74411 RVA: 0x0006F558 File Offset: 0x0006D758
		[Token(Token = "0x60122AB")]
		[Address(RVA = "0xA374C0", Offset = "0xA360C0", VA = "0x180A374C0")]
		private bool <>xLuaBaseProxy_CanCharge()
		{
			return default(bool);
		}

		// Token: 0x040148B9 RID: 84153
		[Token(Token = "0x40148B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		[SerializeField]
		[Group("Extra")]
		private string _exProjectileKey;

		// Token: 0x040148BA RID: 84154
		[Token(Token = "0x40148BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		[SerializeField]
		[Group("Extra")]
		private int _maxExChargeTimes;

		// Token: 0x040148BB RID: 84155
		[Token(Token = "0x40148BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		[Group("Extra")]
		private TargetValidator _targetValidator;

		// Token: 0x040148BC RID: 84156
		[Token(Token = "0x40148BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		[SerializeField]
		[Group("Extra")]
		private bool _forceExCharge;

		// Token: 0x040148BD RID: 84157
		[Token(Token = "0x40148BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
		[SerializeField]
		[Group("Extra")]
		private bool _refreshBlackboardOnAttached;

		// Token: 0x040148BE RID: 84158
		[Token(Token = "0x40148BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		[SerializeField]
		[Group("Extra")]
		private List<Entity.MountPointType> _exMounts;

		// Token: 0x040148BF RID: 84159
		[Token(Token = "0x40148BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private int m_exChargeTimes;

		// Token: 0x040148C0 RID: 84160
		[Token(Token = "0x40148C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private int m_maxExChargeTimes;

		// Token: 0x040148C1 RID: 84161
		[Token(Token = "0x40148C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private bool m_isExChargeAction;

		// Token: 0x040148C2 RID: 84162
		[Token(Token = "0x40148C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private ObjectPtr<Entity> m_castTarget;

		// Token: 0x040148C3 RID: 84163
		[Token(Token = "0x40148C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private AbilityExChargeGroup m_syncGroup;

		// Token: 0x040148C4 RID: 84164
		[Token(Token = "0x40148C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_exChargeTimes;

		// Token: 0x040148C5 RID: 84165
		[Token(Token = "0x40148C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040148C6 RID: 84166
		[Token(Token = "0x40148C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetChargeGroup;

		// Token: 0x040148C7 RID: 84167
		[Token(Token = "0x40148C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040148C8 RID: 84168
		[Token(Token = "0x40148C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040148C9 RID: 84169
		[Token(Token = "0x40148C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x040148CA RID: 84170
		[Token(Token = "0x40148CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040148CB RID: 84171
		[Token(Token = "0x40148CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x040148CC RID: 84172
		[Token(Token = "0x40148CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ConsumeChargeTimes;

		// Token: 0x040148CD RID: 84173
		[Token(Token = "0x40148CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AddChargeTimes;

		// Token: 0x040148CE RID: 84174
		[Token(Token = "0x40148CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetIsChargeAction;

		// Token: 0x040148CF RID: 84175
		[Token(Token = "0x40148CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CanCharge;

		// Token: 0x040148D0 RID: 84176
		[Token(Token = "0x40148D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetExChargeTimes;

		// Token: 0x040148D1 RID: 84177
		[Token(Token = "0x40148D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetExChargeTimes;

		// Token: 0x040148D2 RID: 84178
		[Token(Token = "0x40148D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsExChargeAction;

		// Token: 0x040148D3 RID: 84179
		[Token(Token = "0x40148D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x040148D4 RID: 84180
		[Token(Token = "0x40148D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
