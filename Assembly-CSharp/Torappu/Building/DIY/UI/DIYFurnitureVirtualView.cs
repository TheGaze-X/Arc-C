using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B4 RID: 6580
	[Token(Token = "0x20019B4")]
	public class DIYFurnitureVirtualView : UIRecycleLayoutAdapter.VirtualView<DIYRecycleElementView>
	{
		// Token: 0x0600A548 RID: 42312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A548")]
		[Address(RVA = "0x31ED400", Offset = "0x31EC000", VA = "0x1831ED400", Slot = "12")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x00040128 File Offset: 0x0003E328
		[Token(Token = "0x600A549")]
		[Address(RVA = "0x31ED460", Offset = "0x31EC060", VA = "0x1831ED460", Slot = "13")]
		public override float GetPreferSize()
		{
			return 0f;
		}

		// Token: 0x0600A54A RID: 42314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A54A")]
		[Address(RVA = "0x31ED6C0", Offset = "0x31EC2C0", VA = "0x1831ED6C0")]
		public void UpdateItemView(DIYItemViewData data)
		{
		}

		// Token: 0x0600A54B RID: 42315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A54B")]
		[Address(RVA = "0x31ED510", Offset = "0x31EC110", VA = "0x1831ED510", Slot = "10")]
		protected override void OnViewAttached()
		{
		}

		// Token: 0x0600A54C RID: 42316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A54C")]
		[Address(RVA = "0x31ED660", Offset = "0x31EC260", VA = "0x1831ED660", Slot = "11")]
		protected override void OnViewDetached()
		{
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A54D")]
		[Address(RVA = "0x31ED7D0", Offset = "0x31EC3D0", VA = "0x1831ED7D0")]
		public DIYFurnitureVirtualView()
		{
		}

		// Token: 0x04009CCE RID: 40142
		[Token(Token = "0x4009CCE")]
		[FieldOffset(Offset = "0x20")]
		public GameObject elementPrefab;

		// Token: 0x04009CCF RID: 40143
		[Token(Token = "0x4009CCF")]
		[FieldOffset(Offset = "0x28")]
		public DIYItemViewData itemData;

		// Token: 0x04009CD0 RID: 40144
		[Token(Token = "0x4009CD0")]
		[FieldOffset(Offset = "0x30")]
		public int index;

		// Token: 0x04009CD1 RID: 40145
		[Token(Token = "0x4009CD1")]
		[FieldOffset(Offset = "0x34")]
		public DIYRecycleElementView.ElementType elementType;

		// Token: 0x04009CD2 RID: 40146
		[Token(Token = "0x4009CD2")]
		[FieldOffset(Offset = "0x38")]
		public Func<DIYItemViewData, bool> OnSelected;

		// Token: 0x04009CD3 RID: 40147
		[Token(Token = "0x4009CD3")]
		[FieldOffset(Offset = "0x40")]
		public Func<DIYItemViewData, bool> OnInfo;

		// Token: 0x04009CD4 RID: 40148
		[Token(Token = "0x4009CD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x04009CD5 RID: 40149
		[Token(Token = "0x4009CD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x04009CD6 RID: 40150
		[Token(Token = "0x4009CD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateItemView;

		// Token: 0x04009CD7 RID: 40151
		[Token(Token = "0x4009CD7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x04009CD8 RID: 40152
		[Token(Token = "0x4009CD8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x04009CD9 RID: 40153
		[Token(Token = "0x4009CD9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
