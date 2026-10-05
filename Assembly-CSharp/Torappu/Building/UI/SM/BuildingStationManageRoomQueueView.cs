using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CD1 RID: 7377
	[Token(Token = "0x2001CD1")]
	public class BuildingStationManageRoomQueueView : BuildingStationManageQueueBaseView, IHotfixable
	{
		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x0600B69C RID: 46748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015EA")]
		protected override BuildingStationManageQueueBaseView.CharAdapter charAdapter
		{
			[Token(Token = "0x600B69C")]
			[Address(RVA = "0x3347F90", Offset = "0x3346B90", VA = "0x183347F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B69D RID: 46749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B69D")]
		[Address(RVA = "0x3347410", Offset = "0x3346010", VA = "0x183347410", Slot = "5")]
		protected override void InitAdapter()
		{
		}

		// Token: 0x0600B69E RID: 46750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B69E")]
		[Address(RVA = "0x3347C30", Offset = "0x3346830", VA = "0x183347C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B69F RID: 46751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B69F")]
		[Address(RVA = "0x3347540", Offset = "0x3346140", VA = "0x183347540")]
		public void Render(StationManageEditRoomQueueStructModel queueStructModel)
		{
		}

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6A0")]
		[Address(RVA = "0x3347D20", Offset = "0x3346920", VA = "0x183347D20")]
		private void _TryPlayQueueUpdateAnim(StationManageEditRoomQueueStructModel queueStructModel)
		{
		}

		// Token: 0x0600B6A1 RID: 46753 RVA: 0x00044F40 File Offset: 0x00043140
		[Token(Token = "0x600B6A1")]
		[Address(RVA = "0x33478B0", Offset = "0x33464B0", VA = "0x1833478B0")]
		private bool _GetIsQueueChanged(StationCharStructModel[] newQueue)
		{
			return default(bool);
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6A2")]
		[Address(RVA = "0x3347EA0", Offset = "0x3346AA0", VA = "0x183347EA0")]
		public BuildingStationManageRoomQueueView()
		{
		}

		// Token: 0x0400B401 RID: 46081
		[Token(Token = "0x400B401")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animSwitchQueue;

		// Token: 0x0400B402 RID: 46082
		[Token(Token = "0x400B402")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0400B403 RID: 46083
		[Token(Token = "0x400B403")]
		[FieldOffset(Offset = "0x58")]
		private BuildingStationManageRoomQueueView.CharAdapterForEditRoom m_charAdapter;

		// Token: 0x0400B404 RID: 46084
		[Token(Token = "0x400B404")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_switchQueueAnimTween;

		// Token: 0x0400B405 RID: 46085
		[Token(Token = "0x400B405")]
		[FieldOffset(Offset = "0x68")]
		private IntHashSet prefCharsInstIdSet;

		// Token: 0x0400B406 RID: 46086
		[Token(Token = "0x400B406")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charAdapter;

		// Token: 0x0400B407 RID: 46087
		[Token(Token = "0x400B407")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAdapter;

		// Token: 0x0400B408 RID: 46088
		[Token(Token = "0x400B408")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B409 RID: 46089
		[Token(Token = "0x400B409")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B40A RID: 46090
		[Token(Token = "0x400B40A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryPlayQueueUpdateAnim;

		// Token: 0x0400B40B RID: 46091
		[Token(Token = "0x400B40B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetIsQueueChanged;

		// Token: 0x0400B40C RID: 46092
		[Token(Token = "0x400B40C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CD2 RID: 7378
		[Token(Token = "0x2001CD2")]
		private class CharAdapterForEditRoom : BuildingStationManageQueueBaseView.CharAdapter
		{
			// Token: 0x0600B6A3 RID: 46755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6A3")]
			[Address(RVA = "0x334B6C0", Offset = "0x334A2C0", VA = "0x18334B6C0")]
			public CharAdapterForEditRoom(BuildingStationManageRoomQueueView closure)
			{
			}

			// Token: 0x170015EB RID: 5611
			// (get) Token: 0x0600B6A4 RID: 46756 RVA: 0x00044F58 File Offset: 0x00043158
			[Token(Token = "0x170015EB")]
			public override int count
			{
				[Token(Token = "0x600B6A4")]
				[Address(RVA = "0x334B780", Offset = "0x334A380", VA = "0x18334B780", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B6A5 RID: 46757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B6A5")]
			[Address(RVA = "0x334B2E0", Offset = "0x3349EE0", VA = "0x18334B2E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B40D RID: 46093
			[Token(Token = "0x400B40D")]
			[FieldOffset(Offset = "0x20")]
			private BuildingStationManageRoomQueueView m_closure;

			// Token: 0x0400B40E RID: 46094
			[Token(Token = "0x400B40E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B40F RID: 46095
			[Token(Token = "0x400B40F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B410 RID: 46096
			[Token(Token = "0x400B410")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
