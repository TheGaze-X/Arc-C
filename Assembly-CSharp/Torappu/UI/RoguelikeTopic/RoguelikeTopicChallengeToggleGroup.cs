using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044BC RID: 17596
	[Token(Token = "0x20044BC")]
	public abstract class RoguelikeTopicChallengeToggleGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AE07 RID: 110087
		[Token(Token = "0x601AE07")]
		public abstract void Init(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext);

		// Token: 0x0601AE08 RID: 110088
		[Token(Token = "0x601AE08")]
		public abstract void RefreshToggles(RoguelikeTopicChallengeModeViewModel challengeModeViewModel);

		// Token: 0x0601AE09 RID: 110089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE09")]
		[Address(RVA = "0x1408300", Offset = "0x1406F00", VA = "0x181408300")]
		protected RoguelikeTopicChallengeToggleGroup()
		{
		}

		// Token: 0x0402270C RID: 141068
		[Token(Token = "0x402270C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
