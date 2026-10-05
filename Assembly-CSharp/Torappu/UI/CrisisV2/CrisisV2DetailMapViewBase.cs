using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200599F RID: 22943
	[Token(Token = "0x200599F")]
	public abstract class CrisisV2DetailMapViewBase : DataBinder<CrisisV2MapProp>
	{
		// Token: 0x06021717 RID: 136983
		[Token(Token = "0x6021717")]
		protected abstract CrisisV2MapModel.ViewType GetViewType();

		// Token: 0x06021718 RID: 136984
		[Token(Token = "0x6021718")]
		protected abstract void InitDictPool();

		// Token: 0x06021719 RID: 136985
		[Token(Token = "0x6021719")]
		protected abstract void UpdateDictPool(CrisisV2MapModel mapModel);

		// Token: 0x0602171A RID: 136986
		[Token(Token = "0x602171A")]
		protected abstract Vector2 GetMapSize(CrisisV2MapModel mapModel);

		// Token: 0x0602171B RID: 136987
		[Token(Token = "0x602171B")]
		protected abstract void ForceRecycleDictPool();

		// Token: 0x0602171C RID: 136988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602171C")]
		[Address(RVA = "0x1BBE880", Offset = "0x1BBD480", VA = "0x181BBE880", Slot = "7")]
		public override void OnValueChanged(CrisisV2MapProp property)
		{
		}

		// Token: 0x0602171D RID: 136989 RVA: 0x000BA4C8 File Offset: 0x000B86C8
		[Token(Token = "0x602171D")]
		[Address(RVA = "0x1BBE710", Offset = "0x1BBD310", VA = "0x181BBE710")]
		public float GetTargetPos()
		{
			return 0f;
		}

		// Token: 0x0602171E RID: 136990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602171E")]
		[Address(RVA = "0x1BBEF00", Offset = "0x1BBDB00", VA = "0x181BBEF00")]
		private void _ScrollToPos(int seqNum, float targetPos)
		{
		}

		// Token: 0x0602171F RID: 136991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602171F")]
		[Address(RVA = "0x1BBEE10", Offset = "0x1BBDA10", VA = "0x181BBEE10")]
		private void _OnJumpComplete(int seqNum)
		{
		}

		// Token: 0x06021720 RID: 136992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021720")]
		[Address(RVA = "0x1BBED80", Offset = "0x1BBD980", VA = "0x181BBED80")]
		private void _NotifySwitchCompelted()
		{
		}

		// Token: 0x06021721 RID: 136993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021721")]
		[Address(RVA = "0x1BBF170", Offset = "0x1BBDD70", VA = "0x181BBF170")]
		private void _UpdateMapSize(CrisisV2MapModel mapModel)
		{
		}

		// Token: 0x06021722 RID: 136994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021722")]
		[Address(RVA = "0x1BBEB60", Offset = "0x1BBD760", VA = "0x181BBEB60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021723 RID: 136995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021723")]
		[Address(RVA = "0x1BBF250", Offset = "0x1BBDE50", VA = "0x181BBF250")]
		protected CrisisV2DetailMapViewBase()
		{
		}

		// Token: 0x0402DA3B RID: 186939
		[Token(Token = "0x402DA3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402DA3C RID: 186940
		[Token(Token = "0x402DA3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x0402DA3D RID: 186941
		[Token(Token = "0x402DA3D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _closePreviewArea;

		// Token: 0x0402DA3E RID: 186942
		[Token(Token = "0x402DA3E")]
		private const float JUMP_DURATION = 0.5f;

		// Token: 0x0402DA3F RID: 186943
		[Token(Token = "0x402DA3F")]
		private const float SCROLL_TOP_PADDING = 160f;

		// Token: 0x0402DA40 RID: 186944
		[Token(Token = "0x402DA40")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402DA41 RID: 186945
		[Token(Token = "0x402DA41")]
		[FieldOffset(Offset = "0x48")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402DA42 RID: 186946
		[Token(Token = "0x402DA42")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedSeqNum;

		// Token: 0x0402DA43 RID: 186947
		[Token(Token = "0x402DA43")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_jumpTween;

		// Token: 0x0402DA44 RID: 186948
		[Token(Token = "0x402DA44")]
		[FieldOffset(Offset = "0x60")]
		protected bool m_isVisible;

		// Token: 0x0402DA45 RID: 186949
		[Token(Token = "0x402DA45")]
		[FieldOffset(Offset = "0x68")]
		protected string m_mapId;

		// Token: 0x0402DA46 RID: 186950
		[Token(Token = "0x402DA46")]
		[FieldOffset(Offset = "0x70")]
		protected CrisisV2MapModel m_mapModel;

		// Token: 0x0402DA47 RID: 186951
		[Token(Token = "0x402DA47")]
		[FieldOffset(Offset = "0x78")]
		protected UIStateFinder m_stateFinder;

		// Token: 0x0402DA48 RID: 186952
		[Token(Token = "0x402DA48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DA49 RID: 186953
		[Token(Token = "0x402DA49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTargetPos;

		// Token: 0x0402DA4A RID: 186954
		[Token(Token = "0x402DA4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ScrollToPos;

		// Token: 0x0402DA4B RID: 186955
		[Token(Token = "0x402DA4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpComplete;

		// Token: 0x0402DA4C RID: 186956
		[Token(Token = "0x402DA4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NotifySwitchCompelted;

		// Token: 0x0402DA4D RID: 186957
		[Token(Token = "0x402DA4D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateMapSize;

		// Token: 0x0402DA4E RID: 186958
		[Token(Token = "0x402DA4E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DA4F RID: 186959
		[Token(Token = "0x402DA4F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
