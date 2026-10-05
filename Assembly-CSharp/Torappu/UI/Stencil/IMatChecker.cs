using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stencil
{
	// Token: 0x02005A4C RID: 23116
	[Token(Token = "0x2005A4C")]
	public interface IMatChecker
	{
		// Token: 0x06021A5F RID: 137823
		[Token(Token = "0x6021A5F")]
		bool CheckMaterialExclusive(Material mat, [Optional] List<Material> whiteList);
	}
}
