using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037D9 RID: 14297
	[Token(Token = "0x20037D9")]
	public abstract class AsyncDataViewListAdapter<TView, TData> : IHotfixable where TView : Component, IAsyncDataView<TData>
	{
		// Token: 0x06016AB7 RID: 92855
		[Token(Token = "0x6016AB7")]
		protected abstract int GetCount();

		// Token: 0x06016AB8 RID: 92856
		[Token(Token = "0x6016AB8")]
		protected abstract TData GetData(int index);

		// Token: 0x06016AB9 RID: 92857
		[Token(Token = "0x6016AB9")]
		protected abstract GameObject GetPrefab();

		// Token: 0x06016ABA RID: 92858
		[Token(Token = "0x6016ABA")]
		protected abstract Transform GetListContainer();

		// Token: 0x06016ABB RID: 92859
		[Token(Token = "0x6016ABB")]
		protected abstract uint CostPerItem();

		// Token: 0x06016ABC RID: 92860 RVA: 0x00092598 File Offset: 0x00090798
		[Token(Token = "0x6016ABC")]
		protected virtual int GetListGroup()
		{
			return 0;
		}

		// Token: 0x06016ABD RID: 92861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016ABD")]
		protected virtual Component GetMaintainer()
		{
			return null;
		}

		// Token: 0x06016ABE RID: 92862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ABE")]
		public void NotifyDataChanged(AsyncGameObjectLoader loader)
		{
		}

		// Token: 0x06016ABF RID: 92863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ABF")]
		private void _UpdateViews(AsyncGameObjectLoader loader)
		{
		}

		// Token: 0x06016AC0 RID: 92864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AC0")]
		protected AsyncDataViewListAdapter()
		{
		}

		// Token: 0x0401B526 RID: 111910
		[Token(Token = "0x401B526")]
		[FieldOffset(Offset = "0x0")]
		private List<AsyncDataViewHandler<TView, TData>> m_viewHandlers;

		// Token: 0x0401B527 RID: 111911
		[Token(Token = "0x401B527")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetListGroup;

		// Token: 0x0401B528 RID: 111912
		[Token(Token = "0x401B528")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMaintainer;

		// Token: 0x0401B529 RID: 111913
		[Token(Token = "0x401B529")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NotifyDataChanged;

		// Token: 0x0401B52A RID: 111914
		[Token(Token = "0x401B52A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateViews;

		// Token: 0x0401B52B RID: 111915
		[Token(Token = "0x401B52B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
