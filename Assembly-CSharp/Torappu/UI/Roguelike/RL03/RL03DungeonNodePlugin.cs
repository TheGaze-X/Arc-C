using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x020057FE RID: 22526
	[Token(Token = "0x20057FE")]
	public class RL03DungeonNodePlugin : RoguelikeDungeonNodePlugin
	{
		// Token: 0x06020ED5 RID: 134869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED5")]
		[Address(RVA = "0x1B31090", Offset = "0x1B2FC90", VA = "0x181B31090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020ED6 RID: 134870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED6")]
		[Address(RVA = "0x1B30DF0", Offset = "0x1B2F9F0", VA = "0x181B30DF0", Slot = "4")]
		public override void Render(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x06020ED7 RID: 134871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED7")]
		[Address(RVA = "0x1B30B00", Offset = "0x1B2F700", VA = "0x181B30B00")]
		public void OnDialogDetail()
		{
		}

		// Token: 0x06020ED8 RID: 134872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED8")]
		[Address(RVA = "0x1B311A0", Offset = "0x1B2FDA0", VA = "0x181B311A0")]
		public RL03DungeonNodePlugin()
		{
		}

		// Token: 0x0402CC3A RID: 183354
		[Token(Token = "0x402CC3A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _clearPart;

		// Token: 0x0402CC3B RID: 183355
		[Token(Token = "0x402CC3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hidePart;

		// Token: 0x0402CC3C RID: 183356
		[Token(Token = "0x402CC3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hasTotem;

		// Token: 0x0402CC3D RID: 183357
		[Token(Token = "0x402CC3D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402CC3E RID: 183358
		[Token(Token = "0x402CC3E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeDetailNodeDialog _dialog;

		// Token: 0x0402CC3F RID: 183359
		[Token(Token = "0x402CC3F")]
		[FieldOffset(Offset = "0x40")]
		private RL03DungeonNodePlugin.Adapter m_adapter;

		// Token: 0x0402CC40 RID: 183360
		[Token(Token = "0x402CC40")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402CC41 RID: 183361
		[Token(Token = "0x402CC41")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeDungeonNode m_node;

		// Token: 0x0402CC42 RID: 183362
		[Token(Token = "0x402CC42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CC43 RID: 183363
		[Token(Token = "0x402CC43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CC44 RID: 183364
		[Token(Token = "0x402CC44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDialogDetail;

		// Token: 0x0402CC45 RID: 183365
		[Token(Token = "0x402CC45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057FF RID: 22527
		[Token(Token = "0x20057FF")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004D50 RID: 19792
			// (get) Token: 0x06020ED9 RID: 134873 RVA: 0x000B7D80 File Offset: 0x000B5F80
			[Token(Token = "0x17004D50")]
			public override int count
			{
				[Token(Token = "0x6020ED9")]
				[Address(RVA = "0x1B2E6A0", Offset = "0x1B2D2A0", VA = "0x181B2E6A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020EDA RID: 134874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020EDA")]
			[Address(RVA = "0x1B2E470", Offset = "0x1B2D070", VA = "0x181B2E470", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06020EDB RID: 134875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020EDB")]
			[Address(RVA = "0x1B2E5E0", Offset = "0x1B2D1E0", VA = "0x181B2E5E0")]
			public Adapter()
			{
			}

			// Token: 0x0402CC46 RID: 183366
			[Token(Token = "0x402CC46")]
			private const int MAX_COUNT = 7;

			// Token: 0x0402CC47 RID: 183367
			[Token(Token = "0x402CC47")]
			[FieldOffset(Offset = "0x20")]
			public int detailCount;

			// Token: 0x0402CC48 RID: 183368
			[Token(Token = "0x402CC48")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402CC49 RID: 183369
			[Token(Token = "0x402CC49")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402CC4A RID: 183370
			[Token(Token = "0x402CC4A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
