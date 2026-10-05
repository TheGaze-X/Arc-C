using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200549A RID: 21658
	[Token(Token = "0x200549A")]
	public class RoguelikeCharSelectAttrController : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FDF0 RID: 130544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF0")]
		[Address(RVA = "0x19F0E40", Offset = "0x19EFA40", VA = "0x1819F0E40")]
		public void Render(RoguelikeCharCardViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x0601FDF1 RID: 130545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF1")]
		[Address(RVA = "0x19F15B0", Offset = "0x19F01B0", VA = "0x1819F15B0")]
		private void _RenderTab(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FDF2 RID: 130546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF2")]
		[Address(RVA = "0x19F13C0", Offset = "0x19EFFC0", VA = "0x1819F13C0")]
		private void _RenderSkillGroup(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FDF3 RID: 130547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF3")]
		[Address(RVA = "0x19F12E0", Offset = "0x19EFEE0", VA = "0x1819F12E0")]
		private void _RenderBranchGroup(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FDF4 RID: 130548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF4")]
		[Address(RVA = "0x19F1910", Offset = "0x19F0510", VA = "0x1819F1910")]
		public RoguelikeCharSelectAttrController()
		{
		}

		// Token: 0x0402AF32 RID: 175922
		[Token(Token = "0x402AF32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402AF33 RID: 175923
		[Token(Token = "0x402AF33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _codeName;

		// Token: 0x0402AF34 RID: 175924
		[Token(Token = "0x402AF34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _evolvePhase;

		// Token: 0x0402AF35 RID: 175925
		[Token(Token = "0x402AF35")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _maxEvolvePhase;

		// Token: 0x0402AF36 RID: 175926
		[Token(Token = "0x402AF36")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _currentLevel;

		// Token: 0x0402AF37 RID: 175927
		[Token(Token = "0x402AF37")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _maxLevel;

		// Token: 0x0402AF38 RID: 175928
		[Token(Token = "0x402AF38")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _maxHp;

		// Token: 0x0402AF39 RID: 175929
		[Token(Token = "0x402AF39")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _atk;

		// Token: 0x0402AF3A RID: 175930
		[Token(Token = "0x402AF3A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _def;

		// Token: 0x0402AF3B RID: 175931
		[Token(Token = "0x402AF3B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _res;

		// Token: 0x0402AF3C RID: 175932
		[Token(Token = "0x402AF3C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _reviveTimeDesc;

		// Token: 0x0402AF3D RID: 175933
		[Token(Token = "0x402AF3D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _cost;

		// Token: 0x0402AF3E RID: 175934
		[Token(Token = "0x402AF3E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _blockNum;

		// Token: 0x0402AF3F RID: 175935
		[Token(Token = "0x402AF3F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _attackSpeedDesc;

		// Token: 0x0402AF40 RID: 175936
		[Token(Token = "0x402AF40")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _evolveLimitText;

		// Token: 0x0402AF41 RID: 175937
		[Token(Token = "0x402AF41")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x0402AF42 RID: 175938
		[Token(Token = "0x402AF42")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeCharSelectSkillGroup _skillGroup;

		// Token: 0x0402AF43 RID: 175939
		[Token(Token = "0x402AF43")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RoguelikeCharSelectBranchGroup _branchGroup;

		// Token: 0x0402AF44 RID: 175940
		[Token(Token = "0x402AF44")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _haveCharPart;

		// Token: 0x0402AF45 RID: 175941
		[Token(Token = "0x402AF45")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _noCharPart;

		// Token: 0x0402AF46 RID: 175942
		[Token(Token = "0x402AF46")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private List<RoguelikeCharSelectAttrTabItem> _tabList;

		// Token: 0x0402AF47 RID: 175943
		[Token(Token = "0x402AF47")]
		[FieldOffset(Offset = "0xC0")]
		private int m_chrInstIdCache;

		// Token: 0x0402AF48 RID: 175944
		[Token(Token = "0x402AF48")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public RoguelikeCharSelectState.RoguelikeCharAttrTabTypeMessage onTabClickEvent;

		// Token: 0x0402AF49 RID: 175945
		[Token(Token = "0x402AF49")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public UIStringEvent onSkillSelectEvent;

		// Token: 0x0402AF4A RID: 175946
		[Token(Token = "0x402AF4A")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public UIStringEvent onBranchSelectEvent;

		// Token: 0x0402AF4B RID: 175947
		[Token(Token = "0x402AF4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AF4C RID: 175948
		[Token(Token = "0x402AF4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderTab;

		// Token: 0x0402AF4D RID: 175949
		[Token(Token = "0x402AF4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSkillGroup;

		// Token: 0x0402AF4E RID: 175950
		[Token(Token = "0x402AF4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderBranchGroup;

		// Token: 0x0402AF4F RID: 175951
		[Token(Token = "0x402AF4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
