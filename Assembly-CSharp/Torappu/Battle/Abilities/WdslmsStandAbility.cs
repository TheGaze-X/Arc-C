using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BBF RID: 11199
	[Token(Token = "0x2002BBF")]
	public class WdslmsStandAbility : EmptyAbility
	{
		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x06012EAA RID: 77482 RVA: 0x00073F50 File Offset: 0x00072150
		[Token(Token = "0x170029B9")]
		public bool isHost
		{
			[Token(Token = "0x6012EAA")]
			[Address(RVA = "0xAD8F60", Offset = "0xAD7B60", VA = "0x180AD8F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x06012EAB RID: 77483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029BA")]
		public Enemy host
		{
			[Token(Token = "0x6012EAB")]
			[Address(RVA = "0xAD8F00", Offset = "0xAD7B00", VA = "0x180AD8F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x06012EAC RID: 77484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029BB")]
		public List<Enemy> stands
		{
			[Token(Token = "0x6012EAC")]
			[Address(RVA = "0xAD8FC0", Offset = "0xAD7BC0", VA = "0x180AD8FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012EAD RID: 77485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EAD")]
		[Address(RVA = "0xAD8DA0", Offset = "0xAD79A0", VA = "0x180AD8DA0")]
		public void SetIsHost(bool value)
		{
		}

		// Token: 0x06012EAE RID: 77486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EAE")]
		[Address(RVA = "0xAD8490", Offset = "0xAD7090", VA = "0x180AD8490")]
		public void RegisterHost(Enemy host)
		{
		}

		// Token: 0x06012EAF RID: 77487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EAF")]
		[Address(RVA = "0xAD8510", Offset = "0xAD7110", VA = "0x180AD8510")]
		public void RegisterStand(Enemy stand)
		{
		}

		// Token: 0x06012EB0 RID: 77488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EB0")]
		[Address(RVA = "0xAD8240", Offset = "0xAD6E40", VA = "0x180AD8240")]
		public void CopyStandList(WdslmsStandAbility hostAbility)
		{
		}

		// Token: 0x06012EB1 RID: 77489 RVA: 0x00073F68 File Offset: 0x00072168
		[Token(Token = "0x6012EB1")]
		[Address(RVA = "0xAD85B0", Offset = "0xAD71B0", VA = "0x180AD85B0")]
		public bool RunActions(WdslmsStandAbility.ActionsTargetType targetType, ActionNode[] actions, ActionNode.SourceType sourceType, Blackboard blackboard)
		{
			return default(bool);
		}

		// Token: 0x06012EB2 RID: 77490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EB2")]
		[Address(RVA = "0xAD8370", Offset = "0xAD6F70", VA = "0x180AD8370", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012EB3 RID: 77491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EB3")]
		[Address(RVA = "0xAD8E10", Offset = "0xAD7A10", VA = "0x180AD8E10")]
		public WdslmsStandAbility()
		{
		}

		// Token: 0x06012EB4 RID: 77492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EB4")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x04015570 RID: 87408
		[Token(Token = "0x4015570")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _isHost;

		// Token: 0x04015571 RID: 87409
		[Token(Token = "0x4015571")]
		[FieldOffset(Offset = "0x118")]
		private Enemy m_host;

		// Token: 0x04015572 RID: 87410
		[Token(Token = "0x4015572")]
		[FieldOffset(Offset = "0x120")]
		private List<Enemy> m_stands;

		// Token: 0x04015573 RID: 87411
		[Token(Token = "0x4015573")]
		[FieldOffset(Offset = "0x128")]
		private List<Enemy> m_actionTargets;

		// Token: 0x04015574 RID: 87412
		[Token(Token = "0x4015574")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isHost;

		// Token: 0x04015575 RID: 87413
		[Token(Token = "0x4015575")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_host;

		// Token: 0x04015576 RID: 87414
		[Token(Token = "0x4015576")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stands;

		// Token: 0x04015577 RID: 87415
		[Token(Token = "0x4015577")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetIsHost;

		// Token: 0x04015578 RID: 87416
		[Token(Token = "0x4015578")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterHost;

		// Token: 0x04015579 RID: 87417
		[Token(Token = "0x4015579")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterStand;

		// Token: 0x0401557A RID: 87418
		[Token(Token = "0x401557A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CopyStandList;

		// Token: 0x0401557B RID: 87419
		[Token(Token = "0x401557B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RunActions;

		// Token: 0x0401557C RID: 87420
		[Token(Token = "0x401557C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401557D RID: 87421
		[Token(Token = "0x401557D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BC0 RID: 11200
		[Token(Token = "0x2002BC0")]
		public enum ActionsTargetType
		{
			// Token: 0x0401557F RID: 87423
			[Token(Token = "0x401557F")]
			HOST,
			// Token: 0x04015580 RID: 87424
			[Token(Token = "0x4015580")]
			STANDS,
			// Token: 0x04015581 RID: 87425
			[Token(Token = "0x4015581")]
			STANDS_EXCEPT_SELF,
			// Token: 0x04015582 RID: 87426
			[Token(Token = "0x4015582")]
			SELF_WITH_HOST_AS_SOURCE
		}
	}
}
