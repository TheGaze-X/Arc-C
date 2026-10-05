using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	internal sealed class SerializationEvents
	{
		// Token: 0x06001F99 RID: 8089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x4BAAF20", Offset = "0x4BA9B20", VA = "0x184BAAF20")]
		internal SerializationEvents(System.Type t)
		{
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0x4BAAC30", Offset = "0x4BA9830", VA = "0x184BAAC30")]
		private System.Collections.Generic.List<System.Reflection.MethodInfo> GetMethodsWithAttribute(System.Type attribute, System.Type t)
		{
			return null;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00013170 File Offset: 0x00011370
		[Token(Token = "0x17000423")]
		internal bool HasOnSerializingEvents
		{
			[Token(Token = "0x6001F9B")]
			[Address(RVA = "0x4BAB070", Offset = "0x4BA9C70", VA = "0x184BAB070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0x4BAAEE0", Offset = "0x4BA9AE0", VA = "0x184BAAEE0")]
		internal void InvokeOnSerializing(object obj, StreamingContext context)
		{
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0x4BAAEA0", Offset = "0x4BA9AA0", VA = "0x184BAAEA0")]
		internal void InvokeOnDeserializing(object obj, StreamingContext context)
		{
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0x4BAAE60", Offset = "0x4BA9A60", VA = "0x184BAAE60")]
		internal void InvokeOnDeserialized(object obj, StreamingContext context)
		{
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0x4BAAC10", Offset = "0x4BA9810", VA = "0x184BAAC10")]
		internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler)
		{
			return null;
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x4BAABF0", Offset = "0x4BA97F0", VA = "0x184BAABF0")]
		internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler)
		{
			return null;
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x4BAAE20", Offset = "0x4BA9A20", VA = "0x184BAAE20")]
		private static void InvokeOnDelegate(object obj, StreamingContext context, System.Collections.Generic.List<System.Reflection.MethodInfo> methods)
		{
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x4BAA9D0", Offset = "0x4BA95D0", VA = "0x184BAA9D0")]
		private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, System.Collections.Generic.List<System.Reflection.MethodInfo> methods)
		{
			return null;
		}

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.Collections.Generic.List<System.Reflection.MethodInfo> _onSerializingMethods;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x18")]
		private readonly System.Collections.Generic.List<System.Reflection.MethodInfo> _onSerializedMethods;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x20")]
		private readonly System.Collections.Generic.List<System.Reflection.MethodInfo> _onDeserializingMethods;

		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x28")]
		private readonly System.Collections.Generic.List<System.Reflection.MethodInfo> _onDeserializedMethods;
	}
}
