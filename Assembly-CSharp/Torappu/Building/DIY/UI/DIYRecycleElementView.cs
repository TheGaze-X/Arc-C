using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B2 RID: 6578
	[Token(Token = "0x20019B2")]
	public class DIYRecycleElementView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x0600A540 RID: 42304 RVA: 0x00040110 File Offset: 0x0003E310
		// (set) Token: 0x0600A541 RID: 42305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700130C")]
		public int index
		{
			[Token(Token = "0x600A540")]
			[Address(RVA = "0x31F5E50", Offset = "0x31F4A50", VA = "0x1831F5E50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A541")]
			[Address(RVA = "0x31F5EB0", Offset = "0x31F4AB0", VA = "0x1831F5EB0")]
			set
			{
			}
		}

		// Token: 0x0600A542 RID: 42306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A542")]
		[Address(RVA = "0x31F59F0", Offset = "0x31F45F0", VA = "0x1831F59F0")]
		private void _OnButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A543")]
		[Address(RVA = "0x31F5AE0", Offset = "0x31F46E0", VA = "0x1831F5AE0")]
		private void _OnInfoButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A544")]
		[Address(RVA = "0x31F5620", Offset = "0x31F4220", VA = "0x1831F5620")]
		public void SetUpFurnItemView(DIYItemViewData viewData, int idx, DIYRecycleElementView.ElementType type, bool firstRow = true)
		{
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A545")]
		[Address(RVA = "0x31F58A0", Offset = "0x31F44A0", VA = "0x1831F58A0")]
		public void UpdateFurnItemView(DIYItemViewData viewData, DIYRecycleElementView.ElementType type, bool firstRow = true)
		{
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A546")]
		[Address(RVA = "0x31F5BD0", Offset = "0x31F47D0", VA = "0x1831F5BD0")]
		private void _UpdateFuncFurniFrame(DIYItemViewData viewData, DIYRecycleElementView.ElementType type, bool firstRow)
		{
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A547")]
		[Address(RVA = "0x31F5DF0", Offset = "0x31F49F0", VA = "0x1831F5DF0")]
		public DIYRecycleElementView()
		{
		}

		// Token: 0x04009CB9 RID: 40121
		[Token(Token = "0x4009CB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FurnitureItemView _furnItemView;

		// Token: 0x04009CBA RID: 40122
		[Token(Token = "0x4009CBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bgGrey;

		// Token: 0x04009CBB RID: 40123
		[Token(Token = "0x4009CBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _frameSelected;

		// Token: 0x04009CBC RID: 40124
		[Token(Token = "0x4009CBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imgUpperBlue;

		// Token: 0x04009CBD RID: 40125
		[Token(Token = "0x4009CBD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _coverGrey;

		// Token: 0x04009CBE RID: 40126
		[Token(Token = "0x4009CBE")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> furnitureSelected;

		// Token: 0x04009CBF RID: 40127
		[Token(Token = "0x4009CBF")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> infoButtonPressed;

		// Token: 0x04009CC0 RID: 40128
		[Token(Token = "0x4009CC0")]
		[FieldOffset(Offset = "0x50")]
		private int m_index;

		// Token: 0x04009CC1 RID: 40129
		[Token(Token = "0x4009CC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x04009CC2 RID: 40130
		[Token(Token = "0x4009CC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x04009CC3 RID: 40131
		[Token(Token = "0x4009CC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnButtonPressed;

		// Token: 0x04009CC4 RID: 40132
		[Token(Token = "0x4009CC4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnInfoButtonPressed;

		// Token: 0x04009CC5 RID: 40133
		[Token(Token = "0x4009CC5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetUpFurnItemView;

		// Token: 0x04009CC6 RID: 40134
		[Token(Token = "0x4009CC6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateFurnItemView;

		// Token: 0x04009CC7 RID: 40135
		[Token(Token = "0x4009CC7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateFuncFurniFrame;

		// Token: 0x04009CC8 RID: 40136
		[Token(Token = "0x4009CC8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020019B3 RID: 6579
		[Token(Token = "0x20019B3")]
		public enum ElementType
		{
			// Token: 0x04009CCA RID: 40138
			[Token(Token = "0x4009CCA")]
			DEFAULT,
			// Token: 0x04009CCB RID: 40139
			[Token(Token = "0x4009CCB")]
			FUNC,
			// Token: 0x04009CCC RID: 40140
			[Token(Token = "0x4009CCC")]
			EMPTY,
			// Token: 0x04009CCD RID: 40141
			[Token(Token = "0x4009CCD")]
			ROW_EMPTY
		}
	}
}
