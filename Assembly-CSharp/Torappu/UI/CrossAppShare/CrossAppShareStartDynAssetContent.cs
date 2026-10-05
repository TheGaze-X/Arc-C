using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x02005901 RID: 22785
	[Token(Token = "0x2005901")]
	public class CrossAppShareStartDynAssetContent : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004DF0 RID: 19952
		// (get) Token: 0x0602134D RID: 136013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602134E RID: 136014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DF0")]
		public CrossAppShareDynAssetBaseModel dynAssetModel
		{
			[Token(Token = "0x602134D")]
			[Address(RVA = "0x1B78F20", Offset = "0x1B77B20", VA = "0x181B78F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x602134E")]
			[Address(RVA = "0x1B78F80", Offset = "0x1B77B80", VA = "0x181B78F80")]
			set
			{
			}
		}

		// Token: 0x0602134F RID: 136015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602134F")]
		[Address(RVA = "0x1B78EC0", Offset = "0x1B77AC0", VA = "0x181B78EC0")]
		public CrossAppShareStartDynAssetContent()
		{
		}

		// Token: 0x0402D3B4 RID: 185268
		[Token(Token = "0x402D3B4")]
		[FieldOffset(Offset = "0x18")]
		private CrossAppShareDynAssetBaseModel m_dynAssetModel;

		// Token: 0x0402D3B5 RID: 185269
		[Token(Token = "0x402D3B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dynAssetModel;

		// Token: 0x0402D3B6 RID: 185270
		[Token(Token = "0x402D3B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dynAssetModel;

		// Token: 0x0402D3B7 RID: 185271
		[Token(Token = "0x402D3B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
