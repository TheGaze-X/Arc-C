using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035C8 RID: 13768
	[Token(Token = "0x20035C8")]
	public class DefaultCommonCharCardViewModel : CommonCharCardViewModelWithParser, ICommonSquadChar, ICharacterCardViewModel, IHotfixable, IComparableChar
	{
		// Token: 0x06015E8F RID: 89743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E8F")]
		[Address(RVA = "0xE673F0", Offset = "0xE65FF0", VA = "0x180E673F0")]
		public void SetSkinId(string newSkinId)
		{
		}

		// Token: 0x06015E90 RID: 89744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E90")]
		[Address(RVA = "0xE67340", Offset = "0xE65F40", VA = "0x180E67340", Slot = "59")]
		public override void ParseFromCharCardViewModel(CharacterCardViewModel characterCardViewModel)
		{
		}

		// Token: 0x06015E91 RID: 89745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E91")]
		[Address(RVA = "0xE674B0", Offset = "0xE660B0", VA = "0x180E674B0", Slot = "60")]
		public override void UpdateMember(DataBundle updateDataInput)
		{
		}

		// Token: 0x06015E92 RID: 89746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E92")]
		[Address(RVA = "0xE676D0", Offset = "0xE662D0", VA = "0x180E676D0")]
		public DefaultCommonCharCardViewModel()
		{
		}

		// Token: 0x0401A591 RID: 107921
		[Token(Token = "0x401A591")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSkinId;

		// Token: 0x0401A592 RID: 107922
		[Token(Token = "0x401A592")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ParseFromCharCardViewModel;

		// Token: 0x0401A593 RID: 107923
		[Token(Token = "0x401A593")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateMember;

		// Token: 0x0401A594 RID: 107924
		[Token(Token = "0x401A594")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035C9 RID: 13769
		[Token(Token = "0x20035C9")]
		public class DefaultCharCache : CommonSquadCharCache<DefaultCommonCharCardViewModel>
		{
			// Token: 0x06015E93 RID: 89747 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015E93")]
			[Address(RVA = "0xE66F30", Offset = "0xE65B30", VA = "0x180E66F30", Slot = "19")]
			public override DefaultCommonCharCardViewModel DecodeFromCache(CommonSquadGroupViewModel commonSquadGroupViewModel)
			{
				return null;
			}

			// Token: 0x06015E94 RID: 89748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015E94")]
			[Address(RVA = "0xE672D0", Offset = "0xE65ED0", VA = "0x180E672D0")]
			public DefaultCharCache()
			{
			}

			// Token: 0x0401A595 RID: 107925
			[Token(Token = "0x401A595")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DecodeFromCache;

			// Token: 0x0401A596 RID: 107926
			[Token(Token = "0x401A596")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
