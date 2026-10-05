using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A6C RID: 14956
	[Token(Token = "0x2003A6C")]
	public abstract class UIAnimationCompDialog : UISimpleCompDialog, IAudioAnimationPlayerConditionProvider, IHotfixable
	{
		// Token: 0x06017A5F RID: 96863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A5F")]
		[Address(RVA = "0xFF1650", Offset = "0xFF0250", VA = "0x180FF1650", Slot = "9")]
		protected sealed override void OnInit()
		{
		}

		// Token: 0x06017A60 RID: 96864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A60")]
		[Address(RVA = "0xFF16F0", Offset = "0xFF02F0", VA = "0x180FF16F0", Slot = "18")]
		protected sealed override void OnRender(object input)
		{
		}

		// Token: 0x06017A61 RID: 96865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A61")]
		[Address(RVA = "0xFF15F0", Offset = "0xFF01F0", VA = "0x180FF15F0", Slot = "20")]
		protected virtual void OnAnimationDialogInit()
		{
		}

		// Token: 0x06017A62 RID: 96866
		[Token(Token = "0x6017A62")]
		protected abstract void OnAnimationDialogRender(object input);

		// Token: 0x06017A63 RID: 96867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A63")]
		[Address(RVA = "0xFF1590", Offset = "0xFF0190", VA = "0x180FF1590", Slot = "22")]
		protected virtual void OnAnimationCompleted()
		{
		}

		// Token: 0x06017A64 RID: 96868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A64")]
		[Address(RVA = "0xFF18B0", Offset = "0xFF04B0", VA = "0x180FF18B0")]
		private void _OnTweenCompleted()
		{
		}

		// Token: 0x06017A65 RID: 96869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A65")]
		[Address(RVA = "0xFF19A0", Offset = "0xFF05A0", VA = "0x180FF19A0")]
		private void _PlayAnimation()
		{
		}

		// Token: 0x06017A66 RID: 96870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A66")]
		[Address(RVA = "0xFF14C0", Offset = "0xFF00C0", VA = "0x180FF14C0")]
		public void CloseDialogIfAnimPlayed()
		{
		}

		// Token: 0x06017A67 RID: 96871 RVA: 0x00097890 File Offset: 0x00095A90
		[Token(Token = "0x6017A67")]
		[Address(RVA = "0xFF1450", Offset = "0xFF0050", VA = "0x180FF1450", Slot = "19")]
		public bool CanPlayAudio()
		{
			return default(bool);
		}

		// Token: 0x06017A68 RID: 96872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A68")]
		[Address(RVA = "0xFF1AE0", Offset = "0xFF06E0", VA = "0x180FF1AE0")]
		protected UIAnimationCompDialog()
		{
		}

		// Token: 0x06017A69 RID: 96873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A69")]
		[Address(RVA = "0xFE84D0", Offset = "0xFE70D0", VA = "0x180FE84D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0401C89A RID: 116890
		[Token(Token = "0x401C89A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0401C89B RID: 116891
		[Token(Token = "0x401C89B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Ease _ease;

		// Token: 0x0401C89C RID: 116892
		[Token(Token = "0x401C89C")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool _dontCloseWhenPlayed;

		// Token: 0x0401C89D RID: 116893
		[Token(Token = "0x401C89D")]
		[FieldOffset(Offset = "0x85")]
		private bool m_isAnimPlayed;

		// Token: 0x0401C89E RID: 116894
		[Token(Token = "0x401C89E")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_animTween;

		// Token: 0x0401C89F RID: 116895
		[Token(Token = "0x401C89F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C8A0 RID: 116896
		[Token(Token = "0x401C8A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401C8A1 RID: 116897
		[Token(Token = "0x401C8A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAnimationDialogInit;

		// Token: 0x0401C8A2 RID: 116898
		[Token(Token = "0x401C8A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAnimationCompleted;

		// Token: 0x0401C8A3 RID: 116899
		[Token(Token = "0x401C8A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTweenCompleted;

		// Token: 0x0401C8A4 RID: 116900
		[Token(Token = "0x401C8A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayAnimation;

		// Token: 0x0401C8A5 RID: 116901
		[Token(Token = "0x401C8A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CloseDialogIfAnimPlayed;

		// Token: 0x0401C8A6 RID: 116902
		[Token(Token = "0x401C8A6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CanPlayAudio;

		// Token: 0x0401C8A7 RID: 116903
		[Token(Token = "0x401C8A7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
