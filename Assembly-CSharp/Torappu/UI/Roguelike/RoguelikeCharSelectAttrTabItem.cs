using System;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200549B RID: 21659
	[Token(Token = "0x200549B")]
	[RequireComponent(typeof(TwoStateToggle))]
	public class RoguelikeCharSelectAttrTabItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FDF5 RID: 130549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF5")]
		[Address(RVA = "0x19F1B30", Offset = "0x19F0730", VA = "0x1819F1B30")]
		private void _InitIfNot(RoguelikeCharSelectState.RoguelikeCharAttrTabTypeMessage onTabClick)
		{
		}

		// Token: 0x0601FDF6 RID: 130550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF6")]
		[Address(RVA = "0x19F1980", Offset = "0x19F0580", VA = "0x1819F1980")]
		public void RenderType(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectState.RoguelikeCharAttrTabTypeMessage onTabClick)
		{
		}

		// Token: 0x0601FDF7 RID: 130551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF7")]
		[Address(RVA = "0x19F1C50", Offset = "0x19F0850", VA = "0x1819F1C50")]
		private void _OnToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x17004AB7 RID: 19127
		// (get) Token: 0x0601FDF8 RID: 130552 RVA: 0x000B3A30 File Offset: 0x000B1C30
		[Token(Token = "0x17004AB7")]
		public CharAttrTabType attrTabType
		{
			[Token(Token = "0x601FDF8")]
			[Address(RVA = "0x19F1D40", Offset = "0x19F0940", VA = "0x1819F1D40")]
			get
			{
				return CharAttrTabType.SKILL;
			}
		}

		// Token: 0x0601FDF9 RID: 130553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDF9")]
		[Address(RVA = "0x19F1CE0", Offset = "0x19F08E0", VA = "0x1819F1CE0")]
		public RoguelikeCharSelectAttrTabItem()
		{
		}

		// Token: 0x0402AF50 RID: 175952
		[Token(Token = "0x402AF50")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharAttrTabType _tabType;

		// Token: 0x0402AF51 RID: 175953
		[Token(Token = "0x402AF51")]
		[FieldOffset(Offset = "0x20")]
		private RoguelikeCharSelectState.RoguelikeCharAttrTabTypeMessage m_onSortTypeChanged;

		// Token: 0x0402AF52 RID: 175954
		[Token(Token = "0x402AF52")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0402AF53 RID: 175955
		[Token(Token = "0x402AF53")]
		[FieldOffset(Offset = "0x30")]
		private TwoStateToggle m_twoStateToggle;

		// Token: 0x0402AF54 RID: 175956
		[Token(Token = "0x402AF54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AF55 RID: 175957
		[Token(Token = "0x402AF55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderType;

		// Token: 0x0402AF56 RID: 175958
		[Token(Token = "0x402AF56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnToggle;

		// Token: 0x0402AF57 RID: 175959
		[Token(Token = "0x402AF57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_attrTabType;

		// Token: 0x0402AF58 RID: 175960
		[Token(Token = "0x402AF58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
