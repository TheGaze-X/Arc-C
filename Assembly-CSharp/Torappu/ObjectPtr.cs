using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000527 RID: 1319
	[Token(Token = "0x2000527")]
	public static class ObjectPtr
	{
		// Token: 0x06004F76 RID: 20342 RVA: 0x0002E530 File Offset: 0x0002C730
		[Token(Token = "0x6004F76")]
		public static ObjectPtr<T> Wrap<T>(T obj) where T : class, IPtrObject
		{
			return default(ObjectPtr<T>);
		}
	}
}
