using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Endo;

namespace Org.BouncyCastle.Asn1.Sec
{
	// Token: 0x02000433 RID: 1075
	[Token(Token = "0x2000433")]
	public sealed class SecNamedCurves
	{
		// Token: 0x06002336 RID: 9014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private SecNamedCurves()
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002337")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		private static ECCurve ConfigureCurve(ECCurve curve)
		{
			return null;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x5373F90", Offset = "0x5372B90", VA = "0x185373F90")]
		private static ECCurve ConfigureCurveGlv(ECCurve c, GlvTypeBParameters p)
		{
			return null;
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002339")]
		[Address(RVA = "0x53741A0", Offset = "0x5372DA0", VA = "0x1853741A0")]
		private static BigInteger FromHex(string hex)
		{
			return null;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x5374060", Offset = "0x5372C60", VA = "0x185374060")]
		private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233C")]
		[Address(RVA = "0x5374240", Offset = "0x5372E40", VA = "0x185374240")]
		public static X9ECParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233D")]
		[Address(RVA = "0x53743D0", Offset = "0x5372FD0", VA = "0x1853743D0")]
		public static X9ECParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233E")]
		[Address(RVA = "0x5374590", Offset = "0x5373190", VA = "0x185374590")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233F")]
		[Address(RVA = "0x53744E0", Offset = "0x53730E0", VA = "0x1853744E0")]
		public static string GetName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A5")]
		public static IEnumerable Names
		{
			[Token(Token = "0x6002340")]
			[Address(RVA = "0x5375530", Offset = "0x5374130", VA = "0x185375530")]
			get
			{
				return null;
			}
		}

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary objIds;

		// Token: 0x040012CE RID: 4814
		[Token(Token = "0x40012CE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary curves;

		// Token: 0x040012CF RID: 4815
		[Token(Token = "0x40012CF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary names;

		// Token: 0x02000434 RID: 1076
		[Token(Token = "0x2000434")]
		internal class Secp112r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002341 RID: 9025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002341")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp112r1Holder()
			{
			}

			// Token: 0x06002342 RID: 9026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002342")]
			[Address(RVA = "0x5376D80", Offset = "0x5375980", VA = "0x185376D80", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D0 RID: 4816
			[Token(Token = "0x40012D0")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000435 RID: 1077
		[Token(Token = "0x2000435")]
		internal class Secp112r2Holder : X9ECParametersHolder
		{
			// Token: 0x06002344 RID: 9028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002344")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp112r2Holder()
			{
			}

			// Token: 0x06002345 RID: 9029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002345")]
			[Address(RVA = "0x5377040", Offset = "0x5375C40", VA = "0x185377040", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D1 RID: 4817
			[Token(Token = "0x40012D1")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000436 RID: 1078
		[Token(Token = "0x2000436")]
		internal class Secp128r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002347 RID: 9031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002347")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp128r1Holder()
			{
			}

			// Token: 0x06002348 RID: 9032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002348")]
			[Address(RVA = "0x5377300", Offset = "0x5375F00", VA = "0x185377300", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D2 RID: 4818
			[Token(Token = "0x40012D2")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000437 RID: 1079
		[Token(Token = "0x2000437")]
		internal class Secp128r2Holder : X9ECParametersHolder
		{
			// Token: 0x0600234A RID: 9034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600234A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp128r2Holder()
			{
			}

			// Token: 0x0600234B RID: 9035 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600234B")]
			[Address(RVA = "0x53775C0", Offset = "0x53761C0", VA = "0x1853775C0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D3 RID: 4819
			[Token(Token = "0x40012D3")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000438 RID: 1080
		[Token(Token = "0x2000438")]
		internal class Secp160k1Holder : X9ECParametersHolder
		{
			// Token: 0x0600234D RID: 9037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600234D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp160k1Holder()
			{
			}

			// Token: 0x0600234E RID: 9038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600234E")]
			[Address(RVA = "0x5377880", Offset = "0x5376480", VA = "0x185377880", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D4 RID: 4820
			[Token(Token = "0x40012D4")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000439 RID: 1081
		[Token(Token = "0x2000439")]
		internal class Secp160r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002350 RID: 9040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002350")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp160r1Holder()
			{
			}

			// Token: 0x06002351 RID: 9041 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002351")]
			[Address(RVA = "0x5377EC0", Offset = "0x5376AC0", VA = "0x185377EC0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D5 RID: 4821
			[Token(Token = "0x40012D5")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200043A RID: 1082
		[Token(Token = "0x200043A")]
		internal class Secp160r2Holder : X9ECParametersHolder
		{
			// Token: 0x06002353 RID: 9043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002353")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp160r2Holder()
			{
			}

			// Token: 0x06002354 RID: 9044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002354")]
			[Address(RVA = "0x5378180", Offset = "0x5376D80", VA = "0x185378180", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D6 RID: 4822
			[Token(Token = "0x40012D6")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200043B RID: 1083
		[Token(Token = "0x200043B")]
		internal class Secp192k1Holder : X9ECParametersHolder
		{
			// Token: 0x06002356 RID: 9046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002356")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp192k1Holder()
			{
			}

			// Token: 0x06002357 RID: 9047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002357")]
			[Address(RVA = "0x5378440", Offset = "0x5377040", VA = "0x185378440", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D7 RID: 4823
			[Token(Token = "0x40012D7")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200043C RID: 1084
		[Token(Token = "0x200043C")]
		internal class Secp192r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002359 RID: 9049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002359")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp192r1Holder()
			{
			}

			// Token: 0x0600235A RID: 9050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600235A")]
			[Address(RVA = "0x5378A80", Offset = "0x5377680", VA = "0x185378A80", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D8 RID: 4824
			[Token(Token = "0x40012D8")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200043D RID: 1085
		[Token(Token = "0x200043D")]
		internal class Secp224k1Holder : X9ECParametersHolder
		{
			// Token: 0x0600235C RID: 9052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600235C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp224k1Holder()
			{
			}

			// Token: 0x0600235D RID: 9053 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600235D")]
			[Address(RVA = "0x5378D40", Offset = "0x5377940", VA = "0x185378D40", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012D9 RID: 4825
			[Token(Token = "0x40012D9")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200043E RID: 1086
		[Token(Token = "0x200043E")]
		internal class Secp224r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600235F RID: 9055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600235F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp224r1Holder()
			{
			}

			// Token: 0x06002360 RID: 9056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002360")]
			[Address(RVA = "0x5379380", Offset = "0x5377F80", VA = "0x185379380", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012DA RID: 4826
			[Token(Token = "0x40012DA")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x0200043F RID: 1087
		[Token(Token = "0x200043F")]
		internal class Secp256k1Holder : X9ECParametersHolder
		{
			// Token: 0x06002362 RID: 9058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002362")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp256k1Holder()
			{
			}

			// Token: 0x06002363 RID: 9059 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002363")]
			[Address(RVA = "0x5379640", Offset = "0x5378240", VA = "0x185379640", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012DB RID: 4827
			[Token(Token = "0x40012DB")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000440 RID: 1088
		[Token(Token = "0x2000440")]
		internal class Secp256r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002365 RID: 9061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002365")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp256r1Holder()
			{
			}

			// Token: 0x06002366 RID: 9062 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002366")]
			[Address(RVA = "0x5379C80", Offset = "0x5378880", VA = "0x185379C80", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012DC RID: 4828
			[Token(Token = "0x40012DC")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000441 RID: 1089
		[Token(Token = "0x2000441")]
		internal class Secp384r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002368 RID: 9064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002368")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp384r1Holder()
			{
			}

			// Token: 0x06002369 RID: 9065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002369")]
			[Address(RVA = "0x5379F40", Offset = "0x5378B40", VA = "0x185379F40", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012DD RID: 4829
			[Token(Token = "0x40012DD")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000442 RID: 1090
		[Token(Token = "0x2000442")]
		internal class Secp521r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600236B RID: 9067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600236B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Secp521r1Holder()
			{
			}

			// Token: 0x0600236C RID: 9068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600236C")]
			[Address(RVA = "0x537A200", Offset = "0x5378E00", VA = "0x18537A200", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012DE RID: 4830
			[Token(Token = "0x40012DE")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}

		// Token: 0x02000443 RID: 1091
		[Token(Token = "0x2000443")]
		internal class Sect113r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600236E RID: 9070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600236E")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect113r1Holder()
			{
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600236F")]
			[Address(RVA = "0x537A4C0", Offset = "0x53790C0", VA = "0x18537A4C0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012DF RID: 4831
			[Token(Token = "0x40012DF")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x040012E0 RID: 4832
			[Token(Token = "0x40012E0")]
			private const int m = 113;

			// Token: 0x040012E1 RID: 4833
			[Token(Token = "0x40012E1")]
			private const int k = 9;
		}

		// Token: 0x02000444 RID: 1092
		[Token(Token = "0x2000444")]
		internal class Sect113r2Holder : X9ECParametersHolder
		{
			// Token: 0x06002371 RID: 9073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002371")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect113r2Holder()
			{
			}

			// Token: 0x06002372 RID: 9074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002372")]
			[Address(RVA = "0x537A760", Offset = "0x5379360", VA = "0x18537A760", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012E2 RID: 4834
			[Token(Token = "0x40012E2")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x040012E3 RID: 4835
			[Token(Token = "0x40012E3")]
			private const int m = 113;

			// Token: 0x040012E4 RID: 4836
			[Token(Token = "0x40012E4")]
			private const int k = 9;
		}

		// Token: 0x02000445 RID: 1093
		[Token(Token = "0x2000445")]
		internal class Sect131r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002374 RID: 9076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002374")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect131r1Holder()
			{
			}

			// Token: 0x06002375 RID: 9077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002375")]
			[Address(RVA = "0x537AA00", Offset = "0x5379600", VA = "0x18537AA00", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012E5 RID: 4837
			[Token(Token = "0x40012E5")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x040012E6 RID: 4838
			[Token(Token = "0x40012E6")]
			private const int m = 131;

			// Token: 0x040012E7 RID: 4839
			[Token(Token = "0x40012E7")]
			private const int k1 = 2;

			// Token: 0x040012E8 RID: 4840
			[Token(Token = "0x40012E8")]
			private const int k2 = 3;

			// Token: 0x040012E9 RID: 4841
			[Token(Token = "0x40012E9")]
			private const int k3 = 8;
		}

		// Token: 0x02000446 RID: 1094
		[Token(Token = "0x2000446")]
		internal class Sect131r2Holder : X9ECParametersHolder
		{
			// Token: 0x06002377 RID: 9079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002377")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect131r2Holder()
			{
			}

			// Token: 0x06002378 RID: 9080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002378")]
			[Address(RVA = "0x537ACB0", Offset = "0x53798B0", VA = "0x18537ACB0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012EA RID: 4842
			[Token(Token = "0x40012EA")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x040012EB RID: 4843
			[Token(Token = "0x40012EB")]
			private const int m = 131;

			// Token: 0x040012EC RID: 4844
			[Token(Token = "0x40012EC")]
			private const int k1 = 2;

			// Token: 0x040012ED RID: 4845
			[Token(Token = "0x40012ED")]
			private const int k2 = 3;

			// Token: 0x040012EE RID: 4846
			[Token(Token = "0x40012EE")]
			private const int k3 = 8;
		}

		// Token: 0x02000447 RID: 1095
		[Token(Token = "0x2000447")]
		internal class Sect163k1Holder : X9ECParametersHolder
		{
			// Token: 0x0600237A RID: 9082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600237A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect163k1Holder()
			{
			}

			// Token: 0x0600237B RID: 9083 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600237B")]
			[Address(RVA = "0x537AF60", Offset = "0x5379B60", VA = "0x18537AF60", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012EF RID: 4847
			[Token(Token = "0x40012EF")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x040012F0 RID: 4848
			[Token(Token = "0x40012F0")]
			private const int m = 163;

			// Token: 0x040012F1 RID: 4849
			[Token(Token = "0x40012F1")]
			private const int k1 = 3;

			// Token: 0x040012F2 RID: 4850
			[Token(Token = "0x40012F2")]
			private const int k2 = 6;

			// Token: 0x040012F3 RID: 4851
			[Token(Token = "0x40012F3")]
			private const int k3 = 7;
		}

		// Token: 0x02000448 RID: 1096
		[Token(Token = "0x2000448")]
		internal class Sect163r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600237D RID: 9085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600237D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect163r1Holder()
			{
			}

			// Token: 0x0600237E RID: 9086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600237E")]
			[Address(RVA = "0x537B1D0", Offset = "0x5379DD0", VA = "0x18537B1D0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012F4 RID: 4852
			[Token(Token = "0x40012F4")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x040012F5 RID: 4853
			[Token(Token = "0x40012F5")]
			private const int m = 163;

			// Token: 0x040012F6 RID: 4854
			[Token(Token = "0x40012F6")]
			private const int k1 = 3;

			// Token: 0x040012F7 RID: 4855
			[Token(Token = "0x40012F7")]
			private const int k2 = 6;

			// Token: 0x040012F8 RID: 4856
			[Token(Token = "0x40012F8")]
			private const int k3 = 7;
		}

		// Token: 0x02000449 RID: 1097
		[Token(Token = "0x2000449")]
		internal class Sect163r2Holder : X9ECParametersHolder
		{
			// Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002380")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect163r2Holder()
			{
			}

			// Token: 0x06002381 RID: 9089 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002381")]
			[Address(RVA = "0x537B480", Offset = "0x537A080", VA = "0x18537B480", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012F9 RID: 4857
			[Token(Token = "0x40012F9")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x040012FA RID: 4858
			[Token(Token = "0x40012FA")]
			private const int m = 163;

			// Token: 0x040012FB RID: 4859
			[Token(Token = "0x40012FB")]
			private const int k1 = 3;

			// Token: 0x040012FC RID: 4860
			[Token(Token = "0x40012FC")]
			private const int k2 = 6;

			// Token: 0x040012FD RID: 4861
			[Token(Token = "0x40012FD")]
			private const int k3 = 7;
		}

		// Token: 0x0200044A RID: 1098
		[Token(Token = "0x200044A")]
		internal class Sect193r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002383 RID: 9091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002383")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect193r1Holder()
			{
			}

			// Token: 0x06002384 RID: 9092 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002384")]
			[Address(RVA = "0x537B720", Offset = "0x537A320", VA = "0x18537B720", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x040012FE RID: 4862
			[Token(Token = "0x40012FE")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x040012FF RID: 4863
			[Token(Token = "0x40012FF")]
			private const int m = 193;

			// Token: 0x04001300 RID: 4864
			[Token(Token = "0x4001300")]
			private const int k = 15;
		}

		// Token: 0x0200044B RID: 1099
		[Token(Token = "0x200044B")]
		internal class Sect193r2Holder : X9ECParametersHolder
		{
			// Token: 0x06002386 RID: 9094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002386")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect193r2Holder()
			{
			}

			// Token: 0x06002387 RID: 9095 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002387")]
			[Address(RVA = "0x537B9C0", Offset = "0x537A5C0", VA = "0x18537B9C0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001301 RID: 4865
			[Token(Token = "0x4001301")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x04001302 RID: 4866
			[Token(Token = "0x4001302")]
			private const int m = 193;

			// Token: 0x04001303 RID: 4867
			[Token(Token = "0x4001303")]
			private const int k = 15;
		}

		// Token: 0x0200044C RID: 1100
		[Token(Token = "0x200044C")]
		internal class Sect233k1Holder : X9ECParametersHolder
		{
			// Token: 0x06002389 RID: 9097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002389")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect233k1Holder()
			{
			}

			// Token: 0x0600238A RID: 9098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600238A")]
			[Address(RVA = "0x537BC60", Offset = "0x537A860", VA = "0x18537BC60", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001304 RID: 4868
			[Token(Token = "0x4001304")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x04001305 RID: 4869
			[Token(Token = "0x4001305")]
			private const int m = 233;

			// Token: 0x04001306 RID: 4870
			[Token(Token = "0x4001306")]
			private const int k = 74;
		}

		// Token: 0x0200044D RID: 1101
		[Token(Token = "0x200044D")]
		internal class Sect233r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600238C RID: 9100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600238C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect233r1Holder()
			{
			}

			// Token: 0x0600238D RID: 9101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600238D")]
			[Address(RVA = "0x537BEC0", Offset = "0x537AAC0", VA = "0x18537BEC0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001307 RID: 4871
			[Token(Token = "0x4001307")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x04001308 RID: 4872
			[Token(Token = "0x4001308")]
			private const int m = 233;

			// Token: 0x04001309 RID: 4873
			[Token(Token = "0x4001309")]
			private const int k = 74;
		}

		// Token: 0x0200044E RID: 1102
		[Token(Token = "0x200044E")]
		internal class Sect239k1Holder : X9ECParametersHolder
		{
			// Token: 0x0600238F RID: 9103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600238F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect239k1Holder()
			{
			}

			// Token: 0x06002390 RID: 9104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002390")]
			[Address(RVA = "0x537C150", Offset = "0x537AD50", VA = "0x18537C150", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400130A RID: 4874
			[Token(Token = "0x400130A")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x0400130B RID: 4875
			[Token(Token = "0x400130B")]
			private const int m = 239;

			// Token: 0x0400130C RID: 4876
			[Token(Token = "0x400130C")]
			private const int k = 158;
		}

		// Token: 0x0200044F RID: 1103
		[Token(Token = "0x200044F")]
		internal class Sect283k1Holder : X9ECParametersHolder
		{
			// Token: 0x06002392 RID: 9106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002392")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect283k1Holder()
			{
			}

			// Token: 0x06002393 RID: 9107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002393")]
			[Address(RVA = "0x537C3B0", Offset = "0x537AFB0", VA = "0x18537C3B0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400130D RID: 4877
			[Token(Token = "0x400130D")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x0400130E RID: 4878
			[Token(Token = "0x400130E")]
			private const int m = 283;

			// Token: 0x0400130F RID: 4879
			[Token(Token = "0x400130F")]
			private const int k1 = 5;

			// Token: 0x04001310 RID: 4880
			[Token(Token = "0x4001310")]
			private const int k2 = 7;

			// Token: 0x04001311 RID: 4881
			[Token(Token = "0x4001311")]
			private const int k3 = 12;
		}

		// Token: 0x02000450 RID: 1104
		[Token(Token = "0x2000450")]
		internal class Sect283r1Holder : X9ECParametersHolder
		{
			// Token: 0x06002395 RID: 9109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002395")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect283r1Holder()
			{
			}

			// Token: 0x06002396 RID: 9110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002396")]
			[Address(RVA = "0x537C620", Offset = "0x537B220", VA = "0x18537C620", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001312 RID: 4882
			[Token(Token = "0x4001312")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x04001313 RID: 4883
			[Token(Token = "0x4001313")]
			private const int m = 283;

			// Token: 0x04001314 RID: 4884
			[Token(Token = "0x4001314")]
			private const int k1 = 5;

			// Token: 0x04001315 RID: 4885
			[Token(Token = "0x4001315")]
			private const int k2 = 7;

			// Token: 0x04001316 RID: 4886
			[Token(Token = "0x4001316")]
			private const int k3 = 12;
		}

		// Token: 0x02000451 RID: 1105
		[Token(Token = "0x2000451")]
		internal class Sect409k1Holder : X9ECParametersHolder
		{
			// Token: 0x06002398 RID: 9112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002398")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect409k1Holder()
			{
			}

			// Token: 0x06002399 RID: 9113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002399")]
			[Address(RVA = "0x537C8C0", Offset = "0x537B4C0", VA = "0x18537C8C0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001317 RID: 4887
			[Token(Token = "0x4001317")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x04001318 RID: 4888
			[Token(Token = "0x4001318")]
			private const int m = 409;

			// Token: 0x04001319 RID: 4889
			[Token(Token = "0x4001319")]
			private const int k = 87;
		}

		// Token: 0x02000452 RID: 1106
		[Token(Token = "0x2000452")]
		internal class Sect409r1Holder : X9ECParametersHolder
		{
			// Token: 0x0600239B RID: 9115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600239B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect409r1Holder()
			{
			}

			// Token: 0x0600239C RID: 9116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600239C")]
			[Address(RVA = "0x537CB20", Offset = "0x537B720", VA = "0x18537CB20", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400131A RID: 4890
			[Token(Token = "0x400131A")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x0400131B RID: 4891
			[Token(Token = "0x400131B")]
			private const int m = 409;

			// Token: 0x0400131C RID: 4892
			[Token(Token = "0x400131C")]
			private const int k = 87;
		}

		// Token: 0x02000453 RID: 1107
		[Token(Token = "0x2000453")]
		internal class Sect571k1Holder : X9ECParametersHolder
		{
			// Token: 0x0600239E RID: 9118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600239E")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect571k1Holder()
			{
			}

			// Token: 0x0600239F RID: 9119 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600239F")]
			[Address(RVA = "0x537CDB0", Offset = "0x537B9B0", VA = "0x18537CDB0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400131D RID: 4893
			[Token(Token = "0x400131D")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x0400131E RID: 4894
			[Token(Token = "0x400131E")]
			private const int m = 571;

			// Token: 0x0400131F RID: 4895
			[Token(Token = "0x400131F")]
			private const int k1 = 2;

			// Token: 0x04001320 RID: 4896
			[Token(Token = "0x4001320")]
			private const int k2 = 5;

			// Token: 0x04001321 RID: 4897
			[Token(Token = "0x4001321")]
			private const int k3 = 10;
		}

		// Token: 0x02000454 RID: 1108
		[Token(Token = "0x2000454")]
		internal class Sect571r1Holder : X9ECParametersHolder
		{
			// Token: 0x060023A1 RID: 9121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023A1")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Sect571r1Holder()
			{
			}

			// Token: 0x060023A2 RID: 9122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60023A2")]
			[Address(RVA = "0x537D020", Offset = "0x537BC20", VA = "0x18537D020", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x04001322 RID: 4898
			[Token(Token = "0x4001322")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;

			// Token: 0x04001323 RID: 4899
			[Token(Token = "0x4001323")]
			private const int m = 571;

			// Token: 0x04001324 RID: 4900
			[Token(Token = "0x4001324")]
			private const int k1 = 2;

			// Token: 0x04001325 RID: 4901
			[Token(Token = "0x4001325")]
			private const int k2 = 5;

			// Token: 0x04001326 RID: 4902
			[Token(Token = "0x4001326")]
			private const int k3 = 10;
		}
	}
}
