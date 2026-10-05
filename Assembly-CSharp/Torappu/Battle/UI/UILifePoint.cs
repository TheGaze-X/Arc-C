using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200338C RID: 13196
	[Token(Token = "0x200338C")]
	public class UILifePoint : MonoBehaviour, IHotfixable
	{
		// Token: 0x060150A6 RID: 86182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150A6")]
		[Address(RVA = "0xD78D80", Offset = "0xD77980", VA = "0x180D78D80")]
		public void SetData(int lifePoint)
		{
		}

		// Token: 0x060150A7 RID: 86183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150A7")]
		[Address(RVA = "0xD78F30", Offset = "0xD77B30", VA = "0x180D78F30")]
		public void UpdateData(int lifePoint)
		{
		}

		// Token: 0x060150A8 RID: 86184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150A8")]
		[Address(RVA = "0xD78C60", Offset = "0xD77860", VA = "0x180D78C60")]
		private void OnDestroy()
		{
		}

		// Token: 0x060150A9 RID: 86185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150A9")]
		[Address(RVA = "0xD791E0", Offset = "0xD77DE0", VA = "0x180D791E0")]
		public UILifePoint()
		{
		}

		// Token: 0x040190B2 RID: 102578
		[Token(Token = "0x40190B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _lifePointLabel;

		// Token: 0x040190B3 RID: 102579
		[Token(Token = "0x40190B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _tweenTime;

		// Token: 0x040190B4 RID: 102580
		[Token(Token = "0x40190B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image[] _images;

		// Token: 0x040190B5 RID: 102581
		[Token(Token = "0x40190B5")]
		[FieldOffset(Offset = "0x30")]
		private int m_lifePoint;

		// Token: 0x040190B6 RID: 102582
		[Token(Token = "0x40190B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040190B7 RID: 102583
		[Token(Token = "0x40190B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040190B8 RID: 102584
		[Token(Token = "0x40190B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040190B9 RID: 102585
		[Token(Token = "0x40190B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
