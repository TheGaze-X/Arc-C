using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public class Atlas : IEnumerable<AtlasRegion>, IEnumerable
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x4E41EA0", Offset = "0x4E40AA0", VA = "0x184E41EA0", Slot = "4")]
		public IEnumerator<AtlasRegion> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4E42DB0", Offset = "0x4E419B0", VA = "0x184E42DB0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700005A")]
		public List<AtlasRegion> Regions
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700005B")]
		public List<AtlasPage> Pages
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4E42E30", Offset = "0x4E41A30", VA = "0x184E42E30")]
		public Atlas(TextReader reader, string dir, TextureLoader textureLoader)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4E42F50", Offset = "0x4E41B50", VA = "0x184E42F50")]
		public Atlas(List<AtlasPage> pages, List<AtlasRegion> regions)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4E41F20", Offset = "0x4E40B20", VA = "0x184E41F20")]
		private void Load(TextReader reader, string imagesDir, TextureLoader textureLoader)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4E42CC0", Offset = "0x4E418C0", VA = "0x184E42CC0")]
		private static string ReadValue(TextReader reader)
		{
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x4E42AA0", Offset = "0x4E416A0", VA = "0x184E42AA0")]
		private static int ReadTuple(TextReader reader, string[] tuple)
		{
			return 0;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x4E41DE0", Offset = "0x4E409E0", VA = "0x184E41DE0")]
		public void FlipV()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x4E41D20", Offset = "0x4E40920", VA = "0x184E41D20")]
		public AtlasRegion FindRegion(string name)
		{
			return null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x4E41B90", Offset = "0x4E40790", VA = "0x184E41B90")]
		public void Dispose()
		{
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<AtlasPage> pages;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x18")]
		private List<AtlasRegion> regions;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x20")]
		private TextureLoader textureLoader;
	}
}
