using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004FC RID: 1276
	[Token(Token = "0x20004FC")]
	[System.Serializable]
	public abstract class FieldInfo : MemberInfo
	{
		// Token: 0x06002455 RID: 9301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected FieldInfo()
		{
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x000145F8 File Offset: 0x000127F8
		[Token(Token = "0x170004AE")]
		public override MemberTypes MemberType
		{
			[Token(Token = "0x6002456")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "7")]
			get
			{
				return (MemberTypes)0;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06002457 RID: 9303
		[Token(Token = "0x170004AF")]
		public abstract FieldAttributes Attributes { [Token(Token = "0x6002457")] get; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06002458 RID: 9304
		[Token(Token = "0x170004B0")]
		public abstract System.Type FieldType { [Token(Token = "0x6002458")] get; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x00014610 File Offset: 0x00012810
		[Token(Token = "0x170004B1")]
		public bool IsInitOnly
		{
			[Token(Token = "0x6002459")]
			[Address(RVA = "0x4BD4BD0", Offset = "0x4BD37D0", VA = "0x184BD4BD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x00014628 File Offset: 0x00012828
		[Token(Token = "0x170004B2")]
		public bool IsLiteral
		{
			[Token(Token = "0x600245A")]
			[Address(RVA = "0x4BD4C10", Offset = "0x4BD3810", VA = "0x184BD4C10", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x00014640 File Offset: 0x00012840
		[Token(Token = "0x170004B3")]
		public bool IsNotSerialized
		{
			[Token(Token = "0x600245B")]
			[Address(RVA = "0x4BD4C50", Offset = "0x4BD3850", VA = "0x184BD4C50", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x00014658 File Offset: 0x00012858
		[Token(Token = "0x170004B4")]
		public bool IsStatic
		{
			[Token(Token = "0x600245C")]
			[Address(RVA = "0x4BD4D10", Offset = "0x4BD3910", VA = "0x184BD4D10", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x00014670 File Offset: 0x00012870
		[Token(Token = "0x170004B5")]
		public bool IsPrivate
		{
			[Token(Token = "0x600245D")]
			[Address(RVA = "0x4BD4C90", Offset = "0x4BD3890", VA = "0x184BD4C90", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x00014688 File Offset: 0x00012888
		[Token(Token = "0x170004B6")]
		public bool IsPublic
		{
			[Token(Token = "0x600245E")]
			[Address(RVA = "0x4BD4CD0", Offset = "0x4BD38D0", VA = "0x184BD4CD0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600245F RID: 9311
		[Token(Token = "0x170004B7")]
		public abstract System.RuntimeFieldHandle FieldHandle { [Token(Token = "0x600245F")] get; }

		// Token: 0x06002460 RID: 9312 RVA: 0x000146A0 File Offset: 0x000128A0
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x000146B8 File Offset: 0x000128B8
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x000146D0 File Offset: 0x000128D0
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x4ED030", Offset = "0x4EBC30", VA = "0x1804ED030")]
		public static bool operator ==(FieldInfo left, FieldInfo right)
		{
			return default(bool);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x000146E8 File Offset: 0x000128E8
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x4ED060", Offset = "0x4EBC60", VA = "0x1804ED060")]
		public static bool operator !=(FieldInfo left, FieldInfo right)
		{
			return default(bool);
		}

		// Token: 0x06002464 RID: 9316
		[Token(Token = "0x6002464")]
		public abstract object GetValue(object obj);

		// Token: 0x06002465 RID: 9317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x4BD4B20", Offset = "0x4BD3720", VA = "0x184BD4B20", Slot = "26")]
		[System.Diagnostics.DebuggerHidden]
		[System.Diagnostics.DebuggerStepThrough]
		public void SetValue(object obj, object value)
		{
		}

		// Token: 0x06002466 RID: 9318
		[Token(Token = "0x6002466")]
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, System.Globalization.CultureInfo culture);

		// Token: 0x06002467 RID: 9319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x4BD4AC0", Offset = "0x4BD36C0", VA = "0x184BD4AC0", Slot = "28")]
		[System.CLSCompliant(false)]
		public virtual void SetValueDirect(System.TypedReference obj, object value)
		{
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x4BD4A60", Offset = "0x4BD3660", VA = "0x184BD4A60", Slot = "29")]
		public virtual object GetRawConstantValue()
		{
			return null;
		}

		// Token: 0x06002469 RID: 9321
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x4BD4D50", Offset = "0x4BD3950", VA = "0x184BD4D50")]
		[MethodImpl(4096)]
		private static extern FieldInfo internal_from_handle_type(System.IntPtr field_handle, System.IntPtr type_handle);

		// Token: 0x0600246A RID: 9322 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x4BD3E30", Offset = "0x4BD2A30", VA = "0x184BD3E30")]
		public static FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle handle)
		{
			return null;
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600246B")]
		[Address(RVA = "0x4BD3EF0", Offset = "0x4BD2AF0", VA = "0x184BD3EF0")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public static FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle handle, System.RuntimeTypeHandle declaringType)
		{
			return null;
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00014700 File Offset: 0x00012900
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x4BD4000", Offset = "0x4BD2C00", VA = "0x184BD4000", Slot = "30")]
		internal virtual int GetFieldOffset()
		{
			return 0;
		}

		// Token: 0x0600246D RID: 9325
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x4B69290", Offset = "0x4B67E90", VA = "0x184B69290")]
		[MethodImpl(4096)]
		private extern System.Runtime.InteropServices.MarshalAsAttribute get_marshal_info();

		// Token: 0x0600246E RID: 9326 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600246E")]
		[Address(RVA = "0x4BD4770", Offset = "0x4BD3370", VA = "0x184BD4770")]
		internal object[] GetPseudoCustomAttributes()
		{
			return null;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600246F")]
		[Address(RVA = "0x4BD4060", Offset = "0x4BD2C60", VA = "0x184BD4060")]
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			return null;
		}
	}
}
