using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002588 RID: 9608
	[Token(Token = "0x2002588")]
	public class MultiTargetValidator : TargetValidator
	{
		// Token: 0x0600F7C6 RID: 63430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7C6")]
		[Address(RVA = "0x710EB0", Offset = "0x70FAB0", VA = "0x180710EB0", Slot = "4")]
		public override void SetData(Entity owner, Blackboard blackboard, bool ignoreTargetSide)
		{
		}

		// Token: 0x0600F7C7 RID: 63431 RVA: 0x0005CB98 File Offset: 0x0005AD98
		[Token(Token = "0x600F7C7")]
		[Address(RVA = "0x7110A0", Offset = "0x70FCA0", VA = "0x1807110A0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7C8 RID: 63432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7C8")]
		[Address(RVA = "0x711270", Offset = "0x70FE70", VA = "0x180711270")]
		public MultiTargetValidator()
		{
		}

		// Token: 0x0600F7C9 RID: 63433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7C9")]
		[Address(RVA = "0x6EFB90", Offset = "0x6EE790", VA = "0x1806EFB90")]
		private void <>xLuaBaseProxy_SetData(Entity P0, Blackboard P1, bool P2)
		{
		}

		// Token: 0x0600F7CA RID: 63434 RVA: 0x0005CBB0 File Offset: 0x0005ADB0
		[Token(Token = "0x600F7CA")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011354 RID: 70484
		[Token(Token = "0x4011354")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _isAnd;

		// Token: 0x04011355 RID: 70485
		[Token(Token = "0x4011355")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TargetValidator[] _validators;

		// Token: 0x04011356 RID: 70486
		[Token(Token = "0x4011356")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TargetValidator[] _invertedValidators;

		// Token: 0x04011357 RID: 70487
		[Token(Token = "0x4011357")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04011358 RID: 70488
		[Token(Token = "0x4011358")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011359 RID: 70489
		[Token(Token = "0x4011359")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
