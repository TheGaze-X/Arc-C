using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002501 RID: 9473
	[Token(Token = "0x2002501")]
	public class BlockedOrAdvancedSelectorWithRestPostSort : BlockedOrAdvancedSelector
	{
		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x0600F3F9 RID: 62457 RVA: 0x00059FA0 File Offset: 0x000581A0
		[Token(Token = "0x17001FC3")]
		private bool hasPriorAbnormalFlag
		{
			[Token(Token = "0x600F3F9")]
			[Address(RVA = "0x6B6040", Offset = "0x6B4C40", VA = "0x1806B6040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F3FA RID: 62458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3FA")]
		[Address(RVA = "0x6B5A00", Offset = "0x6B4600", VA = "0x1806B5A00", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3FB RID: 62459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3FB")]
		[Address(RVA = "0x6B5FD0", Offset = "0x6B4BD0", VA = "0x1806B5FD0")]
		public BlockedOrAdvancedSelectorWithRestPostSort()
		{
		}

		// Token: 0x0600F3FE RID: 62462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3FE")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010E29 RID: 69161
		[Token(Token = "0x4010E29")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private string _postSortTag;

		// Token: 0x04010E2A RID: 69162
		[Token(Token = "0x4010E2A")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private string _excludeBuffKey;

		// Token: 0x04010E2B RID: 69163
		[Token(Token = "0x4010E2B")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _hasPriorAbnormalFlag;

		// Token: 0x04010E2C RID: 69164
		[Token(Token = "0x4010E2C")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[Inspect("hasPriorAbnormalFlag")]
		private AbnormalFlag _priorAbnormalFlag;

		// Token: 0x04010E2D RID: 69165
		[Token(Token = "0x4010E2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasPriorAbnormalFlag;

		// Token: 0x04010E2E RID: 69166
		[Token(Token = "0x4010E2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010E2F RID: 69167
		[Token(Token = "0x4010E2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
