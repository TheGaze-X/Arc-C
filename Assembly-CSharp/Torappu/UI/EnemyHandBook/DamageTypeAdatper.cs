using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F44 RID: 20292
	[Token(Token = "0x2004F44")]
	public class DamageTypeAdatper : SimpleLayoutAdapter
	{
		// Token: 0x170046DD RID: 18141
		// (get) Token: 0x0601E375 RID: 123765 RVA: 0x000ADEE0 File Offset: 0x000AC0E0
		[Token(Token = "0x170046DD")]
		public override int count
		{
			[Token(Token = "0x601E375")]
			[Address(RVA = "0x17E0F80", Offset = "0x17DFB80", VA = "0x1817E0F80", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601E376 RID: 123766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E376")]
		[Address(RVA = "0x17E0D00", Offset = "0x17DF900", VA = "0x1817E0D00", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0601E377 RID: 123767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E377")]
		[Address(RVA = "0x17E0F20", Offset = "0x17DFB20", VA = "0x1817E0F20")]
		public DamageTypeAdatper()
		{
		}

		// Token: 0x0402846C RID: 164972
		[Token(Token = "0x402846C")]
		[FieldOffset(Offset = "0x20")]
		public UIIntEvent clickEvent;

		// Token: 0x0402846D RID: 164973
		[Token(Token = "0x402846D")]
		[FieldOffset(Offset = "0x28")]
		public List<EnemyHandbookShuffleViewModel.DamageTypeShuffleItem> damageTypeList;

		// Token: 0x0402846E RID: 164974
		[Token(Token = "0x402846E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0402846F RID: 164975
		[Token(Token = "0x402846F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04028470 RID: 164976
		[Token(Token = "0x4028470")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
