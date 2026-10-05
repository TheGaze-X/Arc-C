using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedInspector
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class GroupAttribute : Attribute
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public string Name
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public string Description
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public string Style
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public int Priority
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public bool Expandable
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x4EF620", Offset = "0x4EE220", VA = "0x1804EF620")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public Color Color
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x4ED6A0", Offset = "0x4EC2A0", VA = "0x1804ED6A0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x4EEA20", Offset = "0x4ED620", VA = "0x1804EEA20")]
			set
			{
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4EF130", Offset = "0x4EDD30", VA = "0x1804EF130")]
		public GroupAttribute(string name)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4EF440", Offset = "0x4EE040", VA = "0x1804EF440")]
		public GroupAttribute(string name, int priority)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4EF420", Offset = "0x4EE020", VA = "0x1804EF420")]
		public GroupAttribute(string name, string style)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4EF560", Offset = "0x4EE160", VA = "0x1804EF560")]
		public GroupAttribute(string name, float r, float g, float b)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4EF090", Offset = "0x4EDC90", VA = "0x1804EF090")]
		public GroupAttribute(string name, float r, float g, float b, float a)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4EF390", Offset = "0x4EDF90", VA = "0x1804EF390")]
		public GroupAttribute(string name, string style, int priority)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4EEFE0", Offset = "0x4EDBE0", VA = "0x1804EEFE0")]
		public GroupAttribute(string name, string style, float r, float g, float b)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4EEF30", Offset = "0x4EDB30", VA = "0x1804EEF30")]
		public GroupAttribute(string name, string style, float r, float g, float b, float a)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4EF4B0", Offset = "0x4EE0B0", VA = "0x1804EF4B0")]
		public GroupAttribute(string name, string style, int priority, float r, float g, float b)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4EF190", Offset = "0x4EDD90", VA = "0x1804EF190")]
		public GroupAttribute(string name, string style, int priority, float r, float g, float b, float a)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4EF240", Offset = "0x4EDE40", VA = "0x1804EF240")]
		public GroupAttribute(string name, string description, string style, int priority, float r, float g, float b, float a)
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		private string description;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		private string style;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x28")]
		private int priority;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x2C")]
		private bool expandable;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x30")]
		private Color color;
	}
}
