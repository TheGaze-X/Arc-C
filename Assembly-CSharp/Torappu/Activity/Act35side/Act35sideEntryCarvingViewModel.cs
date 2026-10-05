using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x02007472 RID: 29810
	[Token(Token = "0x2007472")]
	public class Act35sideEntryCarvingViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x0602A0D6 RID: 172246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0D6")]
		[Address(RVA = "0x2597F50", Offset = "0x2596B50", VA = "0x182597F50")]
		public Act35sideEntryCarvingViewModel(object param)
		{
		}

		// Token: 0x0602A0D7 RID: 172247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0D7")]
		[Address(RVA = "0x2597DB0", Offset = "0x25969B0", VA = "0x182597DB0")]
		public void RefreshStatus()
		{
		}

		// Token: 0x0403C56B RID: 247147
		[Token(Token = "0x403C56B")]
		[FieldOffset(Offset = "0x20")]
		public Act35sideEntryCarvingViewModel.Status currStatus;

		// Token: 0x0403C56C RID: 247148
		[Token(Token = "0x403C56C")]
		[FieldOffset(Offset = "0x28")]
		private string m_actId;

		// Token: 0x0403C56D RID: 247149
		[Token(Token = "0x403C56D")]
		[FieldOffset(Offset = "0x30")]
		private DateTime m_actStartTs;

		// Token: 0x0403C56E RID: 247150
		[Token(Token = "0x403C56E")]
		[FieldOffset(Offset = "0x38")]
		private DateTime m_actEndTs;

		// Token: 0x0403C56F RID: 247151
		[Token(Token = "0x403C56F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403C570 RID: 247152
		[Token(Token = "0x403C570")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshStatus;

		// Token: 0x02007473 RID: 29811
		[Token(Token = "0x2007473")]
		public class Input
		{
			// Token: 0x0602A0D8 RID: 172248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A0D8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403C571 RID: 247153
			[Token(Token = "0x403C571")]
			[FieldOffset(Offset = "0x10")]
			public Act35SideData gameData;

			// Token: 0x0403C572 RID: 247154
			[Token(Token = "0x403C572")]
			[FieldOffset(Offset = "0x18")]
			public ActivityBasicInfo actBasicInfo;
		}

		// Token: 0x02007474 RID: 29812
		[Token(Token = "0x2007474")]
		public enum Status
		{
			// Token: 0x0403C574 RID: 247156
			[Token(Token = "0x403C574")]
			LOCKED,
			// Token: 0x0403C575 RID: 247157
			[Token(Token = "0x403C575")]
			TIME_OUT,
			// Token: 0x0403C576 RID: 247158
			[Token(Token = "0x403C576")]
			UNLOCK_NORMAL,
			// Token: 0x0403C577 RID: 247159
			[Token(Token = "0x403C577")]
			UNLOCK_WITH_NEW_CONTENT
		}
	}
}
