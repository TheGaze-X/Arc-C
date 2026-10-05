using System;
using Il2CppDummyDll;
using Torappu.UI.Home;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006640 RID: 26176
	[Token(Token = "0x2006640")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ArtGalleryUnlockDescGenerator
	{
		// Token: 0x06025985 RID: 153989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025985")]
		[Address(RVA = "0x208D830", Offset = "0x208C430", VA = "0x18208D830")]
		public static string GenUnlockCondition(CommonLimitObtainModel limitObtainItemModel, bool isLimitItem, string unlockDesPre, string unlockCondFormat)
		{
			return null;
		}

		// Token: 0x06025986 RID: 153990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025986")]
		[Address(RVA = "0x208D6A0", Offset = "0x208C2A0", VA = "0x18208D6A0")]
		public static string GenAvatarUnlockCondition(CommonLimitObtainModel limitObtainItemModel, bool isLimitItem, string unlockCond)
		{
			return null;
		}

		// Token: 0x04034D23 RID: 216355
		[Token(Token = "0x4034D23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenUnlockCondition;

		// Token: 0x04034D24 RID: 216356
		[Token(Token = "0x4034D24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenAvatarUnlockCondition;
	}
}
