using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200397A RID: 14714
	[Token(Token = "0x200397A")]
	public class LoopScrollAdapterBinder<TView, TData> : LoopScrollAdapterBinder where TView : Component where TData : class
	{
		// Token: 0x060173B5 RID: 95157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173B5")]
		public LoopScrollAdapterBinder(LoopScrollAdapterBinder<TView, TData>.Options options)
		{
		}

		// Token: 0x060173B6 RID: 95158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173B6")]
		public void SetDataSource(IList<TData> list, bool forceRebuild = false)
		{
		}

		// Token: 0x060173B7 RID: 95159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173B7")]
		protected sealed override void UpdateView(int position, GameObject go, GetComponentCache holder, object data)
		{
		}

		// Token: 0x0401C0B2 RID: 114866
		[Token(Token = "0x401C0B2")]
		[FieldOffset(Offset = "0x0")]
		private LoopScrollAdapterBinder<TView, TData>.Options m_options;

		// Token: 0x0401C0B3 RID: 114867
		[Token(Token = "0x401C0B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C0B4 RID: 114868
		[Token(Token = "0x401C0B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetDataSource;

		// Token: 0x0401C0B5 RID: 114869
		[Token(Token = "0x401C0B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0200397B RID: 14715
		[Token(Token = "0x200397B")]
		public struct Options
		{
			// Token: 0x0401C0B6 RID: 114870
			[Token(Token = "0x401C0B6")]
			[FieldOffset(Offset = "0x0")]
			public LoopScrollAdapter<GetComponentCache, object> behaviour;

			// Token: 0x0401C0B7 RID: 114871
			[Token(Token = "0x401C0B7")]
			[FieldOffset(Offset = "0x0")]
			public Action<int, TView, TData> onViewUpdated;

			// Token: 0x0401C0B8 RID: 114872
			[Token(Token = "0x401C0B8")]
			[FieldOffset(Offset = "0x0")]
			public Action<TView> onNewViewCreated;
		}
	}
}
