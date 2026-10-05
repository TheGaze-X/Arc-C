using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A34 RID: 31284
	[Token(Token = "0x2007A34")]
	public class Act13sideDailySearchOrgItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066CA RID: 26314
		// (get) Token: 0x0602BD5D RID: 179549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD5E RID: 179550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066CA")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x602BD5D")]
			[Address(RVA = "0x27B64A0", Offset = "0x27B50A0", VA = "0x1827B64A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD5E")]
			[Address(RVA = "0x27B6500", Offset = "0x27B5100", VA = "0x1827B6500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BD5F RID: 179551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD5F")]
		[Address(RVA = "0x27B60C0", Offset = "0x27B4CC0", VA = "0x1827B60C0")]
		public void Render(Act13sideDailySearchViewModel searchModel, Act13SideData.OrgData orgData)
		{
		}

		// Token: 0x0602BD60 RID: 179552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD60")]
		[Address(RVA = "0x27B5FA0", Offset = "0x27B4BA0", VA = "0x1827B5FA0")]
		public void OnItemClick()
		{
		}

		// Token: 0x0602BD61 RID: 179553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD61")]
		[Address(RVA = "0x27B6440", Offset = "0x27B5040", VA = "0x1827B6440")]
		public Act13sideDailySearchOrgItemView()
		{
		}

		// Token: 0x0403F72E RID: 259886
		[Token(Token = "0x403F72E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectedBgGo;

		// Token: 0x0403F72F RID: 259887
		[Token(Token = "0x403F72F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalBgGo;

		// Token: 0x0403F730 RID: 259888
		[Token(Token = "0x403F730")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403F731 RID: 259889
		[Token(Token = "0x403F731")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0403F732 RID: 259890
		[Token(Token = "0x403F732")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgLogo;

		// Token: 0x0403F733 RID: 259891
		[Token(Token = "0x403F733")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgTextBg;

		// Token: 0x0403F734 RID: 259892
		[Token(Token = "0x403F734")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textPrestige;

		// Token: 0x0403F735 RID: 259893
		[Token(Token = "0x403F735")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0403F736 RID: 259894
		[Token(Token = "0x403F736")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorNormalText;

		// Token: 0x0403F737 RID: 259895
		[Token(Token = "0x403F737")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorSelected;

		// Token: 0x0403F738 RID: 259896
		[Token(Token = "0x403F738")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorSelectedText;

		// Token: 0x0403F73A RID: 259898
		[Token(Token = "0x403F73A")]
		[FieldOffset(Offset = "0x98")]
		private Act13SideData.OrgData m_orgData;

		// Token: 0x0403F73B RID: 259899
		[Token(Token = "0x403F73B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403F73C RID: 259900
		[Token(Token = "0x403F73C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403F73D RID: 259901
		[Token(Token = "0x403F73D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F73E RID: 259902
		[Token(Token = "0x403F73E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403F73F RID: 259903
		[Token(Token = "0x403F73F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
