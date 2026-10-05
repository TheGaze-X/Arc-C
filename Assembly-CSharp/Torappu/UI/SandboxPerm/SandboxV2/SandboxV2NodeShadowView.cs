using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200425C RID: 16988
	[Token(Token = "0x200425C")]
	public class SandboxV2NodeShadowView : MonoBehaviour, IAsyncDataView<SandboxV2NodeShadowView.RenderParam>, IAsyncShowEffect, IHotfixable
	{
		// Token: 0x0601A2E8 RID: 107240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2E8")]
		[Address(RVA = "0x13224B0", Offset = "0x13210B0", VA = "0x1813224B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A2E9 RID: 107241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2E9")]
		[Address(RVA = "0x1322610", Offset = "0x1321210", VA = "0x181322610")]
		private void _OnRecycle()
		{
		}

		// Token: 0x0601A2EA RID: 107242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2EA")]
		[Address(RVA = "0x13220C0", Offset = "0x1320CC0", VA = "0x1813220C0", Slot = "4")]
		public void AsyncSetData(SandboxV2NodeShadowView.RenderParam param)
		{
		}

		// Token: 0x0601A2EB RID: 107243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2EB")]
		[Address(RVA = "0x1322450", Offset = "0x1321050", VA = "0x181322450", Slot = "5")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601A2EC RID: 107244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2EC")]
		[Address(RVA = "0x1322680", Offset = "0x1321280", VA = "0x181322680")]
		public SandboxV2NodeShadowView()
		{
		}

		// Token: 0x040211A7 RID: 135591
		[Token(Token = "0x40211A7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _showHandler;

		// Token: 0x040211A8 RID: 135592
		[Token(Token = "0x40211A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040211A9 RID: 135593
		[Token(Token = "0x40211A9")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonConstructChecker;

		// Token: 0x040211AA RID: 135594
		[Token(Token = "0x40211AA")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_enterAnimChecker;

		// Token: 0x040211AB RID: 135595
		[Token(Token = "0x40211AB")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x040211AC RID: 135596
		[Token(Token = "0x40211AC")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2EnterAnimTween m_enterAnimTween;

		// Token: 0x040211AD RID: 135597
		[Token(Token = "0x40211AD")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_showTween;

		// Token: 0x040211AE RID: 135598
		[Token(Token = "0x40211AE")]
		[FieldOffset(Offset = "0x68")]
		private bool m_asyncShown;

		// Token: 0x040211AF RID: 135599
		[Token(Token = "0x40211AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040211B0 RID: 135600
		[Token(Token = "0x40211B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnRecycle;

		// Token: 0x040211B1 RID: 135601
		[Token(Token = "0x40211B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x040211B2 RID: 135602
		[Token(Token = "0x40211B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x040211B3 RID: 135603
		[Token(Token = "0x40211B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200425D RID: 16989
		[Token(Token = "0x200425D")]
		public struct RenderParam
		{
			// Token: 0x040211B4 RID: 135604
			[Token(Token = "0x40211B4")]
			[FieldOffset(Offset = "0x0")]
			public string nodeId;

			// Token: 0x040211B5 RID: 135605
			[Token(Token = "0x40211B5")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2DungeonViewModel dungeonViewModel;
		}
	}
}
