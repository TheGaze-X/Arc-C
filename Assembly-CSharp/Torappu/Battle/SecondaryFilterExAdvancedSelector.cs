using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002526 RID: 9510
	[Token(Token = "0x2002526")]
	public class SecondaryFilterExAdvancedSelector : AdvancedSelector
	{
		// Token: 0x0600F57E RID: 62846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F57E")]
		[Address(RVA = "0x6DA4B0", Offset = "0x6D90B0", VA = "0x1806DA4B0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F57F RID: 62847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F57F")]
		[Address(RVA = "0x6DA8A0", Offset = "0x6D94A0", VA = "0x1806DA8A0")]
		private void _CheckSecondFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F580 RID: 62848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F580")]
		[Address(RVA = "0x6DA970", Offset = "0x6D9570", VA = "0x1806DA970")]
		public SecondaryFilterExAdvancedSelector()
		{
		}

		// Token: 0x0600F581 RID: 62849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F581")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x0401102A RID: 69674
		[Token(Token = "0x401102A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SecondaryFilterExAdvancedSelector.SecondaryFilterExType _secondaryFilterEx;

		// Token: 0x0401102B RID: 69675
		[Token(Token = "0x401102B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x0401102C RID: 69676
		[Token(Token = "0x401102C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckSecondFilter;

		// Token: 0x0401102D RID: 69677
		[Token(Token = "0x401102D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002527 RID: 9511
		[Token(Token = "0x2002527")]
		private enum SecondaryFilterExType
		{
			// Token: 0x0401102F RID: 69679
			[Token(Token = "0x401102F")]
			INSERT_THE_LAST_AT_FRONT
		}
	}
}
