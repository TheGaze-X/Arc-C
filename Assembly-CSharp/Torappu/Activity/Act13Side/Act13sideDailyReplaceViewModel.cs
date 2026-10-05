using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A15 RID: 31253
	[Token(Token = "0x2007A15")]
	public class Act13sideDailyReplaceViewModel : IHotfixable
	{
		// Token: 0x170066AE RID: 26286
		// (get) Token: 0x0602BCE3 RID: 179427 RVA: 0x000DD400 File Offset: 0x000DB600
		[Token(Token = "0x170066AE")]
		public int candidatePoolIdx
		{
			[Token(Token = "0x602BCE3")]
			[Address(RVA = "0x27B5720", Offset = "0x27B4320", VA = "0x1827B5720")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170066AF RID: 26287
		// (get) Token: 0x0602BCE4 RID: 179428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066AF")]
		public List<Act13sideDailyMissionItemViewModel> boardItemModelList
		{
			[Token(Token = "0x602BCE4")]
			[Address(RVA = "0x27B5660", Offset = "0x27B4260", VA = "0x1827B5660")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066B0 RID: 26288
		// (get) Token: 0x0602BCE5 RID: 179429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066B0")]
		public Act13sideDailyMissionItemViewModel candidateItemModel
		{
			[Token(Token = "0x602BCE5")]
			[Address(RVA = "0x27B56C0", Offset = "0x27B42C0", VA = "0x1827B56C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066B1 RID: 26289
		// (get) Token: 0x0602BCE6 RID: 179430 RVA: 0x000DD418 File Offset: 0x000DB618
		[Token(Token = "0x170066B1")]
		public int ownAgenda
		{
			[Token(Token = "0x602BCE6")]
			[Address(RVA = "0x27B5780", Offset = "0x27B4380", VA = "0x1827B5780")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170066B2 RID: 26290
		// (get) Token: 0x0602BCE7 RID: 179431 RVA: 0x000DD430 File Offset: 0x000DB630
		[Token(Token = "0x170066B2")]
		public int selectItemAgenda
		{
			[Token(Token = "0x602BCE7")]
			[Address(RVA = "0x27B57E0", Offset = "0x27B43E0", VA = "0x1827B57E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170066B3 RID: 26291
		// (get) Token: 0x0602BCE8 RID: 179432 RVA: 0x000DD448 File Offset: 0x000DB648
		[Token(Token = "0x170066B3")]
		public int agendaAfterReplace
		{
			[Token(Token = "0x602BCE8")]
			[Address(RVA = "0x27B5500", Offset = "0x27B4100", VA = "0x1827B5500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602BCE9 RID: 179433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BCE9")]
		[Address(RVA = "0x27B4EF0", Offset = "0x27B3AF0", VA = "0x1827B4EF0")]
		public int[] GetSelectIdxList()
		{
			return null;
		}

		// Token: 0x0602BCEA RID: 179434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCEA")]
		[Address(RVA = "0x27B5300", Offset = "0x27B3F00", VA = "0x1827B5300")]
		public void SelectItem(int itemIdx, bool isSelect)
		{
		}

		// Token: 0x0602BCEB RID: 179435 RVA: 0x000DD460 File Offset: 0x000DB660
		[Token(Token = "0x602BCEB")]
		[Address(RVA = "0x27B4F60", Offset = "0x27B3B60", VA = "0x1827B4F60")]
		public bool IsItemSelected(int itemIdx)
		{
			return default(bool);
		}

		// Token: 0x0602BCEC RID: 179436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCEC")]
		[Address(RVA = "0x27B4FF0", Offset = "0x27B3BF0", VA = "0x1827B4FF0")]
		public void LoadData(string actId, int candidatePoolIdx)
		{
		}

		// Token: 0x0602BCED RID: 179437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCED")]
		[Address(RVA = "0x27B5400", Offset = "0x27B4000", VA = "0x1827B5400")]
		public Act13sideDailyReplaceViewModel()
		{
		}

		// Token: 0x0403F618 RID: 259608
		[Token(Token = "0x403F618")]
		[FieldOffset(Offset = "0x10")]
		private List<Act13sideDailyMissionItemViewModel> m_boardItemModelList;

		// Token: 0x0403F619 RID: 259609
		[Token(Token = "0x403F619")]
		[FieldOffset(Offset = "0x18")]
		private Act13sideDailyMissionItemViewModel m_candidateItemModel;

		// Token: 0x0403F61A RID: 259610
		[Token(Token = "0x403F61A")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<int> m_selectedIdxSet;

		// Token: 0x0403F61B RID: 259611
		[Token(Token = "0x403F61B")]
		[FieldOffset(Offset = "0x28")]
		private int m_agenda;

		// Token: 0x0403F61C RID: 259612
		[Token(Token = "0x403F61C")]
		[FieldOffset(Offset = "0x2C")]
		private int m_candidatePoolIdx;

		// Token: 0x0403F61D RID: 259613
		[Token(Token = "0x403F61D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_candidatePoolIdx;

		// Token: 0x0403F61E RID: 259614
		[Token(Token = "0x403F61E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_boardItemModelList;

		// Token: 0x0403F61F RID: 259615
		[Token(Token = "0x403F61F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_candidateItemModel;

		// Token: 0x0403F620 RID: 259616
		[Token(Token = "0x403F620")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_ownAgenda;

		// Token: 0x0403F621 RID: 259617
		[Token(Token = "0x403F621")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectItemAgenda;

		// Token: 0x0403F622 RID: 259618
		[Token(Token = "0x403F622")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_agendaAfterReplace;

		// Token: 0x0403F623 RID: 259619
		[Token(Token = "0x403F623")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSelectIdxList;

		// Token: 0x0403F624 RID: 259620
		[Token(Token = "0x403F624")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x0403F625 RID: 259621
		[Token(Token = "0x403F625")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsItemSelected;

		// Token: 0x0403F626 RID: 259622
		[Token(Token = "0x403F626")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F627 RID: 259623
		[Token(Token = "0x403F627")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
