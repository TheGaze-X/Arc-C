using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B46 RID: 19270
	[Token(Token = "0x2004B46")]
	public class HomeDisplayMultiFormRawData : IHotfixable
	{
		// Token: 0x0601D070 RID: 118896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D070")]
		[Address(RVA = "0x16718B0", Offset = "0x16704B0", VA = "0x1816718B0")]
		public HomeDisplayMultiFormRawData()
		{
		}

		// Token: 0x04026146 RID: 155974
		[Token(Token = "0x4026146")]
		[FieldOffset(Offset = "0x10")]
		public string mainId;

		// Token: 0x04026147 RID: 155975
		[Token(Token = "0x4026147")]
		[FieldOffset(Offset = "0x18")]
		public HomeDisplayCompType compType;

		// Token: 0x04026148 RID: 155976
		[Token(Token = "0x4026148")]
		[FieldOffset(Offset = "0x1C")]
		public bool isMultiForm;

		// Token: 0x04026149 RID: 155977
		[Token(Token = "0x4026149")]
		[FieldOffset(Offset = "0x20")]
		public HomeMultiFormChangeRule rule;

		// Token: 0x0402614A RID: 155978
		[Token(Token = "0x402614A")]
		[FieldOffset(Offset = "0x28")]
		public List<HomeDisplayMultiFormItemModel> formModels;

		// Token: 0x0402614B RID: 155979
		[Token(Token = "0x402614B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
