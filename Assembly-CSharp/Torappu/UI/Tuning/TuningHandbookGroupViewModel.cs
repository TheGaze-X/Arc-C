using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C95 RID: 15509
	[Token(Token = "0x2003C95")]
	public class TuningHandbookGroupViewModel : IHotfixable
	{
		// Token: 0x06018379 RID: 99193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018379")]
		[Address(RVA = "0x10B4640", Offset = "0x10B3240", VA = "0x1810B4640")]
		public void LoadData(string actId, string emotionId, Act29SideData.Act29SideProductGroupData groupData, string selectId)
		{
		}

		// Token: 0x0601837A RID: 99194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601837A")]
		[Address(RVA = "0x10B4790", Offset = "0x10B3390", VA = "0x1810B4790")]
		public void SetFormulaList(Act29SideData.Act29SideProductGroupData groupData, Dictionary<string, Act29SideData.Act29SideFormData> formulaDataList, Dictionary<string, Act29SideData.Act29SideFragData> fragDataList, List<string> formBag, bool isSpLock)
		{
		}

		// Token: 0x0601837B RID: 99195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601837B")]
		[Address(RVA = "0x10B4B10", Offset = "0x10B3710", VA = "0x1810B4B10")]
		public void UpdateSelect(string id)
		{
		}

		// Token: 0x0601837C RID: 99196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601837C")]
		[Address(RVA = "0x10B4B90", Offset = "0x10B3790", VA = "0x1810B4B90")]
		public TuningHandbookGroupViewModel()
		{
		}

		// Token: 0x0401D803 RID: 120835
		[Token(Token = "0x401D803")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0401D804 RID: 120836
		[Token(Token = "0x401D804")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x0401D805 RID: 120837
		[Token(Token = "0x401D805")]
		[FieldOffset(Offset = "0x20")]
		public string groupName;

		// Token: 0x0401D806 RID: 120838
		[Token(Token = "0x401D806")]
		[FieldOffset(Offset = "0x28")]
		public string groupDesc;

		// Token: 0x0401D807 RID: 120839
		[Token(Token = "0x401D807")]
		[FieldOffset(Offset = "0x30")]
		public string defaultBgmSignal;

		// Token: 0x0401D808 RID: 120840
		[Token(Token = "0x401D808")]
		[FieldOffset(Offset = "0x38")]
		public string groupEngName;

		// Token: 0x0401D809 RID: 120841
		[Token(Token = "0x401D809")]
		[FieldOffset(Offset = "0x40")]
		public string groupSmallName;

		// Token: 0x0401D80A RID: 120842
		[Token(Token = "0x401D80A")]
		[FieldOffset(Offset = "0x48")]
		public string groupTypeIcon;

		// Token: 0x0401D80B RID: 120843
		[Token(Token = "0x401D80B")]
		[FieldOffset(Offset = "0x50")]
		public string groupTypeBasePic;

		// Token: 0x0401D80C RID: 120844
		[Token(Token = "0x401D80C")]
		[FieldOffset(Offset = "0x58")]
		public int groupSortId;

		// Token: 0x0401D80D RID: 120845
		[Token(Token = "0x401D80D")]
		[FieldOffset(Offset = "0x5C")]
		public bool isSpecial;

		// Token: 0x0401D80E RID: 120846
		[Token(Token = "0x401D80E")]
		[FieldOffset(Offset = "0x5D")]
		public bool isLock;

		// Token: 0x0401D80F RID: 120847
		[Token(Token = "0x401D80F")]
		[FieldOffset(Offset = "0x60")]
		public string selectId;

		// Token: 0x0401D810 RID: 120848
		[Token(Token = "0x401D810")]
		[FieldOffset(Offset = "0x68")]
		public List<TuningHandbookFormulaViewModel> formulaModelList;

		// Token: 0x0401D811 RID: 120849
		[Token(Token = "0x401D811")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D812 RID: 120850
		[Token(Token = "0x401D812")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetFormulaList;

		// Token: 0x0401D813 RID: 120851
		[Token(Token = "0x401D813")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateSelect;

		// Token: 0x0401D814 RID: 120852
		[Token(Token = "0x401D814")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
