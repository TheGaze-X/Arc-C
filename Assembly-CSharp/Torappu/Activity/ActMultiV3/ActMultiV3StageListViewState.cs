using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007001 RID: 28673
	[Token(Token = "0x2007001")]
	public abstract class ActMultiV3StageListViewState : PopupFadeState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06028B46 RID: 166726
		[Token(Token = "0x6028B46")]
		public abstract void OnMessage(int key, ValueBundle msg);

		// Token: 0x06028B47 RID: 166727
		[Token(Token = "0x6028B47")]
		public abstract void HandleCallBack(int instId, ValueBundle output);

		// Token: 0x06028B48 RID: 166728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B48")]
		[Address(RVA = "0x2414390", Offset = "0x2412F90", VA = "0x182414390")]
		protected ActMultiV3StageListViewState()
		{
		}

		// Token: 0x0403A050 RID: 237648
		[Token(Token = "0x403A050")]
		[NonSerialized]
		public const int ON_TAB_CLICKED = 0;

		// Token: 0x0403A051 RID: 237649
		[Token(Token = "0x403A051")]
		[NonSerialized]
		public const int ON_STAGE_CLICKED = 1;

		// Token: 0x0403A052 RID: 237650
		[Token(Token = "0x403A052")]
		[NonSerialized]
		public const int ON_BACK_BTN_CLICKED = 2;

		// Token: 0x0403A053 RID: 237651
		[Token(Token = "0x403A053")]
		[NonSerialized]
		public const int ON_INFO_BTN_CLICKED = 3;

		// Token: 0x0403A054 RID: 237652
		[Token(Token = "0x403A054")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
