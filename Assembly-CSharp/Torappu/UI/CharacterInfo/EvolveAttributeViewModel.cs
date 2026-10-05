using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F10 RID: 24336
	[Token(Token = "0x2005F10")]
	public class EvolveAttributeViewModel
	{
		// Token: 0x06023412 RID: 144402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023412")]
		[Address(RVA = "0x1DD0EC0", Offset = "0x1DCFAC0", VA = "0x181DD0EC0")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x06023413 RID: 144403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023413")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EvolveAttributeViewModel()
		{
		}

		// Token: 0x04030969 RID: 199017
		[Token(Token = "0x4030969")]
		[FieldOffset(Offset = "0x10")]
		public EvolvePhase targetEvolvePhase;

		// Token: 0x0403096A RID: 199018
		[Token(Token = "0x403096A")]
		[FieldOffset(Offset = "0x18")]
		public RichTextModel[][] evolveDesc;
	}
}
