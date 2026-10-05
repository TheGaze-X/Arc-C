using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020035D6 RID: 13782
	[Token(Token = "0x20035D6")]
	public interface ICommonSquadChar : ICharacterCardViewModel, IHotfixable, IComparableChar
	{
		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x06015EDE RID: 89822 RVA: 0x0008EAE8 File Offset: 0x0008CCE8
		[Token(Token = "0x170034B2")]
		bool isPredefined
		{
			[Token(Token = "0x6015EDE")]
			[Address(RVA = "0xE7BA80", Offset = "0xE7A680", VA = "0x180E7BA80", Slot = "0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015EDF RID: 89823
		[Token(Token = "0x6015EDF")]
		void UpdateMember(DataBundle updateDataInput);
	}
}
