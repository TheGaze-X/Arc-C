using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058D2 RID: 22738
	[Token(Token = "0x20058D2")]
	public class CrossAppShareAvatarModel : CrossAppShareDynAssetBaseModel
	{
		// Token: 0x0602129E RID: 135838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602129E")]
		[Address(RVA = "0x1B70E40", Offset = "0x1B6FA40", VA = "0x181B70E40")]
		public void InitModel(bool isActive, PlayerAvatarQuery query)
		{
		}

		// Token: 0x0602129F RID: 135839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602129F")]
		[Address(RVA = "0x1B70F00", Offset = "0x1B6FB00", VA = "0x181B70F00")]
		public void InitModel(bool isActive, AvatarInfo avatarInfo)
		{
		}

		// Token: 0x060212A0 RID: 135840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212A0")]
		[Address(RVA = "0x1B71050", Offset = "0x1B6FC50", VA = "0x181B71050")]
		public CrossAppShareAvatarModel()
		{
		}

		// Token: 0x0402D2C3 RID: 185027
		[Token(Token = "0x402D2C3")]
		[FieldOffset(Offset = "0x30")]
		public PlayerAvatarQuery query;

		// Token: 0x0402D2C4 RID: 185028
		[Token(Token = "0x402D2C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0402D2C5 RID: 185029
		[Token(Token = "0x402D2C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_InitModel;

		// Token: 0x0402D2C6 RID: 185030
		[Token(Token = "0x402D2C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
