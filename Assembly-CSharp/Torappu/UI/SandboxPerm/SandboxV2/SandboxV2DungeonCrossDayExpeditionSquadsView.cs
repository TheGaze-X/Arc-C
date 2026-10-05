using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200418E RID: 16782
	[Token(Token = "0x200418E")]
	public class SandboxV2DungeonCrossDayExpeditionSquadsView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019E33 RID: 106035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E33")]
		[Address(RVA = "0x12C26C0", Offset = "0x12C12C0", VA = "0x1812C26C0")]
		public void Render(List<List<Sprite>> squadsList)
		{
		}

		// Token: 0x06019E34 RID: 106036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E34")]
		[Address(RVA = "0x12C28B0", Offset = "0x12C14B0", VA = "0x1812C28B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019E35 RID: 106037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E35")]
		[Address(RVA = "0x12C2A10", Offset = "0x12C1610", VA = "0x1812C2A10")]
		public SandboxV2DungeonCrossDayExpeditionSquadsView()
		{
		}

		// Token: 0x040208E6 RID: 133350
		[Token(Token = "0x40208E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _expeditionsListContent;

		// Token: 0x040208E7 RID: 133351
		[Token(Token = "0x40208E7")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x040208E8 RID: 133352
		[Token(Token = "0x40208E8")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2DungeonCrossDayExpeditionSquadsView.SquadItemListAdapter m_adapter;

		// Token: 0x040208E9 RID: 133353
		[Token(Token = "0x40208E9")]
		[FieldOffset(Offset = "0x30")]
		private List<List<Sprite>> m_squadsList;

		// Token: 0x040208EA RID: 133354
		[Token(Token = "0x40208EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040208EB RID: 133355
		[Token(Token = "0x40208EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040208EC RID: 133356
		[Token(Token = "0x40208EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200418F RID: 16783
		[Token(Token = "0x200418F")]
		private class SquadItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06019E36 RID: 106038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019E36")]
			[Address(RVA = "0x12CA030", Offset = "0x12C8C30", VA = "0x1812CA030")]
			public SquadItemListAdapter(SandboxV2DungeonCrossDayExpeditionSquadsView closure)
			{
			}

			// Token: 0x17003DA4 RID: 15780
			// (get) Token: 0x06019E37 RID: 106039 RVA: 0x0009FA20 File Offset: 0x0009DC20
			[Token(Token = "0x17003DA4")]
			public override int count
			{
				[Token(Token = "0x6019E37")]
				[Address(RVA = "0x12CA0B0", Offset = "0x12C8CB0", VA = "0x1812CA0B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019E38 RID: 106040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019E38")]
			[Address(RVA = "0x12C9E80", Offset = "0x12C8A80", VA = "0x1812C9E80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040208ED RID: 133357
			[Token(Token = "0x40208ED")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonCrossDayExpeditionSquadsView m_closure;

			// Token: 0x040208EE RID: 133358
			[Token(Token = "0x40208EE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040208EF RID: 133359
			[Token(Token = "0x40208EF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040208F0 RID: 133360
			[Token(Token = "0x40208F0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
