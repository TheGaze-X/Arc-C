using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CD2 RID: 23762
	[Token(Token = "0x2005CD2")]
	public class ClimbTowerProfessionMenuObject : ClimbTowerMenuObject
	{
		// Token: 0x170050E3 RID: 20707
		// (get) Token: 0x06022668 RID: 140904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050E3")]
		private ClimbTowerProfessionMenuObject.GetProfessionCharCount getProfessionCharCount
		{
			[Token(Token = "0x6022668")]
			[Address(RVA = "0x1CD64B0", Offset = "0x1CD50B0", VA = "0x181CD64B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022669 RID: 140905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022669")]
		[Address(RVA = "0x1CD5FD0", Offset = "0x1CD4BD0", VA = "0x181CD5FD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602266A RID: 140906 RVA: 0x000BD4F8 File Offset: 0x000BB6F8
		[Token(Token = "0x602266A")]
		[Address(RVA = "0x1CD5F20", Offset = "0x1CD4B20", VA = "0x181CD5F20")]
		private int _DefaultGetProfessionCharCount(ProfessionCategory profession)
		{
			return 0;
		}

		// Token: 0x0602266B RID: 140907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602266B")]
		[Address(RVA = "0x1CD61A0", Offset = "0x1CD4DA0", VA = "0x181CD61A0")]
		private void _RenderCount()
		{
		}

		// Token: 0x0602266C RID: 140908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602266C")]
		[Address(RVA = "0x1CD5DE0", Offset = "0x1CD49E0", VA = "0x181CD5DE0", Slot = "4")]
		public override void Render(ClimbTowerMenuViewModel viewModel)
		{
		}

		// Token: 0x0602266D RID: 140909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602266D")]
		[Address(RVA = "0x1CD5E70", Offset = "0x1CD4A70", VA = "0x181CD5E70")]
		public void UpdateButton(ClimbTowerProfessionMenuObject.GetProfessionCharCount overrideGetProfessionCharCount, Action<ProfessionCategory> callback)
		{
		}

		// Token: 0x0602266E RID: 140910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602266E")]
		[Address(RVA = "0x1CD63B0", Offset = "0x1CD4FB0", VA = "0x181CD63B0")]
		public ClimbTowerProfessionMenuObject()
		{
		}

		// Token: 0x0402F46E RID: 193646
		[Token(Token = "0x402F46E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ClimbTowerMenuProfessionItem> _professionItems;

		// Token: 0x0402F46F RID: 193647
		[Token(Token = "0x402F46F")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0402F470 RID: 193648
		[Token(Token = "0x402F470")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<ProfessionCategory, ClimbTowerMenuProfessionItem> m_professionViewDict;

		// Token: 0x0402F471 RID: 193649
		[Token(Token = "0x402F471")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerProfessionMenuObject.GetProfessionCharCount m_overrideGetProfessionCharCount;

		// Token: 0x0402F472 RID: 193650
		[Token(Token = "0x402F472")]
		[FieldOffset(Offset = "0x40")]
		private Action<ProfessionCategory> m_callback;

		// Token: 0x0402F473 RID: 193651
		[Token(Token = "0x402F473")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerMenuViewModel m_cachedModel;

		// Token: 0x0402F474 RID: 193652
		[Token(Token = "0x402F474")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_getProfessionCharCount;

		// Token: 0x0402F475 RID: 193653
		[Token(Token = "0x402F475")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F476 RID: 193654
		[Token(Token = "0x402F476")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DefaultGetProfessionCharCount;

		// Token: 0x0402F477 RID: 193655
		[Token(Token = "0x402F477")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCount;

		// Token: 0x0402F478 RID: 193656
		[Token(Token = "0x402F478")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F479 RID: 193657
		[Token(Token = "0x402F479")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateButton;

		// Token: 0x0402F47A RID: 193658
		[Token(Token = "0x402F47A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CD3 RID: 23763
		// (Invoke) Token: 0x06022670 RID: 140912
		[Token(Token = "0x2005CD3")]
		public delegate int GetProfessionCharCount(ProfessionCategory profession);
	}
}
