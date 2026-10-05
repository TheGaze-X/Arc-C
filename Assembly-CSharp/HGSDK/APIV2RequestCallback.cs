using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	public struct APIV2RequestCallback<RespDataType>
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000513")]
		public void InvokeFailCallback(APIV2FailResponse response)
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000514")]
		public void InvokeSucCallback(APIV2RespWrapper<RespDataType> response)
		{
		}

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[FieldOffset(Offset = "0x0")]
		public Action<APIV2RespWrapper<RespDataType>> onSuc;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x0")]
		public Action<APIV2FailResponse> onFail;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x0")]
		public string errorAlertTmpl;
	}
}
