using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C26 RID: 15398
	[Token(Token = "0x2003C26")]
	public class UniEquipLevelUpBoardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601815E RID: 98654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601815E")]
		[Address(RVA = "0x1091D90", Offset = "0x1090990", VA = "0x181091D90")]
		public void Render(UniEquipLevelUpBoardObjViewModel model)
		{
		}

		// Token: 0x0601815F RID: 98655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601815F")]
		[Address(RVA = "0x1091CB0", Offset = "0x10908B0", VA = "0x181091CB0")]
		public void EventOnSelectTargetLevel()
		{
		}

		// Token: 0x06018160 RID: 98656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018160")]
		[Address(RVA = "0x10924C0", Offset = "0x10910C0", VA = "0x1810924C0")]
		public UniEquipLevelUpBoardView()
		{
		}

		// Token: 0x0401D385 RID: 119685
		[Token(Token = "0x401D385")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _arrow;

		// Token: 0x0401D386 RID: 119686
		[Token(Token = "0x401D386")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _targetNextArrow;

		// Token: 0x0401D387 RID: 119687
		[Token(Token = "0x401D387")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _levelImage;

		// Token: 0x0401D388 RID: 119688
		[Token(Token = "0x401D388")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Sprite> _stageSprites;

		// Token: 0x0401D389 RID: 119689
		[Token(Token = "0x401D389")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _selectTargetLight;

		// Token: 0x0401D38A RID: 119690
		[Token(Token = "0x401D38A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _arrowBtn;

		// Token: 0x0401D38B RID: 119691
		[Token(Token = "0x401D38B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _boardBtn;

		// Token: 0x0401D38C RID: 119692
		[Token(Token = "0x401D38C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _targetLevelImageColor;

		// Token: 0x0401D38D RID: 119693
		[Token(Token = "0x401D38D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _notTargetLevelImageColor;

		// Token: 0x0401D38E RID: 119694
		[Token(Token = "0x401D38E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UniEquipLevelUpNormalInfoView _basicInfoView;

		// Token: 0x0401D38F RID: 119695
		[Token(Token = "0x401D38F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UniEquipLevelUpSubProfessionView _subProfessionView;

		// Token: 0x0401D390 RID: 119696
		[Token(Token = "0x401D390")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UniEquipLevelUpNormalInfoView _talentView;

		// Token: 0x0401D391 RID: 119697
		[Token(Token = "0x401D391")]
		[FieldOffset(Offset = "0x88")]
		private bool m_boardLevelIsCur;

		// Token: 0x0401D392 RID: 119698
		[Token(Token = "0x401D392")]
		[FieldOffset(Offset = "0x8C")]
		private int m_boardLevel;

		// Token: 0x0401D393 RID: 119699
		[Token(Token = "0x401D393")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D394 RID: 119700
		[Token(Token = "0x401D394")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D395 RID: 119701
		[Token(Token = "0x401D395")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnSelectTargetLevel;

		// Token: 0x0401D396 RID: 119702
		[Token(Token = "0x401D396")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
