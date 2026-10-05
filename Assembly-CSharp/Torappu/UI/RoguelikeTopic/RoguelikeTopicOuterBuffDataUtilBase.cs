using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200452B RID: 17707
	[Token(Token = "0x200452B")]
	public abstract class RoguelikeTopicOuterBuffDataUtilBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B015 RID: 110613
		[Token(Token = "0x601B015")]
		public abstract void GetRoguelikeTopicOuterBuffTokenData(string topicId, out int currTokenNum, out bool allCompleted);

		// Token: 0x0601B016 RID: 110614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B016")]
		[Address(RVA = "0x142C830", Offset = "0x142B430", VA = "0x18142C830")]
		protected RoguelikeTopicOuterBuffDataUtilBase()
		{
		}

		// Token: 0x04022AFE RID: 142078
		[Token(Token = "0x4022AFE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
