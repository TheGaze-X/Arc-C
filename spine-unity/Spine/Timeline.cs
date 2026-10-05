using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public interface Timeline
	{
		// Token: 0x0600002C RID: 44
		[Token(Token = "0x600002C")]
		void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction);

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002D RID: 45
		[Token(Token = "0x17000009")]
		int PropertyId { [Token(Token = "0x600002D")] get; }
	}
}
