using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CE7 RID: 23783
	[Token(Token = "0x2005CE7")]
	public class TacticalBuffItemModel : IHotfixable
	{
		// Token: 0x060226F4 RID: 141044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226F4")]
		[Address(RVA = "0x1CE17F0", Offset = "0x1CE03F0", VA = "0x181CE17F0")]
		public TacticalBuffItemModel(ClimbTowerTacticalBuffData buffData, bool hasTowerPass)
		{
		}

		// Token: 0x170050F7 RID: 20727
		// (get) Token: 0x060226F5 RID: 141045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050F7")]
		public ClimbTowerTacticalBuffData buffData
		{
			[Token(Token = "0x60226F5")]
			[Address(RVA = "0x1CE1880", Offset = "0x1CE0480", VA = "0x181CE1880")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050F8 RID: 20728
		// (get) Token: 0x060226F6 RID: 141046 RVA: 0x000BD6C0 File Offset: 0x000BB8C0
		[Token(Token = "0x170050F8")]
		public bool isBuffLocked
		{
			[Token(Token = "0x60226F6")]
			[Address(RVA = "0x1CE18E0", Offset = "0x1CE04E0", VA = "0x181CE18E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0402F53B RID: 193851
		[Token(Token = "0x402F53B")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerTacticalBuffData m_buffData;

		// Token: 0x0402F53C RID: 193852
		[Token(Token = "0x402F53C")]
		[FieldOffset(Offset = "0x18")]
		private bool m_hasTowerPass;

		// Token: 0x0402F53D RID: 193853
		[Token(Token = "0x402F53D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402F53E RID: 193854
		[Token(Token = "0x402F53E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_buffData;

		// Token: 0x0402F53F RID: 193855
		[Token(Token = "0x402F53F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isBuffLocked;
	}
}
