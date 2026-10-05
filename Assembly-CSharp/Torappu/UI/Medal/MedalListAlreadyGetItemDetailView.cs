using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200497C RID: 18812
	[Token(Token = "0x200497C")]
	public class MedalListAlreadyGetItemDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C59F RID: 116127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C59F")]
		[Address(RVA = "0x15CFE20", Offset = "0x15CEA20", VA = "0x1815CFE20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C5A0 RID: 116128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5A0")]
		[Address(RVA = "0x15CF180", Offset = "0x15CDD80", VA = "0x1815CF180")]
		public void ApplyAnimation()
		{
		}

		// Token: 0x0601C5A1 RID: 116129 RVA: 0x000A7F70 File Offset: 0x000A6170
		[Token(Token = "0x601C5A1")]
		[Address(RVA = "0x15CF330", Offset = "0x15CDF30", VA = "0x1815CF330")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x0601C5A2 RID: 116130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5A2")]
		[Address(RVA = "0x15CFCF0", Offset = "0x15CE8F0", VA = "0x1815CFCF0")]
		public void SetToLargeCommon()
		{
		}

		// Token: 0x0601C5A3 RID: 116131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5A3")]
		[Address(RVA = "0x15CFD70", Offset = "0x15CE970", VA = "0x1815CFD70")]
		public void StopAnimation()
		{
		}

		// Token: 0x0601C5A4 RID: 116132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5A4")]
		[Address(RVA = "0x15CF3F0", Offset = "0x15CDFF0", VA = "0x1815CF3F0")]
		public void RenderDetailView(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5A5 RID: 116133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5A5")]
		[Address(RVA = "0x15D0010", Offset = "0x15CEC10", VA = "0x1815D0010")]
		public MedalListAlreadyGetItemDetailView()
		{
		}

		// Token: 0x040251B1 RID: 151985
		[Token(Token = "0x40251B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _scaler;

		// Token: 0x040251B2 RID: 151986
		[Token(Token = "0x40251B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rewardPart;

		// Token: 0x040251B3 RID: 151987
		[Token(Token = "0x40251B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x040251B4 RID: 151988
		[Token(Token = "0x40251B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x040251B5 RID: 151989
		[Token(Token = "0x40251B5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _preObj;

		// Token: 0x040251B6 RID: 151990
		[Token(Token = "0x40251B6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _getMethodText;

		// Token: 0x040251B7 RID: 151991
		[Token(Token = "0x40251B7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040251B8 RID: 151992
		[Token(Token = "0x40251B8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MedalAdvanceCommonView _advancedView;

		// Token: 0x040251B9 RID: 151993
		[Token(Token = "0x40251B9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _advancedIcon;

		// Token: 0x040251BA RID: 151994
		[Token(Token = "0x40251BA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _hasAdvancedIcon;

		// Token: 0x040251BB RID: 151995
		[Token(Token = "0x40251BB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040251BC RID: 151996
		[Token(Token = "0x40251BC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _getTime;

		// Token: 0x040251BD RID: 151997
		[Token(Token = "0x40251BD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _name;

		// Token: 0x040251BE RID: 151998
		[Token(Token = "0x40251BE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _description;

		// Token: 0x040251BF RID: 151999
		[Token(Token = "0x40251BF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x040251C0 RID: 152000
		[Token(Token = "0x40251C0")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public UIStringEvent toTargetMedal;

		// Token: 0x040251C1 RID: 152001
		[Token(Token = "0x40251C1")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x040251C2 RID: 152002
		[Token(Token = "0x40251C2")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemCard m_itemCard;

		// Token: 0x040251C3 RID: 152003
		[Token(Token = "0x40251C3")]
		[FieldOffset(Offset = "0xA8")]
		private MedalLittleAdapter m_adapter;

		// Token: 0x040251C4 RID: 152004
		[Token(Token = "0x40251C4")]
		private const string ANIMATION_PARAM_DOWN = "enlarge_already_get_down";

		// Token: 0x040251C5 RID: 152005
		[Token(Token = "0x40251C5")]
		private const string ANIMATION_PARAM_UP = "enlarge_already_get_up";

		// Token: 0x040251C6 RID: 152006
		[Token(Token = "0x40251C6")]
		private const string LARGE_COMMON = "large_common";

		// Token: 0x040251C7 RID: 152007
		[Token(Token = "0x40251C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040251C8 RID: 152008
		[Token(Token = "0x40251C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyAnimation;

		// Token: 0x040251C9 RID: 152009
		[Token(Token = "0x40251C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsPlaying;

		// Token: 0x040251CA RID: 152010
		[Token(Token = "0x40251CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetToLargeCommon;

		// Token: 0x040251CB RID: 152011
		[Token(Token = "0x40251CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StopAnimation;

		// Token: 0x040251CC RID: 152012
		[Token(Token = "0x40251CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderDetailView;

		// Token: 0x040251CD RID: 152013
		[Token(Token = "0x40251CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
