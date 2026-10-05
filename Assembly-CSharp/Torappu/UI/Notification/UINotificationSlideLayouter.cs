using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Notification;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Notification
{
	// Token: 0x020047D9 RID: 18393
	[Token(Token = "0x20047D9")]
	public class UINotificationSlideLayouter : NotifyViewLayouter
	{
		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x0601BD50 RID: 114000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700422F")]
		public override NotifyViewHost host
		{
			[Token(Token = "0x601BD50")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BD51 RID: 114001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD51")]
		[Address(RVA = "0x1536A60", Offset = "0x1535660", VA = "0x181536A60")]
		public UINotificationSlideLayouter(NotifyViewHost controller, VerticalLayoutGroup layoutGroup)
		{
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x0601BD52 RID: 114002 RVA: 0x000A6698 File Offset: 0x000A4898
		[Token(Token = "0x17004230")]
		public override float toastPreDelay
		{
			[Token(Token = "0x601BD52")]
			[Address(RVA = "0x1536B20", Offset = "0x1535720", VA = "0x181536B20", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601BD53 RID: 114003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BD53")]
		protected override ViewType InstNotifyView<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options)
		{
			return null;
		}

		// Token: 0x0601BD54 RID: 114004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD54")]
		public override void AddNotifyView<ViewType, ParamType>(NotifyView notifyView, NotifyViewOptions<ViewType, ParamType> options)
		{
		}

		// Token: 0x0601BD55 RID: 114005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD55")]
		[Address(RVA = "0x1535FE0", Offset = "0x1534BE0", VA = "0x181535FE0", Slot = "6")]
		public override void RemoveNotifyView(int layoutId)
		{
		}

		// Token: 0x0601BD56 RID: 114006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BD56")]
		[Address(RVA = "0x1536080", Offset = "0x1534C80", VA = "0x181536080")]
		private UINotificationSlideLayouter.NotifyWrapper _GenerateWrapper(NotifyView notifyView)
		{
			return null;
		}

		// Token: 0x0601BD57 RID: 114007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD57")]
		[Address(RVA = "0x1536690", Offset = "0x1535290", VA = "0x181536690")]
		private void _StartShowEffect(UINotificationSlideLayouter.NotifyWrapper wrapper, bool toTheFront, float delay, [Optional] string audioSignal)
		{
		}

		// Token: 0x0601BD58 RID: 114008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD58")]
		[Address(RVA = "0x1536380", Offset = "0x1534F80", VA = "0x181536380")]
		private void _StartHideTween(UINotificationSlideLayouter.NotifyWrapper wrapper)
		{
		}

		// Token: 0x04024380 RID: 148352
		[Token(Token = "0x4024380")]
		private const string NOTIFY_CONTAINER_NAME = "notify_contaienr";

		// Token: 0x04024381 RID: 148353
		[Token(Token = "0x4024381")]
		private const float TWEEN_DURATION = 0.4f;

		// Token: 0x04024382 RID: 148354
		[Token(Token = "0x4024382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NotifyViewHost m_host;

		// Token: 0x04024383 RID: 148355
		[Token(Token = "0x4024383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VerticalLayoutGroup m_layout;

		// Token: 0x04024384 RID: 148356
		[Token(Token = "0x4024384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ListDict<int, UINotificationSlideLayouter.NotifyWrapper> m_notifyList;

		// Token: 0x020047DA RID: 18394
		[Token(Token = "0x20047DA")]
		private class NotifyWrapper
		{
			// Token: 0x0601BD59 RID: 114009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BD59")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NotifyWrapper()
			{
			}

			// Token: 0x04024385 RID: 148357
			[Token(Token = "0x4024385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform container;

			// Token: 0x04024386 RID: 148358
			[Token(Token = "0x4024386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LayoutElement layout;

			// Token: 0x04024387 RID: 148359
			[Token(Token = "0x4024387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween tween;

			// Token: 0x04024388 RID: 148360
			[Token(Token = "0x4024388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RectTransform viewTrans;

			// Token: 0x04024389 RID: 148361
			[Token(Token = "0x4024389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public NotifyView view;

			// Token: 0x0402438A RID: 148362
			[Token(Token = "0x402438A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector2 viewSize;
		}
	}
}
