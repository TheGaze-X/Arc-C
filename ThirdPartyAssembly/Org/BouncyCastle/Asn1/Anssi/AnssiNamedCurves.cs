using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.Anssi
{
	// Token: 0x0200046D RID: 1133
	[Token(Token = "0x200046D")]
	public class AnssiNamedCurves
	{
		// Token: 0x0600241C RID: 9244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241C")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		private static ECCurve ConfigureCurve(ECCurve curve)
		{
			return null;
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x5357DC0", Offset = "0x53569C0", VA = "0x185357DC0")]
		private static BigInteger FromHex(string hex)
		{
			return null;
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x5357C80", Offset = "0x5356880", VA = "0x185357C80")]
		private static void DefineCurve(string name, DerObjectIdentifier oid, X9ECParametersHolder holder)
		{
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x5357E60", Offset = "0x5356A60", VA = "0x185357E60")]
		public static X9ECParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x53580E0", Offset = "0x5356CE0", VA = "0x1853580E0")]
		public static X9ECParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x53582A0", Offset = "0x5356EA0", VA = "0x1853582A0")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x53581F0", Offset = "0x5356DF0", VA = "0x1853581F0")]
		public static string GetName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C6")]
		public static IEnumerable Names
		{
			[Token(Token = "0x6002424")]
			[Address(RVA = "0x5358660", Offset = "0x5357260", VA = "0x185358660")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AnssiNamedCurves()
		{
		}

		// Token: 0x0400147B RID: 5243
		[Token(Token = "0x400147B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary objIds;

		// Token: 0x0400147C RID: 5244
		[Token(Token = "0x400147C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary curves;

		// Token: 0x0400147D RID: 5245
		[Token(Token = "0x400147D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary names;

		// Token: 0x0200046E RID: 1134
		[Token(Token = "0x200046E")]
		internal class Frp256v1Holder : X9ECParametersHolder
		{
			// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002426")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			private Frp256v1Holder()
			{
			}

			// Token: 0x06002427 RID: 9255 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002427")]
			[Address(RVA = "0x5362EA0", Offset = "0x5361AA0", VA = "0x185362EA0", Slot = "4")]
			protected override X9ECParameters CreateParameters()
			{
				return null;
			}

			// Token: 0x0400147E RID: 5246
			[Token(Token = "0x400147E")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly X9ECParametersHolder Instance;
		}
	}
}
