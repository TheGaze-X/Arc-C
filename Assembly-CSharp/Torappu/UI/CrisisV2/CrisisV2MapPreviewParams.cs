using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005965 RID: 22885
	[Token(Token = "0x2005965")]
	public struct CrisisV2MapPreviewParams : IHotfixable
	{
		// Token: 0x060215A8 RID: 136616 RVA: 0x000B9AA8 File Offset: 0x000B7CA8
		[Token(Token = "0x60215A8")]
		[Address(RVA = "0x1BB0B40", Offset = "0x1BAF740", VA = "0x181BB0B40")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0402D7BD RID: 186301
		[Token(Token = "0x402D7BD")]
		[FieldOffset(Offset = "0x0")]
		public string targetId;

		// Token: 0x0402D7BE RID: 186302
		[Token(Token = "0x402D7BE")]
		[FieldOffset(Offset = "0x8")]
		public CrisisV2MapModel.TargetType targetType;

		// Token: 0x0402D7BF RID: 186303
		[Token(Token = "0x402D7BF")]
		[FieldOffset(Offset = "0xC")]
		public CrisisV2MapModel.ViewType viewType;

		// Token: 0x0402D7C0 RID: 186304
		[Token(Token = "0x402D7C0")]
		[FieldOffset(Offset = "0x0")]
		public static CrisisV2MapPreviewParams EMPTY_PARAM;

		// Token: 0x0402D7C1 RID: 186305
		[Token(Token = "0x402D7C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsEmpty;
	}
}
