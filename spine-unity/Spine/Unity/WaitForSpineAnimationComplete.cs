using System;
using System.Collections;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class WaitForSpineAnimationComplete : WaitForSpineAnimation, IEnumerator
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x4E9F180", Offset = "0x4E9DD80", VA = "0x184E9F180")]
		public WaitForSpineAnimationComplete(TrackEntry trackEntry, bool includeEndEvent = false)
		{
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x4E9F140", Offset = "0x4E9DD40", VA = "0x184E9F140")]
		public WaitForSpineAnimationComplete NowWaitFor(TrackEntry trackEntry, bool includeEndEvent = false)
		{
			return null;
		}
	}
}
