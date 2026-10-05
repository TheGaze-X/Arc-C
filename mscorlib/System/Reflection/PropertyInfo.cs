using System;
using System.Diagnostics;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	[System.Serializable]
	public abstract class PropertyInfo : MemberInfo
	{
		// Token: 0x060024E5 RID: 9445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PropertyInfo()
		{
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x00014B50 File Offset: 0x00012D50
		[Token(Token = "0x170004E2")]
		public override MemberTypes MemberType
		{
			[Token(Token = "0x60024E6")]
			[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "7")]
			get
			{
				return (MemberTypes)0;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060024E7 RID: 9447
		[Token(Token = "0x170004E3")]
		public abstract System.Type PropertyType { [Token(Token = "0x60024E7")] get; }

		// Token: 0x060024E8 RID: 9448
		[Token(Token = "0x60024E8")]
		public abstract ParameterInfo[] GetIndexParameters();

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060024E9 RID: 9449
		[Token(Token = "0x170004E4")]
		public abstract PropertyAttributes Attributes { [Token(Token = "0x60024E9")] get; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060024EA RID: 9450
		[Token(Token = "0x170004E5")]
		public abstract bool CanRead { [Token(Token = "0x60024EA")] get; }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060024EB RID: 9451
		[Token(Token = "0x170004E6")]
		public abstract bool CanWrite { [Token(Token = "0x60024EB")] get; }

		// Token: 0x060024EC RID: 9452
		[Token(Token = "0x60024EC")]
		public abstract MethodInfo[] GetAccessors(bool nonPublic);

		// Token: 0x060024ED RID: 9453 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x4BDBEE0", Offset = "0x4BDAAE0", VA = "0x184BDBEE0", Slot = "22")]
		public MethodInfo GetGetMethod()
		{
			return null;
		}

		// Token: 0x060024EE RID: 9454
		[Token(Token = "0x60024EE")]
		public abstract MethodInfo GetGetMethod(bool nonPublic);

		// Token: 0x060024EF RID: 9455 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024EF")]
		[Address(RVA = "0x4BDBF20", Offset = "0x4BDAB20", VA = "0x184BDBF20", Slot = "24")]
		public MethodInfo GetSetMethod()
		{
			return null;
		}

		// Token: 0x060024F0 RID: 9456
		[Token(Token = "0x60024F0")]
		public abstract MethodInfo GetSetMethod(bool nonPublic);

		// Token: 0x060024F1 RID: 9457 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024F1")]
		[Address(RVA = "0x4BDBF60", Offset = "0x4BDAB60", VA = "0x184BDBF60")]
		[System.Diagnostics.DebuggerStepThrough]
		[System.Diagnostics.DebuggerHidden]
		public object GetValue(object obj)
		{
			return null;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024F2")]
		[Address(RVA = "0x4BDBFB0", Offset = "0x4BDABB0", VA = "0x184BDBFB0", Slot = "26")]
		[System.Diagnostics.DebuggerHidden]
		[System.Diagnostics.DebuggerStepThrough]
		public virtual object GetValue(object obj, object[] index)
		{
			return null;
		}

		// Token: 0x060024F3 RID: 9459
		[Token(Token = "0x60024F3")]
		public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, System.Globalization.CultureInfo culture);

		// Token: 0x060024F4 RID: 9460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x4BDC020", Offset = "0x4BDAC20", VA = "0x184BDC020", Slot = "28")]
		[System.Diagnostics.DebuggerStepThrough]
		[System.Diagnostics.DebuggerHidden]
		public virtual void SetValue(object obj, object value, object[] index)
		{
		}

		// Token: 0x060024F5 RID: 9461
		[Token(Token = "0x60024F5")]
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, System.Globalization.CultureInfo culture);

		// Token: 0x060024F6 RID: 9462 RVA: 0x00014B68 File Offset: 0x00012D68
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00014B80 File Offset: 0x00012D80
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00014B98 File Offset: 0x00012D98
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x4ED030", Offset = "0x4EBC30", VA = "0x1804ED030")]
		public static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			return default(bool);
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00014BB0 File Offset: 0x00012DB0
		[Token(Token = "0x60024F9")]
		[Address(RVA = "0x4ED060", Offset = "0x4EBC60", VA = "0x1804ED060")]
		public static bool operator !=(PropertyInfo left, PropertyInfo right)
		{
			return default(bool);
		}
	}
}
