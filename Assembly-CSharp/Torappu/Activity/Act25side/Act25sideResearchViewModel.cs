using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200752E RID: 29998
	[Token(Token = "0x200752E")]
	public class Act25sideResearchViewModel : IHotfixable
	{
		// Token: 0x1700638F RID: 25487
		// (get) Token: 0x0602A44A RID: 173130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700638F")]
		public ListDict<string, Act25sideAreaViewModel> areaViewModels
		{
			[Token(Token = "0x602A44A")]
			[Address(RVA = "0x25EB1C0", Offset = "0x25E9DC0", VA = "0x1825EB1C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006390 RID: 25488
		// (get) Token: 0x0602A44B RID: 173131 RVA: 0x000D7E68 File Offset: 0x000D6068
		[Token(Token = "0x17006390")]
		public int researchCount
		{
			[Token(Token = "0x602A44B")]
			[Address(RVA = "0x25EB220", Offset = "0x25E9E20", VA = "0x1825EB220")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006391 RID: 25489
		// (get) Token: 0x0602A44C RID: 173132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006391")]
		public string selectedAreaId
		{
			[Token(Token = "0x602A44C")]
			[Address(RVA = "0x25EB280", Offset = "0x25E9E80", VA = "0x1825EB280")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A44D RID: 173133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A44D")]
		[Address(RVA = "0x25EA910", Offset = "0x25E9510", VA = "0x1825EA910")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602A44E RID: 173134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A44E")]
		[Address(RVA = "0x25EAFC0", Offset = "0x25E9BC0", VA = "0x1825EAFC0")]
		private void _UpdateAreaNewTrackPoint(string areaId)
		{
		}

		// Token: 0x0602A44F RID: 173135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A44F")]
		[Address(RVA = "0x25EAE30", Offset = "0x25E9A30", VA = "0x1825EAE30")]
		public void SetSelectAreaId(string areaId)
		{
		}

		// Token: 0x0602A450 RID: 173136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A450")]
		[Address(RVA = "0x25EA7F0", Offset = "0x25E93F0", VA = "0x1825EA7F0")]
		public Act25sideAreaViewModel GetSelectedArea()
		{
			return null;
		}

		// Token: 0x0602A451 RID: 173137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A451")]
		[Address(RVA = "0x25EB110", Offset = "0x25E9D10", VA = "0x1825EB110")]
		public Act25sideResearchViewModel()
		{
		}

		// Token: 0x0403CC57 RID: 248919
		[Token(Token = "0x403CC57")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403CC58 RID: 248920
		[Token(Token = "0x403CC58")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, Act25sideAreaViewModel> m_areaViewModels;

		// Token: 0x0403CC59 RID: 248921
		[Token(Token = "0x403CC59")]
		[FieldOffset(Offset = "0x20")]
		private int m_researchCount;

		// Token: 0x0403CC5A RID: 248922
		[Token(Token = "0x403CC5A")]
		[FieldOffset(Offset = "0x28")]
		private string m_selectedAreaId;

		// Token: 0x0403CC5B RID: 248923
		[Token(Token = "0x403CC5B")]
		[FieldOffset(Offset = "0x30")]
		public bool isInit;

		// Token: 0x0403CC5C RID: 248924
		[Token(Token = "0x403CC5C")]
		[FieldOffset(Offset = "0x31")]
		public bool isMax;

		// Token: 0x0403CC5D RID: 248925
		[Token(Token = "0x403CC5D")]
		[FieldOffset(Offset = "0x32")]
		public bool isAllComplete;

		// Token: 0x0403CC5E RID: 248926
		[Token(Token = "0x403CC5E")]
		[FieldOffset(Offset = "0x33")]
		public bool isEnd;

		// Token: 0x0403CC5F RID: 248927
		[Token(Token = "0x403CC5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_areaViewModels;

		// Token: 0x0403CC60 RID: 248928
		[Token(Token = "0x403CC60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_researchCount;

		// Token: 0x0403CC61 RID: 248929
		[Token(Token = "0x403CC61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedAreaId;

		// Token: 0x0403CC62 RID: 248930
		[Token(Token = "0x403CC62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC63 RID: 248931
		[Token(Token = "0x403CC63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateAreaNewTrackPoint;

		// Token: 0x0403CC64 RID: 248932
		[Token(Token = "0x403CC64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetSelectAreaId;

		// Token: 0x0403CC65 RID: 248933
		[Token(Token = "0x403CC65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSelectedArea;

		// Token: 0x0403CC66 RID: 248934
		[Token(Token = "0x403CC66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
