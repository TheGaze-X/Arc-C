using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	public class VersionCompat : ILuaCallCSharp
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008C")]
		public static string CUR_FUNC_VER
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x552C0C0", Offset = "0x552ACC0", VA = "0x18552C0C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x552BFE0", Offset = "0x552ABE0", VA = "0x18552BFE0")]
		public static void SetFuncVersion(string targetFuncVer)
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000066EC File Offset: 0x000048EC
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x552BF30", Offset = "0x552AB30", VA = "0x18552BF30")]
		public static bool FuncVersion(string requireVersion)
		{
			return default(bool);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x552BFA0", Offset = "0x552ABA0", VA = "0x18552BFA0")]
		public static string GetVersion4Display()
		{
			return null;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VersionCompat()
		{
		}

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x0")]
		private static string s_targetFunVer;
	}
}
