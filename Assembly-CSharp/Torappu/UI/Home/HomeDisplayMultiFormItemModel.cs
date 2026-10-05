using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B43 RID: 19267
	[Token(Token = "0x2004B43")]
	public abstract class HomeDisplayMultiFormItemModel : IHotfixable, IComparable<HomeDisplayMultiFormItemModel>
	{
		// Token: 0x0601D06C RID: 118892 RVA: 0x000AA088 File Offset: 0x000A8288
		[Token(Token = "0x601D06C")]
		[Address(RVA = "0x166FE10", Offset = "0x166EA10", VA = "0x18166FE10", Slot = "4")]
		public int CompareTo(HomeDisplayMultiFormItemModel other)
		{
			return 0;
		}

		// Token: 0x0601D06D RID: 118893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D06D")]
		[Address(RVA = "0x166FE90", Offset = "0x166EA90", VA = "0x18166FE90")]
		protected HomeDisplayMultiFormItemModel()
		{
		}

		// Token: 0x0402613B RID: 155963
		[Token(Token = "0x402613B")]
		[FieldOffset(Offset = "0x10")]
		public bool isMultiForm;

		// Token: 0x0402613C RID: 155964
		[Token(Token = "0x402613C")]
		[FieldOffset(Offset = "0x18")]
		public string mainId;

		// Token: 0x0402613D RID: 155965
		[Token(Token = "0x402613D")]
		[FieldOffset(Offset = "0x20")]
		public string formId;

		// Token: 0x0402613E RID: 155966
		[Token(Token = "0x402613E")]
		[FieldOffset(Offset = "0x28")]
		public bool hasBackward;

		// Token: 0x0402613F RID: 155967
		[Token(Token = "0x402613F")]
		[FieldOffset(Offset = "0x2C")]
		public HomeDisplayCompType compType;

		// Token: 0x04026140 RID: 155968
		[Token(Token = "0x4026140")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x04026141 RID: 155969
		[Token(Token = "0x4026141")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04026142 RID: 155970
		[Token(Token = "0x4026142")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
