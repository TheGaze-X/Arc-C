using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006331 RID: 25393
	[Token(Token = "0x2006331")]
	public class AutoChessShopLevelTagViewModel : IHotfixable
	{
		// Token: 0x1700564F RID: 22095
		// (get) Token: 0x060249C1 RID: 149953 RVA: 0x000C4DA0 File Offset: 0x000C2FA0
		// (set) Token: 0x060249C2 RID: 149954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700564F")]
		public int level
		{
			[Token(Token = "0x60249C1")]
			[Address(RVA = "0x1F701A0", Offset = "0x1F6EDA0", VA = "0x181F701A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60249C2")]
			[Address(RVA = "0x1F702E0", Offset = "0x1F6EEE0", VA = "0x181F702E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005650 RID: 22096
		// (get) Token: 0x060249C3 RID: 149955 RVA: 0x000C4DB8 File Offset: 0x000C2FB8
		// (set) Token: 0x060249C4 RID: 149956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005650")]
		public AutoChessShopStatus shopStatus
		{
			[Token(Token = "0x60249C3")]
			[Address(RVA = "0x1F70200", Offset = "0x1F6EE00", VA = "0x181F70200")]
			[CompilerGenerated]
			get
			{
				return AutoChessShopStatus.NONE;
			}
			[Token(Token = "0x60249C4")]
			[Address(RVA = "0x1F70350", Offset = "0x1F6EF50", VA = "0x181F70350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005651 RID: 22097
		// (get) Token: 0x060249C5 RID: 149957 RVA: 0x000C4DD0 File Offset: 0x000C2FD0
		// (set) Token: 0x060249C6 RID: 149958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005651")]
		public Color levelTagBgColor
		{
			[Token(Token = "0x60249C5")]
			[Address(RVA = "0x1F70120", Offset = "0x1F6ED20", VA = "0x181F70120")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60249C6")]
			[Address(RVA = "0x1F70260", Offset = "0x1F6EE60", VA = "0x181F70260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060249C7 RID: 149959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249C7")]
		[Address(RVA = "0x1F6FED0", Offset = "0x1F6EAD0", VA = "0x181F6FED0")]
		public void LoadData(int shopLevel, AutoChessShopStatus status, string levelColStr)
		{
		}

		// Token: 0x060249C8 RID: 149960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249C8")]
		[Address(RVA = "0x1F70040", Offset = "0x1F6EC40", VA = "0x181F70040")]
		public void RefreshByShopStatusChanged(AutoChessShopStatus status)
		{
		}

		// Token: 0x060249C9 RID: 149961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249C9")]
		[Address(RVA = "0x1F700C0", Offset = "0x1F6ECC0", VA = "0x181F700C0")]
		public AutoChessShopLevelTagViewModel()
		{
		}

		// Token: 0x0403314B RID: 209227
		[Token(Token = "0x403314B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0403314C RID: 209228
		[Token(Token = "0x403314C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0403314D RID: 209229
		[Token(Token = "0x403314D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_shopStatus;

		// Token: 0x0403314E RID: 209230
		[Token(Token = "0x403314E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_shopStatus;

		// Token: 0x0403314F RID: 209231
		[Token(Token = "0x403314F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_levelTagBgColor;

		// Token: 0x04033150 RID: 209232
		[Token(Token = "0x4033150")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_levelTagBgColor;

		// Token: 0x04033151 RID: 209233
		[Token(Token = "0x4033151")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033152 RID: 209234
		[Token(Token = "0x4033152")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshByShopStatusChanged;

		// Token: 0x04033153 RID: 209235
		[Token(Token = "0x4033153")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
