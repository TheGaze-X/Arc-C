using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C43 RID: 7235
	[Token(Token = "0x2001C43")]
	public class BuildingTradingRequireItemInfo : MonoBehaviour
	{
		// Token: 0x0600B426 RID: 46118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B426")]
		[Address(RVA = "0x32F7240", Offset = "0x32F5E40", VA = "0x1832F7240")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B427")]
		[Address(RVA = "0x32F72C0", Offset = "0x32F5EC0", VA = "0x1832F72C0")]
		public void Render(TradingOrderRequireStruct requireStruct)
		{
		}

		// Token: 0x0600B428 RID: 46120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B428")]
		[Address(RVA = "0x32F7430", Offset = "0x32F6030", VA = "0x1832F7430")]
		private IEnumerator _UpdateAutoLayoutsCoroutine()
		{
			return null;
		}

		// Token: 0x0600B429 RID: 46121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B429")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingTradingRequireItemInfo()
		{
		}

		// Token: 0x0400AFB8 RID: 44984
		[Token(Token = "0x400AFB8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _iconFinish;

		// Token: 0x0400AFB9 RID: 44985
		[Token(Token = "0x400AFB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurCount;

		// Token: 0x0400AFBA RID: 44986
		[Token(Token = "0x400AFBA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRequireCount;

		// Token: 0x0400AFBB RID: 44987
		[Token(Token = "0x400AFBB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panelLine;
	}
}
