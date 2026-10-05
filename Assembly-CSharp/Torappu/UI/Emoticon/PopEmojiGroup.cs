using System;
using Il2CppDummyDll;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050D2 RID: 20690
	[Token(Token = "0x20050D2")]
	public struct PopEmojiGroup
	{
		// Token: 0x0601E99A RID: 125338 RVA: 0x000AF0C8 File Offset: 0x000AD2C8
		[Token(Token = "0x601E99A")]
		[Address(RVA = "0x184CE70", Offset = "0x184BA70", VA = "0x18184CE70")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0402900F RID: 167951
		[Token(Token = "0x402900F")]
		[FieldOffset(Offset = "0x0")]
		public EmojiItemModel model;

		// Token: 0x04029010 RID: 167952
		[Token(Token = "0x4029010")]
		[FieldOffset(Offset = "0x8")]
		public EmoticonPopEmojiItemBaseView view;
	}
}
