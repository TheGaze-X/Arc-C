using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039BB RID: 14779
	[Token(Token = "0x20039BB")]
	[RequireComponent(typeof(LayoutElement))]
	public class HeightTweenLayoutElement : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601759E RID: 95646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601759E")]
		[Address(RVA = "0xFB10B0", Offset = "0xFAFCB0", VA = "0x180FB10B0")]
		public void SetInitHeight(float target)
		{
		}

		// Token: 0x0601759F RID: 95647 RVA: 0x00096228 File Offset: 0x00094428
		[Token(Token = "0x601759F")]
		[Address(RVA = "0xFB1050", Offset = "0xFAFC50", VA = "0x180FB1050")]
		public bool IsTweenActive()
		{
			return default(bool);
		}

		// Token: 0x060175A0 RID: 95648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175A0")]
		[Address(RVA = "0xFB1170", Offset = "0xFAFD70", VA = "0x180FB1170")]
		public void TweenHeight(float target, float overrideDuration)
		{
		}

		// Token: 0x060175A1 RID: 95649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175A1")]
		[Address(RVA = "0xFB1450", Offset = "0xFB0050", VA = "0x180FB1450")]
		public HeightTweenLayoutElement()
		{
		}

		// Token: 0x0401C325 RID: 115493
		[Token(Token = "0x401C325")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _speed;

		// Token: 0x0401C326 RID: 115494
		[Token(Token = "0x401C326")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0401C327 RID: 115495
		[Token(Token = "0x401C327")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minTime;

		// Token: 0x0401C328 RID: 115496
		[Token(Token = "0x401C328")]
		[FieldOffset(Offset = "0x2C")]
		private float m_heightTarget;

		// Token: 0x0401C329 RID: 115497
		[Token(Token = "0x401C329")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_tween;

		// Token: 0x0401C32A RID: 115498
		[Token(Token = "0x401C32A")]
		[FieldOffset(Offset = "0x38")]
		private float m_currentHeight;

		// Token: 0x0401C32B RID: 115499
		[Token(Token = "0x401C32B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetInitHeight;

		// Token: 0x0401C32C RID: 115500
		[Token(Token = "0x401C32C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsTweenActive;

		// Token: 0x0401C32D RID: 115501
		[Token(Token = "0x401C32D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TweenHeight;

		// Token: 0x0401C32E RID: 115502
		[Token(Token = "0x401C32E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
