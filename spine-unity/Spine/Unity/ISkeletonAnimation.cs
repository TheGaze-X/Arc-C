using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public interface ISkeletonAnimation
	{
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x0600068B RID: 1675
		// (remove) Token: 0x0600068C RID: 1676
		[Token(Token = "0x1400002F")]
		event UpdateBonesDelegate UpdateLocal;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x0600068D RID: 1677
		// (remove) Token: 0x0600068E RID: 1678
		[Token(Token = "0x14000030")]
		event UpdateBonesDelegate UpdateWorld;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x0600068F RID: 1679
		// (remove) Token: 0x06000690 RID: 1680
		[Token(Token = "0x14000031")]
		event UpdateBonesDelegate UpdateComplete;

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000691 RID: 1681
		[Token(Token = "0x170001B8")]
		Skeleton Skeleton { [Token(Token = "0x6000691")] get; }
	}
}
