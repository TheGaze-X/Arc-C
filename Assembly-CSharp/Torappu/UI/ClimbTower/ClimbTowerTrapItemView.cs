using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CF3 RID: 23795
	[Token(Token = "0x2005CF3")]
	public class ClimbTowerTrapItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005105 RID: 20741
		// (get) Token: 0x06022731 RID: 141105 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022732 RID: 141106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005105")]
		public UIPage page
		{
			[Token(Token = "0x6022731")]
			[Address(RVA = "0x1D0FB80", Offset = "0x1D0E780", VA = "0x181D0FB80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022732")]
			[Address(RVA = "0x1D0FBE0", Offset = "0x1D0E7E0", VA = "0x181D0FBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022733 RID: 141107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022733")]
		[Address(RVA = "0x1D0F4E0", Offset = "0x1D0E0E0", VA = "0x181D0F4E0")]
		public void Render(ClimbTowerTrapViewModel trapViewModel)
		{
		}

		// Token: 0x06022734 RID: 141108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022734")]
		[Address(RVA = "0x1D0F700", Offset = "0x1D0E300", VA = "0x181D0F700")]
		private void _RenderViewWithType(ClimbTowerTrapViewModel trapViewModel)
		{
		}

		// Token: 0x06022735 RID: 141109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022735")]
		[Address(RVA = "0x1D0FB20", Offset = "0x1D0E720", VA = "0x181D0FB20")]
		public ClimbTowerTrapItemView()
		{
		}

		// Token: 0x0402F5A6 RID: 193958
		[Token(Token = "0x402F5A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402F5A7 RID: 193959
		[Token(Token = "0x402F5A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402F5A8 RID: 193960
		[Token(Token = "0x402F5A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F5A9 RID: 193961
		[Token(Token = "0x402F5A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgTrapBkg;

		// Token: 0x0402F5AA RID: 193962
		[Token(Token = "0x402F5AA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelArrow;

		// Token: 0x0402F5AB RID: 193963
		[Token(Token = "0x402F5AB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgNameBkg;

		// Token: 0x0402F5AC RID: 193964
		[Token(Token = "0x402F5AC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("UIAtlas")]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402F5AD RID: 193965
		[Token(Token = "0x402F5AD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("UIAtlas")]
		private string _mainCardBkgId;

		// Token: 0x0402F5AE RID: 193966
		[Token(Token = "0x402F5AE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("UIAtlas")]
		private string _subCardBkgId;

		// Token: 0x0402F5AF RID: 193967
		[Token(Token = "0x402F5AF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("UIAtlas")]
		private string _subCardEmptyBkgId;

		// Token: 0x0402F5B0 RID: 193968
		[Token(Token = "0x402F5B0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("UIAtlas")]
		private string _curseCardBkgId;

		// Token: 0x0402F5B1 RID: 193969
		[Token(Token = "0x402F5B1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("UIAtlas")]
		private string _trapCardBkgId;

		// Token: 0x0402F5B2 RID: 193970
		[Token(Token = "0x402F5B2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("UIAtlas")]
		private string _nameNormalBkgId;

		// Token: 0x0402F5B3 RID: 193971
		[Token(Token = "0x402F5B3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("UIAtlas")]
		private string _nameEmptyBkgId;

		// Token: 0x0402F5B4 RID: 193972
		[Token(Token = "0x402F5B4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("UIAtlas")]
		private string _nameCurseBkgId;

		// Token: 0x0402F5B6 RID: 193974
		[Token(Token = "0x402F5B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F5B7 RID: 193975
		[Token(Token = "0x402F5B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F5B8 RID: 193976
		[Token(Token = "0x402F5B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F5B9 RID: 193977
		[Token(Token = "0x402F5B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderViewWithType;

		// Token: 0x0402F5BA RID: 193978
		[Token(Token = "0x402F5BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
