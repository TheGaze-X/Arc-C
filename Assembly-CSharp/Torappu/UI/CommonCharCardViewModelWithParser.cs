using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035AF RID: 13743
	[Token(Token = "0x20035AF")]
	public abstract class CommonCharCardViewModelWithParser : CommonCharCardViewModel, ICharCardViewModelParser, ICommonSquadChar, ICharacterCardViewModel, IHotfixable, IComparableChar
	{
		// Token: 0x06015DED RID: 89581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015DED")]
		[Address(RVA = "0xE5CC60", Offset = "0xE5B860", VA = "0x180E5CC60", Slot = "55")]
		public CharacterCardViewModel ParseToCharCardViewModel()
		{
			return null;
		}

		// Token: 0x06015DEE RID: 89582
		[Token(Token = "0x6015DEE")]
		public abstract void ParseFromCharCardViewModel(CharacterCardViewModel characterCardViewModel);

		// Token: 0x06015DEF RID: 89583
		[Token(Token = "0x6015DEF")]
		public abstract void UpdateMember(DataBundle updateDataInput);

		// Token: 0x06015DF0 RID: 89584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DF0")]
		[Address(RVA = "0xE5D2A0", Offset = "0xE5BEA0", VA = "0x180E5D2A0")]
		protected CommonCharCardViewModelWithParser()
		{
		}

		// Token: 0x0401A4C9 RID: 107721
		[Token(Token = "0x401A4C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ParseToCharCardViewModel;

		// Token: 0x0401A4CA RID: 107722
		[Token(Token = "0x401A4CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
