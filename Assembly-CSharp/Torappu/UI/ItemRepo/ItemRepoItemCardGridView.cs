using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E8E RID: 24206
	[Token(Token = "0x2005E8E")]
	public class ItemRepoItemCardGridView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700531A RID: 21274
		// (get) Token: 0x0602312E RID: 143662 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602312F RID: 143663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700531A")]
		public SimpleLayoutAdapter adapter
		{
			[Token(Token = "0x602312E")]
			[Address(RVA = "0x1D98CC0", Offset = "0x1D978C0", VA = "0x181D98CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x602312F")]
			[Address(RVA = "0x1D98D20", Offset = "0x1D97920", VA = "0x181D98D20")]
			set
			{
			}
		}

		// Token: 0x06023130 RID: 143664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023130")]
		[Address(RVA = "0x1D98A00", Offset = "0x1D97600", VA = "0x181D98A00")]
		private void _ObserveAdapter(SimpleLayoutAdapter adapter)
		{
		}

		// Token: 0x06023131 RID: 143665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023131")]
		[Address(RVA = "0x1D98A80", Offset = "0x1D97680", VA = "0x181D98A80")]
		private void _UpdateViews()
		{
		}

		// Token: 0x06023132 RID: 143666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023132")]
		[Address(RVA = "0x1D98C60", Offset = "0x1D97860", VA = "0x181D98C60")]
		public ItemRepoItemCardGridView()
		{
		}

		// Token: 0x040304E1 RID: 197857
		[Token(Token = "0x40304E1")]
		[FieldOffset(Offset = "0x18")]
		private SimpleLayoutAdapter m_adapter;

		// Token: 0x040304E2 RID: 197858
		[Token(Token = "0x40304E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x040304E3 RID: 197859
		[Token(Token = "0x40304E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_adapter;

		// Token: 0x040304E4 RID: 197860
		[Token(Token = "0x40304E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ObserveAdapter;

		// Token: 0x040304E5 RID: 197861
		[Token(Token = "0x40304E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateViews;

		// Token: 0x040304E6 RID: 197862
		[Token(Token = "0x40304E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
