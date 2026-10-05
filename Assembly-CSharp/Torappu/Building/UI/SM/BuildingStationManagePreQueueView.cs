using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CCC RID: 7372
	[Token(Token = "0x2001CCC")]
	public class BuildingStationManagePreQueueView : BuildingStationManageQueueBaseView, IHotfixable
	{
		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x0600B68A RID: 46730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015E5")]
		protected override BuildingStationManageQueueBaseView.CharAdapter charAdapter
		{
			[Token(Token = "0x600B68A")]
			[Address(RVA = "0x3346F40", Offset = "0x3345B40", VA = "0x183346F40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B68B RID: 46731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68B")]
		[Address(RVA = "0x3346A40", Offset = "0x3345640", VA = "0x183346A40", Slot = "5")]
		protected override void InitAdapter()
		{
		}

		// Token: 0x0600B68C RID: 46732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68C")]
		[Address(RVA = "0x3346DB0", Offset = "0x33459B0", VA = "0x183346DB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68D")]
		[Address(RVA = "0x3346B70", Offset = "0x3345770", VA = "0x183346B70")]
		public void Render(StationManageEditRoomQueueStructModel queueStructModel, int preQueueIndex)
		{
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68E")]
		[Address(RVA = "0x3346EA0", Offset = "0x3345AA0", VA = "0x183346EA0")]
		public BuildingStationManagePreQueueView()
		{
		}

		// Token: 0x0400B3DF RID: 46047
		[Token(Token = "0x400B3DF")]
		[FieldOffset(Offset = "0x40")]
		private BuildingStationManagePreQueueView.CharAdapterForPreQueue m_charAdapter;

		// Token: 0x0400B3E0 RID: 46048
		[Token(Token = "0x400B3E0")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0400B3E1 RID: 46049
		[Token(Token = "0x400B3E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charAdapter;

		// Token: 0x0400B3E2 RID: 46050
		[Token(Token = "0x400B3E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAdapter;

		// Token: 0x0400B3E3 RID: 46051
		[Token(Token = "0x400B3E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B3E4 RID: 46052
		[Token(Token = "0x400B3E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B3E5 RID: 46053
		[Token(Token = "0x400B3E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CCD RID: 7373
		[Token(Token = "0x2001CCD")]
		private class CharAdapterForPreQueue : BuildingStationManageQueueBaseView.CharAdapter
		{
			// Token: 0x0600B68F RID: 46735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B68F")]
			[Address(RVA = "0x334BBF0", Offset = "0x334A7F0", VA = "0x18334BBF0")]
			public CharAdapterForPreQueue(BuildingStationManagePreQueueView closure)
			{
			}

			// Token: 0x170015E6 RID: 5606
			// (get) Token: 0x0600B690 RID: 46736 RVA: 0x00044F28 File Offset: 0x00043128
			[Token(Token = "0x170015E6")]
			public override int count
			{
				[Token(Token = "0x600B690")]
				[Address(RVA = "0x334BCB0", Offset = "0x334A8B0", VA = "0x18334BCB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B691 RID: 46737 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B691")]
			[Address(RVA = "0x334B800", Offset = "0x334A400", VA = "0x18334B800", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B3E6 RID: 46054
			[Token(Token = "0x400B3E6")]
			[FieldOffset(Offset = "0x20")]
			private BuildingStationManagePreQueueView m_closure;

			// Token: 0x0400B3E7 RID: 46055
			[Token(Token = "0x400B3E7")]
			[FieldOffset(Offset = "0x28")]
			public int preQueueIndex;

			// Token: 0x0400B3E8 RID: 46056
			[Token(Token = "0x400B3E8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B3E9 RID: 46057
			[Token(Token = "0x400B3E9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B3EA RID: 46058
			[Token(Token = "0x400B3EA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
