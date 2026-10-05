using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D52 RID: 27986
	[Token(Token = "0x2006D52")]
	public abstract class ActivityResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005E58 RID: 24152
		// (get) Token: 0x06027E3A RID: 163386
		[Token(Token = "0x17005E58")]
		public abstract Sprite homeSprite { [Token(Token = "0x6027E3A")] get; }

		// Token: 0x17005E59 RID: 24153
		// (get) Token: 0x06027E3B RID: 163387
		[Token(Token = "0x17005E59")]
		public abstract Sprite topbarSprite { [Token(Token = "0x6027E3B")] get; }

		// Token: 0x17005E5A RID: 24154
		// (get) Token: 0x06027E3C RID: 163388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E5A")]
		public virtual Sprite homeSpriteMultiMode
		{
			[Token(Token = "0x6027E3C")]
			[Address(RVA = "0x22EE240", Offset = "0x22ECE40", VA = "0x1822EE240", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E5B RID: 24155
		// (get) Token: 0x06027E3D RID: 163389 RVA: 0x000CFCD8 File Offset: 0x000CDED8
		[Token(Token = "0x17005E5B")]
		public virtual ActivityResHolder.ZoneHomeRes zoneHomeRes
		{
			[Token(Token = "0x6027E3D")]
			[Address(RVA = "0x22F2620", Offset = "0x22F1220", VA = "0x1822F2620", Slot = "7")]
			get
			{
				return default(ActivityResHolder.ZoneHomeRes);
			}
		}

		// Token: 0x06027E3E RID: 163390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E3E")]
		[Address(RVA = "0x22F25C0", Offset = "0x22F11C0", VA = "0x1822F25C0")]
		protected ActivityResHolder()
		{
		}

		// Token: 0x040388A5 RID: 231589
		[Token(Token = "0x40388A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_homeSpriteMultiMode;

		// Token: 0x040388A6 RID: 231590
		[Token(Token = "0x40388A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_zoneHomeRes;

		// Token: 0x040388A7 RID: 231591
		[Token(Token = "0x40388A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D53 RID: 27987
		[Token(Token = "0x2006D53")]
		[Serializable]
		public struct ZoneHomeRes
		{
			// Token: 0x06027E3F RID: 163391 RVA: 0x000CFCF0 File Offset: 0x000CDEF0
			[Token(Token = "0x6027E3F")]
			[Address(RVA = "0x23020E0", Offset = "0x2300CE0", VA = "0x1823020E0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040388A8 RID: 231592
			[Token(Token = "0x40388A8")]
			[FieldOffset(Offset = "0x0")]
			[NonSerialized]
			public static readonly ActivityResHolder.ZoneHomeRes EMPTY;

			// Token: 0x040388A9 RID: 231593
			[Token(Token = "0x40388A9")]
			[FieldOffset(Offset = "0x0")]
			public Color mainColor;

			// Token: 0x040388AA RID: 231594
			[Token(Token = "0x40388AA")]
			[FieldOffset(Offset = "0x10")]
			public Sprite shopIcon;
		}
	}
}
