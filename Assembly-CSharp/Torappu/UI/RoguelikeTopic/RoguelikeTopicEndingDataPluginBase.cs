using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044CA RID: 17610
	[Token(Token = "0x20044CA")]
	public abstract class RoguelikeTopicEndingDataPluginBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AE3E RID: 110142
		[Token(Token = "0x601AE3E")]
		public abstract bool CheckNeedTopicEnding(string topicId, RoguelikeTopicMode mode, GameSettleOuterInfo settleData);

		// Token: 0x0601AE3F RID: 110143 RVA: 0x000A3968 File Offset: 0x000A1B68
		[Token(Token = "0x601AE3F")]
		[Address(RVA = "0x140BFC0", Offset = "0x140ABC0", VA = "0x18140BFC0")]
		protected static bool CheckSpecialOperatorValid(GameSettleOuterInfo outerInfo)
		{
			return default(bool);
		}

		// Token: 0x0601AE40 RID: 110144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE40")]
		[Address(RVA = "0x140C520", Offset = "0x140B120", VA = "0x18140C520")]
		protected RoguelikeTopicEndingDataPluginBase()
		{
		}

		// Token: 0x0402275E RID: 141150
		[Token(Token = "0x402275E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckSpecialOperatorValid;

		// Token: 0x0402275F RID: 141151
		[Token(Token = "0x402275F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
