using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x0200700A RID: 28682
	[Token(Token = "0x200700A")]
	public class ActMultiV3StageModeGroupTitleViewModel : IHotfixable
	{
		// Token: 0x06028B7A RID: 166778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B7A")]
		[Address(RVA = "0x2414E60", Offset = "0x2413A60", VA = "0x182414E60")]
		public ActMultiV3StageModeGroupTitleViewModel()
		{
		}

		// Token: 0x0403A0CA RID: 237770
		[Token(Token = "0x403A0CA")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x0403A0CB RID: 237771
		[Token(Token = "0x403A0CB")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3MapModeType modeType;

		// Token: 0x0403A0CC RID: 237772
		[Token(Token = "0x403A0CC")]
		[FieldOffset(Offset = "0x20")]
		public string modeName;

		// Token: 0x0403A0CD RID: 237773
		[Token(Token = "0x403A0CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
