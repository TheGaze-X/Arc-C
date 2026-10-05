using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056D9 RID: 22233
	[Token(Token = "0x20056D9")]
	public class RL04FragmentItemGroupViewModel : IHotfixable
	{
		// Token: 0x060209BF RID: 133567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209BF")]
		[Address(RVA = "0x1ABCDF0", Offset = "0x1ABB9F0", VA = "0x181ABCDF0")]
		public RL04FragmentItemGroupViewModel()
		{
		}

		// Token: 0x0402C356 RID: 181078
		[Token(Token = "0x402C356")]
		public const int DETAIL_ITEM_COUNT_PER_ROW = 2;

		// Token: 0x0402C357 RID: 181079
		[Token(Token = "0x402C357")]
		public const int SUMMARY_ITEM_COUNT_PER_ROW = 8;

		// Token: 0x0402C358 RID: 181080
		[Token(Token = "0x402C358")]
		[FieldOffset(Offset = "0x10")]
		public RL04FragmentItemGroupViewModel.Type type;

		// Token: 0x0402C359 RID: 181081
		[Token(Token = "0x402C359")]
		[FieldOffset(Offset = "0x14")]
		public RoguelikeFragmentType titleType;

		// Token: 0x0402C35A RID: 181082
		[Token(Token = "0x402C35A")]
		[FieldOffset(Offset = "0x18")]
		public bool hasFood;

		// Token: 0x0402C35B RID: 181083
		[Token(Token = "0x402C35B")]
		[FieldOffset(Offset = "0x20")]
		public List<RL04FragmentItemViewModel> fragmentList;

		// Token: 0x0402C35C RID: 181084
		[Token(Token = "0x402C35C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056DA RID: 22234
		[Token(Token = "0x20056DA")]
		public enum Type
		{
			// Token: 0x0402C35E RID: 181086
			[Token(Token = "0x402C35E")]
			TITLE,
			// Token: 0x0402C35F RID: 181087
			[Token(Token = "0x402C35F")]
			ITEM
		}
	}
}
