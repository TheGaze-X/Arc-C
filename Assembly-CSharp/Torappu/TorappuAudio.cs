using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.Audio.Middleware;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200047F RID: 1151
	[Token(Token = "0x200047F")]
	public class TorappuAudio : PersistentSingleton<TorappuAudio>, ILuaCallCSharp
	{
		// Token: 0x06004C4D RID: 19533 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x1794030", Offset = "0x1792C30", VA = "0x181794030")]
		public static TorappuAudio.ChannelStatus GetChannelStatus(string channelTag)
		{
			return default(TorappuAudio.ChannelStatus);
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x1794460", Offset = "0x1793060", VA = "0x181794460")]
		public static bool PlayBattle(string signal, [Optional] string subSignal)
		{
			return default(bool);
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x1794590", Offset = "0x1793190", VA = "0x181794590")]
		public static bool PlayBattle(string signal, string subSignal, Vector3 worldPosition)
		{
			return default(bool);
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C50")]
		[Address(RVA = "0x1794320", Offset = "0x1792F20", VA = "0x181794320")]
		public static AudioAtom[] PlayBattleAndGetAtoms(string signal, string subSignal, Vector3 worldPosition)
		{
			return null;
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x0002D108 File Offset: 0x0002B308
		[Token(Token = "0x6004C51")]
		[Address(RVA = "0x17949B0", Offset = "0x17935B0", VA = "0x1817949B0")]
		public static bool PlayUI(string signal, [Optional] string subSignal)
		{
			return default(bool);
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x0002D120 File Offset: 0x0002B320
		[Token(Token = "0x6004C52")]
		[Address(RVA = "0x1794880", Offset = "0x1793480", VA = "0x181794880")]
		public static bool PlaySystem(string signal, [Optional] string subSignal)
		{
			return default(bool);
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x0002D138 File Offset: 0x0002B338
		[Token(Token = "0x6004C53")]
		[Address(RVA = "0x1794790", Offset = "0x1793390", VA = "0x181794790")]
		public static bool PlayEvent(string eventName)
		{
			return default(bool);
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x0002D150 File Offset: 0x0002B350
		[Token(Token = "0x6004C54")]
		[Address(RVA = "0x17946B0", Offset = "0x17932B0", VA = "0x1817946B0")]
		public static bool PlayEvent(string eventName, Vector3 worldPosition)
		{
			return default(bool);
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C55")]
		[Address(RVA = "0x1793F70", Offset = "0x1792B70", VA = "0x181793F70")]
		public static string CreateEventName(string module, string signal, string subSignal)
		{
			return null;
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x0002D168 File Offset: 0x0002B368
		[Token(Token = "0x6004C56")]
		[Address(RVA = "0x17952D0", Offset = "0x1793ED0", VA = "0x1817952D0")]
		public static bool TestEvent(string eventName)
		{
			return default(bool);
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C57")]
		[Address(RVA = "0x17941D0", Offset = "0x1792DD0", VA = "0x1817941D0")]
		public static AudioAtom[] PlayAndGetAtoms(string module, string signal, [Optional] string subSignal)
		{
			return null;
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C58")]
		[Address(RVA = "0x1794E40", Offset = "0x1793A40", VA = "0x181794E40")]
		public static void SetListenerPosition(Vector3 worldPosition, Quaternion worldRotation)
		{
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C59")]
		[Address(RVA = "0x1794AE0", Offset = "0x17936E0", VA = "0x181794AE0")]
		public static void PreloadBattle(string persistTag, string signal, [Optional] string subSignal)
		{
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5A")]
		[Address(RVA = "0x1794CC0", Offset = "0x17938C0", VA = "0x181794CC0")]
		public static void PreloadUI(string persistTag, string signal, [Optional] string subSignal)
		{
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5B")]
		[Address(RVA = "0x1794BD0", Offset = "0x17937D0", VA = "0x181794BD0")]
		public static void PreloadSystem(string persistTag, string signal, [Optional] string subSignal)
		{
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5C")]
		[Address(RVA = "0x1795420", Offset = "0x1794020", VA = "0x181795420")]
		public static void UnloadPreloadedAssets(string persistTag)
		{
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5D")]
		[Address(RVA = "0x1795170", Offset = "0x1793D70", VA = "0x181795170")]
		public static void StopPreloadedEvents(string persistTag)
		{
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5E")]
		[Address(RVA = "0x17940A0", Offset = "0x1792CA0", VA = "0x1817940A0")]
		public static void Init()
		{
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5F")]
		[Address(RVA = "0x1794DB0", Offset = "0x17939B0", VA = "0x181794DB0")]
		public static void ReloadBanks()
		{
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C60")]
		[Address(RVA = "0x1795000", Offset = "0x1793C00", VA = "0x181795000")]
		public static void StopAll(float fadeTime, bool exceptMusic)
		{
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C61")]
		[Address(RVA = "0x1795910", Offset = "0x1794510", VA = "0x181795910")]
		private void _Init()
		{
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C62")]
		[Address(RVA = "0x1795ED0", Offset = "0x1794AD0", VA = "0x181795ED0")]
		private void _ReloadBanks()
		{
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C63")]
		[Address(RVA = "0x1795640", Offset = "0x1794240", VA = "0x181795640")]
		private static string _GenerateEventName(string module, string signal, string subSignal)
		{
			return null;
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x0002D180 File Offset: 0x0002B380
		[Token(Token = "0x6004C64")]
		[Address(RVA = "0x1795B10", Offset = "0x1794710", VA = "0x181795B10")]
		private bool _Play(string module, string signal, string subSignal, Vector3 worldPosition)
		{
			return default(bool);
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C65")]
		[Address(RVA = "0x1795C60", Offset = "0x1794860", VA = "0x181795C60")]
		private void _Play(string module, string signal, string subSignal, Vector3 worldPosition, out AudioAtom[] atoms)
		{
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x0002D198 File Offset: 0x0002B398
		[Token(Token = "0x6004C66")]
		[Address(RVA = "0x1795A00", Offset = "0x1794600", VA = "0x181795A00")]
		private bool _PlayEvent(string eventName, Vector3 worldPosition)
		{
			return default(bool);
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C67")]
		[Address(RVA = "0x1795DC0", Offset = "0x17949C0", VA = "0x181795DC0")]
		private void _Preload(string persistTag, string module, string signal, string subSignal)
		{
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C68")]
		[Address(RVA = "0x1796230", Offset = "0x1794E30", VA = "0x181796230")]
		private void _UnloadPreloadedAssets(string persistTag)
		{
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x1796170", Offset = "0x1794D70", VA = "0x181796170")]
		private void _StopPreloadedEvents(string persistTag)
		{
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0x1795F70", Offset = "0x1794B70", VA = "0x181795F70")]
		private void _SetListenerPosition(Vector3 worldPosition, Quaternion worldRotation)
		{
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x1796090", Offset = "0x1794C90", VA = "0x181796090")]
		private void _StopAll(float fadeTime, bool exceptMusic)
		{
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0x1794130", Offset = "0x1792D30", VA = "0x181794130", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0x1795580", Offset = "0x1794180", VA = "0x181795580")]
		private void Update()
		{
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6E")]
		[Address(RVA = "0x1796380", Offset = "0x1794F80", VA = "0x181796380")]
		public TorappuAudio()
		{
		}

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AudioMiddleware m_middleware;

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StringBuilder m_sb;

		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetChannelStatus;

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayBattle;

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_PlayBattle;

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayBattleAndGetAtoms;

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayUI;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlaySystem;

		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayEvent;

		// Token: 0x0400104B RID: 4171
		[Token(Token = "0x400104B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_PlayEvent;

		// Token: 0x0400104C RID: 4172
		[Token(Token = "0x400104C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateEventName;

		// Token: 0x0400104D RID: 4173
		[Token(Token = "0x400104D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TestEvent;

		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_PlayAndGetAtoms;

		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetListenerPosition;

		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_PreloadBattle;

		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PreloadUI;

		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_PreloadSystem;

		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UnloadPreloadedAssets;

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_StopPreloadedEvents;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ReloadBanks;

		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_StopAll;

		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ReloadBanks;

		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GenerateEventName;

		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__Play;

		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix1__Play;

		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__PlayEvent;

		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__Preload;

		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__UnloadPreloadedAssets;

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__StopPreloadedEvents;

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__SetListenerPosition;

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__StopAll;

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000480 RID: 1152
		[Token(Token = "0x2000480")]
		public struct ChannelStatus
		{
			// Token: 0x04001066 RID: 4198
			[Token(Token = "0x4001066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timePercent;
		}
	}
}
