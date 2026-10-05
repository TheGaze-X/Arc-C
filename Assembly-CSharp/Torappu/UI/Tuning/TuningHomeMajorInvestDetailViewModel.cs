using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CBF RID: 15551
	[Token(Token = "0x2003CBF")]
	public class TuningHomeMajorInvestDetailViewModel : IHotfixable
	{
		// Token: 0x060183FE RID: 99326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183FE")]
		[Address(RVA = "0x10BD030", Offset = "0x10BBC30", VA = "0x1810BD030")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060183FF RID: 99327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183FF")]
		[Address(RVA = "0x10BD4E0", Offset = "0x10BC0E0", VA = "0x1810BD4E0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06018400 RID: 99328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018400")]
		[Address(RVA = "0x10BD800", Offset = "0x10BC400", VA = "0x1810BD800")]
		public TuningHomeMajorInvestDetailViewModel()
		{
		}

		// Token: 0x0401D942 RID: 121154
		[Token(Token = "0x401D942")]
		[FieldOffset(Offset = "0x10")]
		public List<TuningHomeMajorInvestItemViewModel> majorItemList;

		// Token: 0x0401D943 RID: 121155
		[Token(Token = "0x401D943")]
		[FieldOffset(Offset = "0x18")]
		public int currProgress;

		// Token: 0x0401D944 RID: 121156
		[Token(Token = "0x401D944")]
		[FieldOffset(Offset = "0x1C")]
		public int majorMaxCount;

		// Token: 0x0401D945 RID: 121157
		[Token(Token = "0x401D945")]
		[FieldOffset(Offset = "0x20")]
		public string detailDesc1;

		// Token: 0x0401D946 RID: 121158
		[Token(Token = "0x401D946")]
		[FieldOffset(Offset = "0x28")]
		public string detailDesc2;

		// Token: 0x0401D947 RID: 121159
		[Token(Token = "0x401D947")]
		[FieldOffset(Offset = "0x30")]
		public string detailDesc3;

		// Token: 0x0401D948 RID: 121160
		[Token(Token = "0x401D948")]
		[FieldOffset(Offset = "0x38")]
		public string detailDesc4;

		// Token: 0x0401D949 RID: 121161
		[Token(Token = "0x401D949")]
		[FieldOffset(Offset = "0x40")]
		private string m_detailDescFormat1;

		// Token: 0x0401D94A RID: 121162
		[Token(Token = "0x401D94A")]
		[FieldOffset(Offset = "0x48")]
		private string m_detailDescFormat2;

		// Token: 0x0401D94B RID: 121163
		[Token(Token = "0x401D94B")]
		[FieldOffset(Offset = "0x50")]
		private string m_detailDescFormat3;

		// Token: 0x0401D94C RID: 121164
		[Token(Token = "0x401D94C")]
		[FieldOffset(Offset = "0x58")]
		private string m_detailDescFormat4;

		// Token: 0x0401D94D RID: 121165
		[Token(Token = "0x401D94D")]
		[FieldOffset(Offset = "0x60")]
		private string m_tokenName;

		// Token: 0x0401D94E RID: 121166
		[Token(Token = "0x401D94E")]
		[FieldOffset(Offset = "0x68")]
		private string m_actId;

		// Token: 0x0401D94F RID: 121167
		[Token(Token = "0x401D94F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D950 RID: 121168
		[Token(Token = "0x401D950")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0401D951 RID: 121169
		[Token(Token = "0x401D951")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
