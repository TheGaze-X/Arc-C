using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DB
{
	// Token: 0x0200169F RID: 5791
	[Token(Token = "0x200169F")]
	public class GameDataAccessor : CommonGameDataAccessor
	{
		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x060092B2 RID: 37554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F97")]
		public override Dictionary<string, string> richTextStyles
		{
			[Token(Token = "0x60092B2")]
			[Address(RVA = "0x2B39D70", Offset = "0x2B38970", VA = "0x182B39D70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B3")]
		[Address(RVA = "0x2B39D10", Offset = "0x2B38910", VA = "0x182B39D10")]
		public GameDataAccessor()
		{
		}

		// Token: 0x04008854 RID: 34900
		[Token(Token = "0x4008854")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_richTextStyles;

		// Token: 0x04008855 RID: 34901
		[Token(Token = "0x4008855")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
