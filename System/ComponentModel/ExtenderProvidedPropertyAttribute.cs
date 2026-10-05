using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ExtenderProvidedPropertyAttribute : Attribute
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x51464F0", Offset = "0x51450F0", VA = "0x1851464F0")]
		internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider)
		{
			return null;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ExtenderProvidedPropertyAttribute()
		{
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000223")]
		public PropertyDescriptor ExtenderProperty
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000224")]
		public IExtenderProvider Provider
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000225")]
		public Type ReceiverType
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x51465A0", Offset = "0x51451A0", VA = "0x1851465A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x51466A0", Offset = "0x51452A0", VA = "0x1851466A0", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}
	}
}
