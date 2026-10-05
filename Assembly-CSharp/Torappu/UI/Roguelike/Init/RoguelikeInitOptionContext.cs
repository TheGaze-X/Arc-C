using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057E5 RID: 22501
	[Token(Token = "0x20057E5")]
	public abstract class RoguelikeInitOptionContext : RoguelikeInitStepContext
	{
		// Token: 0x17004D37 RID: 19767
		// (get) Token: 0x06020E7B RID: 134779
		[Token(Token = "0x17004D37")]
		public abstract List<RoguelikeInitOption.Model> list { [Token(Token = "0x6020E7B")] get; }

		// Token: 0x17004D38 RID: 19768
		// (get) Token: 0x06020E7C RID: 134780 RVA: 0x000B7BB8 File Offset: 0x000B5DB8
		[Token(Token = "0x17004D38")]
		public virtual bool showHint
		{
			[Token(Token = "0x6020E7C")]
			[Address(RVA = "0x1B3D260", Offset = "0x1B3BE60", VA = "0x181B3D260", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020E7D RID: 134781
		[Token(Token = "0x6020E7D")]
		public abstract void OnSelect(int idx);

		// Token: 0x06020E7E RID: 134782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E7E")]
		[Address(RVA = "0x1B3D1C0", Offset = "0x1B3BDC0", VA = "0x181B3D1C0")]
		protected RoguelikeInitOptionContext()
		{
		}

		// Token: 0x0402CB88 RID: 183176
		[Token(Token = "0x402CB88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showHint;

		// Token: 0x0402CB89 RID: 183177
		[Token(Token = "0x402CB89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
