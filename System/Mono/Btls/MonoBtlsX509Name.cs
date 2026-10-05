using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	internal class MonoBtlsX509Name : MonoBtlsObject
	{
		// Token: 0x060002CB RID: 715
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x50D6F30", Offset = "0x50D5B30", VA = "0x1850D6F30")]
		[PreserveSig]
		private static extern long mono_btls_x509_name_hash(IntPtr handle);

		// Token: 0x060002CC RID: 716
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x50D6C40", Offset = "0x50D5840", VA = "0x1850D6C40")]
		[PreserveSig]
		private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle);

		// Token: 0x060002CD RID: 717
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x50D6E00", Offset = "0x50D5A00", VA = "0x1850D6E00")]
		[PreserveSig]
		private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index);

		// Token: 0x060002CE RID: 718
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x50D6D60", Offset = "0x50D5960", VA = "0x1850D6D60")]
		[PreserveSig]
		private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size);

		// Token: 0x060002CF RID: 719
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x50D6CC0", Offset = "0x50D58C0", VA = "0x1850D6CC0")]
		[PreserveSig]
		private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data);

		// Token: 0x060002D0 RID: 720
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x50D6E90", Offset = "0x50D5A90", VA = "0x1850D6E90")]
		[PreserveSig]
		private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str);

		// Token: 0x060002D1 RID: 721
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x50D6BA0", Offset = "0x50D57A0", VA = "0x1850D6BA0")]
		[PreserveSig]
		private unsafe static extern IntPtr mono_btls_x509_name_from_data(void* data, int len, int use_canon_enc);

		// Token: 0x060002D2 RID: 722
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x50D6B20", Offset = "0x50D5720", VA = "0x1850D6B20")]
		[PreserveSig]
		private static extern void mono_btls_x509_name_free(IntPtr handle);

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		internal new MonoBtlsX509Name.BoringX509NameHandle Handle
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x50D6A60", Offset = "0x50D5660", VA = "0x1850D6A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x4FA7520", Offset = "0x4FA6120", VA = "0x184FA7520")]
		internal MonoBtlsX509Name(MonoBtlsX509Name.BoringX509NameHandle handle)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x50D69C0", Offset = "0x50D55C0", VA = "0x1850D69C0")]
		public long GetHash()
		{
			return 0L;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x50D6220", Offset = "0x50D4E20", VA = "0x1850D6220")]
		public int GetEntryCount()
		{
			return 0;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x50D6660", Offset = "0x50D5260", VA = "0x1850D6660")]
		public MonoBtlsX509NameEntryType GetEntryType(int index)
		{
			return MonoBtlsX509NameEntryType.Unknown;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x50D6420", Offset = "0x50D5020", VA = "0x1850D6420")]
		public string GetEntryOid(int index)
		{
			return null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x50D62C0", Offset = "0x50D4EC0", VA = "0x1850D62C0")]
		public byte[] GetEntryOidData(int index)
		{
			return null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x50D6760", Offset = "0x50D5360", VA = "0x1850D6760")]
		public string GetEntryValue(int index, out int tag)
		{
			return null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x50D6070", Offset = "0x50D4C70", VA = "0x1850D6070")]
		public static MonoBtlsX509Name CreateFromData(byte[] data, bool use_canon_enc)
		{
			return null;
		}

		// Token: 0x0200009A RID: 154
		[Token(Token = "0x200009A")]
		internal class BoringX509NameHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x50C9AE0", Offset = "0x50C86E0", VA = "0x1850C9AE0")]
			internal BoringX509NameHandle(IntPtr handle, bool ownsHandle)
			{
			}

			// Token: 0x060002DD RID: 733 RVA: 0x00002DF0 File Offset: 0x00000FF0
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x50C9A50", Offset = "0x50C8650", VA = "0x1850C9A50", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}

			// Token: 0x040001A6 RID: 422
			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool dontFree;
		}
	}
}
