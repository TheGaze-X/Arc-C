using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200379D RID: 14237
	[Token(Token = "0x200379D")]
	public class AutoUnloadAssets
	{
		// Token: 0x0601695B RID: 92507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601695B")]
		[Address(RVA = "0xEF0AB0", Offset = "0xEEF6B0", VA = "0x180EF0AB0")]
		private AutoUnloadAssets()
		{
		}

		// Token: 0x0601695C RID: 92508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601695C")]
		[Address(RVA = "0xEF0120", Offset = "0xEEED20", VA = "0x180EF0120")]
		public static AutoUnloadAssets Create(ILoadAsset assetGroup, AutoUnloadAssets.IHost host)
		{
			return null;
		}

		// Token: 0x0601695D RID: 92509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601695D")]
		public T LoadAsset<T>(string path, out bool isNewlyLoaded) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0601695E RID: 92510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601695E")]
		[Address(RVA = "0xEF02C0", Offset = "0xEEEEC0", VA = "0x180EF02C0")]
		public UnityEngine.Object LoadAsset(string path, out bool isNewlyLoaded)
		{
			return null;
		}

		// Token: 0x0601695F RID: 92511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601695F")]
		[Address(RVA = "0xEF0320", Offset = "0xEEEF20", VA = "0x180EF0320")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06016960 RID: 92512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016960")]
		[Address(RVA = "0xEF0570", Offset = "0xEEF170", VA = "0x180EF0570")]
		public void UnloadUnusedAssets()
		{
		}

		// Token: 0x0401B398 RID: 111512
		[Token(Token = "0x401B398")]
		[FieldOffset(Offset = "0x10")]
		private AutoUnloadAssets.IHost m_host;

		// Token: 0x0401B399 RID: 111513
		[Token(Token = "0x401B399")]
		[FieldOffset(Offset = "0x18")]
		private ILoadAsset m_assets;

		// Token: 0x0401B39A RID: 111514
		[Token(Token = "0x401B39A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, AutoUnloadAssets.AssetInfo> m_loadedAssets;

		// Token: 0x0401B39B RID: 111515
		[Token(Token = "0x401B39B")]
		[FieldOffset(Offset = "0x28")]
		private LocalGenericPool<AutoUnloadAssets.AssetInfo> m_infoPool;

		// Token: 0x0401B39C RID: 111516
		[Token(Token = "0x401B39C")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<UnityEngine.Object> m_usedAssetsCache;

		// Token: 0x0200379E RID: 14238
		[Token(Token = "0x200379E")]
		public interface IHost
		{
			// Token: 0x06016961 RID: 92513
			[Token(Token = "0x6016961")]
			void CollectUsedAssets(ICollection<UnityEngine.Object> usedAssets);
		}

		// Token: 0x0200379F RID: 14239
		[Token(Token = "0x200379F")]
		private class AssetInfo
		{
			// Token: 0x06016962 RID: 92514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016962")]
			[Address(RVA = "0xEEF350", Offset = "0xEEDF50", VA = "0x180EEF350")]
			public static void Reset(AutoUnloadAssets.AssetInfo info)
			{
			}

			// Token: 0x06016963 RID: 92515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016963")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AssetInfo()
			{
			}

			// Token: 0x0401B39D RID: 111517
			[Token(Token = "0x401B39D")]
			[FieldOffset(Offset = "0x10")]
			public string path;

			// Token: 0x0401B39E RID: 111518
			[Token(Token = "0x401B39E")]
			[FieldOffset(Offset = "0x18")]
			public UnityEngine.Object asset;
		}
	}
}
