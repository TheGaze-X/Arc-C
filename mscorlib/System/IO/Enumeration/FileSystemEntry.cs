using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.IO.Enumeration
{
	// Token: 0x0200068F RID: 1679
	[Token(Token = "0x200068F")]
	[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public ref struct FileSystemEntry
	{
		// Token: 0x06003343 RID: 13123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003343")]
		[Address(RVA = "0x4C979B0", Offset = "0x4C965B0", VA = "0x184C979B0")]
		internal unsafe static void Initialize(ref FileSystemEntry entry, Interop.NtDll.FILE_FULL_DIR_INFORMATION* info, System.ReadOnlySpan<char> directory, System.ReadOnlySpan<char> rootDirectory, System.ReadOnlySpan<char> originalRootDirectory)
		{
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x0001B510 File Offset: 0x00019710
		// (set) Token: 0x06003345 RID: 13125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000829")]
		public System.ReadOnlySpan<char> Directory
		{
			[Token(Token = "0x6003344")]
			[Address(RVA = "0x4007430", Offset = "0x4006030", VA = "0x184007430")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			readonly get
			{
				return default(System.ReadOnlySpan<char>);
			}
			[Token(Token = "0x6003345")]
			[Address(RVA = "0x4C97D60", Offset = "0x4C96960", VA = "0x184C97D60")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06003346 RID: 13126 RVA: 0x0001B528 File Offset: 0x00019728
		// (set) Token: 0x06003347 RID: 13127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082A")]
		public System.ReadOnlySpan<char> RootDirectory
		{
			[Token(Token = "0x6003346")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			readonly get
			{
				return default(System.ReadOnlySpan<char>);
			}
			[Token(Token = "0x6003347")]
			[Address(RVA = "0x36B1B50", Offset = "0x36B0750", VA = "0x1836B1B50")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06003348 RID: 13128 RVA: 0x0001B540 File Offset: 0x00019740
		// (set) Token: 0x06003349 RID: 13129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082B")]
		public System.ReadOnlySpan<char> OriginalRootDirectory
		{
			[Token(Token = "0x6003348")]
			[Address(RVA = "0x4013E20", Offset = "0x4012A20", VA = "0x184013E20")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			readonly get
			{
				return default(System.ReadOnlySpan<char>);
			}
			[Token(Token = "0x6003349")]
			[Address(RVA = "0x4C97D70", Offset = "0x4C96970", VA = "0x184C97D70")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600334A RID: 13130 RVA: 0x0001B558 File Offset: 0x00019758
		[Token(Token = "0x1700082C")]
		public System.ReadOnlySpan<char> FileName
		{
			[Token(Token = "0x600334A")]
			[Address(RVA = "0x4C97D10", Offset = "0x4C96910", VA = "0x184C97D10")]
			get
			{
				return default(System.ReadOnlySpan<char>);
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x0001B570 File Offset: 0x00019770
		[Token(Token = "0x1700082D")]
		public FileAttributes Attributes
		{
			[Token(Token = "0x600334B")]
			[Address(RVA = "0x4C97CF0", Offset = "0x4C968F0", VA = "0x184C97CF0")]
			get
			{
				return (FileAttributes)0;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x0001B588 File Offset: 0x00019788
		[Token(Token = "0x1700082E")]
		public bool IsDirectory
		{
			[Token(Token = "0x600334C")]
			[Address(RVA = "0x4C97D40", Offset = "0x4C96940", VA = "0x184C97D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600334D")]
		[Address(RVA = "0x4C979D0", Offset = "0x4C965D0", VA = "0x184C979D0")]
		public FileSystemInfo ToFileSystemInfo()
		{
			return null;
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600334E")]
		[Address(RVA = "0x4C97AF0", Offset = "0x4C966F0", VA = "0x184C97AF0")]
		public string ToSpecifiedFullPath()
		{
			return null;
		}

		// Token: 0x04001BF7 RID: 7159
		[Token(Token = "0x4001BF7")]
		[FieldOffset(Offset = "0x0")]
		internal unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _info;
	}
}
