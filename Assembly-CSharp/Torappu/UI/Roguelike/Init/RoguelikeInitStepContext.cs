using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057D8 RID: 22488
	[Token(Token = "0x20057D8")]
	public abstract class RoguelikeInitStepContext : IHotfixable
	{
		// Token: 0x06020E40 RID: 134720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E40")]
		[Address(RVA = "0x1B41590", Offset = "0x1B40190", VA = "0x181B41590")]
		public void Bind(RoguelikeInitContextUser user)
		{
		}

		// Token: 0x06020E41 RID: 134721
		[Token(Token = "0x6020E41")]
		public abstract void Load(PlayerRoguelikePendingEvent evt);

		// Token: 0x17004D2B RID: 19755
		// (get) Token: 0x06020E42 RID: 134722
		[Token(Token = "0x17004D2B")]
		public abstract string name { [Token(Token = "0x6020E42")] get; }

		// Token: 0x17004D2C RID: 19756
		// (get) Token: 0x06020E43 RID: 134723 RVA: 0x000B7AE0 File Offset: 0x000B5CE0
		// (set) Token: 0x06020E44 RID: 134724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D2C")]
		public int step
		{
			[Token(Token = "0x6020E43")]
			[Address(RVA = "0x1B41B30", Offset = "0x1B40730", VA = "0x181B41B30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020E44")]
			[Address(RVA = "0x1B41D80", Offset = "0x1B40980", VA = "0x181B41D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004D2D RID: 19757
		// (get) Token: 0x06020E45 RID: 134725 RVA: 0x000B7AF8 File Offset: 0x000B5CF8
		// (set) Token: 0x06020E46 RID: 134726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D2D")]
		public int maxStep
		{
			[Token(Token = "0x6020E45")]
			[Address(RVA = "0x1B419C0", Offset = "0x1B405C0", VA = "0x181B419C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020E46")]
			[Address(RVA = "0x1B41D10", Offset = "0x1B40910", VA = "0x181B41D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004D2E RID: 19758
		// (get) Token: 0x06020E47 RID: 134727 RVA: 0x000B7B10 File Offset: 0x000B5D10
		// (set) Token: 0x06020E48 RID: 134728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D2E")]
		public bool isValid
		{
			[Token(Token = "0x6020E47")]
			[Address(RVA = "0x1B41960", Offset = "0x1B40560", VA = "0x181B41960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6020E48")]
			[Address(RVA = "0x1B41CA0", Offset = "0x1B408A0", VA = "0x181B41CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06020E49 RID: 134729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E49")]
		[Address(RVA = "0x1B41760", Offset = "0x1B40360", VA = "0x181B41760")]
		protected void _SetStepInfo(int[] stepInfo)
		{
		}

		// Token: 0x06020E4A RID: 134730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E4A")]
		[Address(RVA = "0x1B41610", Offset = "0x1B40210", VA = "0x181B41610")]
		protected void Invalide()
		{
		}

		// Token: 0x17004D2F RID: 19759
		// (get) Token: 0x06020E4B RID: 134731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D2F")]
		public string topicId
		{
			[Token(Token = "0x6020E4B")]
			[Address(RVA = "0x1B41B90", Offset = "0x1B40790", VA = "0x181B41B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D30 RID: 19760
		// (get) Token: 0x06020E4C RID: 134732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D30")]
		public UIPage page
		{
			[Token(Token = "0x6020E4C")]
			[Address(RVA = "0x1B41A20", Offset = "0x1B40620", VA = "0x181B41A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020E4D RID: 134733 RVA: 0x000B7B28 File Offset: 0x000B5D28
		[Token(Token = "0x6020E4D")]
		protected bool AddTop<T>() where T : State
		{
			return default(bool);
		}

		// Token: 0x06020E4E RID: 134734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E4E")]
		[Address(RVA = "0x1B41900", Offset = "0x1B40500", VA = "0x181B41900")]
		protected RoguelikeInitStepContext()
		{
		}

		// Token: 0x0402CB0A RID: 183050
		[Token(Token = "0x402CB0A")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeInitContextUser m_user;

		// Token: 0x0402CB0E RID: 183054
		[Token(Token = "0x402CB0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0402CB0F RID: 183055
		[Token(Token = "0x402CB0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_step;

		// Token: 0x0402CB10 RID: 183056
		[Token(Token = "0x402CB10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_step;

		// Token: 0x0402CB11 RID: 183057
		[Token(Token = "0x402CB11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maxStep;

		// Token: 0x0402CB12 RID: 183058
		[Token(Token = "0x402CB12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_maxStep;

		// Token: 0x0402CB13 RID: 183059
		[Token(Token = "0x402CB13")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0402CB14 RID: 183060
		[Token(Token = "0x402CB14")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_isValid;

		// Token: 0x0402CB15 RID: 183061
		[Token(Token = "0x402CB15")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetStepInfo;

		// Token: 0x0402CB16 RID: 183062
		[Token(Token = "0x402CB16")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Invalide;

		// Token: 0x0402CB17 RID: 183063
		[Token(Token = "0x402CB17")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402CB18 RID: 183064
		[Token(Token = "0x402CB18")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402CB19 RID: 183065
		[Token(Token = "0x402CB19")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AddTop;

		// Token: 0x0402CB1A RID: 183066
		[Token(Token = "0x402CB1A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
