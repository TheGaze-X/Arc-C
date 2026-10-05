using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Hypergryph.SDK
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class HGEventLogSDKAppInstance : MonoBehaviour
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4A02FD0", Offset = "0x4A01BD0", VA = "0x184A02FD0")]
		public static bool SetEnvironment(string env)
		{
			return default(bool);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4A03020", Offset = "0x4A01C20", VA = "0x184A03020")]
		public static bool SetGlobalProperties(string globalProperties)
		{
			return default(bool);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4A030D0", Offset = "0x4A01CD0", VA = "0x184A030D0")]
		public static bool UnsetGlobalProperties(string propertyKeys)
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4A02C70", Offset = "0x4A01870", VA = "0x184A02C70")]
		public static void ClearGlobalProperties()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4A02D20", Offset = "0x4A01920", VA = "0x184A02D20")]
		public static bool EventTrack(string name, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4A02AD0", Offset = "0x4A016D0", VA = "0x184A02AD0")]
		public static bool AppStartEvent(string channel1, string channel2, bool beat, string properties)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4A03180", Offset = "0x4A01D80", VA = "0x184A03180")]
		public static bool UserLoginEvent(string userId, string properties)
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4A03130", Offset = "0x4A01D30", VA = "0x184A03130")]
		public static void UnsetUser()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4A02BF0", Offset = "0x4A017F0", VA = "0x184A02BF0")]
		public static bool CharacterLoginEvent(string characterId, string serverId, string properties)
		{
			return default(bool);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4A03080", Offset = "0x4A01C80", VA = "0x184A03080")]
		public static void UnsetCharacter()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4A02E30", Offset = "0x4A01A30", VA = "0x184A02E30")]
		public static string GetPresetProperties()
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4A02F30", Offset = "0x4A01B30", VA = "0x184A02F30")]
		public static void PauseBeat()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4A02F80", Offset = "0x4A01B80", VA = "0x184A02F80")]
		public static void ResumeBeat()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4A02D90", Offset = "0x4A01990", VA = "0x184A02D90")]
		public static void Flush()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4A02CC0", Offset = "0x4A018C0", VA = "0x184A02CC0")]
		public static bool EnableRealTimeSend(bool enable)
		{
			return default(bool);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x4A02E80", Offset = "0x4A01A80", VA = "0x184A02E80")]
		public static string GetStaticPresetProperties()
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4A02DE0", Offset = "0x4A019E0", VA = "0x184A02DE0")]
		public static string GetDeviceIdProperties()
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4A02ED0", Offset = "0x4A01AD0", VA = "0x184A02ED0")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HGEventLogSDKAppInstance()
		{
		}
	}
}
