using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200426B RID: 17003
	[Token(Token = "0x200426B")]
	public class SandboxV2NodePreviewDropNpcView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A34C RID: 107340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A34C")]
		[Address(RVA = "0x131DB70", Offset = "0x131C770", VA = "0x18131DB70")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601A34D RID: 107341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A34D")]
		[Address(RVA = "0x131E060", Offset = "0x131CC60", VA = "0x18131E060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A34E RID: 107342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A34E")]
		[Address(RVA = "0x131E2F0", Offset = "0x131CEF0", VA = "0x18131E2F0")]
		private void _UpdateDropDetail(SandboxV2DungeonNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601A34F RID: 107343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A34F")]
		[Address(RVA = "0x131E1B0", Offset = "0x131CDB0", VA = "0x18131E1B0")]
		private void _SortNpc()
		{
		}

		// Token: 0x0601A350 RID: 107344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A350")]
		[Address(RVA = "0x131E500", Offset = "0x131D100", VA = "0x18131E500")]
		public SandboxV2NodePreviewDropNpcView()
		{
		}

		// Token: 0x04021269 RID: 135785
		[Token(Token = "0x4021269")]
		private const int PREVIEW_DROP_ITEM_COUNT = 4;

		// Token: 0x0402126A RID: 135786
		[Token(Token = "0x402126A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _dropPanel;

		// Token: 0x0402126B RID: 135787
		[Token(Token = "0x402126B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyDropPanel;

		// Token: 0x0402126C RID: 135788
		[Token(Token = "0x402126C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalDropPanel;

		// Token: 0x0402126D RID: 135789
		[Token(Token = "0x402126D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _npcPanel;

		// Token: 0x0402126E RID: 135790
		[Token(Token = "0x402126E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _dropContent;

		// Token: 0x0402126F RID: 135791
		[Token(Token = "0x402126F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _noDropPanel;

		// Token: 0x04021270 RID: 135792
		[Token(Token = "0x4021270")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _dropItemScale;

		// Token: 0x04021271 RID: 135793
		[Token(Token = "0x4021271")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2NodePreviewNpcLoopAdapter _npcLoopAdapter;

		// Token: 0x04021272 RID: 135794
		[Token(Token = "0x4021272")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LoopHorizontalScrollRect _npcScrollRect;

		// Token: 0x04021273 RID: 135795
		[Token(Token = "0x4021273")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _dropDetailButton;

		// Token: 0x04021274 RID: 135796
		[Token(Token = "0x4021274")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04021275 RID: 135797
		[Token(Token = "0x4021275")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2NodePreviewDropNpcView.DropAdapter m_dropAdapter;

		// Token: 0x04021276 RID: 135798
		[Token(Token = "0x4021276")]
		[FieldOffset(Offset = "0x78")]
		private List<SandboxV2DropDetail> m_cachedDropDetailList;

		// Token: 0x04021277 RID: 135799
		[Token(Token = "0x4021277")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<SandboxV2DungeonNpcViewModel> m_duplicatedNpcList;

		// Token: 0x04021278 RID: 135800
		[Token(Token = "0x4021278")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021279 RID: 135801
		[Token(Token = "0x4021279")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402127A RID: 135802
		[Token(Token = "0x402127A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateDropDetail;

		// Token: 0x0402127B RID: 135803
		[Token(Token = "0x402127B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SortNpc;

		// Token: 0x0402127C RID: 135804
		[Token(Token = "0x402127C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200426C RID: 17004
		[Token(Token = "0x200426C")]
		private class DropAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003E3F RID: 15935
			// (get) Token: 0x0601A351 RID: 107345 RVA: 0x000A07B8 File Offset: 0x0009E9B8
			[Token(Token = "0x17003E3F")]
			public override int count
			{
				[Token(Token = "0x601A351")]
				[Address(RVA = "0x1314DE0", Offset = "0x13139E0", VA = "0x181314DE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A352 RID: 107346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A352")]
			[Address(RVA = "0x1314D60", Offset = "0x1313960", VA = "0x181314D60")]
			public DropAdapter(SandboxV2NodePreviewDropNpcView closure)
			{
			}

			// Token: 0x0601A353 RID: 107347 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A353")]
			[Address(RVA = "0x1314AA0", Offset = "0x13136A0", VA = "0x181314AA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402127D RID: 135805
			[Token(Token = "0x402127D")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2NodePreviewDropNpcView m_closure;

			// Token: 0x0402127E RID: 135806
			[Token(Token = "0x402127E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402127F RID: 135807
			[Token(Token = "0x402127F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021280 RID: 135808
			[Token(Token = "0x4021280")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
