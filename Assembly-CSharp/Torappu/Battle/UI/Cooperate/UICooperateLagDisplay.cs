using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003418 RID: 13336
	[Token(Token = "0x2003418")]
	public class UICooperateLagDisplay : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015506 RID: 87302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015506")]
		[Address(RVA = "0xDD7820", Offset = "0xDD6420", VA = "0x180DD7820")]
		public void UpdateData(int lag)
		{
		}

		// Token: 0x06015507 RID: 87303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015507")]
		[Address(RVA = "0xDD7A30", Offset = "0xDD6630", VA = "0x180DD7A30")]
		public UICooperateLagDisplay()
		{
		}

		// Token: 0x040197B2 RID: 104370
		[Token(Token = "0x40197B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Collection(typeof(UICooperateLagDisplay.StatusStyle), Sortable = false)]
		private UICooperateLagDisplay.LagStatus[] _statusLevels;

		// Token: 0x040197B3 RID: 104371
		[Token(Token = "0x40197B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _background;

		// Token: 0x040197B4 RID: 104372
		[Token(Token = "0x40197B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _lagText;

		// Token: 0x040197B5 RID: 104373
		[Token(Token = "0x40197B5")]
		[FieldOffset(Offset = "0x30")]
		private int m_preLag;

		// Token: 0x040197B6 RID: 104374
		[Token(Token = "0x40197B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040197B7 RID: 104375
		[Token(Token = "0x40197B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003419 RID: 13337
		[Token(Token = "0x2003419")]
		[Serializable]
		private struct LagStatus
		{
			// Token: 0x06015508 RID: 87304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015508")]
			[Address(RVA = "0xDD17F0", Offset = "0xDD03F0", VA = "0x180DD17F0")]
			public LagStatus(int threshold, Color color)
			{
			}

			// Token: 0x040197B8 RID: 104376
			[Token(Token = "0x40197B8")]
			[FieldOffset(Offset = "0x0")]
			public int threshold;

			// Token: 0x040197B9 RID: 104377
			[Token(Token = "0x40197B9")]
			[FieldOffset(Offset = "0x4")]
			public Color color;
		}

		// Token: 0x0200341A RID: 13338
		[Token(Token = "0x200341A")]
		private enum StatusStyle
		{
			// Token: 0x040197BB RID: 104379
			[Token(Token = "0x40197BB")]
			BAD,
			// Token: 0x040197BC RID: 104380
			[Token(Token = "0x40197BC")]
			NORMAL,
			// Token: 0x040197BD RID: 104381
			[Token(Token = "0x40197BD")]
			GOOD
		}
	}
}
