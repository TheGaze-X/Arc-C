using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057DE RID: 22494
	[Token(Token = "0x20057DE")]
	public abstract class RoguelikeInitConfirmContext : RoguelikeInitStepContext
	{
		// Token: 0x17004D33 RID: 19763
		// (get) Token: 0x06020E5F RID: 134751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D33")]
		public virtual List<RoguelikeInitChar.Model> charList
		{
			[Token(Token = "0x6020E5F")]
			[Address(RVA = "0x1B39340", Offset = "0x1B37F40", VA = "0x181B39340", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D34 RID: 19764
		// (get) Token: 0x06020E60 RID: 134752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D34")]
		public virtual List<RoguelikeInitRelic.Model> relicList
		{
			[Token(Token = "0x6020E60")]
			[Address(RVA = "0x1B393A0", Offset = "0x1B37FA0", VA = "0x181B393A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020E61 RID: 134753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E61")]
		[Address(RVA = "0x1B39040", Offset = "0x1B37C40", VA = "0x181B39040")]
		public void Confirm()
		{
		}

		// Token: 0x06020E62 RID: 134754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E62")]
		[Address(RVA = "0x1B392A0", Offset = "0x1B37EA0", VA = "0x181B392A0")]
		protected RoguelikeInitConfirmContext()
		{
		}

		// Token: 0x0402CB47 RID: 183111
		[Token(Token = "0x402CB47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charList;

		// Token: 0x0402CB48 RID: 183112
		[Token(Token = "0x402CB48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_relicList;

		// Token: 0x0402CB49 RID: 183113
		[Token(Token = "0x402CB49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Confirm;

		// Token: 0x0402CB4A RID: 183114
		[Token(Token = "0x402CB4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
