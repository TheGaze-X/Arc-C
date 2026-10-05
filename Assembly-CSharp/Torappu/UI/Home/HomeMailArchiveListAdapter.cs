using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C3C RID: 19516
	[Token(Token = "0x2004C3C")]
	public class HomeMailArchiveListAdapter : LoopScrollAdapter<HomeMailArchiveListAdapter.ViewHolder, HomeMailArchiveItemViewModel>, IHotfixable
	{
		// Token: 0x0601D4D3 RID: 120019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D4D3")]
		[Address(RVA = "0x16D0E30", Offset = "0x16CFA30", VA = "0x1816D0E30", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601D4D4 RID: 120020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4D4")]
		[Address(RVA = "0x16D0EE0", Offset = "0x16CFAE0", VA = "0x1816D0EE0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, HomeMailArchiveListAdapter.ViewHolder holder, HomeMailArchiveItemViewModel data)
		{
		}

		// Token: 0x0601D4D5 RID: 120021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4D5")]
		[Address(RVA = "0x16D1030", Offset = "0x16CFC30", VA = "0x1816D1030")]
		public HomeMailArchiveListAdapter()
		{
		}

		// Token: 0x040268D7 RID: 157911
		[Token(Token = "0x40268D7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x040268D8 RID: 157912
		[Token(Token = "0x40268D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040268D9 RID: 157913
		[Token(Token = "0x40268D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040268DA RID: 157914
		[Token(Token = "0x40268DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C3D RID: 19517
		[Token(Token = "0x2004C3D")]
		public class ViewHolder
		{
			// Token: 0x0601D4D6 RID: 120022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D4D6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040268DB RID: 157915
			[Token(Token = "0x40268DB")]
			[FieldOffset(Offset = "0x10")]
			public HomeMailArchiveItemView itemView;
		}
	}
}
