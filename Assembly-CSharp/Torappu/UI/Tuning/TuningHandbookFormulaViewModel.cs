using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C97 RID: 15511
	[Token(Token = "0x2003C97")]
	public class TuningHandbookFormulaViewModel : IHotfixable
	{
		// Token: 0x06018380 RID: 99200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018380")]
		[Address(RVA = "0x10B3D70", Offset = "0x10B2970", VA = "0x1810B3D70")]
		public void LoadData(string formId, Act29SideData.Act29SideFormData formulaData, Dictionary<string, Act29SideData.Act29SideFragData> fragDataList, bool isLock)
		{
		}

		// Token: 0x06018381 RID: 99201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018381")]
		[Address(RVA = "0x10B3E60", Offset = "0x10B2A60", VA = "0x1810B3E60")]
		public TuningHandbookFormulaViewModel()
		{
		}

		// Token: 0x0401D817 RID: 120855
		[Token(Token = "0x401D817")]
		[FieldOffset(Offset = "0x10")]
		public string formId;

		// Token: 0x0401D818 RID: 120856
		[Token(Token = "0x401D818")]
		[FieldOffset(Offset = "0x18")]
		public string formDesc;

		// Token: 0x0401D819 RID: 120857
		[Token(Token = "0x401D819")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act29SideData.Act29SideFragData> fragDataList;

		// Token: 0x0401D81A RID: 120858
		[Token(Token = "0x401D81A")]
		[FieldOffset(Offset = "0x28")]
		public List<string> fragIdList;

		// Token: 0x0401D81B RID: 120859
		[Token(Token = "0x401D81B")]
		[FieldOffset(Offset = "0x30")]
		public int formSortId;

		// Token: 0x0401D81C RID: 120860
		[Token(Token = "0x401D81C")]
		[FieldOffset(Offset = "0x34")]
		public bool isLock;

		// Token: 0x0401D81D RID: 120861
		[Token(Token = "0x401D81D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D81E RID: 120862
		[Token(Token = "0x401D81E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
