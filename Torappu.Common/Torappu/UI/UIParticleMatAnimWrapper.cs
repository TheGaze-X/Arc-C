using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	[RequireComponent(typeof(ParticleSystem))]
	public class UIParticleMatAnimWrapper : UIAbstractMatAnimWrapper
	{
		// Token: 0x0600080B RID: 2059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x5541600", Offset = "0x5540200", VA = "0x185541600", Slot = "4")]
		public override Material GetMaterial()
		{
			return null;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x55415A0", Offset = "0x55401A0", VA = "0x1855415A0", Slot = "5")]
		public override void CleanMaterial()
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x5541660", Offset = "0x5540260", VA = "0x185541660")]
		public UIParticleMatAnimWrapper()
		{
		}

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate159 __Hotfix0_GetMaterial;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_CleanMaterial;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
