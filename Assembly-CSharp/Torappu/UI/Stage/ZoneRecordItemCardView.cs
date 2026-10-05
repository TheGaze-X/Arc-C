using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069C9 RID: 27081
	[Token(Token = "0x20069C9")]
	public class ZoneRecordItemCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B73 RID: 23411
		// (set) Token: 0x06026BF7 RID: 158711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B73")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x6026BF7")]
			[Address(RVA = "0x21E0470", Offset = "0x21DF070", VA = "0x1821E0470")]
			set
			{
			}
		}

		// Token: 0x17005B74 RID: 23412
		// (get) Token: 0x06026BF8 RID: 158712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B74")]
		public UIItemCard itemCard
		{
			[Token(Token = "0x6026BF8")]
			[Address(RVA = "0x21E0220", Offset = "0x21DEE20", VA = "0x1821E0220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B75 RID: 23413
		// (get) Token: 0x06026BF9 RID: 158713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B75")]
		public UIScaler itemCardScaler
		{
			[Token(Token = "0x6026BF9")]
			[Address(RVA = "0x21E01C0", Offset = "0x21DEDC0", VA = "0x1821E01C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B76 RID: 23414
		// (get) Token: 0x06026BFA RID: 158714 RVA: 0x000CC2D0 File Offset: 0x000CA4D0
		// (set) Token: 0x06026BFB RID: 158715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B76")]
		public bool isShowLimitPart
		{
			[Token(Token = "0x6026BFA")]
			[Address(RVA = "0x21E0160", Offset = "0x21DED60", VA = "0x1821E0160")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6026BFB")]
			[Address(RVA = "0x21E0300", Offset = "0x21DEF00", VA = "0x1821E0300")]
			set
			{
			}
		}

		// Token: 0x17005B77 RID: 23415
		// (get) Token: 0x06026BFC RID: 158716 RVA: 0x000CC2E8 File Offset: 0x000CA4E8
		// (set) Token: 0x06026BFD RID: 158717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B77")]
		public bool isShowLeftTime
		{
			[Token(Token = "0x6026BFC")]
			[Address(RVA = "0x21E0100", Offset = "0x21DED00", VA = "0x1821E0100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6026BFD")]
			[Address(RVA = "0x21E0280", Offset = "0x21DEE80", VA = "0x1821E0280")]
			set
			{
			}
		}

		// Token: 0x06026BFE RID: 158718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BFE")]
		[Address(RVA = "0x21DF8C0", Offset = "0x21DE4C0", VA = "0x1821DF8C0")]
		public void Render(int index, UIItemViewModel viewModel, Color mainColor)
		{
		}

		// Token: 0x06026BFF RID: 158719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BFF")]
		[Address(RVA = "0x21DFC00", Offset = "0x21DE800", VA = "0x1821DFC00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026C00 RID: 158720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C00")]
		[Address(RVA = "0x21DFF90", Offset = "0x21DEB90", VA = "0x1821DFF90")]
		private void _UpdateLimitPart()
		{
		}

		// Token: 0x06026C01 RID: 158721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C01")]
		[Address(RVA = "0x21DFDA0", Offset = "0x21DE9A0", VA = "0x1821DFDA0")]
		private void _UpdateLeftTime()
		{
		}

		// Token: 0x06026C02 RID: 158722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C02")]
		[Address(RVA = "0x21E00A0", Offset = "0x21DECA0", VA = "0x1821E00A0")]
		public ZoneRecordItemCardView()
		{
		}

		// Token: 0x04036B86 RID: 224134
		[Token(Token = "0x4036B86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x04036B87 RID: 224135
		[Token(Token = "0x4036B87")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLimit;

		// Token: 0x04036B88 RID: 224136
		[Token(Token = "0x4036B88")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLeftTime;

		// Token: 0x04036B89 RID: 224137
		[Token(Token = "0x4036B89")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLeftTime;

		// Token: 0x04036B8A RID: 224138
		[Token(Token = "0x4036B8A")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04036B8B RID: 224139
		[Token(Token = "0x4036B8B")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isLimitItem;

		// Token: 0x04036B8C RID: 224140
		[Token(Token = "0x4036B8C")]
		[FieldOffset(Offset = "0x3A")]
		private bool m_showLimitPart;

		// Token: 0x04036B8D RID: 224141
		[Token(Token = "0x4036B8D")]
		[FieldOffset(Offset = "0x3B")]
		private bool m_showLeftTime;

		// Token: 0x04036B8E RID: 224142
		[Token(Token = "0x4036B8E")]
		[FieldOffset(Offset = "0x40")]
		private long m_startTs;

		// Token: 0x04036B8F RID: 224143
		[Token(Token = "0x4036B8F")]
		[FieldOffset(Offset = "0x48")]
		private long m_endTs;

		// Token: 0x04036B90 RID: 224144
		[Token(Token = "0x4036B90")]
		[FieldOffset(Offset = "0x50")]
		private UIItemViewModel m_cachedViewModel;

		// Token: 0x04036B91 RID: 224145
		[Token(Token = "0x4036B91")]
		[FieldOffset(Offset = "0x58")]
		private UIItemCard m_itemCardView;

		// Token: 0x04036B92 RID: 224146
		[Token(Token = "0x4036B92")]
		[FieldOffset(Offset = "0x60")]
		private UIScaler m_itemCardScaler;

		// Token: 0x04036B93 RID: 224147
		[Token(Token = "0x4036B93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x04036B94 RID: 224148
		[Token(Token = "0x4036B94")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemCard;

		// Token: 0x04036B95 RID: 224149
		[Token(Token = "0x4036B95")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemCardScaler;

		// Token: 0x04036B96 RID: 224150
		[Token(Token = "0x4036B96")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isShowLimitPart;

		// Token: 0x04036B97 RID: 224151
		[Token(Token = "0x4036B97")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_isShowLimitPart;

		// Token: 0x04036B98 RID: 224152
		[Token(Token = "0x4036B98")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isShowLeftTime;

		// Token: 0x04036B99 RID: 224153
		[Token(Token = "0x4036B99")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_isShowLeftTime;

		// Token: 0x04036B9A RID: 224154
		[Token(Token = "0x4036B9A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036B9B RID: 224155
		[Token(Token = "0x4036B9B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036B9C RID: 224156
		[Token(Token = "0x4036B9C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateLimitPart;

		// Token: 0x04036B9D RID: 224157
		[Token(Token = "0x4036B9D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateLeftTime;

		// Token: 0x04036B9E RID: 224158
		[Token(Token = "0x4036B9E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
