using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Hypergryph.SDK
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class HGEventLogSDKMgr : MonoBehaviour
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4A03CA0", Offset = "0x4A028A0", VA = "0x184A03CA0")]
		public static bool SetEnvironment(string env)
		{
			return default(bool);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4A03A20", Offset = "0x4A02620", VA = "0x184A03A20")]
		public static bool Init(string appId, string regionTag)
		{
			return default(bool);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4A03D20", Offset = "0x4A02920", VA = "0x184A03D20")]
		public static bool SetGlobalProperties(string globalProperties)
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4A03E30", Offset = "0x4A02A30", VA = "0x184A03E30")]
		public static bool UnsetGlobalProperties(string propertyKeys)
		{
			return default(bool);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x4A03660", Offset = "0x4A02260", VA = "0x184A03660")]
		public static void ClearGlobalProperties()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4A03740", Offset = "0x4A02340", VA = "0x184A03740")]
		public static bool EventTrack(string name, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4A03390", Offset = "0x4A01F90", VA = "0x184A03390")]
		public static bool AppStartEvent(string channel1, string channel2, bool beat, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4A03F40", Offset = "0x4A02B40", VA = "0x184A03F40")]
		public static bool UserLoginEvent(string userId, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4A03EC0", Offset = "0x4A02AC0", VA = "0x184A03EC0")]
		public static void UnsetUser()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4A03500", Offset = "0x4A02100", VA = "0x184A03500")]
		public static bool CharacterLoginEvent(string characterId, string serverId, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4A03DB0", Offset = "0x4A029B0", VA = "0x184A03DB0")]
		public static void UnsetCharacter()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4A03900", Offset = "0x4A02500", VA = "0x184A03900")]
		public static string GetPresetProperties()
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4A03BA0", Offset = "0x4A027A0", VA = "0x184A03BA0")]
		public static void PauseBeat()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4A03C20", Offset = "0x4A02820", VA = "0x184A03C20")]
		public static void ResumeBeat()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4A037F0", Offset = "0x4A023F0", VA = "0x184A037F0")]
		public static void Flush()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4A036E0", Offset = "0x4A022E0", VA = "0x184A036E0")]
		public static bool EnableRealTimeSend(bool enable)
		{
			return default(bool);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4A03990", Offset = "0x4A02590", VA = "0x184A03990")]
		public static string GetStaticPresetProperties()
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4A03870", Offset = "0x4A02470", VA = "0x184A03870")]
		public static string GetDeviceIdProperties()
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4A03AE0", Offset = "0x4A026E0", VA = "0x184A03AE0")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HGEventLogSDKMgr()
		{
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x0")]
		private static string appIdForInstance;
	}
}
