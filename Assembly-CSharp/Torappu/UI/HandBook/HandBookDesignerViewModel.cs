using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066B4 RID: 26292
	[Token(Token = "0x20066B4")]
	public class HandBookDesignerViewModel : IHotfixable
	{
		// Token: 0x06025C32 RID: 154674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C32")]
		[Address(RVA = "0x20A4100", Offset = "0x20A2D00", VA = "0x1820A4100")]
		public HandBookDesignerViewModel()
		{
		}

		// Token: 0x0403515B RID: 217435
		[Token(Token = "0x403515B")]
		[FieldOffset(Offset = "0x10")]
		public string drawerName;

		// Token: 0x0403515C RID: 217436
		[Token(Token = "0x403515C")]
		[FieldOffset(Offset = "0x18")]
		public bool haveDesigner;

		// Token: 0x0403515D RID: 217437
		[Token(Token = "0x403515D")]
		[FieldOffset(Offset = "0x20")]
		public string designerName;

		// Token: 0x0403515E RID: 217438
		[Token(Token = "0x403515E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
