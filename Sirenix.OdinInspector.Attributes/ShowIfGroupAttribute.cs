using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[Conditional("UNITY_EDITOR")]
	public class ShowIfGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		public bool Animate
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the Condition member instead.", false)]
		public string MemberName
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x4E185B0", Offset = "0x4E171B0", VA = "0x184E185B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public string Condition
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x4E185B0", Offset = "0x4E171B0", VA = "0x184E185B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x4E18450", Offset = "0x4E17050", VA = "0x184E18450")]
		public ShowIfGroupAttribute(string path, bool animate = true)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x4E184F0", Offset = "0x4E170F0", VA = "0x184E184F0")]
		public ShowIfGroupAttribute(string path, object value, bool animate = true)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x4E1AFC0", Offset = "0x4E19BC0", VA = "0x184E1AFC0", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x38")]
		public object Value;
	}
}
