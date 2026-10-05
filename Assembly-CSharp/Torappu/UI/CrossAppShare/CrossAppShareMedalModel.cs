using System;
using Il2CppDummyDll;
using Torappu.UI.Medal;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058D3 RID: 22739
	[Token(Token = "0x20058D3")]
	public class CrossAppShareMedalModel : CrossAppShareDynAssetBaseModel
	{
		// Token: 0x060212A1 RID: 135841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212A1")]
		[Address(RVA = "0x1B743A0", Offset = "0x1B72FA0", VA = "0x181B743A0")]
		public void InitModel(bool isActive, bool iIsDiy, UIMedalGroupView.GroupOptions iGroupOptions, UIMedalGroupView.DIYOptions iDiyOptions)
		{
		}

		// Token: 0x060212A2 RID: 135842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212A2")]
		[Address(RVA = "0x1B744F0", Offset = "0x1B730F0", VA = "0x181B744F0")]
		public CrossAppShareMedalModel()
		{
		}

		// Token: 0x0402D2C7 RID: 185031
		[Token(Token = "0x402D2C7")]
		[FieldOffset(Offset = "0x30")]
		public bool isDiy;

		// Token: 0x0402D2C8 RID: 185032
		[Token(Token = "0x402D2C8")]
		[FieldOffset(Offset = "0x38")]
		public UIMedalGroupView.GroupOptions groupOptions;

		// Token: 0x0402D2C9 RID: 185033
		[Token(Token = "0x402D2C9")]
		[FieldOffset(Offset = "0x50")]
		public UIMedalGroupView.DIYOptions diyOptions;

		// Token: 0x0402D2CA RID: 185034
		[Token(Token = "0x402D2CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0402D2CB RID: 185035
		[Token(Token = "0x402D2CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
