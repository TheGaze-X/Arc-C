using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007532 RID: 30002
	[Token(Token = "0x2007532")]
	public class Act25sideEntryResearchViewModel : TemplateActivityViewModel
	{
		// Token: 0x0602A456 RID: 173142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A456")]
		[Address(RVA = "0x25DDA50", Offset = "0x25DC650", VA = "0x1825DDA50")]
		public void LoadData()
		{
		}

		// Token: 0x0602A457 RID: 173143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A457")]
		[Address(RVA = "0x25DDF30", Offset = "0x25DCB30", VA = "0x1825DDF30")]
		public Act25sideEntryResearchViewModel(object param)
		{
		}

		// Token: 0x0403CC6D RID: 248941
		[Token(Token = "0x403CC6D")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403CC6E RID: 248942
		[Token(Token = "0x403CC6E")]
		[FieldOffset(Offset = "0x28")]
		public bool canAccess;

		// Token: 0x0403CC6F RID: 248943
		[Token(Token = "0x403CC6F")]
		[FieldOffset(Offset = "0x29")]
		public bool hasUnvisitedArea;

		// Token: 0x0403CC70 RID: 248944
		[Token(Token = "0x403CC70")]
		[FieldOffset(Offset = "0x2A")]
		public bool hasNew;

		// Token: 0x0403CC71 RID: 248945
		[Token(Token = "0x403CC71")]
		[FieldOffset(Offset = "0x30")]
		public string lockedText;

		// Token: 0x0403CC72 RID: 248946
		[Token(Token = "0x403CC72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC73 RID: 248947
		[Token(Token = "0x403CC73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007533 RID: 30003
		[Token(Token = "0x2007533")]
		public class Input
		{
			// Token: 0x0602A458 RID: 173144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A458")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403CC74 RID: 248948
			[Token(Token = "0x403CC74")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
