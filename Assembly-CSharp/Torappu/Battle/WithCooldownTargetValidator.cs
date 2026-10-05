using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002593 RID: 9619
	[Token(Token = "0x2002593")]
	public class WithCooldownTargetValidator : TargetValidator
	{
		// Token: 0x0600F7F6 RID: 63478 RVA: 0x0005CDC0 File Offset: 0x0005AFC0
		[Token(Token = "0x600F7F6")]
		[Address(RVA = "0x71A340", Offset = "0x718F40", VA = "0x18071A340")]
		private bool _CheckTargetValidateCooldown(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7F7 RID: 63479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7F7")]
		[Address(RVA = "0x71A4D0", Offset = "0x7190D0", VA = "0x18071A4D0")]
		private void _UpdateTargetValidateCooldown(Entity target)
		{
		}

		// Token: 0x0600F7F8 RID: 63480 RVA: 0x0005CDD8 File Offset: 0x0005AFD8
		[Token(Token = "0x600F7F8")]
		[Address(RVA = "0x71A010", Offset = "0x718C10", VA = "0x18071A010", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7F9 RID: 63481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7F9")]
		[Address(RVA = "0x719DC0", Offset = "0x7189C0", VA = "0x180719DC0", Slot = "6")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600F7FA RID: 63482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7FA")]
		[Address(RVA = "0x719F30", Offset = "0x718B30", VA = "0x180719F30", Slot = "4")]
		public override void SetData(Entity owner, Blackboard blackboard, bool ignoreTargetSide)
		{
		}

		// Token: 0x0600F7FB RID: 63483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7FB")]
		[Address(RVA = "0x71A620", Offset = "0x719220", VA = "0x18071A620")]
		public WithCooldownTargetValidator()
		{
		}

		// Token: 0x0600F7FC RID: 63484 RVA: 0x0005CDF0 File Offset: 0x0005AFF0
		[Token(Token = "0x600F7FC")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0600F7FD RID: 63485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7FD")]
		[Address(RVA = "0x715F60", Offset = "0x714B60", VA = "0x180715F60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600F7FE RID: 63486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7FE")]
		[Address(RVA = "0x6EFB90", Offset = "0x6EE790", VA = "0x1806EFB90")]
		private void <>xLuaBaseProxy_SetData(Entity P0, Blackboard P1, bool P2)
		{
		}

		// Token: 0x04011396 RID: 70550
		[Token(Token = "0x4011396")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _cooldown;

		// Token: 0x04011397 RID: 70551
		[Token(Token = "0x4011397")]
		[FieldOffset(Offset = "0x98")]
		private readonly ListDict<ObjectPtr<Entity>, FP> m_targetCooldownDict;

		// Token: 0x04011398 RID: 70552
		[Token(Token = "0x4011398")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckTargetValidateCooldown;

		// Token: 0x04011399 RID: 70553
		[Token(Token = "0x4011399")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateTargetValidateCooldown;

		// Token: 0x0401139A RID: 70554
		[Token(Token = "0x401139A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401139B RID: 70555
		[Token(Token = "0x401139B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401139C RID: 70556
		[Token(Token = "0x401139C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401139D RID: 70557
		[Token(Token = "0x401139D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
