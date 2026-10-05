using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047CD RID: 18381
	[Token(Token = "0x20047CD")]
	public class PlayerAvatarDisplayStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601BD28 RID: 113960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD28")]
		[Address(RVA = "0x1527480", Offset = "0x1526080", VA = "0x181527480")]
		public void FillDataByItem(UIItemViewModel model)
		{
		}

		// Token: 0x0601BD29 RID: 113961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD29")]
		[Address(RVA = "0x1527630", Offset = "0x1526230", VA = "0x181527630")]
		public PlayerAvatarDisplayStateBean()
		{
		}

		// Token: 0x04024334 RID: 148276
		[Token(Token = "0x4024334")]
		[FieldOffset(Offset = "0x10")]
		public PlayerAvatarDisplayProperty property;

		// Token: 0x04024335 RID: 148277
		[Token(Token = "0x4024335")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FillDataByItem;

		// Token: 0x04024336 RID: 148278
		[Token(Token = "0x4024336")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
