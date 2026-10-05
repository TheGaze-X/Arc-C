using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	public abstract class PropertyDescriptor : MemberDescriptor
	{
		// Token: 0x06000C43 RID: 3139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x5145BC0", Offset = "0x51447C0", VA = "0x185145BC0")]
		protected PropertyDescriptor(string name, Attribute[] attrs)
		{
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x5145BE0", Offset = "0x51447E0", VA = "0x185145BE0")]
		protected PropertyDescriptor(MemberDescriptor descr)
		{
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x5145BD0", Offset = "0x51447D0", VA = "0x185145BD0")]
		protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs)
		{
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000C46 RID: 3142
		[Token(Token = "0x17000283")]
		public abstract Type ComponentType { [Token(Token = "0x6000C46")] get; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000284")]
		public virtual TypeConverter Converter
		{
			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x51541B0", Offset = "0x5152DB0", VA = "0x1851541B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x17000285")]
		public virtual bool IsLocalizable
		{
			[Token(Token = "0x6000C48")]
			[Address(RVA = "0x5154440", Offset = "0x5153040", VA = "0x185154440", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000C49 RID: 3145
		[Token(Token = "0x17000286")]
		public abstract bool IsReadOnly { [Token(Token = "0x6000C49")] get; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00006E58 File Offset: 0x00005058
		[Token(Token = "0x17000287")]
		public DesignerSerializationVisibility SerializationVisibility
		{
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x5154580", Offset = "0x5153180", VA = "0x185154580")]
			get
			{
				return DesignerSerializationVisibility.Hidden;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000C4B RID: 3147
		[Token(Token = "0x17000288")]
		public abstract Type PropertyType { [Token(Token = "0x6000C4B")] get; }

		// Token: 0x06000C4C RID: 3148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x5152F20", Offset = "0x5151B20", VA = "0x185152F20", Slot = "22")]
		public virtual void AddValueChanged(object component, EventHandler handler)
		{
		}

		// Token: 0x06000C4D RID: 3149
		[Token(Token = "0x6000C4D")]
		public abstract bool CanResetValue(object component);

		// Token: 0x06000C4E RID: 3150 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x5153340", Offset = "0x5151F40", VA = "0x185153340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x5153100", Offset = "0x5151D00", VA = "0x185153100")]
		protected object CreateInstance(Type type)
		{
			return null;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x51534B0", Offset = "0x51520B0", VA = "0x1851534B0", Slot = "15")]
		protected override void FillAttributes(IList attributeList)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x5153690", Offset = "0x5152290", VA = "0x185153690")]
		public PropertyDescriptorCollection GetChildProperties()
		{
			return null;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x5153520", Offset = "0x5152120", VA = "0x185153520")]
		public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
		{
			return null;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x5153570", Offset = "0x5152170", VA = "0x185153570")]
		public PropertyDescriptorCollection GetChildProperties(object instance)
		{
			return null;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x51535C0", Offset = "0x51521C0", VA = "0x1851535C0", Slot = "24")]
		public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
		{
			return null;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x51536D0", Offset = "0x51522D0", VA = "0x1851536D0", Slot = "25")]
		public virtual object GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x5153B00", Offset = "0x5152700", VA = "0x185153B00", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x5153BB0", Offset = "0x51527B0", VA = "0x185153BB0", Slot = "16")]
		protected override object GetInvocationTarget(Type type, object instance)
		{
			return null;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x5153C50", Offset = "0x5152850", VA = "0x185153C50")]
		protected Type GetTypeFromName(string typeName)
		{
			return null;
		}

		// Token: 0x06000C59 RID: 3161
		[Token(Token = "0x6000C59")]
		public abstract object GetValue(object component);

		// Token: 0x06000C5A RID: 3162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x5153F20", Offset = "0x5152B20", VA = "0x185153F20", Slot = "27")]
		protected virtual void OnValueChanged(object component, EventArgs e)
		{
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x5153FE0", Offset = "0x5152BE0", VA = "0x185153FE0", Slot = "28")]
		public virtual void RemoveValueChanged(object component, EventHandler handler)
		{
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x5153E80", Offset = "0x5152A80", VA = "0x185153E80")]
		protected internal EventHandler GetValueChangedHandler(object component)
		{
			return null;
		}

		// Token: 0x06000C5D RID: 3165
		[Token(Token = "0x6000C5D")]
		public abstract void ResetValue(object component);

		// Token: 0x06000C5E RID: 3166
		[Token(Token = "0x6000C5E")]
		public abstract void SetValue(object component, object value);

		// Token: 0x06000C5F RID: 3167
		[Token(Token = "0x6000C5F")]
		public abstract bool ShouldSerializeValue(object component);

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x17000289")]
		public virtual bool SupportsChangeEvents
		{
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x60")]
		private TypeConverter _converter;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x68")]
		private Hashtable _valueChangedHandlers;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x70")]
		private object[] _editors;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x78")]
		private Type[] _editorTypes;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x80")]
		private int _editorCount;
	}
}
