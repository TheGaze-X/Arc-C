using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AEB RID: 15083
	[Token(Token = "0x2003AEB")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class PlayerAvatarUtil
	{
		// Token: 0x06017C6C RID: 97388 RVA: 0x000981C0 File Offset: 0x000963C0
		[Token(Token = "0x6017C6C")]
		[Address(RVA = "0x1002990", Offset = "0x1001590", VA = "0x181002990")]
		public static bool IsAssistantType(PlayerAvatarType avatarType)
		{
			return default(bool);
		}

		// Token: 0x06017C6D RID: 97389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C6D")]
		[Address(RVA = "0x1002710", Offset = "0x1001310", VA = "0x181002710")]
		public static Sprite GetAvatarIcon(AvatarInfo avatarInfo, [Optional] string pageName)
		{
			return null;
		}

		// Token: 0x06017C6E RID: 97390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C6E")]
		[Address(RVA = "0x10024C0", Offset = "0x10010C0", VA = "0x1810024C0")]
		public static Sprite GetAvatarIcon(string avatarId, PlayerAvatarType avatarType, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06017C6F RID: 97391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C6F")]
		[Address(RVA = "0x10025A0", Offset = "0x10011A0", VA = "0x1810025A0")]
		public static Sprite GetAvatarIcon(AvatarInfo avatarInfo, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06017C70 RID: 97392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C70")]
		[Address(RVA = "0x1002300", Offset = "0x1000F00", VA = "0x181002300")]
		public static Sprite GetAvatarIconByAvatarData(string avatarId, PlayerAvatarGroupType groupType, [Optional] string pageName)
		{
			return null;
		}

		// Token: 0x06017C71 RID: 97393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C71")]
		[Address(RVA = "0x10023E0", Offset = "0x1000FE0", VA = "0x1810023E0")]
		public static Sprite GetAvatarIconByAvatarData(string avatarId, PlayerAvatarGroupType groupType, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06017C72 RID: 97394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C72")]
		[Address(RVA = "0x10021E0", Offset = "0x1000DE0", VA = "0x1810021E0")]
		public static string GetAssistantName()
		{
			return null;
		}

		// Token: 0x06017C73 RID: 97395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C73")]
		[Address(RVA = "0x1002880", Offset = "0x1001480", VA = "0x181002880")]
		public static PlayerAvatarView GetAvatarViewPrefab()
		{
			return null;
		}

		// Token: 0x06017C74 RID: 97396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C74")]
		[Address(RVA = "0x1002920", Offset = "0x1001520", VA = "0x181002920")]
		public static string GetDynAvatarSpineIdByDynAvatarId(string dynAvatarId)
		{
			return null;
		}

		// Token: 0x0401CB5B RID: 117595
		[Token(Token = "0x401CB5B")]
		public const string DYN_AVATAR_SPINE_ANIM_NAME = "loop";

		// Token: 0x0401CB5C RID: 117596
		[Token(Token = "0x401CB5C")]
		private const string DYN_AVATAR_SPINE_ID_FORMAT = "spine_{0}";

		// Token: 0x0401CB5D RID: 117597
		[Token(Token = "0x401CB5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsAssistantType;

		// Token: 0x0401CB5E RID: 117598
		[Token(Token = "0x401CB5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAvatarIcon;

		// Token: 0x0401CB5F RID: 117599
		[Token(Token = "0x401CB5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_GetAvatarIcon;

		// Token: 0x0401CB60 RID: 117600
		[Token(Token = "0x401CB60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix2_GetAvatarIcon;

		// Token: 0x0401CB61 RID: 117601
		[Token(Token = "0x401CB61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetAvatarIconByAvatarData;

		// Token: 0x0401CB62 RID: 117602
		[Token(Token = "0x401CB62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_GetAvatarIconByAvatarData;

		// Token: 0x0401CB63 RID: 117603
		[Token(Token = "0x401CB63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetAssistantName;

		// Token: 0x0401CB64 RID: 117604
		[Token(Token = "0x401CB64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetAvatarViewPrefab;

		// Token: 0x0401CB65 RID: 117605
		[Token(Token = "0x401CB65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetDynAvatarSpineIdByDynAvatarId;
	}
}
