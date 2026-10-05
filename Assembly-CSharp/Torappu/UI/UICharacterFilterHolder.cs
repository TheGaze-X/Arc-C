using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003524 RID: 13604
	[Token(Token = "0x2003524")]
	public abstract class UICharacterFilterHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015AF5 RID: 88821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AF5")]
		[Address(RVA = "0xE3CDD0", Offset = "0xE3B9D0", VA = "0x180E3CDD0")]
		protected void _ApplyFilter(ValueBundle val)
		{
		}

		// Token: 0x06015AF6 RID: 88822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015AF6")]
		public static T LoadPrefab<T>(string prefabPath, ILoadAsset assetLoader) where T : UICharacterFilterHolder
		{
			return null;
		}

		// Token: 0x06015AF7 RID: 88823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AF7")]
		[Address(RVA = "0xE3CF10", Offset = "0xE3BB10", VA = "0x180E3CF10")]
		protected UICharacterFilterHolder()
		{
		}

		// Token: 0x0401A093 RID: 106643
		[Token(Token = "0x401A093")]
		[FieldOffset(Offset = "0x18")]
		protected UICharacterFilterHolder.IFilterHandler m_filterHandler;

		// Token: 0x0401A094 RID: 106644
		[Token(Token = "0x401A094")]
		[FieldOffset(Offset = "0x20")]
		protected ILoadAsset m_assetLoader;

		// Token: 0x0401A095 RID: 106645
		[Token(Token = "0x401A095")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ApplyFilter;

		// Token: 0x0401A096 RID: 106646
		[Token(Token = "0x401A096")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadPrefab;

		// Token: 0x0401A097 RID: 106647
		[Token(Token = "0x401A097")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003525 RID: 13605
		[Token(Token = "0x2003525")]
		public interface IFilterHandler : IHotfixable
		{
			// Token: 0x06015AF8 RID: 88824
			[Token(Token = "0x6015AF8")]
			void OnApplyFilter(ValueBundle val);
		}
	}
}
