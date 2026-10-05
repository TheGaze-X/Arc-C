using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComDefaultInterface(typeof(System.Runtime.InteropServices._Activator))]
	public sealed class Activator
	{
		// Token: 0x06000DAA RID: 3498 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x4D0CA70", Offset = "0x4D0B670", VA = "0x184D0CA70")]
		public static object CreateInstance(System.Type type, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x4D0CAE0", Offset = "0x4D0B6E0", VA = "0x184D0CAE0")]
		[MethodImpl(8)]
		public static object CreateInstance(System.Type type, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes)
		{
			return null;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x4D0CD60", Offset = "0x4D0B960", VA = "0x184D0CD60")]
		public static object CreateInstance(System.Type type, params object[] args)
		{
			return null;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x4D0CAA0", Offset = "0x4D0B6A0", VA = "0x184D0CAA0")]
		public static object CreateInstance(System.Type type, object[] args, object[] activationAttributes)
		{
			return null;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x4D0CD90", Offset = "0x4D0B990", VA = "0x184D0CD90")]
		public static object CreateInstance(System.Type type)
		{
			return null;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x4D0CAD0", Offset = "0x4D0B6D0", VA = "0x184D0CAD0")]
		public static object CreateInstance(System.Type type, bool nonPublic)
		{
			return null;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x4D0C890", Offset = "0x4D0B490", VA = "0x184D0C890")]
		[MethodImpl(8)]
		internal static object CreateInstance(System.Type type, bool nonPublic, bool wrapExceptions)
		{
			return null;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DB1")]
		[MethodImpl(8)]
		public static T CreateInstance<T>()
		{
			return null;
		}
	}
}
