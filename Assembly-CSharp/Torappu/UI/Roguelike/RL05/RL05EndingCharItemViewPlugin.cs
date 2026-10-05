using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005581 RID: 21889
	[Token(Token = "0x2005581")]
	public class RL05EndingCharItemViewPlugin : RoguelikeEndingCharItemViewPlugin
	{
		// Token: 0x06020293 RID: 131731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020293")]
		[Address(RVA = "0x1A36B10", Offset = "0x1A35710", VA = "0x181A36B10", Slot = "4")]
		public override void Render(string topicId, RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x06020294 RID: 131732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020294")]
		[Address(RVA = "0x1A36C10", Offset = "0x1A35810", VA = "0x181A36C10")]
		public RL05EndingCharItemViewPlugin()
		{
		}

		// Token: 0x0402B720 RID: 177952
		[Token(Token = "0x402B720")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _candleMask;

		// Token: 0x0402B721 RID: 177953
		[Token(Token = "0x402B721")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B722 RID: 177954
		[Token(Token = "0x402B722")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
