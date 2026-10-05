using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078A0 RID: 30880
	[Token(Token = "0x20078A0")]
	public class Act1LockDetailViewBase : DataBinder<Act1LockDetailProperty>
	{
		// Token: 0x1700653C RID: 25916
		// (get) Token: 0x0602B4A6 RID: 177318 RVA: 0x000DB5B8 File Offset: 0x000D97B8
		[Token(Token = "0x1700653C")]
		protected bool isActive
		{
			[Token(Token = "0x602B4A6")]
			[Address(RVA = "0x271F020", Offset = "0x271DC20", VA = "0x18271F020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700653D RID: 25917
		// (get) Token: 0x0602B4A7 RID: 177319 RVA: 0x000DB5D0 File Offset: 0x000D97D0
		[Token(Token = "0x1700653D")]
		protected bool isTransiting
		{
			[Token(Token = "0x602B4A7")]
			[Address(RVA = "0x271F090", Offset = "0x271DC90", VA = "0x18271F090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700653E RID: 25918
		// (get) Token: 0x0602B4A8 RID: 177320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700653E")]
		protected UIPage page
		{
			[Token(Token = "0x602B4A8")]
			[Address(RVA = "0x271F100", Offset = "0x271DD00", VA = "0x18271F100")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B4A9 RID: 177321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4A9")]
		[Address(RVA = "0x271EC40", Offset = "0x271D840", VA = "0x18271EC40")]
		public void Setup(UIPage page)
		{
		}

		// Token: 0x1700653F RID: 25919
		// (get) Token: 0x0602B4AA RID: 177322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700653F")]
		protected CanvasGroup alphaHandler
		{
			[Token(Token = "0x602B4AA")]
			[Address(RVA = "0x271EF50", Offset = "0x271DB50", VA = "0x18271EF50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B4AB RID: 177323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4AB")]
		[Address(RVA = "0x271E8B0", Offset = "0x271D4B0", VA = "0x18271E8B0", Slot = "7")]
		public override void OnValueChanged(Act1LockDetailProperty property)
		{
		}

		// Token: 0x0602B4AC RID: 177324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4AC")]
		[Address(RVA = "0x271E850", Offset = "0x271D450", VA = "0x18271E850", Slot = "8")]
		protected virtual void OnEnter()
		{
		}

		// Token: 0x0602B4AD RID: 177325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4AD")]
		[Address(RVA = "0x271E7F0", Offset = "0x271D3F0", VA = "0x18271E7F0", Slot = "9")]
		protected virtual void OnDataUpdated(Act1LockDetailProperty prop)
		{
		}

		// Token: 0x0602B4AE RID: 177326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4AE")]
		[Address(RVA = "0x271E600", Offset = "0x271D200", VA = "0x18271E600", Slot = "10")]
		protected virtual void CancelExit()
		{
		}

		// Token: 0x0602B4AF RID: 177327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4AF")]
		[Address(RVA = "0x271E570", Offset = "0x271D170", VA = "0x18271E570", Slot = "11")]
		protected virtual void CancelEnter()
		{
		}

		// Token: 0x0602B4B0 RID: 177328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B4B0")]
		[Address(RVA = "0x271E690", Offset = "0x271D290", VA = "0x18271E690", Slot = "12")]
		protected virtual IEnumerator EnterYieldInstruction()
		{
			return null;
		}

		// Token: 0x0602B4B1 RID: 177329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B4B1")]
		[Address(RVA = "0x271E740", Offset = "0x271D340", VA = "0x18271E740", Slot = "13")]
		protected virtual IEnumerator ExitYieldInstruction()
		{
			return null;
		}

		// Token: 0x0602B4B2 RID: 177330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B4B2")]
		[Address(RVA = "0x271ED80", Offset = "0x271D980", VA = "0x18271ED80")]
		private IEnumerator _EnterProcess()
		{
			return null;
		}

		// Token: 0x0602B4B3 RID: 177331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B4B3")]
		[Address(RVA = "0x271EE30", Offset = "0x271DA30", VA = "0x18271EE30")]
		private IEnumerator _ExitProcess()
		{
			return null;
		}

		// Token: 0x0602B4B4 RID: 177332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4B4")]
		[Address(RVA = "0x271ECC0", Offset = "0x271D8C0", VA = "0x18271ECC0")]
		private void _CoroutineWithPage(IEnumerator coroutine)
		{
		}

		// Token: 0x0602B4B5 RID: 177333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4B5")]
		[Address(RVA = "0x271EEE0", Offset = "0x271DAE0", VA = "0x18271EEE0")]
		public Act1LockDetailViewBase()
		{
		}

		// Token: 0x0403E920 RID: 256288
		[Token(Token = "0x403E920")]
		private const float DEFAULT_ANIM_DUR = 0.23f;

		// Token: 0x0403E921 RID: 256289
		[Token(Token = "0x403E921")]
		[FieldOffset(Offset = "0x20")]
		private Act1LockDetailViewBase.DetailViewStatus m_detailStatus;

		// Token: 0x0403E922 RID: 256290
		[Token(Token = "0x403E922")]
		[FieldOffset(Offset = "0x28")]
		private UIPage m_page;

		// Token: 0x0403E923 RID: 256291
		[Token(Token = "0x403E923")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_defaultEnterTween;

		// Token: 0x0403E924 RID: 256292
		[Token(Token = "0x403E924")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_defaultExitTween;

		// Token: 0x0403E925 RID: 256293
		[Token(Token = "0x403E925")]
		[FieldOffset(Offset = "0x40")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0403E926 RID: 256294
		[Token(Token = "0x403E926")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x0403E927 RID: 256295
		[Token(Token = "0x403E927")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isTransiting;

		// Token: 0x0403E928 RID: 256296
		[Token(Token = "0x403E928")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0403E929 RID: 256297
		[Token(Token = "0x403E929")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0403E92A RID: 256298
		[Token(Token = "0x403E92A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x0403E92B RID: 256299
		[Token(Token = "0x403E92B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E92C RID: 256300
		[Token(Token = "0x403E92C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E92D RID: 256301
		[Token(Token = "0x403E92D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x0403E92E RID: 256302
		[Token(Token = "0x403E92E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CancelExit;

		// Token: 0x0403E92F RID: 256303
		[Token(Token = "0x403E92F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CancelEnter;

		// Token: 0x0403E930 RID: 256304
		[Token(Token = "0x403E930")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EnterYieldInstruction;

		// Token: 0x0403E931 RID: 256305
		[Token(Token = "0x403E931")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ExitYieldInstruction;

		// Token: 0x0403E932 RID: 256306
		[Token(Token = "0x403E932")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EnterProcess;

		// Token: 0x0403E933 RID: 256307
		[Token(Token = "0x403E933")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ExitProcess;

		// Token: 0x0403E934 RID: 256308
		[Token(Token = "0x403E934")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CoroutineWithPage;

		// Token: 0x0403E935 RID: 256309
		[Token(Token = "0x403E935")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078A1 RID: 30881
		[Token(Token = "0x20078A1")]
		protected enum DetailViewStatus
		{
			// Token: 0x0403E937 RID: 256311
			[Token(Token = "0x403E937")]
			NONE,
			// Token: 0x0403E938 RID: 256312
			[Token(Token = "0x403E938")]
			ENTERING,
			// Token: 0x0403E939 RID: 256313
			[Token(Token = "0x403E939")]
			ACTIVE,
			// Token: 0x0403E93A RID: 256314
			[Token(Token = "0x403E93A")]
			EXITING,
			// Token: 0x0403E93B RID: 256315
			[Token(Token = "0x403E93B")]
			INACTIVE
		}
	}
}
