using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003631 RID: 13873
	[Token(Token = "0x2003631")]
	public struct UIPageStackParam
	{
		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0601617D RID: 90493 RVA: 0x0008F670 File Offset: 0x0008D870
		[Token(Token = "0x17003523")]
		public bool isEmpty
		{
			[Token(Token = "0x601617D")]
			[Address(RVA = "0xEA5350", Offset = "0xEA3F50", VA = "0x180EA5350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0401A935 RID: 108853
		[Token(Token = "0x401A935")]
		[FieldOffset(Offset = "0x0")]
		public UIPageStackParam.Mode mode;

		// Token: 0x0401A936 RID: 108854
		[Token(Token = "0x401A936")]
		[FieldOffset(Offset = "0x4")]
		public bool preserveBottomIfPossible;

		// Token: 0x0401A937 RID: 108855
		[Token(Token = "0x401A937")]
		[FieldOffset(Offset = "0x5")]
		public bool preserveAllIfPossible;

		// Token: 0x0401A938 RID: 108856
		[Token(Token = "0x401A938")]
		[FieldOffset(Offset = "0x8")]
		public string preserveSentryPage;

		// Token: 0x0401A939 RID: 108857
		[Token(Token = "0x401A939")]
		[FieldOffset(Offset = "0x10")]
		public List<UIPageStackParam.StackElement> stack;

		// Token: 0x02003632 RID: 13874
		[Token(Token = "0x2003632")]
		public enum Mode
		{
			// Token: 0x0401A93B RID: 108859
			[Token(Token = "0x401A93B")]
			RESET,
			// Token: 0x0401A93C RID: 108860
			[Token(Token = "0x401A93C")]
			APPEND
		}

		// Token: 0x02003633 RID: 13875
		[Token(Token = "0x2003633")]
		public struct StackElement
		{
			// Token: 0x0401A93D RID: 108861
			[Token(Token = "0x401A93D")]
			[FieldOffset(Offset = "0x0")]
			public string pageName;

			// Token: 0x0401A93E RID: 108862
			[Token(Token = "0x401A93E")]
			[FieldOffset(Offset = "0x8")]
			public DataBundle savedInst;

			// Token: 0x0401A93F RID: 108863
			[Token(Token = "0x401A93F")]
			[FieldOffset(Offset = "0x10")]
			public object args;
		}
	}
}
