using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	[System.Serializable]
	public abstract class MemberInfo : ICustomAttributeProvider
	{
		// Token: 0x0600247F RID: 9343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected MemberInfo()
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06002480 RID: 9344
		[Token(Token = "0x170004BB")]
		public abstract MemberTypes MemberType { [Token(Token = "0x6002480")] get; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06002481 RID: 9345
		[Token(Token = "0x170004BC")]
		public abstract string Name { [Token(Token = "0x6002481")] get; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002482 RID: 9346
		[Token(Token = "0x170004BD")]
		public abstract System.Type DeclaringType { [Token(Token = "0x6002482")] get; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002483 RID: 9347
		[Token(Token = "0x170004BE")]
		public abstract System.Type ReflectedType { [Token(Token = "0x6002483")] get; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004BF")]
		public virtual Module Module
		{
			[Token(Token = "0x6002484")]
			[Address(RVA = "0x4BD9580", Offset = "0x4BD8180", VA = "0x184BD9580", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002485 RID: 9349
		[Token(Token = "0x6002485")]
		public abstract bool IsDefined(System.Type attributeType, bool inherit);

		// Token: 0x06002486 RID: 9350
		[Token(Token = "0x6002486")]
		public abstract object[] GetCustomAttributes(bool inherit);

		// Token: 0x06002487 RID: 9351
		[Token(Token = "0x6002487")]
		public abstract object[] GetCustomAttributes(System.Type attributeType, bool inherit);

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x00014730 File Offset: 0x00012930
		[Token(Token = "0x170004C0")]
		public virtual int MetadataToken
		{
			[Token(Token = "0x6002488")]
			[Address(RVA = "0x4BD9530", Offset = "0x4BD8130", VA = "0x184BD9530", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00014748 File Offset: 0x00012948
		[Token(Token = "0x6002489")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x00014760 File Offset: 0x00012960
		[Token(Token = "0x600248A")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00014778 File Offset: 0x00012978
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x4BD9690", Offset = "0x4BD8290", VA = "0x184BD9690")]
		public static bool operator ==(MemberInfo left, MemberInfo right)
		{
			return default(bool);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00014790 File Offset: 0x00012990
		[Token(Token = "0x600248C")]
		[Address(RVA = "0x4BD9920", Offset = "0x4BD8520", VA = "0x184BD9920")]
		public static bool operator !=(MemberInfo left, MemberInfo right)
		{
			return default(bool);
		}
	}
}
