using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Engine.Unity
{
	// Token: 0x02001FCC RID: 8140
	[Token(Token = "0x2001FCC")]
	public class AudioClipManager : AudioAssetManager
	{
		// Token: 0x0600CA05 RID: 51717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA05")]
		[Address(RVA = "0x349EEC0", Offset = "0x349DAC0", VA = "0x18349EEC0")]
		public AudioClipManager()
		{
		}

		// Token: 0x0600CA06 RID: 51718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA06")]
		[Address(RVA = "0x349E950", Offset = "0x349D550", VA = "0x18349E950")]
		private AudioClip _LoadClip(string key, [Optional] string persistTag, bool forceLoadData = false)
		{
			return null;
		}

		// Token: 0x0600CA07 RID: 51719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA07")]
		[Address(RVA = "0x349EBF0", Offset = "0x349D7F0", VA = "0x18349EBF0")]
		private void _UnloadClipByRef(string key)
		{
		}

		// Token: 0x0600CA08 RID: 51720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA08")]
		[Address(RVA = "0x349E850", Offset = "0x349D450", VA = "0x18349E850")]
		private List<AudioClipManager.AudioClipResource> _FindClipsWithPersistTag(string persistTag)
		{
			return null;
		}

		// Token: 0x0600CA09 RID: 51721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA09")]
		[Address(RVA = "0x349EC80", Offset = "0x349D880", VA = "0x18349EC80")]
		private void _UnloadClips(AudioAssetRefCollection collection)
		{
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA0A")]
		[Address(RVA = "0x349EA10", Offset = "0x349D610", VA = "0x18349EA10")]
		private void _UnloadAll()
		{
		}

		// Token: 0x0600CA0B RID: 51723 RVA: 0x00049530 File Offset: 0x00047730
		[Token(Token = "0x600CA0B")]
		[Address(RVA = "0x349E4D0", Offset = "0x349D0D0", VA = "0x18349E4D0", Slot = "6")]
		protected override AudioAsset LoadSound(string name, ISoundInfo info, LoadAssetOptions options)
		{
			return default(AudioAsset);
		}

		// Token: 0x0600CA0C RID: 51724 RVA: 0x00049548 File Offset: 0x00047748
		[Token(Token = "0x600CA0C")]
		[Address(RVA = "0x349E220", Offset = "0x349CE20", VA = "0x18349E220", Slot = "7")]
		protected override AudioAsset LoadMusic(string name, IMusicInfo info, LoadAssetOptions options)
		{
			return default(AudioAsset);
		}

		// Token: 0x0600CA0D RID: 51725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA0D")]
		[Address(RVA = "0x349E730", Offset = "0x349D330", VA = "0x18349E730", Slot = "10")]
		public override void UnloadAssetByRef(AudioAsset asset)
		{
		}

		// Token: 0x0600CA0E RID: 51726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA0E")]
		[Address(RVA = "0x349DFB0", Offset = "0x349CBB0", VA = "0x18349DFB0", Slot = "8")]
		public override void FindAssetsByTag(string persistTag, AudioAssetRefCollection collection)
		{
		}

		// Token: 0x0600CA0F RID: 51727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA0F")]
		[Address(RVA = "0x349E1A0", Offset = "0x349CDA0", VA = "0x18349E1A0", Slot = "9")]
		public override void ForceUnloadAssets(AudioAssetRefCollection collection)
		{
		}

		// Token: 0x0600CA10 RID: 51728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA10")]
		[Address(RVA = "0x349E6A0", Offset = "0x349D2A0", VA = "0x18349E6A0", Slot = "11")]
		public override void OnReloadBanks()
		{
		}

		// Token: 0x0600CA11 RID: 51729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA11")]
		[Address(RVA = "0x349DF50", Offset = "0x349CB50", VA = "0x18349DF50", Slot = "12")]
		public override void Dispose()
		{
		}

		// Token: 0x0400D293 RID: 53907
		[Token(Token = "0x400D293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AudioClipManager.AudioClipResPool m_clipPool;

		// Token: 0x0400D294 RID: 53908
		[Token(Token = "0x400D294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_allowAssetMissing;

		// Token: 0x0400D295 RID: 53909
		[Token(Token = "0x400D295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<AudioClipManager.AudioClipResource> m_tempClips;

		// Token: 0x0400D296 RID: 53910
		[Token(Token = "0x400D296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400D297 RID: 53911
		[Token(Token = "0x400D297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadClip;

		// Token: 0x0400D298 RID: 53912
		[Token(Token = "0x400D298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UnloadClipByRef;

		// Token: 0x0400D299 RID: 53913
		[Token(Token = "0x400D299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FindClipsWithPersistTag;

		// Token: 0x0400D29A RID: 53914
		[Token(Token = "0x400D29A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UnloadClips;

		// Token: 0x0400D29B RID: 53915
		[Token(Token = "0x400D29B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UnloadAll;

		// Token: 0x0400D29C RID: 53916
		[Token(Token = "0x400D29C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadSound;

		// Token: 0x0400D29D RID: 53917
		[Token(Token = "0x400D29D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadMusic;

		// Token: 0x0400D29E RID: 53918
		[Token(Token = "0x400D29E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UnloadAssetByRef;

		// Token: 0x0400D29F RID: 53919
		[Token(Token = "0x400D29F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FindAssetsByTag;

		// Token: 0x0400D2A0 RID: 53920
		[Token(Token = "0x400D2A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ForceUnloadAssets;

		// Token: 0x0400D2A1 RID: 53921
		[Token(Token = "0x400D2A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnReloadBanks;

		// Token: 0x0400D2A2 RID: 53922
		[Token(Token = "0x400D2A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x02001FCD RID: 8141
		[Token(Token = "0x2001FCD")]
		public class AudioClipResource : RefCountedPoolItem<AudioClip>
		{
			// Token: 0x0600CA12 RID: 51730 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CA12")]
			[Address(RVA = "0x349F170", Offset = "0x349DD70", VA = "0x18349F170")]
			public AudioClipResource()
			{
			}
		}

		// Token: 0x02001FCE RID: 8142
		[Token(Token = "0x2001FCE")]
		private class AudioClipResPool : RefCountedPool<AudioClipManager.AudioClipResource, AudioClip>
		{
			// Token: 0x0600CA13 RID: 51731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CA13")]
			[Address(RVA = "0x349F110", Offset = "0x349DD10", VA = "0x18349F110")]
			public AudioClipResPool(AudioClipManager closure)
			{
			}

			// Token: 0x0600CA14 RID: 51732 RVA: 0x00049560 File Offset: 0x00047760
			[Token(Token = "0x600CA14")]
			[Address(RVA = "0x349EF90", Offset = "0x349DB90", VA = "0x18349EF90", Slot = "4")]
			protected override bool LoadObjectToItem(AudioClipManager.AudioClipResource item)
			{
				return default(bool);
			}

			// Token: 0x0600CA15 RID: 51733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CA15")]
			[Address(RVA = "0x349F090", Offset = "0x349DC90", VA = "0x18349F090", Slot = "5")]
			protected override void ReleaseObject(AudioClipManager.AudioClipResource item)
			{
			}

			// Token: 0x0400D2A3 RID: 53923
			[Token(Token = "0x400D2A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private AudioClipManager m_closure;
		}
	}
}
