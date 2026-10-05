using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public interface IMarker
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000270 RID: 624
		// (set) Token: 0x06000271 RID: 625
		[Token(Token = "0x170000B6")]
		double time { [Token(Token = "0x6000270")] get; [Token(Token = "0x6000271")] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000272 RID: 626
		[Token(Token = "0x170000B7")]
		TrackAsset parent { [Token(Token = "0x6000272")] get; }

		// Token: 0x06000273 RID: 627
		[Token(Token = "0x6000273")]
		void Initialize(TrackAsset parent);
	}
}
