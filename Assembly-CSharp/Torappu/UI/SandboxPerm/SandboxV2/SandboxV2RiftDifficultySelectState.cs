using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004386 RID: 17286
	[Token(Token = "0x2004386")]
	public class SandboxV2RiftDifficultySelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601A89A RID: 108698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A89A")]
		[Address(RVA = "0x13B0C40", Offset = "0x13AF840", VA = "0x1813B0C40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A89B RID: 108699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A89B")]
		[Address(RVA = "0x13B0CA0", Offset = "0x13AF8A0", VA = "0x1813B0CA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A89C RID: 108700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A89C")]
		[Address(RVA = "0x13B1200", Offset = "0x13AFE00", VA = "0x1813B1200", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A89D RID: 108701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A89D")]
		[Address(RVA = "0x13B1410", Offset = "0x13B0010", VA = "0x1813B1410")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A89E RID: 108702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A89E")]
		[Address(RVA = "0x13B1AA0", Offset = "0x13B06A0", VA = "0x1813B1AA0")]
		private void _ResetEnterAnim()
		{
		}

		// Token: 0x0601A89F RID: 108703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A89F")]
		[Address(RVA = "0x13B1980", Offset = "0x13B0580", VA = "0x1813B1980")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601A8A0 RID: 108704 RVA: 0x000A2528 File Offset: 0x000A0728
		[Token(Token = "0x601A8A0")]
		[Address(RVA = "0x13B1380", Offset = "0x13AFF80", VA = "0x1813B1380")]
		private bool _EnsureStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601A8A1 RID: 108705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8A1")]
		[Address(RVA = "0x13B0FE0", Offset = "0x13AFBE0", VA = "0x1813B0FE0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A8A2 RID: 108706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8A2")]
		[Address(RVA = "0x13B14B0", Offset = "0x13B00B0", VA = "0x1813B14B0")]
		private void _OnCloseState()
		{
		}

		// Token: 0x0601A8A3 RID: 108707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8A3")]
		[Address(RVA = "0x13B1590", Offset = "0x13B0190", VA = "0x1813B1590")]
		private void _OnConfirmDifficultyLevel(string difficultyId)
		{
		}

		// Token: 0x0601A8A4 RID: 108708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8A4")]
		[Address(RVA = "0x13B1840", Offset = "0x13B0440", VA = "0x1813B1840")]
		private void _OnDifficultyChange(int endLevel)
		{
		}

		// Token: 0x0601A8A5 RID: 108709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8A5")]
		[Address(RVA = "0x13B1B80", Offset = "0x13B0780", VA = "0x1813B1B80")]
		public SandboxV2RiftDifficultySelectState()
		{
		}

		// Token: 0x0601A8A7 RID: 108711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8A7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A8A8 RID: 108712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8A8")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04021C64 RID: 138340
		[Token(Token = "0x4021C64")]
		[NonSerialized]
		public const int ON_CLOSE_STATE = 0;

		// Token: 0x04021C65 RID: 138341
		[Token(Token = "0x4021C65")]
		[NonSerialized]
		public const int ON_CONFIRM_DIFFICULTY_LEVEL = 1;

		// Token: 0x04021C66 RID: 138342
		[Token(Token = "0x4021C66")]
		[NonSerialized]
		public const int ON_DIFFICULTY_CHANGE = 2;

		// Token: 0x04021C67 RID: 138343
		[Token(Token = "0x4021C67")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2RiftDifficultySelectView _view;

		// Token: 0x04021C68 RID: 138344
		[Token(Token = "0x4021C68")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04021C69 RID: 138345
		[Token(Token = "0x4021C69")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2RiftDifficultySelectStateBean m_stateBean;

		// Token: 0x04021C6A RID: 138346
		[Token(Token = "0x4021C6A")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04021C6B RID: 138347
		[Token(Token = "0x4021C6B")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_enterAnimTween;

		// Token: 0x04021C6C RID: 138348
		[Token(Token = "0x4021C6C")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedEnterDifficultyId;

		// Token: 0x04021C6D RID: 138349
		[Token(Token = "0x4021C6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04021C6E RID: 138350
		[Token(Token = "0x4021C6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04021C6F RID: 138351
		[Token(Token = "0x4021C6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04021C70 RID: 138352
		[Token(Token = "0x4021C70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021C71 RID: 138353
		[Token(Token = "0x4021C71")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetEnterAnim;

		// Token: 0x04021C72 RID: 138354
		[Token(Token = "0x4021C72")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04021C73 RID: 138355
		[Token(Token = "0x4021C73")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EnsureStateStable;

		// Token: 0x04021C74 RID: 138356
		[Token(Token = "0x4021C74")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04021C75 RID: 138357
		[Token(Token = "0x4021C75")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnCloseState;

		// Token: 0x04021C76 RID: 138358
		[Token(Token = "0x4021C76")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnConfirmDifficultyLevel;

		// Token: 0x04021C77 RID: 138359
		[Token(Token = "0x4021C77")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnDifficultyChange;

		// Token: 0x04021C78 RID: 138360
		[Token(Token = "0x4021C78")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
