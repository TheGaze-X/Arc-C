using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E75 RID: 20085
	[Token(Token = "0x2004E75")]
	public class FireworkCraftAnimalSelectAnimalView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DFA0 RID: 122784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFA0")]
		[Address(RVA = "0x179A0C0", Offset = "0x1798CC0", VA = "0x18179A0C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DFA1 RID: 122785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFA1")]
		[Address(RVA = "0x1799E20", Offset = "0x1798A20", VA = "0x181799E20")]
		public void Render(FireworkCraftAnimalViewModel animalViewModel, FireworkCraftAnimalSelectViewModel animalSelectViewModel)
		{
		}

		// Token: 0x0601DFA2 RID: 122786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFA2")]
		[Address(RVA = "0x1799D20", Offset = "0x1798920", VA = "0x181799D20")]
		public void OnClick()
		{
		}

		// Token: 0x0601DFA3 RID: 122787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFA3")]
		[Address(RVA = "0x179A300", Offset = "0x1798F00", VA = "0x18179A300")]
		public FireworkCraftAnimalSelectAnimalView()
		{
		}

		// Token: 0x04027CFE RID: 163070
		[Token(Token = "0x4027CFE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlNormal;

		// Token: 0x04027CFF RID: 163071
		[Token(Token = "0x4027CFF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlEquiped;

		// Token: 0x04027D00 RID: 163072
		[Token(Token = "0x4027D00")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x04027D01 RID: 163073
		[Token(Token = "0x4027D01")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlSelected;

		// Token: 0x04027D02 RID: 163074
		[Token(Token = "0x4027D02")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlNew;

		// Token: 0x04027D03 RID: 163075
		[Token(Token = "0x4027D03")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x04027D04 RID: 163076
		[Token(Token = "0x4027D04")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlSelectedHighlight1;

		// Token: 0x04027D05 RID: 163077
		[Token(Token = "0x4027D05")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlSelectedHighlight2;

		// Token: 0x04027D06 RID: 163078
		[Token(Token = "0x4027D06")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _animEquipedMarkShow;

		// Token: 0x04027D07 RID: 163079
		[Token(Token = "0x4027D07")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedAnimalId;

		// Token: 0x04027D08 RID: 163080
		[Token(Token = "0x4027D08")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027D09 RID: 163081
		[Token(Token = "0x4027D09")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_equipedMarkShowTween;

		// Token: 0x04027D0A RID: 163082
		[Token(Token = "0x4027D0A")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x04027D0B RID: 163083
		[Token(Token = "0x4027D0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027D0C RID: 163084
		[Token(Token = "0x4027D0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027D0D RID: 163085
		[Token(Token = "0x4027D0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04027D0E RID: 163086
		[Token(Token = "0x4027D0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
