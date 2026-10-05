using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200764E RID: 30286
	[Token(Token = "0x200764E")]
	public class Act20sideCarObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A9B2 RID: 174514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A9B2")]
		[Address(RVA = "0x2652420", Offset = "0x2651020", VA = "0x182652420")]
		private UIAtlasObject _EnsureAtlasObject()
		{
			return null;
		}

		// Token: 0x0602A9B3 RID: 174515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9B3")]
		[Address(RVA = "0x2652010", Offset = "0x2650C10", VA = "0x182652010")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602A9B4 RID: 174516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9B4")]
		[Address(RVA = "0x2652C30", Offset = "0x2651830", VA = "0x182652C30")]
		private void _UnloadCart()
		{
		}

		// Token: 0x0602A9B5 RID: 174517 RVA: 0x000D93E0 File Offset: 0x000D75E0
		[Token(Token = "0x602A9B5")]
		[Address(RVA = "0x2652540", Offset = "0x2651140", VA = "0x182652540")]
		private SpriteRenderData _GetSpriteCart(string compId, CartComponents.CartAccessoryPos pos)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602A9B6 RID: 174518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9B6")]
		[Address(RVA = "0x2652160", Offset = "0x2650D60", VA = "0x182652160")]
		public void RenderCart(Dictionary<CartComponents.CartAccessoryPos, CartCompViewModel> cartDetail, string pageName)
		{
		}

		// Token: 0x0602A9B7 RID: 174519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9B7")]
		[Address(RVA = "0x2652380", Offset = "0x2650F80", VA = "0x182652380")]
		public void RenderCart(PlayerCartInfo.Cart car, string pageName)
		{
		}

		// Token: 0x0602A9B8 RID: 174520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9B8")]
		[Address(RVA = "0x26527B0", Offset = "0x26513B0", VA = "0x1826527B0")]
		private void _RenderCart(Dictionary<CartComponents.CartAccessoryPos, string> car, string pageName)
		{
		}

		// Token: 0x0602A9B9 RID: 174521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9B9")]
		[Address(RVA = "0x2652D40", Offset = "0x2651940", VA = "0x182652D40")]
		public Act20sideCarObject()
		{
		}

		// Token: 0x0403D587 RID: 251271
		[Token(Token = "0x403D587")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _roofImg;

		// Token: 0x0403D588 RID: 251272
		[Token(Token = "0x403D588")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _headStockImg;

		// Token: 0x0403D589 RID: 251273
		[Token(Token = "0x403D589")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _trunk1;

		// Token: 0x0403D58A RID: 251274
		[Token(Token = "0x403D58A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _trunk2;

		// Token: 0x0403D58B RID: 251275
		[Token(Token = "0x403D58B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _carFrame;

		// Token: 0x0403D58C RID: 251276
		[Token(Token = "0x403D58C")]
		[FieldOffset(Offset = "0x40")]
		private string m_cacheFrameId;

		// Token: 0x0403D58D RID: 251277
		[Token(Token = "0x403D58D")]
		[FieldOffset(Offset = "0x48")]
		private UIAtlasObject m_atlasObject;

		// Token: 0x0403D58E RID: 251278
		[Token(Token = "0x403D58E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureAtlasObject;

		// Token: 0x0403D58F RID: 251279
		[Token(Token = "0x403D58F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403D590 RID: 251280
		[Token(Token = "0x403D590")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UnloadCart;

		// Token: 0x0403D591 RID: 251281
		[Token(Token = "0x403D591")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetSpriteCart;

		// Token: 0x0403D592 RID: 251282
		[Token(Token = "0x403D592")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderCart;

		// Token: 0x0403D593 RID: 251283
		[Token(Token = "0x403D593")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_RenderCart;

		// Token: 0x0403D594 RID: 251284
		[Token(Token = "0x403D594")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderCart;

		// Token: 0x0403D595 RID: 251285
		[Token(Token = "0x403D595")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
