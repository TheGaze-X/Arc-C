using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006335 RID: 25397
	[Token(Token = "0x2006335")]
	public class AutoChessShopMenuLevelItemViewModel : IHotfixable
	{
		// Token: 0x17005666 RID: 22118
		// (get) Token: 0x06024A02 RID: 150018 RVA: 0x000C4F38 File Offset: 0x000C3138
		// (set) Token: 0x06024A03 RID: 150019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005666")]
		public int shopLevel
		{
			[Token(Token = "0x6024A02")]
			[Address(RVA = "0x1F77B80", Offset = "0x1F76780", VA = "0x181F77B80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A03")]
			[Address(RVA = "0x1F77DF0", Offset = "0x1F769F0", VA = "0x181F77DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005667 RID: 22119
		// (get) Token: 0x06024A04 RID: 150020 RVA: 0x000C4F50 File Offset: 0x000C3150
		// (set) Token: 0x06024A05 RID: 150021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005667")]
		public bool showDiyCharInfo
		{
			[Token(Token = "0x6024A04")]
			[Address(RVA = "0x1F77C40", Offset = "0x1F76840", VA = "0x181F77C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024A05")]
			[Address(RVA = "0x1F77ED0", Offset = "0x1F76AD0", VA = "0x181F77ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005668 RID: 22120
		// (get) Token: 0x06024A06 RID: 150022 RVA: 0x000C4F68 File Offset: 0x000C3168
		// (set) Token: 0x06024A07 RID: 150023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005668")]
		public int levelCurDiyCharCnt
		{
			[Token(Token = "0x6024A06")]
			[Address(RVA = "0x1F77B20", Offset = "0x1F76720", VA = "0x181F77B20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A07")]
			[Address(RVA = "0x1F77D80", Offset = "0x1F76980", VA = "0x181F77D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005669 RID: 22121
		// (get) Token: 0x06024A08 RID: 150024 RVA: 0x000C4F80 File Offset: 0x000C3180
		// (set) Token: 0x06024A09 RID: 150025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005669")]
		public AutoChessShopStatus shopStatus
		{
			[Token(Token = "0x6024A08")]
			[Address(RVA = "0x1F77BE0", Offset = "0x1F767E0", VA = "0x181F77BE0")]
			[CompilerGenerated]
			get
			{
				return AutoChessShopStatus.NONE;
			}
			[Token(Token = "0x6024A09")]
			[Address(RVA = "0x1F77E60", Offset = "0x1F76A60", VA = "0x181F77E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700566A RID: 22122
		// (get) Token: 0x06024A0A RID: 150026 RVA: 0x000C4F98 File Offset: 0x000C3198
		// (set) Token: 0x06024A0B RID: 150027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700566A")]
		public bool isSelected
		{
			[Token(Token = "0x6024A0A")]
			[Address(RVA = "0x1F77AC0", Offset = "0x1F766C0", VA = "0x181F77AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024A0B")]
			[Address(RVA = "0x1F77D10", Offset = "0x1F76910", VA = "0x181F77D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700566B RID: 22123
		// (get) Token: 0x06024A0C RID: 150028 RVA: 0x000C4FB0 File Offset: 0x000C31B0
		// (set) Token: 0x06024A0D RID: 150029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700566B")]
		public int index
		{
			[Token(Token = "0x6024A0C")]
			[Address(RVA = "0x1F77A60", Offset = "0x1F76660", VA = "0x181F77A60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024A0D")]
			[Address(RVA = "0x1F77CA0", Offset = "0x1F768A0", VA = "0x181F77CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06024A0E RID: 150030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A0E")]
		[Address(RVA = "0x1F77530", Offset = "0x1F76130", VA = "0x181F77530")]
		public void LoadData(string activityId, ActAutoChessData.ActAutoChessShopLevelDisplayData shopLevelData, ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> charChessDataListDict, AutoChessShopStatus status, int viewIndex)
		{
		}

		// Token: 0x06024A0F RID: 150031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A0F")]
		[Address(RVA = "0x1F77830", Offset = "0x1F76430", VA = "0x181F77830")]
		public void RefreshShopStatus(AutoChessShopStatus status)
		{
		}

		// Token: 0x06024A10 RID: 150032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A10")]
		[Address(RVA = "0x1F776F0", Offset = "0x1F762F0", VA = "0x181F776F0")]
		public void RefreshLevelCurDiyCharCnt(int curDiyCnt)
		{
		}

		// Token: 0x06024A11 RID: 150033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A11")]
		[Address(RVA = "0x1F77790", Offset = "0x1F76390", VA = "0x181F77790")]
		public void RefreshSelectState(bool isSelect)
		{
		}

		// Token: 0x06024A12 RID: 150034 RVA: 0x000C4FC8 File Offset: 0x000C31C8
		[Token(Token = "0x6024A12")]
		[Address(RVA = "0x1F77460", Offset = "0x1F76060", VA = "0x181F77460")]
		public bool IsMenuItemHasLevelInfo()
		{
			return default(bool);
		}

		// Token: 0x06024A13 RID: 150035 RVA: 0x000C4FE0 File Offset: 0x000C31E0
		[Token(Token = "0x6024A13")]
		[Address(RVA = "0x1F77320", Offset = "0x1F75F20", VA = "0x181F77320")]
		public bool CheckChessPoolChessShopLevelCharsHasNew()
		{
			return default(bool);
		}

		// Token: 0x06024A14 RID: 150036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A14")]
		[Address(RVA = "0x1F77A00", Offset = "0x1F76600", VA = "0x181F77A00")]
		public AutoChessShopMenuLevelItemViewModel()
		{
		}

		// Token: 0x040331A9 RID: 209321
		[Token(Token = "0x40331A9")]
		[FieldOffset(Offset = "0x28")]
		private string m_actId;

		// Token: 0x040331AA RID: 209322
		[Token(Token = "0x40331AA")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isLevelCharChessEmpty;

		// Token: 0x040331AB RID: 209323
		[Token(Token = "0x40331AB")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isLevelTrapChessEmpty;

		// Token: 0x040331AC RID: 209324
		[Token(Token = "0x40331AC")]
		[FieldOffset(Offset = "0x34")]
		private int m_levelCanDiyCharCnt;

		// Token: 0x040331AD RID: 209325
		[Token(Token = "0x40331AD")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> m_charChessDataListDict;

		// Token: 0x040331AE RID: 209326
		[Token(Token = "0x40331AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shopLevel;

		// Token: 0x040331AF RID: 209327
		[Token(Token = "0x40331AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_shopLevel;

		// Token: 0x040331B0 RID: 209328
		[Token(Token = "0x40331B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showDiyCharInfo;

		// Token: 0x040331B1 RID: 209329
		[Token(Token = "0x40331B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_showDiyCharInfo;

		// Token: 0x040331B2 RID: 209330
		[Token(Token = "0x40331B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_levelCurDiyCharCnt;

		// Token: 0x040331B3 RID: 209331
		[Token(Token = "0x40331B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_levelCurDiyCharCnt;

		// Token: 0x040331B4 RID: 209332
		[Token(Token = "0x40331B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_shopStatus;

		// Token: 0x040331B5 RID: 209333
		[Token(Token = "0x40331B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_shopStatus;

		// Token: 0x040331B6 RID: 209334
		[Token(Token = "0x40331B6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isSelected;

		// Token: 0x040331B7 RID: 209335
		[Token(Token = "0x40331B7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isSelected;

		// Token: 0x040331B8 RID: 209336
		[Token(Token = "0x40331B8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x040331B9 RID: 209337
		[Token(Token = "0x40331B9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x040331BA RID: 209338
		[Token(Token = "0x40331BA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040331BB RID: 209339
		[Token(Token = "0x40331BB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshShopStatus;

		// Token: 0x040331BC RID: 209340
		[Token(Token = "0x40331BC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RefreshLevelCurDiyCharCnt;

		// Token: 0x040331BD RID: 209341
		[Token(Token = "0x40331BD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RefreshSelectState;

		// Token: 0x040331BE RID: 209342
		[Token(Token = "0x40331BE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsMenuItemHasLevelInfo;

		// Token: 0x040331BF RID: 209343
		[Token(Token = "0x40331BF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckChessPoolChessShopLevelCharsHasNew;

		// Token: 0x040331C0 RID: 209344
		[Token(Token = "0x40331C0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
