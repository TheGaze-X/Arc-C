using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002589 RID: 9609
	[Token(Token = "0x2002589")]
	public class OblvnsAttackRangeValidator : FilterGroupTagTargetValidator
	{
		// Token: 0x0600F7CB RID: 63435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7CB")]
		[Address(RVA = "0x711500", Offset = "0x710100", VA = "0x180711500", Slot = "4")]
		public override void SetData(Entity owner, Blackboard blackboard, bool ignoreTargetSide)
		{
		}

		// Token: 0x0600F7CC RID: 63436 RVA: 0x0005CBC8 File Offset: 0x0005ADC8
		[Token(Token = "0x600F7CC")]
		[Address(RVA = "0x7116A0", Offset = "0x7102A0", VA = "0x1807116A0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7CD RID: 63437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7CD")]
		[Address(RVA = "0x711990", Offset = "0x710590", VA = "0x180711990")]
		public OblvnsAttackRangeValidator()
		{
		}

		// Token: 0x0600F7CE RID: 63438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7CE")]
		[Address(RVA = "0x6EFB90", Offset = "0x6EE790", VA = "0x1806EFB90")]
		private void <>xLuaBaseProxy_SetData(Entity P0, Blackboard P1, bool P2)
		{
		}

		// Token: 0x0600F7CF RID: 63439 RVA: 0x0005CBE0 File Offset: 0x0005ADE0
		[Token(Token = "0x600F7CF")]
		[Address(RVA = "0x711690", Offset = "0x710290", VA = "0x180711690")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401135A RID: 70490
		[Token(Token = "0x401135A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _excludeSelf;

		// Token: 0x0401135B RID: 70491
		[Token(Token = "0x401135B")]
		[FieldOffset(Offset = "0xA0")]
		private Character m_characterOwner;

		// Token: 0x0401135C RID: 70492
		[Token(Token = "0x401135C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401135D RID: 70493
		[Token(Token = "0x401135D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401135E RID: 70494
		[Token(Token = "0x401135E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
