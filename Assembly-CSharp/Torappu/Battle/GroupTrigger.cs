using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002564 RID: 9572
	[Token(Token = "0x2002564")]
	public class GroupTrigger : TargetTrigger
	{
		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x0600F710 RID: 63248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002064")]
		public override Entity target
		{
			[Token(Token = "0x600F710")]
			[Address(RVA = "0x70DC80", Offset = "0x70C880", VA = "0x18070DC80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x0600F711 RID: 63249 RVA: 0x0005C310 File Offset: 0x0005A510
		[Token(Token = "0x17002065")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F711")]
			[Address(RVA = "0x70DB30", Offset = "0x70C730", VA = "0x18070DB30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x0600F712 RID: 63250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002066")]
		public override TargetSelector selector
		{
			[Token(Token = "0x600F712")]
			[Address(RVA = "0x70DBA0", Offset = "0x70C7A0", VA = "0x18070DBA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F713 RID: 63251 RVA: 0x0005C328 File Offset: 0x0005A528
		[Token(Token = "0x600F713")]
		[Address(RVA = "0x70D370", Offset = "0x70BF70", VA = "0x18070D370", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F714 RID: 63252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F714")]
		[Address(RVA = "0x70D520", Offset = "0x70C120", VA = "0x18070D520", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F715 RID: 63253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F715")]
		[Address(RVA = "0x70D880", Offset = "0x70C480", VA = "0x18070D880", Slot = "11")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F716 RID: 63254 RVA: 0x0005C340 File Offset: 0x0005A540
		[Token(Token = "0x600F716")]
		[Address(RVA = "0x70D660", Offset = "0x70C260", VA = "0x18070D660", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F717 RID: 63255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F717")]
		[Address(RVA = "0x70DA60", Offset = "0x70C660", VA = "0x18070DA60")]
		public GroupTrigger()
		{
		}

		// Token: 0x0600F718 RID: 63256 RVA: 0x0005C358 File Offset: 0x0005A558
		[Token(Token = "0x600F718")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0600F719 RID: 63257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F719")]
		[Address(RVA = "0x70DA00", Offset = "0x70C600", VA = "0x18070DA00")]
		private TargetSelector <>xLuaBaseProxy_get_selector()
		{
			return null;
		}

		// Token: 0x0600F71A RID: 63258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F71A")]
		[Address(RVA = "0x6F3400", Offset = "0x6F2000", VA = "0x1806F3400")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x0600F71B RID: 63259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F71B")]
		[Address(RVA = "0x70D9A0", Offset = "0x70C5A0", VA = "0x18070D9A0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0401126F RID: 70255
		[Token(Token = "0x401126F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TargetTrigger[] _triggers;

		// Token: 0x04011270 RID: 70256
		[Token(Token = "0x4011270")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GroupTrigger.CheckType _checkType;

		// Token: 0x04011271 RID: 70257
		[Token(Token = "0x4011271")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _resetTriggers;

		// Token: 0x04011272 RID: 70258
		[Token(Token = "0x4011272")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _isOverrideSelector;

		// Token: 0x04011273 RID: 70259
		[Token(Token = "0x4011273")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TargetSelector _overrideSelector;

		// Token: 0x04011274 RID: 70260
		[Token(Token = "0x4011274")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useRealCheckTargetIn;

		// Token: 0x04011275 RID: 70261
		[Token(Token = "0x4011275")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPtr<Entity> m_lastTarget;

		// Token: 0x04011276 RID: 70262
		[Token(Token = "0x4011276")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04011277 RID: 70263
		[Token(Token = "0x4011277")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x04011278 RID: 70264
		[Token(Token = "0x4011278")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selector;

		// Token: 0x04011279 RID: 70265
		[Token(Token = "0x4011279")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x0401127A RID: 70266
		[Token(Token = "0x401127A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401127B RID: 70267
		[Token(Token = "0x401127B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401127C RID: 70268
		[Token(Token = "0x401127C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x0401127D RID: 70269
		[Token(Token = "0x401127D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002565 RID: 9573
		[Token(Token = "0x2002565")]
		public enum CheckType
		{
			// Token: 0x0401127F RID: 70271
			[Token(Token = "0x401127F")]
			AT_LEAST_ONE,
			// Token: 0x04011280 RID: 70272
			[Token(Token = "0x4011280")]
			ALL
		}
	}
}
