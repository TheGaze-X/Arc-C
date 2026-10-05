using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F6 RID: 9462
	[Token(Token = "0x20024F6")]
	public class AdvancedSelectorWithTagAndBuffKey : AdvancedSelector
	{
		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x0600F3BD RID: 62397 RVA: 0x00059E50 File Offset: 0x00058050
		[Token(Token = "0x17001FBE")]
		private bool buffsNotEmpty
		{
			[Token(Token = "0x600F3BD")]
			[Address(RVA = "0x6A1180", Offset = "0x69FD80", VA = "0x1806A1180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F3BE RID: 62398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3BE")]
		[Address(RVA = "0x6A0960", Offset = "0x69F560", VA = "0x1806A0960", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3BF RID: 62399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3BF")]
		[Address(RVA = "0x6A0E50", Offset = "0x69FA50", VA = "0x1806A0E50")]
		private void _CheckBuff(List<Entity> candidates, string buffKey)
		{
		}

		// Token: 0x0600F3C0 RID: 62400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C0")]
		[Address(RVA = "0x6A10C0", Offset = "0x69FCC0", VA = "0x1806A10C0")]
		public AdvancedSelectorWithTagAndBuffKey()
		{
		}

		// Token: 0x0600F3C1 RID: 62401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C1")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DDE RID: 69086
		[Token(Token = "0x4010DDE")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _tagExcluded;

		// Token: 0x04010DDF RID: 69087
		[Token(Token = "0x4010DDF")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private string _filterTag;

		// Token: 0x04010DE0 RID: 69088
		[Token(Token = "0x4010DE0")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private List<string> _filterTagList;

		// Token: 0x04010DE1 RID: 69089
		[Token(Token = "0x4010DE1")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private bool _buffKeyExcluded;

		// Token: 0x04010DE2 RID: 69090
		[Token(Token = "0x4010DE2")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x04010DE3 RID: 69091
		[Token(Token = "0x4010DE3")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private List<string> _buffs;

		// Token: 0x04010DE4 RID: 69092
		[Token(Token = "0x4010DE4")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Inspect("buffsNotEmpty")]
		private bool _checkOrInsteadOfAnd;

		// Token: 0x04010DE5 RID: 69093
		[Token(Token = "0x4010DE5")]
		[FieldOffset(Offset = "0x121")]
		[SerializeField]
		private bool _filterBuffSource;

		// Token: 0x04010DE6 RID: 69094
		[Token(Token = "0x4010DE6")]
		[FieldOffset(Offset = "0x122")]
		[SerializeField]
		private bool _filterTokenHost;

		// Token: 0x04010DE7 RID: 69095
		[Token(Token = "0x4010DE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffsNotEmpty;

		// Token: 0x04010DE8 RID: 69096
		[Token(Token = "0x4010DE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DE9 RID: 69097
		[Token(Token = "0x4010DE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckBuff;

		// Token: 0x04010DEA RID: 69098
		[Token(Token = "0x4010DEA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
