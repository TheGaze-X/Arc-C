using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002573 RID: 9587
	[Token(Token = "0x2002573")]
	public class SpTrigger : TargetTrigger
	{
		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x0600F76C RID: 63340 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F76D RID: 63341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002078")]
		public Entity owner
		{
			[Token(Token = "0x600F76C")]
			[Address(RVA = "0x715370", Offset = "0x713F70", VA = "0x180715370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600F76D")]
			[Address(RVA = "0x715430", Offset = "0x714030", VA = "0x180715430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600F76E RID: 63342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002079")]
		public override Entity target
		{
			[Token(Token = "0x600F76E")]
			[Address(RVA = "0x7153D0", Offset = "0x713FD0", VA = "0x1807153D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600F76F RID: 63343 RVA: 0x0005C718 File Offset: 0x0005A918
		[Token(Token = "0x1700207A")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F76F")]
			[Address(RVA = "0x715310", Offset = "0x713F10", VA = "0x180715310", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F770 RID: 63344 RVA: 0x0005C730 File Offset: 0x0005A930
		[Token(Token = "0x600F770")]
		[Address(RVA = "0x714EA0", Offset = "0x713AA0", VA = "0x180714EA0")]
		private bool CheckReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0600F771 RID: 63345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F771")]
		[Address(RVA = "0x7150E0", Offset = "0x713CE0", VA = "0x1807150E0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F772 RID: 63346 RVA: 0x0005C748 File Offset: 0x0005A948
		[Token(Token = "0x600F772")]
		[Address(RVA = "0x7151E0", Offset = "0x713DE0", VA = "0x1807151E0", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F773 RID: 63347 RVA: 0x0005C760 File Offset: 0x0005A960
		[Token(Token = "0x600F773")]
		[Address(RVA = "0x715050", Offset = "0x713C50", VA = "0x180715050", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F774 RID: 63348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F774")]
		[Address(RVA = "0x715270", Offset = "0x713E70", VA = "0x180715270")]
		public SpTrigger()
		{
		}

		// Token: 0x0600F775 RID: 63349 RVA: 0x0005C778 File Offset: 0x0005A978
		[Token(Token = "0x600F775")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0600F776 RID: 63350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F776")]
		[Address(RVA = "0x6F3400", Offset = "0x6F2000", VA = "0x1806F3400")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x040112E2 RID: 70370
		[Token(Token = "0x40112E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpTrigger.SpValueType _spValueType;

		// Token: 0x040112E3 RID: 70371
		[Token(Token = "0x40112E3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _valueToCompare;

		// Token: 0x040112E4 RID: 70372
		[Token(Token = "0x40112E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CompareType _compareType;

		// Token: 0x040112E6 RID: 70374
		[Token(Token = "0x40112E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x040112E7 RID: 70375
		[Token(Token = "0x40112E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_owner;

		// Token: 0x040112E8 RID: 70376
		[Token(Token = "0x40112E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x040112E9 RID: 70377
		[Token(Token = "0x40112E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x040112EA RID: 70378
		[Token(Token = "0x40112EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckReadyToTrig;

		// Token: 0x040112EB RID: 70379
		[Token(Token = "0x40112EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040112EC RID: 70380
		[Token(Token = "0x40112EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x040112ED RID: 70381
		[Token(Token = "0x40112ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x040112EE RID: 70382
		[Token(Token = "0x40112EE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002574 RID: 9588
		[Token(Token = "0x2002574")]
		public enum SpValueType
		{
			// Token: 0x040112F0 RID: 70384
			[Token(Token = "0x40112F0")]
			Value,
			// Token: 0x040112F1 RID: 70385
			[Token(Token = "0x40112F1")]
			ChargeLayer
		}
	}
}
