using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	public static class UIParticleUpdater
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00006FBC File Offset: 0x000051BC
		[Token(Token = "0x170000D0")]
		public static int uiParticleCount
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x55454F0", Offset = "0x55440F0", VA = "0x1855454F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x5544A10", Offset = "0x5543610", VA = "0x185544A10")]
		public static void Register(UIParticle particle)
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x5544AD0", Offset = "0x55436D0", VA = "0x185544AD0")]
		public static void Unregister(UIParticle particle)
		{
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x5544960", Offset = "0x5543560", VA = "0x185544960")]
		public static void Register(UIParticleAttractor attractor)
		{
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x5544B90", Offset = "0x5543790", VA = "0x185544B90")]
		public static void Unregister(UIParticleAttractor attractor)
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x5545250", Offset = "0x5543E50", VA = "0x185545250")]
		private static void _UpdateSystemActivateStatus()
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x5544C40", Offset = "0x5543840", VA = "0x185544C40")]
		private static void _Refresh()
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x55445A0", Offset = "0x55431A0", VA = "0x1855445A0")]
		public static void GetGroupedRenderers(long groupId, int index, List<UIParticleRenderer> results)
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x5544770", Offset = "0x5543370", VA = "0x185544770")]
		public static UIParticle GetPrimary(long groupId)
		{
			return null;
		}

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<UIParticle> s_activeParticles;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<UIParticleAttractor> s_activeAttractors;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x10")]
		private static readonly LongHashSet s_updatedGroupIds;

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0x18")]
		private static int s_frameCount;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0x1C")]
		private static bool s_isSystemActivated;
	}
}
