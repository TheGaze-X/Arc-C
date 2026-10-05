using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	[DefaultMember("Item")]
	public class GatewayIPAddressInformationCollection : ICollection<GatewayIPAddressInformation>, IEnumerable<GatewayIPAddressInformation>, IEnumerable
	{
		// Token: 0x0600182A RID: 6186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x509D8A0", Offset = "0x509C4A0", VA = "0x18509D8A0")]
		protected internal GatewayIPAddressInformationCollection()
		{
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x509D6D0", Offset = "0x509C2D0", VA = "0x18509D6D0", Slot = "13")]
		public virtual void CopyTo(GatewayIPAddressInformation[] array, int offset)
		{
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x17000550")]
		public virtual int Count
		{
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x509D930", Offset = "0x509C530", VA = "0x18509D930", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x17000551")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x600182D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182E")]
		[Address(RVA = "0x509D590", Offset = "0x509C190", VA = "0x18509D590", Slot = "16")]
		public virtual void Add(GatewayIPAddressInformation address)
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182F")]
		[Address(RVA = "0x509D790", Offset = "0x509C390", VA = "0x18509D790")]
		internal void InternalAdd(GatewayIPAddressInformation address)
		{
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x509D670", Offset = "0x509C270", VA = "0x18509D670", Slot = "17")]
		public virtual bool Contains(GatewayIPAddressInformation address)
		{
			return default(bool);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001831")]
		[Address(RVA = "0x509D740", Offset = "0x509C340", VA = "0x18509D740", Slot = "18")]
		public virtual IEnumerator<GatewayIPAddressInformation> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001832")]
		[Address(RVA = "0x509D860", Offset = "0x509C460", VA = "0x18509D860", Slot = "12")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x6001833")]
		[Address(RVA = "0x509D7F0", Offset = "0x509C3F0", VA = "0x18509D7F0", Slot = "19")]
		public virtual bool Remove(GatewayIPAddressInformation address)
		{
			return default(bool);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x509D600", Offset = "0x509C200", VA = "0x18509D600", Slot = "20")]
		public virtual void Clear()
		{
		}

		// Token: 0x04000E4B RID: 3659
		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0x10")]
		private Collection<GatewayIPAddressInformation> addresses;
	}
}
