using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E74 RID: 28276
	[Token(Token = "0x2006E74")]
	public class ActVecBreakV2SquadBuffSelectViewModel : IHotfixable
	{
		// Token: 0x17005F09 RID: 24329
		// (get) Token: 0x060283C8 RID: 164808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F09")]
		public List<ActVecBreakV2DefenseStageBuffItemModel> selectedBuffList
		{
			[Token(Token = "0x60283C8")]
			[Address(RVA = "0x2385A40", Offset = "0x2384640", VA = "0x182385A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060283C9 RID: 164809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283C9")]
		[Address(RVA = "0x2384FC0", Offset = "0x2383BC0", VA = "0x182384FC0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060283CA RID: 164810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283CA")]
		[Address(RVA = "0x23850C0", Offset = "0x2383CC0", VA = "0x1823850C0")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x060283CB RID: 164811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283CB")]
		[Address(RVA = "0x2385220", Offset = "0x2383E20", VA = "0x182385220")]
		public void SelectBuffByStageId(string stageId)
		{
		}

		// Token: 0x060283CC RID: 164812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283CC")]
		[Address(RVA = "0x2385850", Offset = "0x2384450", VA = "0x182385850")]
		public void UnselectBuff(string unselectBuffId)
		{
		}

		// Token: 0x060283CD RID: 164813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283CD")]
		[Address(RVA = "0x23857B0", Offset = "0x23843B0", VA = "0x1823857B0")]
		public void UnselectAllBuff()
		{
		}

		// Token: 0x060283CE RID: 164814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60283CE")]
		[Address(RVA = "0x2385450", Offset = "0x2384050", VA = "0x182385450")]
		public List<string> TrySelectBuffByStageId(string stageId)
		{
			return null;
		}

		// Token: 0x060283CF RID: 164815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283CF")]
		[Address(RVA = "0x2385900", Offset = "0x2384500", VA = "0x182385900")]
		public ActVecBreakV2SquadBuffSelectViewModel()
		{
		}

		// Token: 0x04039300 RID: 234240
		[Token(Token = "0x4039300")]
		[FieldOffset(Offset = "0x10")]
		public ActVecBreakV2DefenseBuffListViewModel buffListModel;

		// Token: 0x04039301 RID: 234241
		[Token(Token = "0x4039301")]
		[FieldOffset(Offset = "0x18")]
		public List<string> selectedBuffIdList;

		// Token: 0x04039302 RID: 234242
		[Token(Token = "0x4039302")]
		[FieldOffset(Offset = "0x20")]
		public int maxSelectBuffCount;

		// Token: 0x04039303 RID: 234243
		[Token(Token = "0x4039303")]
		[FieldOffset(Offset = "0x28")]
		public string buffExceedToast;

		// Token: 0x04039304 RID: 234244
		[Token(Token = "0x4039304")]
		[FieldOffset(Offset = "0x30")]
		public string buffLockToast;

		// Token: 0x04039305 RID: 234245
		[Token(Token = "0x4039305")]
		[FieldOffset(Offset = "0x38")]
		public bool hasBuffEdited;

		// Token: 0x04039306 RID: 234246
		[Token(Token = "0x4039306")]
		[FieldOffset(Offset = "0x40")]
		public string buffSelectUnsaveHint;

		// Token: 0x04039307 RID: 234247
		[Token(Token = "0x4039307")]
		[FieldOffset(Offset = "0x48")]
		private List<ActVecBreakV2DefenseStageBuffItemModel> m_selectedBuffList;

		// Token: 0x04039308 RID: 234248
		[Token(Token = "0x4039308")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedBuffList;

		// Token: 0x04039309 RID: 234249
		[Token(Token = "0x4039309")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403930A RID: 234250
		[Token(Token = "0x403930A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403930B RID: 234251
		[Token(Token = "0x403930B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectBuffByStageId;

		// Token: 0x0403930C RID: 234252
		[Token(Token = "0x403930C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnselectBuff;

		// Token: 0x0403930D RID: 234253
		[Token(Token = "0x403930D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UnselectAllBuff;

		// Token: 0x0403930E RID: 234254
		[Token(Token = "0x403930E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TrySelectBuffByStageId;

		// Token: 0x0403930F RID: 234255
		[Token(Token = "0x403930F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
