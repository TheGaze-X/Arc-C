using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public class PreviewFieldAttribute : Attribute
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public ObjectFieldAlignment Alignment
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return ObjectFieldAlignment.Left;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x4E19420", Offset = "0x4E18020", VA = "0x184E19420")]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x17000038")]
		public bool AlignmentHasValue
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public string PreviewGetter
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x4E19430", Offset = "0x4E18030", VA = "0x184E19430")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002448 File Offset: 0x00000648
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public bool PreviewGetterHasValue
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4E191C0", Offset = "0x4E17DC0", VA = "0x184E191C0")]
		public PreviewFieldAttribute()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x4E19390", Offset = "0x4E17F90", VA = "0x184E19390")]
		public PreviewFieldAttribute(float height)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4E19340", Offset = "0x4E17F40", VA = "0x184E19340")]
		public PreviewFieldAttribute(string previewGetter, FilterMode filterMode = FilterMode.Bilinear)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x4E191F0", Offset = "0x4E17DF0", VA = "0x184E191F0")]
		public PreviewFieldAttribute(string previewGetter, float height, FilterMode filterMode = FilterMode.Bilinear)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x4E19250", Offset = "0x4E17E50", VA = "0x184E19250")]
		public PreviewFieldAttribute(float height, ObjectFieldAlignment alignment)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x4E193C0", Offset = "0x4E17FC0", VA = "0x184E193C0")]
		public PreviewFieldAttribute(string previewGetter, ObjectFieldAlignment alignment, FilterMode filterMode = FilterMode.Bilinear)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4E192D0", Offset = "0x4E17ED0", VA = "0x184E192D0")]
		public PreviewFieldAttribute(string previewGetter, float height, ObjectFieldAlignment alignment, FilterMode filterMode = FilterMode.Bilinear)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4E192A0", Offset = "0x4E17EA0", VA = "0x184E192A0")]
		public PreviewFieldAttribute(ObjectFieldAlignment alignment)
		{
		}

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x10")]
		private ObjectFieldAlignment alignment;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x14")]
		private bool alignmentHasValue;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x18")]
		private string previewGetter;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x20")]
		public float Height;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x24")]
		public FilterMode FilterMode;
	}
}
