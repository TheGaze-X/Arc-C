using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200188C RID: 6284
	[Token(Token = "0x200188C")]
	public interface IDIYRoomTemplateProvider
	{
		// Token: 0x06009EF0 RID: 40688
		[Token(Token = "0x6009EF0")]
		void QueryData(Predicate<IDIYRoomTemplate> filter, Action<IDIYRoomTemplate> action);

		// Token: 0x06009EF1 RID: 40689
		[Token(Token = "0x6009EF1")]
		void QueryDatas(Predicate<IDIYRoomTemplate> filter, Action<IDIYRoomTemplate> action);
	}
}
