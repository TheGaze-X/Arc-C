using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedInspector
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	public class DescriptorAttribute : Attribute, IRuntimeAttribute, IDescriptor
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public string Name
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public string Comment
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public string URL
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public Texture Icon
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public Color Color
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x4ED6A0", Offset = "0x4EC2A0", VA = "0x1804ED6A0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x4EEA20", Offset = "0x4ED620", VA = "0x1804EEA20")]
			set
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4ED6B0", Offset = "0x4EC2B0", VA = "0x1804ED6B0", Slot = "12")]
		public Description GetDescription(object[] instances, object[] values)
		{
			return null;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000020")]
		public string MethodName
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000021")]
		public Type Template
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x4EE9C0", Offset = "0x4ED5C0", VA = "0x1804EE9C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000022")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x4EE960", Offset = "0x4ED560", VA = "0x1804EE960", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4EE7E0", Offset = "0x4ED3E0", VA = "0x1804EE7E0")]
		public DescriptorAttribute()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4EE6B0", Offset = "0x4ED2B0", VA = "0x1804EE6B0")]
		public DescriptorAttribute(string name)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4EE460", Offset = "0x4ED060", VA = "0x1804EE460")]
		public DescriptorAttribute(float r, float g, float b)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4EE070", Offset = "0x4ECC70", VA = "0x1804EE070")]
		public DescriptorAttribute(string name, string description)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x4EE0F0", Offset = "0x4ECCF0", VA = "0x1804EE0F0")]
		public DescriptorAttribute(string name, string description, string url)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4EE8E0", Offset = "0x4ED4E0", VA = "0x1804EE8E0")]
		public DescriptorAttribute(string name, string description, string url, float r, float g, float b)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4EE500", Offset = "0x4ED100", VA = "0x1804EE500")]
		private DescriptorAttribute(string name, string description, string url, float r, float g, float b, float a)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4EE2A0", Offset = "0x4ECEA0", VA = "0x1804EE2A0")]
		public DescriptorAttribute(string name, string description, Texture icon)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4EE130", Offset = "0x4ECD30", VA = "0x1804EE130")]
		public DescriptorAttribute(string name, string description, Texture icon, Color color)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4EDB50", Offset = "0x4EC750", VA = "0x1804EDB50")]
		public static Description GetDescriptor(Type type)
		{
			return null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4EDCF0", Offset = "0x4EC8F0", VA = "0x1804EDCF0")]
		public static List<Description> GetDescriptors(List<Type> types)
		{
			return null;
		}

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		private static Color TRANSPARENT;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		private string comment;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		private string url;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x28")]
		private Texture icon;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x30")]
		private Color color;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x40")]
		private string methodName;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x48")]
		private List<Delegate> delegates;

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600008C RID: 140
		[Token(Token = "0x2000012")]
		public delegate Description DescriptorDelegate();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000090 RID: 144
		[Token(Token = "0x2000013")]
		public delegate Description DescriptorStaticDelegate(DescriptorAttribute descriptor, object instance, object value);
	}
}
