using System;
using Il2CppDummyDll;

namespace UnityEngine.Yoga
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	internal class YogaConfig
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x5B4F180", Offset = "0x5B4DD80", VA = "0x185B4F180")]
		private YogaConfig(IntPtr ygConfig)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5B4F140", Offset = "0x5B4DD40", VA = "0x185B4F140")]
		public YogaConfig()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5B4EF60", Offset = "0x5B4DB60", VA = "0x185B4EF60", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		internal IntPtr Handle
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002080 File Offset: 0x00000280
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public bool UseWebDefaults
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x5B4F240", Offset = "0x5B4DE40", VA = "0x185B4F240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x5B4F2D0", Offset = "0x5B4DED0", VA = "0x185B4F2D0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public float PointScaleFactor
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x5B4F280", Offset = "0x5B4DE80", VA = "0x185B4F280")]
			set
			{
			}
		}

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly YogaConfig Default;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr _ygConfig;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		private Logger _logger;
	}
}
