using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C25 RID: 15397
	[Token(Token = "0x2003C25")]
	public class UniEquipLevelUpBoardPointView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018159 RID: 98649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018159")]
		[Address(RVA = "0x1091750", Offset = "0x1090350", VA = "0x181091750")]
		public void Render(UniEquipLevelUpBoardObjViewModel model)
		{
		}

		// Token: 0x0601815A RID: 98650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601815A")]
		[Address(RVA = "0x1091A80", Offset = "0x1090680", VA = "0x181091A80")]
		private void _ResetTween()
		{
		}

		// Token: 0x0601815B RID: 98651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601815B")]
		[Address(RVA = "0x1091C50", Offset = "0x1090850", VA = "0x181091C50")]
		public UniEquipLevelUpBoardPointView()
		{
		}

		// Token: 0x0401D37B RID: 119675
		[Token(Token = "0x401D37B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _tarObj;

		// Token: 0x0401D37C RID: 119676
		[Token(Token = "0x401D37C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _curObj;

		// Token: 0x0401D37D RID: 119677
		[Token(Token = "0x401D37D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _tarImg;

		// Token: 0x0401D37E RID: 119678
		[Token(Token = "0x401D37E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0401D37F RID: 119679
		[Token(Token = "0x401D37F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _endAlpha;

		// Token: 0x0401D380 RID: 119680
		[Token(Token = "0x401D380")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _startAlpha;

		// Token: 0x0401D381 RID: 119681
		[Token(Token = "0x401D381")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_breatheTween;

		// Token: 0x0401D382 RID: 119682
		[Token(Token = "0x401D382")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D383 RID: 119683
		[Token(Token = "0x401D383")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ResetTween;

		// Token: 0x0401D384 RID: 119684
		[Token(Token = "0x401D384")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
