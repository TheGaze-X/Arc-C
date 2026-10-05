using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x020018CF RID: 6351
	[Token(Token = "0x20018CF")]
	public class PersistentImageProxy
	{
		// Token: 0x0600A03C RID: 41020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A03C")]
		[Address(RVA = "0x31B8BF0", Offset = "0x31B77F0", VA = "0x1831B8BF0")]
		private void _LoadCacheInfo()
		{
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A03D")]
		[Address(RVA = "0x31B8EF0", Offset = "0x31B7AF0", VA = "0x1831B8EF0")]
		private void _SaveCacheInfo()
		{
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A03E")]
		[Address(RVA = "0x31B9190", Offset = "0x31B7D90", VA = "0x1831B9190")]
		public string _StringifyDIYPreset(IDIYPreset preset)
		{
			return null;
		}

		// Token: 0x0600A03F RID: 41023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A03F")]
		[Address(RVA = "0x31B8B30", Offset = "0x31B7730", VA = "0x1831B8B30")]
		private Func<char, string> _GetStringReadFunc(string str)
		{
			return null;
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A040")]
		[Address(RVA = "0x31B8860", Offset = "0x31B7460", VA = "0x1831B8860")]
		private PersistentImageProxy.CacheInfo _GetCacheInfo(IDIYPreset preset, bool needCreate)
		{
			return null;
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		[Token(Token = "0x600A041")]
		[Address(RVA = "0x31B81F0", Offset = "0x31B6DF0", VA = "0x1831B81F0")]
		public bool _DIYPresetStringMatch(IDIYPreset preset, string str)
		{
			return default(bool);
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A042")]
		[Address(RVA = "0x31B7D50", Offset = "0x31B6950", VA = "0x1831B7D50")]
		public void Setup(string basePath)
		{
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A043")]
		[Address(RVA = "0x31B8A00", Offset = "0x31B7600", VA = "0x1831B8A00")]
		private string _GetNextFileName()
		{
			return null;
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A044")]
		[Address(RVA = "0x31B7F10", Offset = "0x31B6B10", VA = "0x1831B7F10")]
		public Texture2D TryFetchLocalTexture(IDIYPreset preset)
		{
			return null;
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A045")]
		[Address(RVA = "0x31B7C60", Offset = "0x31B6860", VA = "0x1831B7C60")]
		public IEnumerator QueryImage(IDIYPreset preset, string url, Action<Texture2D> successHandler, [Optional] Action failureHandler, float timeOut = 5f)
		{
			return null;
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x0003E808 File Offset: 0x0003CA08
		[Token(Token = "0x600A046")]
		[Address(RVA = "0x31B7BA0", Offset = "0x31B67A0", VA = "0x1831B7BA0")]
		public int GetLocalCacheFileStorageCost()
		{
			return 0;
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A047")]
		[Address(RVA = "0x31B7710", Offset = "0x31B6310", VA = "0x1831B7710")]
		public void ClearCache(IDIYPresetProvider provider)
		{
		}

		// Token: 0x0600A048 RID: 41032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A048")]
		[Address(RVA = "0x31B9A50", Offset = "0x31B8650", VA = "0x1831B9A50")]
		public PersistentImageProxy()
		{
		}

		// Token: 0x0400967C RID: 38524
		[Token(Token = "0x400967C")]
		private const string CACHE_MAP_FILE_NAME = "cache_map";

		// Token: 0x0400967D RID: 38525
		[Token(Token = "0x400967D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, Texture2D> m_imageCache;

		// Token: 0x0400967E RID: 38526
		[Token(Token = "0x400967E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_basePath;

		// Token: 0x0400967F RID: 38527
		[Token(Token = "0x400967F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<PersistentImageProxy.CacheInfo> m_cacheInfoList;

		// Token: 0x04009680 RID: 38528
		[Token(Token = "0x4009680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_cacheInfoFileName;

		// Token: 0x020018D0 RID: 6352
		[Token(Token = "0x20018D0")]
		private class CacheInfo
		{
			// Token: 0x0600A049 RID: 41033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A049")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CacheInfo()
			{
			}

			// Token: 0x04009681 RID: 38529
			[Token(Token = "0x4009681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string fileName;

			// Token: 0x04009682 RID: 38530
			[Token(Token = "0x4009682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string presetString;
		}

		// Token: 0x020018D1 RID: 6353
		[Token(Token = "0x20018D1")]
		public struct PerfReport
		{
			// Token: 0x04009683 RID: 38531
			[Token(Token = "0x4009683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string basePath;

			// Token: 0x04009684 RID: 38532
			[Token(Token = "0x4009684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<PersistentImageProxy.PerfReport.CacheItemInfo> memCacheItemInfos;

			// Token: 0x04009685 RID: 38533
			[Token(Token = "0x4009685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<PersistentImageProxy.PerfReport.CacheItemInfo> localCacheItemInfos;

			// Token: 0x04009686 RID: 38534
			[Token(Token = "0x4009686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PersistentImageProxy.PerfReport.CacheItemInfo mapInfo;

			// Token: 0x020018D2 RID: 6354
			[Token(Token = "0x20018D2")]
			public struct CacheItemInfo
			{
				// Token: 0x04009687 RID: 38535
				[Token(Token = "0x4009687")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string name;

				// Token: 0x04009688 RID: 38536
				[Token(Token = "0x4009688")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public int size;

				// Token: 0x04009689 RID: 38537
				[Token(Token = "0x4009689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public bool available;
			}
		}
	}
}
