using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AEA RID: 15082
	[Token(Token = "0x2003AEA")]
	public struct PlayerAvatarQuery : IHotfixable, IEquatable<PlayerAvatarQuery>
	{
		// Token: 0x06017C5A RID: 97370 RVA: 0x000980B8 File Offset: 0x000962B8
		[Token(Token = "0x6017C5A")]
		[Address(RVA = "0x1000DB0", Offset = "0xFFF9B0", VA = "0x181000DB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06017C5B RID: 97371 RVA: 0x000980D0 File Offset: 0x000962D0
		[Token(Token = "0x6017C5B")]
		[Address(RVA = "0x1000EF0", Offset = "0xFFFAF0", VA = "0x181000EF0", Slot = "4")]
		public bool Equals(PlayerAvatarQuery other)
		{
			return default(bool);
		}

		// Token: 0x06017C5C RID: 97372 RVA: 0x000980E8 File Offset: 0x000962E8
		[Token(Token = "0x6017C5C")]
		[Address(RVA = "0x10018B0", Offset = "0x10004B0", VA = "0x1810018B0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06017C5D RID: 97373 RVA: 0x00098100 File Offset: 0x00096300
		[Token(Token = "0x6017C5D")]
		[Address(RVA = "0x1001C90", Offset = "0x1000890", VA = "0x181001C90")]
		public static PlayerAvatarQuery SimpleAvatar(PlayerAvatarType type, string id)
		{
			return default(PlayerAvatarQuery);
		}

		// Token: 0x06017C5E RID: 97374 RVA: 0x00098118 File Offset: 0x00096318
		[Token(Token = "0x6017C5E")]
		[Address(RVA = "0x1001D60", Offset = "0x1000960", VA = "0x181001D60")]
		public static PlayerAvatarQuery SimpleAvatar(PlayerAvatarType type, string id, bool isSpSkin)
		{
			return default(PlayerAvatarQuery);
		}

		// Token: 0x06017C5F RID: 97375 RVA: 0x00098130 File Offset: 0x00096330
		[Token(Token = "0x6017C5F")]
		[Address(RVA = "0x10010D0", Offset = "0xFFFCD0", VA = "0x1810010D0")]
		public static PlayerAvatarQuery FromData(PlayerAvatarPerData data)
		{
			return default(PlayerAvatarQuery);
		}

		// Token: 0x06017C60 RID: 97376 RVA: 0x00098148 File Offset: 0x00096348
		[Token(Token = "0x6017C60")]
		[Address(RVA = "0x1000FE0", Offset = "0xFFFBE0", VA = "0x181000FE0")]
		public static PlayerAvatarQuery FromAvatarInfo(AvatarInfo info)
		{
			return default(PlayerAvatarQuery);
		}

		// Token: 0x06017C61 RID: 97377 RVA: 0x00098160 File Offset: 0x00096360
		[Token(Token = "0x6017C61")]
		[Address(RVA = "0x1001490", Offset = "0x1000090", VA = "0x181001490")]
		public static PlayerAvatarQuery FromPlayerStatus(IPlayerStatus status)
		{
			return default(PlayerAvatarQuery);
		}

		// Token: 0x06017C62 RID: 97378 RVA: 0x00098178 File Offset: 0x00096378
		[Token(Token = "0x6017C62")]
		[Address(RVA = "0x10012D0", Offset = "0xFFFED0", VA = "0x1810012D0")]
		public static PlayerAvatarQuery FromPlayerSecretary(IPlayerStatus status)
		{
			return default(PlayerAvatarQuery);
		}

		// Token: 0x06017C63 RID: 97379 RVA: 0x00098190 File Offset: 0x00096390
		[Token(Token = "0x6017C63")]
		[Address(RVA = "0x10011C0", Offset = "0xFFFDC0", VA = "0x1810011C0")]
		public static PlayerAvatarQuery FromGroupType(PlayerAvatarGroupType groupType, string avatarId, bool isSpSkin = false)
		{
			return default(PlayerAvatarQuery);
		}

		// Token: 0x06017C64 RID: 97380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C64")]
		[Address(RVA = "0x1001AF0", Offset = "0x10006F0", VA = "0x181001AF0")]
		public Sprite LoadAvatar(ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06017C65 RID: 97381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C65")]
		[Address(RVA = "0x1001950", Offset = "0x1000550", VA = "0x181001950")]
		public Sprite LoadAvatar(string pageName)
		{
			return null;
		}

		// Token: 0x06017C66 RID: 97382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C66")]
		[Address(RVA = "0x10017B0", Offset = "0x10003B0", VA = "0x1810017B0")]
		public string GetDynAvatarId()
		{
			return null;
		}

		// Token: 0x06017C67 RID: 97383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C67")]
		[Address(RVA = "0x1001EC0", Offset = "0x1000AC0", VA = "0x181001EC0")]
		private Sprite _GetAvatarIconFromAssistant(string skinId, bool showSpSkin)
		{
			return null;
		}

		// Token: 0x06017C68 RID: 97384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C68")]
		[Address(RVA = "0x1002000", Offset = "0x1000C00", VA = "0x181002000")]
		private Sprite _GetAvatarIconFromHub(string avatarId, [Optional] string pageName)
		{
			return null;
		}

		// Token: 0x06017C69 RID: 97385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C69")]
		[Address(RVA = "0x1002100", Offset = "0x1000D00", VA = "0x181002100")]
		private Sprite _GetAvatarIconFromHub(string avatarId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06017C6B RID: 97387 RVA: 0x000981A8 File Offset: 0x000963A8
		[Token(Token = "0x6017C6B")]
		[Address(RVA = "0x1001E50", Offset = "0x1000A50", VA = "0x181001E50")]
		private bool <>xLuaBaseProxy_Equals(object P0)
		{
			return default(bool);
		}

		// Token: 0x0401CB47 RID: 117575
		[Token(Token = "0x401CB47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PlayerAvatarQuery EMPTY;

		// Token: 0x0401CB48 RID: 117576
		[Token(Token = "0x401CB48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PlayerAvatarType type;

		// Token: 0x0401CB49 RID: 117577
		[Token(Token = "0x401CB49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x0401CB4A RID: 117578
		[Token(Token = "0x401CB4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isSpSkin;

		// Token: 0x0401CB4B RID: 117579
		[Token(Token = "0x401CB4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Equals;

		// Token: 0x0401CB4C RID: 117580
		[Token(Token = "0x401CB4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_Equals;

		// Token: 0x0401CB4D RID: 117581
		[Token(Token = "0x401CB4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0401CB4E RID: 117582
		[Token(Token = "0x401CB4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SimpleAvatar;

		// Token: 0x0401CB4F RID: 117583
		[Token(Token = "0x401CB4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_SimpleAvatar;

		// Token: 0x0401CB50 RID: 117584
		[Token(Token = "0x401CB50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FromData;

		// Token: 0x0401CB51 RID: 117585
		[Token(Token = "0x401CB51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FromAvatarInfo;

		// Token: 0x0401CB52 RID: 117586
		[Token(Token = "0x401CB52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FromPlayerStatus;

		// Token: 0x0401CB53 RID: 117587
		[Token(Token = "0x401CB53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_FromPlayerSecretary;

		// Token: 0x0401CB54 RID: 117588
		[Token(Token = "0x401CB54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FromGroupType;

		// Token: 0x0401CB55 RID: 117589
		[Token(Token = "0x401CB55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadAvatar;

		// Token: 0x0401CB56 RID: 117590
		[Token(Token = "0x401CB56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_LoadAvatar;

		// Token: 0x0401CB57 RID: 117591
		[Token(Token = "0x401CB57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetDynAvatarId;

		// Token: 0x0401CB58 RID: 117592
		[Token(Token = "0x401CB58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetAvatarIconFromAssistant;

		// Token: 0x0401CB59 RID: 117593
		[Token(Token = "0x401CB59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetAvatarIconFromHub;

		// Token: 0x0401CB5A RID: 117594
		[Token(Token = "0x401CB5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix1__GetAvatarIconFromHub;
	}
}
