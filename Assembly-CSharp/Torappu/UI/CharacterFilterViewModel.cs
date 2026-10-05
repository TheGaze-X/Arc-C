using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Home;
using Torappu.UI.Roguelike;

namespace Torappu.UI
{
	// Token: 0x02003505 RID: 13573
	[Token(Token = "0x2003505")]
	public class CharacterFilterViewModel
	{
		// Token: 0x06015A8A RID: 88714 RVA: 0x0008D498 File Offset: 0x0008B698
		[Token(Token = "0x6015A8A")]
		[Address(RVA = "0xE35E90", Offset = "0xE34A90", VA = "0x180E35E90")]
		public bool IsValid(CharacterCardViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06015A8B RID: 88715 RVA: 0x0008D4B0 File Offset: 0x0008B6B0
		[Token(Token = "0x6015A8B")]
		[Address(RVA = "0xE35DD0", Offset = "0xE349D0", VA = "0x180E35DD0")]
		public bool IsValid(RoguelikeCharCardViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06015A8C RID: 88716 RVA: 0x0008D4C8 File Offset: 0x0008B6C8
		[Token(Token = "0x6015A8C")]
		[Address(RVA = "0xE35D10", Offset = "0xE34910", VA = "0x180E35D10")]
		public bool IsValid(HomeSecretaryCardViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x06015A8D RID: 88717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003379")]
		[Inspect]
		public List<CharacterFilterElement> elements
		{
			[Token(Token = "0x6015A8D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015A8E RID: 88718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A8E")]
		[Address(RVA = "0xE35F50", Offset = "0xE34B50", VA = "0x180E35F50")]
		public void Set(CharacterFilterViewModel filter)
		{
		}

		// Token: 0x06015A8F RID: 88719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A8F")]
		[Address(RVA = "0xE35AC0", Offset = "0xE346C0", VA = "0x180E35AC0")]
		public static CharacterFilterViewModel CreateFromProfessionMask(ProfessionCategory professionMask)
		{
			return null;
		}

		// Token: 0x06015A90 RID: 88720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A90")]
		[Address(RVA = "0xE35FD0", Offset = "0xE34BD0", VA = "0x180E35FD0")]
		public CharacterFilterViewModel()
		{
		}

		// Token: 0x04019F82 RID: 106370
		[Token(Token = "0x4019F82")]
		[FieldOffset(Offset = "0x10")]
		public bool isAll;

		// Token: 0x04019F83 RID: 106371
		[Token(Token = "0x4019F83")]
		[FieldOffset(Offset = "0x18")]
		private List<CharacterFilterElement> m_elements;
	}
}
