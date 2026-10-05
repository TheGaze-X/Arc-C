using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.GameCity
{
	// Token: 0x0200342E RID: 13358
	[Token(Token = "0x200342E")]
	public class GameCityScoreUIPlugin : UnitHudPluginManager.HudPlugin
	{
		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x06015642 RID: 87618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003296")]
		private GameModeFactory.GameCityGameMode gameMode
		{
			[Token(Token = "0x6015642")]
			[Address(RVA = "0xDCE430", Offset = "0xDCD030", VA = "0x180DCE430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015643 RID: 87619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015643")]
		[Address(RVA = "0xDCDF70", Offset = "0xDCCB70", VA = "0x180DCDF70", Slot = "9")]
		protected override void DoAttach(Unit owner)
		{
		}

		// Token: 0x06015644 RID: 87620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015644")]
		[Address(RVA = "0xDCE000", Offset = "0xDCCC00", VA = "0x180DCE000")]
		private void Start()
		{
		}

		// Token: 0x06015645 RID: 87621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015645")]
		[Address(RVA = "0xDCE070", Offset = "0xDCCC70", VA = "0x180DCE070")]
		private void Update()
		{
		}

		// Token: 0x06015646 RID: 87622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015646")]
		[Address(RVA = "0xDCE3A0", Offset = "0xDCCFA0", VA = "0x180DCE3A0")]
		public GameCityScoreUIPlugin()
		{
		}

		// Token: 0x06015647 RID: 87623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015647")]
		[Address(RVA = "0xCCDF70", Offset = "0xCCCB70", VA = "0x180CCDF70")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0)
		{
		}

		// Token: 0x04019982 RID: 104834
		[Token(Token = "0x4019982")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameCityBattleScoreUIPanel _scorePanel;

		// Token: 0x04019983 RID: 104835
		[Token(Token = "0x4019983")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x04019984 RID: 104836
		[Token(Token = "0x4019984")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Buff> m_buff;

		// Token: 0x04019985 RID: 104837
		[Token(Token = "0x4019985")]
		[FieldOffset(Offset = "0x48")]
		private Unit m_owner;

		// Token: 0x04019986 RID: 104838
		[Token(Token = "0x4019986")]
		[FieldOffset(Offset = "0x50")]
		private GameModeFactory.GameCityGameMode m_gameMode;

		// Token: 0x04019987 RID: 104839
		[Token(Token = "0x4019987")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x04019988 RID: 104840
		[Token(Token = "0x4019988")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04019989 RID: 104841
		[Token(Token = "0x4019989")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401998A RID: 104842
		[Token(Token = "0x401998A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401998B RID: 104843
		[Token(Token = "0x401998B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
