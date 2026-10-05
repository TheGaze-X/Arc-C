using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CAF RID: 23727
	[Token(Token = "0x2005CAF")]
	public class ClimbTowerSweepCostTktItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022574 RID: 140660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022574")]
		[Address(RVA = "0x1CC3A00", Offset = "0x1CC2600", VA = "0x181CC3A00")]
		public void Render(ClimbTowerSweepCostTktItem.RenderOptions options)
		{
		}

		// Token: 0x06022575 RID: 140661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022575")]
		[Address(RVA = "0x1CC3C30", Offset = "0x1CC2830", VA = "0x181CC3C30")]
		public ClimbTowerSweepCostTktItem()
		{
		}

		// Token: 0x0402F2D9 RID: 193241
		[Token(Token = "0x402F2D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelTo;

		// Token: 0x0402F2DA RID: 193242
		[Token(Token = "0x402F2DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textFrom;

		// Token: 0x0402F2DB RID: 193243
		[Token(Token = "0x402F2DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTo;

		// Token: 0x0402F2DC RID: 193244
		[Token(Token = "0x402F2DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIItemTimeCountDown _timeView;

		// Token: 0x0402F2DD RID: 193245
		[Token(Token = "0x402F2DD")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerSweepCostTktItem.RenderOptions m_options;

		// Token: 0x0402F2DE RID: 193246
		[Token(Token = "0x402F2DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F2DF RID: 193247
		[Token(Token = "0x402F2DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CB0 RID: 23728
		[Token(Token = "0x2005CB0")]
		public struct RenderOptions : IHotfixable
		{
			// Token: 0x0402F2E0 RID: 193248
			[Token(Token = "0x402F2E0")]
			[FieldOffset(Offset = "0x0")]
			public ItemUtil.ConsumableInfo itemInfo;

			// Token: 0x0402F2E1 RID: 193249
			[Token(Token = "0x402F2E1")]
			[FieldOffset(Offset = "0x18")]
			public int useCount;

			// Token: 0x0402F2E2 RID: 193250
			[Token(Token = "0x402F2E2")]
			[FieldOffset(Offset = "0x20")]
			public long remainTs;
		}
	}
}
