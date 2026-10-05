using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004155 RID: 16725
	[Token(Token = "0x2004155")]
	public class SandboxV2BasementUpgradeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x06019D3D RID: 105789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D8F")]
		public SandboxV2BasementUpgradeProperty baseUpgradeProp
		{
			[Token(Token = "0x6019D3D")]
			[Address(RVA = "0x12A4EA0", Offset = "0x12A3AA0", VA = "0x1812A4EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019D3E RID: 105790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D3E")]
		[Address(RVA = "0x12A4DB0", Offset = "0x12A39B0", VA = "0x1812A4DB0")]
		public SandboxV2BasementUpgradeStateBean()
		{
		}

		// Token: 0x040206E7 RID: 132839
		[Token(Token = "0x40206E7")]
		[FieldOffset(Offset = "0x10")]
		private SandboxV2BasementUpgradeProperty m_upgradeProperty;

		// Token: 0x040206E8 RID: 132840
		[Token(Token = "0x40206E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_baseUpgradeProp;

		// Token: 0x040206E9 RID: 132841
		[Token(Token = "0x40206E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
