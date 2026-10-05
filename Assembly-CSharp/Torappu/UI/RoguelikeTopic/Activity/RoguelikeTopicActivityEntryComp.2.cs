using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity
{
	// Token: 0x02004695 RID: 18069
	[Token(Token = "0x2004695")]
	public abstract class RoguelikeTopicActivityEntryComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B6B9 RID: 112313
		[Token(Token = "0x601B6B9")]
		public abstract void Render(RoguelikeTopicActivityEntryCompBaseModel model);

		// Token: 0x0601B6BA RID: 112314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6BA")]
		[Address(RVA = "0x14B1680", Offset = "0x14B0280", VA = "0x1814B1680")]
		protected RoguelikeTopicActivityEntryComp()
		{
		}

		// Token: 0x04023789 RID: 145289
		[Token(Token = "0x4023789")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action onOpenActivityState;

		// Token: 0x0402378A RID: 145290
		[Token(Token = "0x402378A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
