using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047F9 RID: 18425
	[Token(Token = "0x20047F9")]
	public class MonopolyMapLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BDDE RID: 114142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDDE")]
		[Address(RVA = "0x153F630", Offset = "0x153E230", VA = "0x18153F630")]
		public void InitPos(Vector2 startPos, Vector2 endPos)
		{
		}

		// Token: 0x0601BDDF RID: 114143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDDF")]
		[Address(RVA = "0x153FA10", Offset = "0x153E610", VA = "0x18153FA10")]
		public void SetHighLight(bool highLight, bool fastMode)
		{
		}

		// Token: 0x0601BDE0 RID: 114144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDE0")]
		[Address(RVA = "0x153FB30", Offset = "0x153E730", VA = "0x18153FB30")]
		public MonopolyMapLineView()
		{
		}

		// Token: 0x0402449E RID: 148638
		[Token(Token = "0x402449E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 RECT_PIVOT;

		// Token: 0x0402449F RID: 148639
		[Token(Token = "0x402449F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Line Generate")]
		private Image _lineImg;

		// Token: 0x040244A0 RID: 148640
		[Token(Token = "0x40244A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Line Generate")]
		private Sprite[] _lineRandomSprites;

		// Token: 0x040244A1 RID: 148641
		[Token(Token = "0x40244A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Line Generate")]
		private float _lineRedColorRandomMin;

		// Token: 0x040244A2 RID: 148642
		[Token(Token = "0x40244A2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Group("Line Generate")]
		private float _lineRedColorRandomMax;

		// Token: 0x040244A3 RID: 148643
		[Token(Token = "0x40244A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("High Light Line Generate")]
		private Image _highLightLineImg;

		// Token: 0x040244A4 RID: 148644
		[Token(Token = "0x40244A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("High Light Line Generate")]
		private Sprite[] _highLightLineRandomSprites;

		// Token: 0x040244A5 RID: 148645
		[Token(Token = "0x40244A5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _lineRect;

		// Token: 0x040244A6 RID: 148646
		[Token(Token = "0x40244A6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _lineWidth;

		// Token: 0x040244A7 RID: 148647
		[Token(Token = "0x40244A7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateFadeSwitcher _fadeSwitcher;

		// Token: 0x040244A8 RID: 148648
		[Token(Token = "0x40244A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitPos;

		// Token: 0x040244A9 RID: 148649
		[Token(Token = "0x40244A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetHighLight;

		// Token: 0x040244AA RID: 148650
		[Token(Token = "0x40244AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
