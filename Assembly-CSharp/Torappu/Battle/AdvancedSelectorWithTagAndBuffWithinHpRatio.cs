using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F7 RID: 9463
	[Token(Token = "0x20024F7")]
	public class AdvancedSelectorWithTagAndBuffWithinHpRatio : AdvancedSelectorWithinHpRatio
	{
		// Token: 0x0600F3C2 RID: 62402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C2")]
		[Address(RVA = "0x6A1200", Offset = "0x69FE00", VA = "0x1806A1200", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3C3 RID: 62403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C3")]
		[Address(RVA = "0x6A1440", Offset = "0x6A0040", VA = "0x1806A1440")]
		public AdvancedSelectorWithTagAndBuffWithinHpRatio()
		{
		}

		// Token: 0x0600F3C4 RID: 62404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C4")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DEB RID: 69099
		[Token(Token = "0x4010DEB")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _tagExcluded;

		// Token: 0x04010DEC RID: 69100
		[Token(Token = "0x4010DEC")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private string _filterTag;

		// Token: 0x04010DED RID: 69101
		[Token(Token = "0x4010DED")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _buffKeyExcluded;

		// Token: 0x04010DEE RID: 69102
		[Token(Token = "0x4010DEE")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x04010DEF RID: 69103
		[Token(Token = "0x4010DEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DF0 RID: 69104
		[Token(Token = "0x4010DF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
