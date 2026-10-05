using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DF7 RID: 19959
	[Token(Token = "0x2004DF7")]
	public class NameCardV2AvatarModuleView : NameCardV2BaseFixedModuleView<NameCardV2AvatarModuleModel>
	{
		// Token: 0x0601DD46 RID: 122182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD46")]
		[Address(RVA = "0x1759E20", Offset = "0x1758A20", VA = "0x181759E20", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2AvatarModuleModel model)
		{
		}

		// Token: 0x0601DD47 RID: 122183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD47")]
		[Address(RVA = "0x1759D80", Offset = "0x1758980", VA = "0x181759D80", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DD48 RID: 122184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD48")]
		[Address(RVA = "0x175A310", Offset = "0x1758F10", VA = "0x18175A310")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DD49 RID: 122185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD49")]
		[Address(RVA = "0x175A280", Offset = "0x1758E80", VA = "0x18175A280")]
		public void OpenAvatarPage()
		{
		}

		// Token: 0x0601DD4A RID: 122186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD4A")]
		[Address(RVA = "0x1759B20", Offset = "0x1758720", VA = "0x181759B20")]
		public void CopyUid()
		{
		}

		// Token: 0x0601DD4B RID: 122187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD4B")]
		[Address(RVA = "0x1759C10", Offset = "0x1758810", VA = "0x181759C10")]
		public void CrossAppShare()
		{
		}

		// Token: 0x0601DD4C RID: 122188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD4C")]
		[Address(RVA = "0x175A470", Offset = "0x1759070", VA = "0x18175A470")]
		public NameCardV2AvatarModuleView()
		{
		}

		// Token: 0x0601DD4D RID: 122189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD4D")]
		[Address(RVA = "0x1759840", Offset = "0x1758440", VA = "0x181759840")]
		private void <>xLuaBaseProxy_OnApplyStyle(NameCardV2SkinStyle P0)
		{
		}

		// Token: 0x0402785A RID: 161882
		[Token(Token = "0x402785A")]
		private const string DOCTOR_NAME_FORMAT = "{0}#{1}";

		// Token: 0x0402785B RID: 161883
		[Token(Token = "0x402785B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _doctorLevel;

		// Token: 0x0402785C RID: 161884
		[Token(Token = "0x402785C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _doctorName;

		// Token: 0x0402785D RID: 161885
		[Token(Token = "0x402785D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _doctorUid;

		// Token: 0x0402785E RID: 161886
		[Token(Token = "0x402785E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x0402785F RID: 161887
		[Token(Token = "0x402785F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x04027860 RID: 161888
		[Token(Token = "0x4027860")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _avatarModifyBtn;

		// Token: 0x04027861 RID: 161889
		[Token(Token = "0x4027861")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIColorGraphic _avatarColorGraphic;

		// Token: 0x04027862 RID: 161890
		[Token(Token = "0x4027862")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _copyUidBtn;

		// Token: 0x04027863 RID: 161891
		[Token(Token = "0x4027863")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _crossAppShareBtn;

		// Token: 0x04027864 RID: 161892
		[Token(Token = "0x4027864")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CrossAppShareStartDynAssetContent _avatarContent;

		// Token: 0x04027865 RID: 161893
		[Token(Token = "0x4027865")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x04027866 RID: 161894
		[Token(Token = "0x4027866")]
		[FieldOffset(Offset = "0xA8")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04027867 RID: 161895
		[Token(Token = "0x4027867")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedNameCardSkinId;

		// Token: 0x04027868 RID: 161896
		[Token(Token = "0x4027868")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedNameCardSkinTmpl;

		// Token: 0x04027869 RID: 161897
		[Token(Token = "0x4027869")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_isSelfAvatar;

		// Token: 0x0402786A RID: 161898
		[Token(Token = "0x402786A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x0402786B RID: 161899
		[Token(Token = "0x402786B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0402786C RID: 161900
		[Token(Token = "0x402786C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402786D RID: 161901
		[Token(Token = "0x402786D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenAvatarPage;

		// Token: 0x0402786E RID: 161902
		[Token(Token = "0x402786E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CopyUid;

		// Token: 0x0402786F RID: 161903
		[Token(Token = "0x402786F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CrossAppShare;

		// Token: 0x04027870 RID: 161904
		[Token(Token = "0x4027870")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
