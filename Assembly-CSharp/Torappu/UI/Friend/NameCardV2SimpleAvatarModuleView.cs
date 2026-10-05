using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E18 RID: 19992
	[Token(Token = "0x2004E18")]
	public class NameCardV2SimpleAvatarModuleView : NameCardV2BaseFixedModuleView<NameCardV2AvatarModuleModel>
	{
		// Token: 0x0601DDE0 RID: 122336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE0")]
		[Address(RVA = "0x1779960", Offset = "0x1778560", VA = "0x181779960", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2AvatarModuleModel model)
		{
		}

		// Token: 0x0601DDE1 RID: 122337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE1")]
		[Address(RVA = "0x17798D0", Offset = "0x17784D0", VA = "0x1817798D0", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DDE2 RID: 122338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE2")]
		[Address(RVA = "0x1779F10", Offset = "0x1778B10", VA = "0x181779F10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DDE3 RID: 122339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE3")]
		[Address(RVA = "0x1779E80", Offset = "0x1778A80", VA = "0x181779E80")]
		public void OpenAvatarPage()
		{
		}

		// Token: 0x0601DDE4 RID: 122340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE4")]
		[Address(RVA = "0x1779500", Offset = "0x1778100", VA = "0x181779500")]
		public void CopyUid()
		{
		}

		// Token: 0x0601DDE5 RID: 122341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE5")]
		[Address(RVA = "0x17795F0", Offset = "0x17781F0", VA = "0x1817795F0")]
		public void CrossAppShare()
		{
		}

		// Token: 0x0601DDE6 RID: 122342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE6")]
		[Address(RVA = "0x1779760", Offset = "0x1778360", VA = "0x181779760")]
		public void ExtendNameCard()
		{
		}

		// Token: 0x0601DDE7 RID: 122343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE7")]
		[Address(RVA = "0x177A0C0", Offset = "0x1778CC0", VA = "0x18177A0C0")]
		public NameCardV2SimpleAvatarModuleView()
		{
		}

		// Token: 0x0601DDE8 RID: 122344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE8")]
		[Address(RVA = "0x1772BA0", Offset = "0x17717A0", VA = "0x181772BA0")]
		private void <>xLuaBaseProxy_OnApplyStyle(NameCardV2SkinStyle P0)
		{
		}

		// Token: 0x0402797E RID: 162174
		[Token(Token = "0x402797E")]
		private const string DOCTOR_NAME_FORMAT = "{0}#{1}";

		// Token: 0x0402797F RID: 162175
		[Token(Token = "0x402797F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _doctorLevel;

		// Token: 0x04027980 RID: 162176
		[Token(Token = "0x4027980")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _doctorName;

		// Token: 0x04027981 RID: 162177
		[Token(Token = "0x4027981")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _doctorUid;

		// Token: 0x04027982 RID: 162178
		[Token(Token = "0x4027982")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x04027983 RID: 162179
		[Token(Token = "0x4027983")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x04027984 RID: 162180
		[Token(Token = "0x4027984")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _avatarModifyBtn;

		// Token: 0x04027985 RID: 162181
		[Token(Token = "0x4027985")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIColorGraphic _avatarColorGraphic;

		// Token: 0x04027986 RID: 162182
		[Token(Token = "0x4027986")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _copyUidBtn;

		// Token: 0x04027987 RID: 162183
		[Token(Token = "0x4027987")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _crossAppShareBtn;

		// Token: 0x04027988 RID: 162184
		[Token(Token = "0x4027988")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CrossAppShareStartDynAssetContent _avatarContent;

		// Token: 0x04027989 RID: 162185
		[Token(Token = "0x4027989")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0402798A RID: 162186
		[Token(Token = "0x402798A")]
		[FieldOffset(Offset = "0xA8")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0402798B RID: 162187
		[Token(Token = "0x402798B")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedNameCardSkinId;

		// Token: 0x0402798C RID: 162188
		[Token(Token = "0x402798C")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedNameCardSkinTmpl;

		// Token: 0x0402798D RID: 162189
		[Token(Token = "0x402798D")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_isSelfAvatar;

		// Token: 0x0402798E RID: 162190
		[Token(Token = "0x402798E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x0402798F RID: 162191
		[Token(Token = "0x402798F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x04027990 RID: 162192
		[Token(Token = "0x4027990")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027991 RID: 162193
		[Token(Token = "0x4027991")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenAvatarPage;

		// Token: 0x04027992 RID: 162194
		[Token(Token = "0x4027992")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CopyUid;

		// Token: 0x04027993 RID: 162195
		[Token(Token = "0x4027993")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CrossAppShare;

		// Token: 0x04027994 RID: 162196
		[Token(Token = "0x4027994")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ExtendNameCard;

		// Token: 0x04027995 RID: 162197
		[Token(Token = "0x4027995")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
