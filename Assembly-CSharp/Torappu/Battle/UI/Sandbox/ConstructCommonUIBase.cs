using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033A1 RID: 13217
	[Token(Token = "0x20033A1")]
	public class ConstructCommonUIBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x06015168 RID: 86376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700320F")]
		protected ILoadAsset sharedAssetLoaderOrNull
		{
			[Token(Token = "0x6015168")]
			[Address(RVA = "0xD81E50", Offset = "0xD80A50", VA = "0x180D81E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015169 RID: 86377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015169")]
		[Address(RVA = "0xD81DF0", Offset = "0xD809F0", VA = "0x180D81DF0")]
		public ConstructCommonUIBase()
		{
		}

		// Token: 0x040191AE RID: 102830
		[Token(Token = "0x40191AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sharedAssetLoaderOrNull;

		// Token: 0x040191AF RID: 102831
		[Token(Token = "0x40191AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
