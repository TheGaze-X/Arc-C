using System;
using Il2CppDummyDll;
using Torappu;
using XLua;

namespace HGSDK
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	public class APIV2RespWrapper<DataType> : IAPIV2Response, IHotfixable
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000515")]
		public void DontImplThisInBusinessLayer()
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000516")]
		public APIV2RespWrapper()
		{
		}

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x0")]
		public int status;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x0")]
		public string msg;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x0")]
		public DataType data;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DontImplThisInBusinessLayer;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
