using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A9F RID: 31391
	[Token(Token = "0x2007A9F")]
	public class Act12sideNewCharmPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006711 RID: 26385
		// (get) Token: 0x0602BF9C RID: 180124 RVA: 0x000DDCB8 File Offset: 0x000DBEB8
		// (set) Token: 0x0602BF9D RID: 180125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006711")]
		public bool isShow
		{
			[Token(Token = "0x602BF9C")]
			[Address(RVA = "0x27E10D0", Offset = "0x27DFCD0", VA = "0x1827E10D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602BF9D")]
			[Address(RVA = "0x27E1130", Offset = "0x27DFD30", VA = "0x1827E1130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602BF9E RID: 180126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF9E")]
		[Address(RVA = "0x27E0F30", Offset = "0x27DFB30", VA = "0x1827E0F30", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602BF9F RID: 180127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF9F")]
		[Address(RVA = "0x27E1070", Offset = "0x27DFC70", VA = "0x1827E1070")]
		public Act12sideNewCharmPointModel()
		{
		}

		// Token: 0x0403FB28 RID: 260904
		[Token(Token = "0x403FB28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403FB29 RID: 260905
		[Token(Token = "0x403FB29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x0403FB2A RID: 260906
		[Token(Token = "0x403FB2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403FB2B RID: 260907
		[Token(Token = "0x403FB2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
