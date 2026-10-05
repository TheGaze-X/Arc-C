using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200257A RID: 9594
	[Token(Token = "0x200257A")]
	public class AttributeTargetValidator : TargetValidator
	{
		// Token: 0x0600F79B RID: 63387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F79B")]
		[Address(RVA = "0x6EF970", Offset = "0x6EE570", VA = "0x1806EF970", Slot = "4")]
		public override void SetData(Entity owner, Blackboard blackboard, bool ignoreTargetSide)
		{
		}

		// Token: 0x0600F79C RID: 63388 RVA: 0x0005C910 File Offset: 0x0005AB10
		[Token(Token = "0x600F79C")]
		[Address(RVA = "0x6EFBA0", Offset = "0x6EE7A0", VA = "0x1806EFBA0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F79D RID: 63389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F79D")]
		[Address(RVA = "0x6EFD60", Offset = "0x6EE960", VA = "0x1806EFD60")]
		public AttributeTargetValidator()
		{
		}

		// Token: 0x0600F79E RID: 63390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F79E")]
		[Address(RVA = "0x6EFB90", Offset = "0x6EE790", VA = "0x1806EFB90")]
		private void <>xLuaBaseProxy_SetData(Entity P0, Blackboard P1, bool P2)
		{
		}

		// Token: 0x0600F79F RID: 63391 RVA: 0x0005C928 File Offset: 0x0005AB28
		[Token(Token = "0x600F79F")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011322 RID: 70434
		[Token(Token = "0x4011322")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _blackboardPrefix;

		// Token: 0x04011323 RID: 70435
		[Token(Token = "0x4011323")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AttributeTargetValidator.AttributeCondition[] _conditions;

		// Token: 0x04011324 RID: 70436
		[Token(Token = "0x4011324")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04011325 RID: 70437
		[Token(Token = "0x4011325")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011326 RID: 70438
		[Token(Token = "0x4011326")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200257B RID: 9595
		[Token(Token = "0x200257B")]
		[Serializable]
		public class AttributeCondition
		{
			// Token: 0x0600F7A0 RID: 63392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F7A0")]
			[Address(RVA = "0x6EF960", Offset = "0x6EE560", VA = "0x1806EF960")]
			public AttributeCondition()
			{
			}

			// Token: 0x04011327 RID: 70439
			[Token(Token = "0x4011327")]
			[FieldOffset(Offset = "0x10")]
			public AttributeType attributeType;

			// Token: 0x04011328 RID: 70440
			[Token(Token = "0x4011328")]
			[FieldOffset(Offset = "0x14")]
			public CompareType compareType;

			// Token: 0x04011329 RID: 70441
			[Token(Token = "0x4011329")]
			[FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public float requiredValue;
		}
	}
}
