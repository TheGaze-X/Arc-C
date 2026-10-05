using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.TeleTrust
{
	// Token: 0x02000423 RID: 1059
	[Token(Token = "0x2000423")]
	public class TeleTrusTNamedCurves
	{
		// Token: 0x06002300 RID: 8960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002300")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		private static ECCurve ConfigureCurve(ECCurve curve)
		{
			return null;
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x537DEC0", Offset = "0x537CAC0", VA = "0x18537DEC0")]
		private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder)
		{
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x537E000", Offset = "0x537CC00", VA = "0x18537E000")]
		public static X9ECParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002304")]
		[Address(RVA = "0x537E170", Offset = "0x537CD70", VA = "0x18537E170")]
		public static X9ECParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x537E3F0", Offset = "0x537CFF0", VA = "0x18537E3F0")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002306")]
		[Address(RVA = "0x537E280", Offset = "0x537CE80", VA = "0x18537E280")]
		public static string GetName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A4")]
		public static IEnumerable Names
		{
			[Token(Token = "0x6002307")]
			[Address(RVA = "0x537EBF0", Offset = "0x537D7F0", VA = "0x18537EBF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002308")]
		[Address(RVA = "0x537E330", Offset = "0x537CF30", VA = "0x18537E330")]
		public static DerObjectIdentifier GetOid(short curvesize, bool twisted)
		{
			return null;
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TeleTrusTNamedCurves()
		{
		}

		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary objIds;

		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary curves;

		// Token: 0x040012A2 RID: 4770
		[Token(Token = "0x40012A2")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary names;

		// Token: 0x02000424 RID: 1060
		[Token(Token = "0x2000424")]
		internal class BrainpoolP160r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600230A RID: 8970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600230A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP160r1Holder()
			{
			}

			// Token: 0x0600230B RID: 8971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600230B")]
			[Address(RVA = "0x535D470", Offset = "0x535C070", VA = "0x18535D470", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012A3 RID: 4771
			[Token(Token = "0x40012A3")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000425 RID: 1061
		[Token(Token = "0x2000425")]
		internal class BrainpoolP160t1Holder : X9ECParametersHolder
		{
			// Token: 0x0600230D RID: 8973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600230D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP160t1Holder()
			{
			}

			// Token: 0x0600230E RID: 8974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600230E")]
			[Address(RVA = "0x535D790", Offset = "0x535C390", VA = "0x18535D790", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012A4 RID: 4772
			[Token(Token = "0x40012A4")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000426 RID: 1062
		[Token(Token = "0x2000426")]
		internal class BrainpoolP192r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002310 RID: 8976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002310")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP192r1Holder()
			{
			}

			// Token: 0x06002311 RID: 8977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002311")]
			[Address(RVA = "0x535DAB0", Offset = "0x535C6B0", VA = "0x18535DAB0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012A5 RID: 4773
			[Token(Token = "0x40012A5")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000427 RID: 1063
		[Token(Token = "0x2000427")]
		internal class BrainpoolP192t1Holder : X9ECParametersHolder
		{
			// Token: 0x06002313 RID: 8979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002313")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP192t1Holder()
			{
			}

			// Token: 0x06002314 RID: 8980 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002314")]
			[Address(RVA = "0x535DDD0", Offset = "0x535C9D0", VA = "0x18535DDD0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012A6 RID: 4774
			[Token(Token = "0x40012A6")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000428 RID: 1064
		[Token(Token = "0x2000428")]
		internal class BrainpoolP224r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002316 RID: 8982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002316")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP224r1Holder()
			{
			}

			// Token: 0x06002317 RID: 8983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002317")]
			[Address(RVA = "0x535E0F0", Offset = "0x535CCF0", VA = "0x18535E0F0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012A7 RID: 4775
			[Token(Token = "0x40012A7")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000429 RID: 1065
		[Token(Token = "0x2000429")]
		internal class BrainpoolP224t1Holder : X9ECParametersHolder
		{
			// Token: 0x06002319 RID: 8985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002319")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP224t1Holder()
			{
			}

			// Token: 0x0600231A RID: 8986 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600231A")]
			[Address(RVA = "0x535E410", Offset = "0x535D010", VA = "0x18535E410", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012A8 RID: 4776
			[Token(Token = "0x40012A8")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200042A RID: 1066
		[Token(Token = "0x200042A")]
		internal class BrainpoolP256r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600231C RID: 8988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600231C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP256r1Holder()
			{
			}

			// Token: 0x0600231D RID: 8989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600231D")]
			[Address(RVA = "0x535E730", Offset = "0x535D330", VA = "0x18535E730", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012A9 RID: 4777
			[Token(Token = "0x40012A9")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200042B RID: 1067
		[Token(Token = "0x200042B")]
		internal class BrainpoolP256t1Holder : X9ECParametersHolder
		{
			// Token: 0x0600231F RID: 8991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600231F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP256t1Holder()
			{
			}

			// Token: 0x06002320 RID: 8992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002320")]
			[Address(RVA = "0x535EA50", Offset = "0x535D650", VA = "0x18535EA50", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012AA RID: 4778
			[Token(Token = "0x40012AA")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200042C RID: 1068
		[Token(Token = "0x200042C")]
		internal class BrainpoolP320r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002322 RID: 8994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002322")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP320r1Holder()
			{
			}

			// Token: 0x06002323 RID: 8995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002323")]
			[Address(RVA = "0x535ED70", Offset = "0x535D970", VA = "0x18535ED70", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012AB RID: 4779
			[Token(Token = "0x40012AB")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200042D RID: 1069
		[Token(Token = "0x200042D")]
		internal class BrainpoolP320t1Holder : X9ECParametersHolder
		{
			// Token: 0x06002325 RID: 8997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002325")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP320t1Holder()
			{
			}

			// Token: 0x06002326 RID: 8998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002326")]
			[Address(RVA = "0x535F090", Offset = "0x535DC90", VA = "0x18535F090", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012AC RID: 4780
			[Token(Token = "0x40012AC")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200042E RID: 1070
		[Token(Token = "0x200042E")]
		internal class BrainpoolP384r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002328 RID: 9000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002328")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP384r1Holder()
			{
			}

			// Token: 0x06002329 RID: 9001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002329")]
			[Address(RVA = "0x535F3B0", Offset = "0x535DFB0", VA = "0x18535F3B0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012AD RID: 4781
			[Token(Token = "0x40012AD")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200042F RID: 1071
		[Token(Token = "0x200042F")]
		internal class BrainpoolP384t1Holder : X9ECParametersHolder
		{
			// Token: 0x0600232B RID: 9003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600232B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP384t1Holder()
			{
			}

			// Token: 0x0600232C RID: 9004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x535F6D0", Offset = "0x535E2D0", VA = "0x18535F6D0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012AE RID: 4782
			[Token(Token = "0x40012AE")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000430 RID: 1072
		[Token(Token = "0x2000430")]
		internal class BrainpoolP512r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600232E RID: 9006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP512r1Holder()
			{
			}

			// Token: 0x0600232F RID: 9007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600232F")]
			[Address(RVA = "0x535F9F0", Offset = "0x535E5F0", VA = "0x18535F9F0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012AF RID: 4783
			[Token(Token = "0x40012AF")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000431 RID: 1073
		[Token(Token = "0x2000431")]
		internal class BrainpoolP512t1Holder : X9ECParametersHolder
		{
			// Token: 0x06002331 RID: 9009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002331")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private BrainpoolP512t1Holder()
			{
			}

			// Token: 0x06002332 RID: 9010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002332")]
			[Address(RVA = "0x535FD10", Offset = "0x535E910", VA = "0x18535FD10", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012B0 RID: 4784
			[Token(Token = "0x40012B0")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}
	}
}
