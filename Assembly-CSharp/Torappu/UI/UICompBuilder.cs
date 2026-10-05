using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A6B RID: 14955
	[Token(Token = "0x2003A6B")]
	public class UICompBuilder<Dialog, Input> : UICompDialogMgr.CompBaseBuilder where Dialog : UICompDialog<Input> where Input : class
	{
		// Token: 0x06017A5C RID: 96860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A5C")]
		public override object GetInput()
		{
			return null;
		}

		// Token: 0x06017A5D RID: 96861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A5D")]
		public static UICompBuilder<Dialog, Input> InstBuilder(string resPath, Input input)
		{
			return null;
		}

		// Token: 0x06017A5E RID: 96862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A5E")]
		public UICompBuilder()
		{
		}

		// Token: 0x0401C896 RID: 116886
		[Token(Token = "0x401C896")]
		[FieldOffset(Offset = "0x0")]
		public Input input;

		// Token: 0x0401C897 RID: 116887
		[Token(Token = "0x401C897")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetInput;

		// Token: 0x0401C898 RID: 116888
		[Token(Token = "0x401C898")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InstBuilder;

		// Token: 0x0401C899 RID: 116889
		[Token(Token = "0x401C899")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
