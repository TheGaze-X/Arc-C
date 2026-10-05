using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C98 RID: 15512
	[Token(Token = "0x2003C98")]
	public class TuningHandbookViewModel : IHotfixable
	{
		// Token: 0x06018382 RID: 99202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018382")]
		[Address(RVA = "0x10B63F0", Offset = "0x10B4FF0", VA = "0x1810B63F0")]
		public void LoadData(string actId, string groupId)
		{
		}

		// Token: 0x06018383 RID: 99203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018383")]
		[Address(RVA = "0x10B6340", Offset = "0x10B4F40", VA = "0x1810B6340")]
		public List<TuningHandbookFormulaViewModel> GetFormulaList()
		{
			return null;
		}

		// Token: 0x06018384 RID: 99204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018384")]
		[Address(RVA = "0x10B6C70", Offset = "0x10B5870", VA = "0x1810B6C70")]
		public void SetSelectGroupId(string groupId)
		{
		}

		// Token: 0x06018385 RID: 99205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018385")]
		[Address(RVA = "0x10B6E90", Offset = "0x10B5A90", VA = "0x1810B6E90")]
		public TuningHandbookViewModel()
		{
		}

		// Token: 0x0401D81F RID: 120863
		[Token(Token = "0x401D81F")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0401D820 RID: 120864
		[Token(Token = "0x401D820")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, TuningHandbookGroupViewModel> groupList;

		// Token: 0x0401D821 RID: 120865
		[Token(Token = "0x401D821")]
		[FieldOffset(Offset = "0x20")]
		private List<string> formBag;

		// Token: 0x0401D822 RID: 120866
		[Token(Token = "0x401D822")]
		[FieldOffset(Offset = "0x28")]
		public string selectGroupId;

		// Token: 0x0401D823 RID: 120867
		[Token(Token = "0x401D823")]
		[FieldOffset(Offset = "0x30")]
		public string playBgmId;

		// Token: 0x0401D824 RID: 120868
		[Token(Token = "0x401D824")]
		[FieldOffset(Offset = "0x38")]
		public bool isSpecial;

		// Token: 0x0401D825 RID: 120869
		[Token(Token = "0x401D825")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D826 RID: 120870
		[Token(Token = "0x401D826")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetFormulaList;

		// Token: 0x0401D827 RID: 120871
		[Token(Token = "0x401D827")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectGroupId;

		// Token: 0x0401D828 RID: 120872
		[Token(Token = "0x401D828")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
