using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Endo;

namespace Org.BouncyCastle.Crypto.EC
{
	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000353")]
	public sealed class CustomNamedCurves
	{
		// Token: 0x06001D1A RID: 7450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private CustomNamedCurves()
		{
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x52D9580", Offset = "0x52D8180", VA = "0x1852D9580")]
		private static BigInteger FromHex(string hex)
		{
			return null;
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		private static ECCurve ConfigureCurve(ECCurve curve)
		{
			return null;
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x52D9080", Offset = "0x52D7C80", VA = "0x1852D9080")]
		private static ECCurve ConfigureCurveGlv(ECCurve c, GlvTypeBParameters p)
		{
			return null;
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x52D9480", Offset = "0x52D8080", VA = "0x1852D9480")]
		private static void DefineCurve(string name, X9ECParametersHolder holder)
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x52D92E0", Offset = "0x52D7EE0", VA = "0x1852D92E0")]
		private static void DefineCurveWithOid(string name, DerObjectIdentifier oid, X9ECParametersHolder holder)
		{
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D20")]
		[Address(RVA = "0x52D9150", Offset = "0x52D7D50", VA = "0x1852D9150")]
		private static void DefineCurveAlias(string name, DerObjectIdentifier oid)
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x52D9620", Offset = "0x52D8220", VA = "0x1852D9620")]
		public static X9ECParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x52D9760", Offset = "0x52D8360", VA = "0x1852D9760")]
		public static X9ECParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x52D9920", Offset = "0x52D8520", VA = "0x1852D9920")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x52D9870", Offset = "0x52D8470", VA = "0x1852D9870")]
		public static string GetName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FE")]
		public static IEnumerable Names
		{
			[Token(Token = "0x6001D26")]
			[Address(RVA = "0x52DABF0", Offset = "0x52D97F0", VA = "0x1852DABF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000FCF RID: 4047
		[Token(Token = "0x4000FCF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary nameToCurve;

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary nameToOid;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary oidToCurve;

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x18")]
		private static readonly IDictionary oidToName;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x20")]
		private static readonly IList names;

		// Token: 0x02000354 RID: 852
		[Token(Token = "0x2000354")]
		internal class Curve25519Holder : X9ECParametersHolder
		{
			// Token: 0x06001D27 RID: 7463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D27")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Curve25519Holder()
			{
			}

			// Token: 0x06001D28 RID: 7464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D28")]
			[Address(RVA = "0x52D8E50", Offset = "0x52D7A50", VA = "0x1852D8E50", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FD4 RID: 4052
			[Token(Token = "0x4000FD4")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000355 RID: 853
		[Token(Token = "0x2000355")]
		internal class SecP128R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D2A RID: 7466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D2A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP128R1Holder()
			{
			}

			// Token: 0x06001D2B RID: 7467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D2B")]
			[Address(RVA = "0x52E73C0", Offset = "0x52E5FC0", VA = "0x1852E73C0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FD5 RID: 4053
			[Token(Token = "0x4000FD5")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000356 RID: 854
		[Token(Token = "0x2000356")]
		internal class SecP160K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D2D RID: 7469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D2D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP160K1Holder()
			{
			}

			// Token: 0x06001D2E RID: 7470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D2E")]
			[Address(RVA = "0x52E7610", Offset = "0x52E6210", VA = "0x1852E7610", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FD6 RID: 4054
			[Token(Token = "0x4000FD6")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000357 RID: 855
		[Token(Token = "0x2000357")]
		internal class SecP160R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D30 RID: 7472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D30")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP160R1Holder()
			{
			}

			// Token: 0x06001D31 RID: 7473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D31")]
			[Address(RVA = "0x52E7BF0", Offset = "0x52E67F0", VA = "0x1852E7BF0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FD7 RID: 4055
			[Token(Token = "0x4000FD7")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000358 RID: 856
		[Token(Token = "0x2000358")]
		internal class SecP160R2Holder : X9ECParametersHolder
		{
			// Token: 0x06001D33 RID: 7475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D33")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP160R2Holder()
			{
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D34")]
			[Address(RVA = "0x52E7E40", Offset = "0x52E6A40", VA = "0x1852E7E40", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FD8 RID: 4056
			[Token(Token = "0x4000FD8")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000359 RID: 857
		[Token(Token = "0x2000359")]
		internal class SecP192K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D36 RID: 7478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D36")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP192K1Holder()
			{
			}

			// Token: 0x06001D37 RID: 7479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D37")]
			[Address(RVA = "0x52E8090", Offset = "0x52E6C90", VA = "0x1852E8090", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FD9 RID: 4057
			[Token(Token = "0x4000FD9")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200035A RID: 858
		[Token(Token = "0x200035A")]
		internal class SecP192R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D39 RID: 7481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D39")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP192R1Holder()
			{
			}

			// Token: 0x06001D3A RID: 7482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D3A")]
			[Address(RVA = "0x52E8670", Offset = "0x52E7270", VA = "0x1852E8670", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FDA RID: 4058
			[Token(Token = "0x4000FDA")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200035B RID: 859
		[Token(Token = "0x200035B")]
		internal class SecP224K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D3C RID: 7484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D3C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP224K1Holder()
			{
			}

			// Token: 0x06001D3D RID: 7485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D3D")]
			[Address(RVA = "0x52E88C0", Offset = "0x52E74C0", VA = "0x1852E88C0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FDB RID: 4059
			[Token(Token = "0x4000FDB")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200035C RID: 860
		[Token(Token = "0x200035C")]
		internal class SecP224R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D3F RID: 7487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D3F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP224R1Holder()
			{
			}

			// Token: 0x06001D40 RID: 7488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D40")]
			[Address(RVA = "0x52E8EA0", Offset = "0x52E7AA0", VA = "0x1852E8EA0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FDC RID: 4060
			[Token(Token = "0x4000FDC")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200035D RID: 861
		[Token(Token = "0x200035D")]
		internal class SecP256K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D42 RID: 7490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D42")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP256K1Holder()
			{
			}

			// Token: 0x06001D43 RID: 7491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D43")]
			[Address(RVA = "0x52E90F0", Offset = "0x52E7CF0", VA = "0x1852E90F0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FDD RID: 4061
			[Token(Token = "0x4000FDD")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200035E RID: 862
		[Token(Token = "0x200035E")]
		internal class SecP256R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D45")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP256R1Holder()
			{
			}

			// Token: 0x06001D46 RID: 7494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D46")]
			[Address(RVA = "0x52E96D0", Offset = "0x52E82D0", VA = "0x1852E96D0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FDE RID: 4062
			[Token(Token = "0x4000FDE")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200035F RID: 863
		[Token(Token = "0x200035F")]
		internal class SecP384R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D48 RID: 7496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D48")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP384R1Holder()
			{
			}

			// Token: 0x06001D49 RID: 7497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D49")]
			[Address(RVA = "0x52E9920", Offset = "0x52E8520", VA = "0x1852E9920", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FDF RID: 4063
			[Token(Token = "0x4000FDF")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000360 RID: 864
		[Token(Token = "0x2000360")]
		internal class SecP521R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D4B RID: 7499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D4B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecP521R1Holder()
			{
			}

			// Token: 0x06001D4C RID: 7500 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D4C")]
			[Address(RVA = "0x52E9B70", Offset = "0x52E8770", VA = "0x1852E9B70", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE0 RID: 4064
			[Token(Token = "0x4000FE0")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000361 RID: 865
		[Token(Token = "0x2000361")]
		internal class SecT113R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D4E RID: 7502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D4E")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT113R1Holder()
			{
			}

			// Token: 0x06001D4F RID: 7503 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D4F")]
			[Address(RVA = "0x52E9DC0", Offset = "0x52E89C0", VA = "0x1852E9DC0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE1 RID: 4065
			[Token(Token = "0x4000FE1")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000362 RID: 866
		[Token(Token = "0x2000362")]
		internal class SecT113R2Holder : X9ECParametersHolder
		{
			// Token: 0x06001D51 RID: 7505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D51")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT113R2Holder()
			{
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D52")]
			[Address(RVA = "0x52EA010", Offset = "0x52E8C10", VA = "0x1852EA010", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE2 RID: 4066
			[Token(Token = "0x4000FE2")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000363 RID: 867
		[Token(Token = "0x2000363")]
		internal class SecT131R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D54 RID: 7508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D54")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT131R1Holder()
			{
			}

			// Token: 0x06001D55 RID: 7509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D55")]
			[Address(RVA = "0x52EA260", Offset = "0x52E8E60", VA = "0x1852EA260", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE3 RID: 4067
			[Token(Token = "0x4000FE3")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000364 RID: 868
		[Token(Token = "0x2000364")]
		internal class SecT131R2Holder : X9ECParametersHolder
		{
			// Token: 0x06001D57 RID: 7511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D57")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT131R2Holder()
			{
			}

			// Token: 0x06001D58 RID: 7512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D58")]
			[Address(RVA = "0x52EA4B0", Offset = "0x52E90B0", VA = "0x1852EA4B0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE4 RID: 4068
			[Token(Token = "0x4000FE4")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000365 RID: 869
		[Token(Token = "0x2000365")]
		internal class SecT163K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D5A RID: 7514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D5A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT163K1Holder()
			{
			}

			// Token: 0x06001D5B RID: 7515 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D5B")]
			[Address(RVA = "0x52EA700", Offset = "0x52E9300", VA = "0x1852EA700", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE5 RID: 4069
			[Token(Token = "0x4000FE5")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000366 RID: 870
		[Token(Token = "0x2000366")]
		internal class SecT163R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D5D RID: 7517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D5D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT163R1Holder()
			{
			}

			// Token: 0x06001D5E RID: 7518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D5E")]
			[Address(RVA = "0x52EA930", Offset = "0x52E9530", VA = "0x1852EA930", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE6 RID: 4070
			[Token(Token = "0x4000FE6")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000367 RID: 871
		[Token(Token = "0x2000367")]
		internal class SecT163R2Holder : X9ECParametersHolder
		{
			// Token: 0x06001D60 RID: 7520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D60")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT163R2Holder()
			{
			}

			// Token: 0x06001D61 RID: 7521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D61")]
			[Address(RVA = "0x52EAB80", Offset = "0x52E9780", VA = "0x1852EAB80", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE7 RID: 4071
			[Token(Token = "0x4000FE7")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000368 RID: 872
		[Token(Token = "0x2000368")]
		internal class SecT193R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D63 RID: 7523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D63")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT193R1Holder()
			{
			}

			// Token: 0x06001D64 RID: 7524 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D64")]
			[Address(RVA = "0x52EADD0", Offset = "0x52E99D0", VA = "0x1852EADD0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE8 RID: 4072
			[Token(Token = "0x4000FE8")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000369 RID: 873
		[Token(Token = "0x2000369")]
		internal class SecT193R2Holder : X9ECParametersHolder
		{
			// Token: 0x06001D66 RID: 7526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D66")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT193R2Holder()
			{
			}

			// Token: 0x06001D67 RID: 7527 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D67")]
			[Address(RVA = "0x52EB020", Offset = "0x52E9C20", VA = "0x1852EB020", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FE9 RID: 4073
			[Token(Token = "0x4000FE9")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200036A RID: 874
		[Token(Token = "0x200036A")]
		internal class SecT233K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D69 RID: 7529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D69")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT233K1Holder()
			{
			}

			// Token: 0x06001D6A RID: 7530 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D6A")]
			[Address(RVA = "0x52EB270", Offset = "0x52E9E70", VA = "0x1852EB270", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FEA RID: 4074
			[Token(Token = "0x4000FEA")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200036B RID: 875
		[Token(Token = "0x200036B")]
		internal class SecT233R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D6C RID: 7532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D6C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT233R1Holder()
			{
			}

			// Token: 0x06001D6D RID: 7533 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D6D")]
			[Address(RVA = "0x52EB4A0", Offset = "0x52EA0A0", VA = "0x1852EB4A0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FEB RID: 4075
			[Token(Token = "0x4000FEB")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200036C RID: 876
		[Token(Token = "0x200036C")]
		internal class SecT239K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D6F RID: 7535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D6F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT239K1Holder()
			{
			}

			// Token: 0x06001D70 RID: 7536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D70")]
			[Address(RVA = "0x52EB6F0", Offset = "0x52EA2F0", VA = "0x1852EB6F0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FEC RID: 4076
			[Token(Token = "0x4000FEC")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200036D RID: 877
		[Token(Token = "0x200036D")]
		internal class SecT283K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D72 RID: 7538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D72")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT283K1Holder()
			{
			}

			// Token: 0x06001D73 RID: 7539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D73")]
			[Address(RVA = "0x52EB920", Offset = "0x52EA520", VA = "0x1852EB920", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FED RID: 4077
			[Token(Token = "0x4000FED")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200036E RID: 878
		[Token(Token = "0x200036E")]
		internal class SecT283R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D75 RID: 7541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D75")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT283R1Holder()
			{
			}

			// Token: 0x06001D76 RID: 7542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D76")]
			[Address(RVA = "0x52EBB50", Offset = "0x52EA750", VA = "0x1852EBB50", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FEE RID: 4078
			[Token(Token = "0x4000FEE")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200036F RID: 879
		[Token(Token = "0x200036F")]
		internal class SecT409K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D78 RID: 7544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D78")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT409K1Holder()
			{
			}

			// Token: 0x06001D79 RID: 7545 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D79")]
			[Address(RVA = "0x52EBDA0", Offset = "0x52EA9A0", VA = "0x1852EBDA0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FEF RID: 4079
			[Token(Token = "0x4000FEF")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000370 RID: 880
		[Token(Token = "0x2000370")]
		internal class SecT409R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D7B RID: 7547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D7B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT409R1Holder()
			{
			}

			// Token: 0x06001D7C RID: 7548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D7C")]
			[Address(RVA = "0x52EBFD0", Offset = "0x52EABD0", VA = "0x1852EBFD0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FF0 RID: 4080
			[Token(Token = "0x4000FF0")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000371 RID: 881
		[Token(Token = "0x2000371")]
		internal class SecT571K1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D7E RID: 7550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D7E")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT571K1Holder()
			{
			}

			// Token: 0x06001D7F RID: 7551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D7F")]
			[Address(RVA = "0x52EC220", Offset = "0x52EAE20", VA = "0x1852EC220", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FF1 RID: 4081
			[Token(Token = "0x4000FF1")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000372 RID: 882
		[Token(Token = "0x2000372")]
		internal class SecT571R1Holder : X9ECParametersHolder
		{
			// Token: 0x06001D81 RID: 7553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D81")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private SecT571R1Holder()
			{
			}

			// Token: 0x06001D82 RID: 7554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D82")]
			[Address(RVA = "0x52EC450", Offset = "0x52EB050", VA = "0x1852EC450", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04000FF2 RID: 4082
			[Token(Token = "0x4000FF2")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}
	}
}
