using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001889 RID: 6281
	[Token(Token = "0x2001889")]
	public interface IDIYRoomModifierManager : IDIYRoomModifierProvider
	{
		// Token: 0x06009EE0 RID: 40672
		[Token(Token = "0x6009EE0")]
		void AddDIYRoomModifier(DIYRoomModifier modifier);

		// Token: 0x06009EE1 RID: 40673
		[Token(Token = "0x6009EE1")]
		void RemoveDIYRoomModifier(DIYRoomModifier modifier);

		// Token: 0x06009EE2 RID: 40674
		[Token(Token = "0x6009EE2")]
		void ClearDIYRoomModifier();
	}
}
