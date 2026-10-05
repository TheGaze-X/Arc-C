using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000372 RID: 882
	[Token(Token = "0x2000372")]
	[DefaultMember("Item")]
	public class UnicastIPAddressInformationCollection : ICollection<UnicastIPAddressInformation>, IEnumerable<UnicastIPAddressInformation>, IEnumerable
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001856")]
		[Address(RVA = "0x50B5FD0", Offset = "0x50B4BD0", VA = "0x1850B5FD0")]
		protected internal UnicastIPAddressInformationCollection()
		{
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x50B5E40", Offset = "0x50B4A40", VA = "0x1850B5E40", Slot = "13")]
		public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset)
		{
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x1700055D")]
		public virtual int Count
		{
			[Token(Token = "0x6001858")]
			[Address(RVA = "0x50B6060", Offset = "0x50B4C60", VA = "0x1850B6060", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x1700055E")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6001859")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x50B5D00", Offset = "0x50B4900", VA = "0x1850B5D00", Slot = "16")]
		public virtual void Add(UnicastIPAddressInformation address)
		{
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x50B5F00", Offset = "0x50B4B00", VA = "0x1850B5F00")]
		internal void InternalAdd(UnicastIPAddressInformation address)
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x50B5DE0", Offset = "0x50B49E0", VA = "0x1850B5DE0", Slot = "17")]
		public virtual bool Contains(UnicastIPAddressInformation address)
		{
			return default(bool);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185D")]
		[Address(RVA = "0x509D860", Offset = "0x509C460", VA = "0x18509D860", Slot = "12")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x50B5EB0", Offset = "0x50B4AB0", VA = "0x1850B5EB0", Slot = "18")]
		public virtual IEnumerator<UnicastIPAddressInformation> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x600185F")]
		[Address(RVA = "0x50B5F60", Offset = "0x50B4B60", VA = "0x1850B5F60", Slot = "19")]
		public virtual bool Remove(UnicastIPAddressInformation address)
		{
			return default(bool);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x50B5D70", Offset = "0x50B4970", VA = "0x1850B5D70", Slot = "20")]
		public virtual void Clear()
		{
		}

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x10")]
		private Collection<UnicastIPAddressInformation> addresses;
	}
}
