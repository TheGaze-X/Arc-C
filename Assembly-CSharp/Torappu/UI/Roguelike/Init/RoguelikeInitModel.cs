using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Init.Style;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057D2 RID: 22482
	[Token(Token = "0x20057D2")]
	public class RoguelikeInitModel : IHotfixable
	{
		// Token: 0x17004D21 RID: 19745
		// (get) Token: 0x06020E1E RID: 134686 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020E1F RID: 134687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D21")]
		public RoguelikeInitStepContext currentContext
		{
			[Token(Token = "0x6020E1E")]
			[Address(RVA = "0x1B3C6E0", Offset = "0x1B3B2E0", VA = "0x181B3C6E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020E1F")]
			[Address(RVA = "0x1B3CA60", Offset = "0x1B3B660", VA = "0x181B3CA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004D22 RID: 19746
		// (get) Token: 0x06020E20 RID: 134688 RVA: 0x000B7A80 File Offset: 0x000B5C80
		[Token(Token = "0x17004D22")]
		public int step
		{
			[Token(Token = "0x6020E20")]
			[Address(RVA = "0x1B3C8D0", Offset = "0x1B3B4D0", VA = "0x181B3C8D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004D23 RID: 19747
		// (get) Token: 0x06020E21 RID: 134689 RVA: 0x000B7A98 File Offset: 0x000B5C98
		[Token(Token = "0x17004D23")]
		public int maxStep
		{
			[Token(Token = "0x6020E21")]
			[Address(RVA = "0x1B3C7A0", Offset = "0x1B3B3A0", VA = "0x181B3C7A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004D24 RID: 19748
		// (get) Token: 0x06020E22 RID: 134690 RVA: 0x000B7AB0 File Offset: 0x000B5CB0
		// (set) Token: 0x06020E23 RID: 134691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D24")]
		public PlayerRoguelikePlayerEventType initPhase
		{
			[Token(Token = "0x6020E22")]
			[Address(RVA = "0x1B3C740", Offset = "0x1B3B340", VA = "0x181B3C740")]
			[CompilerGenerated]
			get
			{
				return PlayerRoguelikePlayerEventType.GAME_INIT_MODE_RELIC;
			}
			[Token(Token = "0x6020E23")]
			[Address(RVA = "0x1B3CAE0", Offset = "0x1B3B6E0", VA = "0x181B3CAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004D25 RID: 19749
		// (get) Token: 0x06020E24 RID: 134692 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020E25 RID: 134693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D25")]
		public RoguelikeInitStyle uiStyle
		{
			[Token(Token = "0x6020E24")]
			[Address(RVA = "0x1B3CA00", Offset = "0x1B3B600", VA = "0x181B3CA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020E25")]
			[Address(RVA = "0x1B3CB50", Offset = "0x1B3B750", VA = "0x181B3CB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06020E26 RID: 134694 RVA: 0x000B7AC8 File Offset: 0x000B5CC8
		[Token(Token = "0x6020E26")]
		[Address(RVA = "0x1B3C070", Offset = "0x1B3AC70", VA = "0x181B3C070")]
		public bool Load(RoguelikeInitContextUser user, RoguelikeInitStyle style)
		{
			return default(bool);
		}

		// Token: 0x06020E27 RID: 134695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020E27")]
		[Address(RVA = "0x1B3C4B0", Offset = "0x1B3B0B0", VA = "0x181B3C4B0")]
		private RoguelikeInitStepContext _CheckContextSuitForEvent(PlayerRoguelikePlayerEventType type, RoguelikeInitContextUser user)
		{
			return null;
		}

		// Token: 0x06020E28 RID: 134696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E28")]
		private void _CheckCurStepContextType<T>(PlayerRoguelikePlayerEventType type, RoguelikeInitContextUser user) where T : RoguelikeInitStepContext, new()
		{
		}

		// Token: 0x06020E29 RID: 134697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E29")]
		[Address(RVA = "0x1B3C680", Offset = "0x1B3B280", VA = "0x181B3C680")]
		public RoguelikeInitModel()
		{
		}

		// Token: 0x0402CAE4 RID: 183012
		[Token(Token = "0x402CAE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentContext;

		// Token: 0x0402CAE5 RID: 183013
		[Token(Token = "0x402CAE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_currentContext;

		// Token: 0x0402CAE6 RID: 183014
		[Token(Token = "0x402CAE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_step;

		// Token: 0x0402CAE7 RID: 183015
		[Token(Token = "0x402CAE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maxStep;

		// Token: 0x0402CAE8 RID: 183016
		[Token(Token = "0x402CAE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_initPhase;

		// Token: 0x0402CAE9 RID: 183017
		[Token(Token = "0x402CAE9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_initPhase;

		// Token: 0x0402CAEA RID: 183018
		[Token(Token = "0x402CAEA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_uiStyle;

		// Token: 0x0402CAEB RID: 183019
		[Token(Token = "0x402CAEB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_uiStyle;

		// Token: 0x0402CAEC RID: 183020
		[Token(Token = "0x402CAEC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402CAED RID: 183021
		[Token(Token = "0x402CAED")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckContextSuitForEvent;

		// Token: 0x0402CAEE RID: 183022
		[Token(Token = "0x402CAEE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckCurStepContextType;

		// Token: 0x0402CAEF RID: 183023
		[Token(Token = "0x402CAEF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
