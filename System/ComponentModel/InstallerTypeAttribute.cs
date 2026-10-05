using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	[AttributeUsage(AttributeTargets.Class)]
	public class InstallerTypeAttribute : Attribute
	{
		// Token: 0x06000B1B RID: 2843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x51471B0", Offset = "0x5145DB0", VA = "0x1851471B0")]
		public InstallerTypeAttribute(Type installerType)
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public InstallerTypeAttribute(string typeName)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023F")]
		public virtual Type InstallerType
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x5147220", Offset = "0x5145E20", VA = "0x185147220", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x51470F0", Offset = "0x5145CF0", VA = "0x1851470F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x10")]
		private string _typeName;
	}
}
