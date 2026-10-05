using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071B3 RID: 29107
	[Token(Token = "0x20071B3")]
	public class Act6FunZoneMapBgPluginViewModel : IHotfixable
	{
		// Token: 0x170061C2 RID: 25026
		// (get) Token: 0x060294DC RID: 169180 RVA: 0x000D5438 File Offset: 0x000D3638
		// (set) Token: 0x060294DD RID: 169181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061C2")]
		public bool isNormalBg
		{
			[Token(Token = "0x60294DC")]
			[Address(RVA = "0x24B31E0", Offset = "0x24B1DE0", VA = "0x1824B31E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60294DD")]
			[Address(RVA = "0x24B32B0", Offset = "0x24B1EB0", VA = "0x1824B32B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061C3 RID: 25027
		// (get) Token: 0x060294DE RID: 169182 RVA: 0x000D5450 File Offset: 0x000D3650
		// (set) Token: 0x060294DF RID: 169183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061C3")]
		public bool isBonusBg
		{
			[Token(Token = "0x60294DE")]
			[Address(RVA = "0x24B3180", Offset = "0x24B1D80", VA = "0x1824B3180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60294DF")]
			[Address(RVA = "0x24B3240", Offset = "0x24B1E40", VA = "0x1824B3240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060294E0 RID: 169184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294E0")]
		[Address(RVA = "0x24B2E60", Offset = "0x24B1A60", VA = "0x1824B2E60")]
		public void LoadData(Act6FunData act6FunData)
		{
		}

		// Token: 0x060294E1 RID: 169185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294E1")]
		[Address(RVA = "0x24B2EE0", Offset = "0x24B1AE0", VA = "0x1824B2EE0")]
		public void RefreshByPlayerData(PlayerActFun6 playerActFun6Data)
		{
		}

		// Token: 0x060294E2 RID: 169186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294E2")]
		[Address(RVA = "0x24B3120", Offset = "0x24B1D20", VA = "0x1824B3120")]
		public Act6FunZoneMapBgPluginViewModel()
		{
		}

		// Token: 0x0403AFB3 RID: 241587
		[Token(Token = "0x403AFB3")]
		[FieldOffset(Offset = "0x14")]
		private int m_achieveTotalCount;

		// Token: 0x0403AFB4 RID: 241588
		[Token(Token = "0x403AFB4")]
		[FieldOffset(Offset = "0x18")]
		private int m_curAchieveCount;

		// Token: 0x0403AFB5 RID: 241589
		[Token(Token = "0x403AFB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isNormalBg;

		// Token: 0x0403AFB6 RID: 241590
		[Token(Token = "0x403AFB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isNormalBg;

		// Token: 0x0403AFB7 RID: 241591
		[Token(Token = "0x403AFB7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isBonusBg;

		// Token: 0x0403AFB8 RID: 241592
		[Token(Token = "0x403AFB8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isBonusBg;

		// Token: 0x0403AFB9 RID: 241593
		[Token(Token = "0x403AFB9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AFBA RID: 241594
		[Token(Token = "0x403AFBA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshByPlayerData;

		// Token: 0x0403AFBB RID: 241595
		[Token(Token = "0x403AFBB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
