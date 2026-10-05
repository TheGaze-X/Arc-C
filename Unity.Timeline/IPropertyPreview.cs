using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public interface IPropertyPreview
	{
		// Token: 0x0600033F RID: 831
		[Token(Token = "0x600033F")]
		void GatherProperties(PlayableDirector director, IPropertyCollector driver);
	}
}
