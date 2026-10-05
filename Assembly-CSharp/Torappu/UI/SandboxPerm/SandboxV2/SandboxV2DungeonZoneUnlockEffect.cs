using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041BF RID: 16831
	[Token(Token = "0x20041BF")]
	public class SandboxV2DungeonZoneUnlockEffect : SandboxV2DungeonPushMessageElement
	{
		// Token: 0x06019F31 RID: 106289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F31")]
		[Address(RVA = "0x12E4220", Offset = "0x12E2E20", VA = "0x1812E4220")]
		private void _PlayEffect()
		{
		}

		// Token: 0x06019F32 RID: 106290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F32")]
		[Address(RVA = "0x12E4440", Offset = "0x12E3040", VA = "0x1812E4440")]
		private void _Reset()
		{
		}

		// Token: 0x06019F33 RID: 106291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F33")]
		[Address(RVA = "0x12E3EF0", Offset = "0x12E2AF0", VA = "0x1812E3EF0", Slot = "4")]
		public override void SetShowStatus(SandboxV2DungeonPushMessageElement.ShowParam showParam)
		{
		}

		// Token: 0x06019F34 RID: 106292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F34")]
		[Address(RVA = "0x12E44B0", Offset = "0x12E30B0", VA = "0x1812E44B0")]
		public SandboxV2DungeonZoneUnlockEffect()
		{
		}

		// Token: 0x04020AD9 RID: 133849
		[Token(Token = "0x4020AD9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasUI;

		// Token: 0x04020ADA RID: 133850
		[Token(Token = "0x4020ADA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _canvasUIFadeDur;

		// Token: 0x04020ADB RID: 133851
		[Token(Token = "0x4020ADB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _cameraFocusStartTime;

		// Token: 0x04020ADC RID: 133852
		[Token(Token = "0x4020ADC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _cameraFocusDur;

		// Token: 0x04020ADD RID: 133853
		[Token(Token = "0x4020ADD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Ease _cameraFocusEaseType;

		// Token: 0x04020ADE RID: 133854
		[Token(Token = "0x4020ADE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _effectTotalDur;

		// Token: 0x04020ADF RID: 133855
		[Token(Token = "0x4020ADF")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_effectTween;

		// Token: 0x04020AE0 RID: 133856
		[Token(Token = "0x4020AE0")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020AE1 RID: 133857
		[Token(Token = "0x4020AE1")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedZoneId;

		// Token: 0x04020AE2 RID: 133858
		[Token(Token = "0x4020AE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__PlayEffect;

		// Token: 0x04020AE3 RID: 133859
		[Token(Token = "0x4020AE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x04020AE4 RID: 133860
		[Token(Token = "0x4020AE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04020AE5 RID: 133861
		[Token(Token = "0x4020AE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
