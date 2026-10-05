using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004C9F RID: 19615
	[Token(Token = "0x2004C9F")]
	public class HiddenStageMissionAdapter : SimpleLayoutAdapter
	{
		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x0601D66D RID: 120429 RVA: 0x000AB600 File Offset: 0x000A9800
		[Token(Token = "0x170044FB")]
		public override int count
		{
			[Token(Token = "0x601D66D")]
			[Address(RVA = "0x16E1790", Offset = "0x16E0390", VA = "0x1816E1790", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601D66E RID: 120430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D66E")]
		[Address(RVA = "0x16E1570", Offset = "0x16E0170", VA = "0x1816E1570", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0601D66F RID: 120431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D66F")]
		[Address(RVA = "0x16E16E0", Offset = "0x16E02E0", VA = "0x1816E16E0")]
		public HiddenStageMissionAdapter()
		{
		}

		// Token: 0x04026B74 RID: 158580
		[Token(Token = "0x4026B74")]
		[FieldOffset(Offset = "0x20")]
		public List<HiddenStageMissionViewModel> sorceList;

		// Token: 0x04026B75 RID: 158581
		[Token(Token = "0x4026B75")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<string> onStageJump;

		// Token: 0x04026B76 RID: 158582
		[Token(Token = "0x4026B76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04026B77 RID: 158583
		[Token(Token = "0x4026B77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04026B78 RID: 158584
		[Token(Token = "0x4026B78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
