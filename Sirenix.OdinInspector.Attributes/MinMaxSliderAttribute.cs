using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class MinMaxSliderAttribute : Attribute
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the MinValueGetter member instead.", false)]
		public string MinMember
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		[Obsolete("Use the MaxValueGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MaxMember
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the MinMaxValueGetter member instead.", false)]
		public string MinMaxMember
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4E18E30", Offset = "0x4E17A30", VA = "0x184E18E30")]
		public MinMaxSliderAttribute(float minValue, float maxValue, bool showFields = false)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4E18DD0", Offset = "0x4E179D0", VA = "0x184E18DD0")]
		public MinMaxSliderAttribute(string minValueGetter, float maxValue, bool showFields = false)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4E18F30", Offset = "0x4E17B30", VA = "0x184E18F30")]
		public MinMaxSliderAttribute(float minValue, string maxValueGetter, bool showFields = false)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4E18E80", Offset = "0x4E17A80", VA = "0x184E18E80")]
		public MinMaxSliderAttribute(string minValueGetter, string maxValueGetter, bool showFields = false)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4E18EE0", Offset = "0x4E17AE0", VA = "0x184E18EE0")]
		public MinMaxSliderAttribute(string minMaxValueGetter, bool showFields = false)
		{
		}

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x10")]
		public float MinValue;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x14")]
		public float MaxValue;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x18")]
		public string MinValueGetter;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x20")]
		public string MaxValueGetter;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x28")]
		public string MinMaxValueGetter;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x30")]
		public bool ShowFields;
	}
}
