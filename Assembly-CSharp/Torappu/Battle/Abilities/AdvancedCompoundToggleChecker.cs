using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B54 RID: 11092
	[Token(Token = "0x2002B54")]
	public class AdvancedCompoundToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x060129DF RID: 76255 RVA: 0x00072090 File Offset: 0x00070290
		[Token(Token = "0x17002907")]
		public bool disableWhenAppliedModifier
		{
			[Token(Token = "0x60129DF")]
			[Address(RVA = "0xA9BCD0", Offset = "0xA9A8D0", VA = "0x180A9BCD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x060129E0 RID: 76256 RVA: 0x000720A8 File Offset: 0x000702A8
		[Token(Token = "0x17002908")]
		public override float restoreDelay
		{
			[Token(Token = "0x60129E0")]
			[Address(RVA = "0xA9BD30", Offset = "0xA9A930", VA = "0x180A9BD30", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060129E1 RID: 76257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129E1")]
		[Address(RVA = "0xA9AB30", Offset = "0xA99730", VA = "0x180A9AB30", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x060129E2 RID: 76258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129E2")]
		[Address(RVA = "0xA9ABE0", Offset = "0xA997E0", VA = "0x180A9ABE0", Slot = "7")]
		public override void OnAttached()
		{
		}

		// Token: 0x060129E3 RID: 76259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129E3")]
		[Address(RVA = "0xA9AE40", Offset = "0xA99A40", VA = "0x180A9AE40", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x060129E4 RID: 76260 RVA: 0x000720C0 File Offset: 0x000702C0
		[Token(Token = "0x60129E4")]
		[Address(RVA = "0xA9AAD0", Offset = "0xA996D0", VA = "0x180A9AAD0", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x060129E5 RID: 76261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129E5")]
		[Address(RVA = "0xA9B0A0", Offset = "0xA99CA0", VA = "0x180A9B0A0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060129E6 RID: 76262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129E6")]
		[Address(RVA = "0xA9B8D0", Offset = "0xA9A4D0", VA = "0x180A9B8D0")]
		private void _OnOutputDamage(object arg)
		{
		}

		// Token: 0x060129E7 RID: 76263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129E7")]
		[Address(RVA = "0xA9B9A0", Offset = "0xA9A5A0", VA = "0x180A9B9A0")]
		private void _OnOutputHeal(object arg)
		{
		}

		// Token: 0x060129E8 RID: 76264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129E8")]
		[Address(RVA = "0xA9BB60", Offset = "0xA9A760", VA = "0x180A9BB60")]
		private void _OnTakeDamage(object arg)
		{
		}

		// Token: 0x060129E9 RID: 76265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129E9")]
		[Address(RVA = "0xA9B6C0", Offset = "0xA9A2C0", VA = "0x180A9B6C0")]
		private void _OnAppliedModifier(object arg)
		{
		}

		// Token: 0x060129EA RID: 76266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129EA")]
		[Address(RVA = "0xA9BC30", Offset = "0xA9A830", VA = "0x180A9BC30")]
		public AdvancedCompoundToggleChecker()
		{
		}

		// Token: 0x060129EB RID: 76267 RVA: 0x000720D8 File Offset: 0x000702D8
		[Token(Token = "0x60129EB")]
		[Address(RVA = "0xA9B660", Offset = "0xA9A260", VA = "0x180A9B660")]
		private float <>xLuaBaseProxy_get_restoreDelay()
		{
			return 0f;
		}

		// Token: 0x060129EC RID: 76268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129EC")]
		[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x060129ED RID: 76269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129ED")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060129EE RID: 76270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129EE")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401508A RID: 86154
		[Token(Token = "0x401508A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isInitToggled;

		// Token: 0x0401508B RID: 86155
		[Token(Token = "0x401508B")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _disableWhenAttack;

		// Token: 0x0401508C RID: 86156
		[Token(Token = "0x401508C")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _disableWhenBlocked;

		// Token: 0x0401508D RID: 86157
		[Token(Token = "0x401508D")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		private bool _disableWhenInAttackState;

		// Token: 0x0401508E RID: 86158
		[Token(Token = "0x401508E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _disableWhenInCombatState;

		// Token: 0x0401508F RID: 86159
		[Token(Token = "0x401508F")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _disableWhenOutputHeal;

		// Token: 0x04015090 RID: 86160
		[Token(Token = "0x4015090")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		private bool _disableWhenTakeDamage;

		// Token: 0x04015091 RID: 86161
		[Token(Token = "0x4015091")]
		[FieldOffset(Offset = "0x27")]
		[SerializeField]
		private bool _disableWhenAppliedModifier;

		// Token: 0x04015092 RID: 86162
		[Token(Token = "0x4015092")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inspect("disableWhenAppliedModifier")]
		private bool _disableWhenAppliedDamageModifier;

		// Token: 0x04015093 RID: 86163
		[Token(Token = "0x4015093")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _disableWhenMoving;

		// Token: 0x04015094 RID: 86164
		[Token(Token = "0x4015094")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _restoreDelay;

		// Token: 0x04015095 RID: 86165
		[Token(Token = "0x4015095")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _disableDuringReborn;

		// Token: 0x04015096 RID: 86166
		[Token(Token = "0x4015096")]
		[FieldOffset(Offset = "0x34")]
		private float m_restoreDelay;

		// Token: 0x04015097 RID: 86167
		[Token(Token = "0x4015097")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableWhenAppliedModifier;

		// Token: 0x04015098 RID: 86168
		[Token(Token = "0x4015098")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_restoreDelay;

		// Token: 0x04015099 RID: 86169
		[Token(Token = "0x4015099")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401509A RID: 86170
		[Token(Token = "0x401509A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x0401509B RID: 86171
		[Token(Token = "0x401509B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x0401509C RID: 86172
		[Token(Token = "0x401509C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x0401509D RID: 86173
		[Token(Token = "0x401509D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401509E RID: 86174
		[Token(Token = "0x401509E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnOutputDamage;

		// Token: 0x0401509F RID: 86175
		[Token(Token = "0x401509F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnOutputHeal;

		// Token: 0x040150A0 RID: 86176
		[Token(Token = "0x40150A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnTakeDamage;

		// Token: 0x040150A1 RID: 86177
		[Token(Token = "0x40150A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnAppliedModifier;

		// Token: 0x040150A2 RID: 86178
		[Token(Token = "0x40150A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
