using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000542 RID: 1346
	[Token(Token = "0x2000542")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class StrongNameKeyPair : System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x06002770 RID: 10096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x4C27870", Offset = "0x4C26470", VA = "0x184C27870")]
		protected StrongNameKeyPair(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x4C27730", Offset = "0x4C26330", VA = "0x184C27730", Slot = "4")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x0400163E RID: 5694
		[Token(Token = "0x400163E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] _publicKey;

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _keyPairContainer;

		// Token: 0x04001640 RID: 5696
		[Token(Token = "0x4001640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _keyPairExported;

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _keyPairArray;
	}
}
