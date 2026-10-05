using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SoftMasking
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	public interface ISoftMask
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06004957 RID: 18775
		[Token(Token = "0x1700015F")]
		bool isAlive { [Token(Token = "0x6004957")] get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06004958 RID: 18776
		[Token(Token = "0x17000160")]
		bool isMaskingEnabled { [Token(Token = "0x6004958")] get; }

		// Token: 0x06004959 RID: 18777
		[Token(Token = "0x6004959")]
		Material GetReplacement(Material original);

		// Token: 0x0600495A RID: 18778
		[Token(Token = "0x600495A")]
		void ReleaseReplacement(Material replacement);

		// Token: 0x0600495B RID: 18779
		[Token(Token = "0x600495B")]
		void UpdateTransformChildren(Transform transform);
	}
}
