using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A9E RID: 31390
	[Token(Token = "0x2007A9E")]
	public class Act12sideMissionTrackPointModel : IHotfixable, ITrackPointModel
	{
		// Token: 0x17006710 RID: 26384
		// (get) Token: 0x0602BF99 RID: 180121 RVA: 0x000DDCA0 File Offset: 0x000DBEA0
		[Token(Token = "0x17006710")]
		public bool isShow
		{
			[Token(Token = "0x602BF99")]
			[Address(RVA = "0x27E0ED0", Offset = "0x27DFAD0", VA = "0x1827E0ED0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BF9A RID: 180122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF9A")]
		[Address(RVA = "0x27E0DB0", Offset = "0x27DF9B0", VA = "0x1827E0DB0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602BF9B RID: 180123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF9B")]
		[Address(RVA = "0x27E0E70", Offset = "0x27DFA70", VA = "0x1827E0E70")]
		public Act12sideMissionTrackPointModel()
		{
		}

		// Token: 0x0403FB23 RID: 260899
		[Token(Token = "0x403FB23")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403FB24 RID: 260900
		[Token(Token = "0x403FB24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403FB25 RID: 260901
		[Token(Token = "0x403FB25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403FB26 RID: 260902
		[Token(Token = "0x403FB26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
