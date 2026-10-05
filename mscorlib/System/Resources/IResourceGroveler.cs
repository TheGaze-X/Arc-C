using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	internal interface IResourceGroveler
	{
		// Token: 0x060023B7 RID: 9143
		[Token(Token = "0x60023B7")]
		ResourceSet GrovelForResourceSet(System.Globalization.CultureInfo culture, System.Collections.Generic.Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark);
	}
}
