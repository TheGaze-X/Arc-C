using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F64 RID: 28516
	[Token(Token = "0x2006F64")]
	public class ActMultiV3PhotoCharacter : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287D3 RID: 165843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D3")]
		[Address(RVA = "0x23CD900", Offset = "0x23CC500", VA = "0x1823CD900")]
		public void Render(ActMultiV3PhotoCharViewModel charModel, UIColorGraphic characterGraphic)
		{
		}

		// Token: 0x060287D4 RID: 165844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D4")]
		[Address(RVA = "0x23CDCE0", Offset = "0x23CC8E0", VA = "0x1823CDCE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287D5 RID: 165845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D5")]
		[Address(RVA = "0x23CDD60", Offset = "0x23CC960", VA = "0x1823CDD60")]
		public ActMultiV3PhotoCharacter()
		{
		}

		// Token: 0x040399D7 RID: 235991
		[Token(Token = "0x40399D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UISpineHolder _spineHolder;

		// Token: 0x040399D8 RID: 235992
		[Token(Token = "0x40399D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _shadowImage;

		// Token: 0x040399D9 RID: 235993
		[Token(Token = "0x40399D9")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x040399DA RID: 235994
		[Token(Token = "0x40399DA")]
		[FieldOffset(Offset = "0x30")]
		private UIBuildingSpineAdapter m_spineImpl;

		// Token: 0x040399DB RID: 235995
		[Token(Token = "0x40399DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040399DC RID: 235996
		[Token(Token = "0x40399DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040399DD RID: 235997
		[Token(Token = "0x40399DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
