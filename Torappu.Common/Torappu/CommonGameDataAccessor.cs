using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	public abstract class CommonGameDataAccessor : LazySingleton<CommonGameDataAccessor>
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000540 RID: 1344
		[Token(Token = "0x17000067")]
		public abstract Dictionary<string, string> richTextStyles { [Token(Token = "0x6000540")] get; }

		// Token: 0x06000541 RID: 1345 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x54FBD40", Offset = "0x54FA940", VA = "0x1854FBD40")]
		protected CommonGameDataAccessor()
		{
		}

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
