using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F43 RID: 20291
	[Token(Token = "0x2004F43")]
	public class AttackTypeAdatper : SimpleLayoutAdapter
	{
		// Token: 0x170046DC RID: 18140
		// (get) Token: 0x0601E372 RID: 123762 RVA: 0x000ADEC8 File Offset: 0x000AC0C8
		[Token(Token = "0x170046DC")]
		public override int count
		{
			[Token(Token = "0x601E372")]
			[Address(RVA = "0x17E0A10", Offset = "0x17DF610", VA = "0x1817E0A10", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601E373 RID: 123763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E373")]
		[Address(RVA = "0x17E07E0", Offset = "0x17DF3E0", VA = "0x1817E07E0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0601E374 RID: 123764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E374")]
		[Address(RVA = "0x17E09B0", Offset = "0x17DF5B0", VA = "0x1817E09B0")]
		public AttackTypeAdatper()
		{
		}

		// Token: 0x04028467 RID: 164967
		[Token(Token = "0x4028467")]
		[FieldOffset(Offset = "0x20")]
		public UIIntEvent clickEvent;

		// Token: 0x04028468 RID: 164968
		[Token(Token = "0x4028468")]
		[FieldOffset(Offset = "0x28")]
		public List<EnemyHandbookShuffleViewModel.AttackTypeShuffleItem> attackTypeList;

		// Token: 0x04028469 RID: 164969
		[Token(Token = "0x4028469")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0402846A RID: 164970
		[Token(Token = "0x402846A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402846B RID: 164971
		[Token(Token = "0x402846B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
