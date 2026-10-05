using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D7E RID: 23934
	[Token(Token = "0x2005D7E")]
	public class ClimbTowerSquadMultiEditStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170051D4 RID: 20948
		// (get) Token: 0x06022B0C RID: 142092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051D4")]
		public ClimbTowerSquadMultiEditProp prop
		{
			[Token(Token = "0x6022B0C")]
			[Address(RVA = "0x1D3F3A0", Offset = "0x1D3DFA0", VA = "0x181D3F3A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022B0D RID: 142093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B0D")]
		[Address(RVA = "0x1D3EDC0", Offset = "0x1D3D9C0", VA = "0x181D3EDC0")]
		public void InitData(UIPage page)
		{
		}

		// Token: 0x06022B0E RID: 142094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B0E")]
		[Address(RVA = "0x1D3F1F0", Offset = "0x1D3DDF0", VA = "0x181D3F1F0")]
		public void SetFocusIndex(int viewIndex, float columnIndex)
		{
		}

		// Token: 0x06022B0F RID: 142095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B0F")]
		[Address(RVA = "0x1D3EF50", Offset = "0x1D3DB50", VA = "0x181D3EF50")]
		public void SaveEditDict()
		{
		}

		// Token: 0x06022B10 RID: 142096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B10")]
		[Address(RVA = "0x1D3F2B0", Offset = "0x1D3DEB0", VA = "0x181D3F2B0")]
		public ClimbTowerSquadMultiEditStateBean()
		{
		}

		// Token: 0x0402FB13 RID: 195347
		[Token(Token = "0x402FB13")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerSquadMultiEditProp m_prop;

		// Token: 0x0402FB14 RID: 195348
		[Token(Token = "0x402FB14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0402FB15 RID: 195349
		[Token(Token = "0x402FB15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402FB16 RID: 195350
		[Token(Token = "0x402FB16")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetFocusIndex;

		// Token: 0x0402FB17 RID: 195351
		[Token(Token = "0x402FB17")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SaveEditDict;

		// Token: 0x0402FB18 RID: 195352
		[Token(Token = "0x402FB18")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
