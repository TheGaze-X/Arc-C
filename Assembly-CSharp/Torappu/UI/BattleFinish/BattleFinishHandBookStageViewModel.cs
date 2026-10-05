using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061F6 RID: 25078
	[Token(Token = "0x20061F6")]
	public class BattleFinishHandBookStageViewModel : IHotfixable
	{
		// Token: 0x1700555A RID: 21850
		// (get) Token: 0x06024312 RID: 148242 RVA: 0x000C3618 File Offset: 0x000C1818
		[Token(Token = "0x1700555A")]
		public PlayerBattleRank rank
		{
			[Token(Token = "0x6024312")]
			[Address(RVA = "0x1ED1B20", Offset = "0x1ED0720", VA = "0x181ED1B20")]
			get
			{
				return (PlayerBattleRank)0;
			}
		}

		// Token: 0x1700555B RID: 21851
		// (get) Token: 0x06024313 RID: 148243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700555B")]
		public string stageName
		{
			[Token(Token = "0x6024313")]
			[Address(RVA = "0x1ED1B90", Offset = "0x1ED0790", VA = "0x181ED1B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700555C RID: 21852
		// (get) Token: 0x06024314 RID: 148244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700555C")]
		public BattleInfoViewModel infoModel
		{
			[Token(Token = "0x6024314")]
			[Address(RVA = "0x1ED1AC0", Offset = "0x1ED06C0", VA = "0x181ED1AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700555D RID: 21853
		// (get) Token: 0x06024315 RID: 148245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700555D")]
		public HandBookDropInfoViewModel droupInfoGroupModel
		{
			[Token(Token = "0x6024315")]
			[Address(RVA = "0x1ED1A60", Offset = "0x1ED0660", VA = "0x181ED1A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024316 RID: 148246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024316")]
		[Address(RVA = "0x1ED1530", Offset = "0x1ED0130", VA = "0x181ED1530")]
		public void LoadData()
		{
		}

		// Token: 0x06024317 RID: 148247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024317")]
		[Address(RVA = "0x1ED1590", Offset = "0x1ED0190", VA = "0x181ED1590")]
		private void _LoadBattleInfoModel()
		{
		}

		// Token: 0x06024318 RID: 148248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024318")]
		[Address(RVA = "0x1ED1A00", Offset = "0x1ED0600", VA = "0x181ED1A00")]
		public BattleFinishHandBookStageViewModel()
		{
		}

		// Token: 0x040324E9 RID: 206057
		[Token(Token = "0x40324E9")]
		[FieldOffset(Offset = "0x10")]
		private BattleInfoViewModel m_infoViewModel;

		// Token: 0x040324EA RID: 206058
		[Token(Token = "0x40324EA")]
		[FieldOffset(Offset = "0x18")]
		private HandBookDropInfoViewModel m_droupInfoGroupModel;

		// Token: 0x040324EB RID: 206059
		[Token(Token = "0x40324EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rank;

		// Token: 0x040324EC RID: 206060
		[Token(Token = "0x40324EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stageName;

		// Token: 0x040324ED RID: 206061
		[Token(Token = "0x40324ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_infoModel;

		// Token: 0x040324EE RID: 206062
		[Token(Token = "0x40324EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_droupInfoGroupModel;

		// Token: 0x040324EF RID: 206063
		[Token(Token = "0x40324EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040324F0 RID: 206064
		[Token(Token = "0x40324F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadBattleInfoModel;

		// Token: 0x040324F1 RID: 206065
		[Token(Token = "0x40324F1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
