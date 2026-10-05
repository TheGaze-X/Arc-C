using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058D4 RID: 22740
	[Token(Token = "0x20058D4")]
	public class CrossAppShareIllustModel : CrossAppShareDynAssetBaseModel
	{
		// Token: 0x060212A3 RID: 135843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212A3")]
		[Address(RVA = "0x1B73FE0", Offset = "0x1B72BE0", VA = "0x181B73FE0")]
		public void InitModel(bool isActive, CharUISkinStruct iCharUISkinStruct)
		{
		}

		// Token: 0x060212A4 RID: 135844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212A4")]
		[Address(RVA = "0x1B740A0", Offset = "0x1B72CA0", VA = "0x181B740A0")]
		public CrossAppShareIllustModel()
		{
		}

		// Token: 0x0402D2CC RID: 185036
		[Token(Token = "0x402D2CC")]
		[FieldOffset(Offset = "0x30")]
		public CharUISkinStruct charUISkinStruct;

		// Token: 0x0402D2CD RID: 185037
		[Token(Token = "0x402D2CD")]
		[FieldOffset(Offset = "0x48")]
		public float illustScaleFactor;

		// Token: 0x0402D2CE RID: 185038
		[Token(Token = "0x402D2CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0402D2CF RID: 185039
		[Token(Token = "0x402D2CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
