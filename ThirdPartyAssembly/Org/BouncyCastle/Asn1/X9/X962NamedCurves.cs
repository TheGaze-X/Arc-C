using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003E1 RID: 993
	[Token(Token = "0x20003E1")]
	public sealed class X962NamedCurves
	{
		// Token: 0x0600214B RID: 8523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private X962NamedCurves()
		{
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x5350CD0", Offset = "0x534F8D0", VA = "0x185350CD0")]
		private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder)
		{
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214E")]
		[Address(RVA = "0x5350E10", Offset = "0x534FA10", VA = "0x185350E10")]
		public static X9ECParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214F")]
		[Address(RVA = "0x5350E90", Offset = "0x534FA90", VA = "0x185350E90")]
		public static X9ECParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002150")]
		[Address(RVA = "0x5351050", Offset = "0x534FC50", VA = "0x185351050")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002151")]
		[Address(RVA = "0x5350FA0", Offset = "0x534FBA0", VA = "0x185350FA0")]
		public static string GetName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000447")]
		public static IEnumerable Names
		{
			[Token(Token = "0x6002152")]
			[Address(RVA = "0x5351C10", Offset = "0x5350810", VA = "0x185351C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary objIds;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary curves;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary names;

		// Token: 0x020003E2 RID: 994
		[Token(Token = "0x20003E2")]
		internal class Prime192v1Holder : X9ECParametersHolder
		{
			// Token: 0x06002153 RID: 8531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002153")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Prime192v1Holder()
			{
			}

			// Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002154")]
			[Address(RVA = "0x5340DB0", Offset = "0x533F9B0", VA = "0x185340DB0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001165 RID: 4453
			[Token(Token = "0x4001165")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003E3 RID: 995
		[Token(Token = "0x20003E3")]
		internal class Prime192v2Holder : X9ECParametersHolder
		{
			// Token: 0x06002156 RID: 8534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002156")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Prime192v2Holder()
			{
			}

			// Token: 0x06002157 RID: 8535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002157")]
			[Address(RVA = "0x53410C0", Offset = "0x533FCC0", VA = "0x1853410C0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001166 RID: 4454
			[Token(Token = "0x4001166")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003E4 RID: 996
		[Token(Token = "0x20003E4")]
		internal class Prime192v3Holder : X9ECParametersHolder
		{
			// Token: 0x06002159 RID: 8537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002159")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Prime192v3Holder()
			{
			}

			// Token: 0x0600215A RID: 8538 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600215A")]
			[Address(RVA = "0x53413D0", Offset = "0x533FFD0", VA = "0x1853413D0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001167 RID: 4455
			[Token(Token = "0x4001167")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003E5 RID: 997
		[Token(Token = "0x20003E5")]
		internal class Prime239v1Holder : X9ECParametersHolder
		{
			// Token: 0x0600215C RID: 8540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600215C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Prime239v1Holder()
			{
			}

			// Token: 0x0600215D RID: 8541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600215D")]
			[Address(RVA = "0x53416E0", Offset = "0x53402E0", VA = "0x1853416E0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001168 RID: 4456
			[Token(Token = "0x4001168")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003E6 RID: 998
		[Token(Token = "0x20003E6")]
		internal class Prime239v2Holder : X9ECParametersHolder
		{
			// Token: 0x0600215F RID: 8543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600215F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Prime239v2Holder()
			{
			}

			// Token: 0x06002160 RID: 8544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002160")]
			[Address(RVA = "0x53419F0", Offset = "0x53405F0", VA = "0x1853419F0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001169 RID: 4457
			[Token(Token = "0x4001169")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003E7 RID: 999
		[Token(Token = "0x20003E7")]
		internal class Prime239v3Holder : X9ECParametersHolder
		{
			// Token: 0x06002162 RID: 8546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002162")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Prime239v3Holder()
			{
			}

			// Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002163")]
			[Address(RVA = "0x5341D00", Offset = "0x5340900", VA = "0x185341D00", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400116A RID: 4458
			[Token(Token = "0x400116A")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003E8 RID: 1000
		[Token(Token = "0x20003E8")]
		internal class Prime256v1Holder : X9ECParametersHolder
		{
			// Token: 0x06002165 RID: 8549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002165")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Prime256v1Holder()
			{
			}

			// Token: 0x06002166 RID: 8550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002166")]
			[Address(RVA = "0x5342010", Offset = "0x5340C10", VA = "0x185342010", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400116B RID: 4459
			[Token(Token = "0x400116B")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003E9 RID: 1001
		[Token(Token = "0x20003E9")]
		internal class C2pnb163v1Holder : X9ECParametersHolder
		{
			// Token: 0x06002168 RID: 8552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002168")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2pnb163v1Holder()
			{
			}

			// Token: 0x06002169 RID: 8553 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002169")]
			[Address(RVA = "0x532B3C0", Offset = "0x5329FC0", VA = "0x18532B3C0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400116C RID: 4460
			[Token(Token = "0x400116C")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003EA RID: 1002
		[Token(Token = "0x20003EA")]
		internal class C2pnb163v2Holder : X9ECParametersHolder
		{
			// Token: 0x0600216B RID: 8555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600216B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2pnb163v2Holder()
			{
			}

			// Token: 0x0600216C RID: 8556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600216C")]
			[Address(RVA = "0x532B6B0", Offset = "0x532A2B0", VA = "0x18532B6B0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400116D RID: 4461
			[Token(Token = "0x400116D")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003EB RID: 1003
		[Token(Token = "0x20003EB")]
		internal class C2pnb163v3Holder : X9ECParametersHolder
		{
			// Token: 0x0600216E RID: 8558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600216E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2pnb163v3Holder()
			{
			}

			// Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600216F")]
			[Address(RVA = "0x532B970", Offset = "0x532A570", VA = "0x18532B970", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400116E RID: 4462
			[Token(Token = "0x400116E")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003EC RID: 1004
		[Token(Token = "0x20003EC")]
		internal class C2pnb176w1Holder : X9ECParametersHolder
		{
			// Token: 0x06002171 RID: 8561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002171")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2pnb176w1Holder()
			{
			}

			// Token: 0x06002172 RID: 8562 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002172")]
			[Address(RVA = "0x532BC30", Offset = "0x532A830", VA = "0x18532BC30", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400116F RID: 4463
			[Token(Token = "0x400116F")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003ED RID: 1005
		[Token(Token = "0x20003ED")]
		internal class C2tnb191v1Holder : X9ECParametersHolder
		{
			// Token: 0x06002174 RID: 8564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002174")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2tnb191v1Holder()
			{
			}

			// Token: 0x06002175 RID: 8565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002175")]
			[Address(RVA = "0x532CA40", Offset = "0x532B640", VA = "0x18532CA40", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001170 RID: 4464
			[Token(Token = "0x4001170")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003EE RID: 1006
		[Token(Token = "0x20003EE")]
		internal class C2tnb191v2Holder : X9ECParametersHolder
		{
			// Token: 0x06002177 RID: 8567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002177")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2tnb191v2Holder()
			{
			}

			// Token: 0x06002178 RID: 8568 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002178")]
			[Address(RVA = "0x532CD20", Offset = "0x532B920", VA = "0x18532CD20", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001171 RID: 4465
			[Token(Token = "0x4001171")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003EF RID: 1007
		[Token(Token = "0x20003EF")]
		internal class C2tnb191v3Holder : X9ECParametersHolder
		{
			// Token: 0x0600217A RID: 8570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600217A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2tnb191v3Holder()
			{
			}

			// Token: 0x0600217B RID: 8571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600217B")]
			[Address(RVA = "0x532CFE0", Offset = "0x532BBE0", VA = "0x18532CFE0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001172 RID: 4466
			[Token(Token = "0x4001172")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F0 RID: 1008
		[Token(Token = "0x20003F0")]
		internal class C2pnb208w1Holder : X9ECParametersHolder
		{
			// Token: 0x0600217D RID: 8573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600217D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2pnb208w1Holder()
			{
			}

			// Token: 0x0600217E RID: 8574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600217E")]
			[Address(RVA = "0x532BF00", Offset = "0x532AB00", VA = "0x18532BF00", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001173 RID: 4467
			[Token(Token = "0x4001173")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F1 RID: 1009
		[Token(Token = "0x20003F1")]
		internal class C2tnb239v1Holder : X9ECParametersHolder
		{
			// Token: 0x06002180 RID: 8576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002180")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2tnb239v1Holder()
			{
			}

			// Token: 0x06002181 RID: 8577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002181")]
			[Address(RVA = "0x532D2A0", Offset = "0x532BEA0", VA = "0x18532D2A0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001174 RID: 4468
			[Token(Token = "0x4001174")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F2 RID: 1010
		[Token(Token = "0x20003F2")]
		internal class C2tnb239v2Holder : X9ECParametersHolder
		{
			// Token: 0x06002183 RID: 8579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002183")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2tnb239v2Holder()
			{
			}

			// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002184")]
			[Address(RVA = "0x532D560", Offset = "0x532C160", VA = "0x18532D560", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001175 RID: 4469
			[Token(Token = "0x4001175")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F3 RID: 1011
		[Token(Token = "0x20003F3")]
		internal class C2tnb239v3Holder : X9ECParametersHolder
		{
			// Token: 0x06002186 RID: 8582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002186")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2tnb239v3Holder()
			{
			}

			// Token: 0x06002187 RID: 8583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002187")]
			[Address(RVA = "0x532D820", Offset = "0x532C420", VA = "0x18532D820", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001176 RID: 4470
			[Token(Token = "0x4001176")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F4 RID: 1012
		[Token(Token = "0x20003F4")]
		internal class C2pnb272w1Holder : X9ECParametersHolder
		{
			// Token: 0x06002189 RID: 8585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002189")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2pnb272w1Holder()
			{
			}

			// Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600218A")]
			[Address(RVA = "0x532C1D0", Offset = "0x532ADD0", VA = "0x18532C1D0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001177 RID: 4471
			[Token(Token = "0x4001177")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F5 RID: 1013
		[Token(Token = "0x20003F5")]
		internal class C2pnb304w1Holder : X9ECParametersHolder
		{
			// Token: 0x0600218C RID: 8588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2pnb304w1Holder()
			{
			}

			// Token: 0x0600218D RID: 8589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600218D")]
			[Address(RVA = "0x532C4A0", Offset = "0x532B0A0", VA = "0x18532C4A0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001178 RID: 4472
			[Token(Token = "0x4001178")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F6 RID: 1014
		[Token(Token = "0x20003F6")]
		internal class C2tnb359v1Holder : X9ECParametersHolder
		{
			// Token: 0x0600218F RID: 8591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2tnb359v1Holder()
			{
			}

			// Token: 0x06002190 RID: 8592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002190")]
			[Address(RVA = "0x532DAE0", Offset = "0x532C6E0", VA = "0x18532DAE0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001179 RID: 4473
			[Token(Token = "0x4001179")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F7 RID: 1015
		[Token(Token = "0x20003F7")]
		internal class C2pnb368w1Holder : X9ECParametersHolder
		{
			// Token: 0x06002192 RID: 8594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002192")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2pnb368w1Holder()
			{
			}

			// Token: 0x06002193 RID: 8595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002193")]
			[Address(RVA = "0x532C770", Offset = "0x532B370", VA = "0x18532C770", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400117A RID: 4474
			[Token(Token = "0x400117A")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x020003F8 RID: 1016
		[Token(Token = "0x20003F8")]
		internal class C2tnb431r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002195 RID: 8597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002195")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private C2tnb431r1Holder()
			{
			}

			// Token: 0x06002196 RID: 8598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002196")]
			[Address(RVA = "0x532DDA0", Offset = "0x532C9A0", VA = "0x18532DDA0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400117B RID: 4475
			[Token(Token = "0x400117B")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}
	}
}
