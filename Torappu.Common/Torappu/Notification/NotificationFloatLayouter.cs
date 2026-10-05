using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Notification
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	public class NotificationFloatLayouter : NotifyViewLayouter
	{
		// Token: 0x06000BCA RID: 3018 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x5570A70", Offset = "0x556F670", VA = "0x185570A70")]
		public NotificationFloatLayouter(NotifyViewHost host, RectTransform layoutGroup)
		{
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000119")]
		public override NotifyViewHost host
		{
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCC")]
		protected override ViewType InstNotifyView<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options)
		{
			return null;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BCD")]
		public override void AddNotifyView<ViewType, ParamType>(NotifyView notifyView, NotifyViewOptions<ViewType, ParamType> options)
		{
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x55702D0", Offset = "0x556EED0", VA = "0x1855702D0", Slot = "6")]
		public override void RemoveNotifyView(int layoutId)
		{
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x5570410", Offset = "0x556F010", VA = "0x185570410")]
		private NotificationFloatLayouter.NotifyWrapper _GenerateWrapper(NotifyView notifyView)
		{
			return null;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x55706B0", Offset = "0x556F2B0", VA = "0x1855706B0")]
		private void _StartShowEffect(NotificationFloatLayouter.NotifyWrapper wrapper, float delay)
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x55705E0", Offset = "0x556F1E0", VA = "0x1855705E0")]
		private void _StartHideTween(NotificationFloatLayouter.NotifyWrapper wrapper)
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x5570550", Offset = "0x556F150", VA = "0x185570550")]
		private IEnumerator _HideWrapperCoroutine(NotificationFloatLayouter.NotifyWrapper wrapper)
		{
			return null;
		}

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		[FieldOffset(Offset = "0x10")]
		private NotifyViewHost m_host;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform m_layout;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<int, NotificationFloatLayouter.NotifyWrapper> m_notifyList;

		// Token: 0x020001F6 RID: 502
		[Token(Token = "0x20001F6")]
		private class NotifyWrapper
		{
			// Token: 0x06000BD3 RID: 3027 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x5572460", Offset = "0x5571060", VA = "0x185572460")]
			public void ClearDelayTween()
			{
			}

			// Token: 0x06000BD4 RID: 3028 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NotifyWrapper()
			{
			}

			// Token: 0x04000B85 RID: 2949
			[Token(Token = "0x4000B85")]
			[FieldOffset(Offset = "0x10")]
			public NotifyView view;

			// Token: 0x04000B86 RID: 2950
			[Token(Token = "0x4000B86")]
			[FieldOffset(Offset = "0x18")]
			public UISwitchTween tween;

			// Token: 0x04000B87 RID: 2951
			[Token(Token = "0x4000B87")]
			[FieldOffset(Offset = "0x20")]
			public Tween delayTween;
		}
	}
}
