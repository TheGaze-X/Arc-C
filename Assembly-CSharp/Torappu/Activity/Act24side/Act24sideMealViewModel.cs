using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007585 RID: 30085
	[Token(Token = "0x2007585")]
	public class Act24sideMealViewModel : IHotfixable
	{
		// Token: 0x0602A5B6 RID: 173494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5B6")]
		[Address(RVA = "0x2601DF0", Offset = "0x26009F0", VA = "0x182601DF0")]
		public void LoadData(string mealId, Act24SideData.MealData mealData)
		{
		}

		// Token: 0x0602A5B7 RID: 173495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5B7")]
		[Address(RVA = "0x2601EF0", Offset = "0x2600AF0", VA = "0x182601EF0")]
		public Act24sideMealViewModel()
		{
		}

		// Token: 0x0403CED2 RID: 249554
		[Token(Token = "0x403CED2")]
		[FieldOffset(Offset = "0x10")]
		public string mealId;

		// Token: 0x0403CED3 RID: 249555
		[Token(Token = "0x403CED3")]
		[FieldOffset(Offset = "0x18")]
		public string mealName;

		// Token: 0x0403CED4 RID: 249556
		[Token(Token = "0x403CED4")]
		[FieldOffset(Offset = "0x20")]
		public string mealDesc;

		// Token: 0x0403CED5 RID: 249557
		[Token(Token = "0x403CED5")]
		[FieldOffset(Offset = "0x28")]
		public string mealEffect;

		// Token: 0x0403CED6 RID: 249558
		[Token(Token = "0x403CED6")]
		[FieldOffset(Offset = "0x30")]
		public int mealSortId;

		// Token: 0x0403CED7 RID: 249559
		[Token(Token = "0x403CED7")]
		[FieldOffset(Offset = "0x34")]
		public int mealCost;

		// Token: 0x0403CED8 RID: 249560
		[Token(Token = "0x403CED8")]
		[FieldOffset(Offset = "0x38")]
		public ItemBundle mealRewardItemInfo;

		// Token: 0x0403CED9 RID: 249561
		[Token(Token = "0x403CED9")]
		[FieldOffset(Offset = "0x40")]
		public int mealRewardApCount;

		// Token: 0x0403CEDA RID: 249562
		[Token(Token = "0x403CEDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CEDB RID: 249563
		[Token(Token = "0x403CEDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
