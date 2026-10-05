using System;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x02006064 RID: 24676
	[Token(Token = "0x2006064")]
	public struct CarvingCardTokenStatus
	{
		// Token: 0x17005431 RID: 21553
		// (get) Token: 0x06023ACD RID: 146125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005431")]
		public string cardId
		{
			[Token(Token = "0x6023ACD")]
			[Address(RVA = "0x1E42540", Offset = "0x1E41140", VA = "0x181E42540")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023ACE RID: 146126 RVA: 0x000C1848 File Offset: 0x000BFA48
		[Token(Token = "0x6023ACE")]
		[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x040316FC RID: 202492
		[Token(Token = "0x40316FC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CarvingCardTokenStatus NONE;

		// Token: 0x040316FD RID: 202493
		[Token(Token = "0x40316FD")]
		[FieldOffset(Offset = "0x0")]
		public CarvingMainCardViewModel cardViewModel;

		// Token: 0x040316FE RID: 202494
		[Token(Token = "0x40316FE")]
		[FieldOffset(Offset = "0x8")]
		public int slotIndex;

		// Token: 0x040316FF RID: 202495
		[Token(Token = "0x40316FF")]
		[FieldOffset(Offset = "0xC")]
		public CarvingCardPosition source;

		// Token: 0x04031700 RID: 202496
		[Token(Token = "0x4031700")]
		[FieldOffset(Offset = "0x10")]
		public bool inHandArea;
	}
}
