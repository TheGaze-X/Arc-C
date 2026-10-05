using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073FF RID: 29695
	[Token(Token = "0x20073FF")]
	public class Act3D0GachaBoxItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F07 RID: 171783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F07")]
		[Address(RVA = "0x2589540", Offset = "0x2588140", VA = "0x182589540")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029F08 RID: 171784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F08")]
		[Address(RVA = "0x2589060", Offset = "0x2587C60", VA = "0x182589060")]
		public void Render(Act3D0GachaBoxInfo.Act3D0GachaBoxItemInfo item)
		{
		}

		// Token: 0x06029F09 RID: 171785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F09")]
		[Address(RVA = "0x2589710", Offset = "0x2588310", VA = "0x182589710")]
		private void _OnItemCardClicked(int position)
		{
		}

		// Token: 0x06029F0A RID: 171786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F0A")]
		[Address(RVA = "0x2589800", Offset = "0x2588400", VA = "0x182589800")]
		public Act3D0GachaBoxItemView()
		{
		}

		// Token: 0x0403C19A RID: 246170
		[Token(Token = "0x403C19A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0403C19B RID: 246171
		[Token(Token = "0x403C19B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0403C19C RID: 246172
		[Token(Token = "0x403C19C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScaleFactor;

		// Token: 0x0403C19D RID: 246173
		[Token(Token = "0x403C19D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403C19E RID: 246174
		[Token(Token = "0x403C19E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _outStack;

		// Token: 0x0403C19F RID: 246175
		[Token(Token = "0x403C19F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _replicateFlag;

		// Token: 0x0403C1A0 RID: 246176
		[Token(Token = "0x403C1A0")]
		private const float ANIMATION_ALPHA_SPEED = 8f;

		// Token: 0x0403C1A1 RID: 246177
		[Token(Token = "0x403C1A1")]
		private const float ANIMATION_ANIM_SPEED = 6f;

		// Token: 0x0403C1A2 RID: 246178
		[Token(Token = "0x403C1A2")]
		[FieldOffset(Offset = "0x48")]
		private UIItemCard m_itemCard;

		// Token: 0x0403C1A3 RID: 246179
		[Token(Token = "0x403C1A3")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_cacheTween;

		// Token: 0x0403C1A4 RID: 246180
		[Token(Token = "0x403C1A4")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0403C1A5 RID: 246181
		[Token(Token = "0x403C1A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C1A6 RID: 246182
		[Token(Token = "0x403C1A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C1A7 RID: 246183
		[Token(Token = "0x403C1A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x0403C1A8 RID: 246184
		[Token(Token = "0x403C1A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
