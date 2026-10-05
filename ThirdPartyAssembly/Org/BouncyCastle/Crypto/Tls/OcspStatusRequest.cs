using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	public class OcspStatusRequest
	{
		// Token: 0x060014EF RID: 5359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public OcspStatusRequest(IList responderIDList, X509Extensions requestExtensions)
		{
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		public virtual IList ResponderIDList
		{
			[Token(Token = "0x60014F0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		public virtual X509Extensions RequestExtensions
		{
			[Token(Token = "0x60014F1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x524AB50", Offset = "0x5249750", VA = "0x18524AB50", Slot = "6")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x524B040", Offset = "0x5249C40", VA = "0x18524B040")]
		public static OcspStatusRequest Parse(Stream input)
		{
			return null;
		}

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IList mResponderIDList;

		// Token: 0x04000BA7 RID: 2983
		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x18")]
		protected readonly X509Extensions mRequestExtensions;
	}
}
