using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CDB RID: 19675
	[Token(Token = "0x2004CDB")]
	public class GroceryOrderSelfShopStrategyItemViewModel : IHotfixable
	{
		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x0601D788 RID: 120712 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D789 RID: 120713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700451C")]
		public string goodId
		{
			[Token(Token = "0x601D788")]
			[Address(RVA = "0x1701D10", Offset = "0x1700910", VA = "0x181701D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D789")]
			[Address(RVA = "0x1701F50", Offset = "0x1700B50", VA = "0x181701F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x0601D78A RID: 120714 RVA: 0x000AB8D0 File Offset: 0x000A9AD0
		// (set) Token: 0x0601D78B RID: 120715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700451D")]
		public int index
		{
			[Token(Token = "0x601D78A")]
			[Address(RVA = "0x1701D70", Offset = "0x1700970", VA = "0x181701D70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D78B")]
			[Address(RVA = "0x1701FD0", Offset = "0x1700BD0", VA = "0x181701FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x0601D78C RID: 120716 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D78D RID: 120717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700451E")]
		public string shopIconId
		{
			[Token(Token = "0x601D78C")]
			[Address(RVA = "0x1701E90", Offset = "0x1700A90", VA = "0x181701E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D78D")]
			[Address(RVA = "0x1702120", Offset = "0x1700D20", VA = "0x181702120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x0601D78E RID: 120718 RVA: 0x000AB8E8 File Offset: 0x000A9AE8
		// (set) Token: 0x0601D78F RID: 120719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700451F")]
		public int priceCount
		{
			[Token(Token = "0x601D78E")]
			[Address(RVA = "0x1701E30", Offset = "0x1700A30", VA = "0x181701E30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D78F")]
			[Address(RVA = "0x17020B0", Offset = "0x1700CB0", VA = "0x1817020B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x0601D790 RID: 120720 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D791 RID: 120721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004520")]
		public string strategyName
		{
			[Token(Token = "0x601D790")]
			[Address(RVA = "0x1701EF0", Offset = "0x1700AF0", VA = "0x181701EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D791")]
			[Address(RVA = "0x17021A0", Offset = "0x1700DA0", VA = "0x1817021A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004521 RID: 17697
		// (get) Token: 0x0601D792 RID: 120722 RVA: 0x000AB900 File Offset: 0x000A9B00
		// (set) Token: 0x0601D793 RID: 120723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004521")]
		public bool isSelecting
		{
			[Token(Token = "0x601D792")]
			[Address(RVA = "0x1701DD0", Offset = "0x17009D0", VA = "0x181701DD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D793")]
			[Address(RVA = "0x1702040", Offset = "0x1700C40", VA = "0x181702040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601D794 RID: 120724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D794")]
		[Address(RVA = "0x17019E0", Offset = "0x17005E0", VA = "0x1817019E0")]
		public void LoadData(string goodId, int strategyIndex, string iconId, int price, string strategy)
		{
		}

		// Token: 0x0601D795 RID: 120725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D795")]
		[Address(RVA = "0x1701C10", Offset = "0x1700810", VA = "0x181701C10")]
		public void RefreshSelect(bool isSelect)
		{
		}

		// Token: 0x0601D796 RID: 120726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D796")]
		[Address(RVA = "0x1701CB0", Offset = "0x17008B0", VA = "0x181701CB0")]
		public GroceryOrderSelfShopStrategyItemViewModel()
		{
		}

		// Token: 0x04026DEE RID: 159214
		[Token(Token = "0x4026DEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_goodId;

		// Token: 0x04026DEF RID: 159215
		[Token(Token = "0x4026DEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_goodId;

		// Token: 0x04026DF0 RID: 159216
		[Token(Token = "0x4026DF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x04026DF1 RID: 159217
		[Token(Token = "0x4026DF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x04026DF2 RID: 159218
		[Token(Token = "0x4026DF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_shopIconId;

		// Token: 0x04026DF3 RID: 159219
		[Token(Token = "0x4026DF3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_shopIconId;

		// Token: 0x04026DF4 RID: 159220
		[Token(Token = "0x4026DF4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_priceCount;

		// Token: 0x04026DF5 RID: 159221
		[Token(Token = "0x4026DF5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_priceCount;

		// Token: 0x04026DF6 RID: 159222
		[Token(Token = "0x4026DF6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_strategyName;

		// Token: 0x04026DF7 RID: 159223
		[Token(Token = "0x4026DF7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_strategyName;

		// Token: 0x04026DF8 RID: 159224
		[Token(Token = "0x4026DF8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isSelecting;

		// Token: 0x04026DF9 RID: 159225
		[Token(Token = "0x4026DF9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_isSelecting;

		// Token: 0x04026DFA RID: 159226
		[Token(Token = "0x4026DFA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026DFB RID: 159227
		[Token(Token = "0x4026DFB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshSelect;

		// Token: 0x04026DFC RID: 159228
		[Token(Token = "0x4026DFC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
