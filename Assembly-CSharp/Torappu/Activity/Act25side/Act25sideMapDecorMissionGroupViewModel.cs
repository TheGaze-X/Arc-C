using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007535 RID: 30005
	[Token(Token = "0x2007535")]
	public class Act25sideMapDecorMissionGroupViewModel : TemplateActivityViewModel
	{
		// Token: 0x0602A45C RID: 173148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A45C")]
		[Address(RVA = "0x25DF250", Offset = "0x25DDE50", VA = "0x1825DF250")]
		public void LoadData()
		{
		}

		// Token: 0x0602A45D RID: 173149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A45D")]
		[Address(RVA = "0x25DF640", Offset = "0x25DE240", VA = "0x1825DF640")]
		public Act25sideMapDecorMissionGroupViewModel(object param)
		{
		}

		// Token: 0x0403CC7F RID: 248959
		[Token(Token = "0x403CC7F")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403CC80 RID: 248960
		[Token(Token = "0x403CC80")]
		[FieldOffset(Offset = "0x28")]
		public List<Act25sideMapDecorMissionViewModel> missions;

		// Token: 0x0403CC81 RID: 248961
		[Token(Token = "0x403CC81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC82 RID: 248962
		[Token(Token = "0x403CC82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007536 RID: 30006
		[Token(Token = "0x2007536")]
		public class Input
		{
			// Token: 0x0602A45E RID: 173150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A45E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403CC83 RID: 248963
			[Token(Token = "0x403CC83")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
