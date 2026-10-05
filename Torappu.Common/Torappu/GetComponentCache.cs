using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	public class GetComponentCache : IHotfixable
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x54FDED0", Offset = "0x54FCAD0", VA = "0x1854FDED0")]
		public Component GetComponent(GameObject gameObject, Type componentType, out bool isNewlyFound)
		{
			return null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000473")]
		public T GetComponent<T>(GameObject gameObject, out bool isNewlyFound) where T : Component
		{
			return null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x54FDE40", Offset = "0x54FCA40", VA = "0x1854FDE40")]
		public void ClearCache()
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x54FE0C0", Offset = "0x54FCCC0", VA = "0x1854FE0C0")]
		public GetComponentCache()
		{
		}

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x10")]
		private GameObject m_cachedGameObject;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, Component> m_componentCache;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate56 __Hotfix0_GetComponent;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ClearCache;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
