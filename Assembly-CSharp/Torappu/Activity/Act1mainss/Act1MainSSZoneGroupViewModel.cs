using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007856 RID: 30806
	[Token(Token = "0x2007856")]
	public class Act1MainSSZoneGroupViewModel : TemplateActivityViewModel
	{
		// Token: 0x0602B320 RID: 176928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B320")]
		[Address(RVA = "0x271AF90", Offset = "0x2719B90", VA = "0x18271AF90")]
		public Act1MainSSZoneGroupViewModel(object param)
		{
		}

		// Token: 0x0602B321 RID: 176929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B321")]
		[Address(RVA = "0x271AE50", Offset = "0x2719A50", VA = "0x18271AE50")]
		public void LoadData(ActivityBasicInfo activityBasicInfo, string zoneId, TemplateActivityLifeCycleViewModel.ActState actState)
		{
		}

		// Token: 0x0403E732 RID: 255794
		[Token(Token = "0x403E732")]
		[FieldOffset(Offset = "0x20")]
		public bool isInActTime;

		// Token: 0x0403E733 RID: 255795
		[Token(Token = "0x403E733")]
		[FieldOffset(Offset = "0x21")]
		public bool isPassPreview;

		// Token: 0x0403E734 RID: 255796
		[Token(Token = "0x403E734")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403E735 RID: 255797
		[Token(Token = "0x403E735")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x02007857 RID: 30807
		[Token(Token = "0x2007857")]
		public class Input
		{
			// Token: 0x0602B322 RID: 176930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B322")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403E736 RID: 255798
			[Token(Token = "0x403E736")]
			[FieldOffset(Offset = "0x10")]
			public ActivityBasicInfo actBasicInfo;

			// Token: 0x0403E737 RID: 255799
			[Token(Token = "0x403E737")]
			[FieldOffset(Offset = "0x88")]
			public string zoneId;

			// Token: 0x0403E738 RID: 255800
			[Token(Token = "0x403E738")]
			[FieldOffset(Offset = "0x90")]
			public TemplateActivityLifeCycleViewModel.ActState actState;
		}
	}
}
