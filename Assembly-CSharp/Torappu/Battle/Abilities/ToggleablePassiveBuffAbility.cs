using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B6C RID: 11116
	[Token(Token = "0x2002B6C")]
	public class ToggleablePassiveBuffAbility : PassiveBuffAbility
	{
		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x06012A93 RID: 76435 RVA: 0x00072618 File Offset: 0x00070818
		// (set) Token: 0x06012A94 RID: 76436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002911")]
		protected bool toggled
		{
			[Token(Token = "0x6012A93")]
			[Address(RVA = "0xAA8950", Offset = "0xAA7550", VA = "0x180AA8950")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6012A94")]
			[Address(RVA = "0xAA8A10", Offset = "0xAA7610", VA = "0x180AA8A10")]
			set
			{
			}
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x06012A95 RID: 76437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002912")]
		protected ToggleablePassiveBuffAbility.Checker checker
		{
			[Token(Token = "0x6012A95")]
			[Address(RVA = "0xAA8870", Offset = "0xAA7470", VA = "0x180AA8870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x06012A96 RID: 76438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002913")]
		protected virtual BuffData[] unmanagedBuffsWhenToggleOn
		{
			[Token(Token = "0x6012A96")]
			[Address(RVA = "0xAA89B0", Offset = "0xAA75B0", VA = "0x180AA89B0", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012A97 RID: 76439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A97")]
		[Address(RVA = "0xAA7E00", Offset = "0xAA6A00", VA = "0x180AA7E00", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012A98 RID: 76440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A98")]
		[Address(RVA = "0xAA7D80", Offset = "0xAA6980", VA = "0x180AA7D80", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012A99 RID: 76441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A99")]
		[Address(RVA = "0xAA7FB0", Offset = "0xAA6BB0", VA = "0x180AA7FB0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012A9A RID: 76442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A9A")]
		[Address(RVA = "0xAA8330", Offset = "0xAA6F30", VA = "0x180AA8330", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A9B RID: 76443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A9B")]
		[Address(RVA = "0xAA7B80", Offset = "0xAA6780", VA = "0x180AA7B80", Slot = "61")]
		protected override void AddPassiveBuffs()
		{
		}

		// Token: 0x06012A9C RID: 76444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A9C")]
		[Address(RVA = "0xAA8080", Offset = "0xAA6C80", VA = "0x180AA8080", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012A9D RID: 76445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A9D")]
		[Address(RVA = "0xAA8270", Offset = "0xAA6E70", VA = "0x180AA8270", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012A9E RID: 76446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A9E")]
		[Address(RVA = "0xAA83F0", Offset = "0xAA6FF0", VA = "0x180AA83F0", Slot = "97")]
		protected virtual void OnToggleChanged(bool isToggled)
		{
		}

		// Token: 0x06012A9F RID: 76447 RVA: 0x00072630 File Offset: 0x00070830
		[Token(Token = "0x6012A9F")]
		[Address(RVA = "0xAA84C0", Offset = "0xAA70C0", VA = "0x180AA84C0")]
		private bool _SetToggledInternal(bool value, bool force)
		{
			return default(bool);
		}

		// Token: 0x06012AA0 RID: 76448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA0")]
		[Address(RVA = "0xAA8680", Offset = "0xAA7280", VA = "0x180AA8680")]
		private void _UpdateNextActiveTime()
		{
		}

		// Token: 0x06012AA1 RID: 76449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA1")]
		[Address(RVA = "0xAA87B0", Offset = "0xAA73B0", VA = "0x180AA87B0")]
		public ToggleablePassiveBuffAbility()
		{
		}

		// Token: 0x06012AA2 RID: 76450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA2")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012AA3 RID: 76451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA3")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012AA4 RID: 76452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA4")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x06012AA5 RID: 76453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA5")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012AA6 RID: 76454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA6")]
		[Address(RVA = "0xAA84B0", Offset = "0xAA70B0", VA = "0x180AA84B0")]
		private void <>xLuaBaseProxy_AddPassiveBuffs()
		{
		}

		// Token: 0x06012AA7 RID: 76455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA7")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012AA8 RID: 76456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AA8")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x04015188 RID: 86408
		[Token(Token = "0x4015188")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Help("HelpAttribute.IsValueNull", HelpType.Error, "Must specified a checker.")]
		private ToggleablePassiveBuffAbility.Checker _checker;

		// Token: 0x04015189 RID: 86409
		[Token(Token = "0x4015189")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private BuffData[] _unmanagedBuffsWhenToggleOn;

		// Token: 0x0401518A RID: 86410
		[Token(Token = "0x401518A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private bool _setToggleFalseOnDetached;

		// Token: 0x0401518B RID: 86411
		[Token(Token = "0x401518B")]
		[FieldOffset(Offset = "0x129")]
		[SerializeField]
		private bool _isInverseToggle;

		// Token: 0x0401518C RID: 86412
		[Token(Token = "0x401518C")]
		[FieldOffset(Offset = "0x12A")]
		private bool m_toggled;

		// Token: 0x0401518D RID: 86413
		[Token(Token = "0x401518D")]
		[FieldOffset(Offset = "0x130")]
		protected FP m_nextActiveTime;

		// Token: 0x0401518E RID: 86414
		[Token(Token = "0x401518E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_toggled;

		// Token: 0x0401518F RID: 86415
		[Token(Token = "0x401518F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_toggled;

		// Token: 0x04015190 RID: 86416
		[Token(Token = "0x4015190")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_checker;

		// Token: 0x04015191 RID: 86417
		[Token(Token = "0x4015191")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_unmanagedBuffsWhenToggleOn;

		// Token: 0x04015192 RID: 86418
		[Token(Token = "0x4015192")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015193 RID: 86419
		[Token(Token = "0x4015193")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015194 RID: 86420
		[Token(Token = "0x4015194")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015195 RID: 86421
		[Token(Token = "0x4015195")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015196 RID: 86422
		[Token(Token = "0x4015196")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AddPassiveBuffs;

		// Token: 0x04015197 RID: 86423
		[Token(Token = "0x4015197")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x04015198 RID: 86424
		[Token(Token = "0x4015198")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015199 RID: 86425
		[Token(Token = "0x4015199")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnToggleChanged;

		// Token: 0x0401519A RID: 86426
		[Token(Token = "0x401519A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetToggledInternal;

		// Token: 0x0401519B RID: 86427
		[Token(Token = "0x401519B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateNextActiveTime;

		// Token: 0x0401519C RID: 86428
		[Token(Token = "0x401519C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B6D RID: 11117
		[Token(Token = "0x2002B6D")]
		public abstract class Checker : MonoBehaviour, IHotfixable
		{
			// Token: 0x17002914 RID: 10516
			// (get) Token: 0x06012AA9 RID: 76457 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06012AAA RID: 76458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002914")]
			private protected ToggleablePassiveBuffAbility ability
			{
				[Token(Token = "0x6012AA9")]
				[Address(RVA = "0xA9F4B0", Offset = "0xA9E0B0", VA = "0x180A9F4B0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x6012AAA")]
				[Address(RVA = "0xA9F800", Offset = "0xA9E400", VA = "0x180A9F800")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002915 RID: 10517
			// (get) Token: 0x06012AAB RID: 76459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002915")]
			protected Entity owner
			{
				[Token(Token = "0x6012AAB")]
				[Address(RVA = "0xA9F670", Offset = "0xA9E270", VA = "0x180A9F670")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002916 RID: 10518
			// (get) Token: 0x06012AAC RID: 76460 RVA: 0x00072648 File Offset: 0x00070848
			// (set) Token: 0x06012AAD RID: 76461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002916")]
			protected bool toggled
			{
				[Token(Token = "0x6012AAC")]
				[Address(RVA = "0xA9F720", Offset = "0xA9E320", VA = "0x180A9F720")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6012AAD")]
				[Address(RVA = "0xA9F880", Offset = "0xA9E480", VA = "0x180A9F880")]
				set
				{
				}
			}

			// Token: 0x17002917 RID: 10519
			// (get) Token: 0x06012AAE RID: 76462 RVA: 0x00072660 File Offset: 0x00070860
			[Token(Token = "0x17002917")]
			protected FP nextActiveTime
			{
				[Token(Token = "0x6012AAE")]
				[Address(RVA = "0xA9F5C0", Offset = "0xA9E1C0", VA = "0x180A9F5C0")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17002918 RID: 10520
			// (get) Token: 0x06012AAF RID: 76463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002918")]
			protected Blackboard blackboard
			{
				[Token(Token = "0x6012AAF")]
				[Address(RVA = "0xA9F510", Offset = "0xA9E110", VA = "0x180A9F510")]
				get
				{
					return null;
				}
			}

			// Token: 0x17002919 RID: 10521
			// (get) Token: 0x06012AB0 RID: 76464 RVA: 0x00072678 File Offset: 0x00070878
			[Token(Token = "0x17002919")]
			public virtual float restoreDelay
			{
				[Token(Token = "0x6012AB0")]
				[Address(RVA = "0xA9B660", Offset = "0xA9A260", VA = "0x180A9B660", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06012AB1 RID: 76465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012AB1")]
			[Address(RVA = "0xA9F090", Offset = "0xA9DC90", VA = "0x180A9F090")]
			public void SetData(ToggleablePassiveBuffAbility ability, Blackboard blackboard)
			{
			}

			// Token: 0x06012AB2 RID: 76466
			[Token(Token = "0x6012AB2")]
			public abstract bool CheckInitialToggled();

			// Token: 0x06012AB3 RID: 76467
			[Token(Token = "0x6012AB3")]
			protected abstract void LoadData(Blackboard blackboard);

			// Token: 0x06012AB4 RID: 76468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012AB4")]
			[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
			public virtual void OnAttached()
			{
			}

			// Token: 0x06012AB5 RID: 76469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012AB5")]
			[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0", Slot = "8")]
			public virtual void OnDetached()
			{
			}

			// Token: 0x06012AB6 RID: 76470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012AB6")]
			[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850", Slot = "9")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06012AB7 RID: 76471 RVA: 0x00072690 File Offset: 0x00070890
			[Token(Token = "0x6012AB7")]
			[Address(RVA = "0xA9F190", Offset = "0xA9DD90", VA = "0x180A9F190")]
			protected bool SetToggledInternal(bool value, bool force)
			{
				return default(bool);
			}

			// Token: 0x06012AB8 RID: 76472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012AB8")]
			[Address(RVA = "0xA9F280", Offset = "0xA9DE80", VA = "0x180A9F280")]
			protected void UpdateNextActiveTime()
			{
			}

			// Token: 0x06012AB9 RID: 76473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012AB9")]
			[Address(RVA = "0xA9F450", Offset = "0xA9E050", VA = "0x180A9F450")]
			protected Checker()
			{
			}

			// Token: 0x0401519E RID: 86430
			[Token(Token = "0x401519E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_ability;

			// Token: 0x0401519F RID: 86431
			[Token(Token = "0x401519F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_ability;

			// Token: 0x040151A0 RID: 86432
			[Token(Token = "0x40151A0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x040151A1 RID: 86433
			[Token(Token = "0x40151A1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_toggled;

			// Token: 0x040151A2 RID: 86434
			[Token(Token = "0x40151A2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_toggled;

			// Token: 0x040151A3 RID: 86435
			[Token(Token = "0x40151A3")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_nextActiveTime;

			// Token: 0x040151A4 RID: 86436
			[Token(Token = "0x40151A4")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_blackboard;

			// Token: 0x040151A5 RID: 86437
			[Token(Token = "0x40151A5")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_restoreDelay;

			// Token: 0x040151A6 RID: 86438
			[Token(Token = "0x40151A6")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x040151A7 RID: 86439
			[Token(Token = "0x40151A7")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnAttached;

			// Token: 0x040151A8 RID: 86440
			[Token(Token = "0x40151A8")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnDetached;

			// Token: 0x040151A9 RID: 86441
			[Token(Token = "0x40151A9")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x040151AA RID: 86442
			[Token(Token = "0x40151AA")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_SetToggledInternal;

			// Token: 0x040151AB RID: 86443
			[Token(Token = "0x40151AB")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_UpdateNextActiveTime;

			// Token: 0x040151AC RID: 86444
			[Token(Token = "0x40151AC")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
