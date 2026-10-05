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
	// Token: 0x02002AB2 RID: 10930
	[Token(Token = "0x2002AB2")]
	public class MultiChargeRangedAttack : RangedAttack, IMultiChargeUberEffectEmitterAbility, IChargeableSource, IAlwaysTrigger
	{
		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x060122DD RID: 74461 RVA: 0x0006F6A8 File Offset: 0x0006D8A8
		[Token(Token = "0x170027E3")]
		private bool isUseChargeableGroup
		{
			[Token(Token = "0x60122DD")]
			[Address(RVA = "0xA3F9C0", Offset = "0xA3E5C0", VA = "0x180A3F9C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060122DE RID: 74462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122DE")]
		[Address(RVA = "0xA3F1B0", Offset = "0xA3DDB0", VA = "0x180A3F1B0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x060122DF RID: 74463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122DF")]
		[Address(RVA = "0xA3F6C0", Offset = "0xA3E2C0", VA = "0x180A3F6C0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x060122E0 RID: 74464 RVA: 0x0006F6C0 File Offset: 0x0006D8C0
		[Token(Token = "0x60122E0")]
		[Address(RVA = "0xA3EBE0", Offset = "0xA3D7E0", VA = "0x180A3EBE0", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x060122E1 RID: 74465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122E1")]
		[Address(RVA = "0xA3F3D0", Offset = "0xA3DFD0", VA = "0x180A3F3D0", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060122E2 RID: 74466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122E2")]
		[Address(RVA = "0xA3F520", Offset = "0xA3E120", VA = "0x180A3F520", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x060122E3 RID: 74467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122E3")]
		[Address(RVA = "0xA3F290", Offset = "0xA3DE90", VA = "0x180A3F290", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060122E4 RID: 74468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60122E4")]
		[Address(RVA = "0xA3EDB0", Offset = "0xA3D9B0", VA = "0x180A3EDB0", Slot = "113")]
		protected override Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x060122E5 RID: 74469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122E5")]
		[Address(RVA = "0xA3EE70", Offset = "0xA3DA70", VA = "0x180A3EE70", Slot = "91")]
		protected override void DoEmitAudioSignalForSpellOn()
		{
		}

		// Token: 0x060122E6 RID: 74470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60122E6")]
		[Address(RVA = "0xA3F010", Offset = "0xA3DC10", VA = "0x180A3F010", Slot = "105")]
		public override string GetAnimKey()
		{
			return null;
		}

		// Token: 0x060122E7 RID: 74471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122E7")]
		[Address(RVA = "0xA3F880", Offset = "0xA3E480", VA = "0x180A3F880")]
		private void _SetIsChargeAction(bool isChargeAction)
		{
		}

		// Token: 0x060122E8 RID: 74472 RVA: 0x0006F6D8 File Offset: 0x0006D8D8
		[Token(Token = "0x60122E8")]
		[Address(RVA = "0xA3F150", Offset = "0xA3DD50", VA = "0x180A3F150", Slot = "116")]
		public bool GetIsChargeAction()
		{
			return default(bool);
		}

		// Token: 0x060122E9 RID: 74473 RVA: 0x0006F6F0 File Offset: 0x0006D8F0
		[Token(Token = "0x60122E9")]
		[Address(RVA = "0xA3F0F0", Offset = "0xA3DCF0", VA = "0x180A3F0F0", Slot = "117")]
		public int GetChargeTimes()
		{
			return 0;
		}

		// Token: 0x060122EA RID: 74474 RVA: 0x0006F708 File Offset: 0x0006D908
		[Token(Token = "0x60122EA")]
		[Address(RVA = "0xA3F7D0", Offset = "0xA3E3D0", VA = "0x180A3F7D0")]
		private bool _CheckCanCharge()
		{
			return default(bool);
		}

		// Token: 0x060122EB RID: 74475 RVA: 0x0006F720 File Offset: 0x0006D920
		[Token(Token = "0x60122EB")]
		[Address(RVA = "0xA3EB80", Offset = "0xA3D780", VA = "0x180A3EB80", Slot = "118")]
		public bool CanAlwaysTrigger()
		{
			return default(bool);
		}

		// Token: 0x060122EC RID: 74476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122EC")]
		[Address(RVA = "0xA3F960", Offset = "0xA3E560", VA = "0x180A3F960")]
		public MultiChargeRangedAttack()
		{
		}

		// Token: 0x060122ED RID: 74477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122ED")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x060122EE RID: 74478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122EE")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060122EF RID: 74479 RVA: 0x0006F738 File Offset: 0x0006D938
		[Token(Token = "0x60122EF")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x060122F0 RID: 74480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122F0")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x060122F1 RID: 74481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122F1")]
		[Address(RVA = "0xA36010", Offset = "0xA34C10", VA = "0x180A36010")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060122F2 RID: 74482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122F2")]
		[Address(RVA = "0xA37180", Offset = "0xA35D80", VA = "0x180A37180")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060122F3 RID: 74483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60122F3")]
		[Address(RVA = "0xA37170", Offset = "0xA35D70", VA = "0x180A37170")]
		private Projectile <>xLuaBaseProxy_CreateProjectile(ILocatable P0, out Projectile P1)
		{
			return null;
		}

		// Token: 0x060122F4 RID: 74484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122F4")]
		[Address(RVA = "0xA275A0", Offset = "0xA261A0", VA = "0x180A275A0")]
		private void <>xLuaBaseProxy_DoEmitAudioSignalForSpellOn()
		{
		}

		// Token: 0x060122F5 RID: 74485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60122F5")]
		[Address(RVA = "0xA3F7C0", Offset = "0xA3E3C0", VA = "0x180A3F7C0")]
		private string <>xLuaBaseProxy_GetAnimKey()
		{
			return null;
		}

		// Token: 0x04014908 RID: 84232
		[Token(Token = "0x4014908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("MultiCharge")]
		private bool _useChargeableGroup;

		// Token: 0x04014909 RID: 84233
		[Token(Token = "0x4014909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[Inspect("isUseChargeableGroup", true)]
		[SerializeField]
		[Group("MultiCharge")]
		protected AbilityChargeableGroup _chargeableGroup;

		// Token: 0x0401490A RID: 84234
		[Token(Token = "0x401490A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		[SerializeField]
		[Group("MultiCharge")]
		protected ChargeRangedAttack _chargeAbility;

		// Token: 0x0401490B RID: 84235
		[Token(Token = "0x401490B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		[SerializeField]
		[Group("MultiCharge")]
		private string _chargeAnimKey;

		// Token: 0x0401490C RID: 84236
		[Token(Token = "0x401490C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		[SerializeField]
		[Group("MultiCharge")]
		private string _chargeDownAnimKey;

		// Token: 0x0401490D RID: 84237
		[Token(Token = "0x401490D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		[SerializeField]
		[Group("MultiCharge")]
		private string _chargeUpAnimKey;

		// Token: 0x0401490E RID: 84238
		[Token(Token = "0x401490E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		[SerializeField]
		[Group("MultiCharge")]
		private bool _attachAndDetach;

		// Token: 0x0401490F RID: 84239
		[Token(Token = "0x401490F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x299")]
		private bool m_isChargeAction;

		// Token: 0x04014910 RID: 84240
		[Token(Token = "0x4014910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUseChargeableGroup;

		// Token: 0x04014911 RID: 84241
		[Token(Token = "0x4014911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x04014912 RID: 84242
		[Token(Token = "0x4014912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014913 RID: 84243
		[Token(Token = "0x4014913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014914 RID: 84244
		[Token(Token = "0x4014914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014915 RID: 84245
		[Token(Token = "0x4014915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014916 RID: 84246
		[Token(Token = "0x4014916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014917 RID: 84247
		[Token(Token = "0x4014917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x04014918 RID: 84248
		[Token(Token = "0x4014918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoEmitAudioSignalForSpellOn;

		// Token: 0x04014919 RID: 84249
		[Token(Token = "0x4014919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetAnimKey;

		// Token: 0x0401491A RID: 84250
		[Token(Token = "0x401491A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetIsChargeAction;

		// Token: 0x0401491B RID: 84251
		[Token(Token = "0x401491B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetIsChargeAction;

		// Token: 0x0401491C RID: 84252
		[Token(Token = "0x401491C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetChargeTimes;

		// Token: 0x0401491D RID: 84253
		[Token(Token = "0x401491D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckCanCharge;

		// Token: 0x0401491E RID: 84254
		[Token(Token = "0x401491E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CanAlwaysTrigger;

		// Token: 0x0401491F RID: 84255
		[Token(Token = "0x401491F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
