using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A17 RID: 31255
	[Token(Token = "0x2007A17")]
	public class Act13sideDailySearchViewModel : IHotfixable
	{
		// Token: 0x170066B4 RID: 26292
		// (get) Token: 0x0602BCEF RID: 179439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066B4")]
		public string actId
		{
			[Token(Token = "0x602BCEF")]
			[Address(RVA = "0x27B6A70", Offset = "0x27B5670", VA = "0x1827B6A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066B5 RID: 26293
		// (get) Token: 0x0602BCF0 RID: 179440 RVA: 0x000DD478 File Offset: 0x000DB678
		[Token(Token = "0x170066B5")]
		public int searchCount
		{
			[Token(Token = "0x602BCF0")]
			[Address(RVA = "0x27B6AD0", Offset = "0x27B56D0", VA = "0x1827B6AD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602BCF1 RID: 179441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCF1")]
		[Address(RVA = "0x27B65E0", Offset = "0x27B51E0", VA = "0x1827B65E0")]
		public void Init(string actId)
		{
		}

		// Token: 0x0602BCF2 RID: 179442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCF2")]
		[Address(RVA = "0x27B69C0", Offset = "0x27B55C0", VA = "0x1827B69C0")]
		public Act13sideDailySearchViewModel()
		{
		}

		// Token: 0x0403F628 RID: 259624
		[Token(Token = "0x403F628")]
		[FieldOffset(Offset = "0x10")]
		public string selectOrgId;

		// Token: 0x0403F629 RID: 259625
		[Token(Token = "0x403F629")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle selectMatItem;

		// Token: 0x0403F62A RID: 259626
		[Token(Token = "0x403F62A")]
		[FieldOffset(Offset = "0x20")]
		public List<Act13SideData.OrgData> orgList;

		// Token: 0x0403F62B RID: 259627
		[Token(Token = "0x403F62B")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> matList;

		// Token: 0x0403F62C RID: 259628
		[Token(Token = "0x403F62C")]
		[FieldOffset(Offset = "0x30")]
		private string m_actId;

		// Token: 0x0403F62D RID: 259629
		[Token(Token = "0x403F62D")]
		[FieldOffset(Offset = "0x38")]
		private int m_searchCount;

		// Token: 0x0403F62E RID: 259630
		[Token(Token = "0x403F62E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403F62F RID: 259631
		[Token(Token = "0x403F62F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_searchCount;

		// Token: 0x0403F630 RID: 259632
		[Token(Token = "0x403F630")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403F631 RID: 259633
		[Token(Token = "0x403F631")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
