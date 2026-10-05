using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005891 RID: 22673
	[Token(Token = "0x2005891")]
	public class RL03ChaosHpBarDecorationView : RoguelikeRewardEntryView.HpBarDecorationView, IHotfixable
	{
		// Token: 0x0602119D RID: 135581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602119D")]
		[Address(RVA = "0x1B7A260", Offset = "0x1B78E60", VA = "0x181B7A260", Slot = "4")]
		public override void Render(string topicId)
		{
		}

		// Token: 0x0602119E RID: 135582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602119E")]
		[Address(RVA = "0x1B7A3A0", Offset = "0x1B78FA0", VA = "0x181B7A3A0")]
		public RL03ChaosHpBarDecorationView()
		{
		}

		// Token: 0x0602119F RID: 135583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602119F")]
		[Address(RVA = "0x1B7A390", Offset = "0x1B78F90", VA = "0x181B7A390")]
		private void <>xLuaBaseProxy_Render(string P0)
		{
		}

		// Token: 0x0402D116 RID: 184598
		[Token(Token = "0x402D116")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text chaosUpNum;

		// Token: 0x0402D117 RID: 184599
		[Token(Token = "0x402D117")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D118 RID: 184600
		[Token(Token = "0x402D118")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
