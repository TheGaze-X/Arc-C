using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BE1 RID: 7137
	[Token(Token = "0x2001BE1")]
	public class BuildingWorkshopFilterPanelItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B211 RID: 45585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B211")]
		[Address(RVA = "0x32BC260", Offset = "0x32BAE60", VA = "0x1832BC260")]
		public void Render(BuildingWorkshopFilterPanelItem.RenderParam param)
		{
		}

		// Token: 0x0600B212 RID: 45586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B212")]
		[Address(RVA = "0x32BC170", Offset = "0x32BAD70", VA = "0x1832BC170")]
		public void OnClick()
		{
		}

		// Token: 0x0600B213 RID: 45587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B213")]
		[Address(RVA = "0x32BC3D0", Offset = "0x32BAFD0", VA = "0x1832BC3D0")]
		public BuildingWorkshopFilterPanelItem()
		{
		}

		// Token: 0x0400ACAE RID: 44206
		[Token(Token = "0x400ACAE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtNameNormal;

		// Token: 0x0400ACAF RID: 44207
		[Token(Token = "0x400ACAF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtNameSelect;

		// Token: 0x0400ACB0 RID: 44208
		[Token(Token = "0x400ACB0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgStrip;

		// Token: 0x0400ACB1 RID: 44209
		[Token(Token = "0x400ACB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _stateToggle;

		// Token: 0x0400ACB2 RID: 44210
		[Token(Token = "0x400ACB2")]
		[FieldOffset(Offset = "0x38")]
		private int m_index;

		// Token: 0x0400ACB3 RID: 44211
		[Token(Token = "0x400ACB3")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedColorStr;

		// Token: 0x0400ACB4 RID: 44212
		[Token(Token = "0x400ACB4")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400ACB5 RID: 44213
		[Token(Token = "0x400ACB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400ACB6 RID: 44214
		[Token(Token = "0x400ACB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0400ACB7 RID: 44215
		[Token(Token = "0x400ACB7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BE2 RID: 7138
		[Token(Token = "0x2001BE2")]
		public class RenderParam
		{
			// Token: 0x0600B214 RID: 45588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B214")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RenderParam()
			{
			}

			// Token: 0x0400ACB8 RID: 44216
			[Token(Token = "0x400ACB8")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.WorkshopRarityInfo rarityInfo;

			// Token: 0x0400ACB9 RID: 44217
			[Token(Token = "0x400ACB9")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			// Token: 0x0400ACBA RID: 44218
			[Token(Token = "0x400ACBA")]
			[FieldOffset(Offset = "0x1C")]
			public bool isSelect;
		}
	}
}
