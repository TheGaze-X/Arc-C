using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	[System.Serializable]
	public abstract class MethodBase : MemberInfo
	{
		// Token: 0x0600248D RID: 9357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected MethodBase()
		{
		}

		// Token: 0x0600248E RID: 9358
		[Token(Token = "0x600248E")]
		public abstract ParameterInfo[] GetParameters();

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600248F RID: 9359
		[Token(Token = "0x170004C1")]
		public abstract MethodAttributes Attributes { [Token(Token = "0x600248F")] get; }

		// Token: 0x06002490 RID: 9360
		[Token(Token = "0x6002490")]
		public abstract MethodImplAttributes GetMethodImplementationFlags();

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x000147A8 File Offset: 0x000129A8
		[Token(Token = "0x170004C2")]
		public virtual CallingConventions CallingConvention
		{
			[Token(Token = "0x6002491")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "19")]
			get
			{
				return (CallingConventions)0;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x000147C0 File Offset: 0x000129C0
		[Token(Token = "0x170004C3")]
		public bool IsAbstract
		{
			[Token(Token = "0x6002492")]
			[Address(RVA = "0x4BDA280", Offset = "0x4BD8E80", VA = "0x184BDA280", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x000147D8 File Offset: 0x000129D8
		[Token(Token = "0x170004C4")]
		public bool IsConstructor
		{
			[Token(Token = "0x6002493")]
			[Address(RVA = "0x4BDA2C0", Offset = "0x4BD8EC0", VA = "0x184BDA2C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x000147F0 File Offset: 0x000129F0
		[Token(Token = "0x170004C5")]
		public bool IsFinal
		{
			[Token(Token = "0x6002494")]
			[Address(RVA = "0x4BDA3B0", Offset = "0x4BD8FB0", VA = "0x184BDA3B0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x00014808 File Offset: 0x00012A08
		[Token(Token = "0x170004C6")]
		public bool IsSpecialName
		{
			[Token(Token = "0x6002495")]
			[Address(RVA = "0x4BDA4A0", Offset = "0x4BD90A0", VA = "0x184BDA4A0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x00014820 File Offset: 0x00012A20
		[Token(Token = "0x170004C7")]
		public bool IsStatic
		{
			[Token(Token = "0x6002496")]
			[Address(RVA = "0x4BDA4E0", Offset = "0x4BD90E0", VA = "0x184BDA4E0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x00014838 File Offset: 0x00012A38
		[Token(Token = "0x170004C8")]
		public bool IsVirtual
		{
			[Token(Token = "0x6002497")]
			[Address(RVA = "0x4BDA520", Offset = "0x4BD9120", VA = "0x184BDA520", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x00014850 File Offset: 0x00012A50
		[Token(Token = "0x170004C9")]
		public bool IsPrivate
		{
			[Token(Token = "0x6002498")]
			[Address(RVA = "0x4BDA3F0", Offset = "0x4BD8FF0", VA = "0x184BDA3F0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x00014868 File Offset: 0x00012A68
		[Token(Token = "0x170004CA")]
		public bool IsPublic
		{
			[Token(Token = "0x6002499")]
			[Address(RVA = "0x4BDA430", Offset = "0x4BD9030", VA = "0x184BDA430", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x00014880 File Offset: 0x00012A80
		[Token(Token = "0x170004CB")]
		public virtual bool IsGenericMethod
		{
			[Token(Token = "0x600249A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x00014898 File Offset: 0x00012A98
		[Token(Token = "0x170004CC")]
		public virtual bool IsGenericMethodDefinition
		{
			[Token(Token = "0x600249B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x4BD9D30", Offset = "0x4BD8930", VA = "0x184BD9D30", Slot = "30")]
		public virtual System.Type[] GetGenericArguments()
		{
			return null;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x000148B0 File Offset: 0x00012AB0
		[Token(Token = "0x170004CD")]
		public virtual bool ContainsGenericParameters
		{
			[Token(Token = "0x600249D")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x4BDA210", Offset = "0x4BD8E10", VA = "0x184BDA210", Slot = "32")]
		[System.Diagnostics.DebuggerHidden]
		[System.Diagnostics.DebuggerStepThrough]
		public object Invoke(object obj, object[] parameters)
		{
			return null;
		}

		// Token: 0x0600249F RID: 9375
		[Token(Token = "0x600249F")]
		public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture);

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060024A0 RID: 9376
		[Token(Token = "0x170004CE")]
		public abstract System.RuntimeMethodHandle MethodHandle { [Token(Token = "0x60024A0")] get; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000148C8 File Offset: 0x00012AC8
		[Token(Token = "0x170004CF")]
		public virtual bool IsSecurityCritical
		{
			[Token(Token = "0x60024A1")]
			[Address(RVA = "0x4BDA470", Offset = "0x4BD9070", VA = "0x184BDA470", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x000148E0 File Offset: 0x00012AE0
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x000148F8 File Offset: 0x00012AF8
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00014910 File Offset: 0x00012B10
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x4BDA560", Offset = "0x4BD9160", VA = "0x184BDA560")]
		public static bool operator ==(MethodBase left, MethodBase right)
		{
			return default(bool);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00014928 File Offset: 0x00012B28
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x4BDA730", Offset = "0x4BD9330", VA = "0x184BDA730")]
		public static bool operator !=(MethodBase left, MethodBase right)
		{
			return default(bool);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x4BDA1D0", Offset = "0x4BD8DD0", VA = "0x184BDA1D0", Slot = "36")]
		internal virtual ParameterInfo[] GetParametersInternal()
		{
			return null;
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00014940 File Offset: 0x00012B40
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x4BDA180", Offset = "0x4BD8D80", VA = "0x184BDA180", Slot = "37")]
		internal virtual int GetParametersCount()
		{
			return 0;
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x4BD9B60", Offset = "0x4BD8760", VA = "0x184BD9B60", Slot = "38")]
		internal virtual string FormatNameAndSig(bool serialization)
		{
			return null;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x4BDA030", Offset = "0x4BD8C30", VA = "0x184BDA030", Slot = "39")]
		internal virtual System.Type[] GetParameterTypes()
		{
			return null;
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x4BDA1D0", Offset = "0x4BD8DD0", VA = "0x184BDA1D0", Slot = "40")]
		internal virtual ParameterInfo[] GetParametersNoCopy()
		{
			return null;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x4BD9D90", Offset = "0x4BD8990", VA = "0x184BD9D90")]
		public static MethodBase GetMethodFromHandle(System.RuntimeMethodHandle handle)
		{
			return null;
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x4BD9940", Offset = "0x4BD8540", VA = "0x184BD9940")]
		internal static string ConstructParameters(System.Type[] parameterTypes, CallingConventions callingConvention, bool serialization)
		{
			return null;
		}

		// Token: 0x060024AD RID: 9389
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x4BD9CE0", Offset = "0x4BD88E0", VA = "0x184BD9CE0")]
		[MethodImpl(4096)]
		public static extern MethodBase GetCurrentMethod();
	}
}
