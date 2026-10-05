using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Policy
{
	// Token: 0x020002CF RID: 719
	[Token(Token = "0x20002CF")]
	[MonoTODO("Serialization format not compatible with .NET")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public sealed class Evidence : System.Collections.ICollection, System.Collections.IEnumerable
	{
		// Token: 0x060017F8 RID: 6136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Evidence()
		{
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00011310 File Offset: 0x0000F510
		[Token(Token = "0x1700026D")]
		[System.Obsolete]
		public int Count
		{
			[Token(Token = "0x60017F9")]
			[Address(RVA = "0x4B117D0", Offset = "0x4B103D0", VA = "0x184B117D0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00011328 File Offset: 0x0000F528
		[Token(Token = "0x1700026E")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60017FA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700026F")]
		public object SyncRoot
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FC")]
		[Address(RVA = "0x4B115D0", Offset = "0x4B101D0", VA = "0x184B115D0", Slot = "4")]
		[System.Obsolete]
		public void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017FD")]
		[Address(RVA = "0x4B116C0", Offset = "0x4B102C0", VA = "0x184B116C0", Slot = "8")]
		[System.Obsolete]
		public System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _locked;

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.Collections.ArrayList hostEvidenceList;

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Collections.ArrayList assemblyEvidenceList;

		// Token: 0x020002D0 RID: 720
		[Token(Token = "0x20002D0")]
		private class EvidenceEnumerator : System.Collections.IEnumerator
		{
			// Token: 0x060017FE RID: 6142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017FE")]
			[Address(RVA = "0x4B11510", Offset = "0x4B10110", VA = "0x184B11510")]
			public EvidenceEnumerator(System.Collections.IEnumerator hostenum, System.Collections.IEnumerator assemblyenum)
			{
			}

			// Token: 0x060017FF RID: 6143 RVA: 0x00011340 File Offset: 0x0000F540
			[Token(Token = "0x60017FF")]
			[Address(RVA = "0x4B113F0", Offset = "0x4B0FFF0", VA = "0x184B113F0", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06001800 RID: 6144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001800")]
			[Address(RVA = "0x4B11490", Offset = "0x4B10090", VA = "0x184B11490", Slot = "6")]
			public void Reset()
			{
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x06001801 RID: 6145 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000270")]
			public object Current
			{
				[Token(Token = "0x6001801")]
				[Address(RVA = "0x4B11580", Offset = "0x4B10180", VA = "0x184B11580", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000D09 RID: 3337
			[Token(Token = "0x4000D09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private System.Collections.IEnumerator currentEnum;

			// Token: 0x04000D0A RID: 3338
			[Token(Token = "0x4000D0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private System.Collections.IEnumerator hostEnum;

			// Token: 0x04000D0B RID: 3339
			[Token(Token = "0x4000D0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private System.Collections.IEnumerator assemblyEnum;
		}
	}
}
