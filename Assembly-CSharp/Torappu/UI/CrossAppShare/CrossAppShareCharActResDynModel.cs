using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058C8 RID: 22728
	[Token(Token = "0x20058C8")]
	public class CrossAppShareCharActResDynModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x06021292 RID: 135826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021292")]
		[Address(RVA = "0x1B71A30", Offset = "0x1B70630", VA = "0x181B71A30")]
		public CrossAppShareCharActResDynModel()
		{
		}

		// Token: 0x0402D2A1 RID: 184993
		[Token(Token = "0x402D2A1")]
		[FieldOffset(Offset = "0x18")]
		public bool needActId;

		// Token: 0x0402D2A2 RID: 184994
		[Token(Token = "0x402D2A2")]
		[FieldOffset(Offset = "0x19")]
		public bool needColorId;

		// Token: 0x0402D2A3 RID: 184995
		[Token(Token = "0x402D2A3")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0402D2A4 RID: 184996
		[Token(Token = "0x402D2A4")]
		[FieldOffset(Offset = "0x28")]
		public string colorId;

		// Token: 0x0402D2A5 RID: 184997
		[Token(Token = "0x402D2A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
