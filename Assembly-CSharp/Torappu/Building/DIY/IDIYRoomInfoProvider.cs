using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200188E RID: 6286
	[Token(Token = "0x200188E")]
	public interface IDIYRoomInfoProvider
	{
		// Token: 0x06009EF5 RID: 40693
		[Token(Token = "0x6009EF5")]
		void QueryData(Predicate<DIYRoomInfo> filter, Action<DIYRoomInfo> action);

		// Token: 0x06009EF6 RID: 40694
		[Token(Token = "0x6009EF6")]
		void QueryDatas(Predicate<DIYRoomInfo> filter, Action<DIYRoomInfo> action);
	}
}
