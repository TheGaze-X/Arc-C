using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047D6 RID: 18390
	[Token(Token = "0x20047D6")]
	public class PlayerAvatarGroupViewModel : IHotfixable
	{
		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x0601BD49 RID: 113993 RVA: 0x000A6668 File Offset: 0x000A4868
		[Token(Token = "0x1700422C")]
		public PlayerAvatarGroupType groupType
		{
			[Token(Token = "0x601BD49")]
			[Address(RVA = "0x1528A70", Offset = "0x1527670", VA = "0x181528A70")]
			get
			{
				return PlayerAvatarGroupType.NONE;
			}
		}

		// Token: 0x0601BD4A RID: 113994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD4A")]
		[Address(RVA = "0x1528980", Offset = "0x1527580", VA = "0x181528980")]
		public void AddAvatar(PlayerAvatarItemViewModel viewModel)
		{
		}

		// Token: 0x0601BD4B RID: 113995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD4B")]
		[Address(RVA = "0x1528A10", Offset = "0x1527610", VA = "0x181528A10")]
		public PlayerAvatarGroupViewModel()
		{
		}

		// Token: 0x04024374 RID: 148340
		[Token(Token = "0x4024374")]
		[FieldOffset(Offset = "0x10")]
		public PlayerAvatarGroupData data;

		// Token: 0x04024375 RID: 148341
		[Token(Token = "0x4024375")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerAvatarItemViewModel> avatarItemList;

		// Token: 0x04024376 RID: 148342
		[Token(Token = "0x4024376")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupType;

		// Token: 0x04024377 RID: 148343
		[Token(Token = "0x4024377")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddAvatar;

		// Token: 0x04024378 RID: 148344
		[Token(Token = "0x4024378")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
