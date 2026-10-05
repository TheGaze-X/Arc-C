using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace CriWare.CriTimeline.Mana
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	public class CriManaClip : CriManaClipBase
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x0000440C File Offset: 0x0000260C
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x370D820", Offset = "0x370C420", VA = "0x18370D820", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700009F")]
		public override string MoviePath
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000A0")]
		public override byte[] MovieData
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x370DAE0", Offset = "0x370C6E0", VA = "0x18370DAE0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000A1")]
		public override string MovieName
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x370DB70", Offset = "0x370C770", VA = "0x18370DB70", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00004424 File Offset: 0x00002624
		[Token(Token = "0x170000A2")]
		public override int DataId
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x370DA10", Offset = "0x370C610", VA = "0x18370DA10", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x370D8F0", Offset = "0x370C4F0", VA = "0x18370D8F0")]
		public CriManaClip()
		{
		}

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0xA0")]
		public string m_moviePath;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0xA8")]
		public TextAsset m_movieData;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0xB0")]
		public CriManaBehaviour m_manaBehaviour;
	}
}
