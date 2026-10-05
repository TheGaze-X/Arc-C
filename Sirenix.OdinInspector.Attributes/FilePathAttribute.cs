using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class FilePathAttribute : Attribute
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Add a ReadOnly attribute to the property instead.", true)]
		public bool ReadOnly
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x4EF620", Offset = "0x4EE220", VA = "0x1804EF620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4E180B0", Offset = "0x4E16CB0", VA = "0x184E180B0")]
		public FilePathAttribute()
		{
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		public bool AbsolutePath;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x18")]
		public string Extensions;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x20")]
		public string ParentFolder;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x28")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use RequireExistingPath instead.", true)]
		public bool RequireValidPath;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x29")]
		public bool RequireExistingPath;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x2A")]
		public bool UseBackslashes;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x2B")]
		public bool IncludeFileExtension;
	}
}
