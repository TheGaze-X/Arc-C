using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	[RequireComponent(typeof(RawImage))]
	public class UIRawImageMatAnimWrapper : UIAbstractMatAnimWrapper, IMaterialModifier
	{
		// Token: 0x0600080E RID: 2062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x5547880", Offset = "0x5546480", VA = "0x185547880", Slot = "4")]
		public override Material GetMaterial()
		{
			return null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x5547930", Offset = "0x5546530", VA = "0x185547930", Slot = "6")]
		public Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x55477A0", Offset = "0x55463A0", VA = "0x1855477A0", Slot = "5")]
		public override void CleanMaterial()
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x5547B20", Offset = "0x5546720", VA = "0x185547B20")]
		public UIRawImageMatAnimWrapper()
		{
		}

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x368")]
		private int count;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x36C")]
		private int get;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x370")]
		private Material m_mat;

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x378")]
		private Material m_cacheBaseMaterial;

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate159 __Hotfix0_GetMaterial;

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate160 __Hotfix0_GetModifiedMaterial;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_CleanMaterial;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
