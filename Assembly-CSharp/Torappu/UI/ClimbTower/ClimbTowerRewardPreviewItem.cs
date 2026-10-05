using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CA9 RID: 23721
	[Token(Token = "0x2005CA9")]
	public class ClimbTowerRewardPreviewItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170050A9 RID: 20649
		// (set) Token: 0x0602255C RID: 140636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050A9")]
		public float scaleFactor
		{
			[Token(Token = "0x602255C")]
			[Address(RVA = "0x1CC2590", Offset = "0x1CC1190", VA = "0x181CC2590")]
			set
			{
			}
		}

		// Token: 0x0602255D RID: 140637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602255D")]
		[Address(RVA = "0x1CC2100", Offset = "0x1CC0D00", VA = "0x181CC2100")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602255E RID: 140638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602255E")]
		[Address(RVA = "0x1CC2050", Offset = "0x1CC0C50", VA = "0x181CC2050")]
		public void Render(StageRewardViewModel viewModel)
		{
		}

		// Token: 0x0602255F RID: 140639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602255F")]
		[Address(RVA = "0x1CC22B0", Offset = "0x1CC0EB0", VA = "0x181CC22B0")]
		private void _RenderTimelyDrop(StageRewardViewModel viewModel)
		{
		}

		// Token: 0x06022560 RID: 140640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022560")]
		[Address(RVA = "0x1CC2500", Offset = "0x1CC1100", VA = "0x181CC2500")]
		public ClimbTowerRewardPreviewItem()
		{
		}

		// Token: 0x0402F295 RID: 193173
		[Token(Token = "0x402F295")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0402F296 RID: 193174
		[Token(Token = "0x402F296")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _timelyDropContainer;

		// Token: 0x0402F297 RID: 193175
		[Token(Token = "0x402F297")]
		[FieldOffset(Offset = "0x28")]
		private string m_cacheDropId;

		// Token: 0x0402F298 RID: 193176
		[Token(Token = "0x402F298")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_timelyDropItem;

		// Token: 0x0402F299 RID: 193177
		[Token(Token = "0x402F299")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x0402F29A RID: 193178
		[Token(Token = "0x402F29A")]
		[FieldOffset(Offset = "0x40")]
		private UIItemViewModel m_viewModel;

		// Token: 0x0402F29B RID: 193179
		[Token(Token = "0x402F29B")]
		[FieldOffset(Offset = "0x48")]
		private float m_scaleFactor;

		// Token: 0x0402F29C RID: 193180
		[Token(Token = "0x402F29C")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isInited;

		// Token: 0x0402F29D RID: 193181
		[Token(Token = "0x402F29D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_scaleFactor;

		// Token: 0x0402F29E RID: 193182
		[Token(Token = "0x402F29E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F29F RID: 193183
		[Token(Token = "0x402F29F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F2A0 RID: 193184
		[Token(Token = "0x402F2A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderTimelyDrop;

		// Token: 0x0402F2A1 RID: 193185
		[Token(Token = "0x402F2A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
