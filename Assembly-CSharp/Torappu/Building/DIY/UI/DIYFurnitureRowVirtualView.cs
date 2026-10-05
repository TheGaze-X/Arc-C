using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200198D RID: 6541
	[Token(Token = "0x200198D")]
	public class DIYFurnitureRowVirtualView : UIRecycleLayoutAdapter.VirtualView<DIYFurnitureRowView>
	{
		// Token: 0x0600A414 RID: 42004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A414")]
		[Address(RVA = "0x31DD580", Offset = "0x31DC180", VA = "0x1831DD580")]
		public void SetViewIndex(int viewIndex)
		{
		}

		// Token: 0x0600A415 RID: 42005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A415")]
		[Address(RVA = "0x31DD300", Offset = "0x31DBF00", VA = "0x1831DD300", Slot = "12")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x0003F918 File Offset: 0x0003DB18
		[Token(Token = "0x600A416")]
		[Address(RVA = "0x31DD360", Offset = "0x31DBF60", VA = "0x1831DD360", Slot = "13")]
		public override float GetPreferSize()
		{
			return 0f;
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A417")]
		[Address(RVA = "0x31DD3C0", Offset = "0x31DBFC0", VA = "0x1831DD3C0", Slot = "10")]
		protected override void OnViewAttached()
		{
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A418")]
		[Address(RVA = "0x31DD520", Offset = "0x31DC120", VA = "0x1831DD520", Slot = "11")]
		protected override void OnViewDetached()
		{
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A419")]
		[Address(RVA = "0x31DD5F0", Offset = "0x31DC1F0", VA = "0x1831DD5F0")]
		public DIYFurnitureRowVirtualView()
		{
		}

		// Token: 0x04009B1C RID: 39708
		[Token(Token = "0x4009B1C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject rowPrefab;

		// Token: 0x04009B1D RID: 39709
		[Token(Token = "0x4009B1D")]
		[FieldOffset(Offset = "0x28")]
		public List<DIYItemViewData> rowDatas;

		// Token: 0x04009B1E RID: 39710
		[Token(Token = "0x4009B1E")]
		[FieldOffset(Offset = "0x30")]
		public float rowHeight;

		// Token: 0x04009B1F RID: 39711
		[Token(Token = "0x4009B1F")]
		[FieldOffset(Offset = "0x34")]
		public DIYViewListModel.DIYViewListThemeState themeState;

		// Token: 0x04009B20 RID: 39712
		[Token(Token = "0x4009B20")]
		[FieldOffset(Offset = "0x38")]
		public Func<DIYItemViewData, bool> OnSelected;

		// Token: 0x04009B21 RID: 39713
		[Token(Token = "0x4009B21")]
		[FieldOffset(Offset = "0x40")]
		public Func<DIYItemViewData, bool> OnInfo;

		// Token: 0x04009B22 RID: 39714
		[Token(Token = "0x4009B22")]
		[FieldOffset(Offset = "0x48")]
		private int m_viewIndex;

		// Token: 0x04009B23 RID: 39715
		[Token(Token = "0x4009B23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetViewIndex;

		// Token: 0x04009B24 RID: 39716
		[Token(Token = "0x4009B24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x04009B25 RID: 39717
		[Token(Token = "0x4009B25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x04009B26 RID: 39718
		[Token(Token = "0x4009B26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x04009B27 RID: 39719
		[Token(Token = "0x4009B27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x04009B28 RID: 39720
		[Token(Token = "0x4009B28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
