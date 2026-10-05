using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200397E RID: 14718
	[Token(Token = "0x200397E")]
	public abstract class LoopScrollAdapter<ViewHolder, DataType> : LoopScrollAdapter where ViewHolder : new()
	{
		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x060173E7 RID: 95207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060173E8 RID: 95208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003789")]
		public List<DataType> dataSource
		{
			[Token(Token = "0x60173E7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60173E8")]
			set
			{
			}
		}

		// Token: 0x060173E9 RID: 95209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173E9")]
		public void SetDataSource(List<DataType> list, bool forceRebuild)
		{
		}

		// Token: 0x060173EA RID: 95210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173EA")]
		protected virtual void OnDataSourceChanged()
		{
		}

		// Token: 0x060173EB RID: 95211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173EB")]
		protected sealed override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x060173EC RID: 95212 RVA: 0x00095760 File Offset: 0x00093960
		[Token(Token = "0x1700378A")]
		public sealed override int totalCount
		{
			[Token(Token = "0x60173EC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060173ED RID: 95213
		[Token(Token = "0x60173ED")]
		public abstract void UpdateView(int position, GameObject view, ViewHolder holder, DataType data);

		// Token: 0x060173EE RID: 95214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60173EE")]
		private ViewHolder _GetViewHolderSecure(Transform transform)
		{
			return null;
		}

		// Token: 0x060173EF RID: 95215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173EF")]
		protected LoopScrollAdapter()
		{
		}

		// Token: 0x0401C0EF RID: 114927
		[Token(Token = "0x401C0EF")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, ViewHolder> m_viewHolders;

		// Token: 0x0401C0F0 RID: 114928
		[Token(Token = "0x401C0F0")]
		[FieldOffset(Offset = "0x0")]
		private List<DataType> m_dataSource;

		// Token: 0x0401C0F1 RID: 114929
		[Token(Token = "0x401C0F1")]
		[FieldOffset(Offset = "0x0")]
		private int m_dataSourceCountCache;

		// Token: 0x0401C0F2 RID: 114930
		[Token(Token = "0x401C0F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataSource;

		// Token: 0x0401C0F3 RID: 114931
		[Token(Token = "0x401C0F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_dataSource;

		// Token: 0x0401C0F4 RID: 114932
		[Token(Token = "0x401C0F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetDataSource;

		// Token: 0x0401C0F5 RID: 114933
		[Token(Token = "0x401C0F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0401C0F6 RID: 114934
		[Token(Token = "0x401C0F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401C0F7 RID: 114935
		[Token(Token = "0x401C0F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0401C0F8 RID: 114936
		[Token(Token = "0x401C0F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetViewHolderSecure;

		// Token: 0x0401C0F9 RID: 114937
		[Token(Token = "0x401C0F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
