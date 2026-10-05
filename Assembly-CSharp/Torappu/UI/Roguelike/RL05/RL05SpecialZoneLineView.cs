using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005624 RID: 22052
	[Token(Token = "0x2005624")]
	public class RL05SpecialZoneLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060205DE RID: 132574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205DE")]
		[Address(RVA = "0x1A84470", Offset = "0x1A83070", VA = "0x181A84470")]
		public void Init(RL05SpecialZoneLineView.InitParam initParam)
		{
		}

		// Token: 0x060205DF RID: 132575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205DF")]
		[Address(RVA = "0x1A84810", Offset = "0x1A83410", VA = "0x181A84810")]
		public void SetShow(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x060205E0 RID: 132576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205E0")]
		[Address(RVA = "0x1A845D0", Offset = "0x1A831D0", VA = "0x181A845D0")]
		public void Render(RL05SpecialZoneLineView.RenderParam renderParam)
		{
		}

		// Token: 0x060205E1 RID: 132577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205E1")]
		[Address(RVA = "0x1A849D0", Offset = "0x1A835D0", VA = "0x181A849D0")]
		private void _InitPos(Vector2 startVector, Vector2 endVector)
		{
		}

		// Token: 0x060205E2 RID: 132578 RVA: 0x000B5920 File Offset: 0x000B3B20
		[Token(Token = "0x60205E2")]
		[Address(RVA = "0x1A848E0", Offset = "0x1A834E0", VA = "0x181A848E0")]
		private bool _CheckIfLineValid(RoguelikeDungeonNode nodeStart, RoguelikeDungeonNode nodeEnd)
		{
			return default(bool);
		}

		// Token: 0x060205E3 RID: 132579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205E3")]
		[Address(RVA = "0x1A84C40", Offset = "0x1A83840", VA = "0x181A84C40")]
		private void _PlayColorAnim(bool isValid, bool fastMode)
		{
		}

		// Token: 0x060205E4 RID: 132580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205E4")]
		[Address(RVA = "0x1A84E20", Offset = "0x1A83A20", VA = "0x181A84E20")]
		public RL05SpecialZoneLineView()
		{
		}

		// Token: 0x0402BD08 RID: 179464
		[Token(Token = "0x402BD08")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgLine;

		// Token: 0x0402BD09 RID: 179465
		[Token(Token = "0x402BD09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x0402BD0A RID: 179466
		[Token(Token = "0x402BD0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402BD0B RID: 179467
		[Token(Token = "0x402BD0B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _lineWidth;

		// Token: 0x0402BD0C RID: 179468
		[Token(Token = "0x402BD0C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _delayColorTween;

		// Token: 0x0402BD0D RID: 179469
		[Token(Token = "0x402BD0D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _durationColorTween;

		// Token: 0x0402BD0E RID: 179470
		[Token(Token = "0x402BD0E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _durationFade;

		// Token: 0x0402BD0F RID: 179471
		[Token(Token = "0x402BD0F")]
		[FieldOffset(Offset = "0x40")]
		private Color m_cachedValidColor;

		// Token: 0x0402BD10 RID: 179472
		[Token(Token = "0x402BD10")]
		[FieldOffset(Offset = "0x50")]
		private Color m_cachedInvalidColor;

		// Token: 0x0402BD11 RID: 179473
		[Token(Token = "0x402BD11")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0402BD12 RID: 179474
		[Token(Token = "0x402BD12")]
		[FieldOffset(Offset = "0x68")]
		private bool? m_isLineValid;

		// Token: 0x0402BD13 RID: 179475
		[Token(Token = "0x402BD13")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_colorTween;

		// Token: 0x0402BD14 RID: 179476
		[Token(Token = "0x402BD14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402BD15 RID: 179477
		[Token(Token = "0x402BD15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402BD16 RID: 179478
		[Token(Token = "0x402BD16")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BD17 RID: 179479
		[Token(Token = "0x402BD17")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitPos;

		// Token: 0x0402BD18 RID: 179480
		[Token(Token = "0x402BD18")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfLineValid;

		// Token: 0x0402BD19 RID: 179481
		[Token(Token = "0x402BD19")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayColorAnim;

		// Token: 0x0402BD1A RID: 179482
		[Token(Token = "0x402BD1A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005625 RID: 22053
		[Token(Token = "0x2005625")]
		public struct InitParam
		{
			// Token: 0x0402BD1B RID: 179483
			[Token(Token = "0x402BD1B")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 startVector;

			// Token: 0x0402BD1C RID: 179484
			[Token(Token = "0x402BD1C")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 endVector;

			// Token: 0x0402BD1D RID: 179485
			[Token(Token = "0x402BD1D")]
			[FieldOffset(Offset = "0x10")]
			public Color validColor;

			// Token: 0x0402BD1E RID: 179486
			[Token(Token = "0x402BD1E")]
			[FieldOffset(Offset = "0x20")]
			public Color inValidColor;
		}

		// Token: 0x02005626 RID: 22054
		[Token(Token = "0x2005626")]
		public struct RenderParam
		{
			// Token: 0x0402BD1F RID: 179487
			[Token(Token = "0x402BD1F")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeDungeonNode nodeStart;

			// Token: 0x0402BD20 RID: 179488
			[Token(Token = "0x402BD20")]
			[FieldOffset(Offset = "0x8")]
			public RoguelikeDungeonNode nodeEnd;

			// Token: 0x0402BD21 RID: 179489
			[Token(Token = "0x402BD21")]
			[FieldOffset(Offset = "0x10")]
			public bool disable;
		}
	}
}
