using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058D1 RID: 22737
	[Token(Token = "0x20058D1")]
	public abstract class CrossAppShareDynAssetBaseModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x0602129D RID: 135837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602129D")]
		[Address(RVA = "0x1B73A20", Offset = "0x1B72620", VA = "0x181B73A20")]
		protected CrossAppShareDynAssetBaseModel()
		{
		}

		// Token: 0x0402D2C0 RID: 185024
		[Token(Token = "0x402D2C0")]
		[FieldOffset(Offset = "0x18")]
		public CrossAppShareDynAssetType dynAssetType;

		// Token: 0x0402D2C1 RID: 185025
		[Token(Token = "0x402D2C1")]
		[FieldOffset(Offset = "0x1C")]
		public CrossAppShareElementScaleStruct scaleStruct;

		// Token: 0x0402D2C2 RID: 185026
		[Token(Token = "0x402D2C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
