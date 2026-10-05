using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005554 RID: 21844
	[Token(Token = "0x2005554")]
	public abstract class RoguelikeTravelLeaveToastView : UINotifyView<RoguelikeTravelLeaveToastView.Param>
	{
		// Token: 0x060201F1 RID: 131569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201F1")]
		[Address(RVA = "0x1A45E80", Offset = "0x1A44A80", VA = "0x181A45E80")]
		protected RoguelikeTravelLeaveToastView()
		{
		}

		// Token: 0x0402B64B RID: 177739
		[Token(Token = "0x402B64B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005555 RID: 21845
		[Token(Token = "0x2005555")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060201F2 RID: 131570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201F2")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402B64C RID: 177740
			[Token(Token = "0x402B64C")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402B64D RID: 177741
			[Token(Token = "0x402B64D")]
			[FieldOffset(Offset = "0x18")]
			public PlayerRoguelikeV2.CurrentData.Troop.ExpedType type;

			// Token: 0x0402B64E RID: 177742
			[Token(Token = "0x402B64E")]
			[FieldOffset(Offset = "0x20")]
			public List<string> leftChars;
		}
	}
}
