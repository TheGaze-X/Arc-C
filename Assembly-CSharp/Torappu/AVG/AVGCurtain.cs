using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F55 RID: 8021
	[Token(Token = "0x2001F55")]
	public class AVGCurtain : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x0600C75E RID: 51038 RVA: 0x00048AC8 File Offset: 0x00046CC8
		[Token(Token = "0x1700179B")]
		public float currentAlpha
		{
			[Token(Token = "0x600C75E")]
			[Address(RVA = "0x347BC90", Offset = "0x347A890", VA = "0x18347BC90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x0600C75F RID: 51039 RVA: 0x00048AE0 File Offset: 0x00046CE0
		[Token(Token = "0x1700179C")]
		public Color currentColor
		{
			[Token(Token = "0x600C75F")]
			[Address(RVA = "0x347BD00", Offset = "0x347A900", VA = "0x18347BD00")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x0600C760 RID: 51040 RVA: 0x00048AF8 File Offset: 0x00046CF8
		[Token(Token = "0x1700179D")]
		public Vector2 currentSize
		{
			[Token(Token = "0x600C760")]
			[Address(RVA = "0x347BDB0", Offset = "0x347A9B0", VA = "0x18347BDB0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x0600C761 RID: 51041 RVA: 0x00048B10 File Offset: 0x00046D10
		[Token(Token = "0x1700179E")]
		public Vector2 originSize
		{
			[Token(Token = "0x600C761")]
			[Address(RVA = "0x347BE20", Offset = "0x347AA20", VA = "0x18347BE20")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600C762 RID: 51042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C762")]
		[Address(RVA = "0x347BA40", Offset = "0x347A640", VA = "0x18347BA40")]
		public Tween SetCurtainSizeTween(Vector2 targetSize, float fadetime, bool useGradient)
		{
			return null;
		}

		// Token: 0x0600C763 RID: 51043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C763")]
		[Address(RVA = "0x347B8C0", Offset = "0x347A4C0", VA = "0x18347B8C0")]
		public Tween SetCurtainAlphaTween(float afrom, float ato, float fadetime)
		{
			return null;
		}

		// Token: 0x0600C764 RID: 51044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C764")]
		[Address(RVA = "0x347BB30", Offset = "0x347A730", VA = "0x18347BB30")]
		public void SetCurtainSize(Vector2 targetSize, bool useGradient)
		{
		}

		// Token: 0x0600C765 RID: 51045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C765")]
		[Address(RVA = "0x347B9C0", Offset = "0x347A5C0", VA = "0x18347B9C0")]
		public void SetCurtainAlpha(float targetAlpha = 1f)
		{
		}

		// Token: 0x0600C766 RID: 51046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C766")]
		[Address(RVA = "0x347B7D0", Offset = "0x347A3D0", VA = "0x18347B7D0")]
		public void ResetCurtain()
		{
		}

		// Token: 0x0600C767 RID: 51047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C767")]
		[Address(RVA = "0x347B520", Offset = "0x347A120", VA = "0x18347B520")]
		public void HideCurtain(float fadetime)
		{
		}

		// Token: 0x0600C768 RID: 51048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C768")]
		[Address(RVA = "0x347B6C0", Offset = "0x347A2C0", VA = "0x18347B6C0")]
		public void RecycleCurtain()
		{
		}

		// Token: 0x0600C769 RID: 51049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C769")]
		[Address(RVA = "0x347BC30", Offset = "0x347A830", VA = "0x18347BC30")]
		public AVGCurtain()
		{
		}

		// Token: 0x0400CD47 RID: 52551
		[Token(Token = "0x400CD47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _curtainRect;

		// Token: 0x0400CD48 RID: 52552
		[Token(Token = "0x400CD48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400CD49 RID: 52553
		[Token(Token = "0x400CD49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _curtainImg;

		// Token: 0x0400CD4A RID: 52554
		[Token(Token = "0x400CD4A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _gradientImg;

		// Token: 0x0400CD4B RID: 52555
		[Token(Token = "0x400CD4B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _originSize;

		// Token: 0x0400CD4C RID: 52556
		[Token(Token = "0x400CD4C")]
		private const float DEFAULT_ALPHA = 1f;

		// Token: 0x0400CD4D RID: 52557
		[Token(Token = "0x400CD4D")]
		private const float ALPHA_ZERO = 0f;

		// Token: 0x0400CD4E RID: 52558
		[Token(Token = "0x400CD4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentAlpha;

		// Token: 0x0400CD4F RID: 52559
		[Token(Token = "0x400CD4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentColor;

		// Token: 0x0400CD50 RID: 52560
		[Token(Token = "0x400CD50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentSize;

		// Token: 0x0400CD51 RID: 52561
		[Token(Token = "0x400CD51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_originSize;

		// Token: 0x0400CD52 RID: 52562
		[Token(Token = "0x400CD52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetCurtainSizeTween;

		// Token: 0x0400CD53 RID: 52563
		[Token(Token = "0x400CD53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetCurtainAlphaTween;

		// Token: 0x0400CD54 RID: 52564
		[Token(Token = "0x400CD54")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetCurtainSize;

		// Token: 0x0400CD55 RID: 52565
		[Token(Token = "0x400CD55")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetCurtainAlpha;

		// Token: 0x0400CD56 RID: 52566
		[Token(Token = "0x400CD56")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetCurtain;

		// Token: 0x0400CD57 RID: 52567
		[Token(Token = "0x400CD57")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HideCurtain;

		// Token: 0x0400CD58 RID: 52568
		[Token(Token = "0x400CD58")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RecycleCurtain;

		// Token: 0x0400CD59 RID: 52569
		[Token(Token = "0x400CD59")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
