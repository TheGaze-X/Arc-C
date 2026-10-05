using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C36 RID: 19510
	[Token(Token = "0x2004C36")]
	public class HomeMailArchiveBarListAdapter : LoopScrollAdapter<HomeMailArchiveBarListAdapter.ViewHolder, HomeMailArchiveItemViewModel>, IHotfixable
	{
		// Token: 0x170044DA RID: 17626
		// (get) Token: 0x0601D4B8 RID: 119992 RVA: 0x000AB1C8 File Offset: 0x000A93C8
		// (set) Token: 0x0601D4B9 RID: 119993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044DA")]
		public int focusYear
		{
			[Token(Token = "0x601D4B8")]
			[Address(RVA = "0x16CF8E0", Offset = "0x16CE4E0", VA = "0x1816CF8E0")]
			[CompilerGenerated]
			private get
			{
				return 0;
			}
			[Token(Token = "0x601D4B9")]
			[Address(RVA = "0x16CF940", Offset = "0x16CE540", VA = "0x1816CF940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601D4BA RID: 119994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D4BA")]
		[Address(RVA = "0x16CF420", Offset = "0x16CE020", VA = "0x1816CF420", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601D4BB RID: 119995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4BB")]
		[Address(RVA = "0x16CF620", Offset = "0x16CE220", VA = "0x1816CF620", Slot = "13")]
		public override void UpdateView(int position, GameObject view, HomeMailArchiveBarListAdapter.ViewHolder holder, HomeMailArchiveItemViewModel data)
		{
		}

		// Token: 0x0601D4BC RID: 119996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4BC")]
		[Address(RVA = "0x16CF4D0", Offset = "0x16CE0D0", VA = "0x1816CF4D0", Slot = "9")]
		protected override void OnNewItemAlloc(GameObject newItem)
		{
		}

		// Token: 0x0601D4BD RID: 119997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4BD")]
		[Address(RVA = "0x16CF870", Offset = "0x16CE470", VA = "0x1816CF870")]
		public HomeMailArchiveBarListAdapter()
		{
		}

		// Token: 0x0601D4BE RID: 119998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4BE")]
		[Address(RVA = "0x138F8E0", Offset = "0x138E4E0", VA = "0x18138F8E0")]
		private void <>xLuaBaseProxy_OnNewItemAlloc(GameObject P0)
		{
		}

		// Token: 0x04026898 RID: 157848
		[Token(Token = "0x4026898")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402689A RID: 157850
		[Token(Token = "0x402689A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusYear;

		// Token: 0x0402689B RID: 157851
		[Token(Token = "0x402689B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_focusYear;

		// Token: 0x0402689C RID: 157852
		[Token(Token = "0x402689C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402689D RID: 157853
		[Token(Token = "0x402689D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402689E RID: 157854
		[Token(Token = "0x402689E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnNewItemAlloc;

		// Token: 0x0402689F RID: 157855
		[Token(Token = "0x402689F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C37 RID: 19511
		[Token(Token = "0x2004C37")]
		public class ViewHolder
		{
			// Token: 0x0601D4BF RID: 119999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D4BF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040268A0 RID: 157856
			[Token(Token = "0x40268A0")]
			[FieldOffset(Offset = "0x10")]
			public HomeMailArchiveBarItemView itemView;
		}
	}
}
