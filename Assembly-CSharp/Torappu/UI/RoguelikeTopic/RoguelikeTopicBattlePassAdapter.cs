using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200447E RID: 17534
	[Token(Token = "0x200447E")]
	public class RoguelikeTopicBattlePassAdapter : LoopScrollAdapter<RoguelikeTopicBattlePassAdapter.ViewHolder, RoguelikeTopicBPObjViewModel>
	{
		// Token: 0x0601ACAA RID: 109738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACAA")]
		[Address(RVA = "0x13F1A70", Offset = "0x13F0670", VA = "0x1813F1A70", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601ACAB RID: 109739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACAB")]
		[Address(RVA = "0x13F1B30", Offset = "0x13F0730", VA = "0x1813F1B30", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeTopicBattlePassAdapter.ViewHolder holder, RoguelikeTopicBPObjViewModel data)
		{
		}

		// Token: 0x0601ACAC RID: 109740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACAC")]
		[Address(RVA = "0x13F1C70", Offset = "0x13F0870", VA = "0x1813F1C70")]
		public RoguelikeTopicBattlePassAdapter()
		{
		}

		// Token: 0x0402243D RID: 140349
		[Token(Token = "0x402243D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeTopicBattlePassObjView _itemPrefab;

		// Token: 0x0402243E RID: 140350
		[Token(Token = "0x402243E")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<string> clickAction;

		// Token: 0x0402243F RID: 140351
		[Token(Token = "0x402243F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04022440 RID: 140352
		[Token(Token = "0x4022440")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04022441 RID: 140353
		[Token(Token = "0x4022441")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200447F RID: 17535
		[Token(Token = "0x200447F")]
		public class ViewHolder
		{
			// Token: 0x0601ACAD RID: 109741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACAD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04022442 RID: 140354
			[Token(Token = "0x4022442")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeTopicBattlePassObjView itemView;
		}
	}
}
