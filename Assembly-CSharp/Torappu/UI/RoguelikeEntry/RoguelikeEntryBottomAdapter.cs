using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x0200446A RID: 17514
	[Token(Token = "0x200446A")]
	public class RoguelikeEntryBottomAdapter : LoopScrollAdapter<RoguelikeEntryBottomViewHolder, RoguelikeEntryItemViewModel>, IHotfixable
	{
		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x0601AC65 RID: 109669 RVA: 0x000A34D0 File Offset: 0x000A16D0
		// (set) Token: 0x0601AC66 RID: 109670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FAA")]
		public int focusIndex
		{
			[Token(Token = "0x601AC65")]
			[Address(RVA = "0x13D6040", Offset = "0x13D4C40", VA = "0x1813D6040")]
			[CompilerGenerated]
			private get
			{
				return 0;
			}
			[Token(Token = "0x601AC66")]
			[Address(RVA = "0x13D60A0", Offset = "0x13D4CA0", VA = "0x1813D60A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AC67 RID: 109671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC67")]
		[Address(RVA = "0x13D5D70", Offset = "0x13D4970", VA = "0x1813D5D70", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601AC68 RID: 109672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC68")]
		[Address(RVA = "0x13D5E20", Offset = "0x13D4A20", VA = "0x1813D5E20", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeEntryBottomViewHolder holder, RoguelikeEntryItemViewModel data)
		{
		}

		// Token: 0x0601AC69 RID: 109673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC69")]
		[Address(RVA = "0x13D5FD0", Offset = "0x13D4BD0", VA = "0x1813D5FD0")]
		public RoguelikeEntryBottomAdapter()
		{
		}

		// Token: 0x04022392 RID: 140178
		[Token(Token = "0x4022392")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x04022394 RID: 140180
		[Token(Token = "0x4022394")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusIndex;

		// Token: 0x04022395 RID: 140181
		[Token(Token = "0x4022395")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_focusIndex;

		// Token: 0x04022396 RID: 140182
		[Token(Token = "0x4022396")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04022397 RID: 140183
		[Token(Token = "0x4022397")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04022398 RID: 140184
		[Token(Token = "0x4022398")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
