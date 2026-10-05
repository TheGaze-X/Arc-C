using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002571 RID: 9585
	[Token(Token = "0x2002571")]
	[RequireComponent(typeof(TargetSelector))]
	public class SelectorTrigger : TargetTrigger
	{
		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x0600F756 RID: 63318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002073")]
		public override Entity target
		{
			[Token(Token = "0x600F756")]
			[Address(RVA = "0x714AB0", Offset = "0x7136B0", VA = "0x180714AB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x0600F757 RID: 63319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002074")]
		protected Entity owner
		{
			[Token(Token = "0x600F757")]
			[Address(RVA = "0x7149E0", Offset = "0x7135E0", VA = "0x1807149E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x0600F758 RID: 63320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002075")]
		public override TargetSelector selector
		{
			[Token(Token = "0x600F758")]
			[Address(RVA = "0x714A50", Offset = "0x713650", VA = "0x180714A50", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F759 RID: 63321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F759")]
		[Address(RVA = "0x714550", Offset = "0x713150", VA = "0x180714550", Slot = "11")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F75A RID: 63322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F75A")]
		[Address(RVA = "0x714030", Offset = "0x712C30", VA = "0x180714030", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F75B RID: 63323 RVA: 0x0005C658 File Offset: 0x0005A858
		[Token(Token = "0x600F75B")]
		[Address(RVA = "0x714210", Offset = "0x712E10", VA = "0x180714210", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F75C RID: 63324 RVA: 0x0005C670 File Offset: 0x0005A870
		[Token(Token = "0x600F75C")]
		[Address(RVA = "0x713E40", Offset = "0x712A40", VA = "0x180713E40", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F75D RID: 63325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F75D")]
		[Address(RVA = "0x713F50", Offset = "0x712B50", VA = "0x180713F50", Slot = "15")]
		public override void OnAbilityExtendUpdated(FP extend)
		{
		}

		// Token: 0x0600F75E RID: 63326 RVA: 0x0005C688 File Offset: 0x0005A888
		[Token(Token = "0x600F75E")]
		[Address(RVA = "0x714690", Offset = "0x713290", VA = "0x180714690", Slot = "16")]
		protected virtual bool Validator(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F75F RID: 63327 RVA: 0x0005C6A0 File Offset: 0x0005A8A0
		[Token(Token = "0x600F75F")]
		[Address(RVA = "0x714760", Offset = "0x713360", VA = "0x180714760")]
		protected bool _IsHiddenToOwner(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F760 RID: 63328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F760")]
		[Address(RVA = "0x713DC0", Offset = "0x7129C0", VA = "0x180713DC0", Slot = "17")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600F761 RID: 63329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F761")]
		[Address(RVA = "0x713EE0", Offset = "0x712AE0", VA = "0x180713EE0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600F762 RID: 63330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F762")]
		[Address(RVA = "0x7148B0", Offset = "0x7134B0", VA = "0x1807148B0")]
		public SelectorTrigger()
		{
		}

		// Token: 0x0600F763 RID: 63331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F763")]
		[Address(RVA = "0x70DA00", Offset = "0x70C600", VA = "0x18070DA00")]
		private TargetSelector <>xLuaBaseProxy_get_selector()
		{
			return null;
		}

		// Token: 0x0600F764 RID: 63332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F764")]
		[Address(RVA = "0x70D9A0", Offset = "0x70C5A0", VA = "0x18070D9A0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F765 RID: 63333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F765")]
		[Address(RVA = "0x6F3400", Offset = "0x6F2000", VA = "0x1806F3400")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x0600F766 RID: 63334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F766")]
		[Address(RVA = "0x714630", Offset = "0x713230", VA = "0x180714630")]
		private void <>xLuaBaseProxy_OnAbilityExtendUpdated(FP P0)
		{
		}

		// Token: 0x040112C4 RID: 70340
		[Token(Token = "0x40112C4")]
		protected const int SEARCH_TARGET_TICK = 3;

		// Token: 0x040112C5 RID: 70341
		[Token(Token = "0x40112C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _keepTarget;

		// Token: 0x040112C6 RID: 70342
		[Token(Token = "0x40112C6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _minTargetNum;

		// Token: 0x040112C7 RID: 70343
		[Token(Token = "0x40112C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Override internal search tick's period if this is >= 0")]
		private int _overrideSearchTargetTick;

		// Token: 0x040112C8 RID: 70344
		[Token(Token = "0x40112C8")]
		[FieldOffset(Offset = "0x30")]
		private TargetSelector m_selector;

		// Token: 0x040112C9 RID: 70345
		[Token(Token = "0x40112C9")]
		[FieldOffset(Offset = "0x38")]
		protected ObjectPtr<Entity> m_lastTarget;

		// Token: 0x040112CA RID: 70346
		[Token(Token = "0x40112CA")]
		[FieldOffset(Offset = "0x48")]
		protected CompoundPeriodicTicker m_findTargetTicker;

		// Token: 0x040112CB RID: 70347
		[Token(Token = "0x40112CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x040112CC RID: 70348
		[Token(Token = "0x40112CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x040112CD RID: 70349
		[Token(Token = "0x40112CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selector;

		// Token: 0x040112CE RID: 70350
		[Token(Token = "0x40112CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040112CF RID: 70351
		[Token(Token = "0x40112CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040112D0 RID: 70352
		[Token(Token = "0x40112D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x040112D1 RID: 70353
		[Token(Token = "0x40112D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x040112D2 RID: 70354
		[Token(Token = "0x40112D2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnAbilityExtendUpdated;

		// Token: 0x040112D3 RID: 70355
		[Token(Token = "0x40112D3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Validator;

		// Token: 0x040112D4 RID: 70356
		[Token(Token = "0x40112D4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__IsHiddenToOwner;

		// Token: 0x040112D5 RID: 70357
		[Token(Token = "0x40112D5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040112D6 RID: 70358
		[Token(Token = "0x40112D6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x040112D7 RID: 70359
		[Token(Token = "0x40112D7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
