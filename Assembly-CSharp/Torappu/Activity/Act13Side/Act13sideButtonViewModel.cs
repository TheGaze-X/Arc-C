using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A0E RID: 31246
	[Token(Token = "0x2007A0E")]
	public class Act13sideButtonViewModel : TemplateActivityViewModel
	{
		// Token: 0x0602BCC5 RID: 179397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCC5")]
		[Address(RVA = "0x27ABAF0", Offset = "0x27AA6F0", VA = "0x1827ABAF0")]
		public Act13sideButtonViewModel(object param)
		{
		}

		// Token: 0x0403F5E9 RID: 259561
		[Token(Token = "0x403F5E9")]
		[FieldOffset(Offset = "0x20")]
		public bool isLocked;

		// Token: 0x0403F5EA RID: 259562
		[Token(Token = "0x403F5EA")]
		[FieldOffset(Offset = "0x28")]
		public Act13sideButtonViewModel.Input input;

		// Token: 0x0403F5EB RID: 259563
		[Token(Token = "0x403F5EB")]
		[FieldOffset(Offset = "0x30")]
		public StageData stageData;

		// Token: 0x0403F5EC RID: 259564
		[Token(Token = "0x403F5EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A0F RID: 31247
		[Token(Token = "0x2007A0F")]
		public class Input
		{
			// Token: 0x0602BCC6 RID: 179398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BCC6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F5ED RID: 259565
			[Token(Token = "0x403F5ED")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x0403F5EE RID: 259566
			[Token(Token = "0x403F5EE")]
			[FieldOffset(Offset = "0x18")]
			public TemplateActivityLifeCycleViewModel.ActState state;
		}
	}
}
