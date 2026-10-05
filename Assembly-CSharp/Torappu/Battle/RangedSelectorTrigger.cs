using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200256F RID: 9583
	[Token(Token = "0x200256F")]
	[RequireComponent(typeof(RangeSelector))]
	public class RangedSelectorTrigger : SelectorTrigger
	{
		// Token: 0x0600F74A RID: 63306 RVA: 0x0005C5C8 File Offset: 0x0005A7C8
		[Token(Token = "0x600F74A")]
		[Address(RVA = "0x713660", Offset = "0x712260", VA = "0x180713660", Slot = "16")]
		protected override bool Validator(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F74B RID: 63307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F74B")]
		[Address(RVA = "0x7135C0", Offset = "0x7121C0", VA = "0x1807135C0", Slot = "17")]
		protected override void Awake()
		{
		}

		// Token: 0x0600F74C RID: 63308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F74C")]
		[Address(RVA = "0x713780", Offset = "0x712380", VA = "0x180713780")]
		public RangedSelectorTrigger()
		{
		}

		// Token: 0x0600F74D RID: 63309 RVA: 0x0005C5E0 File Offset: 0x0005A7E0
		[Token(Token = "0x600F74D")]
		[Address(RVA = "0x709C90", Offset = "0x708890", VA = "0x180709C90")]
		private bool <>xLuaBaseProxy_Validator(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0600F74E RID: 63310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F74E")]
		[Address(RVA = "0x713650", Offset = "0x712250", VA = "0x180713650")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x040112BB RID: 70331
		[Token(Token = "0x40112BB")]
		[FieldOffset(Offset = "0x50")]
		private RangeSelector m_rangeSelector;

		// Token: 0x040112BC RID: 70332
		[Token(Token = "0x40112BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validator;

		// Token: 0x040112BD RID: 70333
		[Token(Token = "0x40112BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040112BE RID: 70334
		[Token(Token = "0x40112BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
