using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200427A RID: 17018
	[Token(Token = "0x200427A")]
	public class SandboxV2DungeonBlockView : SandboxV2DungeonPushMessageElement
	{
		// Token: 0x0601A388 RID: 107400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A388")]
		[Address(RVA = "0x13178B0", Offset = "0x13164B0", VA = "0x1813178B0")]
		public void SetColor(Color blockColor)
		{
		}

		// Token: 0x0601A389 RID: 107401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A389")]
		[Address(RVA = "0x1317960", Offset = "0x1316560", VA = "0x181317960", Slot = "4")]
		public override void SetShowStatus(SandboxV2DungeonPushMessageElement.ShowParam showParam)
		{
		}

		// Token: 0x0601A38A RID: 107402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A38A")]
		[Address(RVA = "0x1317DA0", Offset = "0x13169A0", VA = "0x181317DA0")]
		private void _SetBlockColorByParam(SandboxV2DungeonPushMessageElement.ShowParam showParam)
		{
		}

		// Token: 0x0601A38B RID: 107403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A38B")]
		[Address(RVA = "0x1317EE0", Offset = "0x1316AE0", VA = "0x181317EE0")]
		private void _Show(bool isFastMode)
		{
		}

		// Token: 0x0601A38C RID: 107404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A38C")]
		[Address(RVA = "0x1317BF0", Offset = "0x13167F0", VA = "0x181317BF0")]
		private void _Hide(bool isFastMode)
		{
		}

		// Token: 0x0601A38D RID: 107405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A38D")]
		[Address(RVA = "0x1317CA0", Offset = "0x13168A0", VA = "0x181317CA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A38E RID: 107406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A38E")]
		[Address(RVA = "0x1317F90", Offset = "0x1316B90", VA = "0x181317F90")]
		public SandboxV2DungeonBlockView()
		{
		}

		// Token: 0x04021320 RID: 135968
		[Token(Token = "0x4021320")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _graphicBlock;

		// Token: 0x04021321 RID: 135969
		[Token(Token = "0x4021321")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroupBlock;

		// Token: 0x04021322 RID: 135970
		[Token(Token = "0x4021322")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<SandboxV2DungeonBlockView.MonoColorBind> _blockColorBindList;

		// Token: 0x04021323 RID: 135971
		[Token(Token = "0x4021323")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x04021324 RID: 135972
		[Token(Token = "0x4021324")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04021325 RID: 135973
		[Token(Token = "0x4021325")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x04021326 RID: 135974
		[Token(Token = "0x4021326")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetColor;

		// Token: 0x04021327 RID: 135975
		[Token(Token = "0x4021327")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04021328 RID: 135976
		[Token(Token = "0x4021328")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetBlockColorByParam;

		// Token: 0x04021329 RID: 135977
		[Token(Token = "0x4021329")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Show;

		// Token: 0x0402132A RID: 135978
		[Token(Token = "0x402132A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Hide;

		// Token: 0x0402132B RID: 135979
		[Token(Token = "0x402132B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402132C RID: 135980
		[Token(Token = "0x402132C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200427B RID: 17019
		[Token(Token = "0x200427B")]
		[Serializable]
		private class MonoColorBind
		{
			// Token: 0x0601A38F RID: 107407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A38F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MonoColorBind()
			{
			}

			// Token: 0x0402132D RID: 135981
			[Token(Token = "0x402132D")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2DungeonPushMessageObservableType observableType;

			// Token: 0x0402132E RID: 135982
			[Token(Token = "0x402132E")]
			[FieldOffset(Offset = "0x14")]
			public Color blockColor;
		}
	}
}
