using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056CC RID: 22220
	[Token(Token = "0x20056CC")]
	public class RL04FragmentGainViewModel : IHotfixable
	{
		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x0602096D RID: 133485 RVA: 0x000B6718 File Offset: 0x000B4918
		[Token(Token = "0x17004C5C")]
		public bool isLastItem
		{
			[Token(Token = "0x602096D")]
			[Address(RVA = "0x1ABC730", Offset = "0x1ABB330", VA = "0x181ABC730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602096E RID: 133486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602096E")]
		[Address(RVA = "0x1ABC5D0", Offset = "0x1ABB1D0", VA = "0x181ABC5D0")]
		public void LoadData(RL04FragmentGainDialog.Options input)
		{
		}

		// Token: 0x0602096F RID: 133487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602096F")]
		[Address(RVA = "0x1ABC670", Offset = "0x1ABB270", VA = "0x181ABC670")]
		public void ShowNextItem()
		{
		}

		// Token: 0x06020970 RID: 133488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020970")]
		[Address(RVA = "0x1ABC6D0", Offset = "0x1ABB2D0", VA = "0x181ABC6D0")]
		public RL04FragmentGainViewModel()
		{
		}

		// Token: 0x0402C2C1 RID: 180929
		[Token(Token = "0x402C2C1")]
		[FieldOffset(Offset = "0x10")]
		public List<IRoguelikeFragmentItemModel> fragmentList;

		// Token: 0x0402C2C2 RID: 180930
		[Token(Token = "0x402C2C2")]
		[FieldOffset(Offset = "0x18")]
		public int showIndex;

		// Token: 0x0402C2C3 RID: 180931
		[Token(Token = "0x402C2C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLastItem;

		// Token: 0x0402C2C4 RID: 180932
		[Token(Token = "0x402C2C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C2C5 RID: 180933
		[Token(Token = "0x402C2C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowNextItem;

		// Token: 0x0402C2C6 RID: 180934
		[Token(Token = "0x402C2C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
