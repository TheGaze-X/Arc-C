using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Page
{
	// Token: 0x02005A5B RID: 23131
	[Token(Token = "0x2005A5B")]
	[CreateAssetMenu(menuName = "Torappu/UI/DynPageHub")]
	[Serializable]
	public class UIDynamicPageHub : ScriptableObject, ISerializationCallbackReceiver
	{
		// Token: 0x17004EFF RID: 20223
		// (get) Token: 0x06021A99 RID: 137881 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021A9A RID: 137882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EFF")]
		private UIPage[] _dragPagesHere
		{
			[Token(Token = "0x6021A99")]
			[Address(RVA = "0x1C2D500", Offset = "0x1C2C100", VA = "0x181C2D500")]
			get
			{
				return null;
			}
			[Token(Token = "0x6021A9A")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17004F00 RID: 20224
		// (get) Token: 0x06021A9B RID: 137883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F00")]
		public List<UIDynamicPageHub.PageUrl> pageUrls
		{
			[Token(Token = "0x6021A9B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021A9C RID: 137884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A9C")]
		[Address(RVA = "0x1C2D320", Offset = "0x1C2BF20", VA = "0x181C2D320", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06021A9D RID: 137885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A9D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06021A9E RID: 137886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A9E")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public UIDynamicPageHub()
		{
		}

		// Token: 0x0402E062 RID: 188514
		[Token(Token = "0x402E062")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIDynamicPageHub.PageUrl> _pages;

		// Token: 0x02005A5C RID: 23132
		[Token(Token = "0x2005A5C")]
		[Serializable]
		public struct PageUrl
		{
			// Token: 0x0402E063 RID: 188515
			[Token(Token = "0x402E063")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0402E064 RID: 188516
			[Token(Token = "0x402E064")]
			[FieldOffset(Offset = "0x8")]
			public string resPath;
		}
	}
}
