using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	public struct UIWebScheme : IHotfixable
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000E5")]
		public string title
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x5560EC0", Offset = "0x555FAC0", VA = "0x185560EC0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x5561050", Offset = "0x555FC50", VA = "0x185561050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000E6")]
		public string path
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x5560E40", Offset = "0x555FA40", VA = "0x185560E40")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x5560FC0", Offset = "0x555FBC0", VA = "0x185560FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000E7")]
		public Dictionary<string, string> args
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x5560DC0", Offset = "0x555F9C0", VA = "0x185560DC0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x5560F30", Offset = "0x555FB30", VA = "0x185560F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x5560870", Offset = "0x555F470", VA = "0x185560870")]
		public UIWebScheme(string schemeStr)
		{
		}

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate203 __Hotfix0_get_title;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate204 __Hotfix0_set_title;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate203 __Hotfix0_get_path;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate204 __Hotfix0_set_path;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate205 __Hotfix0_get_args;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate204 __Hotfix0_set_args;

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate204 _c__Hotfix0_ctor;
	}
}
