using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using XLua;

namespace Torappu.Audio.Engine.Unity
{
	// Token: 0x02001FCF RID: 8143
	[Token(Token = "0x2001FCF")]
	public class UnityAudioEngine : AudioEngine
	{
		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x0600CA16 RID: 51734 RVA: 0x00049578 File Offset: 0x00047778
		[Token(Token = "0x170017E9")]
		public override AudioEngineType engineType
		{
			[Token(Token = "0x600CA16")]
			[Address(RVA = "0x34B7730", Offset = "0x34B6330", VA = "0x1834B7730", Slot = "9")]
			get
			{
				return AudioEngineType.UNITY;
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x0600CA17 RID: 51735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017EA")]
		public override AudioAssetManager assetMgr
		{
			[Token(Token = "0x600CA17")]
			[Address(RVA = "0x34B76D0", Offset = "0x34B62D0", VA = "0x1834B76D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CA18 RID: 51736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA18")]
		[Address(RVA = "0x34B64A0", Offset = "0x34B50A0", VA = "0x1834B64A0", Slot = "8")]
		public override AudioPlayback CreatePlayback()
		{
			return null;
		}

		// Token: 0x0600CA19 RID: 51737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA19")]
		[Address(RVA = "0x34B6C80", Offset = "0x34B5880", VA = "0x1834B6C80", Slot = "11")]
		protected override void SetMixerParamImpl(string name, float value)
		{
		}

		// Token: 0x0600CA1A RID: 51738 RVA: 0x00049590 File Offset: 0x00047790
		[Token(Token = "0x600CA1A")]
		[Address(RVA = "0x34B6960", Offset = "0x34B5560", VA = "0x1834B6960", Slot = "10")]
		protected override bool GetMixerParamImpl(string name, out float value)
		{
			return default(bool);
		}

		// Token: 0x0600CA1B RID: 51739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA1B")]
		[Address(RVA = "0x34B6410", Offset = "0x34B5010", VA = "0x1834B6410", Slot = "13")]
		public override Component CreateAudioListener(GameObject listenerObj)
		{
			return null;
		}

		// Token: 0x0600CA1C RID: 51740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA1C")]
		[Address(RVA = "0x34B6A10", Offset = "0x34B5610", VA = "0x1834B6A10", Slot = "14")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CA1D RID: 51741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA1D")]
		[Address(RVA = "0x34B6BB0", Offset = "0x34B57B0", VA = "0x1834B6BB0", Slot = "15")]
		protected override void OnReloadBanks()
		{
		}

		// Token: 0x0600CA1E RID: 51742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA1E")]
		[Address(RVA = "0x34B65A0", Offset = "0x34B51A0", VA = "0x1834B65A0")]
		public AudioMixerGroup GetMixerByDesc(MixerDesc desc)
		{
			return null;
		}

		// Token: 0x0600CA1F RID: 51743 RVA: 0x000495A8 File Offset: 0x000477A8
		[Token(Token = "0x600CA1F")]
		[Address(RVA = "0x34B6D30", Offset = "0x34B5930", VA = "0x1834B6D30", Slot = "12")]
		public override bool TransitionToSnapshot(SnapshotTransition transition)
		{
			return default(bool);
		}

		// Token: 0x0600CA20 RID: 51744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA20")]
		[Address(RVA = "0x34B74A0", Offset = "0x34B60A0", VA = "0x1834B74A0")]
		private IEnumerator _TransitionToSnapshotDelayRoutine(AudioMixerSnapshot[] snapshots, float[] weights, float duration, float delay)
		{
			return null;
		}

		// Token: 0x0600CA21 RID: 51745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA21")]
		[Address(RVA = "0x34B7330", Offset = "0x34B5F30", VA = "0x1834B7330")]
		private AudioMixerSnapshot _FindSnapshot(string name)
		{
			return null;
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA22")]
		[Address(RVA = "0x34B75D0", Offset = "0x34B61D0", VA = "0x1834B75D0")]
		public UnityAudioEngine()
		{
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA23")]
		[Address(RVA = "0x34B7310", Offset = "0x34B5F10", VA = "0x1834B7310")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CA24 RID: 51748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA24")]
		[Address(RVA = "0x34B7320", Offset = "0x34B5F20", VA = "0x1834B7320")]
		private void <>xLuaBaseProxy_OnReloadBanks()
		{
		}

		// Token: 0x0400D2A4 RID: 53924
		[Token(Token = "0x400D2A4")]
		[FieldOffset(Offset = "0x38")]
		private AudioClipManager m_clipManager;

		// Token: 0x0400D2A5 RID: 53925
		[Token(Token = "0x400D2A5")]
		[FieldOffset(Offset = "0x40")]
		private AudioOptions m_audioOptions;

		// Token: 0x0400D2A6 RID: 53926
		[Token(Token = "0x400D2A6")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, AudioMixerGroup> m_findGroupCache;

		// Token: 0x0400D2A7 RID: 53927
		[Token(Token = "0x400D2A7")]
		[FieldOffset(Offset = "0x50")]
		private ListDict<string, AudioMixerSnapshot> m_findSnapshotCache;

		// Token: 0x0400D2A8 RID: 53928
		[Token(Token = "0x400D2A8")]
		[FieldOffset(Offset = "0x58")]
		private IEnumerator m_snapshotDelay;

		// Token: 0x0400D2A9 RID: 53929
		[Token(Token = "0x400D2A9")]
		[FieldOffset(Offset = "0x60")]
		private AudioMixerSnapshot[] m_singleSnapshot;

		// Token: 0x0400D2AA RID: 53930
		[Token(Token = "0x400D2AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_engineType;

		// Token: 0x0400D2AB RID: 53931
		[Token(Token = "0x400D2AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_assetMgr;

		// Token: 0x0400D2AC RID: 53932
		[Token(Token = "0x400D2AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreatePlayback;

		// Token: 0x0400D2AD RID: 53933
		[Token(Token = "0x400D2AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetMixerParamImpl;

		// Token: 0x0400D2AE RID: 53934
		[Token(Token = "0x400D2AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMixerParamImpl;

		// Token: 0x0400D2AF RID: 53935
		[Token(Token = "0x400D2AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateAudioListener;

		// Token: 0x0400D2B0 RID: 53936
		[Token(Token = "0x400D2B0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D2B1 RID: 53937
		[Token(Token = "0x400D2B1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnReloadBanks;

		// Token: 0x0400D2B2 RID: 53938
		[Token(Token = "0x400D2B2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetMixerByDesc;

		// Token: 0x0400D2B3 RID: 53939
		[Token(Token = "0x400D2B3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TransitionToSnapshot;

		// Token: 0x0400D2B4 RID: 53940
		[Token(Token = "0x400D2B4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TransitionToSnapshotDelayRoutine;

		// Token: 0x0400D2B5 RID: 53941
		[Token(Token = "0x400D2B5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FindSnapshot;

		// Token: 0x0400D2B6 RID: 53942
		[Token(Token = "0x400D2B6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
