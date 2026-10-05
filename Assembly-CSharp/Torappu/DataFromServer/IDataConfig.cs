using System;
using Il2CppDummyDll;

namespace Torappu.DataFromServer
{
	// Token: 0x020016F4 RID: 5876
	[Token(Token = "0x20016F4")]
	internal interface IDataConfig : IHotfixable
	{
		// Token: 0x060094C0 RID: 38080
		[Token(Token = "0x60094C0")]
		string GetDataId();

		// Token: 0x060094C1 RID: 38081
		[Token(Token = "0x60094C1")]
		DataFromServerStorage.DataChunk.Config GetDataChunkConfig();
	}
}
