using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA0 RID: 31392
	[Token(Token = "0x2007AA0")]
	public class Act12sideRecycleCharmPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006712 RID: 26386
		// (get) Token: 0x0602BFA0 RID: 180128 RVA: 0x000DDCD0 File Offset: 0x000DBED0
		// (set) Token: 0x0602BFA1 RID: 180129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006712")]
		public bool isShow
		{
			[Token(Token = "0x602BFA0")]
			[Address(RVA = "0x27E1ED0", Offset = "0x27E0AD0", VA = "0x1827E1ED0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602BFA1")]
			[Address(RVA = "0x27E1F30", Offset = "0x27E0B30", VA = "0x1827E1F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602BFA2 RID: 180130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFA2")]
		[Address(RVA = "0x27E1C00", Offset = "0x27E0800", VA = "0x1827E1C00", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602BFA3 RID: 180131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFA3")]
		[Address(RVA = "0x27E1E70", Offset = "0x27E0A70", VA = "0x1827E1E70")]
		public Act12sideRecycleCharmPointModel()
		{
		}

		// Token: 0x0403FB2D RID: 260909
		[Token(Token = "0x403FB2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403FB2E RID: 260910
		[Token(Token = "0x403FB2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x0403FB2F RID: 260911
		[Token(Token = "0x403FB2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403FB30 RID: 260912
		[Token(Token = "0x403FB30")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
