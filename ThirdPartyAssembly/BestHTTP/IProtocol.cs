using System;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x020004AC RID: 1196
	[Token(Token = "0x20004AC")]
	public interface IProtocol
	{
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600274D RID: 10061
		[Token(Token = "0x1700058B")]
		bool IsClosed { [Token(Token = "0x600274D")] get; }

		// Token: 0x0600274E RID: 10062
		[Token(Token = "0x600274E")]
		void HandleEvents();
	}
}
