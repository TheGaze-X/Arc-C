using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077A2 RID: 30626
	[Token(Token = "0x20077A2")]
	public class Act1VHalfIdleDepotBuffDetailViewModel : IHotfixable
	{
		// Token: 0x0602AFF8 RID: 176120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFF8")]
		[Address(RVA = "0x26C74D0", Offset = "0x26C60D0", VA = "0x1826C74D0")]
		public void LoadData(ProfessionCategory prof, Act1VHalfIdleDepotBuffViewModel buffModel)
		{
		}

		// Token: 0x0602AFF9 RID: 176121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFF9")]
		[Address(RVA = "0x26C7600", Offset = "0x26C6200", VA = "0x1826C7600")]
		public void NextProf(bool isReverse)
		{
		}

		// Token: 0x0602AFFA RID: 176122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFFA")]
		[Address(RVA = "0x26C76C0", Offset = "0x26C62C0", VA = "0x1826C76C0")]
		public Act1VHalfIdleDepotBuffDetailViewModel()
		{
		}

		// Token: 0x0403E113 RID: 254227
		[Token(Token = "0x403E113")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleDepotBuffViewModel buffViewModel;

		// Token: 0x0403E114 RID: 254228
		[Token(Token = "0x403E114")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleDepotBuffDetailType showType;

		// Token: 0x0403E115 RID: 254229
		[Token(Token = "0x403E115")]
		[FieldOffset(Offset = "0x1C")]
		public int selectedIndex;

		// Token: 0x0403E116 RID: 254230
		[Token(Token = "0x403E116")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E117 RID: 254231
		[Token(Token = "0x403E117")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NextProf;

		// Token: 0x0403E118 RID: 254232
		[Token(Token = "0x403E118")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
