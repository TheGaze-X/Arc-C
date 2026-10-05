using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CB2 RID: 15538
	[Token(Token = "0x2003CB2")]
	public class TuningHomeViewModel : IHotfixable
	{
		// Token: 0x060183D7 RID: 99287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D7")]
		[Address(RVA = "0x10C11F0", Offset = "0x10BFDF0", VA = "0x1810C11F0")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x060183D8 RID: 99288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D8")]
		[Address(RVA = "0x10C15C0", Offset = "0x10C01C0", VA = "0x1810C15C0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x060183D9 RID: 99289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D9")]
		[Address(RVA = "0x10C1910", Offset = "0x10C0510", VA = "0x1810C1910")]
		public TuningHomeViewModel()
		{
		}

		// Token: 0x0401D8E9 RID: 121065
		[Token(Token = "0x401D8E9")]
		[FieldOffset(Offset = "0x10")]
		public List<TuningHomeFragItemViewModel> fragList;

		// Token: 0x0401D8EA RID: 121066
		[Token(Token = "0x401D8EA")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x0401D8EB RID: 121067
		[Token(Token = "0x401D8EB")]
		[FieldOffset(Offset = "0x20")]
		public string nextTimeDesc;

		// Token: 0x0401D8EC RID: 121068
		[Token(Token = "0x401D8EC")]
		[FieldOffset(Offset = "0x28")]
		public bool showRemainTime;

		// Token: 0x0401D8ED RID: 121069
		[Token(Token = "0x401D8ED")]
		[FieldOffset(Offset = "0x2C")]
		public int entryAnimSequence;

		// Token: 0x0401D8EE RID: 121070
		[Token(Token = "0x401D8EE")]
		[FieldOffset(Offset = "0x30")]
		public bool showArchiveEntry;

		// Token: 0x0401D8EF RID: 121071
		[Token(Token = "0x401D8EF")]
		[FieldOffset(Offset = "0x38")]
		public TuningHomeMajorInvestViewModel majorInvestModel;

		// Token: 0x0401D8F0 RID: 121072
		[Token(Token = "0x401D8F0")]
		[FieldOffset(Offset = "0x40")]
		public TuningHomeHiddenInvestViewModel hiddenInvestModel;

		// Token: 0x0401D8F1 RID: 121073
		[Token(Token = "0x401D8F1")]
		[FieldOffset(Offset = "0x48")]
		public TuningHomeNormalInvestGroupViewModel normalInvestGroupModel;

		// Token: 0x0401D8F2 RID: 121074
		[Token(Token = "0x401D8F2")]
		[FieldOffset(Offset = "0x50")]
		private long m_actEndTs;

		// Token: 0x0401D8F3 RID: 121075
		[Token(Token = "0x401D8F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D8F4 RID: 121076
		[Token(Token = "0x401D8F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0401D8F5 RID: 121077
		[Token(Token = "0x401D8F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
