using System;
using Il2CppDummyDll;
using Torappu.DB;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066D3 RID: 26323
	[Token(Token = "0x20066D3")]
	public class HandBookV2ForceMapDB : DBComponent<HandBookV2ForceMapData>
	{
		// Token: 0x1700598C RID: 22924
		// (get) Token: 0x06025C91 RID: 154769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700598C")]
		protected override string dataURL
		{
			[Token(Token = "0x6025C91")]
			[Address(RVA = "0x20C0000", Offset = "0x20BEC00", VA = "0x1820C0000", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025C92 RID: 154770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C92")]
		[Address(RVA = "0x20BFF90", Offset = "0x20BEB90", VA = "0x1820BFF90")]
		public HandBookV2ForceMapDB()
		{
		}

		// Token: 0x040351F3 RID: 217587
		[Token(Token = "0x40351F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataURL;

		// Token: 0x040351F4 RID: 217588
		[Token(Token = "0x40351F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
