using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	public class LuaGlobalRefs : Singleton<LuaGlobalRefs>
	{
		// Token: 0x060061EA RID: 25066 RVA: 0x0002FF28 File Offset: 0x0002E128
		[Token(Token = "0x60061EA")]
		[Address(RVA = "0x1DEE7C0", Offset = "0x1DED3C0", VA = "0x181DEE7C0")]
		public int Alloc(IDisposable target)
		{
			return 0;
		}

		// Token: 0x060061EB RID: 25067 RVA: 0x0002FF40 File Offset: 0x0002E140
		[Token(Token = "0x60061EB")]
		[Address(RVA = "0x1DEE8F0", Offset = "0x1DED4F0", VA = "0x181DEE8F0")]
		public bool Dispose(int index)
		{
			return default(bool);
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061EC")]
		[Address(RVA = "0x1DEEA40", Offset = "0x1DED640", VA = "0x181DEEA40")]
		public static void LuaManagerOnly_DisposeAll()
		{
		}

		// Token: 0x060061ED RID: 25069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061ED")]
		[Address(RVA = "0x1DEEC50", Offset = "0x1DED850", VA = "0x181DEEC50")]
		private LuaGlobalRefs()
		{
		}

		// Token: 0x04002BC3 RID: 11203
		[Token(Token = "0x4002BC3")]
		public const int EMPTY_REF = 0;

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x10")]
		private int m_refIndex;

		// Token: 0x04002BC5 RID: 11205
		[Token(Token = "0x4002BC5")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, WeakReference> m_refs;

		// Token: 0x04002BC6 RID: 11206
		[Token(Token = "0x4002BC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Alloc;

		// Token: 0x04002BC7 RID: 11207
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LuaManagerOnly_DisposeAll;

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
