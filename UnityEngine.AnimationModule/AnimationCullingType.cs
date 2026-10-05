using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public enum AnimationCullingType
	{
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		AlwaysAnimate,
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		BasedOnRenderers,
		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[Obsolete("Enum member AnimatorCullingMode.BasedOnClipBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
		BasedOnClipBounds,
		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[Obsolete("Enum member AnimatorCullingMode.BasedOnUserBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
		BasedOnUserBounds
	}
}
