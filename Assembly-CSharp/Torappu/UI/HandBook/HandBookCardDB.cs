using System;
using Il2CppDummyDll;
using Torappu.DB;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200665C RID: 26204
	[Token(Token = "0x200665C")]
	public class HandBookCardDB : DBComponent<string, HandbookCardData>
	{
		// Token: 0x1700592B RID: 22827
		// (get) Token: 0x06025A1D RID: 154141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700592B")]
		protected override string dataURL
		{
			[Token(Token = "0x6025A1D")]
			[Address(RVA = "0x208F060", Offset = "0x208DC60", VA = "0x18208F060", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025A1E RID: 154142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A1E")]
		[Address(RVA = "0x208EFF0", Offset = "0x208DBF0", VA = "0x18208EFF0")]
		public HandBookCardDB()
		{
		}

		// Token: 0x04034DD7 RID: 216535
		[Token(Token = "0x4034DD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataURL;

		// Token: 0x04034DD8 RID: 216536
		[Token(Token = "0x4034DD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
