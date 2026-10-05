using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C8C RID: 7308
	[Token(Token = "0x2001C8C")]
	public class BuildingStationSelectConfirmRoomCharCardAdapter : LoopScrollAdapter<BuildingStationSelectConfirmRoomCharCardAdapter.ViewHolder, ChangedCharCardViewModel>
	{
		// Token: 0x0600B57D RID: 46461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B57D")]
		[Address(RVA = "0x330F030", Offset = "0x330DC30", VA = "0x18330F030", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B57E")]
		[Address(RVA = "0x330F0F0", Offset = "0x330DCF0", VA = "0x18330F0F0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, BuildingStationSelectConfirmRoomCharCardAdapter.ViewHolder holder, ChangedCharCardViewModel data)
		{
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B57F")]
		[Address(RVA = "0x330F250", Offset = "0x330DE50", VA = "0x18330F250")]
		public BuildingStationSelectConfirmRoomCharCardAdapter()
		{
		}

		// Token: 0x0400B1D3 RID: 45523
		[Token(Token = "0x400B1D3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingStationSelectConfirmCard _charPrefab;

		// Token: 0x0400B1D4 RID: 45524
		[Token(Token = "0x400B1D4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _poolTransform;

		// Token: 0x0400B1D5 RID: 45525
		[Token(Token = "0x400B1D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400B1D6 RID: 45526
		[Token(Token = "0x400B1D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400B1D7 RID: 45527
		[Token(Token = "0x400B1D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C8D RID: 7309
		[Token(Token = "0x2001C8D")]
		public class ViewHolder
		{
			// Token: 0x0600B580 RID: 46464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B580")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0400B1D8 RID: 45528
			[Token(Token = "0x400B1D8")]
			[FieldOffset(Offset = "0x10")]
			public BuildingStationSelectConfirmCard view;
		}
	}
}
