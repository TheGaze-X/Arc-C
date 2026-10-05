using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006328 RID: 25384
	[Token(Token = "0x2006328")]
	public class AutoChessShopQuickAssistViewModel : IHotfixable
	{
		// Token: 0x17005641 RID: 22081
		// (get) Token: 0x060249A3 RID: 149923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249A4 RID: 149924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005641")]
		public string activityId
		{
			[Token(Token = "0x60249A3")]
			[Address(RVA = "0x1F7CA00", Offset = "0x1F7B600", VA = "0x181F7CA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249A4")]
			[Address(RVA = "0x1F7CC40", Offset = "0x1F7B840", VA = "0x181F7CC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005642 RID: 22082
		// (get) Token: 0x060249A5 RID: 149925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005642")]
		public List<IAutoChessShopQuickAssistListItemViewModel> assistItemsViewList
		{
			[Token(Token = "0x60249A5")]
			[Address(RVA = "0x1F7CA60", Offset = "0x1F7B660", VA = "0x181F7CA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005643 RID: 22083
		// (get) Token: 0x060249A6 RID: 149926 RVA: 0x000C4C98 File Offset: 0x000C2E98
		[Token(Token = "0x17005643")]
		public int enterSequenceNum
		{
			[Token(Token = "0x60249A6")]
			[Address(RVA = "0x1F7CB80", Offset = "0x1F7B780", VA = "0x181F7CB80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005644 RID: 22084
		// (get) Token: 0x060249A7 RID: 149927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005644")]
		public ListDict<string, bool> cachedChessAssistInfoListDict
		{
			[Token(Token = "0x60249A7")]
			[Address(RVA = "0x1F7CAC0", Offset = "0x1F7B6C0", VA = "0x181F7CAC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005645 RID: 22085
		// (get) Token: 0x060249A8 RID: 149928 RVA: 0x000C4CB0 File Offset: 0x000C2EB0
		// (set) Token: 0x060249A9 RID: 149929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005645")]
		public int curAssistCnt
		{
			[Token(Token = "0x60249A8")]
			[Address(RVA = "0x1F7CB20", Offset = "0x1F7B720", VA = "0x181F7CB20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60249A9")]
			[Address(RVA = "0x1F7CCC0", Offset = "0x1F7B8C0", VA = "0x181F7CCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005646 RID: 22086
		// (get) Token: 0x060249AA RID: 149930 RVA: 0x000C4CC8 File Offset: 0x000C2EC8
		// (set) Token: 0x060249AB RID: 149931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005646")]
		public int maxCanAssistCnt
		{
			[Token(Token = "0x60249AA")]
			[Address(RVA = "0x1F7CBE0", Offset = "0x1F7B7E0", VA = "0x181F7CBE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60249AB")]
			[Address(RVA = "0x1F7CD30", Offset = "0x1F7B930", VA = "0x181F7CD30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060249AC RID: 149932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249AC")]
		[Address(RVA = "0x1F7B360", Offset = "0x1F79F60", VA = "0x181F7B360")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060249AD RID: 149933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249AD")]
		[Address(RVA = "0x1F7B9D0", Offset = "0x1F7A5D0", VA = "0x181F7B9D0")]
		public void RefreshAssistInfoByPlayerData(string chessId)
		{
		}

		// Token: 0x060249AE RID: 149934 RVA: 0x000C4CE0 File Offset: 0x000C2EE0
		[Token(Token = "0x60249AE")]
		[Address(RVA = "0x1F7B1C0", Offset = "0x1F79DC0", VA = "0x181F7B1C0")]
		public bool IsChessAssistInfoChanged()
		{
			return default(bool);
		}

		// Token: 0x060249AF RID: 149935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249AF")]
		[Address(RVA = "0x1F7C0C0", Offset = "0x1F7ACC0", VA = "0x181F7C0C0")]
		private void _LoadDisplayLevelItemsData(ActAutoChessData.ActAutoChessShopLevelDisplayData shopLevelData, bool canAssistMore, ListDict<string, bool> showingAssistChessIdDict, ActAutoChessData actData, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPlayerDataPool)
		{
		}

		// Token: 0x060249B0 RID: 149936 RVA: 0x000C4CF8 File Offset: 0x000C2EF8
		[Token(Token = "0x60249B0")]
		[Address(RVA = "0x1F7C4F0", Offset = "0x1F7B0F0", VA = "0x181F7C4F0")]
		private bool _RefreshChessAssistInfoDictByPlayerData(ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> charShopChessDataDict, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPool)
		{
			return default(bool);
		}

		// Token: 0x060249B1 RID: 149937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60249B1")]
		[Address(RVA = "0x1F7BC80", Offset = "0x1F7A880", VA = "0x181F7BC80")]
		private AutoChessShopCharChessCardViewModel _CreateCharChessCardViewModel(string actId, string chessId, ListDict<string, bool> showingAssistChessIdDict, ActAutoChessData actData, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPlayerDataPool)
		{
			return null;
		}

		// Token: 0x060249B2 RID: 149938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249B2")]
		[Address(RVA = "0x1F7C8C0", Offset = "0x1F7B4C0", VA = "0x181F7C8C0")]
		public AutoChessShopQuickAssistViewModel()
		{
		}

		// Token: 0x04033119 RID: 209177
		[Token(Token = "0x4033119")]
		[FieldOffset(Offset = "0x20")]
		private List<IAutoChessShopQuickAssistListItemViewModel> m_assistItemsViewList;

		// Token: 0x0403311A RID: 209178
		[Token(Token = "0x403311A")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, bool> m_cachedChessAssistInfoListDict;

		// Token: 0x0403311B RID: 209179
		[Token(Token = "0x403311B")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, bool> m_cachedChessAssistInfoInitListDict;

		// Token: 0x0403311C RID: 209180
		[Token(Token = "0x403311C")]
		[FieldOffset(Offset = "0x38")]
		private ActAutoChessData m_cachedActData;

		// Token: 0x0403311D RID: 209181
		[Token(Token = "0x403311D")]
		[FieldOffset(Offset = "0x40")]
		private int m_enterSequenceNum;

		// Token: 0x0403311E RID: 209182
		[Token(Token = "0x403311E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403311F RID: 209183
		[Token(Token = "0x403311F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x04033120 RID: 209184
		[Token(Token = "0x4033120")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_assistItemsViewList;

		// Token: 0x04033121 RID: 209185
		[Token(Token = "0x4033121")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enterSequenceNum;

		// Token: 0x04033122 RID: 209186
		[Token(Token = "0x4033122")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cachedChessAssistInfoListDict;

		// Token: 0x04033123 RID: 209187
		[Token(Token = "0x4033123")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_curAssistCnt;

		// Token: 0x04033124 RID: 209188
		[Token(Token = "0x4033124")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_curAssistCnt;

		// Token: 0x04033125 RID: 209189
		[Token(Token = "0x4033125")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_maxCanAssistCnt;

		// Token: 0x04033126 RID: 209190
		[Token(Token = "0x4033126")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_maxCanAssistCnt;

		// Token: 0x04033127 RID: 209191
		[Token(Token = "0x4033127")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033128 RID: 209192
		[Token(Token = "0x4033128")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshAssistInfoByPlayerData;

		// Token: 0x04033129 RID: 209193
		[Token(Token = "0x4033129")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsChessAssistInfoChanged;

		// Token: 0x0403312A RID: 209194
		[Token(Token = "0x403312A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadDisplayLevelItemsData;

		// Token: 0x0403312B RID: 209195
		[Token(Token = "0x403312B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RefreshChessAssistInfoDictByPlayerData;

		// Token: 0x0403312C RID: 209196
		[Token(Token = "0x403312C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateCharChessCardViewModel;

		// Token: 0x0403312D RID: 209197
		[Token(Token = "0x403312D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006329 RID: 25385
		[Token(Token = "0x2006329")]
		private struct CharInfoInputParams
		{
			// Token: 0x0403312E RID: 209198
			[Token(Token = "0x403312E")]
			[FieldOffset(Offset = "0x0")]
			public string chessId;

			// Token: 0x0403312F RID: 209199
			[Token(Token = "0x403312F")]
			[FieldOffset(Offset = "0x8")]
			public ActAutoChessData.ActAutoChessCharShopChessData chessData;

			// Token: 0x04033130 RID: 209200
			[Token(Token = "0x4033130")]
			[FieldOffset(Offset = "0x10")]
			public ActAutoChessData.ActAutoChessCharChessStatusData chessStatusData;

			// Token: 0x04033131 RID: 209201
			[Token(Token = "0x4033131")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessPlayerDataPool;
		}

		// Token: 0x0200632A RID: 25386
		[Token(Token = "0x200632A")]
		private struct CharInfo : AutoChessShopCharChessCardViewModel.ICharInfo
		{
			// Token: 0x060249B3 RID: 149939 RVA: 0x000C4D10 File Offset: 0x000C2F10
			[Token(Token = "0x60249B3")]
			[Address(RVA = "0x1F7D7E0", Offset = "0x1F7C3E0", VA = "0x181F7D7E0", Slot = "4")]
			public bool LoadCharInfo()
			{
				return default(bool);
			}

			// Token: 0x17005647 RID: 22087
			// (get) Token: 0x060249B4 RID: 149940 RVA: 0x000C4D28 File Offset: 0x000C2F28
			[Token(Token = "0x17005647")]
			public PlayerActivity.PlayerActAutoChessActivity.AutoChessCharType chessType
			{
				[Token(Token = "0x60249B4")]
				[Address(RVA = "0x1F7D900", Offset = "0x1F7C500", VA = "0x181F7D900", Slot = "6")]
				get
				{
					return PlayerActivity.PlayerActAutoChessActivity.AutoChessCharType.OWN;
				}
			}

			// Token: 0x17005648 RID: 22088
			// (get) Token: 0x060249B5 RID: 149941 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005648")]
			public ActAutoChessData.ActAutoChessCharShopChessData originChessShopData
			{
				[Token(Token = "0x60249B5")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005649 RID: 22089
			// (get) Token: 0x060249B6 RID: 149942 RVA: 0x000C4D40 File Offset: 0x000C2F40
			[Token(Token = "0x17005649")]
			public CharQuery charQuery
			{
				[Token(Token = "0x60249B6")]
				[Address(RVA = "0x1F7D890", Offset = "0x1F7C490", VA = "0x181F7D890", Slot = "7")]
				get
				{
					return default(CharQuery);
				}
			}

			// Token: 0x1700564A RID: 22090
			// (get) Token: 0x060249B7 RID: 149943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700564A")]
			public string skinId
			{
				[Token(Token = "0x60249B7")]
				[Address(RVA = "0x1F7DA10", Offset = "0x1F7C610", VA = "0x181F7DA10", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700564B RID: 22091
			// (get) Token: 0x060249B8 RID: 149944 RVA: 0x000C4D58 File Offset: 0x000C2F58
			[Token(Token = "0x1700564B")]
			public int skillIndex
			{
				[Token(Token = "0x60249B8")]
				[Address(RVA = "0x1F7D9D0", Offset = "0x1F7C5D0", VA = "0x181F7D9D0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700564C RID: 22092
			// (get) Token: 0x060249B9 RID: 149945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700564C")]
			public string skillId
			{
				[Token(Token = "0x60249B9")]
				[Address(RVA = "0x1F7D990", Offset = "0x1F7C590", VA = "0x181F7D990", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700564D RID: 22093
			// (get) Token: 0x060249BA RID: 149946 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700564D")]
			public string currentEquip
			{
				[Token(Token = "0x60249BA")]
				[Address(RVA = "0x1F7D920", Offset = "0x1F7C520", VA = "0x181F7D920", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700564E RID: 22094
			// (get) Token: 0x060249BB RID: 149947 RVA: 0x000C4D70 File Offset: 0x000C2F70
			[Token(Token = "0x1700564E")]
			public int potentialRank
			{
				[Token(Token = "0x60249BB")]
				[Address(RVA = "0x1F7D960", Offset = "0x1F7C560", VA = "0x181F7D960", Slot = "12")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04033132 RID: 209202
			[Token(Token = "0x4033132")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessShopQuickAssistViewModel.CharInfoInputParams inputParams;

			// Token: 0x04033133 RID: 209203
			[Token(Token = "0x4033133")]
			[FieldOffset(Offset = "0x20")]
			private PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot m_chessPlayerData;
		}
	}
}
