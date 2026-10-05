using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	[System.Serializable]
	public abstract class MethodInfo : MethodBase
	{
		// Token: 0x060024AE RID: 9390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected MethodInfo()
		{
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x170004D0")]
		public override MemberTypes MemberType
		{
			[Token(Token = "0x60024AF")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "7")]
			get
			{
				return (MemberTypes)0;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004D1")]
		public virtual ParameterInfo ReturnParameter
		{
			[Token(Token = "0x60024B0")]
			[Address(RVA = "0x4BDA980", Offset = "0x4BD9580", VA = "0x184BDA980", Slot = "41")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004D2")]
		public virtual System.Type ReturnType
		{
			[Token(Token = "0x60024B1")]
			[Address(RVA = "0x4BDA9B0", Offset = "0x4BD95B0", VA = "0x184BDA9B0", Slot = "42")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0x4BDA810", Offset = "0x4BD9410", VA = "0x184BDA810", Slot = "30")]
		public override System.Type[] GetGenericArguments()
		{
			return null;
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x4BDA870", Offset = "0x4BD9470", VA = "0x184BDA870", Slot = "43")]
		public virtual MethodInfo GetGenericMethodDefinition()
		{
			return null;
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0x4BDA8D0", Offset = "0x4BD94D0", VA = "0x184BDA8D0", Slot = "44")]
		public virtual MethodInfo MakeGenericMethod(params System.Type[] typeArguments)
		{
			return null;
		}

		// Token: 0x060024B5 RID: 9397
		[Token(Token = "0x60024B5")]
		public abstract MethodInfo GetBaseDefinition();

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060024B6 RID: 9398
		[Token(Token = "0x170004D3")]
		public abstract ICustomAttributeProvider ReturnTypeCustomAttributes { [Token(Token = "0x60024B6")] get; }

		// Token: 0x060024B7 RID: 9399 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x4BDA750", Offset = "0x4BD9350", VA = "0x184BDA750", Slot = "47")]
		public virtual System.Delegate CreateDelegate(System.Type delegateType)
		{
			return null;
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x4BDA7B0", Offset = "0x4BD93B0", VA = "0x184BDA7B0", Slot = "48")]
		public virtual System.Delegate CreateDelegate(System.Type delegateType, object target)
		{
			return null;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00014970 File Offset: 0x00012B70
		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000149A0 File Offset: 0x00012BA0
		[Token(Token = "0x60024BB")]
		[Address(RVA = "0x4ED030", Offset = "0x4EBC30", VA = "0x1804ED030")]
		public static bool operator ==(MethodInfo left, MethodInfo right)
		{
			return default(bool);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x4ED060", Offset = "0x4EBC60", VA = "0x1804ED060")]
		public static bool operator !=(MethodInfo left, MethodInfo right)
		{
			return default(bool);
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x000149D0 File Offset: 0x00012BD0
		[Token(Token = "0x170004D4")]
		internal virtual int GenericParameterCount
		{
			[Token(Token = "0x60024BD")]
			[Address(RVA = "0x4BDA930", Offset = "0x4BD9530", VA = "0x184BDA930", Slot = "49")]
			get
			{
				return 0;
			}
		}
	}
}
