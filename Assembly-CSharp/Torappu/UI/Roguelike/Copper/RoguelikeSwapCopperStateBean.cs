using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x020058A3 RID: 22691
	[Token(Token = "0x20058A3")]
	public class RoguelikeSwapCopperStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004DCF RID: 19919
		// (get) Token: 0x06021218 RID: 135704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004DCF")]
		public RoguelikeSwapCopperProperty prop
		{
			[Token(Token = "0x6021218")]
			[Address(RVA = "0x1B82810", Offset = "0x1B81410", VA = "0x181B82810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004DD0 RID: 19920
		// (get) Token: 0x06021219 RID: 135705 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602121A RID: 135706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DD0")]
		public string topicId
		{
			[Token(Token = "0x6021219")]
			[Address(RVA = "0x1B82870", Offset = "0x1B81470", VA = "0x181B82870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602121A")]
			[Address(RVA = "0x1B828D0", Offset = "0x1B814D0", VA = "0x181B828D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602121B RID: 135707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602121B")]
		[Address(RVA = "0x1B82620", Offset = "0x1B81220", VA = "0x181B82620")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0602121C RID: 135708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602121C")]
		[Address(RVA = "0x1B82720", Offset = "0x1B81320", VA = "0x181B82720")]
		public RoguelikeSwapCopperStateBean()
		{
		}

		// Token: 0x0402D1D0 RID: 184784
		[Token(Token = "0x402D1D0")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeSwapCopperProperty m_prop;

		// Token: 0x0402D1D2 RID: 184786
		[Token(Token = "0x402D1D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0402D1D3 RID: 184787
		[Token(Token = "0x402D1D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402D1D4 RID: 184788
		[Token(Token = "0x402D1D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402D1D5 RID: 184789
		[Token(Token = "0x402D1D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D1D6 RID: 184790
		[Token(Token = "0x402D1D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
