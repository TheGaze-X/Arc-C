using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005050 RID: 20560
	[Token(Token = "0x2005050")]
	public class EnemyDuelPrepareSelectModeViewModel : IHotfixable
	{
		// Token: 0x0601E7B1 RID: 124849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7B1")]
		[Address(RVA = "0x182E460", Offset = "0x182D060", VA = "0x18182E460")]
		public void LoadData(string actId, bool isRoom, string selectModeId)
		{
		}

		// Token: 0x0601E7B2 RID: 124850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7B2")]
		[Address(RVA = "0x182E640", Offset = "0x182D240", VA = "0x18182E640")]
		public void SelectMode(int idx)
		{
		}

		// Token: 0x0601E7B3 RID: 124851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7B3")]
		[Address(RVA = "0x182E710", Offset = "0x182D310", VA = "0x18182E710")]
		public EnemyDuelPrepareSelectModeViewModel()
		{
		}

		// Token: 0x04028D38 RID: 167224
		[Token(Token = "0x4028D38")]
		[FieldOffset(Offset = "0x10")]
		public int seqNum;

		// Token: 0x04028D39 RID: 167225
		[Token(Token = "0x4028D39")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x04028D3A RID: 167226
		[Token(Token = "0x4028D3A")]
		[FieldOffset(Offset = "0x20")]
		public bool isRoom;

		// Token: 0x04028D3B RID: 167227
		[Token(Token = "0x4028D3B")]
		[FieldOffset(Offset = "0x28")]
		public ActivityEnemyDuelData actData;

		// Token: 0x04028D3C RID: 167228
		[Token(Token = "0x4028D3C")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerEnemyDuelActivity playerActData;

		// Token: 0x04028D3D RID: 167229
		[Token(Token = "0x4028D3D")]
		[FieldOffset(Offset = "0x38")]
		public float picRotateTime;

		// Token: 0x04028D3E RID: 167230
		[Token(Token = "0x4028D3E")]
		[FieldOffset(Offset = "0x40")]
		public string defaultPicId;

		// Token: 0x04028D3F RID: 167231
		[Token(Token = "0x4028D3F")]
		[FieldOffset(Offset = "0x48")]
		public EnemyDuelPrepareSelectModeSelectionViewModel selectionViewModel;

		// Token: 0x04028D40 RID: 167232
		[Token(Token = "0x4028D40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028D41 RID: 167233
		[Token(Token = "0x4028D41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectMode;

		// Token: 0x04028D42 RID: 167234
		[Token(Token = "0x4028D42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
