using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BD6 RID: 31702
	[Token(Token = "0x2007BD6")]
	public struct InspectedMember
	{
		// Token: 0x170067E3 RID: 26595
		// (get) Token: 0x0602C5E7 RID: 181735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067E3")]
		public InspectedProperty Property
		{
			[Token(Token = "0x602C5E7")]
			[Address(RVA = "0x285B730", Offset = "0x285A330", VA = "0x18285B730")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067E4 RID: 26596
		// (get) Token: 0x0602C5E8 RID: 181736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067E4")]
		public InspectedMethod Method
		{
			[Token(Token = "0x602C5E8")]
			[Address(RVA = "0x285B660", Offset = "0x285A260", VA = "0x18285B660")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067E5 RID: 26597
		// (get) Token: 0x0602C5E9 RID: 181737 RVA: 0x000DFBC0 File Offset: 0x000DDDC0
		[Token(Token = "0x170067E5")]
		public bool IsMethod
		{
			[Token(Token = "0x602C5E9")]
			[Address(RVA = "0xEDB190", Offset = "0xED9D90", VA = "0x180EDB190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170067E6 RID: 26598
		// (get) Token: 0x0602C5EA RID: 181738 RVA: 0x000DFBD8 File Offset: 0x000DDDD8
		[Token(Token = "0x170067E6")]
		public bool IsProperty
		{
			[Token(Token = "0x602C5EA")]
			[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170067E7 RID: 26599
		// (get) Token: 0x0602C5EB RID: 181739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067E7")]
		public string Name
		{
			[Token(Token = "0x602C5EB")]
			[Address(RVA = "0x285B6D0", Offset = "0x285A2D0", VA = "0x18285B6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067E8 RID: 26600
		// (get) Token: 0x0602C5EC RID: 181740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067E8")]
		public MemberInfo MemberInfo
		{
			[Token(Token = "0x602C5EC")]
			[Address(RVA = "0x285B630", Offset = "0x285A230", VA = "0x18285B630")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C5ED RID: 181741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5ED")]
		[Address(RVA = "0xF5A710", Offset = "0xF59310", VA = "0x180F5A710")]
		public InspectedMember(InspectedProperty property)
		{
		}

		// Token: 0x0602C5EE RID: 181742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5EE")]
		[Address(RVA = "0x285B5F0", Offset = "0x285A1F0", VA = "0x18285B5F0")]
		public InspectedMember(InspectedMethod method)
		{
		}

		// Token: 0x0404024A RID: 262730
		[Token(Token = "0x404024A")]
		[FieldOffset(Offset = "0x0")]
		private InspectedProperty _property;

		// Token: 0x0404024B RID: 262731
		[Token(Token = "0x404024B")]
		[FieldOffset(Offset = "0x8")]
		private InspectedMethod _method;
	}
}
