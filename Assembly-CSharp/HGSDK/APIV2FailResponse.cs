using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.Network;
using XLua;

namespace HGSDK
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	public struct APIV2FailResponse : IHotfixable
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x6000511")]
		public static APIV2FailResponse FromResponse<RespDataType>(APIV2RespWrapper<RespDataType> response) where RespDataType : APIV2ResponseBase
		{
			return default(APIV2FailResponse);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1028240", Offset = "0x1026E40", VA = "0x181028240")]
		public string GetProperFailMsg()
		{
			return null;
		}

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x0")]
		public bool isCaptchaFailed;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x1")]
		public bool isPhoneCodeFailed;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x8")]
		public ResponseError error;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x30")]
		public int status;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x38")]
		public string msg;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x40")]
		public string errorAlertTmpl;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x48")]
		public APIV2ResponseBase respBody;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FromResponse;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProperFailMsg;
	}
}
