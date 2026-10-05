using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005039 RID: 20537
	[Token(Token = "0x2005039")]
	public class EnemyDuelPrepareRoomPlayerCardAdapter : LoopScrollAdapter<EnemyDuelPrepareRoomPlayerCardAdapter.ViewHolder, EnemyDuelPrepareRoomPlayerCardViewModel>
	{
		// Token: 0x0601E751 RID: 124753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E751")]
		[Address(RVA = "0x18282A0", Offset = "0x1826EA0", VA = "0x1818282A0")]
		public void SetRoomViewModel(EnemyDuelPrepareRoomViewModel roomViewModel)
		{
		}

		// Token: 0x0601E752 RID: 124754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E752")]
		[Address(RVA = "0x18281E0", Offset = "0x1826DE0", VA = "0x1818281E0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601E753 RID: 124755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E753")]
		[Address(RVA = "0x1828320", Offset = "0x1826F20", VA = "0x181828320", Slot = "13")]
		public override void UpdateView(int position, GameObject view, EnemyDuelPrepareRoomPlayerCardAdapter.ViewHolder holder, EnemyDuelPrepareRoomPlayerCardViewModel data)
		{
		}

		// Token: 0x0601E754 RID: 124756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E754")]
		[Address(RVA = "0x18284D0", Offset = "0x18270D0", VA = "0x1818284D0")]
		public EnemyDuelPrepareRoomPlayerCardAdapter()
		{
		}

		// Token: 0x04028C36 RID: 166966
		[Token(Token = "0x4028C36")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private EnemyDuelPrepareRoomPlayerCardView _viewPrefab;

		// Token: 0x04028C37 RID: 166967
		[Token(Token = "0x4028C37")]
		[FieldOffset(Offset = "0x60")]
		private EnemyDuelPrepareRoomViewModel m_roomViewModel;

		// Token: 0x04028C38 RID: 166968
		[Token(Token = "0x4028C38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRoomViewModel;

		// Token: 0x04028C39 RID: 166969
		[Token(Token = "0x4028C39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04028C3A RID: 166970
		[Token(Token = "0x4028C3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04028C3B RID: 166971
		[Token(Token = "0x4028C3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200503A RID: 20538
		[Token(Token = "0x200503A")]
		public class ViewHolder
		{
			// Token: 0x0601E755 RID: 124757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E755")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04028C3C RID: 166972
			[Token(Token = "0x4028C3C")]
			[FieldOffset(Offset = "0x10")]
			public EnemyDuelPrepareRoomPlayerCardView view;
		}
	}
}
