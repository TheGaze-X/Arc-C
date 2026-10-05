using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DA5 RID: 7589
	[Token(Token = "0x2001DA5")]
	public class BuildingManufactListAdapter : LoopScrollAdapter<BuildingManufactListAdapter.ViewHolder, MFormulaViewModel>
	{
		// Token: 0x0600BB25 RID: 47909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB25")]
		[Address(RVA = "0x3391900", Offset = "0x3390500", VA = "0x183391900", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600BB26 RID: 47910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB26")]
		[Address(RVA = "0x3391AA0", Offset = "0x33906A0", VA = "0x183391AA0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, BuildingManufactListAdapter.ViewHolder holder, MFormulaViewModel data)
		{
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB27")]
		[Address(RVA = "0x33919C0", Offset = "0x33905C0", VA = "0x1833919C0", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0600BB28 RID: 47912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB28")]
		[Address(RVA = "0x3391D00", Offset = "0x3390900", VA = "0x183391D00")]
		private void _TryRegisterAVGFirstItem(BuildingManufactFormulaItemView view)
		{
		}

		// Token: 0x0600BB29 RID: 47913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB29")]
		[Address(RVA = "0x3391E30", Offset = "0x3390A30", VA = "0x183391E30")]
		public BuildingManufactListAdapter()
		{
		}

		// Token: 0x0400BA99 RID: 47769
		[Token(Token = "0x400BA99")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _recycleParent;

		// Token: 0x0400BA9A RID: 47770
		[Token(Token = "0x400BA9A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BuildingManufactFormulaItemView _itemPrefab;

		// Token: 0x0400BA9B RID: 47771
		[Token(Token = "0x400BA9B")]
		[FieldOffset(Offset = "0x68")]
		private GameObjectPool m_objectPool;

		// Token: 0x0400BA9C RID: 47772
		[Token(Token = "0x400BA9C")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public string selectedItemId;

		// Token: 0x0400BA9D RID: 47773
		[Token(Token = "0x400BA9D")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<MFormulaViewModel> onFormulaClicked;

		// Token: 0x0400BA9E RID: 47774
		[Token(Token = "0x400BA9E")]
		[FieldOffset(Offset = "0x80")]
		private int m_totalCountCache;

		// Token: 0x0400BA9F RID: 47775
		[Token(Token = "0x400BA9F")]
		[FieldOffset(Offset = "0x84")]
		private bool m_AVGIsFirstItemRegistered;

		// Token: 0x0400BAA0 RID: 47776
		[Token(Token = "0x400BAA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400BAA1 RID: 47777
		[Token(Token = "0x400BAA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400BAA2 RID: 47778
		[Token(Token = "0x400BAA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0400BAA3 RID: 47779
		[Token(Token = "0x400BAA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryRegisterAVGFirstItem;

		// Token: 0x0400BAA4 RID: 47780
		[Token(Token = "0x400BAA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001DA6 RID: 7590
		[Token(Token = "0x2001DA6")]
		public class ViewHolder
		{
			// Token: 0x0600BB2A RID: 47914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BB2A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0400BAA5 RID: 47781
			[Token(Token = "0x400BAA5")]
			[FieldOffset(Offset = "0x10")]
			public BuildingManufactFormulaItemView itemView;
		}
	}
}
