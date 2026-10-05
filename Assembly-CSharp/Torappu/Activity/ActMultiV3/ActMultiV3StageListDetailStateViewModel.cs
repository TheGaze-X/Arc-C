using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FE7 RID: 28647
	[Token(Token = "0x2006FE7")]
	public class ActMultiV3StageListDetailStateViewModel : IHotfixable
	{
		// Token: 0x17006015 RID: 24597
		// (get) Token: 0x06028AFE RID: 166654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006015")]
		public string selectedStageId
		{
			[Token(Token = "0x6028AFE")]
			[Address(RVA = "0x23FFB10", Offset = "0x23FE710", VA = "0x1823FFB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028AFF RID: 166655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AFF")]
		[Address(RVA = "0x23FF6C0", Offset = "0x23FE2C0", VA = "0x1823FF6C0")]
		public void LoadData(string actId, string stageId)
		{
		}

		// Token: 0x06028B00 RID: 166656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B00")]
		[Address(RVA = "0x23FF8F0", Offset = "0x23FE4F0", VA = "0x1823FF8F0")]
		private void _ReloadStageViewModel()
		{
		}

		// Token: 0x06028B01 RID: 166657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B01")]
		[Address(RVA = "0x23FF800", Offset = "0x23FE400", VA = "0x1823FF800")]
		public void SetSelectedStage(bool isRight)
		{
		}

		// Token: 0x06028B02 RID: 166658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B02")]
		[Address(RVA = "0x23FFA60", Offset = "0x23FE660", VA = "0x1823FFA60")]
		public ActMultiV3StageListDetailStateViewModel()
		{
		}

		// Token: 0x04039FAD RID: 237485
		[Token(Token = "0x4039FAD")]
		[FieldOffset(Offset = "0x10")]
		public List<string> stageList;

		// Token: 0x04039FAE RID: 237486
		[Token(Token = "0x4039FAE")]
		[FieldOffset(Offset = "0x18")]
		public int normalStageCount;

		// Token: 0x04039FAF RID: 237487
		[Token(Token = "0x4039FAF")]
		[FieldOffset(Offset = "0x1C")]
		public int selectedStageIndex;

		// Token: 0x04039FB0 RID: 237488
		[Token(Token = "0x4039FB0")]
		[FieldOffset(Offset = "0x20")]
		public ActMultiV3StageDetailViewModel stageViewModel;

		// Token: 0x04039FB1 RID: 237489
		[Token(Token = "0x4039FB1")]
		[FieldOffset(Offset = "0x28")]
		public string actId;

		// Token: 0x04039FB2 RID: 237490
		[Token(Token = "0x4039FB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedStageId;

		// Token: 0x04039FB3 RID: 237491
		[Token(Token = "0x4039FB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039FB4 RID: 237492
		[Token(Token = "0x4039FB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ReloadStageViewModel;

		// Token: 0x04039FB5 RID: 237493
		[Token(Token = "0x4039FB5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelectedStage;

		// Token: 0x04039FB6 RID: 237494
		[Token(Token = "0x4039FB6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
