using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AE8 RID: 6888
	[Token(Token = "0x2001AE8")]
	public class BuyLaborStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600AE19 RID: 44569 RVA: 0x00043110 File Offset: 0x00041310
		// (set) Token: 0x0600AE1A RID: 44570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001495")]
		public int addCount
		{
			[Token(Token = "0x600AE19")]
			[Address(RVA = "0x329A1A0", Offset = "0x3298DA0", VA = "0x18329A1A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600AE1A")]
			[Address(RVA = "0x329A690", Offset = "0x3299290", VA = "0x18329A690")]
			set
			{
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x0600AE1B RID: 44571 RVA: 0x00043128 File Offset: 0x00041328
		[Token(Token = "0x17001496")]
		public int maxCount
		{
			[Token(Token = "0x600AE1B")]
			[Address(RVA = "0x329A440", Offset = "0x3299040", VA = "0x18329A440")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x0600AE1C RID: 44572 RVA: 0x00043140 File Offset: 0x00041340
		[Token(Token = "0x17001497")]
		public int apMaxCount
		{
			[Token(Token = "0x600AE1C")]
			[Address(RVA = "0x329A290", Offset = "0x3298E90", VA = "0x18329A290")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600AE1D RID: 44573 RVA: 0x00043158 File Offset: 0x00041358
		[Token(Token = "0x17001498")]
		public int laborCount
		{
			[Token(Token = "0x600AE1D")]
			[Address(RVA = "0x329A360", Offset = "0x3298F60", VA = "0x18329A360")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600AE1E RID: 44574 RVA: 0x00043170 File Offset: 0x00041370
		[Token(Token = "0x17001499")]
		public int laborLimit
		{
			[Token(Token = "0x600AE1E")]
			[Address(RVA = "0x329A3D0", Offset = "0x3298FD0", VA = "0x18329A3D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x0600AE1F RID: 44575 RVA: 0x00043188 File Offset: 0x00041388
		[Token(Token = "0x1700149A")]
		public int minCount
		{
			[Token(Token = "0x600AE1F")]
			[Address(RVA = "0x329A620", Offset = "0x3299220", VA = "0x18329A620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE20")]
		[Address(RVA = "0x329A090", Offset = "0x3298C90", VA = "0x18329A090")]
		public void OnInitialize()
		{
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE21")]
		[Address(RVA = "0x329A020", Offset = "0x3298C20", VA = "0x18329A020")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE22")]
		[Address(RVA = "0x329A140", Offset = "0x3298D40", VA = "0x18329A140")]
		public BuyLaborStateBean()
		{
		}

		// Token: 0x0400A675 RID: 42613
		[Token(Token = "0x400A675")]
		[FieldOffset(Offset = "0x18")]
		private int m_addCount;

		// Token: 0x0400A676 RID: 42614
		[Token(Token = "0x400A676")]
		[FieldOffset(Offset = "0x20")]
		private BuildingLaborViewModel m_laborViewModel;

		// Token: 0x0400A677 RID: 42615
		[Token(Token = "0x400A677")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActionPointViewModel _apviewModel;

		// Token: 0x0400A678 RID: 42616
		[Token(Token = "0x400A678")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_addCount;

		// Token: 0x0400A679 RID: 42617
		[Token(Token = "0x400A679")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_addCount;

		// Token: 0x0400A67A RID: 42618
		[Token(Token = "0x400A67A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxCount;

		// Token: 0x0400A67B RID: 42619
		[Token(Token = "0x400A67B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_apMaxCount;

		// Token: 0x0400A67C RID: 42620
		[Token(Token = "0x400A67C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_laborCount;

		// Token: 0x0400A67D RID: 42621
		[Token(Token = "0x400A67D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_laborLimit;

		// Token: 0x0400A67E RID: 42622
		[Token(Token = "0x400A67E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_minCount;

		// Token: 0x0400A67F RID: 42623
		[Token(Token = "0x400A67F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInitialize;

		// Token: 0x0400A680 RID: 42624
		[Token(Token = "0x400A680")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0400A681 RID: 42625
		[Token(Token = "0x400A681")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
