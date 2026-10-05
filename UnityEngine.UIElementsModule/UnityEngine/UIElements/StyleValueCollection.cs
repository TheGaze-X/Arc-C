using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000223")]
	internal class StyleValueCollection
	{
		// Token: 0x06000F0C RID: 3852 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x5B13060", Offset = "0x5B11C60", VA = "0x185B13060")]
		public StyleLength GetStyleLength(StylePropertyId id)
		{
			return default(StyleLength);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x5B12F80", Offset = "0x5B11B80", VA = "0x185B12F80")]
		public StyleFloat GetStyleFloat(StylePropertyId id)
		{
			return default(StyleFloat);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x5B12FF0", Offset = "0x5B11BF0", VA = "0x185B12FF0")]
		public StyleInt GetStyleInt(StylePropertyId id)
		{
			return default(StyleInt);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x5B132E0", Offset = "0x5B11EE0", VA = "0x185B132E0")]
		public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value)
		{
			return default(bool);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x5B13100", Offset = "0x5B11D00", VA = "0x185B13100")]
		public void SetStyleValue(StyleValue value)
		{
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x5B13430", Offset = "0x5B12030", VA = "0x185B13430")]
		public StyleValueCollection()
		{
		}

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x10")]
		internal List<StyleValue> m_Values;
	}
}
