using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200605C RID: 24668
	[Token(Token = "0x200605C")]
	public class CarvingMainCardMaterialItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023AB1 RID: 146097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AB1")]
		[Address(RVA = "0x1E4C510", Offset = "0x1E4B110", VA = "0x181E4C510")]
		public void Render(CarvingMainCardMaterialViewModel matModel)
		{
		}

		// Token: 0x06023AB2 RID: 146098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AB2")]
		[Address(RVA = "0x1E4C6C0", Offset = "0x1E4B2C0", VA = "0x181E4C6C0")]
		public CarvingMainCardMaterialItemView()
		{
		}

		// Token: 0x040316AF RID: 202415
		[Token(Token = "0x40316AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _materialRating;

		// Token: 0x040316B0 RID: 202416
		[Token(Token = "0x40316B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _materialIcon;

		// Token: 0x040316B1 RID: 202417
		[Token(Token = "0x40316B1")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040316B2 RID: 202418
		[Token(Token = "0x40316B2")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedIconId;

		// Token: 0x040316B3 RID: 202419
		[Token(Token = "0x40316B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040316B4 RID: 202420
		[Token(Token = "0x40316B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
