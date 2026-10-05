using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F14 RID: 24340
	[Token(Token = "0x2005F14")]
	public class CharacterLvlupItemCardViewModel : IHotfixable
	{
		// Token: 0x17005363 RID: 21347
		// (get) Token: 0x06023436 RID: 144438 RVA: 0x000C0510 File Offset: 0x000BE710
		[Token(Token = "0x17005363")]
		public int gainExp
		{
			[Token(Token = "0x6023436")]
			[Address(RVA = "0x1DC69F0", Offset = "0x1DC55F0", VA = "0x181DC69F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06023437 RID: 144439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023437")]
		[Address(RVA = "0x1DC6990", Offset = "0x1DC5590", VA = "0x181DC6990")]
		public CharacterLvlupItemCardViewModel()
		{
		}

		// Token: 0x04030994 RID: 199060
		[Token(Token = "0x4030994")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel itemViewModel;

		// Token: 0x04030995 RID: 199061
		[Token(Token = "0x4030995")]
		[FieldOffset(Offset = "0x18")]
		public CharacterLvlupItemCardViewModel.Mode mode;

		// Token: 0x04030996 RID: 199062
		[Token(Token = "0x4030996")]
		[FieldOffset(Offset = "0x1C")]
		public bool needDescOnly;

		// Token: 0x04030997 RID: 199063
		[Token(Token = "0x4030997")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gainExp;

		// Token: 0x04030998 RID: 199064
		[Token(Token = "0x4030998")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F15 RID: 24341
		[Token(Token = "0x2005F15")]
		public enum Mode
		{
			// Token: 0x0403099A RID: 199066
			[Token(Token = "0x403099A")]
			SELECTED_MODE,
			// Token: 0x0403099B RID: 199067
			[Token(Token = "0x403099B")]
			DISPLAY_MODE,
			// Token: 0x0403099C RID: 199068
			[Token(Token = "0x403099C")]
			COUNTING_MODE
		}
	}
}
