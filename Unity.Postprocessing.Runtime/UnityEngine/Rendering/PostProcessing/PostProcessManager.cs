using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public sealed class PostProcessManager
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000012")]
		public static PostProcessManager instance
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x5841540", Offset = "0x5840140", VA = "0x185841540")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x5841320", Offset = "0x583FF20", VA = "0x185841320")]
		private PostProcessManager()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x583EEA0", Offset = "0x583DAA0", VA = "0x18583EEA0")]
		private void CleanBaseTypes()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5840100", Offset = "0x583ED00", VA = "0x185840100")]
		private void ReloadBaseTypes()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x583F0A0", Offset = "0x583DCA0", VA = "0x18583F0A0")]
		public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x583F690", Offset = "0x583E290", VA = "0x18583F690")]
		public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
		{
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x583F760", Offset = "0x583E360", VA = "0x18583F760")]
		public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
		{
			return null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x583FD10", Offset = "0x583E910", VA = "0x18583FD10")]
		public PostProcessVolume QuickVolume(int layer, float priority, params PostProcessEffectSettings[] settings)
		{
			return null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5840830", Offset = "0x583F430", VA = "0x185840830")]
		internal void SetLayerDirty(int layer)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x58412E0", Offset = "0x583FEE0", VA = "0x1858412E0")]
		internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x583FF00", Offset = "0x583EB00", VA = "0x18583FF00")]
		private void Register(PostProcessVolume volume, int layer)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x58400B0", Offset = "0x583ECB0", VA = "0x1858400B0")]
		internal void Register(PostProcessVolume volume)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x5840AF0", Offset = "0x583F6F0", VA = "0x185840AF0")]
		private void Unregister(PostProcessVolume volume, int layer)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5840AA0", Offset = "0x583F6A0", VA = "0x185840AA0")]
		internal void Unregister(PostProcessVolume volume)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5840610", Offset = "0x583F210", VA = "0x185840610")]
		private void ReplaceData(PostProcessLayer postProcessLayer)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5840C80", Offset = "0x583F880", VA = "0x185840C80")]
		internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x583F900", Offset = "0x583E500", VA = "0x18583F900")]
		private List<PostProcessVolume> GrabVolumes(LayerMask mask)
		{
			return null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x5840990", Offset = "0x583F590", VA = "0x185840990")]
		private static void SortByPriority(List<PostProcessVolume> volumes)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
		{
			return default(bool);
		}

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x0")]
		private static PostProcessManager s_Instance;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		private const int k_MaxLayerCount = 32;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<PostProcessVolume> m_Volumes;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, bool> m_SortNeeded;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<PostProcessEffectSettings> m_BaseSettings;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<Collider> m_TempColliders;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x38")]
		public readonly Dictionary<Type, PostProcessAttribute> settingsTypes;
	}
}
