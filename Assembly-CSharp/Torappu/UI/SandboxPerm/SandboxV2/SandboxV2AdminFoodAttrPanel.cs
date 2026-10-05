using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004030 RID: 16432
	[Token(Token = "0x2004030")]
	public class SandboxV2AdminFoodAttrPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060196EE RID: 104174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196EE")]
		[Address(RVA = "0x121CF60", Offset = "0x121BB60", VA = "0x18121CF60")]
		public void RenderFoodState(SandboxV2CharFoodModel foodModel, bool isAlreadyFight)
		{
		}

		// Token: 0x060196EF RID: 104175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196EF")]
		[Address(RVA = "0x121D040", Offset = "0x121BC40", VA = "0x18121D040")]
		private void _RenderFoodInfo(SandboxV2CharFoodModel foodModel)
		{
		}

		// Token: 0x060196F0 RID: 104176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196F0")]
		[Address(RVA = "0x121D310", Offset = "0x121BF10", VA = "0x18121D310")]
		public SandboxV2AdminFoodAttrPanel()
		{
		}

		// Token: 0x0401FAC0 RID: 129728
		[Token(Token = "0x401FAC0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _noFoodPart;

		// Token: 0x0401FAC1 RID: 129729
		[Token(Token = "0x401FAC1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hasFoodPart;

		// Token: 0x0401FAC2 RID: 129730
		[Token(Token = "0x401FAC2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _remainTimePart;

		// Token: 0x0401FAC3 RID: 129731
		[Token(Token = "0x401FAC3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _outOfTimePart;

		// Token: 0x0401FAC4 RID: 129732
		[Token(Token = "0x401FAC4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x0401FAC5 RID: 129733
		[Token(Token = "0x401FAC5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _foodName;

		// Token: 0x0401FAC6 RID: 129734
		[Token(Token = "0x401FAC6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _foodPic;

		// Token: 0x0401FAC7 RID: 129735
		[Token(Token = "0x401FAC7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _foodIcon;

		// Token: 0x0401FAC8 RID: 129736
		[Token(Token = "0x401FAC8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _foodUsage;

		// Token: 0x0401FAC9 RID: 129737
		[Token(Token = "0x401FAC9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _alreadyFight;

		// Token: 0x0401FACA RID: 129738
		[Token(Token = "0x401FACA")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401FACB RID: 129739
		[Token(Token = "0x401FACB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderFoodState;

		// Token: 0x0401FACC RID: 129740
		[Token(Token = "0x401FACC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderFoodInfo;

		// Token: 0x0401FACD RID: 129741
		[Token(Token = "0x401FACD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
