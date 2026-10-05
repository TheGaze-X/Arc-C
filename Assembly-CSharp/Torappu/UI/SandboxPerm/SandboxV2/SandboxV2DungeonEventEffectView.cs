using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041FC RID: 16892
	[Token(Token = "0x20041FC")]
	public class SandboxV2DungeonEventEffectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A125 RID: 106789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A125")]
		[Address(RVA = "0x12E7A90", Offset = "0x12E6690", VA = "0x1812E7A90")]
		public void Render(SandboxV2DungeonMiscEventEffectViewModel viewModel)
		{
		}

		// Token: 0x0601A126 RID: 106790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A126")]
		[Address(RVA = "0x12E7CC0", Offset = "0x12E68C0", VA = "0x1812E7CC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A127 RID: 106791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A127")]
		[Address(RVA = "0x12E7DE0", Offset = "0x12E69E0", VA = "0x1812E7DE0")]
		public SandboxV2DungeonEventEffectView()
		{
		}

		// Token: 0x04020D76 RID: 134518
		[Token(Token = "0x4020D76")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04020D77 RID: 134519
		[Token(Token = "0x4020D77")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _title;

		// Token: 0x04020D78 RID: 134520
		[Token(Token = "0x4020D78")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x04020D79 RID: 134521
		[Token(Token = "0x4020D79")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2DungeonEventEffectView.Adapter m_adapter;

		// Token: 0x04020D7A RID: 134522
		[Token(Token = "0x4020D7A")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2DungeonMiscEventEffectViewModel m_cachedViewModel;

		// Token: 0x04020D7B RID: 134523
		[Token(Token = "0x4020D7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020D7C RID: 134524
		[Token(Token = "0x4020D7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020D7D RID: 134525
		[Token(Token = "0x4020D7D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041FD RID: 16893
		[Token(Token = "0x20041FD")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A128 RID: 106792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A128")]
			[Address(RVA = "0x12E6600", Offset = "0x12E5200", VA = "0x1812E6600")]
			public Adapter(SandboxV2DungeonEventEffectView closure)
			{
			}

			// Token: 0x17003E11 RID: 15889
			// (get) Token: 0x0601A129 RID: 106793 RVA: 0x000A0380 File Offset: 0x0009E580
			[Token(Token = "0x17003E11")]
			public override int count
			{
				[Token(Token = "0x601A129")]
				[Address(RVA = "0x12E6880", Offset = "0x12E5480", VA = "0x1812E6880", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A12A RID: 106794 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A12A")]
			[Address(RVA = "0x12E5900", Offset = "0x12E4500", VA = "0x1812E5900", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020D7E RID: 134526
			[Token(Token = "0x4020D7E")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonEventEffectView m_closure;

			// Token: 0x04020D7F RID: 134527
			[Token(Token = "0x4020D7F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020D80 RID: 134528
			[Token(Token = "0x4020D80")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020D81 RID: 134529
			[Token(Token = "0x4020D81")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
