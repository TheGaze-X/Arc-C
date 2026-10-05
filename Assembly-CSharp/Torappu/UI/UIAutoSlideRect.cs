using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200384B RID: 14411
	[Token(Token = "0x200384B")]
	public class UIAutoSlideRect : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016D4D RID: 93517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D4D")]
		[Address(RVA = "0xF3E550", Offset = "0xF3D150", VA = "0x180F3E550")]
		private CanvasGroup _EnsureAlphaHandler()
		{
			return null;
		}

		// Token: 0x06016D4E RID: 93518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D4E")]
		[Address(RVA = "0xF3DD40", Offset = "0xF3C940", VA = "0x180F3DD40")]
		private void Awake()
		{
		}

		// Token: 0x06016D4F RID: 93519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D4F")]
		[Address(RVA = "0xF3E230", Offset = "0xF3CE30", VA = "0x180F3E230")]
		private void Update()
		{
		}

		// Token: 0x06016D50 RID: 93520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D50")]
		[Address(RVA = "0xF3DEC0", Offset = "0xF3CAC0", VA = "0x180F3DEC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06016D51 RID: 93521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D51")]
		[Address(RVA = "0xF3E850", Offset = "0xF3D450", VA = "0x180F3E850")]
		private void _TryStopCoroutine()
		{
		}

		// Token: 0x06016D52 RID: 93522 RVA: 0x00093240 File Offset: 0x00091440
		[Token(Token = "0x6016D52")]
		[Address(RVA = "0xF3E410", Offset = "0xF3D010", VA = "0x180F3E410")]
		private Vector2 _CalculateMoveDistance()
		{
			return default(Vector2);
		}

		// Token: 0x06016D53 RID: 93523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D53")]
		[Address(RVA = "0xF3E7A0", Offset = "0xF3D3A0", VA = "0x180F3E7A0")]
		private IEnumerator _MovingCoroutine()
		{
			return null;
		}

		// Token: 0x06016D54 RID: 93524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D54")]
		[Address(RVA = "0xF3DF50", Offset = "0xF3CB50", VA = "0x180F3DF50")]
		public void ResetSliding()
		{
		}

		// Token: 0x06016D55 RID: 93525 RVA: 0x00093258 File Offset: 0x00091458
		[Token(Token = "0x6016D55")]
		[Address(RVA = "0xF3E6D0", Offset = "0xF3D2D0", VA = "0x180F3E6D0")]
		private float _MoveDistance(float targetDistance, float cur, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06016D56 RID: 93526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D56")]
		[Address(RVA = "0xF3E8E0", Offset = "0xF3D4E0", VA = "0x180F3E8E0")]
		public UIAutoSlideRect()
		{
		}

		// Token: 0x0401B87D RID: 112765
		[Token(Token = "0x401B87D")]
		private const float MOVE_THRESHOLD = 0.9f;

		// Token: 0x0401B87E RID: 112766
		[Token(Token = "0x401B87E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _horizontalSpeed;

		// Token: 0x0401B87F RID: 112767
		[Token(Token = "0x401B87F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _verticalSpeed;

		// Token: 0x0401B880 RID: 112768
		[Token(Token = "0x401B880")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _beginWaitingTime;

		// Token: 0x0401B881 RID: 112769
		[Token(Token = "0x401B881")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _endWaitingTime;

		// Token: 0x0401B882 RID: 112770
		[Token(Token = "0x401B882")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _referenceRectTransform;

		// Token: 0x0401B883 RID: 112771
		[Token(Token = "0x401B883")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _textFadeDuration;

		// Token: 0x0401B884 RID: 112772
		[Token(Token = "0x401B884")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _selfDrive;

		// Token: 0x0401B885 RID: 112773
		[Token(Token = "0x401B885")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform m_rectTrans;

		// Token: 0x0401B886 RID: 112774
		[Token(Token = "0x401B886")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 m_startPos;

		// Token: 0x0401B887 RID: 112775
		[Token(Token = "0x401B887")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine m_movingCoroutine;

		// Token: 0x0401B888 RID: 112776
		[Token(Token = "0x401B888")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 m_moveDistance;

		// Token: 0x0401B889 RID: 112777
		[Token(Token = "0x401B889")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_sizeCache;

		// Token: 0x0401B88A RID: 112778
		[Token(Token = "0x401B88A")]
		[FieldOffset(Offset = "0x60")]
		private CanvasGroup m_optionalAlphaHandler;

		// Token: 0x0401B88B RID: 112779
		[Token(Token = "0x401B88B")]
		[FieldOffset(Offset = "0x68")]
		private int counter;

		// Token: 0x0401B88C RID: 112780
		[Token(Token = "0x401B88C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureAlphaHandler;

		// Token: 0x0401B88D RID: 112781
		[Token(Token = "0x401B88D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401B88E RID: 112782
		[Token(Token = "0x401B88E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401B88F RID: 112783
		[Token(Token = "0x401B88F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401B890 RID: 112784
		[Token(Token = "0x401B890")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryStopCoroutine;

		// Token: 0x0401B891 RID: 112785
		[Token(Token = "0x401B891")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalculateMoveDistance;

		// Token: 0x0401B892 RID: 112786
		[Token(Token = "0x401B892")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__MovingCoroutine;

		// Token: 0x0401B893 RID: 112787
		[Token(Token = "0x401B893")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetSliding;

		// Token: 0x0401B894 RID: 112788
		[Token(Token = "0x401B894")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__MoveDistance;

		// Token: 0x0401B895 RID: 112789
		[Token(Token = "0x401B895")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200384C RID: 14412
		[Token(Token = "0x200384C")]
		private struct Timer
		{
			// Token: 0x06016D57 RID: 93527 RVA: 0x00093270 File Offset: 0x00091470
			[Token(Token = "0x6016D57")]
			[Address(RVA = "0xF3B360", Offset = "0xF39F60", VA = "0x180F3B360")]
			public static UIAutoSlideRect.Timer FromNow()
			{
				return default(UIAutoSlideRect.Timer);
			}

			// Token: 0x06016D58 RID: 93528 RVA: 0x00093288 File Offset: 0x00091488
			[Token(Token = "0x6016D58")]
			[Address(RVA = "0xF3B3C0", Offset = "0xF39FC0", VA = "0x180F3B3C0")]
			public float GetDelta()
			{
				return 0f;
			}

			// Token: 0x0401B896 RID: 112790
			[Token(Token = "0x401B896")]
			[FieldOffset(Offset = "0x0")]
			private long m_startTick;
		}
	}
}
