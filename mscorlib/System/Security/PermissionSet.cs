using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002BF RID: 703
	[Token(Token = "0x20002BF")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[MonoTODO("CAS support is experimental (and unsupported).")]
	[System.Serializable]
	public class PermissionSet : ISecurityEncodable, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x0600179C RID: 6044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179C")]
		[Address(RVA = "0x4B166E0", Offset = "0x4B152E0", VA = "0x184B166E0")]
		internal PermissionSet()
		{
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179D")]
		[Address(RVA = "0x4B16750", Offset = "0x4B15350", VA = "0x184B16750")]
		public PermissionSet(System.Security.Permissions.PermissionState state)
		{
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x4B16680", Offset = "0x4B15280", VA = "0x184B16680")]
		internal PermissionSet(IPermission perm)
		{
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179F")]
		[Address(RVA = "0x4B155F0", Offset = "0x4B141F0", VA = "0x184B155F0", Slot = "11")]
		public virtual void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x4B157C0", Offset = "0x4B143C0", VA = "0x184B157C0", Slot = "12")]
		public void Demand()
		{
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x4B15550", Offset = "0x4B14150", VA = "0x184B15550")]
		internal void CasOnlyDemand(int skip)
		{
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x4B15BC0", Offset = "0x4B147C0", VA = "0x184B15BC0", Slot = "9")]
		public System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00011118 File Offset: 0x0000F318
		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x4B15C80", Offset = "0x4B14880", VA = "0x184B15C80")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00011130 File Offset: 0x0000F330
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x4E8070", Offset = "0x4E6C70", VA = "0x1804E8070")]
		public bool IsUnrestricted()
		{
			return default(bool);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x4B15F60", Offset = "0x4B14B60", VA = "0x184B15F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017A6")]
		[Address(RVA = "0x4B15FD0", Offset = "0x4B14BD0", VA = "0x184B15FD0", Slot = "13")]
		public virtual SecurityElement ToXml()
		{
			return null;
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00011148 File Offset: 0x0000F348
		[Token(Token = "0x17000261")]
		public virtual int Count
		{
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x4B16780", Offset = "0x4B15380", VA = "0x184B16780", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00011160 File Offset: 0x0000F360
		[Token(Token = "0x17000262")]
		public virtual bool IsSynchronized
		{
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x4B167D0", Offset = "0x4B153D0", VA = "0x184B167D0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000263")]
		public virtual object SyncRoot
		{
			[Token(Token = "0x60017A9")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		[MonoTODO("may not be required")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00011178 File Offset: 0x0000F378
		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x4B15A10", Offset = "0x4B14610", VA = "0x184B15A10", Slot = "0")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00011190 File Offset: 0x0000F390
		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x4B15C10", Offset = "0x4B14810", VA = "0x184B15C10", Slot = "2")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object[] psUnrestricted;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.Security.Permissions.PermissionState state;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.Collections.ArrayList list;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _declsec;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool[] _ignored;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object[] action;
	}
}
