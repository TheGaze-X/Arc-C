using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A7C RID: 31356
	[Token(Token = "0x2007A7C")]
	public class CharmHole : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BEB9 RID: 179897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEB9")]
		[Address(RVA = "0x27D4230", Offset = "0x27D2E30", VA = "0x1827D4230")]
		public void Flush(CharmItemData charmData)
		{
		}

		// Token: 0x0602BEBA RID: 179898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEBA")]
		[Address(RVA = "0x27D44A0", Offset = "0x27D30A0", VA = "0x1827D44A0")]
		public void SetIdx(int idx)
		{
		}

		// Token: 0x0602BEBB RID: 179899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEBB")]
		[Address(RVA = "0x27D41C0", Offset = "0x27D2DC0", VA = "0x1827D41C0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602BEBC RID: 179900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEBC")]
		[Address(RVA = "0x27D4570", Offset = "0x27D3170", VA = "0x1827D4570")]
		public CharmHole()
		{
		}

		// Token: 0x0403F9CD RID: 260557
		[Token(Token = "0x403F9CD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _empty;

		// Token: 0x0403F9CE RID: 260558
		[Token(Token = "0x403F9CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _content;

		// Token: 0x0403F9CF RID: 260559
		[Token(Token = "0x403F9CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _num;

		// Token: 0x0403F9D0 RID: 260560
		[Token(Token = "0x403F9D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite[] _numSprites;

		// Token: 0x0403F9D1 RID: 260561
		[Token(Token = "0x403F9D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403F9D2 RID: 260562
		[Token(Token = "0x403F9D2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _rarities;

		// Token: 0x0403F9D3 RID: 260563
		[Token(Token = "0x403F9D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403F9D4 RID: 260564
		[Token(Token = "0x403F9D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403F9D5 RID: 260565
		[Token(Token = "0x403F9D5")]
		[FieldOffset(Offset = "0x58")]
		private int m_idx;

		// Token: 0x0403F9D6 RID: 260566
		[Token(Token = "0x403F9D6")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Action<int> onClick;

		// Token: 0x0403F9D7 RID: 260567
		[Token(Token = "0x403F9D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x0403F9D8 RID: 260568
		[Token(Token = "0x403F9D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetIdx;

		// Token: 0x0403F9D9 RID: 260569
		[Token(Token = "0x403F9D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403F9DA RID: 260570
		[Token(Token = "0x403F9DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
