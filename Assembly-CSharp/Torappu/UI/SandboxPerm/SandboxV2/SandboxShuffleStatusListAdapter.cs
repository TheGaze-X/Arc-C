using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200402A RID: 16426
	[Token(Token = "0x200402A")]
	public class SandboxShuffleStatusListAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x060196D1 RID: 104145 RVA: 0x0009DFF8 File Offset: 0x0009C1F8
		[Token(Token = "0x17003C93")]
		public override int count
		{
			[Token(Token = "0x60196D1")]
			[Address(RVA = "0x121AD90", Offset = "0x1219990", VA = "0x18121AD90", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060196D2 RID: 104146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60196D2")]
		[Address(RVA = "0x121AA00", Offset = "0x1219600", VA = "0x18121AA00", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060196D3 RID: 104147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196D3")]
		[Address(RVA = "0x121ABD0", Offset = "0x12197D0", VA = "0x18121ABD0")]
		public SandboxShuffleStatusListAdapter()
		{
		}

		// Token: 0x0401FA6D RID: 129645
		[Token(Token = "0x401FA6D")]
		[FieldOffset(Offset = "0x20")]
		private List<SandboxV2CharFilter> CHAR_STATUS_ORDER_LIST;

		// Token: 0x0401FA6E RID: 129646
		[Token(Token = "0x401FA6E")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2CharFilter charSelectFilter;

		// Token: 0x0401FA6F RID: 129647
		[Token(Token = "0x401FA6F")]
		[FieldOffset(Offset = "0x30")]
		public Action<SandboxV2CharFilter> onStatusFilterClick;

		// Token: 0x0401FA70 RID: 129648
		[Token(Token = "0x401FA70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0401FA71 RID: 129649
		[Token(Token = "0x401FA71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401FA72 RID: 129650
		[Token(Token = "0x401FA72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
