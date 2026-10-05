using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006702 RID: 26370
	[Token(Token = "0x2006702")]
	public class HandBookV2MapGroupHolder : DataBinder<HandBookV2GroupProperty>, IHotfixable
	{
		// Token: 0x06025D80 RID: 155008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D80")]
		[Address(RVA = "0x20C77E0", Offset = "0x20C63E0", VA = "0x1820C77E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025D81 RID: 155009 RVA: 0x000C9318 File Offset: 0x000C7518
		[Token(Token = "0x6025D81")]
		[Address(RVA = "0x20C71A0", Offset = "0x20C5DA0", VA = "0x1820C71A0")]
		public float GetScale()
		{
			return 0f;
		}

		// Token: 0x06025D82 RID: 155010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D82")]
		[Address(RVA = "0x20C7B10", Offset = "0x20C6710", VA = "0x1820C7B10")]
		private void _OnScaleStart(float scale)
		{
		}

		// Token: 0x06025D83 RID: 155011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D83")]
		[Address(RVA = "0x20C7A90", Offset = "0x20C6690", VA = "0x1820C7A90")]
		private void _OnScaleEnd(float scale)
		{
		}

		// Token: 0x06025D84 RID: 155012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D84")]
		[Address(RVA = "0x20C7960", Offset = "0x20C6560", VA = "0x1820C7960")]
		private void _OnScaleChanged(float scale)
		{
		}

		// Token: 0x06025D85 RID: 155013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D85")]
		[Address(RVA = "0x20C76A0", Offset = "0x20C62A0", VA = "0x1820C76A0")]
		private HandBookV2MapGroupView _GetGroupView()
		{
			return null;
		}

		// Token: 0x06025D86 RID: 155014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D86")]
		[Address(RVA = "0x20C7D60", Offset = "0x20C6960", VA = "0x1820C7D60")]
		private void _RenderBackLogo(HandBookV2GroupViewModel viewModel)
		{
		}

		// Token: 0x06025D87 RID: 155015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D87")]
		[Address(RVA = "0x20C7B90", Offset = "0x20C6790", VA = "0x1820C7B90")]
		private IEnumerator _OnTransitionGroup(HandBookV2GroupViewModel oldViewModel, HandBookV2GroupViewModel newViewModel)
		{
			return null;
		}

		// Token: 0x06025D88 RID: 155016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D88")]
		[Address(RVA = "0x20C7C90", Offset = "0x20C6890", VA = "0x1820C7C90")]
		private IEnumerator _OnTransition(HandBookV2GroupViewModel newViewModel)
		{
			return null;
		}

		// Token: 0x06025D89 RID: 155017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D89")]
		[Address(RVA = "0x20C7230", Offset = "0x20C5E30", VA = "0x1820C7230", Slot = "7")]
		public override void OnValueChanged(HandBookV2GroupProperty property)
		{
		}

		// Token: 0x1700599D RID: 22941
		// (get) Token: 0x06025D8A RID: 155018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700599D")]
		public RectTransform touchZoomRect
		{
			[Token(Token = "0x6025D8A")]
			[Address(RVA = "0x20C7FE0", Offset = "0x20C6BE0", VA = "0x1820C7FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700599E RID: 22942
		// (get) Token: 0x06025D8B RID: 155019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700599E")]
		public ScrollRect scrollRect
		{
			[Token(Token = "0x6025D8B")]
			[Address(RVA = "0x20C7F80", Offset = "0x20C6B80", VA = "0x1820C7F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700599F RID: 22943
		// (get) Token: 0x06025D8C RID: 155020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700599F")]
		public RectTransform scrollRectTrans
		{
			[Token(Token = "0x6025D8C")]
			[Address(RVA = "0x20C7F20", Offset = "0x20C6B20", VA = "0x1820C7F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025D8D RID: 155021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D8D")]
		[Address(RVA = "0x20C75C0", Offset = "0x20C61C0", VA = "0x1820C75C0")]
		private void _CoroutineWithPage(IEnumerator coroutine)
		{
		}

		// Token: 0x06025D8E RID: 155022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D8E")]
		[Address(RVA = "0x20C7E60", Offset = "0x20C6A60", VA = "0x1820C7E60")]
		public HandBookV2MapGroupHolder()
		{
		}

		// Token: 0x04035348 RID: 217928
		[Token(Token = "0x4035348")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04035349 RID: 217929
		[Token(Token = "0x4035349")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIHandBookCardEvent _clickEvent;

		// Token: 0x0403534A RID: 217930
		[Token(Token = "0x403534A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _backLogo;

		// Token: 0x0403534B RID: 217931
		[Token(Token = "0x403534B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _focusView;

		// Token: 0x0403534C RID: 217932
		[Token(Token = "0x403534C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIStringEvent _onForceClick;

		// Token: 0x0403534D RID: 217933
		[Token(Token = "0x403534D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _scrollHolder;

		// Token: 0x0403534E RID: 217934
		[Token(Token = "0x403534E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UITouchZoom _touchZoom;

		// Token: 0x0403534F RID: 217935
		[Token(Token = "0x403534F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04035350 RID: 217936
		[Token(Token = "0x4035350")]
		[FieldOffset(Offset = "0x60")]
		private HandBookV2MapGroupView defaultGroup;

		// Token: 0x04035351 RID: 217937
		[Token(Token = "0x4035351")]
		[FieldOffset(Offset = "0x68")]
		private HandBookV2GroupViewModel m_cacheViewModel;

		// Token: 0x04035352 RID: 217938
		[Token(Token = "0x4035352")]
		[FieldOffset(Offset = "0x70")]
		private HandBookV2GroupViewModel m_pendingData;

		// Token: 0x04035353 RID: 217939
		[Token(Token = "0x4035353")]
		[FieldOffset(Offset = "0x78")]
		private HandBookV2MapGroupView m_groupView;

		// Token: 0x04035354 RID: 217940
		[Token(Token = "0x4035354")]
		[FieldOffset(Offset = "0x80")]
		private UIPageListener m_pageBinder;

		// Token: 0x04035355 RID: 217941
		[Token(Token = "0x4035355")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public bool isLocked;

		// Token: 0x04035356 RID: 217942
		[Token(Token = "0x4035356")]
		[FieldOffset(Offset = "0x90")]
		private string m_mainForce;

		// Token: 0x04035357 RID: 217943
		[Token(Token = "0x4035357")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04035358 RID: 217944
		[Token(Token = "0x4035358")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035359 RID: 217945
		[Token(Token = "0x4035359")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetScale;

		// Token: 0x0403535A RID: 217946
		[Token(Token = "0x403535A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnScaleStart;

		// Token: 0x0403535B RID: 217947
		[Token(Token = "0x403535B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnScaleEnd;

		// Token: 0x0403535C RID: 217948
		[Token(Token = "0x403535C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnScaleChanged;

		// Token: 0x0403535D RID: 217949
		[Token(Token = "0x403535D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetGroupView;

		// Token: 0x0403535E RID: 217950
		[Token(Token = "0x403535E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderBackLogo;

		// Token: 0x0403535F RID: 217951
		[Token(Token = "0x403535F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnTransitionGroup;

		// Token: 0x04035360 RID: 217952
		[Token(Token = "0x4035360")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnTransition;

		// Token: 0x04035361 RID: 217953
		[Token(Token = "0x4035361")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035362 RID: 217954
		[Token(Token = "0x4035362")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_touchZoomRect;

		// Token: 0x04035363 RID: 217955
		[Token(Token = "0x4035363")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_scrollRect;

		// Token: 0x04035364 RID: 217956
		[Token(Token = "0x4035364")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_scrollRectTrans;

		// Token: 0x04035365 RID: 217957
		[Token(Token = "0x4035365")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CoroutineWithPage;

		// Token: 0x04035366 RID: 217958
		[Token(Token = "0x4035366")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
