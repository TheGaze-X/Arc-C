using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072A6 RID: 29350
	[Token(Token = "0x20072A6")]
	public class Act46SideMapDecorTrapViewModel : TemplateActivityViewModel
	{
		// Token: 0x060298DB RID: 170203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298DB")]
		[Address(RVA = "0x24FEB70", Offset = "0x24FD770", VA = "0x1824FEB70")]
		public Act46SideMapDecorTrapViewModel(object param)
		{
		}

		// Token: 0x060298DC RID: 170204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298DC")]
		[Address(RVA = "0x24FE900", Offset = "0x24FD500", VA = "0x1824FE900")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0403B68B RID: 243339
		[Token(Token = "0x403B68B")]
		[FieldOffset(Offset = "0x20")]
		public string domainId;

		// Token: 0x0403B68C RID: 243340
		[Token(Token = "0x403B68C")]
		[FieldOffset(Offset = "0x28")]
		public string currTrapId;

		// Token: 0x0403B68D RID: 243341
		[Token(Token = "0x403B68D")]
		[FieldOffset(Offset = "0x30")]
		public bool isUnlock;

		// Token: 0x0403B68E RID: 243342
		[Token(Token = "0x403B68E")]
		[FieldOffset(Offset = "0x38")]
		public string lockedToast;

		// Token: 0x0403B68F RID: 243343
		[Token(Token = "0x403B68F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403B690 RID: 243344
		[Token(Token = "0x403B690")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x020072A7 RID: 29351
		[Token(Token = "0x20072A7")]
		public class Input
		{
			// Token: 0x060298DD RID: 170205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60298DD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B691 RID: 243345
			[Token(Token = "0x403B691")]
			[FieldOffset(Offset = "0x10")]
			public Act46SideData actData;

			// Token: 0x0403B692 RID: 243346
			[Token(Token = "0x403B692")]
			[FieldOffset(Offset = "0x18")]
			public ActivityBasicInfo actBasicInfo;
		}
	}
}
