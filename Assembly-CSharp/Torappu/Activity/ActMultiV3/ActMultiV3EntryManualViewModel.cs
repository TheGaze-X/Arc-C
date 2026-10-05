using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F2B RID: 28459
	[Token(Token = "0x2006F2B")]
	public class ActMultiV3EntryManualViewModel : IHotfixable
	{
		// Token: 0x060286D7 RID: 165591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D7")]
		[Address(RVA = "0x23AC040", Offset = "0x23AAC40", VA = "0x1823AC040")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060286D8 RID: 165592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D8")]
		[Address(RVA = "0x23AC0C0", Offset = "0x23AACC0", VA = "0x1823AC0C0")]
		public ActMultiV3EntryManualViewModel()
		{
		}

		// Token: 0x040397F7 RID: 235511
		[Token(Token = "0x40397F7")]
		[FieldOffset(Offset = "0x10")]
		public bool hasTrackPoint;

		// Token: 0x040397F8 RID: 235512
		[Token(Token = "0x40397F8")]
		[FieldOffset(Offset = "0x11")]
		public bool hasNewTitle;

		// Token: 0x040397F9 RID: 235513
		[Token(Token = "0x40397F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040397FA RID: 235514
		[Token(Token = "0x40397FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
