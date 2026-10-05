using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public interface ISkeletonComponent
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000693 RID: 1683
		[Token(Token = "0x170001BA")]
		SkeletonDataAsset SkeletonDataAsset { [Token(Token = "0x6000693")] get; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000694 RID: 1684
		[Token(Token = "0x170001BB")]
		Skeleton Skeleton { [Token(Token = "0x6000694")] get; }
	}
}
