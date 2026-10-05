using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003796 RID: 14230
	[Token(Token = "0x2003796")]
	public class FadeInDecoIfScrollEnd : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016940 RID: 92480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016940")]
		[Address(RVA = "0xEF83A0", Offset = "0xEF6FA0", VA = "0x180EF83A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016941 RID: 92481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016941")]
		[Address(RVA = "0xEF8650", Offset = "0xEF7250", VA = "0x180EF8650")]
		private void _OnValueChanged(Vector2 size)
		{
		}

		// Token: 0x06016942 RID: 92482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016942")]
		[Address(RVA = "0xEF86D0", Offset = "0xEF72D0", VA = "0x180EF86D0")]
		private void _UpdateDecoState(Vector2 size)
		{
		}

		// Token: 0x06016943 RID: 92483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016943")]
		[Address(RVA = "0xEF8570", Offset = "0xEF7170", VA = "0x180EF8570")]
		private void _OnContentLayoutRebuilt()
		{
		}

		// Token: 0x06016944 RID: 92484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016944")]
		[Address(RVA = "0xEF82F0", Offset = "0xEF6EF0", VA = "0x180EF82F0")]
		private void Start()
		{
		}

		// Token: 0x06016945 RID: 92485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016945")]
		[Address(RVA = "0xEF87D0", Offset = "0xEF73D0", VA = "0x180EF87D0")]
		public FadeInDecoIfScrollEnd()
		{
		}

		// Token: 0x0401B355 RID: 111445
		[Token(Token = "0x401B355")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FadeInDecoIfScrollEnd.DecoInfo _topDecoInfo;

		// Token: 0x0401B356 RID: 111446
		[Token(Token = "0x401B356")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FadeInDecoIfScrollEnd.DecoInfo _downDecoInfo;

		// Token: 0x0401B357 RID: 111447
		[Token(Token = "0x401B357")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FadeInDecoIfScrollEnd.DecoInfo _leftDecoInfo;

		// Token: 0x0401B358 RID: 111448
		[Token(Token = "0x401B358")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FadeInDecoIfScrollEnd.DecoInfo _rightDecoInfo;

		// Token: 0x0401B359 RID: 111449
		[Token(Token = "0x401B359")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401B35A RID: 111450
		[Token(Token = "0x401B35A")]
		[FieldOffset(Offset = "0x40")]
		private UIWrappedScrollRect.Wrapper m_scrollRect;

		// Token: 0x0401B35B RID: 111451
		[Token(Token = "0x401B35B")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isScrollVertical;

		// Token: 0x0401B35C RID: 111452
		[Token(Token = "0x401B35C")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isScrollHorizontal;

		// Token: 0x0401B35D RID: 111453
		[Token(Token = "0x401B35D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B35E RID: 111454
		[Token(Token = "0x401B35E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnValueChanged;

		// Token: 0x0401B35F RID: 111455
		[Token(Token = "0x401B35F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateDecoState;

		// Token: 0x0401B360 RID: 111456
		[Token(Token = "0x401B360")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnContentLayoutRebuilt;

		// Token: 0x0401B361 RID: 111457
		[Token(Token = "0x401B361")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B362 RID: 111458
		[Token(Token = "0x401B362")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003797 RID: 14231
		[Token(Token = "0x2003797")]
		[Serializable]
		private class DecoInfo : IHotfixable
		{
			// Token: 0x06016946 RID: 92486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016946")]
			[Address(RVA = "0xEF2E40", Offset = "0xEF1A40", VA = "0x180EF2E40")]
			public void Init()
			{
			}

			// Token: 0x06016947 RID: 92487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016947")]
			[Address(RVA = "0xEF2F60", Offset = "0xEF1B60", VA = "0x180EF2F60")]
			public void UpdateTween(bool inDirection, float pos)
			{
			}

			// Token: 0x06016948 RID: 92488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016948")]
			[Address(RVA = "0xEF3020", Offset = "0xEF1C20", VA = "0x180EF3020")]
			public DecoInfo()
			{
			}

			// Token: 0x0401B363 RID: 111459
			[Token(Token = "0x401B363")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float _endDistDelta;

			// Token: 0x0401B364 RID: 111460
			[Token(Token = "0x401B364")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _fadeDur;

			// Token: 0x0401B365 RID: 111461
			[Token(Token = "0x401B365")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private CanvasGroup _decCanvas;

			// Token: 0x0401B366 RID: 111462
			[Token(Token = "0x401B366")]
			[FieldOffset(Offset = "0x20")]
			private bool m_hasDeco;

			// Token: 0x0401B367 RID: 111463
			[Token(Token = "0x401B367")]
			[FieldOffset(Offset = "0x28")]
			private FadeSwitchTween m_tween;

			// Token: 0x0401B368 RID: 111464
			[Token(Token = "0x401B368")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0401B369 RID: 111465
			[Token(Token = "0x401B369")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateTween;

			// Token: 0x0401B36A RID: 111466
			[Token(Token = "0x401B36A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
