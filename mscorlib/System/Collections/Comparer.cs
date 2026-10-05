using System;
using System.Globalization;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005B6 RID: 1462
	[Token(Token = "0x20005B6")]
	[System.Serializable]
	public sealed class Comparer : IComparer, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06002B82 RID: 11138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x4C5CB40", Offset = "0x4C5B740", VA = "0x184C5CB40")]
		public Comparer(System.Globalization.CultureInfo culture)
		{
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x4C5C940", Offset = "0x4C5B540", VA = "0x184C5C940")]
		private Comparer(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x4C5C670", Offset = "0x4C5B270", VA = "0x184C5C670", Slot = "5")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x00018048 File Offset: 0x00016248
		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x4C5C4A0", Offset = "0x4C5B0A0", VA = "0x184C5C4A0", Slot = "4")]
		public int Compare(object a, object b)
		{
			return 0;
		}

		// Token: 0x04001972 RID: 6514
		[Token(Token = "0x4001972")]
		[FieldOffset(Offset = "0x10")]
		private System.Globalization.CompareInfo _compareInfo;

		// Token: 0x04001973 RID: 6515
		[Token(Token = "0x4001973")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Comparer Default;

		// Token: 0x04001974 RID: 6516
		[Token(Token = "0x4001974")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Comparer DefaultInvariant;
	}
}
