using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006333 RID: 25395
	[Token(Token = "0x2006333")]
	public class AutoChessShopCharChessDiyCardViewModel : IHotfixable
	{
		// Token: 0x17005658 RID: 22104
		// (get) Token: 0x060249D9 RID: 149977 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249DA RID: 149978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005658")]
		public string firstDiyChessId
		{
			[Token(Token = "0x60249D9")]
			[Address(RVA = "0x1F6C060", Offset = "0x1F6AC60", VA = "0x181F6C060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249DA")]
			[Address(RVA = "0x1F6C270", Offset = "0x1F6AE70", VA = "0x181F6C270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005659 RID: 22105
		// (get) Token: 0x060249DB RID: 149979 RVA: 0x000C4E30 File Offset: 0x000C3030
		// (set) Token: 0x060249DC RID: 149980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005659")]
		public int chessShopLv
		{
			[Token(Token = "0x60249DB")]
			[Address(RVA = "0x1F6BFA0", Offset = "0x1F6ABA0", VA = "0x181F6BFA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60249DC")]
			[Address(RVA = "0x1F6C190", Offset = "0x1F6AD90", VA = "0x181F6C190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700565A RID: 22106
		// (get) Token: 0x060249DD RID: 149981 RVA: 0x000C4E48 File Offset: 0x000C3048
		// (set) Token: 0x060249DE RID: 149982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700565A")]
		public int curDiyCount
		{
			[Token(Token = "0x60249DD")]
			[Address(RVA = "0x1F6C000", Offset = "0x1F6AC00", VA = "0x181F6C000")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60249DE")]
			[Address(RVA = "0x1F6C200", Offset = "0x1F6AE00", VA = "0x181F6C200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700565B RID: 22107
		// (get) Token: 0x060249DF RID: 149983 RVA: 0x000C4E60 File Offset: 0x000C3060
		// (set) Token: 0x060249E0 RID: 149984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700565B")]
		public int maxDiyCount
		{
			[Token(Token = "0x60249DF")]
			[Address(RVA = "0x1F6C0C0", Offset = "0x1F6ACC0", VA = "0x181F6C0C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60249E0")]
			[Address(RVA = "0x1F6C2F0", Offset = "0x1F6AEF0", VA = "0x181F6C2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700565C RID: 22108
		// (get) Token: 0x060249E1 RID: 149985 RVA: 0x000C4E78 File Offset: 0x000C3078
		// (set) Token: 0x060249E2 RID: 149986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700565C")]
		public bool canShow
		{
			[Token(Token = "0x60249E1")]
			[Address(RVA = "0x1F6BF40", Offset = "0x1F6AB40", VA = "0x181F6BF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60249E2")]
			[Address(RVA = "0x1F6C120", Offset = "0x1F6AD20", VA = "0x181F6C120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060249E3 RID: 149987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249E3")]
		[Address(RVA = "0x1F6BBA0", Offset = "0x1F6A7A0", VA = "0x181F6BBA0")]
		public void LoadData(string baseChessId, int shopLv, int maxDiyCnt)
		{
		}

		// Token: 0x060249E4 RID: 149988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249E4")]
		[Address(RVA = "0x1F6BD50", Offset = "0x1F6A950", VA = "0x181F6BD50")]
		public void RefreshInfos(int curDiyCnt, AutoChessShopStatus shopStatus)
		{
		}

		// Token: 0x060249E5 RID: 149989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249E5")]
		[Address(RVA = "0x1F6BEE0", Offset = "0x1F6AAE0", VA = "0x181F6BEE0")]
		public AutoChessShopCharChessDiyCardViewModel()
		{
		}

		// Token: 0x0403316F RID: 209263
		[Token(Token = "0x403316F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_firstDiyChessId;

		// Token: 0x04033170 RID: 209264
		[Token(Token = "0x4033170")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_firstDiyChessId;

		// Token: 0x04033171 RID: 209265
		[Token(Token = "0x4033171")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_chessShopLv;

		// Token: 0x04033172 RID: 209266
		[Token(Token = "0x4033172")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_chessShopLv;

		// Token: 0x04033173 RID: 209267
		[Token(Token = "0x4033173")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curDiyCount;

		// Token: 0x04033174 RID: 209268
		[Token(Token = "0x4033174")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_curDiyCount;

		// Token: 0x04033175 RID: 209269
		[Token(Token = "0x4033175")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_maxDiyCount;

		// Token: 0x04033176 RID: 209270
		[Token(Token = "0x4033176")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_maxDiyCount;

		// Token: 0x04033177 RID: 209271
		[Token(Token = "0x4033177")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_canShow;

		// Token: 0x04033178 RID: 209272
		[Token(Token = "0x4033178")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_canShow;

		// Token: 0x04033179 RID: 209273
		[Token(Token = "0x4033179")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403317A RID: 209274
		[Token(Token = "0x403317A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RefreshInfos;

		// Token: 0x0403317B RID: 209275
		[Token(Token = "0x403317B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
