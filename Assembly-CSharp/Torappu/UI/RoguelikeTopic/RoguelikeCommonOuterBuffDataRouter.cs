using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044FD RID: 17661
	[Token(Token = "0x20044FD")]
	public abstract class RoguelikeCommonOuterBuffDataRouter : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF40 RID: 110400
		[Token(Token = "0x601AF40")]
		public abstract RoguelikeCommonDevelopmentData LoadData(RoguelikeTopicCustomizeData customizeData);

		// Token: 0x0601AF41 RID: 110401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF41")]
		[Address(RVA = "0x141BD10", Offset = "0x141A910", VA = "0x18141BD10")]
		protected RoguelikeCommonOuterBuffDataRouter()
		{
		}

		// Token: 0x0402295D RID: 141661
		[Token(Token = "0x402295D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
