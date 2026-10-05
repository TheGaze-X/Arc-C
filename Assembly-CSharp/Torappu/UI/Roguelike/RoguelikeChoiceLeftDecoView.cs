using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051B3 RID: 20915
	[Token(Token = "0x20051B3")]
	public class RoguelikeChoiceLeftDecoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601EE54 RID: 126548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE54")]
		[Address(RVA = "0x18A35D0", Offset = "0x18A21D0", VA = "0x1818A35D0", Slot = "4")]
		public virtual void Render(string topicId, RoguelikeGameChoiceData choiceData, PlayerRoguelikePendingEvent.ChoiceAddition playerAdditionData)
		{
		}

		// Token: 0x0601EE55 RID: 126549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE55")]
		[Address(RVA = "0x18A3660", Offset = "0x18A2260", VA = "0x1818A3660")]
		public RoguelikeChoiceLeftDecoView()
		{
		}

		// Token: 0x0402973F RID: 169791
		[Token(Token = "0x402973F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029740 RID: 169792
		[Token(Token = "0x4029740")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
