using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[Preserve]
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008D")]
		internal static ReflectionDelegateFactory Instance
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x4D8F610", Offset = "0x4D8E210", VA = "0x184D8F610")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x4D8F380", Offset = "0x4D8DF80", VA = "0x184D8F380", Slot = "5")]
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method)
		{
			return null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			return null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LateBoundReflectionDelegateFactory()
		{
		}

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LateBoundReflectionDelegateFactory _instance;
	}
}
