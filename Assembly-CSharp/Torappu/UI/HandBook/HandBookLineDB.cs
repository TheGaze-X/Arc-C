using System;
using Il2CppDummyDll;
using Torappu.DB;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200665D RID: 26205
	[Token(Token = "0x200665D")]
	public class HandBookLineDB : DBComponent<int, HandBookLineViewModel>
	{
		// Token: 0x1700592C RID: 22828
		// (get) Token: 0x06025A1F RID: 154143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700592C")]
		protected override string dataURL
		{
			[Token(Token = "0x6025A1F")]
			[Address(RVA = "0x2098DE0", Offset = "0x20979E0", VA = "0x182098DE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025A20 RID: 154144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A20")]
		[Address(RVA = "0x2098D70", Offset = "0x2097970", VA = "0x182098D70")]
		public HandBookLineDB()
		{
		}

		// Token: 0x04034DD9 RID: 216537
		[Token(Token = "0x4034DD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataURL;

		// Token: 0x04034DDA RID: 216538
		[Token(Token = "0x4034DDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
