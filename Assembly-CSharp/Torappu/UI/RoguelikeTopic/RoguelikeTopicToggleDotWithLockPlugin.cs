using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044C0 RID: 17600
	[Token(Token = "0x20044C0")]
	public abstract class RoguelikeTopicToggleDotWithLockPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AE13 RID: 110099
		[Token(Token = "0x601AE13")]
		public abstract void Init(int dotIndex, int dotsCountPerGroup);

		// Token: 0x0601AE14 RID: 110100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE14")]
		[Address(RVA = "0x1415480", Offset = "0x1414080", VA = "0x181415480")]
		protected RoguelikeTopicToggleDotWithLockPlugin()
		{
		}

		// Token: 0x04022722 RID: 141090
		[Token(Token = "0x4022722")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
