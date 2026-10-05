using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class CollectionAttribute : Attribute, IListAttribute, IRuntimeAttribute<string[]>, IRuntimeAttribute
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public int Size
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public bool Sortable
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public CollectionDisplay Display
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return CollectionDisplay.List;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002118 File Offset: 0x00000318
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public int MaxDisplayedItems
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public bool AlwaysExpanded
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public bool ExpandElements
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x4EA870", Offset = "0x4E9470", VA = "0x1804EA870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x4EAC00", Offset = "0x4E9800", VA = "0x1804EAC00")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public Type EnumType
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x4EA9B0", Offset = "0x4E95B0", VA = "0x1804EA9B0")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public string MethodName
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000013")]
		public Type Template
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x4EA920", Offset = "0x4E9520", VA = "0x1804EA920", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000014")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x4EA8C0", Offset = "0x4E94C0", VA = "0x1804EA8C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4E9D40", Offset = "0x4E8940", VA = "0x1804E9D40", Slot = "7")]
		public string[] Invoke(int index, object instance, object value)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4EA280", Offset = "0x4E8E80", VA = "0x1804EA280")]
		public CollectionAttribute()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4EA340", Offset = "0x4E8F40", VA = "0x1804EA340")]
		public CollectionAttribute(int size)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4EA680", Offset = "0x4E9280", VA = "0x1804EA680")]
		public CollectionAttribute(Type enumType)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4EA770", Offset = "0x4E9370", VA = "0x1804EA770")]
		public CollectionAttribute(bool sortable)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4EA3A0", Offset = "0x4E8FA0", VA = "0x1804EA3A0")]
		public CollectionAttribute(string methodName)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4EA6F0", Offset = "0x4E92F0", VA = "0x1804EA6F0")]
		public CollectionAttribute(CollectionDisplay display)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4EA7D0", Offset = "0x4E93D0", VA = "0x1804EA7D0")]
		public CollectionAttribute(int size, bool sortable)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4EA750", Offset = "0x4E9350", VA = "0x1804EA750")]
		public CollectionAttribute(Type enumType, bool sortable)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4EA610", Offset = "0x4E9210", VA = "0x1804EA610")]
		public CollectionAttribute(int size, CollectionDisplay display)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4EA6A0", Offset = "0x4E92A0", VA = "0x1804EA6A0")]
		public CollectionAttribute(Type enumType, CollectionDisplay display)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4EA120", Offset = "0x4E8D20", VA = "0x1804EA120")]
		public CollectionAttribute(string methodName, int size, bool sortable, CollectionDisplay display)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4EA3E0", Offset = "0x4E8FE0", VA = "0x1804EA3E0")]
		public CollectionAttribute(Type enumType, bool sortable, CollectionDisplay display)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4EA3C0", Offset = "0x4E8FC0", VA = "0x1804EA3C0")]
		public CollectionAttribute(Delegate method)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4EA260", Offset = "0x4E8E60", VA = "0x1804EA260")]
		public CollectionAttribute(Delegate method, int size)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4EA230", Offset = "0x4E8E30", VA = "0x1804EA230")]
		public CollectionAttribute(Delegate method, bool sortable)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4EA6C0", Offset = "0x4E92C0", VA = "0x1804EA6C0")]
		public CollectionAttribute(Delegate method, CollectionDisplay display)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4EA4F0", Offset = "0x4E90F0", VA = "0x1804EA4F0")]
		public CollectionAttribute(Delegate method, int size, bool sortable, CollectionDisplay display)
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		private int size;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x14")]
		private bool sortable;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private CollectionDisplay display;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x1C")]
		private int maxDisplayedItems;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		private int maxItemsPerRow;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x24")]
		private bool alwaysExpanded;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x25")]
		private bool expandElements;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x28")]
		private Type enumType;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x30")]
		private string methodName;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x38")]
		private List<Delegate> delegates;

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000054 RID: 84
		[Token(Token = "0x200000B")]
		public delegate string[] CollectionDelegate();

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000058 RID: 88
		[Token(Token = "0x200000C")]
		public delegate string[] CollectionStaticDelegate(CollectionAttribute collection, object instance, object value);
	}
}
