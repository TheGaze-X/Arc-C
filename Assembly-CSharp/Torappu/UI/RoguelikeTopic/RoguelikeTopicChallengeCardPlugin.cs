using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044A7 RID: 17575
	[Token(Token = "0x20044A7")]
	public abstract class RoguelikeTopicChallengeCardPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AD95 RID: 109973
		[Token(Token = "0x601AD95")]
		public abstract void Render(string topicId, RoguelikeTopicChallengeModel model);

		// Token: 0x0601AD96 RID: 109974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD96")]
		[Address(RVA = "0x1402230", Offset = "0x1400E30", VA = "0x181402230")]
		protected RoguelikeTopicChallengeCardPlugin()
		{
		}

		// Token: 0x0402262F RID: 140847
		[Token(Token = "0x402262F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
