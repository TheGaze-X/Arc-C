using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200547F RID: 21631
	[Token(Token = "0x200547F")]
	public abstract class RoguelikeSelectCharMenuButtonResHolderBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FD5C RID: 130396
		[Token(Token = "0x601FD5C")]
		public abstract RoguelikeSelectCharMenuButtonResHolderBase.Output SelectAvailMenuButton(RoguelikeSelectCharMenuButtonResHolderBase.Input input);

		// Token: 0x0601FD5D RID: 130397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD5D")]
		[Address(RVA = "0x19FC700", Offset = "0x19FB300", VA = "0x1819FC700")]
		protected RoguelikeSelectCharMenuButtonResHolderBase()
		{
		}

		// Token: 0x0402AE28 RID: 175656
		[Token(Token = "0x402AE28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005480 RID: 21632
		[Token(Token = "0x2005480")]
		public struct Output
		{
			// Token: 0x0402AE29 RID: 175657
			[Token(Token = "0x402AE29")]
			[FieldOffset(Offset = "0x0")]
			public bool hideCharMenuObject;

			// Token: 0x0402AE2A RID: 175658
			[Token(Token = "0x402AE2A")]
			[FieldOffset(Offset = "0x8")]
			public RoguelikeMenuButtonPluginBase menuPlugin;

			// Token: 0x0402AE2B RID: 175659
			[Token(Token = "0x402AE2B")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeMenuButtonPluginBase.Input menuPluginInput;
		}

		// Token: 0x02005481 RID: 21633
		[Token(Token = "0x2005481")]
		public struct Input
		{
			// Token: 0x0402AE2C RID: 175660
			[Token(Token = "0x402AE2C")]
			[FieldOffset(Offset = "0x0")]
			public Action onCancel;

			// Token: 0x0402AE2D RID: 175661
			[Token(Token = "0x402AE2D")]
			[FieldOffset(Offset = "0x8")]
			public Action onClearAll;

			// Token: 0x0402AE2E RID: 175662
			[Token(Token = "0x402AE2E")]
			[FieldOffset(Offset = "0x10")]
			public Action onConfirm;

			// Token: 0x0402AE2F RID: 175663
			[Token(Token = "0x402AE2F")]
			[FieldOffset(Offset = "0x18")]
			public string topicId;

			// Token: 0x0402AE30 RID: 175664
			[Token(Token = "0x402AE30")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeSelectCharViewModel selectCharViewModel;

			// Token: 0x0402AE31 RID: 175665
			[Token(Token = "0x402AE31")]
			[FieldOffset(Offset = "0x28")]
			public List<IRoguelikeCharCardViewPluginContext> pluginContexts;
		}
	}
}
