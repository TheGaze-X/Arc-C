using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Friend;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F69 RID: 28521
	[Token(Token = "0x2006F69")]
	public class ActMultiV3PhotoSelectNameCardView : UIStylerApplier<NameCardV2SkinStyle>, IHotfixable
	{
		// Token: 0x060287E2 RID: 165858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E2")]
		[Address(RVA = "0x23CE910", Offset = "0x23CD510", VA = "0x1823CE910")]
		public void Render(ActMultiV3PhotoDetailViewModel selectedPhoto)
		{
		}

		// Token: 0x060287E3 RID: 165859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E3")]
		[Address(RVA = "0x23CE750", Offset = "0x23CD350", VA = "0x1823CE750")]
		public void OnApplyFriend()
		{
		}

		// Token: 0x060287E4 RID: 165860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E4")]
		[Address(RVA = "0x23CE880", Offset = "0x23CD480", VA = "0x1823CE880")]
		public void OnCheckNameCard()
		{
		}

		// Token: 0x060287E5 RID: 165861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E5")]
		[Address(RVA = "0x23CE7E0", Offset = "0x23CD3E0", VA = "0x1823CE7E0", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x060287E6 RID: 165862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E6")]
		[Address(RVA = "0x23CED10", Offset = "0x23CD910", VA = "0x1823CED10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287E7 RID: 165863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E7")]
		[Address(RVA = "0x23CEE30", Offset = "0x23CDA30", VA = "0x1823CEE30")]
		public ActMultiV3PhotoSelectNameCardView()
		{
		}

		// Token: 0x040399FE RID: 236030
		[Token(Token = "0x40399FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x040399FF RID: 236031
		[Token(Token = "0x40399FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _doctorLevel;

		// Token: 0x04039A00 RID: 236032
		[Token(Token = "0x4039A00")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _doctorName;

		// Token: 0x04039A01 RID: 236033
		[Token(Token = "0x4039A01")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _doctorUid;

		// Token: 0x04039A02 RID: 236034
		[Token(Token = "0x4039A02")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x04039A03 RID: 236035
		[Token(Token = "0x4039A03")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x04039A04 RID: 236036
		[Token(Token = "0x4039A04")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _applyFriendPart;

		// Token: 0x04039A05 RID: 236037
		[Token(Token = "0x4039A05")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _appliedFriendPart;

		// Token: 0x04039A06 RID: 236038
		[Token(Token = "0x4039A06")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _addedFriendPart;

		// Token: 0x04039A07 RID: 236039
		[Token(Token = "0x4039A07")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIColorGraphic _applyFriendColorGraphic;

		// Token: 0x04039A08 RID: 236040
		[Token(Token = "0x4039A08")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIColorGraphic _checkNameCardColorGraphic;

		// Token: 0x04039A09 RID: 236041
		[Token(Token = "0x4039A09")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _validButtonColor;

		// Token: 0x04039A0A RID: 236042
		[Token(Token = "0x4039A0A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _invalidButtonColor;

		// Token: 0x04039A0B RID: 236043
		[Token(Token = "0x4039A0B")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x04039A0C RID: 236044
		[Token(Token = "0x4039A0C")]
		[FieldOffset(Offset = "0xA0")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04039A0D RID: 236045
		[Token(Token = "0x4039A0D")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039A0E RID: 236046
		[Token(Token = "0x4039A0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039A0F RID: 236047
		[Token(Token = "0x4039A0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyFriend;

		// Token: 0x04039A10 RID: 236048
		[Token(Token = "0x4039A10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCheckNameCard;

		// Token: 0x04039A11 RID: 236049
		[Token(Token = "0x4039A11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x04039A12 RID: 236050
		[Token(Token = "0x4039A12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039A13 RID: 236051
		[Token(Token = "0x4039A13")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
