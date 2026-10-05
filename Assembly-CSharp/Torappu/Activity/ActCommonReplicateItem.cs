using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D8F RID: 28047
	[Token(Token = "0x2006D8F")]
	public class ActCommonReplicateItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027F39 RID: 163641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F39")]
		[Address(RVA = "0x2331FB0", Offset = "0x2330BB0", VA = "0x182331FB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027F3A RID: 163642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F3A")]
		[Address(RVA = "0x2331C30", Offset = "0x2330830", VA = "0x182331C30")]
		public void Render(ReplicateData data, bool isLast)
		{
		}

		// Token: 0x06027F3B RID: 163643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F3B")]
		[Address(RVA = "0x23322A0", Offset = "0x2330EA0", VA = "0x1823322A0")]
		private IEnumerator _TryEnableTextSlide()
		{
			return null;
		}

		// Token: 0x06027F3C RID: 163644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F3C")]
		[Address(RVA = "0x2331F20", Offset = "0x2330B20", VA = "0x182331F20")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x06027F3D RID: 163645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F3D")]
		[Address(RVA = "0x2331BD0", Offset = "0x23307D0", VA = "0x182331BD0")]
		private void OnDisable()
		{
		}

		// Token: 0x06027F3E RID: 163646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F3E")]
		[Address(RVA = "0x2332350", Offset = "0x2330F50", VA = "0x182332350")]
		public ActCommonReplicateItem()
		{
		}

		// Token: 0x040389E9 RID: 231913
		[Token(Token = "0x40389E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer1;

		// Token: 0x040389EA RID: 231914
		[Token(Token = "0x40389EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer2;

		// Token: 0x040389EB RID: 231915
		[Token(Token = "0x40389EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lastIgnoreObj;

		// Token: 0x040389EC RID: 231916
		[Token(Token = "0x40389EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _itemNameGo;

		// Token: 0x040389ED RID: 231917
		[Token(Token = "0x40389ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x040389EE RID: 231918
		[Token(Token = "0x40389EE")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isInited;

		// Token: 0x040389EF RID: 231919
		[Token(Token = "0x40389EF")]
		[FieldOffset(Offset = "0x40")]
		private UIItemCard m_itemCard1;

		// Token: 0x040389F0 RID: 231920
		[Token(Token = "0x40389F0")]
		[FieldOffset(Offset = "0x48")]
		private UIItemCard m_itemCard2;

		// Token: 0x040389F1 RID: 231921
		[Token(Token = "0x40389F1")]
		[FieldOffset(Offset = "0x50")]
		private Text m_text_name1;

		// Token: 0x040389F2 RID: 231922
		[Token(Token = "0x40389F2")]
		[FieldOffset(Offset = "0x58")]
		private UIAutoSlideRect m_slideName1;

		// Token: 0x040389F3 RID: 231923
		[Token(Token = "0x40389F3")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine m_slideCoroutine;

		// Token: 0x040389F4 RID: 231924
		[Token(Token = "0x40389F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040389F5 RID: 231925
		[Token(Token = "0x40389F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040389F6 RID: 231926
		[Token(Token = "0x40389F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryEnableTextSlide;

		// Token: 0x040389F7 RID: 231927
		[Token(Token = "0x40389F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x040389F8 RID: 231928
		[Token(Token = "0x40389F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x040389F9 RID: 231929
		[Token(Token = "0x40389F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
