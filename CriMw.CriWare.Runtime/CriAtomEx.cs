using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public static class CriAtomEx
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x36CBFE0", Offset = "0x36CABE0", VA = "0x1836CBFE0")]
		public static void SetSpeakerAngle(CriAtomEx.SpeakerAngles6ch speakerAngle)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x36CC090", Offset = "0x36CAC90", VA = "0x1836CC090")]
		public static void SetSpeakerAngle(CriAtomEx.SpeakerAngles8ch speakerAngle)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x36CC140", Offset = "0x36CAD40", VA = "0x1836CC140")]
		public static void SetVirtualSpeakerAngle(CriAtomEx.SpeakerAngles6ch speakerAngle)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x36CC1F0", Offset = "0x36CADF0", VA = "0x1836CC1F0")]
		public static void SetVirtualSpeakerAngle(CriAtomEx.SpeakerAngles8ch speakerAngle)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x36CA5F0", Offset = "0x36C91F0", VA = "0x1836CA5F0")]
		public static void ControlVirtualSpeakerSetting(bool sw)
		{
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000195 RID: 405 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000196 RID: 406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000C")]
		public static event CriAtomEx.CueLinkCbFunc OnCueLinkCallback
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x36CC660", Offset = "0x36CB260", VA = "0x1836CC660")]
			add
			{
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x36CD9B0", Offset = "0x36CC5B0", VA = "0x1836CD9B0")]
			remove
			{
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x36CB660", Offset = "0x36CA260", VA = "0x1836CB660")]
		public static bool RegisterAcf(CriFsBinder binder, string acfPath)
		{
			return default(bool);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x36CB880", Offset = "0x36CA480", VA = "0x1836CB880")]
		public static bool RegisterAcf(IntPtr acfData, int dataSize)
		{
			return default(bool);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x36CB780", Offset = "0x36CA380", VA = "0x1836CB780")]
		[Obsolete("Use RegisterAcf(IntPtr, int) instead")]
		public static bool RegisterAcf(byte[] acfData)
		{
			return default(bool);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x36CC340", Offset = "0x36CAF40", VA = "0x1836CC340")]
		public static void UnregisterAcf()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x36CA7F0", Offset = "0x36C93F0", VA = "0x1836CA7F0")]
		public static string GetAppliedDspBusSnapshotName()
		{
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x36CA500", Offset = "0x36C9100", VA = "0x1836CA500")]
		public static void AttachDspBusSetting(string settingName)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x36CA6A0", Offset = "0x36C92A0", VA = "0x1836CA6A0")]
		public static void DetachDspBusSetting()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x36CA430", Offset = "0x36C9030", VA = "0x1836CA430")]
		public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x36CAE40", Offset = "0x36C9A40", VA = "0x1836CAE40")]
		public static int GetNumGameVariables()
		{
			return 0;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x36CAA00", Offset = "0x36C9600", VA = "0x1836CAA00")]
		public static bool GetGameVariableInfo(ushort index, out CriAtomEx.GameVariableInfo info)
		{
			return default(bool);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x36CACF0", Offset = "0x36C98F0", VA = "0x1836CACF0")]
		public static float GetGameVariable(uint game_variable_id)
		{
			return 0f;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x36CAC20", Offset = "0x36C9820", VA = "0x1836CAC20")]
		public static float GetGameVariable(string game_variable_name)
		{
			return 0f;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x36CBAE0", Offset = "0x36CA6E0", VA = "0x1836CBAE0")]
		public static void SetGameVariable(uint game_variable_id, float game_variable_value)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x36CBA10", Offset = "0x36CA610", VA = "0x1836CBA10")]
		public static void SetGameVariable(string game_variable_name, float game_variable_value)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x36CBF30", Offset = "0x36CAB30", VA = "0x1836CBF30")]
		public static void SetRandomSeed(uint seed)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x36CB970", Offset = "0x36CA570", VA = "0x1836CB970")]
		public static void ResetPerformanceMonitor()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x36CB3C0", Offset = "0x36C9FC0", VA = "0x1836CB3C0")]
		public static void GetPerformanceInfo(out CriAtomEx.PerformanceInfo info)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x36CBBA0", Offset = "0x36CA7A0", VA = "0x1836CBBA0")]
		public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x36CBC60", Offset = "0x36CA860", VA = "0x1836CBC60")]
		public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x36CB5B0", Offset = "0x36CA1B0", VA = "0x1836CB5B0")]
		public static void PauseTimer(bool sw)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x36CB510", Offset = "0x36CA110", VA = "0x1836CB510")]
		public static void Lock()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x36CC2A0", Offset = "0x36CAEA0", VA = "0x1836CC2A0")]
		public static void Unlock()
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x36CBD40", Offset = "0x36CA940", VA = "0x1836CBD40")]
		public static void SetOutputAudioDevice_PC(string deviceId)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x36CAEE0", Offset = "0x36C9AE0", VA = "0x1836CAEE0")]
		public static string GetOutputAudioDeviceId_PC(out bool isDefaultDevice)
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x36CB070", Offset = "0x36C9C70", VA = "0x1836CB070")]
		public static int GetOutputAudioDeviceIndex_PC(out bool isDefaultDevice)
		{
			return 0;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x36CB470", Offset = "0x36CA070", VA = "0x1836CB470")]
		public static bool LoadAudioDeviceList_PC()
		{
			return default(bool);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x36CADA0", Offset = "0x36C99A0", VA = "0x1836CADA0")]
		public static int GetNumAudioDevices_PC()
		{
			return 0;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x36CA8F0", Offset = "0x36C94F0", VA = "0x1836CA8F0")]
		public static string GetAudioDeviceName_PC(int index)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x36CBE70", Offset = "0x36CAA70", VA = "0x1836CBE70")]
		public static void SetOutputAudioDevice_PC(int index)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetOutputVolume_VITA(float volume)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		public static bool IsBgmPortAcquired_VITA()
		{
			return default(bool);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void EnableBackgroundPlayback_IOS()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void DisableBackgroundPlayback_IOS()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public static bool IsInterruptedOtherAudio_IOS()
		{
			return default(bool);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void ResumeAudio_IOS()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public static bool IsSoundStopped_IOS()
		{
			return default(bool);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void EnableAudioSessionRestoration_IOS(bool flag)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x36CA740", Offset = "0x36C9340", VA = "0x1836CA740")]
		public static void EnableBusSendOffsetWhenLevelNotExist(bool enable)
		{
		}

		// Token: 0x060001BD RID: 445
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x36CCF50", Offset = "0x36CBB50", VA = "0x1836CCF50")]
		[PreserveSig]
		private static extern bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize);

		// Token: 0x060001BE RID: 446
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x36CCEA0", Offset = "0x36CBAA0", VA = "0x1836CCEA0")]
		[PreserveSig]
		private static extern bool criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize);

		// Token: 0x060001BF RID: 447
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x36CCDF0", Offset = "0x36CB9F0", VA = "0x1836CCDF0")]
		[PreserveSig]
		private static extern bool criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize);

		// Token: 0x060001C0 RID: 448
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x36CD470", Offset = "0x36CC070", VA = "0x1836CD470")]
		[PreserveSig]
		private static extern void criAtomEx_UnregisterAcf();

		// Token: 0x060001C1 RID: 449
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x36CC850", Offset = "0x36CB450", VA = "0x1836CC850")]
		[PreserveSig]
		private static extern void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize);

		// Token: 0x060001C2 RID: 450
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x36CC980", Offset = "0x36CB580", VA = "0x1836CC980")]
		[PreserveSig]
		private static extern void criAtomEx_DetachDspBusSetting();

		// Token: 0x060001C3 RID: 451
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x36CC7B0", Offset = "0x36CB3B0", VA = "0x1836CC7B0")]
		[PreserveSig]
		private static extern void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms);

		// Token: 0x060001C4 RID: 452
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x36CCA70", Offset = "0x36CB670", VA = "0x1836CCA70")]
		[PreserveSig]
		private static extern IntPtr criAtomEx_GetAppliedDspBusSnapshotName();

		// Token: 0x060001C5 RID: 453
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x36CCC90", Offset = "0x36CB890", VA = "0x1836CCC90")]
		[PreserveSig]
		private static extern int criAtomEx_GetNumGameVariables();

		// Token: 0x060001C6 RID: 454
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x36CCC00", Offset = "0x36CB800", VA = "0x1836CCC00")]
		[PreserveSig]
		private static extern bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info);

		// Token: 0x060001C7 RID: 455
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x36CCAE0", Offset = "0x36CB6E0", VA = "0x1836CCAE0")]
		[PreserveSig]
		private static extern float criAtomEx_GetGameVariableById(uint game_variable_id);

		// Token: 0x060001C8 RID: 456
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x36CCB60", Offset = "0x36CB760", VA = "0x1836CCB60")]
		[PreserveSig]
		private static extern float criAtomEx_GetGameVariableByName(string game_variable_name);

		// Token: 0x060001C9 RID: 457
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x36CD010", Offset = "0x36CBC10", VA = "0x1836CD010")]
		[PreserveSig]
		private static extern void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value);

		// Token: 0x060001CA RID: 458
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x36CD0A0", Offset = "0x36CBCA0", VA = "0x1836CD0A0")]
		[PreserveSig]
		private static extern void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value);

		// Token: 0x060001CB RID: 459
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x36CD140", Offset = "0x36CBD40", VA = "0x1836CD140")]
		[PreserveSig]
		private static extern void criAtomEx_SetRandomSeed(uint seed);

		// Token: 0x060001CC RID: 460
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x36CCD70", Offset = "0x36CB970", VA = "0x1836CCD70")]
		[PreserveSig]
		private static extern void criAtomEx_PauseTimer(bool sw);

		// Token: 0x060001CD RID: 461
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x36CCD00", Offset = "0x36CB900", VA = "0x1836CCD00")]
		[PreserveSig]
		private static extern void criAtomEx_Lock();

		// Token: 0x060001CE RID: 462
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x36CD400", Offset = "0x36CC000", VA = "0x1836CD400")]
		[PreserveSig]
		private static extern void criAtomEx_Unlock();

		// Token: 0x060001CF RID: 463
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x36CD820", Offset = "0x36CC420", VA = "0x1836CD820")]
		[PreserveSig]
		private static extern void criAtom_ResetPerformanceMonitor();

		// Token: 0x060001D0 RID: 464
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x36CD7A0", Offset = "0x36CC3A0", VA = "0x1836CD7A0")]
		[PreserveSig]
		private static extern void criAtom_GetPerformanceInfo(out CriAtomEx.PerformanceInfo info);

		// Token: 0x060001D1 RID: 465
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x36CC670", Offset = "0x36CB270", VA = "0x1836CC670")]
		[PreserveSig]
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index);

		// Token: 0x060001D2 RID: 466
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x36CC700", Offset = "0x36CB300", VA = "0x1836CC700")]
		[PreserveSig]
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name);

		// Token: 0x060001D3 RID: 467
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x36CD1C0", Offset = "0x36CBDC0", VA = "0x1836CD1C0")]
		[PreserveSig]
		private static extern void criAtomEx_SetSpeakerAngleArray(CriAtomEx.SpeakerSystem speaker_system, ref CriAtomEx.SpeakerAngles6ch angle_array);

		// Token: 0x060001D4 RID: 468
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x36CD250", Offset = "0x36CBE50", VA = "0x1836CD250")]
		[PreserveSig]
		private static extern void criAtomEx_SetSpeakerAngleArray(CriAtomEx.SpeakerSystem speaker_system, ref CriAtomEx.SpeakerAngles8ch angle_array);

		// Token: 0x060001D5 RID: 469
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x36CD2E0", Offset = "0x36CBEE0", VA = "0x1836CD2E0")]
		[PreserveSig]
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(CriAtomEx.SpeakerSystem speaker_system, ref CriAtomEx.SpeakerAngles6ch angle_array);

		// Token: 0x060001D6 RID: 470
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x36CD370", Offset = "0x36CBF70", VA = "0x1836CD370")]
		[PreserveSig]
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(CriAtomEx.SpeakerSystem speaker_system, ref CriAtomEx.SpeakerAngles8ch angle_array);

		// Token: 0x060001D7 RID: 471
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x36CC900", Offset = "0x36CB500", VA = "0x1836CC900")]
		[PreserveSig]
		private static extern void criAtomEx_ControlVirtualSpeakerSetting(bool sw);

		// Token: 0x060001D8 RID: 472
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x36CC9F0", Offset = "0x36CB5F0", VA = "0x1836CC9F0")]
		[PreserveSig]
		private static extern void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(bool enable);

		// Token: 0x060001D9 RID: 473
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x36CD920", Offset = "0x36CC520", VA = "0x1836CD920")]
		[PreserveSig]
		private static extern void criAtom_SetDeviceId_WASAPI(CriAtomEx.SoundRendererType soundRendererType, string deviceId);

		// Token: 0x060001DA RID: 474
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x36CD6C0", Offset = "0x36CC2C0", VA = "0x1836CD6C0")]
		[PreserveSig]
		private static extern int criAtom_GetDeviceId_WASAPI(CriAtomEx.SoundRendererType soundRendererType, StringBuilder deviceId, int count, out int is_default_device);

		// Token: 0x060001DB RID: 475
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x36CD890", Offset = "0x36CC490", VA = "0x1836CD890")]
		[PreserveSig]
		private static extern void criAtom_SetDeviceId_WASAPI(CriAtomEx.SoundRendererType type, IntPtr deviceId);

		// Token: 0x060001DC RID: 476
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x36CD650", Offset = "0x36CC250", VA = "0x1836CD650")]
		[PreserveSig]
		private static extern bool criAtomUnity_LoadAudioDeviceList_PC();

		// Token: 0x060001DD RID: 477
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x36CD5E0", Offset = "0x36CC1E0", VA = "0x1836CD5E0")]
		[PreserveSig]
		private static extern int criAtomUnity_GetNumAudioDevices_PC();

		// Token: 0x060001DE RID: 478
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x36CD560", Offset = "0x36CC160", VA = "0x1836CD560")]
		[PreserveSig]
		private static extern IntPtr criAtomUnity_GetAudioDeviceName_PC(int index);

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x36CD4E0", Offset = "0x36CC0E0", VA = "0x1836CD4E0")]
		[PreserveSig]
		private static extern IntPtr criAtomUnity_GetAudioDeviceId_PC(int index);

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		public const uint InvalidAisacControlId = 4294967295U;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<CriAtomEx.Randomize3dCalcType, CriAtomEx.Randomize3dParamType[]> randomize3dParamTable;

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		public enum CharacterEncoding
		{
			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			Utf8,
			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			Sjis
		}

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		public enum SoundRendererType
		{
			// Token: 0x040000CB RID: 203
			[Token(Token = "0x40000CB")]
			Default,
			// Token: 0x040000CC RID: 204
			[Token(Token = "0x40000CC")]
			Native,
			// Token: 0x040000CD RID: 205
			[Token(Token = "0x40000CD")]
			Asr,
			// Token: 0x040000CE RID: 206
			[Token(Token = "0x40000CE")]
			Extended,
			// Token: 0x040000CF RID: 207
			[Token(Token = "0x40000CF")]
			Spatial,
			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x40000D0")]
			Hw1 = 1,
			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x40000D1")]
			Hw2 = 65537,
			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			Hw3 = 131073,
			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x40000D3")]
			Hw4 = 196609,
			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			Haptic = 3,
			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			Pseudo = 65539,
			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			SpatialChannels = 4,
			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40000D7")]
			Ambisonics = 65540,
			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40000D8")]
			Passtrough = 131076,
			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			Object = 196612
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		public enum VoiceAllocationMethod
		{
			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			Once,
			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			Retry
		}

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		public enum BiquadFilterType
		{
			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			Off,
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			LowPass,
			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			HighPass,
			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			Notch,
			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			LowShelf,
			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			HighShelf,
			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			Peaking
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		public enum ResumeMode
		{
			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			AllPlayback,
			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			PausedPlayback,
			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			PreparedPlayback
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public enum PanType
		{
			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			Unknown = -1,
			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			Pan3d,
			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			Pos3d,
			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			Auto
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		public enum VoiceControlMethod
		{
			// Token: 0x040000EF RID: 239
			[Token(Token = "0x40000EF")]
			PreferLast,
			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x40000F0")]
			PreferFirst
		}

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		public enum Parameter
		{
			// Token: 0x040000F2 RID: 242
			[Token(Token = "0x40000F2")]
			Volume,
			// Token: 0x040000F3 RID: 243
			[Token(Token = "0x40000F3")]
			Pitch,
			// Token: 0x040000F4 RID: 244
			[Token(Token = "0x40000F4")]
			Pan3dAngle,
			// Token: 0x040000F5 RID: 245
			[Token(Token = "0x40000F5")]
			Pan3dDistance,
			// Token: 0x040000F6 RID: 246
			[Token(Token = "0x40000F6")]
			Pan3dVolume,
			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x40000F7")]
			BusSendLevel0 = 9,
			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x40000F8")]
			BusSendLevel1,
			// Token: 0x040000F9 RID: 249
			[Token(Token = "0x40000F9")]
			BusSendLevel2,
			// Token: 0x040000FA RID: 250
			[Token(Token = "0x40000FA")]
			BusSendLevel3,
			// Token: 0x040000FB RID: 251
			[Token(Token = "0x40000FB")]
			BusSendLevel4,
			// Token: 0x040000FC RID: 252
			[Token(Token = "0x40000FC")]
			BusSendLevel5,
			// Token: 0x040000FD RID: 253
			[Token(Token = "0x40000FD")]
			BusSendLevel6,
			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			BusSendLevel7,
			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			BandPassFilterCofLow,
			// Token: 0x04000100 RID: 256
			[Token(Token = "0x4000100")]
			BandPassFilterCofHigh,
			// Token: 0x04000101 RID: 257
			[Token(Token = "0x4000101")]
			BiquadFilterType,
			// Token: 0x04000102 RID: 258
			[Token(Token = "0x4000102")]
			BiquadFilterFreq,
			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			BiquadFIlterQ,
			// Token: 0x04000104 RID: 260
			[Token(Token = "0x4000104")]
			BiquadFilterGain,
			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			EnvelopeAttackTime,
			// Token: 0x04000106 RID: 262
			[Token(Token = "0x4000106")]
			EnvelopeHoldTime,
			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			EnvelopeDecayTime,
			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			EnvelopeReleaseTime,
			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			EnvelopeSustainLevel,
			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			StartTime,
			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			Priority = 31
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		public enum Speaker
		{
			// Token: 0x0400010D RID: 269
			[Token(Token = "0x400010D")]
			FrontLeft,
			// Token: 0x0400010E RID: 270
			[Token(Token = "0x400010E")]
			FrontRight,
			// Token: 0x0400010F RID: 271
			[Token(Token = "0x400010F")]
			FrontCenter,
			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			LowFrequency,
			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			SurroundLeft,
			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			SurroundRight,
			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			SurroundBackLeft,
			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			SurroundBackRight
		}

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public enum Format : uint
		{
			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			ADX = 1U,
			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			HCA = 3U,
			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			HCA_MX,
			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			WAVE,
			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			RAW_PCM,
			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			AUDIO_BUFFER = 9U,
			// Token: 0x0400011C RID: 284
			[Token(Token = "0x400011C")]
			HW1 = 65537U,
			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			HW2,
			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			HW3,
			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			MP3 = 65539U
		}

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		public enum CurveType
		{
			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			Linear,
			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			Square,
			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			SquareReverse,
			// Token: 0x04000124 RID: 292
			[Token(Token = "0x4000124")]
			SCurve,
			// Token: 0x04000125 RID: 293
			[Token(Token = "0x4000125")]
			FlatAtHalf
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		private enum SpeakerSystem : uint
		{
			// Token: 0x04000127 RID: 295
			[Token(Token = "0x4000127")]
			Surround_5_1,
			// Token: 0x04000128 RID: 296
			[Token(Token = "0x4000128")]
			Surround_7_1
		}

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public struct SpeakerAngles6ch
		{
			// Token: 0x060001E1 RID: 481 RVA: 0x00002834 File Offset: 0x00000A34
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x36DC590", Offset = "0x36DB190", VA = "0x1836DC590")]
			public static CriAtomEx.SpeakerAngles6ch Default()
			{
				return default(CriAtomEx.SpeakerAngles6ch);
			}

			// Token: 0x04000129 RID: 297
			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float frontLeft;

			// Token: 0x0400012A RID: 298
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float frontRight;

			// Token: 0x0400012B RID: 299
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float frontCenter;

			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float lowFrequency;

			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float surroundLeft;

			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float surroundRight;
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		public struct SpeakerAngles8ch
		{
			// Token: 0x060001E2 RID: 482 RVA: 0x0000284C File Offset: 0x00000A4C
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x36DC5C0", Offset = "0x36DB1C0", VA = "0x1836DC5C0")]
			public static CriAtomEx.SpeakerAngles8ch Default()
			{
				return default(CriAtomEx.SpeakerAngles8ch);
			}

			// Token: 0x0400012F RID: 303
			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float frontLeft;

			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float frontRight;

			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float frontCenter;

			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float lowFrequency;

			// Token: 0x04000133 RID: 307
			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float surroundLeft;

			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float surroundRight;

			// Token: 0x04000135 RID: 309
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float surroundBackLeft;

			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float surroundBackRight;
		}

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		public struct FormatInfo
		{
			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomEx.Format format;

			// Token: 0x04000138 RID: 312
			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int samplingRate;

			// Token: 0x04000139 RID: 313
			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long numSamples;

			// Token: 0x0400013A RID: 314
			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long loopOffset;

			// Token: 0x0400013B RID: 315
			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long loopLength;

			// Token: 0x0400013C RID: 316
			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int numChannels;

			// Token: 0x0400013D RID: 317
			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public uint reserved;
		}

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		public struct AisacControlInfo
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x36B31D0", Offset = "0x36B1DD0", VA = "0x1836B31D0")]
			public AisacControlInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x0400013E RID: 318
			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly string name;

			// Token: 0x0400013F RID: 319
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint id;
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		public enum Randomize3dCalcType
		{
			// Token: 0x04000141 RID: 321
			[Token(Token = "0x4000141")]
			None = -1,
			// Token: 0x04000142 RID: 322
			[Token(Token = "0x4000142")]
			Rectangle,
			// Token: 0x04000143 RID: 323
			[Token(Token = "0x4000143")]
			Cuboid,
			// Token: 0x04000144 RID: 324
			[Token(Token = "0x4000144")]
			Circle,
			// Token: 0x04000145 RID: 325
			[Token(Token = "0x4000145")]
			Cylinder,
			// Token: 0x04000146 RID: 326
			[Token(Token = "0x4000146")]
			Sphere,
			// Token: 0x04000147 RID: 327
			[Token(Token = "0x4000147")]
			List = 6
		}

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		public enum Randomize3dParamType
		{
			// Token: 0x04000149 RID: 329
			[Token(Token = "0x4000149")]
			None,
			// Token: 0x0400014A RID: 330
			[Token(Token = "0x400014A")]
			Width,
			// Token: 0x0400014B RID: 331
			[Token(Token = "0x400014B")]
			Depth,
			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			Height,
			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			Radius
		}

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		[Serializable]
		public struct Randomize3dConfig
		{
			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002864 File Offset: 0x00000A64
			[Token(Token = "0x1700003C")]
			public bool FollowsOriginalSource
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000287C File Offset: 0x00000A7C
			[Token(Token = "0x1700003D")]
			public CriAtomEx.Randomize3dCalcType CalculationType
			{
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
				get
				{
					return CriAtomEx.Randomize3dCalcType.Rectangle;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060001E6 RID: 486 RVA: 0x00002894 File Offset: 0x00000A94
			[Token(Token = "0x1700003E")]
			public float CalculationParameter1
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x36DC030", Offset = "0x36DAC30", VA = "0x1836DC030")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x000028AC File Offset: 0x00000AAC
			[Token(Token = "0x1700003F")]
			public float CalculationParameter2
			{
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x36DC060", Offset = "0x36DAC60", VA = "0x1836DC060")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060001E8 RID: 488 RVA: 0x000028C4 File Offset: 0x00000AC4
			[Token(Token = "0x17000040")]
			public float CalculationParameter3
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x36DC090", Offset = "0x36DAC90", VA = "0x1836DC090")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x36DBE80", Offset = "0x36DAA80", VA = "0x1836DBE80")]
			internal Randomize3dConfig(byte[] data, int startIndex)
			{
			}

			// Token: 0x060001EA RID: 490 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x36DBDB0", Offset = "0x36DA9B0", VA = "0x1836DBDB0")]
			public Randomize3dConfig(bool followsOriginalSource, CriAtomEx.Randomize3dCalcType calculationType, float param1 = 0f, float param2 = 0f, float param3 = 0f)
			{
			}

			// Token: 0x060001EB RID: 491 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x36DBFA0", Offset = "0x36DABA0", VA = "0x1836DBFA0")]
			public Randomize3dConfig(int dummy)
			{
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x36DB8B0", Offset = "0x36DA4B0", VA = "0x1836DB8B0")]
			public void ClearCalcParams(float initVal = 0f)
			{
			}

			// Token: 0x060001ED RID: 493 RVA: 0x000028DC File Offset: 0x00000ADC
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x36DB8F0", Offset = "0x36DA4F0", VA = "0x1836DB8F0")]
			public bool GetParamByType(CriAtomEx.Randomize3dParamType paramType, ref float paramVal)
			{
				return default(bool);
			}

			// Token: 0x060001EE RID: 494 RVA: 0x000028F4 File Offset: 0x00000AF4
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x36DBB50", Offset = "0x36DA750", VA = "0x1836DBB50")]
			public bool SetParamByType(CriAtomEx.Randomize3dParamType paramType, float paramVal)
			{
				return default(bool);
			}

			// Token: 0x0400014E RID: 334
			[Token(Token = "0x400014E")]
			public const int NumOfCalcParams = 3;

			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private bool followsOriginalSource;

			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			private CriAtomEx.Randomize3dCalcType calculationType;

			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private float[] calculationParameters;
		}

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		public struct CuePos3dInfo
		{
			// Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x36DAD80", Offset = "0x36D9980", VA = "0x1836DAD80")]
			public CuePos3dInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float coneInsideAngle;

			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float coneOutsideAngle;

			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float minAttenuationDistance;

			// Token: 0x04000155 RID: 341
			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxAttenuationDistance;

			// Token: 0x04000156 RID: 342
			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float sourceRadius;

			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float interiorDistance;

			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dopplerFactor;

			// Token: 0x04000159 RID: 345
			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CriAtomEx.Randomize3dConfig randomPos;

			// Token: 0x0400015A RID: 346
			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public uint distanceAisacControl;

			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public uint listenerBaseAngleAisacControl;

			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public uint sourceBaseAngleAisacControl;

			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public uint listenerBaseElevationAisacControl;

			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint sourceBaseElevationAisacControl;
		}

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		public struct GameVariableInfo
		{
			// Token: 0x060001F0 RID: 496 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x36DB2D0", Offset = "0x36D9ED0", VA = "0x1836DB2D0")]
			public GameVariableInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x36DB430", Offset = "0x36DA030", VA = "0x1836DB430")]
			public GameVariableInfo(string name, uint id, float gameValue)
			{
			}

			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly string name;

			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint id;

			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float gameValue;
		}

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		public enum CueType
		{
			// Token: 0x04000163 RID: 355
			[Token(Token = "0x4000163")]
			Polyphonic,
			// Token: 0x04000164 RID: 356
			[Token(Token = "0x4000164")]
			Sequential,
			// Token: 0x04000165 RID: 357
			[Token(Token = "0x4000165")]
			Shuffle,
			// Token: 0x04000166 RID: 358
			[Token(Token = "0x4000166")]
			Random,
			// Token: 0x04000167 RID: 359
			[Token(Token = "0x4000167")]
			RandomNoRepeat,
			// Token: 0x04000168 RID: 360
			[Token(Token = "0x4000168")]
			SwitchGameVariable,
			// Token: 0x04000169 RID: 361
			[Token(Token = "0x4000169")]
			ComboSequential,
			// Token: 0x0400016A RID: 362
			[Token(Token = "0x400016A")]
			SwitchSelector,
			// Token: 0x0400016B RID: 363
			[Token(Token = "0x400016B")]
			TrackTransitionBySelector
		}

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		public enum SilentMode
		{
			// Token: 0x0400016D RID: 365
			[Token(Token = "0x400016D")]
			Normal,
			// Token: 0x0400016E RID: 366
			[Token(Token = "0x400016E")]
			Stop,
			// Token: 0x0400016F RID: 367
			[Token(Token = "0x400016F")]
			Virtual,
			// Token: 0x04000170 RID: 368
			[Token(Token = "0x4000170")]
			VirtualRetrigger
		}

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		public struct CueInfo
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x36DA600", Offset = "0x36D9200", VA = "0x1836DA600")]
			public CueInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000171 RID: 369
			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x04000172 RID: 370
			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public CriAtomEx.CueType type;

			// Token: 0x04000173 RID: 371
			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly string name;

			// Token: 0x04000174 RID: 372
			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string userData;

			// Token: 0x04000175 RID: 373
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long length;

			// Token: 0x04000176 RID: 374
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ushort[] categories;

			// Token: 0x04000177 RID: 375
			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public short numLimits;

			// Token: 0x04000178 RID: 376
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
			public ushort numBlocks;

			// Token: 0x04000179 RID: 377
			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public ushort numTracks;

			// Token: 0x0400017A RID: 378
			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
			public ushort numRelatedWaveForms;

			// Token: 0x0400017B RID: 379
			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte priority;

			// Token: 0x0400017C RID: 380
			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public byte headerVisibility;

			// Token: 0x0400017D RID: 381
			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			public byte ignore_player_parameter;

			// Token: 0x0400017E RID: 382
			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			public byte probability;

			// Token: 0x0400017F RID: 383
			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CriAtomEx.PanType panType;

			// Token: 0x04000180 RID: 384
			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CriAtomEx.CuePos3dInfo pos3dInfo;

			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public CriAtomEx.GameVariableInfo gameVariableInfo;

			// Token: 0x04000182 RID: 386
			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float volume;

			// Token: 0x04000183 RID: 387
			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public CriAtomEx.SilentMode silentMode;

			// Token: 0x04000184 RID: 388
			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float pitch;

			// Token: 0x04000185 RID: 389
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public ushort selectorIndex;
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		public struct WaveformInfo
		{
			// Token: 0x060001F3 RID: 499 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x36DE0F0", Offset = "0x36DCCF0", VA = "0x1836DE0F0")]
			public WaveformInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000186 RID: 390
			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int waveId;

			// Token: 0x04000187 RID: 391
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint format;

			// Token: 0x04000188 RID: 392
			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int samplingRate;

			// Token: 0x04000189 RID: 393
			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int numChannels;

			// Token: 0x0400018A RID: 394
			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long numSamples;

			// Token: 0x0400018B RID: 395
			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool streamingFlag;

			// Token: 0x0400018C RID: 396
			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint[] reserved;
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		public struct AisacInfo
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x36B3440", Offset = "0x36B2040", VA = "0x1836B3440")]
			public AisacInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x0400018D RID: 397
			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly string name;

			// Token: 0x0400018E RID: 398
			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool defaultControlFlag;

			// Token: 0x0400018F RID: 399
			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float defaultControlValue;

			// Token: 0x04000190 RID: 400
			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint controlId;

			// Token: 0x04000191 RID: 401
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly string controlName;
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		public struct PerformanceInfo
		{
			// Token: 0x04000192 RID: 402
			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint serverProcessCount;

			// Token: 0x04000193 RID: 403
			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint lastServerTime;

			// Token: 0x04000194 RID: 404
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint maxServerTime;

			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint averageServerTime;

			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint lastServerInterval;

			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint maxServerInterval;

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint averageServerInterval;
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		public struct ResourceUsage
		{
			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint useCount;

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint limit;
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public struct NativeVector
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x36DB840", Offset = "0x36DA440", VA = "0x1836DB840")]
			public NativeVector(float x, float y, float z)
			{
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
			public NativeVector(Vector3 vector)
			{
			}

			// Token: 0x0400019B RID: 411
			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float x;

			// Token: 0x0400019C RID: 412
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float y;

			// Token: 0x0400019D RID: 413
			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float z;
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public struct CueLinkInfo
		{
			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr nativePlayerHn;

			// Token: 0x0400019F RID: 415
			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint basePlaybackId;

			// Token: 0x040001A0 RID: 416
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint targetPlaybackId;

			// Token: 0x040001A1 RID: 417
			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int cueLinkType;
		}

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060001F8 RID: 504
		[Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void CueLinkCbFunc(ref CriAtomEx.CueLinkInfo info);
	}
}
