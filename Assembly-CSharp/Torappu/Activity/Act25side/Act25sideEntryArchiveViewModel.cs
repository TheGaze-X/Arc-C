using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007530 RID: 30000
	[Token(Token = "0x2007530")]
	public class Act25sideEntryArchiveViewModel : TemplateActivityViewModel
	{
		// Token: 0x0602A453 RID: 173139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A453")]
		[Address(RVA = "0x25DD7F0", Offset = "0x25DC3F0", VA = "0x1825DD7F0")]
		public void LoadData()
		{
		}

		// Token: 0x0602A454 RID: 173140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A454")]
		[Address(RVA = "0x25DD8A0", Offset = "0x25DC4A0", VA = "0x1825DD8A0")]
		public Act25sideEntryArchiveViewModel(object param)
		{
		}

		// Token: 0x0403CC67 RID: 248935
		[Token(Token = "0x403CC67")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403CC68 RID: 248936
		[Token(Token = "0x403CC68")]
		[FieldOffset(Offset = "0x28")]
		public bool canAccess;

		// Token: 0x0403CC69 RID: 248937
		[Token(Token = "0x403CC69")]
		[FieldOffset(Offset = "0x29")]
		public bool hasUnvisitedItem;

		// Token: 0x0403CC6A RID: 248938
		[Token(Token = "0x403CC6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC6B RID: 248939
		[Token(Token = "0x403CC6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007531 RID: 30001
		[Token(Token = "0x2007531")]
		public class Input
		{
			// Token: 0x0602A455 RID: 173141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A455")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403CC6C RID: 248940
			[Token(Token = "0x403CC6C")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
