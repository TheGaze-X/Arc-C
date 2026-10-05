using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040F2 RID: 16626
	[Token(Token = "0x20040F2")]
	public class SandboxV2WorkbenchLoopAdapter : LoopScrollAdapter<SandboxV2WorkbenchLoopAdapter.ViewHolder, SandboxV2WorkbenchItemModel>
	{
		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x06019B69 RID: 105321 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019B6A RID: 105322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D59")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x6019B69")]
			[Address(RVA = "0x1299980", Offset = "0x1298580", VA = "0x181299980")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019B6A")]
			[Address(RVA = "0x12999E0", Offset = "0x12985E0", VA = "0x1812999E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019B6B RID: 105323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B6B")]
		[Address(RVA = "0x1299320", Offset = "0x1297F20", VA = "0x181299320", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06019B6C RID: 105324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B6C")]
		[Address(RVA = "0x12993E0", Offset = "0x1297FE0", VA = "0x1812993E0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SandboxV2WorkbenchLoopAdapter.ViewHolder holder, SandboxV2WorkbenchItemModel data)
		{
		}

		// Token: 0x06019B6D RID: 105325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B6D")]
		[Address(RVA = "0x12997F0", Offset = "0x12983F0", VA = "0x1812997F0")]
		private void _TutorialOnly_TryRegisterAVGFirstItem(SandboxV2WorkbenchItemView view)
		{
		}

		// Token: 0x06019B6E RID: 105326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B6E")]
		[Address(RVA = "0x1299910", Offset = "0x1298510", VA = "0x181299910")]
		public SandboxV2WorkbenchLoopAdapter()
		{
		}

		// Token: 0x040202BB RID: 131771
		[Token(Token = "0x40202BB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2WorkbenchItemView _itemViewPrefab;

		// Token: 0x040202BD RID: 131773
		[Token(Token = "0x40202BD")]
		[FieldOffset(Offset = "0x68")]
		private bool m_tutorialIsFirstItemRegistered;

		// Token: 0x040202BE RID: 131774
		[Token(Token = "0x40202BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x040202BF RID: 131775
		[Token(Token = "0x40202BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x040202C0 RID: 131776
		[Token(Token = "0x40202C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040202C1 RID: 131777
		[Token(Token = "0x40202C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040202C2 RID: 131778
		[Token(Token = "0x40202C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRegisterAVGFirstItem;

		// Token: 0x040202C3 RID: 131779
		[Token(Token = "0x40202C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040F3 RID: 16627
		[Token(Token = "0x20040F3")]
		public class ViewHolder
		{
			// Token: 0x06019B6F RID: 105327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B6F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040202C4 RID: 131780
			[Token(Token = "0x40202C4")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2WorkbenchItemView view;
		}
	}
}
