using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003482 RID: 13442
	[Token(Token = "0x2003482")]
	public abstract class AsyncGameObjectDictPool<TObj, TData> : AbstractGameObjectDictPool<TObj, AsyncDataViewHandler<TObj, TData>> where TObj : Component, IAsyncDataView<TData> where TData : new()
	{
		// Token: 0x06015725 RID: 87845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015725")]
		protected sealed override void SetInstActive(AsyncDataViewHandler<TObj, TData> inst, bool active)
		{
		}

		// Token: 0x06015726 RID: 87846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015726")]
		protected sealed override void OnAllocate(string key, AsyncDataViewHandler<TObj, TData> obj)
		{
		}

		// Token: 0x06015727 RID: 87847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015727")]
		protected sealed override void OnRecycle(string key, AsyncDataViewHandler<TObj, TData> obj)
		{
		}

		// Token: 0x06015728 RID: 87848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015728")]
		protected AsyncGameObjectDictPool()
		{
		}

		// Token: 0x04019ACD RID: 105165
		[Token(Token = "0x4019ACD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetInstActive;

		// Token: 0x04019ACE RID: 105166
		[Token(Token = "0x4019ACE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04019ACF RID: 105167
		[Token(Token = "0x4019ACF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04019AD0 RID: 105168
		[Token(Token = "0x4019AD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
