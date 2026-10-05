using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[AddComponentMenu("CRIWARE/CRI Atom")]
	public class CriAtom : CriMonoBehaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		public static int GetThreadPriorityANDROID()
		{
			return 0;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetThreadPriorityANDROID(int prio)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		internal static bool HasUserCallback
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x36DA3A0", Offset = "0x36D8FA0", VA = "0x1836DA3A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		internal static event CriAtomExSequencer.EventCallback OnEventSequencerCallback
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x36CA2E0", Offset = "0x36C8EE0", VA = "0x1836CA2E0")]
			add
			{
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x36CA2F0", Offset = "0x36C8EF0", VA = "0x1836CA2F0")]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		private static event CriAtomExBeatSync.CbFunc beatsyncUserCbFunc
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x36DA0A0", Offset = "0x36D8CA0", VA = "0x1836DA0A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x36DA420", Offset = "0x36D9020", VA = "0x1836DA420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000002")]
		internal static bool HasBeatSyncCallback
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x36DA320", Offset = "0x36D8F20", VA = "0x1836DA320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		internal static event CriAtomExBeatSync.CbFunc OnBeatSyncCallback
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x36C4FA0", Offset = "0x36C3BA0", VA = "0x1836C4FA0")]
			add
			{
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x36C4FB0", Offset = "0x36C3BB0", VA = "0x1836C4FB0")]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000004")]
		private static event CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x36DA160", Offset = "0x36D8D60", VA = "0x1836DA160")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x36DA4E0", Offset = "0x36D90E0", VA = "0x1836DA4E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x17000003")]
		internal static bool HasCueLinkCallback
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x36DA360", Offset = "0x36D8F60", VA = "0x1836DA360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000005")]
		internal static event CriAtomEx.CueLinkCbFunc OnCueLinkCallback
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x36CC660", Offset = "0x36CB260", VA = "0x1836CC660")]
			add
			{
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x36CD9B0", Offset = "0x36CC5B0", VA = "0x1836CD9B0")]
			remove
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		private static CriAtom instance
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x36DA3E0", Offset = "0x36D8FE0", VA = "0x1836DA3E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x36DA5A0", Offset = "0x36D91A0", VA = "0x1836DA5A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x36D7480", Offset = "0x36D6080", VA = "0x1836D7480")]
		public static void AttachDspBusSetting(string settingName)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x36D7980", Offset = "0x36D6580", VA = "0x1836D7980")]
		public static void DetachDspBusSetting()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x36D7C50", Offset = "0x36D6850", VA = "0x1836D7C50")]
		public static CriAtomCueSheet GetCueSheet(string name)
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x36D7380", Offset = "0x36D5F80", VA = "0x1836D7380")]
		public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, [Optional] CriFsBinder binder)
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x36D6E90", Offset = "0x36D5A90", VA = "0x1836D6E90")]
		public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, [Optional] CriFsBinder binder, bool loadAwbOnMemory = false)
		{
			return null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x36D7260", Offset = "0x36D5E60", VA = "0x1836D7260")]
		public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, [Optional] CriFsBinder awbBinder)
		{
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x36D6CE0", Offset = "0x36D58E0", VA = "0x1836D6CE0")]
		public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, [Optional] CriFsBinder awbBinder, bool loadAwbOnMemory = false)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x36D9240", Offset = "0x36D7E40", VA = "0x1836D9240")]
		public static void RemoveCueSheet(string name)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x17000005")]
		public static bool CueSheetsAreLoading
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x36DA220", Offset = "0x36D8E20", VA = "0x1836DA220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x36D7A20", Offset = "0x36D6620", VA = "0x1836D7A20")]
		public static CriAtomExAcb GetAcb(string cueSheetName)
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x36C6AF0", Offset = "0x36C56F0", VA = "0x1836C6AF0")]
		public static void SetCategoryVolume(string name, float volume)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x36C6A60", Offset = "0x36C5660", VA = "0x1836C6A60")]
		public static void SetCategoryVolume(int id, float volume)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x36C5DC0", Offset = "0x36C49C0", VA = "0x1836C5DC0")]
		public static float GetCategoryVolume(string name)
		{
			return 0f;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x36C5E60", Offset = "0x36C4A60", VA = "0x1836C5E60")]
		public static float GetCategoryVolume(int id)
		{
			return 0f;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x36D93D0", Offset = "0x36D7FD0", VA = "0x1836D93D0")]
		public static void SetBusAnalyzer(string busName, bool sw)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x36D9500", Offset = "0x36D8100", VA = "0x1836D9500")]
		public static void SetBusAnalyzer(bool sw)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x36D7B50", Offset = "0x36D6750", VA = "0x1836D7B50")]
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName)
		{
			return default(CriAtomExAsr.BusAnalyzerInfo);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x36D7B80", Offset = "0x36D6780", VA = "0x1836D7B80")]
		[Obsolete("Use CriAtom.GetBusAnalyzerInfo(string busName)")]
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId)
		{
			return default(CriAtomExAsr.BusAnalyzerInfo);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x36D9900", Offset = "0x36D8500", VA = "0x1836D9900")]
		public void Setup()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x36D9D40", Offset = "0x36D8940", VA = "0x1836D9D40")]
		public void Shutdown()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x36D7610", Offset = "0x36D6210", VA = "0x1836D7610")]
		private void Awake()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x36D88A0", Offset = "0x36D74A0", VA = "0x1836D88A0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x36D8730", Offset = "0x36D7330", VA = "0x1836D8730")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x36D7BB0", Offset = "0x36D67B0", VA = "0x1836D7BB0")]
		public CriAtomCueSheet GetCueSheetInternal(string name)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x36D7030", Offset = "0x36D5C30", VA = "0x1836D7030")]
		public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder)
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x36D9080", Offset = "0x36D7C80", VA = "0x1836D9080")]
		public void RemoveCueSheetInternal(string name)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x36D8520", Offset = "0x36D7120", VA = "0x1836D8520")]
		private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x36D8280", Offset = "0x36D6E80", VA = "0x1836D8280")]
		private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x36D7E90", Offset = "0x36D6A90", VA = "0x1836D7E90")]
		private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile)
		{
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x36D8090", Offset = "0x36D6C90", VA = "0x1836D8090")]
		private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x36D8190", Offset = "0x36D6D90", VA = "0x1836D8190")]
		private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x36D7CB0", Offset = "0x36D68B0", VA = "0x1836D7CB0")]
		private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x36D7DA0", Offset = "0x36D69A0", VA = "0x1836D7DA0")]
		private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x36D9370", Offset = "0x36D7F70", VA = "0x1836D9370")]
		[MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCbFunc))]
		public static void SequenceEventCallbackFromNative(string eventString)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x36D9310", Offset = "0x36D7F10", VA = "0x1836D9310")]
		[MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCallback))]
		private static void SequenceCallbackFromNative(ref CriAtomExSequencer.CriAtomExSequenceEventInfo criAtomExSequenceInfo)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x36D78C0", Offset = "0x36D64C0", VA = "0x1836D78C0")]
		[MonoPInvokeCallback(typeof(CriAtomExBeatSync.CbFunc))]
		public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x36D7920", Offset = "0x36D6520", VA = "0x1836D7920")]
		[MonoPInvokeCallback(typeof(CriAtomEx.CueLinkCbFunc))]
		public static void CueLinkCallbackFromNative(ref CriAtomEx.CueLinkInfo info)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x36D9690", Offset = "0x36D8290", VA = "0x1836D9690")]
		public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x36D8E00", Offset = "0x36D7A00", VA = "0x1836D8E00")]
		private static void RegisterEventCallbackChain(CriAtomExSequencer.EventCallback func)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x36CA2F0", Offset = "0x36C8EF0", VA = "0x1836CA2F0")]
		private static void UnregisterEventCallbackChain(CriAtomExSequencer.EventCallback func)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x36C4E80", Offset = "0x36C3A80", VA = "0x1836C4E80")]
		public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x36D8940", Offset = "0x36D7540", VA = "0x1836D8940")]
		private static void RegisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x36D9ED0", Offset = "0x36D8AD0", VA = "0x1836D9ED0")]
		private static void UnregisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x36D8BA0", Offset = "0x36D77A0", VA = "0x1836D8BA0")]
		private static void RegisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x36CD9B0", Offset = "0x36CC5B0", VA = "0x1836CD9B0")]
		private static void UnregisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x36DA000", Offset = "0x36D8C00", VA = "0x1836DA000")]
		public CriAtom()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string acfFile;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool acfIsLoading;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CriAtomCueSheet[] cueSheets;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string dspBusSetting;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool dontDestroyOnLoad;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CriAtomExSequencer.EventCallback eventUserCallback;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static CriAtomExSequencer.EventCbFunc eventUserCbFunc;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static CriAtomExBeatSync.CbFunc obsoleteBeatSyncFunc;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GCHandle acfRegisterGCHandle;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool dontRemoveExistsCueSheet;

		// Token: 0x02000003 RID: 3
		[Token(Token = "0x2000003")]
		protected class NativeMethods
		{
			// Token: 0x06000042 RID: 66 RVA: 0x0000212C File Offset: 0x0000032C
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			internal static int criAtom_GetThreadPriority_ANDROID()
			{
				return 0;
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			internal static void criAtom_SetThreadPriority_ANDROID(int prio)
			{
			}

			// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NativeMethods()
			{
			}
		}

		// Token: 0x02000004 RID: 4
		[Token(Token = "0x2000004")]
		public enum SpeakerMapping
		{
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			Auto,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			Monaural,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			Stereo,
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			Ch5_1,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			Ch7_1,
			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			Ch5_1_2,
			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			Ch7_1_2,
			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			Ch7_1_4,
			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			Ch7_1_4_4,
			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			Ambisonics1p,
			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			Ambisonics2p,
			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			Ambisonics3p,
			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			Object,
			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			Custom
		}
	}
}
