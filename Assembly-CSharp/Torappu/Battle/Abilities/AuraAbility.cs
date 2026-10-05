using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B17 RID: 11031
	[Token(Token = "0x2002B17")]
	[RequireComponent(typeof(Rigidbody2D))]
	public class AuraAbility : AbilityStandard, IAuraAbilityControl
	{
		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x0601279F RID: 75679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170028AF")]
		protected virtual AuraAbility.ITargetEnterExitHandler eeHandler
		{
			[Token(Token = "0x601279F")]
			[Address(RVA = "0xA72330", Offset = "0xA70F30", VA = "0x180A72330", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x060127A0 RID: 75680 RVA: 0x000715B0 File Offset: 0x0006F7B0
		[Token(Token = "0x170028B0")]
		public override FP cooldown
		{
			[Token(Token = "0x60127A0")]
			[Address(RVA = "0xA722B0", Offset = "0xA70EB0", VA = "0x180A722B0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x060127A1 RID: 75681 RVA: 0x000715C8 File Offset: 0x0006F7C8
		[Token(Token = "0x170028B1")]
		public override Ability.Category category
		{
			[Token(Token = "0x60127A1")]
			[Address(RVA = "0xA72250", Offset = "0xA70E50", VA = "0x180A72250", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x060127A2 RID: 75682 RVA: 0x000715E0 File Offset: 0x0006F7E0
		[Token(Token = "0x170028B2")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x60127A2")]
			[Address(RVA = "0xA72700", Offset = "0xA71300", VA = "0x180A72700", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x060127A3 RID: 75683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170028B3")]
		public override IDrawableRange rangeToShow
		{
			[Token(Token = "0x60127A3")]
			[Address(RVA = "0xA72620", Offset = "0xA71220", VA = "0x180A72620", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x060127A4 RID: 75684 RVA: 0x000715F8 File Offset: 0x0006F7F8
		[Token(Token = "0x170028B4")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x60127A4")]
			[Address(RVA = "0xA721F0", Offset = "0xA70DF0", VA = "0x180A721F0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x060127A5 RID: 75685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060127A6 RID: 75686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170028B5")]
		private protected Rigidbody2D rigidbody2D
		{
			[Token(Token = "0x60127A5")]
			[Address(RVA = "0xA726A0", Offset = "0xA712A0", VA = "0x180A726A0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60127A6")]
			[Address(RVA = "0xA72760", Offset = "0xA71360", VA = "0x180A72760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060127A7 RID: 75687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60127A7")]
		[Address(RVA = "0xA70DE0", Offset = "0xA6F9E0", VA = "0x180A70DE0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060127A8 RID: 75688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60127A8")]
		[Address(RVA = "0xA70EB0", Offset = "0xA6FAB0", VA = "0x180A70EB0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x060127A9 RID: 75689 RVA: 0x00071610 File Offset: 0x0006F810
		[Token(Token = "0x170028B6")]
		public float radius
		{
			[Token(Token = "0x60127A9")]
			[Address(RVA = "0xA724F0", Offset = "0xA710F0", VA = "0x180A724F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060127AA RID: 75690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60127AA")]
		[Address(RVA = "0xA70E50", Offset = "0xA6FA50", VA = "0x180A70E50", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x060127AB RID: 75691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60127AB")]
		[Address(RVA = "0xA70D80", Offset = "0xA6F980", VA = "0x180A70D80", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x060127AC RID: 75692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60127AC")]
		[Address(RVA = "0xA715F0", Offset = "0xA701F0", VA = "0x180A715F0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x060127AD RID: 75693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60127AD")]
		[Address(RVA = "0xA71560", Offset = "0xA70160", VA = "0x180A71560", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x060127AE RID: 75694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127AE")]
		[Address(RVA = "0xA71680", Offset = "0xA70280", VA = "0x180A71680", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060127AF RID: 75695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127AF")]
		[Address(RVA = "0xA709A0", Offset = "0xA6F5A0", VA = "0x180A709A0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060127B0 RID: 75696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127B0")]
		[Address(RVA = "0xA6FF30", Offset = "0xA6EB30", VA = "0x180A6FF30", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060127B1 RID: 75697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127B1")]
		[Address(RVA = "0xA70520", Offset = "0xA6F120", VA = "0x180A70520", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060127B2 RID: 75698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127B2")]
		[Address(RVA = "0xA70CD0", Offset = "0xA6F8D0", VA = "0x180A70CD0", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060127B3 RID: 75699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127B3")]
		[Address(RVA = "0xA70C20", Offset = "0xA6F820", VA = "0x180A70C20", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x060127B4 RID: 75700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127B4")]
		[Address(RVA = "0xA70F40", Offset = "0xA6FB40", VA = "0x180A70F40", Slot = "57")]
		public override void OnAbilityExtendUpdated(FP extend)
		{
		}

		// Token: 0x060127B5 RID: 75701 RVA: 0x00071628 File Offset: 0x0006F828
		[Token(Token = "0x60127B5")]
		[Address(RVA = "0xA6FDE0", Offset = "0xA6E9E0", VA = "0x180A6FDE0", Slot = "98")]
		protected virtual bool DealTargetTouched(Entity target, AuraAbility.TargetMeta meta)
		{
			return default(bool);
		}

		// Token: 0x060127B6 RID: 75702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127B6")]
		[Address(RVA = "0xA6FD10", Offset = "0xA6E910", VA = "0x180A6FD10", Slot = "99")]
		protected virtual void DealTargetLeft(Entity target, AuraAbility.TargetMeta meta)
		{
		}

		// Token: 0x060127B7 RID: 75703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127B7")]
		[Address(RVA = "0xA71A90", Offset = "0xA70690", VA = "0x180A71A90")]
		private void _ClearEffects()
		{
		}

		// Token: 0x060127B8 RID: 75704 RVA: 0x00071640 File Offset: 0x0006F840
		[Token(Token = "0x60127B8")]
		[Address(RVA = "0xA71C40", Offset = "0xA70840", VA = "0x180A71C40")]
		private bool _DoTargetCheckAndEnter(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060127B9 RID: 75705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127B9")]
		[Address(RVA = "0xA71E80", Offset = "0xA70A80", VA = "0x180A71E80")]
		protected void _DoTargetExit(Entity target)
		{
		}

		// Token: 0x060127BA RID: 75706 RVA: 0x00071658 File Offset: 0x0006F858
		[Token(Token = "0x60127BA")]
		[Address(RVA = "0xA71900", Offset = "0xA70500", VA = "0x180A71900", Slot = "100")]
		protected virtual bool VerifyTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060127BB RID: 75707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127BB")]
		[Address(RVA = "0xA71180", Offset = "0xA6FD80", VA = "0x180A71180")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x060127BC RID: 75708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127BC")]
		[Address(RVA = "0xA71370", Offset = "0xA6FF70", VA = "0x180A71370")]
		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		// Token: 0x060127BD RID: 75709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127BD")]
		[Address(RVA = "0xA6FAA0", Offset = "0xA6E6A0", VA = "0x180A6FAA0", Slot = "95")]
		protected override void Awake()
		{
		}

		// Token: 0x060127BE RID: 75710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127BE")]
		[Address(RVA = "0xA71020", Offset = "0xA6FC20", VA = "0x180A71020", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060127BF RID: 75711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127BF")]
		[Address(RVA = "0xA71770", Offset = "0xA70370", VA = "0x180A71770", Slot = "96")]
		public void RestartAuraBySideType(SideType sideType)
		{
		}

		// Token: 0x060127C0 RID: 75712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C0")]
		[Address(RVA = "0xA72060", Offset = "0xA70C60", VA = "0x180A72060")]
		public AuraAbility()
		{
		}

		// Token: 0x060127C1 RID: 75713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60127C1")]
		[Address(RVA = "0xA6F370", Offset = "0xA6DF70", VA = "0x180A6F370")]
		private IDrawableRange <>xLuaBaseProxy_get_rangeToShow()
		{
			return null;
		}

		// Token: 0x060127C2 RID: 75714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C2")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060127C3 RID: 75715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C3")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060127C4 RID: 75716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C4")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060127C5 RID: 75717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C5")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x060127C6 RID: 75718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C6")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x060127C7 RID: 75719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C7")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x060127C8 RID: 75720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C8")]
		[Address(RVA = "0xA718F0", Offset = "0xA704F0", VA = "0x180A718F0")]
		private void <>xLuaBaseProxy_OnAbilityExtendUpdated(FP P0)
		{
		}

		// Token: 0x060127C9 RID: 75721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127C9")]
		[Address(RVA = "0xA4FF40", Offset = "0xA4EB40", VA = "0x180A4FF40")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x060127CA RID: 75722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127CA")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014E21 RID: 85537
		[Token(Token = "0x4014E21")]
		protected const int TRIGGER_TICK = 10;

		// Token: 0x04014E22 RID: 85538
		[Token(Token = "0x4014E22")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		protected BuffData[] _buffs;

		// Token: 0x04014E23 RID: 85539
		[Token(Token = "0x4014E23")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected BuffData[] _passiveBuffs;

		// Token: 0x04014E24 RID: 85540
		[Token(Token = "0x4014E24")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected AuraAbility.SelfOption _selfOption;

		// Token: 0x04014E25 RID: 85541
		[Token(Token = "0x4014E25")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool _removeBuffWhenTargetLeave;

		// Token: 0x04014E26 RID: 85542
		[Token(Token = "0x4014E26")]
		[FieldOffset(Offset = "0x125")]
		[SerializeField]
		private bool _removeBuffWhenAbilityDetached;

		// Token: 0x04014E27 RID: 85543
		[Token(Token = "0x4014E27")]
		[FieldOffset(Offset = "0x126")]
		[SerializeField]
		private bool _onlyAddBuffOnceForEachTarget;

		// Token: 0x04014E28 RID: 85544
		[Token(Token = "0x4014E28")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x04014E29 RID: 85545
		[Token(Token = "0x4014E29")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Help("HelpAttribute.IsValueNull", HelpType.Error, "Must specified a validator.")]
		private TargetValidator _targetValidator;

		// Token: 0x04014E2A RID: 85546
		[Token(Token = "0x4014E2A")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool _ignoreOwnerFakeDeath;

		// Token: 0x04014E2B RID: 85547
		[Token(Token = "0x4014E2B")]
		[FieldOffset(Offset = "0x140")]
		private Range m_range;

		// Token: 0x04014E2C RID: 85548
		[Token(Token = "0x4014E2C")]
		[FieldOffset(Offset = "0x148")]
		private int m_layerMask;

		// Token: 0x04014E2D RID: 85549
		[Token(Token = "0x4014E2D")]
		[FieldOffset(Offset = "0x150")]
		protected Dictionary<ObjectPtr<Entity>, AuraAbility.TargetMeta> m_targetMap;

		// Token: 0x04014E2E RID: 85550
		[Token(Token = "0x4014E2E")]
		[FieldOffset(Offset = "0x158")]
		private HashSet<ObjectPtr<Entity>> m_targetHashSet;

		// Token: 0x04014E2F RID: 85551
		[Token(Token = "0x4014E2F")]
		[FieldOffset(Offset = "0x160")]
		protected Collider2D[] m_colliders;

		// Token: 0x04014E30 RID: 85552
		[Token(Token = "0x4014E30")]
		[FieldOffset(Offset = "0x168")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04014E31 RID: 85553
		[Token(Token = "0x4014E31")]
		[FieldOffset(Offset = "0x170")]
		protected AuraAbility.ITargetEnterExitHandler m_eeHandler;

		// Token: 0x04014E33 RID: 85555
		[Token(Token = "0x4014E33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eeHandler;

		// Token: 0x04014E34 RID: 85556
		[Token(Token = "0x4014E34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014E35 RID: 85557
		[Token(Token = "0x4014E35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014E36 RID: 85558
		[Token(Token = "0x4014E36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014E37 RID: 85559
		[Token(Token = "0x4014E37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x04014E38 RID: 85560
		[Token(Token = "0x4014E38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014E39 RID: 85561
		[Token(Token = "0x4014E39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_rigidbody2D;

		// Token: 0x04014E3A RID: 85562
		[Token(Token = "0x4014E3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_rigidbody2D;

		// Token: 0x04014E3B RID: 85563
		[Token(Token = "0x4014E3B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014E3C RID: 85564
		[Token(Token = "0x4014E3C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014E3D RID: 85565
		[Token(Token = "0x4014E3D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_radius;

		// Token: 0x04014E3E RID: 85566
		[Token(Token = "0x4014E3E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014E3F RID: 85567
		[Token(Token = "0x4014E3F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014E40 RID: 85568
		[Token(Token = "0x4014E40")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014E41 RID: 85569
		[Token(Token = "0x4014E41")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014E42 RID: 85570
		[Token(Token = "0x4014E42")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014E43 RID: 85571
		[Token(Token = "0x4014E43")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014E44 RID: 85572
		[Token(Token = "0x4014E44")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014E45 RID: 85573
		[Token(Token = "0x4014E45")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014E46 RID: 85574
		[Token(Token = "0x4014E46")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014E47 RID: 85575
		[Token(Token = "0x4014E47")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014E48 RID: 85576
		[Token(Token = "0x4014E48")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnAbilityExtendUpdated;

		// Token: 0x04014E49 RID: 85577
		[Token(Token = "0x4014E49")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_DealTargetTouched;

		// Token: 0x04014E4A RID: 85578
		[Token(Token = "0x4014E4A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_DealTargetLeft;

		// Token: 0x04014E4B RID: 85579
		[Token(Token = "0x4014E4B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x04014E4C RID: 85580
		[Token(Token = "0x4014E4C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__DoTargetCheckAndEnter;

		// Token: 0x04014E4D RID: 85581
		[Token(Token = "0x4014E4D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__DoTargetExit;

		// Token: 0x04014E4E RID: 85582
		[Token(Token = "0x4014E4E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x04014E4F RID: 85583
		[Token(Token = "0x4014E4F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnTriggerEnter2D;

		// Token: 0x04014E50 RID: 85584
		[Token(Token = "0x4014E50")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnTriggerExit2D;

		// Token: 0x04014E51 RID: 85585
		[Token(Token = "0x4014E51")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04014E52 RID: 85586
		[Token(Token = "0x4014E52")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014E53 RID: 85587
		[Token(Token = "0x4014E53")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_RestartAuraBySideType;

		// Token: 0x04014E54 RID: 85588
		[Token(Token = "0x4014E54")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B18 RID: 11032
		[Token(Token = "0x2002B18")]
		public enum SelfOption
		{
			// Token: 0x04014E56 RID: 85590
			[Token(Token = "0x4014E56")]
			DEFAULT,
			// Token: 0x04014E57 RID: 85591
			[Token(Token = "0x4014E57")]
			INCLUDE,
			// Token: 0x04014E58 RID: 85592
			[Token(Token = "0x4014E58")]
			EXCLUDE
		}

		// Token: 0x02002B19 RID: 11033
		[Token(Token = "0x2002B19")]
		protected class TargetMeta
		{
			// Token: 0x060127CB RID: 75723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127CB")]
			[Address(RVA = "0xA92000", Offset = "0xA90C00", VA = "0x180A92000")]
			public TargetMeta()
			{
			}

			// Token: 0x04014E59 RID: 85593
			[Token(Token = "0x4014E59")]
			[FieldOffset(Offset = "0x10")]
			public List<uint> buffIds;
		}

		// Token: 0x02002B1A RID: 11034
		[Token(Token = "0x2002B1A")]
		public interface ITargetEnterExitHandler
		{
			// Token: 0x060127CC RID: 75724
			[Token(Token = "0x60127CC")]
			void Clear();

			// Token: 0x060127CD RID: 75725
			[Token(Token = "0x60127CD")]
			void OnTick();

			// Token: 0x060127CE RID: 75726
			[Token(Token = "0x60127CE")]
			void OnTargetEnter(Entity target, uint abilityUniqueId);

			// Token: 0x060127CF RID: 75727
			[Token(Token = "0x60127CF")]
			void OnTargetExit(Entity target, uint abilityUniqueId);
		}

		// Token: 0x02002B1B RID: 11035
		[Token(Token = "0x2002B1B")]
		public class TargetEnterExitHandler : MultiEnterExitHandler<Entity>, AuraAbility.ITargetEnterExitHandler
		{
			// Token: 0x060127D0 RID: 75728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127D0")]
			[Address(RVA = "0xA91550", Offset = "0xA90150", VA = "0x180A91550")]
			public TargetEnterExitHandler(AuraAbility.TargetEnterExitHandler.Options options)
			{
			}

			// Token: 0x060127D1 RID: 75729 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127D1")]
			[Address(RVA = "0xA90DF0", Offset = "0xA8F9F0", VA = "0x180A90DF0", Slot = "4")]
			public override void Clear()
			{
			}

			// Token: 0x060127D2 RID: 75730 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127D2")]
			[Address(RVA = "0xA90FC0", Offset = "0xA8FBC0", VA = "0x180A90FC0", Slot = "9")]
			public void OnTargetEnter(Entity target, uint abilityUniqueId)
			{
			}

			// Token: 0x060127D3 RID: 75731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127D3")]
			[Address(RVA = "0xA910C0", Offset = "0xA8FCC0", VA = "0x180A910C0", Slot = "10")]
			public void OnTargetExit(Entity target, uint abilityUniqueId)
			{
			}

			// Token: 0x060127D4 RID: 75732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127D4")]
			[Address(RVA = "0xA911C0", Offset = "0xA8FDC0", VA = "0x180A911C0", Slot = "8")]
			public void OnTick()
			{
			}

			// Token: 0x060127D5 RID: 75733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127D5")]
			[Address(RVA = "0xA90E70", Offset = "0xA8FA70", VA = "0x180A90E70", Slot = "5")]
			protected override void OnRealEnter(Entity target)
			{
			}

			// Token: 0x060127D6 RID: 75734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127D6")]
			[Address(RVA = "0xA90F20", Offset = "0xA8FB20", VA = "0x180A90F20", Slot = "6")]
			protected override void OnRealExit(Entity target)
			{
			}

			// Token: 0x060127D7 RID: 75735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127D7")]
			[Address(RVA = "0xA913A0", Offset = "0xA8FFA0", VA = "0x180A913A0")]
			private void _UpdateInvalidTarget()
			{
			}

			// Token: 0x04014E5A RID: 85594
			[Token(Token = "0x4014E5A")]
			[FieldOffset(Offset = "0x18")]
			private AuraAbility.TargetEnterExitHandler.Options m_options;

			// Token: 0x04014E5B RID: 85595
			[Token(Token = "0x4014E5B")]
			[FieldOffset(Offset = "0x30")]
			private ListSet<ObjectPtr<Entity>> m_invalidTarget;

			// Token: 0x04014E5C RID: 85596
			[Token(Token = "0x4014E5C")]
			[FieldOffset(Offset = "0x38")]
			private PeriodicTicker m_triggerTicker;

			// Token: 0x02002B1C RID: 11036
			[Token(Token = "0x2002B1C")]
			public struct Options
			{
				// Token: 0x04014E5D RID: 85597
				[Token(Token = "0x4014E5D")]
				[FieldOffset(Offset = "0x0")]
				public int periodTick;

				// Token: 0x04014E5E RID: 85598
				[Token(Token = "0x4014E5E")]
				[FieldOffset(Offset = "0x8")]
				public Func<Entity, bool> checkAndEnterFunc;

				// Token: 0x04014E5F RID: 85599
				[Token(Token = "0x4014E5F")]
				[FieldOffset(Offset = "0x10")]
				public Action<Entity> exitFunc;
			}
		}
	}
}
