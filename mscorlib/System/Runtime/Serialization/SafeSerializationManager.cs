using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	[System.Serializable]
	internal sealed class SafeSerializationManager : IObjectReference, ISerializable
	{
		// Token: 0x06002034 RID: 8244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002034")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal SafeSerializationManager()
		{
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002035")]
		[Address(RVA = "0x4BAA500", Offset = "0x4BA9100", VA = "0x184BAA500")]
		private SafeSerializationManager(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x000134B8 File Offset: 0x000116B8
		[Token(Token = "0x17000445")]
		internal bool IsActive
		{
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x1FF9050", Offset = "0x1FF7C50", VA = "0x181FF9050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002037")]
		[Address(RVA = "0x4BA9C90", Offset = "0x4BA8890", VA = "0x184BA9C90")]
		internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002038")]
		[Address(RVA = "0x4BA99D0", Offset = "0x4BA85D0", VA = "0x184BA99D0")]
		internal void CompleteDeserialization(object deserializedObject)
		{
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x4BAA3A0", Offset = "0x4BA8FA0", VA = "0x184BAA3A0", Slot = "5")]
		private void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x4BAA010", Offset = "0x4BA8C10", VA = "0x184BAA010", Slot = "4")]
		private object GetRealObject(StreamingContext context)
		{
			return null;
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x4BA9F50", Offset = "0x4BA8B50", VA = "0x184BA9F50")]
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
		}

		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.Generic.IList<object> m_serializedStates;

		// Token: 0x040010EA RID: 4330
		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x18")]
		private SerializationInfo m_savedSerializationInfo;

		// Token: 0x040010EB RID: 4331
		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x20")]
		private object m_realObject;

		// Token: 0x040010EC RID: 4332
		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x28")]
		private RuntimeType m_realType;

		// Token: 0x040010ED RID: 4333
		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x30")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.EventHandler<SafeSerializationEventArgs> SerializeObjectState;

		// Token: 0x040010EE RID: 4334
		[Token(Token = "0x40010EE")]
		private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";
	}
}
