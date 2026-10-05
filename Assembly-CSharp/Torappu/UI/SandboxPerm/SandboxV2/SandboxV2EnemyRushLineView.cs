using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004254 RID: 16980
	[Token(Token = "0x2004254")]
	public class SandboxV2EnemyRushLineView : Image, IAsyncDataView<SandboxV2EnemyRushLineView.RenderParam>, IAsyncShowEffect, IHotfixable
	{
		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x0601A2C4 RID: 107204 RVA: 0x000A06F8 File Offset: 0x0009E8F8
		[Token(Token = "0x17003E2F")]
		public override bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x601A2C4")]
			[Address(RVA = "0x131C9F0", Offset = "0x131B5F0", VA = "0x18131C9F0", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A2C5 RID: 107205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2C5")]
		[Address(RVA = "0x131C390", Offset = "0x131AF90", VA = "0x18131C390")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A2C6 RID: 107206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2C6")]
		[Address(RVA = "0x131C780", Offset = "0x131B380", VA = "0x18131C780")]
		private void _OnRecycle()
		{
		}

		// Token: 0x0601A2C7 RID: 107207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2C7")]
		[Address(RVA = "0x131C820", Offset = "0x131B420", VA = "0x18131C820")]
		private void _RefreshShowStatus(bool useTween)
		{
		}

		// Token: 0x0601A2C8 RID: 107208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2C8")]
		[Address(RVA = "0x131B660", Offset = "0x131A260", VA = "0x18131B660", Slot = "92")]
		public void AsyncSetData(SandboxV2EnemyRushLineView.RenderParam param)
		{
		}

		// Token: 0x0601A2C9 RID: 107209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2C9")]
		[Address(RVA = "0x131C500", Offset = "0x131B100", VA = "0x18131C500")]
		private void _LineTo(Vector2 srcPos, Vector2 dstPos)
		{
		}

		// Token: 0x0601A2CA RID: 107210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2CA")]
		[Address(RVA = "0x131BDA0", Offset = "0x131A9A0", VA = "0x18131BDA0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x0601A2CB RID: 107211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2CB")]
		[Address(RVA = "0x131BD40", Offset = "0x131A940", VA = "0x18131BD40", Slot = "93")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601A2CC RID: 107212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2CC")]
		[Address(RVA = "0x131C8E0", Offset = "0x131B4E0", VA = "0x18131C8E0")]
		public SandboxV2EnemyRushLineView()
		{
		}

		// Token: 0x0601A2CD RID: 107213 RVA: 0x000A0710 File Offset: 0x0009E910
		[Token(Token = "0x601A2CD")]
		[Address(RVA = "0xD742E0", Offset = "0xD72EE0", VA = "0x180D742E0")]
		private bool <>xLuaBaseProxy_get_packIntoRuntimeAtlas()
		{
			return default(bool);
		}

		// Token: 0x0601A2CE RID: 107214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2CE")]
		[Address(RVA = "0xD742D0", Offset = "0xD72ED0", VA = "0x180D742D0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x04021142 RID: 135490
		[Token(Token = "0x4021142")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private float _lineWidth;

		// Token: 0x04021143 RID: 135491
		[Token(Token = "0x4021143")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private CanvasGroup _showHandler;

		// Token: 0x04021144 RID: 135492
		[Token(Token = "0x4021144")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04021145 RID: 135493
		[Token(Token = "0x4021145")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Sprite _spriteEnemyRush;

		// Token: 0x04021146 RID: 135494
		[Token(Token = "0x4021146")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private Sprite _spriteMessenger;

		// Token: 0x04021147 RID: 135495
		[Token(Token = "0x4021147")]
		[FieldOffset(Offset = "0x1C0")]
		private bool m_inited;

		// Token: 0x04021148 RID: 135496
		[Token(Token = "0x4021148")]
		[FieldOffset(Offset = "0x1C8")]
		private SandboxV2EnterAnimTween m_enterAnimTween;

		// Token: 0x04021149 RID: 135497
		[Token(Token = "0x4021149")]
		[FieldOffset(Offset = "0x1D0")]
		private FadeSwitchTween m_showTween;

		// Token: 0x0402114A RID: 135498
		[Token(Token = "0x402114A")]
		[FieldOffset(Offset = "0x1D8")]
		private string m_cachedEnemyRushId;

		// Token: 0x0402114B RID: 135499
		[Token(Token = "0x402114B")]
		[FieldOffset(Offset = "0x1E0")]
		private string m_cachedLineId;

		// Token: 0x0402114C RID: 135500
		[Token(Token = "0x402114C")]
		[FieldOffset(Offset = "0x1E8")]
		private Vector2 m_cachedSrcPos;

		// Token: 0x0402114D RID: 135501
		[Token(Token = "0x402114D")]
		[FieldOffset(Offset = "0x1F0")]
		private Vector2 m_cachedDstPos;

		// Token: 0x0402114E RID: 135502
		[Token(Token = "0x402114E")]
		[FieldOffset(Offset = "0x1F8")]
		private float m_cachedCycleSpan;

		// Token: 0x0402114F RID: 135503
		[Token(Token = "0x402114F")]
		[FieldOffset(Offset = "0x1FC")]
		private bool m_cachedSelected;

		// Token: 0x04021150 RID: 135504
		[Token(Token = "0x4021150")]
		[FieldOffset(Offset = "0x1FD")]
		private bool m_asyncShown;

		// Token: 0x04021151 RID: 135505
		[Token(Token = "0x4021151")]
		[FieldOffset(Offset = "0x200")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonChangeChecker;

		// Token: 0x04021152 RID: 135506
		[Token(Token = "0x4021152")]
		[FieldOffset(Offset = "0x210")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_enemyRushSelectionChecker;

		// Token: 0x04021153 RID: 135507
		[Token(Token = "0x4021153")]
		[FieldOffset(Offset = "0x220")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_enterAnimChecker;

		// Token: 0x04021154 RID: 135508
		[Token(Token = "0x4021154")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_packIntoRuntimeAtlas;

		// Token: 0x04021155 RID: 135509
		[Token(Token = "0x4021155")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021156 RID: 135510
		[Token(Token = "0x4021156")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnRecycle;

		// Token: 0x04021157 RID: 135511
		[Token(Token = "0x4021157")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshShowStatus;

		// Token: 0x04021158 RID: 135512
		[Token(Token = "0x4021158")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x04021159 RID: 135513
		[Token(Token = "0x4021159")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LineTo;

		// Token: 0x0402115A RID: 135514
		[Token(Token = "0x402115A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0402115B RID: 135515
		[Token(Token = "0x402115B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x0402115C RID: 135516
		[Token(Token = "0x402115C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004255 RID: 16981
		[Token(Token = "0x2004255")]
		public struct RenderParam
		{
			// Token: 0x0402115D RID: 135517
			[Token(Token = "0x402115D")]
			[FieldOffset(Offset = "0x0")]
			public string lineId;

			// Token: 0x0402115E RID: 135518
			[Token(Token = "0x402115E")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2DungeonViewModel dungeonViewModel;
		}
	}
}
