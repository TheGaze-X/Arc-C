using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[Serializable]
	public sealed class ToolboxItemFilterAttribute : Attribute
	{
		// Token: 0x06000CE9 RID: 3305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x5174EC0", Offset = "0x5173AC0", VA = "0x185174EC0")]
		public ToolboxItemFilterAttribute(string filterString)
		{
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x5174E30", Offset = "0x5173A30", VA = "0x185174E30")]
		public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
		{
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AA")]
		public string FilterString
		{
			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x170002AB")]
		public ToolboxItemFilterType FilterType
		{
			[Token(Token = "0x6000CEC")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return ToolboxItemFilterType.Allow;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AC")]
		public override object TypeId
		{
			[Token(Token = "0x6000CED")]
			[Address(RVA = "0x5174F40", Offset = "0x5173B40", VA = "0x185174F40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x5174B70", Offset = "0x5173770", VA = "0x185174B70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x5174C70", Offset = "0x5173870", VA = "0x185174C70", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x5174CC0", Offset = "0x51738C0", VA = "0x185174CC0", Slot = "5")]
		public override bool Match(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x5174D40", Offset = "0x5173940", VA = "0x185174D40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x10")]
		private string _typeId;
	}
}
