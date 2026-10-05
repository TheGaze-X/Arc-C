using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	[RequireComponent(typeof(CanvasGroup))]
	public class UIWidget : CallbackHandler
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000048")]
		public string Name
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public override string[] Callbacks
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x5C36950", Offset = "0x5C35550", VA = "0x185C36950", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x1700004A")]
		private float Duration
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x5C36A60", Offset = "0x5C35660", VA = "0x185C36A60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x1700004B")]
		public bool IgnoreTimeScale
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x1700004C")]
		public bool IsVisible
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x5C36A80", Offset = "0x5C35680", VA = "0x185C36A80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x1700004D")]
		public bool IsLocked
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x1B5F4F0", Offset = "0x1B5E0F0", VA = "0x181B5F4F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x5C35BD0", Offset = "0x5C347D0", VA = "0x185C35BD0")]
		private void Awake()
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x5D55A0", Offset = "0x5D41A0", VA = "0x1805D55A0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x36D3260", Offset = "0x36D1E60", VA = "0x1836D3260")]
		private void Start()
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x5C35F60", Offset = "0x5C34B60", VA = "0x185C35F60", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void OnAwake()
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		protected virtual void OnWidgetDestroy()
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x5C35EE0", Offset = "0x5C34AE0", VA = "0x185C35EE0")]
		private IEnumerator OnDelayedStart()
		{
			return null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x5C35C10", Offset = "0x5C34810", VA = "0x185C35C10")]
		private void CheckForAnimators()
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x5C36B50", Offset = "0x5C35750", VA = "0x185C36B50")]
		private void m_initialized()
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x5C36070", Offset = "0x5C34C70", VA = "0x185C36070", Slot = "11")]
		public virtual void Show()
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x5C35FF0", Offset = "0x5C34BF0", VA = "0x185C35FF0")]
		private IEnumerator OnShow()
		{
			return null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x5C35CA0", Offset = "0x5C348A0", VA = "0x185C35CA0", Slot = "12")]
		public virtual void Close()
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x5C35E40", Offset = "0x5C34A40", VA = "0x185C35E40")]
		private void GameObjectOnClose()
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x5C36480", Offset = "0x5C35080", VA = "0x185C36480")]
		private void TweenCanvasGroupAlpha(float startValue, float targetValue)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x5C36690", Offset = "0x5C35290", VA = "0x185C36690")]
		private void TweenTransformScale(Vector3 startValue, Vector3 targetValue)
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x5C35E10", Offset = "0x5C34A10", VA = "0x185C35E10", Slot = "13")]
		public virtual void Focus()
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x5C368B0", Offset = "0x5C354B0", VA = "0x185C368B0")]
		public UIWidget()
		{
		}

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("widget 的名称, 可以使用 WidgetUtility.Find<T>(name) 查找 widget 的引用")]
		protected new string name;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 100f)]
		internal int priority;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Header("Animator")]
		protected bool m_EnableAnimation;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected EasingEquations.EaseType m_EaseType;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		public float m_EnlargeFactor;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected float m_ReduceFactor;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected float m_Duration;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x40")]
		protected bool m_IgnoreTimeScale;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		[Tooltip("如果为 true 则在游戏对象关闭时停用该 widget")]
		[Header("Appearence")]
		protected bool m_DeactivateOnClose;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x42")]
		protected bool m_Focus;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x48")]
		protected RectTransform m_RectTransform;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x50")]
		protected CanvasGroup m_CanvasGroup;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x58")]
		private bool isInitialized;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x60")]
		private Queue<UnityAction> pendingActions;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x68")]
		protected bool m_IsShowing;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x70")]
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x78")]
		private TweenRunner<Vector3Tween> m_ScaleTweenRunner;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x80")]
		protected bool m_IsLocked;
	}
}
