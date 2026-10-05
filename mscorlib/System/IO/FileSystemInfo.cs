using System;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200066A RID: 1642
	[Token(Token = "0x200066A")]
	[System.Serializable]
	public abstract class FileSystemInfo : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060031A5 RID: 12709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A5")]
		[Address(RVA = "0x4C78CA0", Offset = "0x4C778A0", VA = "0x184C78CA0")]
		protected FileSystemInfo()
		{
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031A6")]
		[Address(RVA = "0x4C78DB0", Offset = "0x4C779B0", VA = "0x184C78DB0")]
		internal static FileSystemInfo Create(string fullPath, ref System.IO.Enumeration.FileSystemEntry findData)
		{
			return null;
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A7")]
		[Address(RVA = "0x4C795B0", Offset = "0x4C781B0", VA = "0x184C795B0")]
		internal void Invalidate()
		{
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A8")]
		[Address(RVA = "0x4C79560", Offset = "0x4C78160", VA = "0x184C79560")]
		internal unsafe void Init(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
		{
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x0001AA30 File Offset: 0x00018C30
		[Token(Token = "0x170007F1")]
		public FileAttributes Attributes
		{
			[Token(Token = "0x60031A9")]
			[Address(RVA = "0x4C797A0", Offset = "0x4C783A0", VA = "0x184C797A0")]
			get
			{
				return (FileAttributes)0;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0001AA48 File Offset: 0x00018C48
		[Token(Token = "0x170007F2")]
		internal bool ExistsCore
		{
			[Token(Token = "0x60031AA")]
			[Address(RVA = "0x4C79A60", Offset = "0x4C78660", VA = "0x184C79A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x0001AA60 File Offset: 0x00018C60
		[Token(Token = "0x170007F3")]
		internal System.DateTimeOffset CreationTimeCore
		{
			[Token(Token = "0x60031AB")]
			[Address(RVA = "0x4C79810", Offset = "0x4C78410", VA = "0x184C79810")]
			get
			{
				return default(System.DateTimeOffset);
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x0001AA78 File Offset: 0x00018C78
		[Token(Token = "0x170007F4")]
		internal System.DateTimeOffset LastAccessTimeCore
		{
			[Token(Token = "0x60031AC")]
			[Address(RVA = "0x4C79B70", Offset = "0x4C78770", VA = "0x184C79B70")]
			get
			{
				return default(System.DateTimeOffset);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x0001AA90 File Offset: 0x00018C90
		[Token(Token = "0x170007F5")]
		internal System.DateTimeOffset LastWriteTimeCore
		{
			[Token(Token = "0x60031AD")]
			[Address(RVA = "0x4C79DC0", Offset = "0x4C789C0", VA = "0x184C79DC0")]
			get
			{
				return default(System.DateTimeOffset);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x0001AAA8 File Offset: 0x00018CA8
		[Token(Token = "0x170007F6")]
		internal long LengthCore
		{
			[Token(Token = "0x60031AE")]
			[Address(RVA = "0x4C7A010", Offset = "0x4C78C10", VA = "0x184C7A010")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AF")]
		[Address(RVA = "0x4C79390", Offset = "0x4C77F90", VA = "0x184C79390")]
		private void EnsureDataInitialized()
		{
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B0")]
		[Address(RVA = "0x4C795C0", Offset = "0x4C781C0", VA = "0x184C795C0")]
		public void Refresh()
		{
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007F7")]
		internal string NormalizedPath
		{
			[Token(Token = "0x60031B1")]
			[Address(RVA = "0x4C7A090", Offset = "0x4C78C90", VA = "0x184C7A090")]
			get
			{
				return null;
			}
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B2")]
		[Address(RVA = "0x4C79640", Offset = "0x4C78240", VA = "0x184C79640")]
		protected FileSystemInfo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B3")]
		[Address(RVA = "0x4C79400", Offset = "0x4C78000", VA = "0x184C79400", Slot = "7")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007F8")]
		public virtual string FullName
		{
			[Token(Token = "0x60031B4")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007F9")]
		public virtual string Name
		{
			[Token(Token = "0x60031B5")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		[Token(Token = "0x170007FA")]
		public virtual bool Exists
		{
			[Token(Token = "0x60031B6")]
			[Address(RVA = "0x4C79AE0", Offset = "0x4C786E0", VA = "0x184C79AE0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		[Token(Token = "0x170007FB")]
		public System.DateTime CreationTime
		{
			[Token(Token = "0x60031B7")]
			[Address(RVA = "0x4C79960", Offset = "0x4C78560", VA = "0x184C79960")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		[Token(Token = "0x170007FC")]
		public System.DateTime CreationTimeUtc
		{
			[Token(Token = "0x60031B8")]
			[Address(RVA = "0x4C798A0", Offset = "0x4C784A0", VA = "0x184C798A0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x0001AB08 File Offset: 0x00018D08
		[Token(Token = "0x170007FD")]
		public System.DateTime LastAccessTime
		{
			[Token(Token = "0x60031B9")]
			[Address(RVA = "0x4C79CC0", Offset = "0x4C788C0", VA = "0x184C79CC0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x0001AB20 File Offset: 0x00018D20
		[Token(Token = "0x170007FE")]
		public System.DateTime LastAccessTimeUtc
		{
			[Token(Token = "0x60031BA")]
			[Address(RVA = "0x4C79C00", Offset = "0x4C78800", VA = "0x184C79C00")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x0001AB38 File Offset: 0x00018D38
		[Token(Token = "0x170007FF")]
		public System.DateTime LastWriteTime
		{
			[Token(Token = "0x60031BB")]
			[Address(RVA = "0x4C79F10", Offset = "0x4C78B10", VA = "0x184C79F10")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x0001AB50 File Offset: 0x00018D50
		[Token(Token = "0x17000800")]
		public System.DateTime LastWriteTimeUtc
		{
			[Token(Token = "0x60031BC")]
			[Address(RVA = "0x4C79E50", Offset = "0x4C78A50", VA = "0x184C79E50")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60031BD")]
		[Address(RVA = "0x4C795F0", Offset = "0x4C781F0", VA = "0x184C795F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001B2C RID: 6956
		[Token(Token = "0x4001B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA _data;

		// Token: 0x04001B2D RID: 6957
		[Token(Token = "0x4001B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _dataInitialized;

		// Token: 0x04001B2E RID: 6958
		[Token(Token = "0x4001B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected string FullPath;

		// Token: 0x04001B2F RID: 6959
		[Token(Token = "0x4001B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected string OriginalPath;

		// Token: 0x04001B30 RID: 6960
		[Token(Token = "0x4001B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal string _name;
	}
}
