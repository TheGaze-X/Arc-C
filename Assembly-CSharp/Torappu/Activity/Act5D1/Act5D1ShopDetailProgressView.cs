using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200725B RID: 29275
	[Token(Token = "0x200725B")]
	internal class Act5D1ShopDetailProgressView : Act5D1ShopDetailView
	{
		// Token: 0x060297CC RID: 169932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297CC")]
		[Address(RVA = "0x24EA820", Offset = "0x24E9420", VA = "0x1824EA820", Slot = "4")]
		public override void ApplyData(Act5D1ShopCommonViewModel data)
		{
		}

		// Token: 0x060297CD RID: 169933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297CD")]
		[Address(RVA = "0x24EABD0", Offset = "0x24E97D0", VA = "0x1824EABD0")]
		public Act5D1ShopDetailProgressView()
		{
		}

		// Token: 0x060297CE RID: 169934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297CE")]
		[Address(RVA = "0x24E8F90", Offset = "0x24E7B90", VA = "0x1824E8F90")]
		private void <>xLuaBaseProxy_ApplyData(Act5D1ShopCommonViewModel P0)
		{
		}

		// Token: 0x0403B47B RID: 242811
		[Token(Token = "0x403B47B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act5D1ShopDetailProgressItem _unactiveItem;

		// Token: 0x0403B47C RID: 242812
		[Token(Token = "0x403B47C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act5D1ShopDetailProgressItem _acativeItem;

		// Token: 0x0403B47D RID: 242813
		[Token(Token = "0x403B47D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403B47E RID: 242814
		[Token(Token = "0x403B47E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _itemDetailState;

		// Token: 0x0403B47F RID: 242815
		[Token(Token = "0x403B47F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403B480 RID: 242816
		[Token(Token = "0x403B480")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200725C RID: 29276
		[Token(Token = "0x200725C")]
		public class PrgViewModel : Act5D1ShopCommonViewModel
		{
			// Token: 0x060297CF RID: 169935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60297CF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PrgViewModel()
			{
			}

			// Token: 0x0403B481 RID: 242817
			[Token(Token = "0x403B481")]
			[FieldOffset(Offset = "0x40")]
			public string prgId;

			// Token: 0x0403B482 RID: 242818
			[Token(Token = "0x403B482")]
			[FieldOffset(Offset = "0x48")]
			public Act5D1ProgressGoodItem[] progress;
		}
	}
}
