using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039C0 RID: 14784
	[Token(Token = "0x20039C0")]
	public class SimpleLayoutAdapter<TView, TData> : SimpleLayoutAdapter<TView> where TView : Component
	{
		// Token: 0x060175BB RID: 95675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175BB")]
		public SimpleLayoutAdapter(SimpleLayoutAdapter<TView, TData>.Options options)
		{
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x060175BC RID: 95676 RVA: 0x00096270 File Offset: 0x00094470
		[Token(Token = "0x170037EF")]
		public sealed override int count
		{
			[Token(Token = "0x60175BC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060175BD RID: 95677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175BD")]
		protected sealed override void OnRender(int position, TView view, bool isNewlyCreated)
		{
		}

		// Token: 0x0401C342 RID: 115522
		[Token(Token = "0x401C342")]
		[FieldOffset(Offset = "0x0")]
		private SimpleLayoutAdapter<TView, TData>.Options m_options;

		// Token: 0x0401C343 RID: 115523
		[Token(Token = "0x401C343")]
		[FieldOffset(Offset = "0x0")]
		public IList<TData> dataList;

		// Token: 0x0401C344 RID: 115524
		[Token(Token = "0x401C344")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C345 RID: 115525
		[Token(Token = "0x401C345")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0401C346 RID: 115526
		[Token(Token = "0x401C346")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x020039C1 RID: 14785
		[Token(Token = "0x20039C1")]
		public struct Options
		{
			// Token: 0x0401C347 RID: 115527
			[Token(Token = "0x401C347")]
			[FieldOffset(Offset = "0x0")]
			public Action<int, TView, TData> onViewUpdated;

			// Token: 0x0401C348 RID: 115528
			[Token(Token = "0x401C348")]
			[FieldOffset(Offset = "0x0")]
			public Action<TView> onNewViewCreated;
		}
	}
}
