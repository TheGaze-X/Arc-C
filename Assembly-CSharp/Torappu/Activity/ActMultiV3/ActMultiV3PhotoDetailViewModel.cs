using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F73 RID: 28531
	[Token(Token = "0x2006F73")]
	public class ActMultiV3PhotoDetailViewModel : IHotfixable
	{
		// Token: 0x06028813 RID: 165907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028813")]
		[Address(RVA = "0x23CDE00", Offset = "0x23CCA00", VA = "0x1823CDE00")]
		public void LoadData(string actId, string instId, PlayerActivity.PlayerMultiV3Activity.PhotoInstance photo, ActMultiV3PhotoTypeData photoTypeData)
		{
		}

		// Token: 0x06028814 RID: 165908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028814")]
		[Address(RVA = "0x23CE5A0", Offset = "0x23CD1A0", VA = "0x1823CE5A0")]
		private string _LoadTitle(string titleId, Dictionary<string, ActMultiV3TitleData> titleDataDict)
		{
			return null;
		}

		// Token: 0x06028815 RID: 165909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028815")]
		[Address(RVA = "0x23CE340", Offset = "0x23CCF40", VA = "0x1823CE340")]
		private void _LoadStageDesc(ActMultiV3Data actData, string stageId)
		{
		}

		// Token: 0x06028816 RID: 165910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028816")]
		[Address(RVA = "0x23CE690", Offset = "0x23CD290", VA = "0x1823CE690")]
		public ActMultiV3PhotoDetailViewModel()
		{
		}

		// Token: 0x04039A87 RID: 236167
		[Token(Token = "0x4039A87")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04039A88 RID: 236168
		[Token(Token = "0x4039A88")]
		[FieldOffset(Offset = "0x18")]
		public FriendStatus friendStatus;

		// Token: 0x04039A89 RID: 236169
		[Token(Token = "0x4039A89")]
		[FieldOffset(Offset = "0x20")]
		public string skinId;

		// Token: 0x04039A8A RID: 236170
		[Token(Token = "0x4039A8A")]
		[FieldOffset(Offset = "0x28")]
		public int skinTmpl;

		// Token: 0x04039A8B RID: 236171
		[Token(Token = "0x4039A8B")]
		[FieldOffset(Offset = "0x30")]
		public string fullNickName;

		// Token: 0x04039A8C RID: 236172
		[Token(Token = "0x4039A8C")]
		[FieldOffset(Offset = "0x38")]
		public int level;

		// Token: 0x04039A8D RID: 236173
		[Token(Token = "0x4039A8D")]
		[FieldOffset(Offset = "0x40")]
		public string uid;

		// Token: 0x04039A8E RID: 236174
		[Token(Token = "0x4039A8E")]
		[FieldOffset(Offset = "0x48")]
		public bool sameChannel;

		// Token: 0x04039A8F RID: 236175
		[Token(Token = "0x4039A8F")]
		[FieldOffset(Offset = "0x50")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04039A90 RID: 236176
		[Token(Token = "0x4039A90")]
		[FieldOffset(Offset = "0x68")]
		public string mateTitlePrefix;

		// Token: 0x04039A91 RID: 236177
		[Token(Token = "0x4039A91")]
		[FieldOffset(Offset = "0x70")]
		public string mateTitleSuffix;

		// Token: 0x04039A92 RID: 236178
		[Token(Token = "0x4039A92")]
		[FieldOffset(Offset = "0x78")]
		public bool hasTrackPoint;

		// Token: 0x04039A93 RID: 236179
		[Token(Token = "0x4039A93")]
		[FieldOffset(Offset = "0x80")]
		public string photoInstId;

		// Token: 0x04039A94 RID: 236180
		[Token(Token = "0x4039A94")]
		[FieldOffset(Offset = "0x88")]
		public string stageName;

		// Token: 0x04039A95 RID: 236181
		[Token(Token = "0x4039A95")]
		[FieldOffset(Offset = "0x90")]
		public string stageDifficultyName;

		// Token: 0x04039A96 RID: 236182
		[Token(Token = "0x4039A96")]
		[FieldOffset(Offset = "0x98")]
		public string stageModeName;

		// Token: 0x04039A97 RID: 236183
		[Token(Token = "0x4039A97")]
		[FieldOffset(Offset = "0xA0")]
		public string mineTitlePrefix;

		// Token: 0x04039A98 RID: 236184
		[Token(Token = "0x4039A98")]
		[FieldOffset(Offset = "0xA8")]
		public string mineTitleSuffix;

		// Token: 0x04039A99 RID: 236185
		[Token(Token = "0x4039A99")]
		[FieldOffset(Offset = "0xB0")]
		public long ts;

		// Token: 0x04039A9A RID: 236186
		[Token(Token = "0x4039A9A")]
		[FieldOffset(Offset = "0xB8")]
		public List<ActMultiV3PhotoCharViewModel> charModels;

		// Token: 0x04039A9B RID: 236187
		[Token(Token = "0x4039A9B")]
		[FieldOffset(Offset = "0xC0")]
		public bool isCommitted;

		// Token: 0x04039A9C RID: 236188
		[Token(Token = "0x4039A9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039A9D RID: 236189
		[Token(Token = "0x4039A9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadTitle;

		// Token: 0x04039A9E RID: 236190
		[Token(Token = "0x4039A9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadStageDesc;

		// Token: 0x04039A9F RID: 236191
		[Token(Token = "0x4039A9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
