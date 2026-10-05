using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039BE RID: 14782
	[Token(Token = "0x20039BE")]
	public abstract class SimpleLayoutAdapter : IHotfixable
	{
		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x060175AE RID: 95662
		[Token(Token = "0x170037EE")]
		public abstract int count { [Token(Token = "0x60175AE")] get; }

		// Token: 0x060175AF RID: 95663
		[Token(Token = "0x60175AF")]
		public abstract GameObject RenderView(int position, GameObject prefab, Transform parent);

		// Token: 0x060175B0 RID: 95664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175B0")]
		[Address(RVA = "0xFB7AB0", Offset = "0xFB66B0", VA = "0x180FB7AB0", Slot = "6")]
		public virtual void DestoryView(int position, GameObject view)
		{
		}

		// Token: 0x060175B1 RID: 95665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175B1")]
		[Address(RVA = "0xFB7980", Offset = "0xFB6580", VA = "0x180FB7980")]
		public void CleanView()
		{
		}

		// Token: 0x060175B2 RID: 95666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60175B2")]
		[Address(RVA = "0xFB7B40", Offset = "0xFB6740", VA = "0x180FB7B40")]
		public GameObject GetView(int position)
		{
			return null;
		}

		// Token: 0x060175B3 RID: 95667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175B3")]
		[Address(RVA = "0xFB7E50", Offset = "0xFB6A50", VA = "0x180FB7E50")]
		public void UpdateViewInstance(int position, GameObject view)
		{
		}

		// Token: 0x060175B4 RID: 95668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175B4")]
		[Address(RVA = "0xFB7DC0", Offset = "0xFB69C0", VA = "0x180FB7DC0")]
		public void TriggerViewRecycle()
		{
		}

		// Token: 0x060175B5 RID: 95669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175B5")]
		[Address(RVA = "0xFB7C60", Offset = "0xFB6860", VA = "0x180FB7C60", Slot = "7")]
		protected virtual void RecycleViews(List<GameObject> views)
		{
		}

		// Token: 0x060175B6 RID: 95670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175B6")]
		[Address(RVA = "0xFB7BF0", Offset = "0xFB67F0", VA = "0x180FB7BF0", Slot = "8")]
		public virtual void NotifyDataSetChanged()
		{
		}

		// Token: 0x060175B7 RID: 95671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175B7")]
		[Address(RVA = "0xFB8040", Offset = "0xFB6C40", VA = "0x180FB8040")]
		protected SimpleLayoutAdapter()
		{
		}

		// Token: 0x0401C336 RID: 115510
		[Token(Token = "0x401C336")]
		[FieldOffset(Offset = "0x10")]
		private List<GameObject> m_views;

		// Token: 0x0401C337 RID: 115511
		[Token(Token = "0x401C337")]
		[FieldOffset(Offset = "0x18")]
		public Action<SimpleLayoutAdapter> observer;

		// Token: 0x0401C338 RID: 115512
		[Token(Token = "0x401C338")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DestoryView;

		// Token: 0x0401C339 RID: 115513
		[Token(Token = "0x401C339")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CleanView;

		// Token: 0x0401C33A RID: 115514
		[Token(Token = "0x401C33A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetView;

		// Token: 0x0401C33B RID: 115515
		[Token(Token = "0x401C33B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateViewInstance;

		// Token: 0x0401C33C RID: 115516
		[Token(Token = "0x401C33C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerViewRecycle;

		// Token: 0x0401C33D RID: 115517
		[Token(Token = "0x401C33D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RecycleViews;

		// Token: 0x0401C33E RID: 115518
		[Token(Token = "0x401C33E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyDataSetChanged;

		// Token: 0x0401C33F RID: 115519
		[Token(Token = "0x401C33F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
