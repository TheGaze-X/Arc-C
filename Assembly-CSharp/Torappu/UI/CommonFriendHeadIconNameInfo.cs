using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AB7 RID: 15031
	[Token(Token = "0x2003AB7")]
	public class CommonFriendHeadIconNameInfo : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017BA6 RID: 97190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BA6")]
		[Address(RVA = "0xFE1B10", Offset = "0xFE0710", VA = "0x180FE1B10")]
		public void ApplyFriendData(FriendCommonData data, [Optional] string alias)
		{
		}

		// Token: 0x06017BA7 RID: 97191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BA7")]
		[Address(RVA = "0xFE1BF0", Offset = "0xFE07F0", VA = "0x180FE1BF0")]
		public void ApplySelfData(PlayerStatus data)
		{
		}

		// Token: 0x06017BA8 RID: 97192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BA8")]
		[Address(RVA = "0xFE1E40", Offset = "0xFE0A40", VA = "0x180FE1E40")]
		public void ClearDisplay()
		{
		}

		// Token: 0x06017BA9 RID: 97193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BA9")]
		[Address(RVA = "0xFE2140", Offset = "0xFE0D40", VA = "0x180FE2140")]
		private void _SetNameInfo(string nickName, string nickNumber, int level, string alias)
		{
		}

		// Token: 0x06017BAA RID: 97194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BAA")]
		[Address(RVA = "0xFE2580", Offset = "0xFE1180", VA = "0x180FE2580")]
		private void _SetOnlineStatus(DateTime lastOnlineTime)
		{
		}

		// Token: 0x06017BAB RID: 97195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BAB")]
		[Address(RVA = "0xFE18E0", Offset = "0xFE04E0", VA = "0x180FE18E0")]
		private void ApplyAvatar(AvatarInfo data)
		{
		}

		// Token: 0x06017BAC RID: 97196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BAC")]
		[Address(RVA = "0xFE1D60", Offset = "0xFE0960", VA = "0x180FE1D60")]
		private void ClearAvatar()
		{
		}

		// Token: 0x06017BAD RID: 97197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BAD")]
		[Address(RVA = "0xFE2760", Offset = "0xFE1360", VA = "0x180FE2760")]
		public CommonFriendHeadIconNameInfo()
		{
		}

		// Token: 0x0401CA35 RID: 117301
		[Token(Token = "0x401CA35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("头像相关")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x0401CA36 RID: 117302
		[Token(Token = "0x401CA36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _avatarViewScale;

		// Token: 0x0401CA37 RID: 117303
		[Token(Token = "0x401CA37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("名称相关")]
		[SerializeField]
		private Text _friendName;

		// Token: 0x0401CA38 RID: 117304
		[Token(Token = "0x401CA38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _nameColor;

		// Token: 0x0401CA39 RID: 117305
		[Token(Token = "0x401CA39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _nickNameColor;

		// Token: 0x0401CA3A RID: 117306
		[Token(Token = "0x401CA3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _nickName;

		// Token: 0x0401CA3B RID: 117307
		[Token(Token = "0x401CA3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _level;

		// Token: 0x0401CA3C RID: 117308
		[Token(Token = "0x401CA3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("在线状态")]
		[SerializeField]
		private TwoStateToggle _onlineState;

		// Token: 0x0401CA3D RID: 117309
		[Token(Token = "0x401CA3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _awayTime;

		// Token: 0x0401CA3E RID: 117310
		[Token(Token = "0x401CA3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("其他信息")]
		[SerializeField]
		private Text _aliasName;

		// Token: 0x0401CA3F RID: 117311
		[Token(Token = "0x401CA3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PlayerAvatarView m_currentAvatarView;

		// Token: 0x0401CA40 RID: 117312
		[Token(Token = "0x401CA40")]
		private const string FRIEND_NAME_FORMAT = "<color=#{2}>{0}</color><color=#{3}>#{1}</color>";

		// Token: 0x0401CA41 RID: 117313
		[Token(Token = "0x401CA41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyFriendData;

		// Token: 0x0401CA42 RID: 117314
		[Token(Token = "0x401CA42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplySelfData;

		// Token: 0x0401CA43 RID: 117315
		[Token(Token = "0x401CA43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearDisplay;

		// Token: 0x0401CA44 RID: 117316
		[Token(Token = "0x401CA44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetNameInfo;

		// Token: 0x0401CA45 RID: 117317
		[Token(Token = "0x401CA45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetOnlineStatus;

		// Token: 0x0401CA46 RID: 117318
		[Token(Token = "0x401CA46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyAvatar;

		// Token: 0x0401CA47 RID: 117319
		[Token(Token = "0x401CA47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearAvatar;

		// Token: 0x0401CA48 RID: 117320
		[Token(Token = "0x401CA48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
