using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public interface IWithFind
	{
		// Token: 0x06000152 RID: 338
		[Token(Token = "0x6000152")]
		void ClearFindMatches();

		// Token: 0x06000153 RID: 339
		[Token(Token = "0x6000153")]
		Task<FindResult> Find(string text, bool forward);
	}
}
