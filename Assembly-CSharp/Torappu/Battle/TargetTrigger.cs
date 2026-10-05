using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002575 RID: 9589
	[Token(Token = "0x2002575")]
	public abstract class TargetTrigger : MonoBehaviour, IDrawableRange, IHotfixable
	{
		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x0600F777 RID: 63351
		[Token(Token = "0x1700207B")]
		public abstract Entity target { [Token(Token = "0x600F777")] get; }

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x0600F778 RID: 63352 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F779 RID: 63353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700207C")]
		public Ability ability
		{
			[Token(Token = "0x600F778")]
			[Address(RVA = "0x715D70", Offset = "0x714970", VA = "0x180715D70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600F779")]
			[Address(RVA = "0x715E80", Offset = "0x714A80", VA = "0x180715E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x0600F77A RID: 63354 RVA: 0x0005C790 File Offset: 0x0005A990
		[Token(Token = "0x1700207D")]
		public virtual bool isReadyToTrig
		{
			[Token(Token = "0x600F77A")]
			[Address(RVA = "0x715DD0", Offset = "0x7149D0", VA = "0x180715DD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x0600F77B RID: 63355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700207E")]
		public virtual TargetSelector selector
		{
			[Token(Token = "0x600F77B")]
			[Address(RVA = "0x70DA00", Offset = "0x70C600", VA = "0x18070DA00", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F77C RID: 63356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F77C")]
		[Address(RVA = "0x70D9A0", Offset = "0x70C5A0", VA = "0x18070D9A0", Slot = "11")]
		public virtual void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F77D RID: 63357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F77D")]
		[Address(RVA = "0x715C30", Offset = "0x714830", VA = "0x180715C30", Slot = "12")]
		public virtual void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F77E RID: 63358
		[Token(Token = "0x600F77E")]
		public abstract bool Search(bool force = false);

		// Token: 0x0600F77F RID: 63359
		[Token(Token = "0x600F77F")]
		public abstract bool CheckTargetIn(ILocatable target);

		// Token: 0x0600F780 RID: 63360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F780")]
		[Address(RVA = "0x714630", Offset = "0x713230", VA = "0x180714630", Slot = "15")]
		public virtual void OnAbilityExtendUpdated(FP extend)
		{
		}

		// Token: 0x0600F781 RID: 63361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F781")]
		[Address(RVA = "0x715D10", Offset = "0x714910", VA = "0x180715D10")]
		protected TargetTrigger()
		{
		}

		// Token: 0x040112F3 RID: 70387
		[Token(Token = "0x40112F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ability;

		// Token: 0x040112F4 RID: 70388
		[Token(Token = "0x40112F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ability;

		// Token: 0x040112F5 RID: 70389
		[Token(Token = "0x40112F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x040112F6 RID: 70390
		[Token(Token = "0x40112F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selector;

		// Token: 0x040112F7 RID: 70391
		[Token(Token = "0x40112F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040112F8 RID: 70392
		[Token(Token = "0x40112F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040112F9 RID: 70393
		[Token(Token = "0x40112F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnAbilityExtendUpdated;

		// Token: 0x040112FA RID: 70394
		[Token(Token = "0x40112FA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
