using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058CE RID: 22734
	[Token(Token = "0x20058CE")]
	public class CrossAppSharePlayerInfoModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x0602129A RID: 135834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602129A")]
		[Address(RVA = "0x1B75B40", Offset = "0x1B74740", VA = "0x181B75B40")]
		public void InitModel(bool active)
		{
		}

		// Token: 0x0602129B RID: 135835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602129B")]
		[Address(RVA = "0x1B75CF0", Offset = "0x1B748F0", VA = "0x181B75CF0")]
		public CrossAppSharePlayerInfoModel()
		{
		}

		// Token: 0x0402D2B3 RID: 185011
		[Token(Token = "0x402D2B3")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x0402D2B4 RID: 185012
		[Token(Token = "0x402D2B4")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarQuery query;

		// Token: 0x0402D2B5 RID: 185013
		[Token(Token = "0x402D2B5")]
		[FieldOffset(Offset = "0x38")]
		public string uid;

		// Token: 0x0402D2B6 RID: 185014
		[Token(Token = "0x402D2B6")]
		[FieldOffset(Offset = "0x40")]
		public string nickName;

		// Token: 0x0402D2B7 RID: 185015
		[Token(Token = "0x402D2B7")]
		[FieldOffset(Offset = "0x48")]
		public string nickNum;

		// Token: 0x0402D2B8 RID: 185016
		[Token(Token = "0x402D2B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0402D2B9 RID: 185017
		[Token(Token = "0x402D2B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
