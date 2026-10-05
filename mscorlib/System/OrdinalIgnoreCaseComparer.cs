using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	[System.Serializable]
	internal sealed class OrdinalIgnoreCaseComparer : System.OrdinalComparer, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000A69 RID: 2665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x4CF6890", Offset = "0x4CF5490", VA = "0x184CF6890")]
		public OrdinalIgnoreCaseComparer()
		{
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x4CF6750", Offset = "0x4CF5350", VA = "0x184CF6750", Slot = "10")]
		public override int Compare(string x, string y)
		{
			return 0;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x4CF6770", Offset = "0x4CF5370", VA = "0x184CF6770", Slot = "11")]
		public override bool Equals(string x, string y)
		{
			return default(bool);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0000A1A0 File Offset: 0x000083A0
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x4CF6790", Offset = "0x4CF5390", VA = "0x184CF6790", Slot = "12")]
		public override int GetHashCode(string obj)
		{
			return 0;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x4CF67F0", Offset = "0x4CF53F0", VA = "0x184CF67F0", Slot = "13")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
