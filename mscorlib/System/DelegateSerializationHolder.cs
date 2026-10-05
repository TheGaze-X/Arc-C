using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	[System.Serializable]
	internal class DelegateSerializationHolder : System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IObjectReference
	{
		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x4D31880", Offset = "0x4D30480", VA = "0x184D31880")]
		private DelegateSerializationHolder(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x4D315E0", Offset = "0x4D301E0", VA = "0x184D315E0")]
		public static void GetDelegateData(System.Delegate instance, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x4D31830", Offset = "0x4D30430", VA = "0x184D31830", Slot = "4")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public object GetRealObject(System.Runtime.Serialization.StreamingContext context)
		{
			return null;
		}

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x10")]
		private System.Delegate _delegate;

		// Token: 0x020001A5 RID: 421
		[Token(Token = "0x20001A5")]
		[System.Serializable]
		private class DelegateEntry
		{
			// Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FD6")]
			[Address(RVA = "0x4D312F0", Offset = "0x4D2FEF0", VA = "0x184D312F0")]
			public DelegateEntry(System.Delegate del, string targetLabel)
			{
			}

			// Token: 0x06000FD7 RID: 4055 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x4D30FC0", Offset = "0x4D2FBC0", VA = "0x184D30FC0")]
			public System.Delegate DeserializeDelegate(System.Runtime.Serialization.SerializationInfo info, int index)
			{
				return null;
			}

			// Token: 0x04000758 RID: 1880
			[Token(Token = "0x4000758")]
			[FieldOffset(Offset = "0x10")]
			private string type;

			// Token: 0x04000759 RID: 1881
			[Token(Token = "0x4000759")]
			[FieldOffset(Offset = "0x18")]
			private string assembly;

			// Token: 0x0400075A RID: 1882
			[Token(Token = "0x400075A")]
			[FieldOffset(Offset = "0x20")]
			private object target;

			// Token: 0x0400075B RID: 1883
			[Token(Token = "0x400075B")]
			[FieldOffset(Offset = "0x28")]
			private string targetTypeAssembly;

			// Token: 0x0400075C RID: 1884
			[Token(Token = "0x400075C")]
			[FieldOffset(Offset = "0x30")]
			private string targetTypeName;

			// Token: 0x0400075D RID: 1885
			[Token(Token = "0x400075D")]
			[FieldOffset(Offset = "0x38")]
			private string methodName;

			// Token: 0x0400075E RID: 1886
			[Token(Token = "0x400075E")]
			[FieldOffset(Offset = "0x40")]
			public DelegateSerializationHolder.DelegateEntry delegateEntry;
		}
	}
}
