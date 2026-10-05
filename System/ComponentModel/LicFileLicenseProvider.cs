using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	public class LicFileLicenseProvider : LicenseProvider
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x00006330 File Offset: 0x00004530
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x5147DB0", Offset = "0x51469B0", VA = "0x185147DB0", Slot = "5")]
		protected virtual bool IsKeyValid(string key, Type type)
		{
			return default(bool);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x5147840", Offset = "0x5146440", VA = "0x185147840", Slot = "6")]
		protected virtual string GetKey(Type type)
		{
			return null;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x51478F0", Offset = "0x51464F0", VA = "0x1851478F0", Slot = "4")]
		public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
		{
			return null;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LicFileLicenseProvider()
		{
		}

		// Token: 0x020001B9 RID: 441
		[Token(Token = "0x20001B9")]
		private class LicFileLicense : License
		{
			// Token: 0x06000B3A RID: 2874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public LicFileLicense(LicFileLicenseProvider owner, string key)
			{
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000244")]
			public override string LicenseKey
			{
				[Token(Token = "0x6000B3B")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000B3C RID: 2876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x5147E30", Offset = "0x5146A30", VA = "0x185147E30", Slot = "6")]
			public override void Dispose()
			{
			}

			// Token: 0x040006B8 RID: 1720
			[Token(Token = "0x40006B8")]
			[FieldOffset(Offset = "0x10")]
			private LicFileLicenseProvider _owner;
		}
	}
}
