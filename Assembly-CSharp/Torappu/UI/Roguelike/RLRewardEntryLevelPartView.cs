using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053D3 RID: 21459
	[Token(Token = "0x20053D3")]
	public abstract class RLRewardEntryLevelPartView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F94E RID: 129358
		[Token(Token = "0x601F94E")]
		public abstract void Init(RoguelikeRewardEarnViewModel earnViewModel);

		// Token: 0x0601F94F RID: 129359
		[Token(Token = "0x601F94F")]
		public abstract IEnumerator DealWithAnimation(RoguelikeRewardEarnViewModel earnViewModel, string stageId, string topicId);

		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x0601F950 RID: 129360
		[Token(Token = "0x170049F6")]
		public abstract GameObject stateRelatedEffect { [Token(Token = "0x601F950")] get; }

		// Token: 0x0601F951 RID: 129361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F951")]
		[Address(RVA = "0x1937F50", Offset = "0x1936B50", VA = "0x181937F50")]
		protected RLRewardEntryLevelPartView()
		{
		}

		// Token: 0x0402A856 RID: 174166
		[Token(Token = "0x402A856")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
