using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200577F RID: 22399
	[Token(Token = "0x200577F")]
	public class RL02ExpeditionCharCardView : RoguelikeExpeditionCharCardViewBase
	{
		// Token: 0x06020C79 RID: 134265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C79")]
		[Address(RVA = "0x1B213C0", Offset = "0x1B1FFC0", VA = "0x181B213C0", Slot = "4")]
		protected override void RenderChar(RoguelikeExpeditionCharCardViewModel viewModel, string selectingCharId, bool fastMode)
		{
		}

		// Token: 0x06020C7A RID: 134266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C7A")]
		[Address(RVA = "0x1B21570", Offset = "0x1B20170", VA = "0x181B21570")]
		public RL02ExpeditionCharCardView()
		{
		}

		// Token: 0x0402C854 RID: 182356
		[Token(Token = "0x402C854")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objDecNormal;

		// Token: 0x0402C855 RID: 182357
		[Token(Token = "0x402C855")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objDecMutation;

		// Token: 0x0402C856 RID: 182358
		[Token(Token = "0x402C856")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objDecEvolution;

		// Token: 0x0402C857 RID: 182359
		[Token(Token = "0x402C857")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x0402C858 RID: 182360
		[Token(Token = "0x402C858")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
