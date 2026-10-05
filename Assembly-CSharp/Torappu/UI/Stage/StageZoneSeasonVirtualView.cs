using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006941 RID: 26945
	[Token(Token = "0x2006941")]
	public class StageZoneSeasonVirtualView<ViewType, ViewModel> : UIRecycleLayoutAdapter.VirtualView<ViewType>, IStageZoneSeasonVirtualView, IHotfixable where ViewType : StageZoneSeasonEntryItem<ViewModel> where ViewModel : StageZoneSeasonEntryViewModel
	{
		// Token: 0x0602694B RID: 158027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602694B")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x0602694C RID: 158028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602694C")]
		protected override void OnViewAttached()
		{
		}

		// Token: 0x0602694D RID: 158029 RVA: 0x000CBBF8 File Offset: 0x000C9DF8
		[Token(Token = "0x602694D")]
		public override float GetPreferSize()
		{
			return 0f;
		}

		// Token: 0x0602694E RID: 158030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602694E")]
		protected override void OnViewDetached()
		{
		}

		// Token: 0x0602694F RID: 158031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602694F")]
		public void RefreshView()
		{
		}

		// Token: 0x06026950 RID: 158032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026950")]
		public StageZoneSeasonVirtualView()
		{
		}

		// Token: 0x040366D6 RID: 222934
		[Token(Token = "0x40366D6")]
		[FieldOffset(Offset = "0x0")]
		public GameObject prefab;

		// Token: 0x040366D7 RID: 222935
		[Token(Token = "0x40366D7")]
		[FieldOffset(Offset = "0x0")]
		public ViewType singleView;

		// Token: 0x040366D8 RID: 222936
		[Token(Token = "0x40366D8")]
		[FieldOffset(Offset = "0x0")]
		public ViewModel viewModel;

		// Token: 0x040366D9 RID: 222937
		[Token(Token = "0x40366D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x040366DA RID: 222938
		[Token(Token = "0x40366DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x040366DB RID: 222939
		[Token(Token = "0x40366DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x040366DC RID: 222940
		[Token(Token = "0x40366DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x040366DD RID: 222941
		[Token(Token = "0x40366DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x040366DE RID: 222942
		[Token(Token = "0x40366DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
