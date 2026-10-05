using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x20002B6")]
	public static class HotfixDelegateBridge
	{
		// Token: 0x060036BE RID: 14014 RVA: 0x00016458 File Offset: 0x00014658
		[Token(Token = "0x60036BE")]
		[Address(RVA = "0x331D030", Offset = "0x331BC30", VA = "0x18331D030")]
		public static bool xlua_get_hotfix_flag(int idx)
		{
			return default(bool);
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x331CD80", Offset = "0x331B980", VA = "0x18331CD80")]
		public static DelegateBridge Get(int idx)
		{
			return null;
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x331CDF0", Offset = "0x331B9F0", VA = "0x18331CDF0")]
		public static void Set(int idx, DelegateBridge val)
		{
		}
	}
}
