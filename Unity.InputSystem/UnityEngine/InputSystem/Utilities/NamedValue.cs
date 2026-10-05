using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	public struct NamedValue : IEquatable<NamedValue>
	{
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D4")]
		public string name
		{
			[Token(Token = "0x6001521")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001522")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0000B3B8 File Offset: 0x000095B8
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D5")]
		public PrimitiveValue value
		{
			[Token(Token = "0x6001523")]
			[Address(RVA = "0x4007430", Offset = "0x4006030", VA = "0x184007430")]
			[CompilerGenerated]
			readonly get
			{
				return default(PrimitiveValue);
			}
			[Token(Token = "0x6001524")]
			[Address(RVA = "0x4C97D60", Offset = "0x4C96960", VA = "0x184C97D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x170005D6")]
		public TypeCode type
		{
			[Token(Token = "0x6001525")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return TypeCode.Empty;
			}
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x56114F0", Offset = "0x56100F0", VA = "0x1856114F0")]
		public NamedValue ConvertTo(TypeCode type)
		{
			return default(NamedValue);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x6001527")]
		public static NamedValue From<TValue>(string name, TValue value) where TValue : struct
		{
			return default(NamedValue);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x5611CD0", Offset = "0x56108D0", VA = "0x185611CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x5611560", Offset = "0x5610160", VA = "0x185611560", Slot = "4")]
		public bool Equals(NamedValue other)
		{
			return default(bool);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x56115E0", Offset = "0x56101E0", VA = "0x1856115E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x56116D0", Offset = "0x56102D0", VA = "0x1856116D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x5611D50", Offset = "0x5610950", VA = "0x185611D50")]
		public static bool operator ==(NamedValue left, NamedValue right)
		{
			return default(bool);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x5611DD0", Offset = "0x56109D0", VA = "0x185611DD0")]
		public static bool operator !=(NamedValue left, NamedValue right)
		{
			return default(bool);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x56117C0", Offset = "0x56103C0", VA = "0x1856117C0")]
		public static NamedValue[] ParseMultiple(string parameterString)
		{
			return null;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x5611C90", Offset = "0x5610890", VA = "0x185611C90")]
		public static NamedValue Parse(string str)
		{
			return default(NamedValue);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x56119A0", Offset = "0x56105A0", VA = "0x1856119A0")]
		private static NamedValue ParseParameter(string parameterString, ref int index)
		{
			return default(NamedValue);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x56111B0", Offset = "0x560FDB0", VA = "0x1856111B0")]
		public void ApplyToObject(object instance)
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001532")]
		public static void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters) where TParameterList : IEnumerable<NamedValue>
		{
		}

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		public const string Separator = ",";
	}
}
