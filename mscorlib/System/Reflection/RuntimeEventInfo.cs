using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000534 RID: 1332
	[Token(Token = "0x2000534")]
	[System.Serializable]
	[StructLayout(0)]
	internal sealed class RuntimeEventInfo : EventInfo, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06002691 RID: 9873
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x4C21040", Offset = "0x4C1FC40", VA = "0x184C21040")]
		[MethodImpl(4096)]
		private static extern void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info);

		// Token: 0x06002692 RID: 9874 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x4C20A90", Offset = "0x4C1F690", VA = "0x184C20A90")]
		internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev)
		{
			return default(MonoEventInfo);
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000557")]
		public override Module Module
		{
			[Token(Token = "0x6002693")]
			[Address(RVA = "0x4C20D60", Offset = "0x4C1F960", VA = "0x184C20D60", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x17000558")]
		internal BindingFlags BindingFlags
		{
			[Token(Token = "0x6002694")]
			[Address(RVA = "0x4C20750", Offset = "0x4C1F350", VA = "0x184C20750")]
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x4C209B0", Offset = "0x4C1F5B0", VA = "0x184C209B0")]
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return null;
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000559")]
		private RuntimeType ReflectedTypeInternal
		{
			[Token(Token = "0x6002696")]
			[Address(RVA = "0x4C20F30", Offset = "0x4C1FB30", VA = "0x184C20F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x4C20D60", Offset = "0x4C1F960", VA = "0x184C20D60")]
		internal RuntimeModule GetRuntimeModule()
		{
			return null;
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x4C20AD0", Offset = "0x4C1F6D0", VA = "0x184C20AD0", Slot = "22")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000155D0 File Offset: 0x000137D0
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x4C20750", Offset = "0x4C1F350", VA = "0x184C20750")]
		internal BindingFlags GetBindingFlags()
		{
			return BindingFlags.Default;
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x4C206D0", Offset = "0x4C1F2D0", VA = "0x184C206D0", Slot = "18")]
		public override MethodInfo GetAddMethod(bool nonPublic)
		{
			return null;
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x4C20C60", Offset = "0x4C1F860", VA = "0x184C20C60", Slot = "20")]
		public override MethodInfo GetRaiseMethod(bool nonPublic)
		{
			return null;
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x4C20CE0", Offset = "0x4C1F8E0", VA = "0x184C20CE0", Slot = "19")]
		public override MethodInfo GetRemoveMethod(bool nonPublic)
		{
			return null;
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700055A")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x600269D")]
			[Address(RVA = "0x4C20ED0", Offset = "0x4C1FAD0", VA = "0x184C20ED0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700055B")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x600269E")]
			[Address(RVA = "0x4C21010", Offset = "0x4C1FC10", VA = "0x184C21010", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700055C")]
		public override string Name
		{
			[Token(Token = "0x600269F")]
			[Address(RVA = "0x4C20F00", Offset = "0x4C1FB00", VA = "0x184C20F00", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x4C20E00", Offset = "0x4C1FA00", VA = "0x184C20E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x4C20D90", Offset = "0x4C1F990", VA = "0x184C20D90", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x4C20950", Offset = "0x4C1F550", VA = "0x184C20950", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x4C208E0", Offset = "0x4C1F4E0", VA = "0x184C208E0", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x00015600 File Offset: 0x00013800
		[Token(Token = "0x1700055D")]
		public override int MetadataToken
		{
			[Token(Token = "0x60026A4")]
			[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060026A5 RID: 9893
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0")]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimeEventInfo monoEvent);

		// Token: 0x060026A6 RID: 9894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RuntimeEventInfo()
		{
		}

		// Token: 0x04001612 RID: 5650
		[Token(Token = "0x4001612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.IntPtr klass;

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.IntPtr handle;
	}
}
