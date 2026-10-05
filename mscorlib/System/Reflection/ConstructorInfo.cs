using System;
using System.Diagnostics;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004F4 RID: 1268
	[Token(Token = "0x20004F4")]
	[System.Serializable]
	public abstract class ConstructorInfo : MethodBase
	{
		// Token: 0x06002436 RID: 9270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ConstructorInfo()
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x00014508 File Offset: 0x00012708
		[Token(Token = "0x170004AA")]
		public override MemberTypes MemberType
		{
			[Token(Token = "0x6002437")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "7")]
			get
			{
				return (MemberTypes)0;
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x4BD1260", Offset = "0x4BCFE60", VA = "0x184BD1260")]
		[System.Diagnostics.DebuggerHidden]
		[System.Diagnostics.DebuggerStepThrough]
		public object Invoke(object[] parameters)
		{
			return null;
		}

		// Token: 0x06002439 RID: 9273
		[Token(Token = "0x6002439")]
		public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture);

		// Token: 0x0600243A RID: 9274 RVA: 0x00014520 File Offset: 0x00012720
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00014538 File Offset: 0x00012738
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00014550 File Offset: 0x00012750
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x4ED030", Offset = "0x4EBC30", VA = "0x1804ED030")]
		public static bool operator ==(ConstructorInfo left, ConstructorInfo right)
		{
			return default(bool);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00014568 File Offset: 0x00012768
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x4BD1370", Offset = "0x4BCFF70", VA = "0x184BD1370")]
		public static bool operator !=(ConstructorInfo left, ConstructorInfo right)
		{
			return default(bool);
		}

		// Token: 0x040014B6 RID: 5302
		[Token(Token = "0x40014B6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ConstructorName;

		// Token: 0x040014B7 RID: 5303
		[Token(Token = "0x40014B7")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string TypeConstructorName;
	}
}
