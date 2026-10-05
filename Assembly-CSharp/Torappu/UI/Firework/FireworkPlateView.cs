using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E40 RID: 20032
	[Token(Token = "0x2004E40")]
	public class FireworkPlateView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DEAD RID: 122541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEAD")]
		[Address(RVA = "0x1771BC0", Offset = "0x17707C0", VA = "0x181771BC0")]
		public void Render(FireworkPlateModel plateModel, FireworkPlateViewStyle style)
		{
		}

		// Token: 0x0601DEAE RID: 122542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEAE")]
		[Address(RVA = "0x1772190", Offset = "0x1770D90", VA = "0x181772190")]
		public FireworkPlateView()
		{
		}

		// Token: 0x04027B4F RID: 162639
		[Token(Token = "0x4027B4F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _elementContainer;

		// Token: 0x04027B50 RID: 162640
		[Token(Token = "0x4027B50")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FireworkPlateElementView _prefabElementView;

		// Token: 0x04027B51 RID: 162641
		[Token(Token = "0x4027B51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _gridSize;

		// Token: 0x04027B52 RID: 162642
		[Token(Token = "0x4027B52")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _padding;

		// Token: 0x04027B53 RID: 162643
		[Token(Token = "0x4027B53")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgBkgOutline;

		// Token: 0x04027B54 RID: 162644
		[Token(Token = "0x4027B54")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x04027B55 RID: 162645
		[Token(Token = "0x4027B55")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgBkgFront;

		// Token: 0x04027B56 RID: 162646
		[Token(Token = "0x4027B56")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgBkgShadow;

		// Token: 0x04027B57 RID: 162647
		[Token(Token = "0x4027B57")]
		[FieldOffset(Offset = "0x58")]
		private List<FireworkPlateElementView> m_gridElements;

		// Token: 0x04027B58 RID: 162648
		[Token(Token = "0x4027B58")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_tween;

		// Token: 0x04027B59 RID: 162649
		[Token(Token = "0x4027B59")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedLoadSeqNum;

		// Token: 0x04027B5A RID: 162650
		[Token(Token = "0x4027B5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027B5B RID: 162651
		[Token(Token = "0x4027B5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
