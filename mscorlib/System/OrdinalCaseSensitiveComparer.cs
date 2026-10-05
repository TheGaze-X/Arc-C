using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	[System.Serializable]
	internal sealed class OrdinalCaseSensitiveComparer : System.OrdinalComparer, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x4CF6420", Offset = "0x4CF5020", VA = "0x184CF6420")]
		public OrdinalCaseSensitiveComparer()
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x100ED90", Offset = "0x100D990", VA = "0x18100ED90", Slot = "10")]
		public override int Compare(string x, string y)
		{
			return 0;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x4BD3BE0", Offset = "0x4BD27E0", VA = "0x184BD3BE0", Slot = "11")]
		public override bool Equals(string x, string y)
		{
			return default(bool);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x4CF6330", Offset = "0x4CF4F30", VA = "0x184CF6330", Slot = "12")]
		public override int GetHashCode(string obj)
		{
			return 0;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x4CF6380", Offset = "0x4CF4F80", VA = "0x184CF6380", Slot = "13")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
