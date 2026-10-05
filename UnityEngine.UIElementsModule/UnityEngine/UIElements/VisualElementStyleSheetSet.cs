using System;
using System.Reflection;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[DefaultMember("Item")]
	public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet>
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
		internal VisualElementStyleSheetSet(VisualElement element)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x5AA15B0", Offset = "0x5AA01B0", VA = "0x185AA15B0")]
		public void Add(StyleSheet styleSheet)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x5AA17F0", Offset = "0x5AA03F0", VA = "0x185AA17F0")]
		public bool Remove(StyleSheet styleSheet)
		{
			return default(bool);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x5A2D650", Offset = "0x5A2C250", VA = "0x185A2D650", Slot = "4")]
		public bool Equals(VisualElementStyleSheetSet other)
		{
			return default(bool);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x5AA1760", Offset = "0x5AA0360", VA = "0x185AA1760", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x5A2D6F0", Offset = "0x5A2C2F0", VA = "0x185A2D6F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x0")]
		private readonly VisualElement m_Element;
	}
}
