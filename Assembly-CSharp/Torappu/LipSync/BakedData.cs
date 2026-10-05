using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DB;

namespace Torappu.LipSync
{
	// Token: 0x0200145E RID: 5214
	[Token(Token = "0x200145E")]
	public class BakedData
	{
		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x060078C2 RID: 30914 RVA: 0x000365B8 File Offset: 0x000347B8
		// (set) Token: 0x060078C3 RID: 30915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E6C")]
		public int frequency
		{
			[Token(Token = "0x60078C2")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60078C3")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x060078C4 RID: 30916 RVA: 0x000365D0 File Offset: 0x000347D0
		// (set) Token: 0x060078C5 RID: 30917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E6D")]
		public float duration
		{
			[Token(Token = "0x60078C4")]
			[Address(RVA = "0x73B8E0", Offset = "0x73A4E0", VA = "0x18073B8E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60078C5")]
			[Address(RVA = "0x73B910", Offset = "0x73A510", VA = "0x18073B910")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x060078C6 RID: 30918 RVA: 0x000365E8 File Offset: 0x000347E8
		[Token(Token = "0x17000E6E")]
		public bool isValid
		{
			[Token(Token = "0x60078C6")]
			[Address(RVA = "0x26364D0", Offset = "0x26350D0", VA = "0x1826364D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060078C7 RID: 30919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078C7")]
		[Address(RVA = "0x2636040", Offset = "0x2634C40", VA = "0x182636040")]
		public BakedFrame GetFrame(float t)
		{
			return null;
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078C8")]
		[Address(RVA = "0x2636030", Offset = "0x2634C30", VA = "0x182636030")]
		public BakedFrame GetFrameByPct(float pct)
		{
			return null;
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x00036600 File Offset: 0x00034800
		[Token(Token = "0x60078C9")]
		[Address(RVA = "0x2636200", Offset = "0x2634E00", VA = "0x182636200")]
		public LipSyncInfo GetLipSyncInfo(BakedFrame frame)
		{
			return default(LipSyncInfo);
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078CA")]
		[Address(RVA = "0x2636280", Offset = "0x2634E80", VA = "0x182636280")]
		public void Import(BakedData.BakedDataJson dataJson)
		{
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078CB")]
		[Address(RVA = "0x2636410", Offset = "0x2635010", VA = "0x182636410")]
		public BakedData()
		{
		}

		// Token: 0x040076BB RID: 30395
		[Token(Token = "0x40076BB")]
		public const ConverterFactory.ConverterType BAKE_DATA_CONVERTER_TYPE = ConverterFactory.ConverterType.FLAT_BUFFER;

		// Token: 0x040076BC RID: 30396
		[Token(Token = "0x40076BC")]
		public const float DEFAULT_MIN_VOLUME = -2.5f;

		// Token: 0x040076BD RID: 30397
		[Token(Token = "0x40076BD")]
		public const float DEFAULT_MAX_VOLUME = -1.5f;

		// Token: 0x040076BE RID: 30398
		[Token(Token = "0x40076BE")]
		[FieldOffset(Offset = "0x10")]
		public List<BakedFrame> m_frames;

		// Token: 0x040076BF RID: 30399
		[Token(Token = "0x40076BF")]
		[FieldOffset(Offset = "0x18")]
		private BakedFrame m_cachedFrame;

		// Token: 0x0200145F RID: 5215
		[Token(Token = "0x200145F")]
		public class BakedDataMeta
		{
			// Token: 0x060078CC RID: 30924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078CC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BakedDataMeta()
			{
			}

			// Token: 0x040076C2 RID: 30402
			[Token(Token = "0x40076C2")]
			[FieldOffset(Offset = "0x10")]
			public string type;
		}

		// Token: 0x02001460 RID: 5216
		[Token(Token = "0x2001460")]
		[Serializable]
		public class BakedFrameJson
		{
			// Token: 0x060078CD RID: 30925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078CD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BakedFrameJson()
			{
			}

			// Token: 0x040076C3 RID: 30403
			[Token(Token = "0x40076C3")]
			[FieldOffset(Offset = "0x10")]
			public int v;

			// Token: 0x040076C4 RID: 30404
			[Token(Token = "0x40076C4")]
			[FieldOffset(Offset = "0x14")]
			public int m;
		}

		// Token: 0x02001461 RID: 5217
		[Token(Token = "0x2001461")]
		[Serializable]
		public class BakedDataJson
		{
			// Token: 0x060078CE RID: 30926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078CE")]
			[Address(RVA = "0x2635FA0", Offset = "0x2634BA0", VA = "0x182635FA0")]
			public BakedDataJson()
			{
			}

			// Token: 0x040076C5 RID: 30405
			[Token(Token = "0x40076C5")]
			[FieldOffset(Offset = "0x10")]
			public int duration;

			// Token: 0x040076C6 RID: 30406
			[Token(Token = "0x40076C6")]
			[FieldOffset(Offset = "0x14")]
			public int frequency;

			// Token: 0x040076C7 RID: 30407
			[Token(Token = "0x40076C7")]
			[FieldOffset(Offset = "0x18")]
			public List<BakedData.BakedFrameJson> frames;
		}
	}
}
