using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005482 RID: 21634
	[Token(Token = "0x2005482")]
	public class RoguelikeSelectCharMenuButtonResHolder : RoguelikeSelectCharMenuButtonResHolderBase
	{
		// Token: 0x0601FD5E RID: 130398 RVA: 0x000B3760 File Offset: 0x000B1960
		[Token(Token = "0x601FD5E")]
		[Address(RVA = "0x19FC760", Offset = "0x19FB360", VA = "0x1819FC760", Slot = "4")]
		public override RoguelikeSelectCharMenuButtonResHolderBase.Output SelectAvailMenuButton(RoguelikeSelectCharMenuButtonResHolderBase.Input input)
		{
			return default(RoguelikeSelectCharMenuButtonResHolderBase.Output);
		}

		// Token: 0x0601FD5F RID: 130399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD5F")]
		[Address(RVA = "0x19FCC00", Offset = "0x19FB800", VA = "0x1819FCC00")]
		public RoguelikeSelectCharMenuButtonResHolder()
		{
		}

		// Token: 0x0402AE32 RID: 175666
		[Token(Token = "0x402AE32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeMenuButtonPluginBase _charRecruitBtnPlugin;

		// Token: 0x0402AE33 RID: 175667
		[Token(Token = "0x402AE33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeMenuButtonPluginBase _charSelectBtnPlugin;

		// Token: 0x0402AE34 RID: 175668
		[Token(Token = "0x402AE34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SelectAvailMenuButton;

		// Token: 0x0402AE35 RID: 175669
		[Token(Token = "0x402AE35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
