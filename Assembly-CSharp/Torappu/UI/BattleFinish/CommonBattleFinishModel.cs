using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061F7 RID: 25079
	[Token(Token = "0x20061F7")]
	public class CommonBattleFinishModel : IHotfixable
	{
		// Token: 0x1700555E RID: 21854
		// (get) Token: 0x06024319 RID: 148249 RVA: 0x000C3630 File Offset: 0x000C1830
		// (set) Token: 0x0602431A RID: 148250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700555E")]
		public bool isInited
		{
			[Token(Token = "0x6024319")]
			[Address(RVA = "0x1EE3DC0", Offset = "0x1EE29C0", VA = "0x181EE3DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602431A")]
			[Address(RVA = "0x1EE3E20", Offset = "0x1EE2A20", VA = "0x181EE3E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602431B RID: 148251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602431B")]
		[Address(RVA = "0x1EE3120", Offset = "0x1EE1D20", VA = "0x181EE3120")]
		public void LoadData(CommonFinishBattleResponse response)
		{
		}

		// Token: 0x0602431C RID: 148252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602431C")]
		[Address(RVA = "0x1EE2E50", Offset = "0x1EE1A50", VA = "0x181EE2E50")]
		public List<KeyValuePair<PlayerCharacter, GachaResult>> FindCharsInDropItems()
		{
			return null;
		}

		// Token: 0x0602431D RID: 148253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602431D")]
		[Address(RVA = "0x1EE3D60", Offset = "0x1EE2960", VA = "0x181EE3D60")]
		public CommonBattleFinishModel()
		{
		}

		// Token: 0x040324F2 RID: 206066
		[Token(Token = "0x40324F2")]
		[FieldOffset(Offset = "0x10")]
		public BattleInfoViewModel battleInfoModel;

		// Token: 0x040324F3 RID: 206067
		[Token(Token = "0x40324F3")]
		[FieldOffset(Offset = "0x18")]
		public DropInfoGroupViewModel dropInfoModel;

		// Token: 0x040324F4 RID: 206068
		[Token(Token = "0x40324F4")]
		[FieldOffset(Offset = "0x20")]
		public List<DropInfoGroupViewModel> pryDropInfoModels;

		// Token: 0x040324F5 RID: 206069
		[Token(Token = "0x40324F5")]
		[FieldOffset(Offset = "0x28")]
		public UIExpBarController.ControlModel expBarControlModel;

		// Token: 0x040324F7 RID: 206071
		[Token(Token = "0x40324F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInited;

		// Token: 0x040324F8 RID: 206072
		[Token(Token = "0x40324F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isInited;

		// Token: 0x040324F9 RID: 206073
		[Token(Token = "0x40324F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040324FA RID: 206074
		[Token(Token = "0x40324FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FindCharsInDropItems;

		// Token: 0x040324FB RID: 206075
		[Token(Token = "0x40324FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
