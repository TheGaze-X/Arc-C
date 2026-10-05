using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001992 RID: 6546
	[Token(Token = "0x2001992")]
	public class DIYFurnitureTitleVirtualView : UIRecycleLayoutAdapter.VirtualView<DIYFurnitureTitleView>
	{
		// Token: 0x0600A42C RID: 42028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A42C")]
		[Address(RVA = "0x31DF220", Offset = "0x31DDE20", VA = "0x1831DF220")]
		public void SetText(string text)
		{
		}

		// Token: 0x0600A42D RID: 42029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A42D")]
		[Address(RVA = "0x31DF2A0", Offset = "0x31DDEA0", VA = "0x1831DF2A0")]
		public void SetViewIndex(int viewIndex)
		{
		}

		// Token: 0x0600A42E RID: 42030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A42E")]
		[Address(RVA = "0x31DEE00", Offset = "0x31DDA00", VA = "0x1831DEE00", Slot = "12")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x0003F930 File Offset: 0x0003DB30
		[Token(Token = "0x600A42F")]
		[Address(RVA = "0x31DEE60", Offset = "0x31DDA60", VA = "0x1831DEE60", Slot = "13")]
		public override float GetPreferSize()
		{
			return 0f;
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A430")]
		[Address(RVA = "0x31DEF10", Offset = "0x31DDB10", VA = "0x1831DEF10", Slot = "10")]
		protected override void OnViewAttached()
		{
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A431")]
		[Address(RVA = "0x31DF1C0", Offset = "0x31DDDC0", VA = "0x1831DF1C0", Slot = "11")]
		protected override void OnViewDetached()
		{
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A432")]
		[Address(RVA = "0x31DF310", Offset = "0x31DDF10", VA = "0x1831DF310")]
		public DIYFurnitureTitleVirtualView()
		{
		}

		// Token: 0x04009B50 RID: 39760
		[Token(Token = "0x4009B50")]
		[FieldOffset(Offset = "0x20")]
		public GameObject prefab;

		// Token: 0x04009B51 RID: 39761
		[Token(Token = "0x4009B51")]
		[FieldOffset(Offset = "0x28")]
		public List<DIYItemViewData> rowDatas;

		// Token: 0x04009B52 RID: 39762
		[Token(Token = "0x4009B52")]
		[FieldOffset(Offset = "0x30")]
		public float rowHeight;

		// Token: 0x04009B53 RID: 39763
		[Token(Token = "0x4009B53")]
		[FieldOffset(Offset = "0x34")]
		public DIYViewListModel.DIYViewListThemeState themeState;

		// Token: 0x04009B54 RID: 39764
		[Token(Token = "0x4009B54")]
		[FieldOffset(Offset = "0x38")]
		public Func<DIYItemViewData, bool> OnSelected;

		// Token: 0x04009B55 RID: 39765
		[Token(Token = "0x4009B55")]
		[FieldOffset(Offset = "0x40")]
		public Func<DIYItemViewData, bool> OnInfo;

		// Token: 0x04009B56 RID: 39766
		[Token(Token = "0x4009B56")]
		[FieldOffset(Offset = "0x48")]
		private int m_viewIndex;

		// Token: 0x04009B57 RID: 39767
		[Token(Token = "0x4009B57")]
		[FieldOffset(Offset = "0x50")]
		private string m_text;

		// Token: 0x04009B58 RID: 39768
		[Token(Token = "0x4009B58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetText;

		// Token: 0x04009B59 RID: 39769
		[Token(Token = "0x4009B59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetViewIndex;

		// Token: 0x04009B5A RID: 39770
		[Token(Token = "0x4009B5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x04009B5B RID: 39771
		[Token(Token = "0x4009B5B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x04009B5C RID: 39772
		[Token(Token = "0x4009B5C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x04009B5D RID: 39773
		[Token(Token = "0x4009B5D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x04009B5E RID: 39774
		[Token(Token = "0x4009B5E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
