using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001888 RID: 6280
	[Token(Token = "0x2001888")]
	public interface IDIYRoomModifierProvider
	{
		// Token: 0x06009EDC RID: 40668
		[Token(Token = "0x6009EDC")]
		void QueryData(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action);

		// Token: 0x06009EDD RID: 40669
		[Token(Token = "0x6009EDD")]
		void QueryDatas(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action);

		// Token: 0x06009EDE RID: 40670
		[Token(Token = "0x6009EDE")]
		void RegisterListener(IDIYRoomModifierProviderListener listener);

		// Token: 0x06009EDF RID: 40671
		[Token(Token = "0x6009EDF")]
		void UnregisterListener(IDIYRoomModifierProviderListener listener);
	}
}
