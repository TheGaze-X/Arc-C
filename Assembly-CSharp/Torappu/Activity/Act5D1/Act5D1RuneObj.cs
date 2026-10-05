using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007236 RID: 29238
	[Token(Token = "0x2007236")]
	public class Act5D1RuneObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296E8 RID: 169704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296E8")]
		[Address(RVA = "0x24C94A0", Offset = "0x24C80A0", VA = "0x1824C94A0")]
		public void SetRune(RuneInfo infoObj)
		{
		}

		// Token: 0x060296E9 RID: 169705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296E9")]
		[Address(RVA = "0x24C9260", Offset = "0x24C7E60", VA = "0x1824C9260")]
		public void SetRuneOnlyForShow(RuneInfo infoObj)
		{
		}

		// Token: 0x060296EA RID: 169706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296EA")]
		[Address(RVA = "0x24C9930", Offset = "0x24C8530", VA = "0x1824C9930")]
		private void _ShowTransitionFirst()
		{
		}

		// Token: 0x060296EB RID: 169707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296EB")]
		[Address(RVA = "0x24C9A70", Offset = "0x24C8670", VA = "0x1824C9A70")]
		private void _ShowTransitionSecond(float delay = 0f)
		{
		}

		// Token: 0x060296EC RID: 169708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296EC")]
		[Address(RVA = "0x24C98A0", Offset = "0x24C84A0", VA = "0x1824C98A0")]
		private void _ResetTween()
		{
		}

		// Token: 0x060296ED RID: 169709 RVA: 0x000D5AB0 File Offset: 0x000D3CB0
		[Token(Token = "0x60296ED")]
		[Address(RVA = "0x24C9650", Offset = "0x24C8250", VA = "0x1824C9650")]
		private bool _RenderOnlyForShow(RuneInfo infoObj)
		{
			return default(bool);
		}

		// Token: 0x060296EE RID: 169710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296EE")]
		[Address(RVA = "0x24C9200", Offset = "0x24C7E00", VA = "0x1824C9200")]
		private void OnDestroy()
		{
		}

		// Token: 0x060296EF RID: 169711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296EF")]
		[Address(RVA = "0x24C9170", Offset = "0x24C7D70", VA = "0x1824C9170")]
		public void OnClick()
		{
		}

		// Token: 0x060296F0 RID: 169712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296F0")]
		[Address(RVA = "0x24C9BE0", Offset = "0x24C87E0", VA = "0x1824C9BE0")]
		public Act5D1RuneObj()
		{
		}

		// Token: 0x0403B2FC RID: 242428
		[Token(Token = "0x403B2FC")]
		private const float FADE_DUR = 0.16f;

		// Token: 0x0403B2FD RID: 242429
		[Token(Token = "0x403B2FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _point;

		// Token: 0x0403B2FE RID: 242430
		[Token(Token = "0x403B2FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hasPoint;

		// Token: 0x0403B2FF RID: 242431
		[Token(Token = "0x403B2FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _noPoint;

		// Token: 0x0403B300 RID: 242432
		[Token(Token = "0x403B300")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _runeImg;

		// Token: 0x0403B301 RID: 242433
		[Token(Token = "0x403B301")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockedObj;

		// Token: 0x0403B302 RID: 242434
		[Token(Token = "0x403B302")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _bannedObj;

		// Token: 0x0403B303 RID: 242435
		[Token(Token = "0x403B303")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectedObj;

		// Token: 0x0403B304 RID: 242436
		[Token(Token = "0x403B304")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _backImg;

		// Token: 0x0403B305 RID: 242437
		[Token(Token = "0x403B305")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0403B306 RID: 242438
		[Token(Token = "0x403B306")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public UIStringEvent onClickEvent;

		// Token: 0x0403B307 RID: 242439
		[Token(Token = "0x403B307")]
		[FieldOffset(Offset = "0x68")]
		private RuneInfo m_cacheInfoObj;

		// Token: 0x0403B308 RID: 242440
		[Token(Token = "0x403B308")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_showTween;

		// Token: 0x0403B309 RID: 242441
		[Token(Token = "0x403B309")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRune;

		// Token: 0x0403B30A RID: 242442
		[Token(Token = "0x403B30A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetRuneOnlyForShow;

		// Token: 0x0403B30B RID: 242443
		[Token(Token = "0x403B30B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowTransitionFirst;

		// Token: 0x0403B30C RID: 242444
		[Token(Token = "0x403B30C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowTransitionSecond;

		// Token: 0x0403B30D RID: 242445
		[Token(Token = "0x403B30D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetTween;

		// Token: 0x0403B30E RID: 242446
		[Token(Token = "0x403B30E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderOnlyForShow;

		// Token: 0x0403B30F RID: 242447
		[Token(Token = "0x403B30F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403B310 RID: 242448
		[Token(Token = "0x403B310")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B311 RID: 242449
		[Token(Token = "0x403B311")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
