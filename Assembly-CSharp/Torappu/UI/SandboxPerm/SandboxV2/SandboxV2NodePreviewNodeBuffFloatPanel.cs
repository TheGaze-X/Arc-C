using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200426F RID: 17007
	[Token(Token = "0x200426F")]
	public class SandboxV2NodePreviewNodeBuffFloatPanel : SandboxV2FloatPanel
	{
		// Token: 0x0601A357 RID: 107351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A357")]
		[Address(RVA = "0x131ECA0", Offset = "0x131D8A0", VA = "0x18131ECA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A358 RID: 107352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A358")]
		[Address(RVA = "0x131EAB0", Offset = "0x131D6B0", VA = "0x18131EAB0", Slot = "4")]
		protected override void SetShowStatus(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601A359 RID: 107353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A359")]
		[Address(RVA = "0x131E980", Offset = "0x131D580", VA = "0x18131E980")]
		public void Render(SandboxV2DungeonNodeBuffViewModel buffViewModel)
		{
		}

		// Token: 0x0601A35A RID: 107354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A35A")]
		[Address(RVA = "0x131EE00", Offset = "0x131DA00", VA = "0x18131EE00")]
		public SandboxV2NodePreviewNodeBuffFloatPanel()
		{
		}

		// Token: 0x04021292 RID: 135826
		[Token(Token = "0x4021292")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _detailAlphaHandler;

		// Token: 0x04021293 RID: 135827
		[Token(Token = "0x4021293")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _detailPositionHandler;

		// Token: 0x04021294 RID: 135828
		[Token(Token = "0x4021294")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _detailShowPos;

		// Token: 0x04021295 RID: 135829
		[Token(Token = "0x4021295")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _detailHidePos;

		// Token: 0x04021296 RID: 135830
		[Token(Token = "0x4021296")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04021297 RID: 135831
		[Token(Token = "0x4021297")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04021298 RID: 135832
		[Token(Token = "0x4021298")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _extraText;

		// Token: 0x04021299 RID: 135833
		[Token(Token = "0x4021299")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0402129A RID: 135834
		[Token(Token = "0x402129A")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_detailShowTween;

		// Token: 0x0402129B RID: 135835
		[Token(Token = "0x402129B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402129C RID: 135836
		[Token(Token = "0x402129C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x0402129D RID: 135837
		[Token(Token = "0x402129D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402129E RID: 135838
		[Token(Token = "0x402129E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
