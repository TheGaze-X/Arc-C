using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06000AB2 RID: 2738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x5145ED0", Offset = "0x5144AD0", VA = "0x185145ED0")]
		public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes)
		{
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x5145D60", Offset = "0x5144960", VA = "0x185145D60")]
		public ExtendedPropertyDescriptor(PropertyDescriptor extender, Attribute[] attributes)
		{
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x5145C50", Offset = "0x5144850", VA = "0x185145C50", Slot = "23")]
		public override bool CanResetValue(object comp)
		{
			return default(bool);
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021F")]
		public override Type ComponentType
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x5146140", Offset = "0x5144D40", VA = "0x185146140", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x17000220")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x5146380", Offset = "0x5144F80", VA = "0x185146380", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000221")]
		public override Type PropertyType
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x51464C0", Offset = "0x51450C0", VA = "0x1851464C0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000222")]
		public override string DisplayName
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x5146190", Offset = "0x5144D90", VA = "0x185146190", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x5145C80", Offset = "0x5144880", VA = "0x185145C80", Slot = "26")]
		public override object GetValue(object comp)
		{
			return null;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x5145CB0", Offset = "0x51448B0", VA = "0x185145CB0", Slot = "29")]
		public override void ResetValue(object comp)
		{
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x5145CF0", Offset = "0x51448F0", VA = "0x185145CF0", Slot = "30")]
		public override void SetValue(object component, object value)
		{
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x5145D30", Offset = "0x5144930", VA = "0x185145D30", Slot = "31")]
		public override bool ShouldSerializeValue(object comp)
		{
			return default(bool);
		}

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x88")]
		private readonly ReflectPropertyDescriptor _extenderInfo;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x90")]
		private readonly IExtenderProvider _provider;
	}
}
