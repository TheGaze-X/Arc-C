using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000531 RID: 1329
	[Token(Token = "0x2000531")]
	public class PCKeyConst : IHotfixable
	{
		// Token: 0x06004FBE RID: 20414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x1AF65E0", Offset = "0x1AF51E0", VA = "0x181AF65E0")]
		public PCKeyConst()
		{
		}

		// Token: 0x04001451 RID: 5201
		[Token(Token = "0x4001451")]
		public const string DEFAULT_ESC_KEY_ID = "bannedEscape";

		// Token: 0x04001452 RID: 5202
		[Token(Token = "0x4001452")]
		public const int DEFAULT_ESC_KEY_CODE = 60;

		// Token: 0x04001453 RID: 5203
		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0x0")]
		public static readonly KeySettingGroupData DEFAULT_GROUP_DATA;

		// Token: 0x04001454 RID: 5204
		[Token(Token = "0x4001454")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
