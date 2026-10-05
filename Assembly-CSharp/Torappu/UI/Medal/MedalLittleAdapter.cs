using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200497E RID: 18814
	[Token(Token = "0x200497E")]
	public class MedalLittleAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x0601C5A8 RID: 116136 RVA: 0x000A7F88 File Offset: 0x000A6188
		[Token(Token = "0x17004322")]
		public override int count
		{
			[Token(Token = "0x601C5A8")]
			[Address(RVA = "0x15D5030", Offset = "0x15D3C30", VA = "0x1815D5030", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C5A9 RID: 116137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C5A9")]
		[Address(RVA = "0x15D4D90", Offset = "0x15D3990", VA = "0x1815D4D90", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0601C5AA RID: 116138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5AA")]
		[Address(RVA = "0x15D4FD0", Offset = "0x15D3BD0", VA = "0x1815D4FD0")]
		public MedalLittleAdapter()
		{
		}

		// Token: 0x040251D0 RID: 152016
		[Token(Token = "0x40251D0")]
		[FieldOffset(Offset = "0x20")]
		public UIStringEvent toTargetEvent;

		// Token: 0x040251D1 RID: 152017
		[Token(Token = "0x40251D1")]
		[FieldOffset(Offset = "0x28")]
		public IList<string> viewModelList;

		// Token: 0x040251D2 RID: 152018
		[Token(Token = "0x40251D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x040251D3 RID: 152019
		[Token(Token = "0x40251D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040251D4 RID: 152020
		[Token(Token = "0x40251D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
