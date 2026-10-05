using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.DB
{
	// Token: 0x0200168E RID: 5774
	[Token(Token = "0x200168E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ConverterConsts
	{
		// Token: 0x06009256 RID: 37462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009256")]
		[Address(RVA = "0x2B2D120", Offset = "0x2B2BD20", VA = "0x182B2D120")]
		public static JsonSerializerSettings CreateGeneralDBSettings(bool useIdent)
		{
			return null;
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009257")]
		[Address(RVA = "0x2B2D340", Offset = "0x2B2BF40", VA = "0x182B2D340")]
		public static void OpenDBStringDedup()
		{
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009258")]
		[Address(RVA = "0x2B2D020", Offset = "0x2B2BC20", VA = "0x182B2D020")]
		public static void CloseDBStringDedup()
		{
		}

		// Token: 0x04008824 RID: 34852
		[Token(Token = "0x4008824")]
		[FieldOffset(Offset = "0x0")]
		private static IDedupPool s_dedupPool;

		// Token: 0x04008825 RID: 34853
		[Token(Token = "0x4008825")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateGeneralDBSettings;

		// Token: 0x04008826 RID: 34854
		[Token(Token = "0x4008826")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenDBStringDedup;

		// Token: 0x04008827 RID: 34855
		[Token(Token = "0x4008827")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CloseDBStringDedup;
	}
}
