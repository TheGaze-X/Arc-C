using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.TotemBuff
{
	// Token: 0x02005561 RID: 21857
	[Token(Token = "0x2005561")]
	public abstract class AbstractRoguelikeTotemBuffView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020206 RID: 131590
		[Token(Token = "0x6020206")]
		public abstract void OnInit();

		// Token: 0x06020207 RID: 131591
		[Token(Token = "0x6020207")]
		public abstract void BindState(State state);

		// Token: 0x06020208 RID: 131592
		[Token(Token = "0x6020208")]
		public abstract void OnStateResume();

		// Token: 0x06020209 RID: 131593
		[Token(Token = "0x6020209")]
		public abstract IRoguelikeTotemBuffViewModel GeneViewData(string topicId, bool isOpenDirectFromDungeon);

		// Token: 0x0602020A RID: 131594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602020A")]
		[Address(RVA = "0x1A2FDB0", Offset = "0x1A2E9B0", VA = "0x181A2FDB0")]
		protected AbstractRoguelikeTotemBuffView()
		{
		}

		// Token: 0x0402B666 RID: 177766
		[Token(Token = "0x402B666")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
