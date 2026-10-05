using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	public class DescriptionPair
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000083")]
		public object Value
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000084")]
		public Description Description
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public DescriptionPair(object value, Description descriptor)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4ECDD0", Offset = "0x4EB9D0", VA = "0x1804ECDD0")]
		public DescriptionPair(object value, string name)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4ECEE0", Offset = "0x4EBAE0", VA = "0x1804ECEE0")]
		public DescriptionPair(object value, string name, string description)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4ED030", Offset = "0x4EBC30", VA = "0x1804ED030")]
		public static bool operator ==(DescriptionPair a, DescriptionPair b)
		{
			return default(bool);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4ED060", Offset = "0x4EBC60", VA = "0x1804ED060")]
		public static bool operator !=(DescriptionPair a, DescriptionPair b)
		{
			return default(bool);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4EC7F0", Offset = "0x4EB3F0", VA = "0x1804EC7F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4EC8D0", Offset = "0x4EB4D0", VA = "0x1804EC8D0")]
		public static DescriptionPair GetDescription(object item)
		{
			return null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4ECB40", Offset = "0x4EB740", VA = "0x1804ECB40")]
		public static IList<DescriptionPair> GetDescriptions(IList items)
		{
			return null;
		}

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x10")]
		private object value;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x18")]
		private Description description;
	}
}
