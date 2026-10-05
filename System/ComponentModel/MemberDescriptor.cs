using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	[ComVisible(true)]
	public abstract class MemberDescriptor
	{
		// Token: 0x06000DCC RID: 3532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x515E680", Offset = "0x515D280", VA = "0x18515E680")]
		protected MemberDescriptor(string name)
		{
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x515ED20", Offset = "0x515D920", VA = "0x18515ED20")]
		protected MemberDescriptor(string name, Attribute[] attributes)
		{
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x515E690", Offset = "0x515D290", VA = "0x18515E690")]
		protected MemberDescriptor(MemberDescriptor descr)
		{
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x515E850", Offset = "0x515D450", VA = "0x18515E850")]
		protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
		{
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E4")]
		protected virtual Attribute[] AttributeArray
		{
			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x515EED0", Offset = "0x515DAD0", VA = "0x18515EED0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DD1")]
			[Address(RVA = "0x515F830", Offset = "0x515E430", VA = "0x18515F830", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E5")]
		public virtual AttributeCollection Attributes
		{
			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x515EF00", Offset = "0x515DB00", VA = "0x18515EF00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		public virtual string Category
		{
			[Token(Token = "0x6000DD3")]
			[Address(RVA = "0x515EFF0", Offset = "0x515DBF0", VA = "0x18515EFF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E7")]
		public virtual string Description
		{
			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x515F1E0", Offset = "0x515DDE0", VA = "0x18515F1E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x000075A8 File Offset: 0x000057A8
		[Token(Token = "0x170002E8")]
		public virtual bool IsBrowsable
		{
			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0x515F6E0", Offset = "0x515E2E0", VA = "0x18515F6E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E9")]
		public virtual string Name
		{
			[Token(Token = "0x6000DD6")]
			[Address(RVA = "0x515F7F0", Offset = "0x515E3F0", VA = "0x18515F7F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x170002EA")]
		protected virtual int NameHashCode
		{
			[Token(Token = "0x6000DD7")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x170002EB")]
		public virtual bool DesignTimeOnly
		{
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x515F3F0", Offset = "0x515DFF0", VA = "0x18515F3F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EC")]
		public virtual string DisplayName
		{
			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0x515F530", Offset = "0x515E130", VA = "0x18515F530", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x515D740", Offset = "0x515C340", VA = "0x18515D740")]
		private void CheckAttributesValid()
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x515D800", Offset = "0x515C400", VA = "0x18515D800", Slot = "14")]
		protected virtual AttributeCollection CreateAttributeCollection()
		{
			return null;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x515D890", Offset = "0x515C490", VA = "0x18515D890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x515DB30", Offset = "0x515C730", VA = "0x18515DB30", Slot = "15")]
		protected virtual void FillAttributes(IList attributeList)
		{
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x515DC80", Offset = "0x515C880", VA = "0x18515DC80")]
		private void FilterAttributesIfNeeded()
		{
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x515E330", Offset = "0x515CF30", VA = "0x18515E330")]
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType)
		{
			return null;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x515E240", Offset = "0x515CE40", VA = "0x18515E240")]
		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly)
		{
			return null;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x515E350", Offset = "0x515CF50", VA = "0x18515E350", Slot = "16")]
		protected virtual object GetInvocationTarget(Type type, object instance)
		{
			return null;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x515E5D0", Offset = "0x515D1D0", VA = "0x18515E5D0")]
		protected static ISite GetSite(object component)
		{
			return null;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x515E490", Offset = "0x515D090", VA = "0x18515E490")]
		[Obsolete("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected static object GetInvokee(Type componentClass, object component)
		{
			return null;
		}

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string displayName;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int nameHash;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AttributeCollection attributeCollection;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Attribute[] attributes;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Attribute[] originalAttributes;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool attributesFiltered;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool attributesFilled;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int metadataVersion;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string category;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string description;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private object lockCookie;
	}
}
