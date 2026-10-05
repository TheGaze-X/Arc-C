using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004241 RID: 16961
	[Token(Token = "0x2004241")]
	public class SandboxV2DungeonBottomBarFloatPanel : SandboxV2FloatPanel
	{
		// Token: 0x0601A24D RID: 107085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A24D")]
		[Address(RVA = "0x12FF1E0", Offset = "0x12FDDE0", VA = "0x1812FF1E0")]
		private void Update()
		{
		}

		// Token: 0x0601A24E RID: 107086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A24E")]
		[Address(RVA = "0x12FEDC0", Offset = "0x12FD9C0", VA = "0x1812FEDC0")]
		public void Render(SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A24F RID: 107087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A24F")]
		[Address(RVA = "0x12FF250", Offset = "0x12FDE50", VA = "0x1812FF250")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A250 RID: 107088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A250")]
		[Address(RVA = "0x12FF110", Offset = "0x12FDD10", VA = "0x1812FF110", Slot = "4")]
		protected override void SetShowStatus(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601A251 RID: 107089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A251")]
		[Address(RVA = "0x12FF3C0", Offset = "0x12FDFC0", VA = "0x1812FF3C0")]
		public SandboxV2DungeonBottomBarFloatPanel()
		{
		}

		// Token: 0x0402104B RID: 135243
		[Token(Token = "0x402104B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _detailAlphaHandler;

		// Token: 0x0402104C RID: 135244
		[Token(Token = "0x402104C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _detailPositionHandler;

		// Token: 0x0402104D RID: 135245
		[Token(Token = "0x402104D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _detailShowPos;

		// Token: 0x0402104E RID: 135246
		[Token(Token = "0x402104E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _detailHidePos;

		// Token: 0x0402104F RID: 135247
		[Token(Token = "0x402104F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlArchive;

		// Token: 0x04021050 RID: 135248
		[Token(Token = "0x4021050")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlArchiveText;

		// Token: 0x04021051 RID: 135249
		[Token(Token = "0x4021051")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pnlArchiveCoolDown;

		// Token: 0x04021052 RID: 135250
		[Token(Token = "0x4021052")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _countDownText;

		// Token: 0x04021053 RID: 135251
		[Token(Token = "0x4021053")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _archiveCg;

		// Token: 0x04021054 RID: 135252
		[Token(Token = "0x4021054")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _archiveCoolDownAlpha;

		// Token: 0x04021055 RID: 135253
		[Token(Token = "0x4021055")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _archiveHotspot;

		// Token: 0x04021056 RID: 135254
		[Token(Token = "0x4021056")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pnlDelete;

		// Token: 0x04021057 RID: 135255
		[Token(Token = "0x4021057")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _pnlDeleteDiv;

		// Token: 0x04021058 RID: 135256
		[Token(Token = "0x4021058")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x04021059 RID: 135257
		[Token(Token = "0x4021059")]
		[FieldOffset(Offset = "0xA0")]
		private UISwitchTween m_detailShowTween;

		// Token: 0x0402105A RID: 135258
		[Token(Token = "0x402105A")]
		[FieldOffset(Offset = "0xA8")]
		private CountDownTask m_cacheCountDownTask;

		// Token: 0x0402105B RID: 135259
		[Token(Token = "0x402105B")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2DungeonViewModel m_cachedDungeonViewModel;

		// Token: 0x0402105C RID: 135260
		[Token(Token = "0x402105C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402105D RID: 135261
		[Token(Token = "0x402105D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402105E RID: 135262
		[Token(Token = "0x402105E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402105F RID: 135263
		[Token(Token = "0x402105F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04021060 RID: 135264
		[Token(Token = "0x4021060")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
