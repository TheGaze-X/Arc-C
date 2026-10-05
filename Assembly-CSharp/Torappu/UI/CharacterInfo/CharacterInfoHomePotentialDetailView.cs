using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F81 RID: 24449
	[Token(Token = "0x2005F81")]
	public class CharacterInfoHomePotentialDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060235FE RID: 144894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235FE")]
		[Address(RVA = "0x1DFF720", Offset = "0x1DFE320", VA = "0x181DFF720")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060235FF RID: 144895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235FF")]
		[Address(RVA = "0x1DFF270", Offset = "0x1DFDE70", VA = "0x181DFF270")]
		public void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x06023600 RID: 144896 RVA: 0x000C0A98 File Offset: 0x000BEC98
		[Token(Token = "0x6023600")]
		[Address(RVA = "0x1DFF180", Offset = "0x1DFDD80", VA = "0x181DFF180")]
		public float CalcAndApplyHeight()
		{
			return 0f;
		}

		// Token: 0x06023601 RID: 144897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023601")]
		[Address(RVA = "0x1DFF830", Offset = "0x1DFE430", VA = "0x181DFF830")]
		private void _ShowPotentialItem(UIItemViewModel cardModel)
		{
		}

		// Token: 0x06023602 RID: 144898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023602")]
		[Address(RVA = "0x1DFF9F0", Offset = "0x1DFE5F0", VA = "0x181DFF9F0")]
		public CharacterInfoHomePotentialDetailView()
		{
		}

		// Token: 0x04030DC1 RID: 200129
		[Token(Token = "0x4030DC1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _spriteIcon;

		// Token: 0x04030DC2 RID: 200130
		[Token(Token = "0x4030DC2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _baseHeight;

		// Token: 0x04030DC3 RID: 200131
		[Token(Token = "0x4030DC3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04030DC4 RID: 200132
		[Token(Token = "0x4030DC4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04030DC5 RID: 200133
		[Token(Token = "0x4030DC5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04030DC6 RID: 200134
		[Token(Token = "0x4030DC6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _switchPotentialItemGroup;

		// Token: 0x04030DC7 RID: 200135
		[Token(Token = "0x4030DC7")]
		[FieldOffset(Offset = "0x48")]
		private CharacterInfoHomePotentialDetailView.Adapter m_adater;

		// Token: 0x04030DC8 RID: 200136
		[Token(Token = "0x4030DC8")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04030DC9 RID: 200137
		[Token(Token = "0x4030DC9")]
		[FieldOffset(Offset = "0x58")]
		private string m_cacheDetail;

		// Token: 0x04030DCA RID: 200138
		[Token(Token = "0x4030DCA")]
		[FieldOffset(Offset = "0x60")]
		private TextGenerator m_textGenerate;

		// Token: 0x04030DCB RID: 200139
		[Token(Token = "0x4030DCB")]
		[FieldOffset(Offset = "0x68")]
		private CharacterInfoHolderBean.CharViewModel m_charViewModel;

		// Token: 0x04030DCC RID: 200140
		[Token(Token = "0x4030DCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030DCD RID: 200141
		[Token(Token = "0x4030DCD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DCE RID: 200142
		[Token(Token = "0x4030DCE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalcAndApplyHeight;

		// Token: 0x04030DCF RID: 200143
		[Token(Token = "0x4030DCF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowPotentialItem;

		// Token: 0x04030DD0 RID: 200144
		[Token(Token = "0x4030DD0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F82 RID: 24450
		[Token(Token = "0x2005F82")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005390 RID: 21392
			// (get) Token: 0x06023603 RID: 144899 RVA: 0x000C0AB0 File Offset: 0x000BECB0
			[Token(Token = "0x17005390")]
			public override int count
			{
				[Token(Token = "0x6023603")]
				[Address(RVA = "0x1DFDE70", Offset = "0x1DFCA70", VA = "0x181DFDE70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023604 RID: 144900 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023604")]
			[Address(RVA = "0x1DFDAB0", Offset = "0x1DFC6B0", VA = "0x181DFDAB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023605 RID: 144901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023605")]
			[Address(RVA = "0x1DFDD90", Offset = "0x1DFC990", VA = "0x181DFDD90")]
			public Adapter()
			{
			}

			// Token: 0x04030DD1 RID: 200145
			[Token(Token = "0x4030DD1")]
			[FieldOffset(Offset = "0x20")]
			public List<string> strList;

			// Token: 0x04030DD2 RID: 200146
			[Token(Token = "0x4030DD2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030DD3 RID: 200147
			[Token(Token = "0x4030DD3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030DD4 RID: 200148
			[Token(Token = "0x4030DD4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
