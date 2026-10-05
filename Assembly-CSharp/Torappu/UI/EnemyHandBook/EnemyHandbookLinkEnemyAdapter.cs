using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F2F RID: 20271
	[Token(Token = "0x2004F2F")]
	public class EnemyHandbookLinkEnemyAdapter : SimpleLayoutAdapter
	{
		// Token: 0x170046CA RID: 18122
		// (get) Token: 0x0601E325 RID: 123685 RVA: 0x000ADCB8 File Offset: 0x000ABEB8
		[Token(Token = "0x170046CA")]
		public override int count
		{
			[Token(Token = "0x601E325")]
			[Address(RVA = "0x17EEF80", Offset = "0x17EDB80", VA = "0x1817EEF80", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601E326 RID: 123686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E326")]
		[Address(RVA = "0x17EEC90", Offset = "0x17ED890", VA = "0x1817EEC90", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0601E327 RID: 123687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E327")]
		[Address(RVA = "0x17EEF20", Offset = "0x17EDB20", VA = "0x1817EEF20")]
		public EnemyHandbookLinkEnemyAdapter()
		{
		}

		// Token: 0x040283CF RID: 164815
		[Token(Token = "0x40283CF")]
		[FieldOffset(Offset = "0x20")]
		public List<EnemyHandBookEverViewModel.LinkEnemy> linkEnemiesList;

		// Token: 0x040283D0 RID: 164816
		[Token(Token = "0x40283D0")]
		[FieldOffset(Offset = "0x28")]
		public UIStringEvent jumpToLinkEvent;

		// Token: 0x040283D1 RID: 164817
		[Token(Token = "0x40283D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x040283D2 RID: 164818
		[Token(Token = "0x40283D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040283D3 RID: 164819
		[Token(Token = "0x40283D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
