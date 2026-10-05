using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061F8 RID: 25080
	[Token(Token = "0x20061F8")]
	public class BattleFinishHomeStateBean : SingletonMonoBehaviour<BattleFinishHomeStateBean>, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x1700555F RID: 21855
		// (get) Token: 0x0602431E RID: 148254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700555F")]
		public CommonBattleFinishModel battleFinishModel
		{
			[Token(Token = "0x602431E")]
			[Address(RVA = "0x1ED1DF0", Offset = "0x1ED09F0", VA = "0x181ED1DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005560 RID: 21856
		// (get) Token: 0x0602431F RID: 148255 RVA: 0x000C3648 File Offset: 0x000C1848
		[Token(Token = "0x17005560")]
		public bool isInited
		{
			[Token(Token = "0x602431F")]
			[Address(RVA = "0x1ED1E50", Offset = "0x1ED0A50", VA = "0x181ED1E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06024320 RID: 148256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024320")]
		[Address(RVA = "0x1ED1C70", Offset = "0x1ED0870", VA = "0x181ED1C70")]
		public void LoadData(CommonFinishBattleResponse response)
		{
		}

		// Token: 0x06024321 RID: 148257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024321")]
		[Address(RVA = "0x1ED1C00", Offset = "0x1ED0800", VA = "0x181ED1C00")]
		public List<KeyValuePair<PlayerCharacter, GachaResult>> FindCharsInDropItems()
		{
			return null;
		}

		// Token: 0x06024322 RID: 148258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024322")]
		[Address(RVA = "0x1ED1CF0", Offset = "0x1ED08F0", VA = "0x181ED1CF0")]
		public BattleFinishHomeStateBean()
		{
		}

		// Token: 0x040324FC RID: 206076
		[Token(Token = "0x40324FC")]
		[FieldOffset(Offset = "0x18")]
		private CommonBattleFinishModel m_battleFinishModel;

		// Token: 0x040324FD RID: 206077
		[Token(Token = "0x40324FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_battleFinishModel;

		// Token: 0x040324FE RID: 206078
		[Token(Token = "0x40324FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isInited;

		// Token: 0x040324FF RID: 206079
		[Token(Token = "0x40324FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032500 RID: 206080
		[Token(Token = "0x4032500")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FindCharsInDropItems;

		// Token: 0x04032501 RID: 206081
		[Token(Token = "0x4032501")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
